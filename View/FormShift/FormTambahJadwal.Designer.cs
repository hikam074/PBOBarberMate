namespace PBOBarberMate.View.FormShift
{
    partial class FormTambahJadwal
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
            lblAddJadwal = new Label();
            lblNamaAkun = new Label();
            lblHari = new Label();
            btnBatal = new Button();
            btnTambah = new Button();
            comboBoxAkun = new ComboBox();
            comboBoxHari = new ComboBox();
            SuspendLayout();
            // 
            // lblAddJadwal
            // 
            lblAddJadwal.AutoSize = true;
            lblAddJadwal.Font = new Font("Bahnschrift SemiBold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAddJadwal.ForeColor = Color.White;
            lblAddJadwal.Location = new Point(320, 58);
            lblAddJadwal.Name = "lblAddJadwal";
            lblAddJadwal.Size = new Size(293, 36);
            lblAddJadwal.TabIndex = 0;
            lblAddJadwal.Text = "Tambah Jadwal Shift";
            lblAddJadwal.Click += lblAddJadwal_Click;
            // 
            // lblNamaAkun
            // 
            lblNamaAkun.AutoSize = true;
            lblNamaAkun.Font = new Font("Bahnschrift", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNamaAkun.ForeColor = Color.White;
            lblNamaAkun.Location = new Point(181, 160);
            lblNamaAkun.Name = "lblNamaAkun";
            lblNamaAkun.Size = new Size(114, 24);
            lblNamaAkun.TabIndex = 1;
            lblNamaAkun.Text = "Nama Akun";
            lblNamaAkun.Click += label1_Click;
            // 
            // lblHari
            // 
            lblHari.AutoSize = true;
            lblHari.Font = new Font("Bahnschrift", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblHari.ForeColor = Color.White;
            lblHari.Location = new Point(181, 279);
            lblHari.Name = "lblHari";
            lblHari.Size = new Size(56, 28);
            lblHari.TabIndex = 2;
            lblHari.Text = "Hari";
            lblHari.Click += label2_Click;
            // 
            // btnBatal
            // 
            btnBatal.Location = new Point(606, 406);
            btnBatal.Name = "btnBatal";
            btnBatal.Size = new Size(94, 29);
            btnBatal.TabIndex = 5;
            btnBatal.Text = "Batal";
            btnBatal.UseVisualStyleBackColor = true;
            btnBatal.Click += btnBatal_Click;
            // 
            // btnTambah
            // 
            btnTambah.Location = new Point(765, 406);
            btnTambah.Name = "btnTambah";
            btnTambah.Size = new Size(94, 29);
            btnTambah.TabIndex = 6;
            btnTambah.Text = "Tambah";
            btnTambah.UseVisualStyleBackColor = true;
            btnTambah.Click += btnTambah_Click;
            // 
            // comboBoxAkun
            // 
            comboBoxAkun.FormattingEnabled = true;
            comboBoxAkun.Location = new Point(432, 160);
            comboBoxAkun.Name = "comboBoxAkun";
            comboBoxAkun.Size = new Size(268, 28);
            comboBoxAkun.TabIndex = 8;
            comboBoxAkun.SelectedIndexChanged += comboBoxAkun_SelectedIndexChanged;
            // 
            // comboBoxHari
            // 
            comboBoxHari.FormattingEnabled = true;
            comboBoxHari.Location = new Point(432, 279);
            comboBoxHari.Name = "comboBoxHari";
            comboBoxHari.Size = new Size(268, 28);
            comboBoxHari.TabIndex = 9;
            comboBoxHari.SelectedIndexChanged += comboBoxHari_SelectedIndexChanged;
            // 
            // FormTambahJadwal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(44, 62, 80);
            ClientSize = new Size(960, 518);
            Controls.Add(comboBoxHari);
            Controls.Add(comboBoxAkun);
            Controls.Add(lblAddJadwal);
            Controls.Add(btnTambah);
            Controls.Add(btnBatal);
            Controls.Add(lblHari);
            Controls.Add(lblNamaAkun);
            ForeColor = SystemColors.ActiveCaptionText;
            Name = "FormTambahJadwal";
            Text = "FormTambahJadwal";
            Load += FormTambahJadwal_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblAddJadwal;
        private Label lblNamaAkun;
        private Label lblHari;
        private Button btnBatal;
        private Button btnTambah;
        private ComboBox comboBoxAkun;
        private ComboBox comboBoxHari;
    }
}