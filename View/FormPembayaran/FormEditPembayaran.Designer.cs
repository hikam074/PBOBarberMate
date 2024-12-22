namespace PBOBarberMate.View.FormPembayaran
{
    partial class FormEditPembayaran
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
            btnKembali = new Button();
            gbxCariReservasi = new GroupBox();
            cbxMetodePembayaran = new ComboBox();
            lblMetodePembayaran = new Label();
            tbxHarga = new TextBox();
            lblNama = new Label();
            lblHeading = new Label();
            gbxkonfirmasiPembayaran = new GroupBox();
            lblConfirmHarga = new Label();
            lblConfirmHeadHarga = new Label();
            btnSubmit = new Button();
            lblConfirmWaktu = new Label();
            lblConfirmHeadWaktu = new Label();
            lblConfirmMetodePembayaran = new Label();
            lblConfirmTanggal = new Label();
            lblConfirmLayanan = new Label();
            lblConfirmNama = new Label();
            lblConfirmHeadMetodePembayaran = new Label();
            lblConfirmHeadTanggal = new Label();
            lblConfirmHeadLayanan = new Label();
            lblConfirmHeadNama = new Label();
            gbxCariReservasi.SuspendLayout();
            gbxkonfirmasiPembayaran.SuspendLayout();
            SuspendLayout();
            // 
            // btnKembali
            // 
            btnKembali.BackColor = SystemColors.Control;
            btnKembali.Font = new Font("Bahnschrift Condensed", 11.25F);
            btnKembali.ForeColor = Color.FromArgb(44, 62, 80);
            btnKembali.Location = new Point(15, 15);
            btnKembali.Name = "btnKembali";
            btnKembali.Size = new Size(75, 39);
            btnKembali.TabIndex = 2;
            btnKembali.Text = "Kembali";
            btnKembali.UseVisualStyleBackColor = false;
            btnKembali.Click += btnKembali_Click;
            // 
            // gbxCariReservasi
            // 
            gbxCariReservasi.Anchor = AnchorStyles.Top;
            gbxCariReservasi.Controls.Add(cbxMetodePembayaran);
            gbxCariReservasi.Controls.Add(lblMetodePembayaran);
            gbxCariReservasi.Controls.Add(tbxHarga);
            gbxCariReservasi.Controls.Add(lblNama);
            gbxCariReservasi.Font = new Font("Bahnschrift Condensed", 11.25F);
            gbxCariReservasi.Location = new Point(133, 105);
            gbxCariReservasi.Name = "gbxCariReservasi";
            gbxCariReservasi.Size = new Size(310, 339);
            gbxCariReservasi.TabIndex = 10;
            gbxCariReservasi.TabStop = false;
            gbxCariReservasi.Text = "Cari pembayaran";
            // 
            // cbxMetodePembayaran
            // 
            cbxMetodePembayaran.FormattingEnabled = true;
            cbxMetodePembayaran.Location = new Point(95, 133);
            cbxMetodePembayaran.Name = "cbxMetodePembayaran";
            cbxMetodePembayaran.Size = new Size(200, 26);
            cbxMetodePembayaran.TabIndex = 10;
            cbxMetodePembayaran.SelectedIndexChanged += cbxMetodePembayaran_SelectedIndexChanged;
            // 
            // lblMetodePembayaran
            // 
            lblMetodePembayaran.Anchor = AnchorStyles.Top;
            lblMetodePembayaran.AutoSize = true;
            lblMetodePembayaran.Font = new Font("Bahnschrift Condensed", 11.25F);
            lblMetodePembayaran.Location = new Point(19, 127);
            lblMetodePembayaran.Name = "lblMetodePembayaran";
            lblMetodePembayaran.Size = new Size(70, 36);
            lblMetodePembayaran.TabIndex = 9;
            lblMetodePembayaran.Text = "Metode\r\nPembayaran";
            // 
            // tbxHarga
            // 
            tbxHarga.Location = new Point(95, 81);
            tbxHarga.Name = "tbxHarga";
            tbxHarga.Size = new Size(200, 26);
            tbxHarga.TabIndex = 8;
            tbxHarga.TextChanged += tbxHarga_TextChanged;
            // 
            // lblNama
            // 
            lblNama.Anchor = AnchorStyles.Top;
            lblNama.AutoSize = true;
            lblNama.Font = new Font("Bahnschrift Condensed", 11.25F);
            lblNama.Location = new Point(19, 84);
            lblNama.Name = "lblNama";
            lblNama.Size = new Size(37, 18);
            lblNama.TabIndex = 7;
            lblNama.Text = "Harga";
            // 
            // lblHeading
            // 
            lblHeading.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblHeading.AutoSize = true;
            lblHeading.Font = new Font("Bahnschrift Condensed", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHeading.ForeColor = Color.FromArgb(44, 62, 80);
            lblHeading.Location = new Point(262, 25);
            lblHeading.Name = "lblHeading";
            lblHeading.Size = new Size(313, 58);
            lblHeading.TabIndex = 12;
            lblHeading.Text = "Ubah Pembayaran";
            // 
            // gbxkonfirmasiPembayaran
            // 
            gbxkonfirmasiPembayaran.Anchor = AnchorStyles.Top;
            gbxkonfirmasiPembayaran.Controls.Add(lblConfirmHarga);
            gbxkonfirmasiPembayaran.Controls.Add(lblConfirmHeadHarga);
            gbxkonfirmasiPembayaran.Controls.Add(btnSubmit);
            gbxkonfirmasiPembayaran.Controls.Add(lblConfirmWaktu);
            gbxkonfirmasiPembayaran.Controls.Add(lblConfirmHeadWaktu);
            gbxkonfirmasiPembayaran.Controls.Add(lblConfirmMetodePembayaran);
            gbxkonfirmasiPembayaran.Controls.Add(lblConfirmTanggal);
            gbxkonfirmasiPembayaran.Controls.Add(lblConfirmLayanan);
            gbxkonfirmasiPembayaran.Controls.Add(lblConfirmNama);
            gbxkonfirmasiPembayaran.Controls.Add(lblConfirmHeadMetodePembayaran);
            gbxkonfirmasiPembayaran.Controls.Add(lblConfirmHeadTanggal);
            gbxkonfirmasiPembayaran.Controls.Add(lblConfirmHeadLayanan);
            gbxkonfirmasiPembayaran.Controls.Add(lblConfirmHeadNama);
            gbxkonfirmasiPembayaran.Font = new Font("Bahnschrift Condensed", 11.25F);
            gbxkonfirmasiPembayaran.Location = new Point(515, 105);
            gbxkonfirmasiPembayaran.Name = "gbxkonfirmasiPembayaran";
            gbxkonfirmasiPembayaran.Size = new Size(300, 339);
            gbxkonfirmasiPembayaran.TabIndex = 13;
            gbxkonfirmasiPembayaran.TabStop = false;
            gbxkonfirmasiPembayaran.Text = "Konfirmasi Pembayaran";
            // 
            // lblConfirmHarga
            // 
            lblConfirmHarga.AutoSize = true;
            lblConfirmHarga.Font = new Font("Bahnschrift Condensed", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblConfirmHarga.Location = new Point(181, 221);
            lblConfirmHarga.Name = "lblConfirmHarga";
            lblConfirmHarga.Size = new Size(31, 23);
            lblConfirmHarga.TabIndex = 21;
            lblConfirmHarga.Text = "---";
            // 
            // lblConfirmHeadHarga
            // 
            lblConfirmHeadHarga.AutoSize = true;
            lblConfirmHeadHarga.ForeColor = SystemColors.ControlDarkDark;
            lblConfirmHeadHarga.Location = new Point(181, 203);
            lblConfirmHeadHarga.Name = "lblConfirmHeadHarga";
            lblConfirmHeadHarga.Size = new Size(37, 18);
            lblConfirmHeadHarga.TabIndex = 20;
            lblConfirmHeadHarga.Text = "Harga";
            // 
            // btnSubmit
            // 
            btnSubmit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSubmit.BackColor = Color.FromArgb(44, 62, 80);
            btnSubmit.ForeColor = Color.White;
            btnSubmit.Location = new Point(214, 282);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(80, 51);
            btnSubmit.TabIndex = 19;
            btnSubmit.Text = "Simpan\r\nPerubahan";
            btnSubmit.UseVisualStyleBackColor = false;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // lblConfirmWaktu
            // 
            lblConfirmWaktu.AutoSize = true;
            lblConfirmWaktu.Font = new Font("Bahnschrift Condensed", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblConfirmWaktu.Location = new Point(181, 163);
            lblConfirmWaktu.Name = "lblConfirmWaktu";
            lblConfirmWaktu.Size = new Size(31, 23);
            lblConfirmWaktu.TabIndex = 18;
            lblConfirmWaktu.Text = "---";
            // 
            // lblConfirmHeadWaktu
            // 
            lblConfirmHeadWaktu.AutoSize = true;
            lblConfirmHeadWaktu.ForeColor = SystemColors.ControlDarkDark;
            lblConfirmHeadWaktu.Location = new Point(181, 145);
            lblConfirmHeadWaktu.Name = "lblConfirmHeadWaktu";
            lblConfirmHeadWaktu.Size = new Size(92, 18);
            lblConfirmHeadWaktu.TabIndex = 17;
            lblConfirmHeadWaktu.Text = "Waktu pelayanan";
            // 
            // lblConfirmMetodePembayaran
            // 
            lblConfirmMetodePembayaran.AutoSize = true;
            lblConfirmMetodePembayaran.Font = new Font("Bahnschrift Condensed", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblConfirmMetodePembayaran.Location = new Point(6, 221);
            lblConfirmMetodePembayaran.Name = "lblConfirmMetodePembayaran";
            lblConfirmMetodePembayaran.Size = new Size(31, 23);
            lblConfirmMetodePembayaran.TabIndex = 16;
            lblConfirmMetodePembayaran.Text = "---";
            // 
            // lblConfirmTanggal
            // 
            lblConfirmTanggal.AutoSize = true;
            lblConfirmTanggal.Font = new Font("Bahnschrift Condensed", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblConfirmTanggal.Location = new Point(6, 163);
            lblConfirmTanggal.Name = "lblConfirmTanggal";
            lblConfirmTanggal.Size = new Size(31, 23);
            lblConfirmTanggal.TabIndex = 15;
            lblConfirmTanggal.Text = "---";
            // 
            // lblConfirmLayanan
            // 
            lblConfirmLayanan.AutoSize = true;
            lblConfirmLayanan.Font = new Font("Bahnschrift Condensed", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblConfirmLayanan.Location = new Point(6, 108);
            lblConfirmLayanan.Name = "lblConfirmLayanan";
            lblConfirmLayanan.Size = new Size(31, 23);
            lblConfirmLayanan.TabIndex = 14;
            lblConfirmLayanan.Text = "---";
            // 
            // lblConfirmNama
            // 
            lblConfirmNama.AutoSize = true;
            lblConfirmNama.Font = new Font("Bahnschrift Condensed", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblConfirmNama.Location = new Point(6, 51);
            lblConfirmNama.Name = "lblConfirmNama";
            lblConfirmNama.Size = new Size(31, 23);
            lblConfirmNama.TabIndex = 13;
            lblConfirmNama.Text = "---";
            // 
            // lblConfirmHeadMetodePembayaran
            // 
            lblConfirmHeadMetodePembayaran.AutoSize = true;
            lblConfirmHeadMetodePembayaran.ForeColor = SystemColors.ControlDarkDark;
            lblConfirmHeadMetodePembayaran.Location = new Point(6, 203);
            lblConfirmHeadMetodePembayaran.Name = "lblConfirmHeadMetodePembayaran";
            lblConfirmHeadMetodePembayaran.Size = new Size(109, 18);
            lblConfirmHeadMetodePembayaran.TabIndex = 12;
            lblConfirmHeadMetodePembayaran.Text = "Metode Pembayaran";
            // 
            // lblConfirmHeadTanggal
            // 
            lblConfirmHeadTanggal.AutoSize = true;
            lblConfirmHeadTanggal.ForeColor = SystemColors.ControlDarkDark;
            lblConfirmHeadTanggal.Location = new Point(6, 145);
            lblConfirmHeadTanggal.Name = "lblConfirmHeadTanggal";
            lblConfirmHeadTanggal.Size = new Size(99, 18);
            lblConfirmHeadTanggal.TabIndex = 11;
            lblConfirmHeadTanggal.Text = "Tanggal pelayanan";
            // 
            // lblConfirmHeadLayanan
            // 
            lblConfirmHeadLayanan.AutoSize = true;
            lblConfirmHeadLayanan.ForeColor = SystemColors.ControlDarkDark;
            lblConfirmHeadLayanan.Location = new Point(6, 90);
            lblConfirmHeadLayanan.Name = "lblConfirmHeadLayanan";
            lblConfirmHeadLayanan.Size = new Size(50, 18);
            lblConfirmHeadLayanan.TabIndex = 10;
            lblConfirmHeadLayanan.Text = "Layanan";
            // 
            // lblConfirmHeadNama
            // 
            lblConfirmHeadNama.AutoSize = true;
            lblConfirmHeadNama.ForeColor = SystemColors.ControlDarkDark;
            lblConfirmHeadNama.Location = new Point(6, 33);
            lblConfirmHeadNama.Name = "lblConfirmHeadNama";
            lblConfirmHeadNama.Size = new Size(90, 18);
            lblConfirmHeadNama.TabIndex = 9;
            lblConfirmHeadNama.Text = "Nama pelanggan";
            // 
            // FormEditPembayaran
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(944, 501);
            Controls.Add(gbxkonfirmasiPembayaran);
            Controls.Add(lblHeading);
            Controls.Add(gbxCariReservasi);
            Controls.Add(btnKembali);
            Name = "FormEditPembayaran";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormAddPembayaran";
            gbxCariReservasi.ResumeLayout(false);
            gbxCariReservasi.PerformLayout();
            gbxkonfirmasiPembayaran.ResumeLayout(false);
            gbxkonfirmasiPembayaran.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnKembali;
        private GroupBox gbxCariReservasi;
        private Label lblNama;
        private TextBox tbxHarga;
        public Label lblHeading;
        private GroupBox gbxkonfirmasiPembayaran;
        private Label lblConfirmHeadWaktu;
        private Label lblConfirmMetodePembayaran;
        private Label lblConfirmHeadMetodePembayaran;
        private Label lblConfirmHeadTanggal;
        private Label lblConfirmHeadLayanan;
        private Label lblConfirmHeadNama;
        private Label lblMetodePembayaran;
        private Button btnSubmit;
        private Label lblConfirmHarga;
        private Label lblConfirmHeadHarga;
        public Label lblConfirmTanggal;
        public Label lblConfirmLayanan;
        public Label lblConfirmNama;
        public Label lblConfirmWaktu;
        public ComboBox cbxMetodePembayaran;
    }
}