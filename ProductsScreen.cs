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

            productsDGV.DataSource = dataSet.Tables[0];

            productsDGV.Columns[0].Visible = false;

            databaseConnection.Close();
        }

        private void BtnProductSave_Click(object sender, EventArgs e)
        {
            if(txtProductName.Text == "" 
                || txtProductBrand.Text == ""
                || comboBoxProductCategory.Text == ""
                || txtProductPrice.Text == "")
            {
                MessageBox.Show("Bitte fülle alle Werte aus.");
                return;
            }

            // save product name in database
            string productName = txtProductName.Text;
            string productBrand = txtProductBrand.Text;
            string productCategory = comboBoxProductCategory.Text;
            string productPrice = txtProductPrice.Text;

            databaseConnection.Open();
            string query = string.Format("insert into Products values('{0}','{1}','{2}','{3}')", productName, productBrand, productCategory, productPrice);
            SqlCommand sqlCommand = new SqlCommand(query, databaseConnection);
            sqlCommand.ExecuteNonQuery();
            databaseConnection.Close();

            ClearAllFields();
            ShowProducts();
        }

        private void BtnProductEdit_Click(object sender, EventArgs e)
        {

            ShowProducts();
        }

        private void BtnProductDelete_Click(object sender, EventArgs e)
        {

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
    }
}
