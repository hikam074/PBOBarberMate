namespace PBOBarberMate.View
{
    partial class FormHomepageCustomer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHomepageCustomer));
            lblProfilEmail = new Label();
            lblProfilRole = new Label();
            lblProfilNama = new Label();
            gbxShowProfile = new GroupBox();
            btnUbahProfil = new Button();
            btnHomepageLogout = new Button();
            lblHomepageGreet = new Label();
            btnProfil = new Button();
            pictbxLayanan = new PictureBox();
            btnReservasi = new Button();
            btnLayanan = new Button();
            gbxMenu = new GroupBox();
            pictbxUlasan = new PictureBox();
            btnUlasan = new Button();
            pictbxReservasiSekarang = new PictureBox();
            pictbxRiwayat = new PictureBox();
            btnLihatReservasi = new Button();
            lblWelcome = new Label();
            dgvJadwalMingguIni = new DataGridView();
            lblJadwalMingguIni = new Label();
            lklbMore = new LinkLabel();
            gbxShowProfile.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictbxLayanan).BeginInit();
            gbxMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictbxUlasan).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictbxReservasiSekarang).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictbxRiwayat).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvJadwalMingguIni).BeginInit();
            SuspendLayout();
            // 
            // lblProfilEmail
            // 
            lblProfilEmail.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblProfilEmail.BackColor = Color.Transparent;
            lblProfilEmail.Font = new Font("Bahnschrift Light Condensed", 9F);
            lblProfilEmail.ForeColor = Color.White;
            lblProfilEmail.Location = new Point(9, 133);
            lblProfilEmail.Margin = new Padding(4, 0, 4, 0);
            lblProfilEmail.Name = "lblProfilEmail";
            lblProfilEmail.Size = new Size(226, 38);
            lblProfilEmail.TabIndex = 3;
            lblProfilEmail.Text = "isi_email";
            lblProfilEmail.TextAlign = ContentAlignment.TopRight;
            // 
            // lblProfilRole
            // 
            lblProfilRole.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblProfilRole.Font = new Font("Bahnschrift SemiLight Condensed", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblProfilRole.ForeColor = Color.White;
            lblProfilRole.Location = new Point(9, 25);
            lblProfilRole.Margin = new Padding(4, 0, 4, 0);
            lblProfilRole.Name = "lblProfilRole";
            lblProfilRole.Size = new Size(226, 35);
            lblProfilRole.TabIndex = 2;
            lblProfilRole.Text = "nama_role";
            lblProfilRole.TextAlign = ContentAlignment.TopRight;
            // 
            // lblProfilNama
            // 
            lblProfilNama.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblProfilNama.Font = new Font("Bahnschrift Condensed", 11.25F);
            lblProfilNama.ForeColor = Color.White;
            lblProfilNama.Location = new Point(9, 58);
            lblProfilNama.Margin = new Padding(4, 0, 4, 0);
            lblProfilNama.Name = "lblProfilNama";
            lblProfilNama.Size = new Size(226, 70);
            lblProfilNama.TabIndex = 0;
            lblProfilNama.Text = "Nama_Pengguna";
            lblProfilNama.TextAlign = ContentAlignment.TopRight;
            // 
            // gbxShowProfile
            // 
            gbxShowProfile.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            gbxShowProfile.BackColor = Color.FromArgb(44, 62, 80);
            gbxShowProfile.Controls.Add(lblProfilEmail);
            gbxShowProfile.Controls.Add(lblProfilRole);
            gbxShowProfile.Controls.Add(btnUbahProfil);
            gbxShowProfile.Controls.Add(lblProfilNama);
            gbxShowProfile.Controls.Add(btnHomepageLogout);
            gbxShowProfile.ForeColor = Color.FromArgb(44, 62, 80);
            gbxShowProfile.Location = new Point(879, 83);
            gbxShowProfile.Margin = new Padding(0);
            gbxShowProfile.Name = "gbxShowProfile";
            gbxShowProfile.Padding = new Padding(4, 5, 4, 5);
            gbxShowProfile.Size = new Size(243, 240);
            gbxShowProfile.TabIndex = 11;
            gbxShowProfile.TabStop = false;
            gbxShowProfile.Visible = false;
            // 
            // btnUbahProfil
            // 
            btnUbahProfil.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnUbahProfil.BackColor = SystemColors.Control;
            btnUbahProfil.Font = new Font("Bahnschrift Light Condensed", 9F);
            btnUbahProfil.ForeColor = Color.FromArgb(44, 62, 80);
            btnUbahProfil.Location = new Point(107, 180);
            btnUbahProfil.Margin = new Padding(4, 5, 4, 5);
            btnUbahProfil.Name = "btnUbahProfil";
            btnUbahProfil.Size = new Size(56, 50);
            btnUbahProfil.TabIndex = 1;
            btnUbahProfil.Text = "Ubah";
            btnUbahProfil.UseVisualStyleBackColor = false;
            btnUbahProfil.Click += btnUbahProfil_Click;
            btnUbahProfil.MouseEnter += btnUbahProfil_MouseEnter;
            btnUbahProfil.MouseLeave += btnUbahProfil_MouseLeave;
            // 
            // btnHomepageLogout
            // 
            btnHomepageLogout.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnHomepageLogout.BackColor = SystemColors.Control;
            btnHomepageLogout.Font = new Font("Bahnschrift Light Condensed", 9F);
            btnHomepageLogout.ForeColor = Color.FromArgb(44, 62, 80);
            btnHomepageLogout.Location = new Point(171, 180);
            btnHomepageLogout.Margin = new Padding(4, 5, 4, 5);
            btnHomepageLogout.Name = "btnHomepageLogout";
            btnHomepageLogout.Size = new Size(61, 50);
            btnHomepageLogout.TabIndex = 1;
            btnHomepageLogout.Text = "Logout";
            btnHomepageLogout.UseVisualStyleBackColor = false;
            btnHomepageLogout.Click += btnHomepageLogout_Click;
            btnHomepageLogout.MouseEnter += btnHomepageLogout_MouseEnter;
            btnHomepageLogout.MouseLeave += btnHomepageLogout_MouseLeave;
            // 
            // lblHomepageGreet
            // 
            lblHomepageGreet.AutoSize = true;
            lblHomepageGreet.Font = new Font("Bahnschrift Condensed", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblHomepageGreet.ForeColor = Color.FromArgb(44, 62, 80);
            lblHomepageGreet.Location = new Point(36, 33);
            lblHomepageGreet.Margin = new Padding(4, 0, 4, 0);
            lblHomepageGreet.Name = "lblHomepageGreet";
            lblHomepageGreet.Size = new Size(50, 35);
            lblHomepageGreet.TabIndex = 10;
            lblHomepageGreet.Text = "Hai,";
            // 
            // btnProfil
            // 
            btnProfil.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnProfil.BackColor = Color.FromArgb(44, 62, 80);
            btnProfil.Font = new Font("Bahnschrift Condensed", 12F);
            btnProfil.ForeColor = Color.White;
            btnProfil.Location = new Point(1043, 17);
            btnProfil.Margin = new Padding(4, 5, 4, 5);
            btnProfil.Name = "btnProfil";
            btnProfil.Size = new Size(79, 60);
            btnProfil.TabIndex = 9;
            btnProfil.Text = "Profil";
            btnProfil.UseVisualStyleBackColor = false;
            btnProfil.Click += btnProfil_Click;
            btnProfil.MouseEnter += btnProfil_MouseEnter;
            btnProfil.MouseLeave += btnProfil_MouseLeave;
            // 
            // pictbxLayanan
            // 
            pictbxLayanan.Anchor = AnchorStyles.Top;
            pictbxLayanan.BackColor = Color.Transparent;
            pictbxLayanan.Image = (Image)resources.GetObject("pictbxLayanan.Image");
            pictbxLayanan.Location = new Point(249, 48);
            pictbxLayanan.Margin = new Padding(4, 5, 4, 5);
            pictbxLayanan.Name = "pictbxLayanan";
            pictbxLayanan.Size = new Size(146, 72);
            pictbxLayanan.SizeMode = PictureBoxSizeMode.CenterImage;
            pictbxLayanan.TabIndex = 7;
            pictbxLayanan.TabStop = false;
            // 
            // btnReservasi
            // 
            btnReservasi.Anchor = AnchorStyles.Top;
            btnReservasi.BackColor = Color.White;
            btnReservasi.BackgroundImageLayout = ImageLayout.Zoom;
            btnReservasi.Font = new Font("Bahnschrift Condensed", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnReservasi.ForeColor = Color.FromArgb(44, 62, 80);
            btnReservasi.ImageAlign = ContentAlignment.TopCenter;
            btnReservasi.Location = new Point(11, 25);
            btnReservasi.Margin = new Padding(4, 5, 4, 5);
            btnReservasi.Name = "btnReservasi";
            btnReservasi.Padding = new Padding(13, 15, 13, 15);
            btnReservasi.Size = new Size(200, 208);
            btnReservasi.TabIndex = 1;
            btnReservasi.Text = "Reservasi Sekarang!";
            btnReservasi.TextAlign = ContentAlignment.BottomCenter;
            btnReservasi.UseVisualStyleBackColor = false;
            btnReservasi.Click += btnReservasi_Click;
            // 
            // btnLayanan
            // 
            btnLayanan.Anchor = AnchorStyles.Top;
            btnLayanan.BackColor = Color.White;
            btnLayanan.Font = new Font("Bahnschrift Condensed", 15.75F);
            btnLayanan.ForeColor = Color.FromArgb(44, 62, 80);
            btnLayanan.ImageAlign = ContentAlignment.TopCenter;
            btnLayanan.Location = new Point(220, 25);
            btnLayanan.Margin = new Padding(4, 5, 4, 5);
            btnLayanan.Name = "btnLayanan";
            btnLayanan.Padding = new Padding(13, 15, 13, 15);
            btnLayanan.Size = new Size(200, 208);
            btnLayanan.TabIndex = 0;
            btnLayanan.Text = "Lihat\r\nLayanan";
            btnLayanan.TextAlign = ContentAlignment.BottomCenter;
            btnLayanan.UseVisualStyleBackColor = false;
            btnLayanan.Click += btnLayanan_Click;
            // 
            // gbxMenu
            // 
            gbxMenu.Anchor = AnchorStyles.Top;
            gbxMenu.BackColor = Color.White;
            gbxMenu.Controls.Add(pictbxUlasan);
            gbxMenu.Controls.Add(btnUlasan);
            gbxMenu.Controls.Add(pictbxReservasiSekarang);
            gbxMenu.Controls.Add(pictbxRiwayat);
            gbxMenu.Controls.Add(btnLihatReservasi);
            gbxMenu.Controls.Add(pictbxLayanan);
            gbxMenu.Controls.Add(btnReservasi);
            gbxMenu.Controls.Add(btnLayanan);
            gbxMenu.Location = new Point(157, 200);
            gbxMenu.Margin = new Padding(4, 5, 4, 5);
            gbxMenu.Name = "gbxMenu";
            gbxMenu.Padding = new Padding(4, 5, 4, 5);
            gbxMenu.Size = new Size(850, 245);
            gbxMenu.TabIndex = 8;
            gbxMenu.TabStop = false;
            // 
            // pictbxUlasan
            // 
            pictbxUlasan.Anchor = AnchorStyles.Top;
            pictbxUlasan.Image = (Image)resources.GetObject("pictbxUlasan.Image");
            pictbxUlasan.Location = new Point(666, 48);
            pictbxUlasan.Margin = new Padding(4, 5, 4, 5);
            pictbxUlasan.Name = "pictbxUlasan";
            pictbxUlasan.Size = new Size(143, 72);
            pictbxUlasan.SizeMode = PictureBoxSizeMode.CenterImage;
            pictbxUlasan.TabIndex = 12;
            pictbxUlasan.TabStop = false;
            // 
            // btnUlasan
            // 
            btnUlasan.Anchor = AnchorStyles.Top;
            btnUlasan.BackColor = Color.White;
            btnUlasan.Font = new Font("Bahnschrift Condensed", 15.75F);
            btnUlasan.ForeColor = Color.FromArgb(44, 62, 80);
            btnUlasan.Location = new Point(637, 25);
            btnUlasan.Margin = new Padding(4, 5, 4, 5);
            btnUlasan.Name = "btnUlasan";
            btnUlasan.Padding = new Padding(13, 15, 13, 15);
            btnUlasan.Size = new Size(200, 208);
            btnUlasan.TabIndex = 11;
            btnUlasan.Text = "Beri\r\nPenilaian";
            btnUlasan.TextAlign = ContentAlignment.BottomCenter;
            btnUlasan.UseVisualStyleBackColor = false;
            btnUlasan.Click += btnUlasan_Click;
            // 
            // pictbxReservasiSekarang
            // 
            pictbxReservasiSekarang.Anchor = AnchorStyles.Top;
            pictbxReservasiSekarang.Image = (Image)resources.GetObject("pictbxReservasiSekarang.Image");
            pictbxReservasiSekarang.Location = new Point(40, 48);
            pictbxReservasiSekarang.Margin = new Padding(4, 5, 4, 5);
            pictbxReservasiSekarang.Name = "pictbxReservasiSekarang";
            pictbxReservasiSekarang.Size = new Size(143, 72);
            pictbxReservasiSekarang.SizeMode = PictureBoxSizeMode.CenterImage;
            pictbxReservasiSekarang.TabIndex = 10;
            pictbxReservasiSekarang.TabStop = false;
            // 
            // pictbxRiwayat
            // 
            pictbxRiwayat.Anchor = AnchorStyles.Top;
            pictbxRiwayat.BackColor = Color.Transparent;
            pictbxRiwayat.Image = (Image)resources.GetObject("pictbxRiwayat.Image");
            pictbxRiwayat.Location = new Point(457, 48);
            pictbxRiwayat.Margin = new Padding(4, 5, 4, 5);
            pictbxRiwayat.Name = "pictbxRiwayat";
            pictbxRiwayat.Size = new Size(146, 72);
            pictbxRiwayat.SizeMode = PictureBoxSizeMode.CenterImage;
            pictbxRiwayat.TabIndex = 9;
            pictbxRiwayat.TabStop = false;
            // 
            // btnLihatReservasi
            // 
            btnLihatReservasi.Anchor = AnchorStyles.Top;
            btnLihatReservasi.BackColor = Color.White;
            btnLihatReservasi.BackgroundImageLayout = ImageLayout.Zoom;
            btnLihatReservasi.Font = new Font("Bahnschrift Condensed", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLihatReservasi.ForeColor = Color.FromArgb(44, 62, 80);
            btnLihatReservasi.ImageAlign = ContentAlignment.TopCenter;
            btnLihatReservasi.Location = new Point(300, 15);
            btnLihatReservasi.Name = "btnLihatReservasi";
            btnLihatReservasi.Padding = new Padding(9);
            btnLihatReservasi.Size = new Size(140, 125);
            btnLihatReservasi.TabIndex = 8;
            btnLihatReservasi.Text = "Reservasi Anda";
            btnLihatReservasi.TextAlign = ContentAlignment.BottomCenter;
            btnLihatReservasi.UseVisualStyleBackColor = false;
            btnLihatReservasi.Click += btnLihatReservasi_Click;
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.Font = new Font("Bahnschrift Condensed", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblWelcome.ForeColor = Color.FromArgb(44, 62, 80);
            lblWelcome.Location = new Point(26, 67);
            lblWelcome.Margin = new Padding(4, 0, 4, 0);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(269, 87);
            lblWelcome.TabIndex = 7;
            lblWelcome.Text = "Pengguna";
            // 
            // dgvJadwalMingguIni
            // 
            dgvJadwalMingguIni.Anchor = AnchorStyles.Top;
            dgvJadwalMingguIni.BackgroundColor = Color.White;
            dgvJadwalMingguIni.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvJadwalMingguIni.GridColor = Color.FromArgb(44, 62, 80);
            dgvJadwalMingguIni.Location = new Point(160, 533);
            dgvJadwalMingguIni.Margin = new Padding(4, 5, 4, 5);
            dgvJadwalMingguIni.Name = "dgvJadwalMingguIni";
            dgvJadwalMingguIni.RowHeadersWidth = 62;
            dgvJadwalMingguIni.Size = new Size(850, 162);
            dgvJadwalMingguIni.TabIndex = 12;
            // 
            // lblJadwalMingguIni
            // 
            lblJadwalMingguIni.Anchor = AnchorStyles.Top;
            lblJadwalMingguIni.AutoSize = true;
            lblJadwalMingguIni.Font = new Font("Bahnschrift Condensed", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblJadwalMingguIni.ForeColor = Color.FromArgb(44, 62, 80);
            lblJadwalMingguIni.Location = new Point(160, 490);
            lblJadwalMingguIni.Margin = new Padding(4, 0, 4, 0);
            lblJadwalMingguIni.Name = "lblJadwalMingguIni";
            lblJadwalMingguIni.Size = new Size(261, 35);
            lblJadwalMingguIni.TabIndex = 13;
            lblJadwalMingguIni.Text = "Reservasi terdekat anda :";
            // 
            // lklbMore
            // 
            lklbMore.Anchor = AnchorStyles.Top;
            lklbMore.AutoSize = true;
            lklbMore.Location = new Point(850, 700);
            lklbMore.Margin = new Padding(4, 0, 4, 0);
            lklbMore.Name = "lklbMore";
            lklbMore.Size = new Size(166, 25);
            lklbMore.TabIndex = 14;
            lklbMore.TabStop = true;
            lklbMore.Text = "Lihat lebih banyak...";
            lklbMore.LinkClicked += lklbMore_LinkClicked;
            // 
            // FormHomepageCustomer
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1143, 750);
            Controls.Add(lklbMore);
            Controls.Add(lblJadwalMingguIni);
            Controls.Add(dgvJadwalMingguIni);
            Controls.Add(gbxShowProfile);
            Controls.Add(lblHomepageGreet);
            Controls.Add(btnProfil);
            Controls.Add(gbxMenu);
            Controls.Add(lblWelcome);
            Margin = new Padding(4, 5, 4, 5);
            Name = "FormHomepageCustomer";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "BarberMate : Dashboard";
            Load += FormHomepageCustomer_Load;
            Click += FormHomepageCustomer_Click;
            gbxShowProfile.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictbxLayanan).EndInit();
            gbxMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictbxUlasan).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictbxReservasiSekarang).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictbxRiwayat).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvJadwalMingguIni).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblProfilEmail;
        private Label lblProfilRole;
        private Label lblProfilNama;
        private GroupBox gbxShowProfile;
        private Button btnUbahProfil;
        private Button btnHomepageLogout;
        private Label lblHomepageGreet;
        private Button btnProfil;
        private PictureBox pictbxLayanan;
        private Button btnReservasi;
        private Button btnLayanan;
        private GroupBox gbxMenu;
        public Label lblWelcome;
        private PictureBox pictbxRiwayat;
        private Button btnLihatReservasi;
        private PictureBox pictbxReservasiSekarang;
        private DataGridView dgvJadwalMingguIni;
        private Label lblJadwalMingguIni;
        private LinkLabel lklbMore;
        private Button btnUlasan;
        private PictureBox pictbxUlasan;
    }
}