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
            dtpFiturPresensiKaryawan = new DateTimePicker();
            btnBatalFiturPresensiKaryawan = new Button();
            btnSelesaiFiturPresensiKaryawan = new Button();
            cbNamaAKUNFiturPresensiKaryawan = new ComboBox();
            cbHariShiftFiturPresensiKaryawan = new ComboBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(68, 72);
            label1.Name = "label1";
            label1.Size = new Size(78, 15);
            label1.TabIndex = 0;
            label1.Text = "NAMA AKUN";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(68, 109);
            label2.Name = "label2";
            label2.Size = new Size(37, 15);
            label2.TabIndex = 1;
            label2.Text = "SHIFT";
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
            // cbNamaAKUNFiturPresensiKaryawan
            // 
            cbNamaAKUNFiturPresensiKaryawan.FormattingEnabled = true;
            cbNamaAKUNFiturPresensiKaryawan.Location = new Point(187, 69);
            cbNamaAKUNFiturPresensiKaryawan.Name = "cbNamaAKUNFiturPresensiKaryawan";
            cbNamaAKUNFiturPresensiKaryawan.Size = new Size(200, 23);
            cbNamaAKUNFiturPresensiKaryawan.TabIndex = 9;
            cbNamaAKUNFiturPresensiKaryawan.SelectedIndexChanged += cbIDAKUNFiturPresensiKaryawan_SelectedIndexChanged;
            // 
            // cbHariShiftFiturPresensiKaryawan
            // 
            cbHariShiftFiturPresensiKaryawan.FormattingEnabled = true;
            cbHariShiftFiturPresensiKaryawan.Location = new Point(187, 106);
            cbHariShiftFiturPresensiKaryawan.Name = "cbHariShiftFiturPresensiKaryawan";
            cbHariShiftFiturPresensiKaryawan.Size = new Size(200, 23);
            cbHariShiftFiturPresensiKaryawan.TabIndex = 10;
            // 
            // FiturPresensiKaryawan
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(cbHariShiftFiturPresensiKaryawan);
            Controls.Add(cbNamaAKUNFiturPresensiKaryawan);
            Controls.Add(btnSelesaiFiturPresensiKaryawan);
            Controls.Add(btnBatalFiturPresensiKaryawan);
            Controls.Add(dtpFiturPresensiKaryawan);
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
        private DateTimePicker dtpFiturPresensiKaryawan;
        private Button btnBatalFiturPresensiKaryawan;
        private Button btnSelesaiFiturPresensiKaryawan;
        private ComboBox cbNamaAKUNFiturPresensiKaryawan;
        private ComboBox cbHariShiftFiturPresensiKaryawan;
    }
}
