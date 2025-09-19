namespace Biomarkt_GmbH
{
    partial class LoadingScreen
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            label1 = new Label();
            lblLoadingProgress = new Label();
            loadingProgressbar = new ProgressBar();
            pictureBox1 = new PictureBox();
            loadingbarTimer = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(295, 404);
            label1.Name = "label1";
            label1.Size = new Size(50, 15);
            label1.TabIndex = 1;
            label1.Text = "Loading";
            // 
            // lblLoadingProgress
            // 
            lblLoadingProgress.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblLoadingProgress.AutoSize = true;
            lblLoadingProgress.Location = new Point(342, 404);
            lblLoadingProgress.Name = "lblLoadingProgress";
            lblLoadingProgress.Size = new Size(23, 15);
            lblLoadingProgress.TabIndex = 2;
            lblLoadingProgress.Text = "0%";
            lblLoadingProgress.Click += Label2_Click;
            // 
            // loadingProgressbar
            // 
            loadingProgressbar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            loadingProgressbar.Location = new Point(15, 435);
            loadingProgressbar.Name = "loadingProgressbar";
            loadingProgressbar.Size = new Size(650, 23);
            loadingProgressbar.TabIndex = 3;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.wp7713378_minecraft_cat_wallpapers1;
            pictureBox1.Location = new Point(14, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(659, 369);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // loadingbarTimer
            // 
            loadingbarTimer.Tick += loadingbarTimer_Tick;
            // 
            // LoadingScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(164, 198, 142);
            ClientSize = new Size(684, 469);
            ControlBox = false;
            Controls.Add(pictureBox1);
            Controls.Add(loadingProgressbar);
            Controls.Add(lblLoadingProgress);
            Controls.Add(label1);
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            Name = "LoadingScreen";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Biomarkt GmbH";
            Load += LoadingScreen_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label lblLoadingProgress;
        private ProgressBar loadingProgressbar;
        private PictureBox pictureBox1;
        private System.Windows.Forms.Timer loadingbarTimer;




    }


}
