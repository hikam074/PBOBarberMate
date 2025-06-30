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
            gbxAddShift = new GroupBox();
            gbxAddShift.SuspendLayout();
            SuspendLayout();
            // 
            // lblAddJadwal
            // 
            lblAddJadwal.AutoSize = true;
            lblAddJadwal.Font = new Font("Bahnschrift Condensed", 36F, FontStyle.Bold);
            lblAddJadwal.ForeColor = Color.FromArgb(44, 62, 80);
            lblAddJadwal.Location = new Point(305, 58);
            lblAddJadwal.Name = "lblAddJadwal";
            lblAddJadwal.Size = new Size(359, 58);
            lblAddJadwal.TabIndex = 0;
            lblAddJadwal.Text = "Tambah Jadwal Shift";
            lblAddJadwal.Click += lblAddJadwal_Click;
            // 
            // lblNamaAkun
            // 
            lblNamaAkun.AutoSize = true;
            lblNamaAkun.Font = new Font("Bahnschrift Condensed", 11.25F);
            lblNamaAkun.ForeColor = Color.FromArgb(44, 62, 80);
            lblNamaAkun.Location = new Point(20, 35);
            lblNamaAkun.Name = "lblNamaAkun";
            lblNamaAkun.Size = new Size(58, 36);
            lblNamaAkun.TabIndex = 1;
            lblNamaAkun.Text = "Nama\r\nKaryawan";
            lblNamaAkun.Click += label1_Click;
            // 
            // lblHari
            // 
            lblHari.AutoSize = true;
            lblHari.Font = new Font("Bahnschrift Condensed", 11.25F);
            lblHari.ForeColor = Color.FromArgb(44, 62, 80);
            lblHari.Location = new Point(20, 97);
            lblHari.Name = "lblHari";
            lblHari.Size = new Size(54, 18);
            lblHari.TabIndex = 2;
            lblHari.Text = "Hari Shift";
            // 
            // btnBatal
            // 
            btnBatal.BackColor = Color.White;
            btnBatal.Font = new Font("Bahnschrift Condensed", 11.25F);
            btnBatal.ForeColor = Color.FromArgb(44, 62, 80);
            btnBatal.Location = new Point(15, 15);
            btnBatal.Name = "btnBatal";
            btnBatal.Size = new Size(75, 39);
            btnBatal.TabIndex = 5;
            btnBatal.Text = "Batal";
            btnBatal.UseVisualStyleBackColor = false;
            btnBatal.Click += btnBatal_Click;
            // 
            // btnTambah
            // 
            btnTambah.BackColor = Color.FromArgb(80, 61, 44);
            btnTambah.Font = new Font("Bahnschrift Condensed", 11.25F);
            btnTambah.ForeColor = Color.White;
            btnTambah.Location = new Point(282, 139);
            btnTambah.Name = "btnTambah";
            btnTambah.Size = new Size(75, 39);
            btnTambah.TabIndex = 6;
            btnTambah.Text = "Tambah";
            btnTambah.UseVisualStyleBackColor = false;
            btnTambah.Click += btnTambah_Click;
            // 
            // comboBoxAkun
            // 
            comboBoxAkun.FormattingEnabled = true;
            comboBoxAkun.Location = new Point(89, 40);
            comboBoxAkun.Name = "comboBoxAkun";
            comboBoxAkun.Size = new Size(268, 23);
            comboBoxAkun.TabIndex = 8;
            comboBoxAkun.SelectedIndexChanged += comboBoxAkun_SelectedIndexChanged;
            // 
            // comboBoxHari
            // 
            comboBoxHari.FormattingEnabled = true;
            comboBoxHari.Location = new Point(89, 95);
            comboBoxHari.Name = "comboBoxHari";
            comboBoxHari.Size = new Size(268, 23);
            comboBoxHari.TabIndex = 9;
            comboBoxHari.SelectedIndexChanged += comboBoxHari_SelectedIndexChanged;
            // 
            // gbxAddShift
            // 
            gbxAddShift.BackColor = Color.White;
            gbxAddShift.Controls.Add(comboBoxHari);
            gbxAddShift.Controls.Add(comboBoxAkun);
            gbxAddShift.Controls.Add(btnTambah);
            gbxAddShift.Controls.Add(lblHari);
            gbxAddShift.Controls.Add(lblNamaAkun);
            gbxAddShift.Location = new Point(305, 184);
            gbxAddShift.Name = "gbxAddShift";
            gbxAddShift.Size = new Size(374, 195);
            gbxAddShift.TabIndex = 10;
            gbxAddShift.TabStop = false;
            // 
            // FormTambahJadwal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(944, 501);
            Controls.Add(gbxAddShift);
            Controls.Add(lblAddJadwal);
            Controls.Add(btnBatal);
            ForeColor = SystemColors.ActiveCaptionText;
            Name = "FormTambahJadwal";
            Text = "FormTambahJadwal";
            Load += FormTambahJadwal_Load;
            gbxAddShift.ResumeLayout(false);
            gbxAddShift.PerformLayout();
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
        private GroupBox gbxAddShift;
    }
}