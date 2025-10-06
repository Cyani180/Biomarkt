namespace Biomarkt_GmbH
{
    partial class InvoiceScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InvoiceScreen));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            textInvoiceCustomerName = new TextBox();
            textTotalInvoice = new TextBox();
            btnInvoceSave = new Button();
            btnInvoiceEdit = new Button();
            btnInvoiceDelete = new Button();
            btnInvoiceClear = new Button();
            dateTimePickerInvoice = new DateTimePicker();
            invoicesC = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)invoicesC).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(59, 53);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Black;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.ImageAlign = ContentAlignment.BottomRight;
            label2.Location = new Point(478, 53);
            label2.Name = "label2";
            label2.Size = new Size(71, 30);
            label2.TabIndex = 1;
            label2.Text = "Name";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Black;
            label3.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.ImageAlign = ContentAlignment.BottomRight;
            label3.Location = new Point(478, 117);
            label3.Name = "label3";
            label3.Size = new Size(58, 30);
            label3.TabIndex = 2;
            label3.Text = "Date";
            label3.TextAlign = ContentAlignment.TopCenter;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Black;
            label4.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.ImageAlign = ContentAlignment.BottomRight;
            label4.Location = new Point(478, 182);
            label4.Name = "label4";
            label4.Size = new Size(84, 30);
            label4.TabIndex = 3;
            label4.Text = "Invoice";
            label4.TextAlign = ContentAlignment.TopCenter;
            // 
            // textInvoiceCustomerName
            // 
            textInvoiceCustomerName.Location = new Point(588, 60);
            textInvoiceCustomerName.Name = "textInvoiceCustomerName";
            textInvoiceCustomerName.Size = new Size(194, 23);
            textInvoiceCustomerName.TabIndex = 4;
            // 
            // textTotalInvoice
            // 
            textTotalInvoice.Location = new Point(588, 189);
            textTotalInvoice.Name = "textTotalInvoice";
            textTotalInvoice.Size = new Size(194, 23);
            textTotalInvoice.TabIndex = 6;
            // 
            // btnInvoceSave
            // 
            btnInvoceSave.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnInvoceSave.Location = new Point(40, 496);
            btnInvoceSave.Name = "btnInvoceSave";
            btnInvoceSave.Size = new Size(68, 26);
            btnInvoceSave.TabIndex = 7;
            btnInvoceSave.Text = "Save";
            btnInvoceSave.UseVisualStyleBackColor = true;
            btnInvoceSave.Click += BtnInvoceSave_Click;
            // 
            // btnInvoiceEdit
            // 
            btnInvoiceEdit.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnInvoiceEdit.Location = new Point(145, 496);
            btnInvoiceEdit.Name = "btnInvoiceEdit";
            btnInvoiceEdit.Size = new Size(68, 26);
            btnInvoiceEdit.TabIndex = 8;
            btnInvoiceEdit.Text = "Edit";
            btnInvoiceEdit.UseVisualStyleBackColor = true;
            btnInvoiceEdit.Click += BtnInvoiceEdit_Click;
            // 
            // btnInvoiceDelete
            // 
            btnInvoiceDelete.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnInvoiceDelete.Location = new Point(253, 496);
            btnInvoiceDelete.Name = "btnInvoiceDelete";
            btnInvoiceDelete.Size = new Size(68, 26);
            btnInvoiceDelete.TabIndex = 9;
            btnInvoiceDelete.Text = "Delete";
            btnInvoiceDelete.UseVisualStyleBackColor = true;
            btnInvoiceDelete.Click += BtnInvoiceDelete_Click;
            // 
            // btnInvoiceClear
            // 
            btnInvoiceClear.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnInvoiceClear.Location = new Point(357, 496);
            btnInvoiceClear.Name = "btnInvoiceClear";
            btnInvoiceClear.Size = new Size(68, 26);
            btnInvoiceClear.TabIndex = 10;
            btnInvoiceClear.Text = "Clear";
            btnInvoiceClear.UseVisualStyleBackColor = true;
            btnInvoiceClear.Click += BtnInvoiceClear_Click;
            // 
            // dateTimePickerInvoice
            // 
            dateTimePickerInvoice.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateTimePickerInvoice.Location = new Point(588, 124);
            dateTimePickerInvoice.Name = "dateTimePickerInvoice";
            dateTimePickerInvoice.Size = new Size(194, 23);
            dateTimePickerInvoice.TabIndex = 11;
            dateTimePickerInvoice.Value = new DateTime(2025, 10, 1, 0, 0, 0, 0);
            // 
            // invoicesC
            // 
            invoicesC.AllowUserToAddRows = false;
            invoicesC.AllowUserToDeleteRows = false;
            invoicesC.AllowUserToResizeColumns = false;
            invoicesC.AllowUserToResizeRows = false;
            invoicesC.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            invoicesC.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            invoicesC.Location = new Point(40, 53);
            invoicesC.Name = "invoicesC";
            invoicesC.RowHeadersVisible = false;
            invoicesC.Size = new Size(385, 385);
            invoicesC.TabIndex = 12;
            invoicesC.CellContentClick += InvoicesC_CellContentClick;
            // 
            // InvoiceScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(804, 561);
            Controls.Add(invoicesC);
            Controls.Add(dateTimePickerInvoice);
            Controls.Add(btnInvoiceClear);
            Controls.Add(btnInvoiceDelete);
            Controls.Add(btnInvoiceEdit);
            Controls.Add(btnInvoceSave);
            Controls.Add(textTotalInvoice);
            Controls.Add(textInvoiceCustomerName);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "InvoiceScreen";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Invoice";
            ((System.ComponentModel.ISupportInitialize)invoicesC).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textInvoiceCustomerName;
        private TextBox textTotalInvoice;
        private Button btnInvoceSave;
        private Button btnInvoiceEdit;
        private Button btnInvoiceDelete;
        private Button btnInvoiceClear;
        private DateTimePicker dateTimePickerInvoice;
        private DataGridView invoicesC;
    }
}