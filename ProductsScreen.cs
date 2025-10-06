using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;


namespace Biomarkt_GmbH
{
    public partial class ProductsScreen : Form
    {
        private SqlConnection databaseConnection = new SqlConnection(@"Data Source=DESKTOP-S85UG84\SQLEXPRESS;
        Initial Catalog=Biomarkt_DB;
        Integrated Security=True;
        TrustServerCertificate=True;  
        Connect Timeout=5");

        private int lastSelectedProductKey;

        public ProductsScreen()
        {

            InitializeComponent();
            //LoadProducts();  
            ShowProducts();

        }

        private void LoadProducts()
        {
            //try
            //{
            //    string query = "SELECT Id, Name, Brand, Category, Price FROM Products";

            //    SqlDataAdapter adapter = new SqlDataAdapter(query, databaseConnection);
            //    DataTable table = new DataTable();
            //    adapter.Fill(table);

            //    // Assuming you already added a DataGridView to the form (dataGridView1)
            //    productsDGV.DataSource = table;
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Error: " + ex.Message);
            //}
        }

        private void ShowProducts()
        {
            // start
            databaseConnection.Open();

            string query = "SELECT * FROM dbo.Products";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, databaseConnection);

            DataSet dataSet = new DataSet();
            sqlDataAdapter.Fill(dataSet);

            productsC.DataSource = dataSet.Tables[0];
            productsC.Columns[0].Visible = false;
            databaseConnection.Close();
        }

        private void BtnProductSave_Click(object sender, EventArgs e)
        {
            if (txtProductName.Text == ""
                || txtProductBrand.Text == ""
                || comboBoxProductCategory.Text == ""
                || txtProductPrice.Text == "")
            {
                MessageBox.Show("Bitte fülle alle Werte aus.");
                return;
            }

            string query = "INSERT INTO Products (Name, Brand, Category, Price) " +
               "VALUES (@Name, @Brand, @Category, @Price)";
            var parameters = new Dictionary<string, object>
            {
                { "@Name", txtProductName.Text },
                { "@Brand", txtProductBrand.Text },
                { "@Category", comboBoxProductCategory.Text },
                { "@Price", txtProductPrice.Text }
            };
            ExecuteQuery(query, parameters);

            ClearAllFields();
            ShowProducts();
        }

        private void BtnProductEdit_Click(object sender, EventArgs e)
        {
            if (lastSelectedProductKey == 0)
            {
                MessageBox.Show("Bitte wähle zuerst ein Pordukt aus.");
                return;
            }

            string query = @"UPDATE Products SET Name = @Name, Brand = @Brand, Category = @Category, Price = @Price WHERE Id = @Id";

            var parameters = new Dictionary<string, object>
            {
                { "@Name", txtProductName.Text },
                { "@Brand", txtProductBrand.Text },
                { "@Category", comboBoxProductCategory.Text },
                { "@Price", txtProductPrice.Text },
                { "@Id", lastSelectedProductKey }
            };

            ExecuteQuery(query, parameters);           
            ShowProducts();
        }

        private void BtnProductDelete_Click(object sender, EventArgs e)
        {
            if(lastSelectedProductKey == 0)
            {
                MessageBox.Show("Bitte wähle zuerst ein Pordukt aus.");
                return;
            }
            string query = "DELETE FROM Products WHERE Id = @Id";

            var parameters = new Dictionary<string, object>
            {
                { "@Id", lastSelectedProductKey }
            };

            ExecuteQuery(query, parameters);
            ClearAllFields();
            ShowProducts();
        }

        private void BtnProductClear_Click(object sender, EventArgs e)
        {
            ClearAllFields();
        }

        private void ClearAllFields()
        {
            txtProductName.Text = "";
            txtProductBrand.Text = "";
            txtProductPrice.Text = "";
            comboBoxProductCategory.Text = "";
            comboBoxProductCategory.SelectedItem = null;
        }

        private void ProductsDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtProductName.Text = productsC.SelectedRows[0].Cells[1].Value.ToString();
            txtProductBrand.Text = productsC.SelectedRows[0].Cells[2].Value.ToString();
            comboBoxProductCategory.Text = productsC.SelectedRows[0].Cells[3].Value.ToString();
            txtProductPrice.Text = productsC.SelectedRows[0].Cells[4].Value.ToString();

            lastSelectedProductKey = (int)productsC.SelectedRows[0].Cells[0].Value;            
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
    }
}
