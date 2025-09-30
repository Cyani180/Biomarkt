namespace Biomarkt_GmbH
{
    partial class ProductsScreen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductsScreen));
            label1 = new Label();
            txtProductName = new TextBox();
            txtProductBrand = new TextBox();
            label2 = new Label();
            label3 = new Label();
            txtProductPrice = new TextBox();
            label4 = new Label();
            comboBoxProductCategory = new ComboBox();
            btnProductSave = new Button();
            btnProductEdit = new Button();
            btnProductDelete = new Button();
            btnProductClear = new Button();
            productsDGV = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)productsDGV).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlText;
            label1.ImageAlign = ContentAlignment.BottomRight;
            label1.Location = new Point(19, 175);
            label1.Name = "label1";
            label1.Size = new Size(56, 21);
            label1.TabIndex = 0;
            label1.Text = "Name";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // txtProductName
            // 
            txtProductName.BorderStyle = BorderStyle.FixedSingle;
            txtProductName.Location = new Point(105, 173);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(144, 23);
            txtProductName.TabIndex = 1;
            // 
            // txtProductBrand
            // 
            txtProductBrand.BorderStyle = BorderStyle.FixedSingle;
            txtProductBrand.Location = new Point(105, 222);
            txtProductBrand.Name = "txtProductBrand";
            txtProductBrand.Size = new Size(144, 23);
            txtProductBrand.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ControlText;
            label2.ImageAlign = ContentAlignment.BottomRight;
            label2.Location = new Point(19, 224);
            label2.Name = "label2";
            label2.Size = new Size(55, 21);
            label2.TabIndex = 2;
            label2.Text = "Brand";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ControlText;
            label3.ImageAlign = ContentAlignment.BottomRight;
            label3.Location = new Point(19, 275);
            label3.Name = "label3";
            label3.Size = new Size(80, 21);
            label3.TabIndex = 4;
            label3.Text = "Category";
            label3.TextAlign = ContentAlignment.TopCenter;
            // 
            // txtProductPrice
            // 
            txtProductPrice.BorderStyle = BorderStyle.FixedSingle;
            txtProductPrice.Location = new Point(105, 326);
            txtProductPrice.Name = "txtProductPrice";
            txtProductPrice.Size = new Size(95, 23);
            txtProductPrice.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ControlText;
            label4.ImageAlign = ContentAlignment.BottomRight;
            label4.Location = new Point(19, 328);
            label4.Name = "label4";
            label4.Size = new Size(48, 21);
            label4.TabIndex = 6;
            label4.Text = "Price";
            label4.TextAlign = ContentAlignment.TopCenter;
            // 
            // comboBoxProductCategory
            // 
            comboBoxProductCategory.FormattingEnabled = true;
            comboBoxProductCategory.Items.AddRange(new object[] { "Fruit", "Vegetables", "Meat", "Fish", "Drugstore", "Beverages" });
            comboBoxProductCategory.Location = new Point(105, 273);
            comboBoxProductCategory.Name = "comboBoxProductCategory";
            comboBoxProductCategory.Size = new Size(95, 23);
            comboBoxProductCategory.TabIndex = 8;
            // 
            // btnProductSave
            // 
            btnProductSave.BackColor = Color.FromArgb(109, 216, 214);
            btnProductSave.Location = new Point(19, 426);
            btnProductSave.Name = "btnProductSave";
            btnProductSave.Size = new Size(75, 23);
            btnProductSave.TabIndex = 9;
            btnProductSave.Text = "Save";
            btnProductSave.UseVisualStyleBackColor = false;
            btnProductSave.Click += BtnProductSave_Click;
            // 
            // btnProductEdit
            // 
            btnProductEdit.BackColor = Color.FromArgb(109, 216, 214);
            btnProductEdit.Location = new Point(125, 426);
            btnProductEdit.Name = "btnProductEdit";
            btnProductEdit.Size = new Size(75, 23);
            btnProductEdit.TabIndex = 10;
            btnProductEdit.Text = "Edit";
            btnProductEdit.UseVisualStyleBackColor = false;
            btnProductEdit.Click += BtnProductEdit_Click;
            // 
            // btnProductDelete
            // 
            btnProductDelete.BackColor = Color.FromArgb(109, 216, 214);
            btnProductDelete.Location = new Point(232, 426);
            btnProductDelete.Name = "btnProductDelete";
            btnProductDelete.Size = new Size(75, 23);
            btnProductDelete.TabIndex = 11;
            btnProductDelete.Text = "Delete";
            btnProductDelete.UseVisualStyleBackColor = false;
            btnProductDelete.Click += BtnProductDelete_Click;
            // 
            // btnProductClear
            // 
            btnProductClear.BackColor = Color.FromArgb(109, 216, 214);
            btnProductClear.Location = new Point(340, 426);
            btnProductClear.Name = "btnProductClear";
            btnProductClear.Size = new Size(75, 23);
            btnProductClear.TabIndex = 12;
            btnProductClear.Text = "Clear";
            btnProductClear.UseVisualStyleBackColor = false;
            btnProductClear.Click += BtnProductClear_Click;
            // 
            // productsDGV
            // 
            productsDGV.AllowUserToAddRows = false;
            productsDGV.AllowUserToDeleteRows = false;
            productsDGV.AllowUserToResizeColumns = false;
            productsDGV.AllowUserToResizeRows = false;
            productsDGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            productsDGV.BackgroundColor = Color.FromArgb(109, 216, 214);
            productsDGV.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            productsDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            productsDGV.Location = new Point(287, 29);
            productsDGV.Name = "productsDGV";
            productsDGV.RowHeadersVisible = false;
            productsDGV.RowTemplate.DefaultCellStyle.BackColor = Color.FromArgb(216, 173, 61);
            productsDGV.RowTemplate.DefaultCellStyle.SelectionBackColor = Color.FromArgb(230, 201, 125);
            productsDGV.RowTemplate.DefaultCellStyle.SelectionForeColor = Color.Black;
            productsDGV.Size = new Size(484, 332);
            productsDGV.TabIndex = 13;
            // 
            // ProductsScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(804, 461);
            Controls.Add(productsDGV);
            Controls.Add(btnProductClear);
            Controls.Add(btnProductDelete);
            Controls.Add(btnProductEdit);
            Controls.Add(btnProductSave);
            Controls.Add(comboBoxProductCategory);
            Controls.Add(txtProductPrice);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtProductBrand);
            Controls.Add(label2);
            Controls.Add(txtProductName);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "ProductsScreen";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Products";
            ((System.ComponentModel.ISupportInitialize)productsDGV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtProductName;
        private TextBox txtProductBrand;
        private Label label2;
        private Label label3;
        private TextBox txtProductPrice;
        private Label label4;
        private ComboBox comboBoxProductCategory;
        private Button btnProductSave;
        private Button btnProductEdit;
        private Button btnProductDelete;
        private Button btnProductClear;
        private DataGridView productsDGV;
    }
}