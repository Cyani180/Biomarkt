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
    public partial class ProductsScreen : Form
    {
        public ProductsScreen()
        {
            InitializeComponent();
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
