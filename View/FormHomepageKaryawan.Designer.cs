namespace PBOBarberMate.View
{
    partial class FormHomepageKaryawan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHomepageKaryawan));
            lblHomepageGreet = new Label();
            lblWelcome = new Label();
            gbxShowProfile = new GroupBox();
            lblProfilEmail = new Label();
            lblProfilRole = new Label();
            btnUbahProfil = new Button();
            lblProfilNama = new Label();
            btnHomepageLogout = new Button();
            btnProfil = new Button();
            gbxMenu = new GroupBox();
            pictureBox1 = new PictureBox();
            btnInventaris = new Button();
            btnUlasan = new Button();
            pictbxReservasiSekarang = new PictureBox();
            pictbxRiwayat = new PictureBox();
            btnLayanan = new Button();
            pictbxLayanan = new PictureBox();
            btnReservasi = new Button();
            btnPerforma = new Button();
            gbxShowProfile.SuspendLayout();
            gbxMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictbxReservasiSekarang).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictbxRiwayat).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictbxLayanan).BeginInit();
            SuspendLayout();
            // 
            // lblHomepageGreet
            // 
            lblHomepageGreet.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblHomepageGreet.AutoSize = true;
            lblHomepageGreet.Font = new Font("Bahnschrift Condensed", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblHomepageGreet.Location = new Point(36, 33);
            lblHomepageGreet.Margin = new Padding(4, 0, 4, 0);
            lblHomepageGreet.Name = "lblHomepageGreet";
            lblHomepageGreet.Size = new Size(50, 35);
            lblHomepageGreet.TabIndex = 7;
            lblHomepageGreet.Text = "Hai,";
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.Font = new Font("Bahnschrift Condensed", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblWelcome.Location = new Point(26, 67);
            lblWelcome.Margin = new Padding(4, 0, 4, 0);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(269, 87);
            lblWelcome.TabIndex = 6;
            lblWelcome.Text = "Pengguna";
            // 
            // gbxShowProfile
            // 
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
            gbxShowProfile.TabIndex = 9;
            gbxShowProfile.TabStop = false;
            gbxShowProfile.Visible = false;
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
            // btnProfil
            // 
            btnProfil.BackColor = Color.FromArgb(44, 62, 80);
            btnProfil.Font = new Font("Bahnschrift Condensed", 12F);
            btnProfil.ForeColor = Color.White;
            btnProfil.Location = new Point(1043, 17);
            btnProfil.Margin = new Padding(4, 5, 4, 5);
            btnProfil.Name = "btnProfil";
            btnProfil.Size = new Size(79, 60);
            btnProfil.TabIndex = 8;
            btnProfil.Text = "Profil";
            btnProfil.UseVisualStyleBackColor = false;
            btnProfil.Click += btnProfil_Click;
            btnProfil.MouseEnter += btnProfil_MouseEnter;
            btnProfil.MouseLeave += btnProfil_MouseLeave;
            // 
            // gbxMenu
            // 
            gbxMenu.Anchor = AnchorStyles.Top;
            gbxMenu.BackColor = Color.White;
            gbxMenu.Controls.Add(pictureBox1);
            gbxMenu.Controls.Add(btnInventaris);
            gbxMenu.Controls.Add(btnUlasan);
            gbxMenu.Controls.Add(pictbxReservasiSekarang);
            gbxMenu.Controls.Add(pictbxRiwayat);
            gbxMenu.Controls.Add(btnLayanan);
            gbxMenu.Controls.Add(pictbxLayanan);
            gbxMenu.Controls.Add(btnReservasi);
            gbxMenu.Controls.Add(btnPerforma);
            gbxMenu.Location = new Point(157, 200);
            gbxMenu.Margin = new Padding(4, 5, 4, 5);
            gbxMenu.Name = "gbxMenu";
            gbxMenu.Padding = new Padding(4, 5, 4, 5);
            gbxMenu.Size = new Size(850, 245);
            gbxMenu.TabIndex = 10;
            gbxMenu.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(666, 48);
            pictureBox1.Margin = new Padding(4, 5, 4, 5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(143, 72);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 13;
            pictureBox1.TabStop = false;
            // 
            // btnInventaris
            // 
            btnInventaris.Anchor = AnchorStyles.Top;
            btnInventaris.BackColor = Color.White;
            btnInventaris.Font = new Font("Bahnschrift Condensed", 15.75F);
            btnInventaris.ForeColor = Color.FromArgb(44, 62, 80);
            btnInventaris.Location = new Point(637, 25);
            btnInventaris.Margin = new Padding(4, 5, 4, 5);
            btnInventaris.Name = "btnInventaris";
            btnInventaris.Padding = new Padding(13, 15, 13, 15);
            btnInventaris.Size = new Size(200, 208);
            btnInventaris.TabIndex = 12;
            btnInventaris.Text = "Lihat\r\nStok Barang";
            btnInventaris.TextAlign = ContentAlignment.BottomCenter;
            btnInventaris.UseVisualStyleBackColor = false;
            btnInventaris.Click += btnInventaris_Click;
            // 
            // btnUlasan
            // 
            btnUlasan.Anchor = AnchorStyles.Top;
            btnUlasan.BackColor = Color.White;
            btnUlasan.Font = new Font("Bahnschrift Condensed", 15.75F);
            btnUlasan.ForeColor = Color.FromArgb(44, 62, 80);
            btnUlasan.Location = new Point(919, 25);
            btnUlasan.Margin = new Padding(4, 5, 4, 5);
            btnUlasan.Name = "btnUlasan";
            btnUlasan.Padding = new Padding(13, 15, 13, 15);
            btnUlasan.Size = new Size(200, 208);
            btnUlasan.TabIndex = 11;
            btnUlasan.Text = "Beri\r\nPenilaian";
            btnUlasan.TextAlign = ContentAlignment.BottomCenter;
            btnUlasan.UseVisualStyleBackColor = false;
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
            // btnLayanan
            // 
            btnLayanan.Anchor = AnchorStyles.Top;
            btnLayanan.BackColor = Color.White;
            btnLayanan.BackgroundImageLayout = ImageLayout.Zoom;
            btnLayanan.Font = new Font("Bahnschrift Condensed", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLayanan.ForeColor = Color.FromArgb(44, 62, 80);
            btnLayanan.ImageAlign = ContentAlignment.TopCenter;
            btnLayanan.Location = new Point(429, 25);
            btnLayanan.Margin = new Padding(4, 5, 4, 5);
            btnLayanan.Name = "btnLayanan";
            btnLayanan.Padding = new Padding(13, 15, 13, 15);
            btnLayanan.Size = new Size(200, 208);
            btnLayanan.TabIndex = 8;
            btnLayanan.Text = "Layanan Barbeshop";
            btnLayanan.TextAlign = ContentAlignment.BottomCenter;
            btnLayanan.UseVisualStyleBackColor = false;
            btnLayanan.Click += btnLayanan_Click;
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
            btnReservasi.Text = "Presensi Sekarang!";
            btnReservasi.TextAlign = ContentAlignment.BottomCenter;
            btnReservasi.UseVisualStyleBackColor = false;
            // 
            // btnPerforma
            // 
            btnPerforma.Anchor = AnchorStyles.Top;
            btnPerforma.BackColor = Color.White;
            btnPerforma.Font = new Font("Bahnschrift Condensed", 15.75F);
            btnPerforma.ForeColor = Color.FromArgb(44, 62, 80);
            btnPerforma.ImageAlign = ContentAlignment.TopCenter;
            btnPerforma.Location = new Point(220, 25);
            btnPerforma.Margin = new Padding(4, 5, 4, 5);
            btnPerforma.Name = "btnPerforma";
            btnPerforma.Padding = new Padding(13, 15, 13, 15);
            btnPerforma.Size = new Size(200, 208);
            btnPerforma.TabIndex = 0;
            btnPerforma.Text = "Performa\r\n\r\n";
            btnPerforma.TextAlign = ContentAlignment.BottomCenter;
            btnPerforma.UseVisualStyleBackColor = false;
            btnPerforma.Click += btnPerforma_Click;
            // 
            // FormHomepageKaryawan
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1143, 750);
            Controls.Add(gbxShowProfile);
            Controls.Add(gbxMenu);
            Controls.Add(btnProfil);
            Controls.Add(lblHomepageGreet);
            Controls.Add(lblWelcome);
            Margin = new Padding(4, 5, 4, 5);
            Name = "FormHomepageKaryawan";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "BarberMate : Dashboard";
            Click += FormHomepageKaryawan_Click;
            gbxShowProfile.ResumeLayout(false);
            gbxMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictbxReservasiSekarang).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictbxRiwayat).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictbxLayanan).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblHomepageGreet;
        public Label lblWelcome;
        private GroupBox gbxShowProfile;
        private Label lblProfilEmail;
        private Label lblProfilRole;
        private Button btnUbahProfil;
        private Label lblProfilNama;
        private Button btnHomepageLogout;
        private Button btnProfil;
        private GroupBox gbxMenu;
        private Button btnUlasan;
        private PictureBox pictbxReservasiSekarang;
        private PictureBox pictbxRiwayat;
        private Button btnLayanan;
        private PictureBox pictbxLayanan;
        private Button btnReservasi;
        private Button btnPerforma;
        private Button btnInventaris;
        private PictureBox pictureBox1;
    }
}