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

            // start
            databaseConnection.Open();
            databaseConnection.Close();

        }


        private void BtnProductSave_Click(object sender, EventArgs e)
        {
            string productName = txtProductName.Text;
            
            // save product name in database


        }

        private void BtnProductEdit_Click(object sender, EventArgs e)
        {

        }

        private void BtnProductDelete_Click(object sender, EventArgs e)
        {

        }

        private void BtnProductClear_Click(object sender, EventArgs e)
        {

        }
    }
}
