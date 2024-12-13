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
            btnPresensi = new Button();
            btnPerforma = new Button();
            gbxInfo = new GroupBox();
            pictbxStatusShiftToday = new PictureBox();
            lblStatusShiftToday = new Label();
            lblStatusPresensiToday = new Label();
            lblStatusShiftTodayHeading = new Label();
            pictbxStatusPresensiToday = new PictureBox();
            btnLakukanPresensi = new Button();
            lblStatusPresensiTodayHeading = new Label();
            button2 = new Button();
            gbxShowProfile.SuspendLayout();
            gbxMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictbxReservasiSekarang).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictbxRiwayat).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictbxLayanan).BeginInit();
            gbxInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictbxStatusShiftToday).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictbxStatusPresensiToday).BeginInit();
            SuspendLayout();
            // 
            // lblHomepageGreet
            // 
            lblHomepageGreet.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblHomepageGreet.AutoSize = true;
            lblHomepageGreet.Font = new Font("Bahnschrift Condensed", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblHomepageGreet.Location = new Point(30, 31);
            lblHomepageGreet.Name = "lblHomepageGreet";
            lblHomepageGreet.Size = new Size(33, 23);
            lblHomepageGreet.TabIndex = 7;
            lblHomepageGreet.Text = "Hai,";
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.Font = new Font("Bahnschrift Condensed", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblWelcome.Location = new Point(24, 51);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(181, 58);
            lblWelcome.TabIndex = 6;
            lblWelcome.Text = "Pengguna";
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
            gbxShowProfile.Location = new Point(755, 65);
            gbxShowProfile.Margin = new Padding(0);
            gbxShowProfile.Name = "gbxShowProfile";
            gbxShowProfile.Size = new Size(170, 144);
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
            lblProfilEmail.Location = new Point(6, 80);
            lblProfilEmail.Name = "lblProfilEmail";
            lblProfilEmail.Size = new Size(158, 22);
            lblProfilEmail.TabIndex = 3;
            lblProfilEmail.Text = "isi_email";
            lblProfilEmail.TextAlign = ContentAlignment.TopRight;
            // 
            // lblProfilRole
            // 
            lblProfilRole.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblProfilRole.Font = new Font("Bahnschrift SemiLight Condensed", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblProfilRole.ForeColor = Color.White;
            lblProfilRole.Location = new Point(6, 15);
            lblProfilRole.Name = "lblProfilRole";
            lblProfilRole.Size = new Size(158, 21);
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
            btnUbahProfil.Location = new Point(75, 108);
            btnUbahProfil.Name = "btnUbahProfil";
            btnUbahProfil.Size = new Size(39, 30);
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
            lblProfilNama.Location = new Point(6, 34);
            lblProfilNama.Name = "lblProfilNama";
            lblProfilNama.Size = new Size(158, 42);
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
            btnHomepageLogout.Location = new Point(120, 108);
            btnHomepageLogout.Name = "btnHomepageLogout";
            btnHomepageLogout.Size = new Size(43, 30);
            btnHomepageLogout.TabIndex = 1;
            btnHomepageLogout.Text = "Logout";
            btnHomepageLogout.UseVisualStyleBackColor = false;
            btnHomepageLogout.Click += btnHomepageLogout_Click;
            btnHomepageLogout.MouseEnter += btnHomepageLogout_MouseEnter;
            btnHomepageLogout.MouseLeave += btnHomepageLogout_MouseLeave;
            // 
            // btnProfil
            // 
            btnProfil.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnProfil.BackColor = Color.FromArgb(44, 62, 80);
            btnProfil.Font = new Font("Bahnschrift Condensed", 12F);
            btnProfil.ForeColor = Color.White;
            btnProfil.Location = new Point(870, 25);
            btnProfil.Name = "btnProfil";
            btnProfil.Size = new Size(55, 36);
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
            gbxMenu.BackColor = Color.Transparent;
            gbxMenu.Controls.Add(pictureBox1);
            gbxMenu.Controls.Add(btnInventaris);
            gbxMenu.Controls.Add(btnUlasan);
            gbxMenu.Controls.Add(pictbxReservasiSekarang);
            gbxMenu.Controls.Add(pictbxRiwayat);
            gbxMenu.Controls.Add(btnLayanan);
            gbxMenu.Controls.Add(pictbxLayanan);
            gbxMenu.Controls.Add(btnPresensi);
            gbxMenu.Controls.Add(btnPerforma);
            gbxMenu.Location = new Point(182, 145);
            gbxMenu.Name = "gbxMenu";
            gbxMenu.Size = new Size(595, 147);
            gbxMenu.TabIndex = 10;
            gbxMenu.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(466, 28);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 44);
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
            btnInventaris.Location = new Point(446, 15);
            btnInventaris.Name = "btnInventaris";
            btnInventaris.Padding = new Padding(9);
            btnInventaris.Size = new Size(140, 124);
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
            btnUlasan.Location = new Point(643, 15);
            btnUlasan.Name = "btnUlasan";
            btnUlasan.Padding = new Padding(9);
            btnUlasan.Size = new Size(140, 124);
            btnUlasan.TabIndex = 11;
            btnUlasan.Text = "Beri\r\nPenilaian";
            btnUlasan.TextAlign = ContentAlignment.BottomCenter;
            btnUlasan.UseVisualStyleBackColor = false;
            // 
            // pictbxReservasiSekarang
            // 
            pictbxReservasiSekarang.Anchor = AnchorStyles.Top;
            pictbxReservasiSekarang.Image = (Image)resources.GetObject("pictbxReservasiSekarang.Image");
            pictbxReservasiSekarang.Location = new Point(28, 28);
            pictbxReservasiSekarang.Name = "pictbxReservasiSekarang";
            pictbxReservasiSekarang.Size = new Size(100, 44);
            pictbxReservasiSekarang.SizeMode = PictureBoxSizeMode.CenterImage;
            pictbxReservasiSekarang.TabIndex = 10;
            pictbxReservasiSekarang.TabStop = false;
            // 
            // pictbxRiwayat
            // 
            pictbxRiwayat.Anchor = AnchorStyles.Top;
            pictbxRiwayat.BackColor = Color.Transparent;
            pictbxRiwayat.Image = (Image)resources.GetObject("pictbxRiwayat.Image");
            pictbxRiwayat.Location = new Point(320, 28);
            pictbxRiwayat.Name = "pictbxRiwayat";
            pictbxRiwayat.Size = new Size(102, 44);
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
            btnLayanan.Location = new Point(300, 15);
            btnLayanan.Name = "btnLayanan";
            btnLayanan.Padding = new Padding(9);
            btnLayanan.Size = new Size(140, 124);
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
            pictbxLayanan.Location = new Point(174, 28);
            pictbxLayanan.Name = "pictbxLayanan";
            pictbxLayanan.Size = new Size(102, 44);
            pictbxLayanan.SizeMode = PictureBoxSizeMode.CenterImage;
            pictbxLayanan.TabIndex = 7;
            pictbxLayanan.TabStop = false;
            // 
            // btnPresensi
            // 
            btnPresensi.Anchor = AnchorStyles.Top;
            btnPresensi.BackColor = Color.White;
            btnPresensi.BackgroundImageLayout = ImageLayout.Zoom;
            btnPresensi.Font = new Font("Bahnschrift Condensed", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnPresensi.ForeColor = Color.FromArgb(44, 62, 80);
            btnPresensi.ImageAlign = ContentAlignment.TopCenter;
            btnPresensi.Location = new Point(8, 15);
            btnPresensi.Name = "btnPresensi";
            btnPresensi.Padding = new Padding(9);
            btnPresensi.Size = new Size(140, 124);
            btnPresensi.TabIndex = 1;
            btnPresensi.Text = "Lihat\r\nPresensi";
            btnPresensi.TextAlign = ContentAlignment.BottomCenter;
            btnPresensi.UseVisualStyleBackColor = false;
            btnPresensi.Click += btnReservasi_Click;
            // 
            // btnPerforma
            // 
            btnPerforma.Anchor = AnchorStyles.Top;
            btnPerforma.BackColor = Color.White;
            btnPerforma.Font = new Font("Bahnschrift Condensed", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnPerforma.ForeColor = Color.FromArgb(44, 62, 80);
            btnPerforma.ImageAlign = ContentAlignment.TopCenter;
            btnPerforma.Location = new Point(154, 15);
            btnPerforma.Name = "btnPerforma";
            btnPerforma.Padding = new Padding(9);
            btnPerforma.Size = new Size(140, 124);
            btnPerforma.TabIndex = 0;
            btnPerforma.Text = "Performa &&\r\nPelayanan Anda";
            btnPerforma.TextAlign = ContentAlignment.BottomCenter;
            btnPerforma.UseVisualStyleBackColor = false;
            // 
            // gbxInfo
            // 
            gbxInfo.Anchor = AnchorStyles.Top;
            gbxInfo.BackColor = Color.Transparent;
            gbxInfo.Controls.Add(pictbxStatusShiftToday);
            gbxInfo.Controls.Add(lblStatusShiftToday);
            gbxInfo.Controls.Add(lblStatusPresensiToday);
            gbxInfo.Controls.Add(lblStatusShiftTodayHeading);
            gbxInfo.Controls.Add(pictbxStatusPresensiToday);
            gbxInfo.Controls.Add(btnLakukanPresensi);
            gbxInfo.Controls.Add(lblStatusPresensiTodayHeading);
            gbxInfo.Controls.Add(button2);
            gbxInfo.Location = new Point(182, 301);
            gbxInfo.Name = "gbxInfo";
            gbxInfo.Size = new Size(595, 94);
            gbxInfo.TabIndex = 11;
            gbxInfo.TabStop = false;
            // 
            // pictbxStatusShiftToday
            // 
            pictbxStatusShiftToday.Anchor = AnchorStyles.Top;
            pictbxStatusShiftToday.Image = (Image)resources.GetObject("pictbxStatusShiftToday.Image");
            pictbxStatusShiftToday.Location = new Point(12, 29);
            pictbxStatusShiftToday.Name = "pictbxStatusShiftToday";
            pictbxStatusShiftToday.Size = new Size(44, 44);
            pictbxStatusShiftToday.SizeMode = PictureBoxSizeMode.CenterImage;
            pictbxStatusShiftToday.TabIndex = 18;
            pictbxStatusShiftToday.TabStop = false;
            // 
            // lblStatusShiftToday
            // 
            lblStatusShiftToday.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblStatusShiftToday.AutoSize = true;
            lblStatusShiftToday.BackColor = Color.Transparent;
            lblStatusShiftToday.Font = new Font("Bahnschrift SemiLight Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblStatusShiftToday.ForeColor = Color.Black;
            lblStatusShiftToday.Location = new Point(64, 52);
            lblStatusShiftToday.Name = "lblStatusShiftToday";
            lblStatusShiftToday.Size = new Size(53, 19);
            lblStatusShiftToday.TabIndex = 17;
            lblStatusShiftToday.Text = "teksHari";
            // 
            // lblStatusPresensiToday
            // 
            lblStatusPresensiToday.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblStatusPresensiToday.AutoSize = true;
            lblStatusPresensiToday.BackColor = Color.Transparent;
            lblStatusPresensiToday.Font = new Font("Bahnschrift SemiLight Condensed", 12F);
            lblStatusPresensiToday.ForeColor = Color.Black;
            lblStatusPresensiToday.Location = new Point(265, 52);
            lblStatusPresensiToday.Name = "lblStatusPresensiToday";
            lblStatusPresensiToday.Size = new Size(15, 19);
            lblStatusPresensiToday.TabIndex = 16;
            lblStatusPresensiToday.Text = "-";
            // 
            // lblStatusShiftTodayHeading
            // 
            lblStatusShiftTodayHeading.AutoSize = true;
            lblStatusShiftTodayHeading.Font = new Font("Bahnschrift Condensed", 15.75F);
            lblStatusShiftTodayHeading.ForeColor = Color.FromArgb(44, 62, 80);
            lblStatusShiftTodayHeading.Location = new Point(62, 27);
            lblStatusShiftTodayHeading.Name = "lblStatusShiftTodayHeading";
            lblStatusShiftTodayHeading.Size = new Size(99, 25);
            lblStatusShiftTodayHeading.TabIndex = 15;
            lblStatusShiftTodayHeading.Text = "Shift Hari ini";
            // 
            // pictbxStatusPresensiToday
            // 
            pictbxStatusPresensiToday.Anchor = AnchorStyles.Top;
            pictbxStatusPresensiToday.Image = (Image)resources.GetObject("pictbxStatusPresensiToday.Image");
            pictbxStatusPresensiToday.Location = new Point(214, 27);
            pictbxStatusPresensiToday.Name = "pictbxStatusPresensiToday";
            pictbxStatusPresensiToday.Size = new Size(44, 44);
            pictbxStatusPresensiToday.SizeMode = PictureBoxSizeMode.CenterImage;
            pictbxStatusPresensiToday.TabIndex = 14;
            pictbxStatusPresensiToday.TabStop = false;
            // 
            // btnLakukanPresensi
            // 
            btnLakukanPresensi.Anchor = AnchorStyles.Top;
            btnLakukanPresensi.BackColor = Color.White;
            btnLakukanPresensi.BackgroundImageLayout = ImageLayout.Zoom;
            btnLakukanPresensi.Font = new Font("Bahnschrift Condensed", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLakukanPresensi.ForeColor = Color.FromArgb(44, 62, 80);
            btnLakukanPresensi.ImageAlign = ContentAlignment.TopCenter;
            btnLakukanPresensi.Location = new Point(446, 15);
            btnLakukanPresensi.Name = "btnLakukanPresensi";
            btnLakukanPresensi.Padding = new Padding(9);
            btnLakukanPresensi.Size = new Size(140, 72);
            btnLakukanPresensi.TabIndex = 13;
            btnLakukanPresensi.Text = "Presensi Sekarang!";
            btnLakukanPresensi.UseVisualStyleBackColor = false;
            btnLakukanPresensi.Click += btnLakukanPresensi_Click;
            // 
            // lblStatusPresensiTodayHeading
            // 
            lblStatusPresensiTodayHeading.AutoSize = true;
            lblStatusPresensiTodayHeading.Font = new Font("Bahnschrift Condensed", 15.75F);
            lblStatusPresensiTodayHeading.ForeColor = Color.FromArgb(44, 62, 80);
            lblStatusPresensiTodayHeading.Location = new Point(264, 27);
            lblStatusPresensiTodayHeading.Name = "lblStatusPresensiTodayHeading";
            lblStatusPresensiTodayHeading.Size = new Size(126, 25);
            lblStatusPresensiTodayHeading.TabIndex = 12;
            lblStatusPresensiTodayHeading.Text = "Presensi Hari ini";
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Top;
            button2.BackColor = Color.White;
            button2.Font = new Font("Bahnschrift Condensed", 15.75F);
            button2.ForeColor = Color.FromArgb(44, 62, 80);
            button2.Location = new Point(840, 15);
            button2.Name = "button2";
            button2.Padding = new Padding(9);
            button2.Size = new Size(140, 124);
            button2.TabIndex = 11;
            button2.Text = "Beri\r\nPenilaian";
            button2.TextAlign = ContentAlignment.BottomCenter;
            button2.UseVisualStyleBackColor = false;
            // 
            // FormHomepageKaryawan
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(944, 501);
            Controls.Add(gbxInfo);
            Controls.Add(gbxShowProfile);
            Controls.Add(gbxMenu);
            Controls.Add(btnProfil);
            Controls.Add(lblHomepageGreet);
            Controls.Add(lblWelcome);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormHomepageKaryawan";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "BarberMate : Dashboard Karyawan";
            Load += FormHomepageKaryawan_Load;
            Click += FormHomepageKaryawan_Click;
            gbxShowProfile.ResumeLayout(false);
            gbxMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictbxReservasiSekarang).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictbxRiwayat).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictbxLayanan).EndInit();
            gbxInfo.ResumeLayout(false);
            gbxInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictbxStatusShiftToday).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictbxStatusPresensiToday).EndInit();
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
        private Button btnPresensi;
        private Button btnPerforma;
        private Button btnInventaris;
        private PictureBox pictureBox1;
        private GroupBox gbxInfo;
        private Label lblStatusPresensiTodayHeading;
        private Button button2;
        private PictureBox pictbxStatusPresensiToday;
        private Button btnLakukanPresensi;
        private Label lblStatusShiftTodayHeading;
        private Label lblStatusShiftToday;
        private Label lblStatusPresensiToday;
        private PictureBox pictbxStatusShiftToday;
    }
}