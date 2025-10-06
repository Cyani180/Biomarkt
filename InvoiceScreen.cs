using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biomarkt_GmbH
{
    public partial class InvoiceScreen : Form
    {
        private SqlConnection databaseConnection = new SqlConnection(@"Data Source=DESKTOP-S85UG84\SQLEXPRESS;
        Initial Catalog=Biomarkt_DB;
        Integrated Security=True;
        TrustServerCertificate=True;  
        Connect Timeout=5");

        private int lastSelectedProductKey;

        public InvoiceScreen()
        {
            InitializeComponent();
            ShowInvoices();
        }

        private void ShowInvoices()
        {
            // start
            databaseConnection.Open();

            string query = "SELECT * FROM dbo.Invoices";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, databaseConnection);

            DataSet dataSet = new DataSet();
            sqlDataAdapter.Fill(dataSet);

            invoicesC.DataSource = dataSet.Tables[0];

            invoicesC.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            invoicesC.Columns["Name"].FillWeight = 160;
            invoicesC.Columns["Date"].FillWeight = 160;
            invoicesC.Columns["Invoice"].FillWeight = 70;

            invoicesC.Columns[0].Visible = false;
            databaseConnection.Close();
        }

        private void BtnInvoceSave_Click(object sender, EventArgs e)
        {
            string invoiceCustomerName = textInvoiceCustomerName.Text;

            if (textInvoiceCustomerName.Text == ""
               || dateTimePickerInvoice.Text == default
               || textTotalInvoice.Text == "")
            {
                MessageBox.Show("Bitte fülle alle Werte aus.");
                return;
            }

            string query = "INSERT INTO [dbo].[Invoices] ([Name], [Date], [Invoice]) VALUES (@Name, @Date, @Invoice)";
            var parameters = new Dictionary<string, object>
            {
                { "@Name", textInvoiceCustomerName.Text },
                { "@Date", dateTimePickerInvoice.Text },
                { "@Invoice", textTotalInvoice.Text }
            };
            ExecuteQuery(query, parameters);

            ClearAllFields();
            ShowInvoices();

        }

        private void BtnInvoiceEdit_Click(object sender, EventArgs e)
        {
            if (lastSelectedProductKey == 0)
            {
                MessageBox.Show("Bitte wähle sie eine Rechnung aus.");
                return;
            }

            string query = @"UPDATE [Invoices] SET Name = @Name, [Date] = @Date, [Invoice] = @Invoice WHERE Id = @Id";

            var parameters = new Dictionary<string, object>
            {
                { "@Name", textInvoiceCustomerName.Text },
                { "@Date", dateTimePickerInvoice.Text },
                { "@Invoice", textTotalInvoice.Text },
                { "@Id", lastSelectedProductKey }
            };

            ExecuteQuery(query, parameters);
            ShowInvoices();
        }

        private void BtnInvoiceDelete_Click(object sender, EventArgs e)
        {
            if (lastSelectedProductKey == 0)
            {
                MessageBox.Show("Bitte wähle sie eine Rechnung aus.");
                return;
            }
            string query = "DELETE FROM Invoices WHERE Id = @Id";

            var parameters = new Dictionary<string, object>
            {
                { "@Id", lastSelectedProductKey }
            };

            ExecuteQuery(query, parameters);
            ClearAllFields();
            ShowInvoices();
        }

        private void BtnInvoiceClear_Click(object sender, EventArgs e)
        {
            ClearAllFields();
        }

        private void ClearAllFields()
        {
            textInvoiceCustomerName.Text = "";
            dateTimePickerInvoice.Text = default;
            textTotalInvoice.Text = "";
        }

        private void ExecuteQuery(string query, Dictionary<string, object> parameters = null)
        {
            using (SqlCommand cmd = new SqlCommand(query, databaseConnection))
            {
                if (parameters != null)
                {
                    foreach (var param in parameters)
                    {
                        cmd.Parameters.AddWithValue(param.Key, param.Value ?? DBNull.Value);
                    }
                }

                databaseConnection.Open();
                cmd.ExecuteNonQuery();
                databaseConnection.Close();
            }
        }


        private void InvoicesC_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Nur wenn eine echte Zeile angeklickt wurde
            {
                // Ganze Zeile holen
                DataGridViewRow row = invoicesC.Rows[e.RowIndex];

                // Jetzt über Spaltennamen gehen
                textInvoiceCustomerName.Text = row.Cells["Name"].Value.ToString();
                dateTimePickerInvoice.Value = Convert.ToDateTime(row.Cells["Date"].Value);
                textTotalInvoice.Text = row.Cells["Invoice"].Value.ToString();
                lastSelectedProductKey = Convert.ToInt32(row.Cells["Id"].Value);
            }
        }
    }
}
