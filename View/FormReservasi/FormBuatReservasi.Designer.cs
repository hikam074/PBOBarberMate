namespace PBOBarberMate.View
{
    partial class FormBuatReservasi
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
            lblLayanan = new Label();
            cbxLayanan = new ComboBox();
            dtpTanggal = new DateTimePicker();
            cbxWaktu = new ComboBox();
            lblTanggal = new Label();
            lblWaktu = new Label();
            btnSubmit = new Button();
            gbxPlanReservasi = new GroupBox();
            groupBox2 = new GroupBox();
            lblConfirmWaktu = new Label();
            lblConfirmTanggal = new Label();
            lblConfirmLayanan = new Label();
            lblConfirmNama = new Label();
            lblConfirmHeadWaktu = new Label();
            lblConfirmHeadTanggal = new Label();
            lblConfirmHeadLayanan = new Label();
            lblConfirmHeadNama = new Label();
            lblHeading = new Label();
            gbxPlanReservasi.SuspendLayout();
            groupBox2.SuspendLayout();
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
            btnKembali.TabIndex = 1;
            btnKembali.Text = "Kembali";
            btnKembali.UseVisualStyleBackColor = false;
            btnKembali.Click += btnKembali_Click;
            // 
            // lblLayanan
            // 
            lblLayanan.Anchor = AnchorStyles.Top;
            lblLayanan.AutoSize = true;
            lblLayanan.Font = new Font("Bahnschrift Condensed", 11.25F);
            lblLayanan.Location = new Point(19, 36);
            lblLayanan.Name = "lblLayanan";
            lblLayanan.Size = new Size(50, 18);
            lblLayanan.TabIndex = 2;
            lblLayanan.Text = "Layanan";
            // 
            // cbxLayanan
            // 
            cbxLayanan.Anchor = AnchorStyles.Top;
            cbxLayanan.DisplayMember = "d";
            cbxLayanan.FormattingEnabled = true;
            cbxLayanan.Location = new Point(85, 33);
            cbxLayanan.Name = "cbxLayanan";
            cbxLayanan.Size = new Size(200, 26);
            cbxLayanan.TabIndex = 3;
            cbxLayanan.SelectedIndexChanged += cbxLayanan_SelectedIndexChanged;
            // 
            // dtpTanggal
            // 
            dtpTanggal.Anchor = AnchorStyles.Top;
            dtpTanggal.Location = new Point(85, 84);
            dtpTanggal.Name = "dtpTanggal";
            dtpTanggal.Size = new Size(200, 26);
            dtpTanggal.TabIndex = 4;
            dtpTanggal.ValueChanged += dtpTanggal_ValueChanged;
            // 
            // cbxWaktu
            // 
            cbxWaktu.Anchor = AnchorStyles.Top;
            cbxWaktu.FormattingEnabled = true;
            cbxWaktu.Location = new Point(85, 136);
            cbxWaktu.Name = "cbxWaktu";
            cbxWaktu.Size = new Size(200, 26);
            cbxWaktu.TabIndex = 5;
            // 
            // lblTanggal
            // 
            lblTanggal.Anchor = AnchorStyles.Top;
            lblTanggal.AutoSize = true;
            lblTanggal.Font = new Font("Bahnschrift Condensed", 11.25F);
            lblTanggal.Location = new Point(19, 90);
            lblTanggal.Name = "lblTanggal";
            lblTanggal.Size = new Size(45, 18);
            lblTanggal.TabIndex = 6;
            lblTanggal.Text = "Tanggal";
            // 
            // lblWaktu
            // 
            lblWaktu.Anchor = AnchorStyles.Top;
            lblWaktu.AutoSize = true;
            lblWaktu.Font = new Font("Bahnschrift Condensed", 11.25F);
            lblWaktu.Location = new Point(19, 139);
            lblWaktu.Name = "lblWaktu";
            lblWaktu.Size = new Size(38, 18);
            lblWaktu.TabIndex = 7;
            lblWaktu.Text = "Waktu";
            // 
            // btnSubmit
            // 
            btnSubmit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSubmit.BackColor = Color.FromArgb(44, 62, 80);
            btnSubmit.ForeColor = Color.White;
            btnSubmit.Location = new Point(219, 258);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(75, 51);
            btnSubmit.TabIndex = 8;
            btnSubmit.Text = "Buat Reservasi";
            btnSubmit.UseVisualStyleBackColor = false;
            // 
            // gbxPlanReservasi
            // 
            gbxPlanReservasi.Anchor = AnchorStyles.Top;
            gbxPlanReservasi.Controls.Add(cbxLayanan);
            gbxPlanReservasi.Controls.Add(lblLayanan);
            gbxPlanReservasi.Controls.Add(dtpTanggal);
            gbxPlanReservasi.Controls.Add(lblWaktu);
            gbxPlanReservasi.Controls.Add(cbxWaktu);
            gbxPlanReservasi.Controls.Add(lblTanggal);
            gbxPlanReservasi.Font = new Font("Bahnschrift Condensed", 11.25F);
            gbxPlanReservasi.Location = new Point(70, 100);
            gbxPlanReservasi.Name = "gbxPlanReservasi";
            gbxPlanReservasi.Size = new Size(310, 179);
            gbxPlanReservasi.TabIndex = 9;
            gbxPlanReservasi.TabStop = false;
            gbxPlanReservasi.Text = "Silahkan isi dibawah ini!";
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.Top;
            groupBox2.Controls.Add(lblConfirmWaktu);
            groupBox2.Controls.Add(lblConfirmTanggal);
            groupBox2.Controls.Add(lblConfirmLayanan);
            groupBox2.Controls.Add(lblConfirmNama);
            groupBox2.Controls.Add(lblConfirmHeadWaktu);
            groupBox2.Controls.Add(lblConfirmHeadTanggal);
            groupBox2.Controls.Add(lblConfirmHeadLayanan);
            groupBox2.Controls.Add(lblConfirmHeadNama);
            groupBox2.Controls.Add(btnSubmit);
            groupBox2.Font = new Font("Bahnschrift Condensed", 11.25F);
            groupBox2.Location = new Point(435, 100);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(300, 315);
            groupBox2.TabIndex = 10;
            groupBox2.TabStop = false;
            groupBox2.Text = "Konfirmasi Pemesanan";
            // 
            // lblConfirmWaktu
            // 
            lblConfirmWaktu.AutoSize = true;
            lblConfirmWaktu.Font = new Font("Bahnschrift Condensed", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblConfirmWaktu.Location = new Point(6, 221);
            lblConfirmWaktu.Name = "lblConfirmWaktu";
            lblConfirmWaktu.Size = new Size(31, 23);
            lblConfirmWaktu.TabIndex = 16;
            lblConfirmWaktu.Text = "---";
            lblConfirmWaktu.TextChanged += lblConfirmWaktu_TextChanged;
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
            lblConfirmTanggal.TextChanged += lblConfirmTanggal_TextChanged;
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
            lblConfirmLayanan.TextChanged += lblConfirmLayanan_TextChanged;
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
            lblConfirmNama.TextChanged += lblConfirmNama_TextChanged;
            // 
            // lblConfirmHeadWaktu
            // 
            lblConfirmHeadWaktu.AutoSize = true;
            lblConfirmHeadWaktu.ForeColor = SystemColors.ControlDarkDark;
            lblConfirmHeadWaktu.Location = new Point(6, 203);
            lblConfirmHeadWaktu.Name = "lblConfirmHeadWaktu";
            lblConfirmHeadWaktu.Size = new Size(92, 18);
            lblConfirmHeadWaktu.TabIndex = 12;
            lblConfirmHeadWaktu.Text = "Waktu kunjungan";
            // 
            // lblConfirmHeadTanggal
            // 
            lblConfirmHeadTanggal.AutoSize = true;
            lblConfirmHeadTanggal.ForeColor = SystemColors.ControlDarkDark;
            lblConfirmHeadTanggal.Location = new Point(6, 145);
            lblConfirmHeadTanggal.Name = "lblConfirmHeadTanggal";
            lblConfirmHeadTanggal.Size = new Size(99, 18);
            lblConfirmHeadTanggal.TabIndex = 11;
            lblConfirmHeadTanggal.Text = "Tanggal kunjungan";
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
            lblConfirmHeadNama.Size = new Size(83, 18);
            lblConfirmHeadNama.TabIndex = 9;
            lblConfirmHeadNama.Text = "Nama pemesan";
            // 
            // lblHeading
            // 
            lblHeading.AutoSize = true;
            lblHeading.Font = new Font("Bahnschrift Condensed", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHeading.ForeColor = Color.FromArgb(44, 62, 80);
            lblHeading.Location = new Point(263, 23);
            lblHeading.Name = "lblHeading";
            lblHeading.Size = new Size(275, 58);
            lblHeading.TabIndex = 11;
            lblHeading.Text = "Buat Reservasi!";
            // 
            // FormBuatReservasi
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(lblHeading);
            Controls.Add(groupBox2);
            Controls.Add(gbxPlanReservasi);
            Controls.Add(btnKembali);
            Name = "FormBuatReservasi";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormBuatReservasi";
            gbxPlanReservasi.ResumeLayout(false);
            gbxPlanReservasi.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnKembali;
        private Label lblLayanan;
        private DateTimePicker dtpTanggal;
        private ComboBox cbxWaktu;
        private Label lblTanggal;
        private Label lblWaktu;
        private Button btnSubmit;
        private GroupBox gbxPlanReservasi;
        private GroupBox groupBox2;
        public Label lblHeading;
        private Label lblConfirmHeadWaktu;
        private Label lblConfirmHeadTanggal;
        private Label lblConfirmHeadLayanan;
        private Label lblConfirmHeadNama;
        private Label lblConfirmNama;
        private Label lblConfirmWaktu;
        private Label lblConfirmTanggal;
        private Label lblConfirmLayanan;
        public ComboBox cbxLayanan;
    }
}