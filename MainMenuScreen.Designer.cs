namespace Biomarkt_GmbH
{
    partial class MainMenuScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenuScreen));
            btnProducts = new Button();
            btnInvoice = new Button();
            SuspendLayout();
            // 
            // btnProducts
            // 
            btnProducts.BackgroundImage = (Image)resources.GetObject("btnProducts.BackgroundImage");
            btnProducts.BackgroundImageLayout = ImageLayout.None;
            btnProducts.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnProducts.Location = new Point(27, 30);
            btnProducts.Name = "btnProducts";
            btnProducts.Padding = new Padding(0, 13, 35, 0);
            btnProducts.Size = new Size(366, 178);
            btnProducts.TabIndex = 0;
            btnProducts.Text = "Manage \r\nProducts";
            btnProducts.TextAlign = ContentAlignment.TopCenter;
            btnProducts.UseVisualStyleBackColor = true;
            btnProducts.Click += BtnProducts_Click;
            // 
            // btnInvoice
            // 
            btnInvoice.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnInvoice.ForeColor = Color.DarkOrange;
            btnInvoice.Image = (Image)resources.GetObject("btnInvoice.Image");
            btnInvoice.ImageAlign = ContentAlignment.TopCenter;
            btnInvoice.Location = new Point(428, 30);
            btnInvoice.Name = "btnInvoice";
            btnInvoice.Size = new Size(365, 178);
            btnInvoice.TabIndex = 1;
            btnInvoice.Text = "Create Invoice";
            btnInvoice.TextAlign = ContentAlignment.TopLeft;
            btnInvoice.UseVisualStyleBackColor = true;
            btnInvoice.Click += BtnInvoice_Click;
            // 
            // MainMenuScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(90, 194, 166);
            ClientSize = new Size(826, 261);
            Controls.Add(btnInvoice);
            Controls.Add(btnProducts);
            Name = "MainMenuScreen";
            Padding = new Padding(0, 0, 30, 0);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Main Menu";
            ResumeLayout(false);
        }

        #endregion

        private Button btnProducts;
        private Button btnInvoice;
    }
}