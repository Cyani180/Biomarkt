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
            btnBill = new Button();
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
            // btnBill
            // 
            btnBill.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBill.ForeColor = Color.DarkOrange;
            btnBill.Image = (Image)resources.GetObject("btnBill.Image");
            btnBill.ImageAlign = ContentAlignment.TopCenter;
            btnBill.Location = new Point(428, 30);
            btnBill.Name = "btnBill";
            btnBill.Size = new Size(365, 178);
            btnBill.TabIndex = 1;
            btnBill.Text = "Create Invoice";
            btnBill.TextAlign = ContentAlignment.TopLeft;
            btnBill.UseVisualStyleBackColor = true;
            // 
            // MainMenuScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(90, 194, 166);
            ClientSize = new Size(826, 261);
            Controls.Add(btnBill);
            Controls.Add(btnProducts);
            Name = "MainMenuScreen";
            Padding = new Padding(0, 0, 30, 0);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Main Menu";
            ResumeLayout(false);
        }

        #endregion

        private Button btnProducts;
        private Button btnBill;
    }
}