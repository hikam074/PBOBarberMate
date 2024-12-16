namespace PBOBarberMate.View.FormKelolaKaryawan
{
    partial class FiturPresensiKaryawan
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            tbIDAKUNFiturPresensiKaryawan = new TextBox();
            tbIDSHIFTFiturPresensiKaryawan = new TextBox();
            dtpFiturPresensiKaryawan = new DateTimePicker();
            btnBatalFiturPresensiKaryawan = new Button();
            btnSelesaiFiturPresensiKaryawan = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(68, 72);
            label1.Name = "label1";
            label1.Size = new Size(53, 15);
            label1.TabIndex = 0;
            label1.Text = "ID AKUN";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(68, 109);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 1;
            label2.Text = "ID SHIFT";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(68, 146);
            label3.Name = "label3";
            label3.Size = new Size(100, 15);
            label3.TabIndex = 2;
            label3.Text = "WAKTU PRESENSI";
            // 
            // tbIDAKUNFiturPresensiKaryawan
            // 
            tbIDAKUNFiturPresensiKaryawan.Location = new Point(187, 69);
            tbIDAKUNFiturPresensiKaryawan.Name = "tbIDAKUNFiturPresensiKaryawan";
            tbIDAKUNFiturPresensiKaryawan.Size = new Size(100, 23);
            tbIDAKUNFiturPresensiKaryawan.TabIndex = 3;
            // 
            // tbIDSHIFTFiturPresensiKaryawan
            // 
            tbIDSHIFTFiturPresensiKaryawan.Location = new Point(187, 106);
            tbIDSHIFTFiturPresensiKaryawan.Name = "tbIDSHIFTFiturPresensiKaryawan";
            tbIDSHIFTFiturPresensiKaryawan.Size = new Size(100, 23);
            tbIDSHIFTFiturPresensiKaryawan.TabIndex = 4;
            // 
            // dtpFiturPresensiKaryawan
            // 
            dtpFiturPresensiKaryawan.Location = new Point(187, 140);
            dtpFiturPresensiKaryawan.Name = "dtpFiturPresensiKaryawan";
            dtpFiturPresensiKaryawan.Size = new Size(200, 23);
            dtpFiturPresensiKaryawan.TabIndex = 6;
            // 
            // btnBatalFiturPresensiKaryawan
            // 
            btnBatalFiturPresensiKaryawan.Location = new Point(531, 399);
            btnBatalFiturPresensiKaryawan.Name = "btnBatalFiturPresensiKaryawan";
            btnBatalFiturPresensiKaryawan.Size = new Size(75, 23);
            btnBatalFiturPresensiKaryawan.TabIndex = 7;
            btnBatalFiturPresensiKaryawan.Text = "BATAL";
            btnBatalFiturPresensiKaryawan.UseVisualStyleBackColor = true;
            btnBatalFiturPresensiKaryawan.Click += btnBatalFiturPresensiKaryawan_Click;
            // 
            // btnSelesaiFiturPresensiKaryawan
            // 
            btnSelesaiFiturPresensiKaryawan.Location = new Point(612, 399);
            btnSelesaiFiturPresensiKaryawan.Name = "btnSelesaiFiturPresensiKaryawan";
            btnSelesaiFiturPresensiKaryawan.Size = new Size(75, 23);
            btnSelesaiFiturPresensiKaryawan.TabIndex = 8;
            btnSelesaiFiturPresensiKaryawan.Text = "SELESAI";
            btnSelesaiFiturPresensiKaryawan.UseVisualStyleBackColor = true;
            btnSelesaiFiturPresensiKaryawan.Click += btnSelesaiFiturPresensiKaryawan_Click;
            // 
            // FiturPresensiKaryawan
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSelesaiFiturPresensiKaryawan);
            Controls.Add(btnBatalFiturPresensiKaryawan);
            Controls.Add(dtpFiturPresensiKaryawan);
            Controls.Add(tbIDSHIFTFiturPresensiKaryawan);
            Controls.Add(tbIDAKUNFiturPresensiKaryawan);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FiturPresensiKaryawan";
            Text = "EditPresensiKaryawan";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox tbIDAKUNFiturPresensiKaryawan;
        private TextBox tbIDSHIFTFiturPresensiKaryawan;
        private DateTimePicker dtpFiturPresensiKaryawan;
        private Button btnBatalFiturPresensiKaryawan;
        private Button btnSelesaiFiturPresensiKaryawan;
    }
}