namespace PBOBarberMate.View.FormUlasan
{
    partial class FormUlasan
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
            lblLayanan = new Label();
            panelUlasanContainer = new Panel();
            bintang1 = new PictureBox();
            button1 = new Button();
            btnKembali = new Button();
            panelUlasanContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)bintang1).BeginInit();
            SuspendLayout();
            // 
            // lblLayanan
            // 
            lblLayanan.AutoSize = true;
            lblLayanan.Font = new Font("Sitka Banner", 20F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblLayanan.Location = new Point(355, 35);
            lblLayanan.Margin = new Padding(2, 0, 2, 0);
            lblLayanan.Name = "lblLayanan";
            lblLayanan.Size = new Size(159, 39);
            lblLayanan.TabIndex = 2;
            lblLayanan.Text = "Daftar Ulasan";
            // 
            // panelUlasanContainer
            // 
            panelUlasanContainer.AutoScroll = true;
            panelUlasanContainer.Controls.Add(bintang1);
            panelUlasanContainer.Controls.Add(button1);
            panelUlasanContainer.Location = new Point(56, 106);
            panelUlasanContainer.Name = "panelUlasanContainer";
            panelUlasanContainer.Size = new Size(747, 83);
            panelUlasanContainer.TabIndex = 3;
            // 
            // bintang1
            // 
            bintang1.Image = Properties.Resources.bintang_removebg_preview__1_;
            bintang1.Location = new Point(12, 24);
            bintang1.Margin = new Padding(2);
            bintang1.Name = "bintang1";
            bintang1.Size = new Size(25, 24);
            bintang1.SizeMode = PictureBoxSizeMode.Zoom;
            bintang1.TabIndex = 4;
            bintang1.TabStop = false;
            bintang1.Visible = false;
            // 
            // button1
            // 
            button1.Location = new Point(388, 38);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Size = new Size(0, 0);
            button1.TabIndex = 0;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // btnKembali
            // 
            btnKembali.BackColor = SystemColors.Control;
            btnKembali.Font = new Font("Bahnschrift Condensed", 11.25F);
            btnKembali.ForeColor = Color.FromArgb(44, 62, 80);
            btnKembali.Location = new Point(56, 35);
            btnKembali.Name = "btnKembali";
            btnKembali.Size = new Size(75, 39);
            btnKembali.TabIndex = 13;
            btnKembali.Text = "Kembali";
            btnKembali.UseVisualStyleBackColor = false;
            btnKembali.Click += btnKembali_Click;
            // 
            // FormUlasan
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(874, 450);
            Controls.Add(btnKembali);
            Controls.Add(panelUlasanContainer);
            Controls.Add(lblLayanan);
            Name = "FormUlasan";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormUlasan";
            Load += FormUlasan_Load;
            panelUlasanContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)bintang1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblLayanan;
        public Panel panelUlasanContainer;
        private Button button1;
        private PictureBox bintang1;
        private Button btnKembali;
    }
}