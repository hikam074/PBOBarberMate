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
            button1 = new Button();
            btnUlasan = new Button();
            pictbxReservasiSekarang = new PictureBox();
            pictbxRiwayat = new PictureBox();
            btnRiwayat = new Button();
            pictbxLayanan = new PictureBox();
            btnReservasi = new Button();
            btnLayanan = new Button();
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
            lblHomepageGreet.Location = new Point(25, 20);
            lblHomepageGreet.Name = "lblHomepageGreet";
            lblHomepageGreet.Size = new Size(33, 23);
            lblHomepageGreet.TabIndex = 7;
            lblHomepageGreet.Text = "Hai,";
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.Font = new Font("Bahnschrift Condensed", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblWelcome.Location = new Point(18, 40);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(181, 58);
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
            gbxShowProfile.Location = new Point(615, 50);
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
            lblProfilEmail.Size = new Size(158, 23);
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
            lblProfilNama.Location = new Point(6, 35);
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
            btnProfil.BackColor = Color.FromArgb(44, 62, 80);
            btnProfil.Font = new Font("Bahnschrift Condensed", 12F);
            btnProfil.ForeColor = Color.White;
            btnProfil.Location = new Point(730, 10);
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
            gbxMenu.BackColor = Color.White;
            gbxMenu.Controls.Add(pictureBox1);
            gbxMenu.Controls.Add(button1);
            gbxMenu.Controls.Add(btnUlasan);
            gbxMenu.Controls.Add(pictbxReservasiSekarang);
            gbxMenu.Controls.Add(pictbxRiwayat);
            gbxMenu.Controls.Add(btnRiwayat);
            gbxMenu.Controls.Add(pictbxLayanan);
            gbxMenu.Controls.Add(btnReservasi);
            gbxMenu.Controls.Add(btnLayanan);
            gbxMenu.Location = new Point(110, 120);
            gbxMenu.Name = "gbxMenu";
            gbxMenu.Size = new Size(595, 147);
            gbxMenu.TabIndex = 10;
            gbxMenu.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(466, 29);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 43);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 13;
            pictureBox1.TabStop = false;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top;
            button1.BackColor = Color.White;
            button1.Font = new Font("Bahnschrift Condensed", 15.75F);
            button1.ForeColor = Color.FromArgb(44, 62, 80);
            button1.Location = new Point(446, 15);
            button1.Name = "button1";
            button1.Padding = new Padding(9);
            button1.Size = new Size(140, 125);
            button1.TabIndex = 12;
            button1.Text = "Lihat\r\nStok Barang";
            button1.TextAlign = ContentAlignment.BottomCenter;
            button1.UseVisualStyleBackColor = false;
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
            btnUlasan.Size = new Size(140, 125);
            btnUlasan.TabIndex = 11;
            btnUlasan.Text = "Beri\r\nPenilaian";
            btnUlasan.TextAlign = ContentAlignment.BottomCenter;
            btnUlasan.UseVisualStyleBackColor = false;
            // 
            // pictbxReservasiSekarang
            // 
            pictbxReservasiSekarang.Anchor = AnchorStyles.Top;
            pictbxReservasiSekarang.Image = (Image)resources.GetObject("pictbxReservasiSekarang.Image");
            pictbxReservasiSekarang.Location = new Point(28, 29);
            pictbxReservasiSekarang.Name = "pictbxReservasiSekarang";
            pictbxReservasiSekarang.Size = new Size(100, 43);
            pictbxReservasiSekarang.SizeMode = PictureBoxSizeMode.CenterImage;
            pictbxReservasiSekarang.TabIndex = 10;
            pictbxReservasiSekarang.TabStop = false;
            // 
            // pictbxRiwayat
            // 
            pictbxRiwayat.Anchor = AnchorStyles.Top;
            pictbxRiwayat.BackColor = Color.Transparent;
            pictbxRiwayat.Image = (Image)resources.GetObject("pictbxRiwayat.Image");
            pictbxRiwayat.Location = new Point(320, 29);
            pictbxRiwayat.Name = "pictbxRiwayat";
            pictbxRiwayat.Size = new Size(102, 43);
            pictbxRiwayat.SizeMode = PictureBoxSizeMode.CenterImage;
            pictbxRiwayat.TabIndex = 9;
            pictbxRiwayat.TabStop = false;
            // 
            // btnRiwayat
            // 
            btnRiwayat.Anchor = AnchorStyles.Top;
            btnRiwayat.BackColor = Color.White;
            btnRiwayat.BackgroundImageLayout = ImageLayout.Zoom;
            btnRiwayat.Font = new Font("Bahnschrift Condensed", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRiwayat.ForeColor = Color.FromArgb(44, 62, 80);
            btnRiwayat.ImageAlign = ContentAlignment.TopCenter;
            btnRiwayat.Location = new Point(300, 15);
            btnRiwayat.Name = "btnRiwayat";
            btnRiwayat.Padding = new Padding(9);
            btnRiwayat.Size = new Size(140, 125);
            btnRiwayat.TabIndex = 8;
            btnRiwayat.Text = "Layanan Barbeshop";
            btnRiwayat.TextAlign = ContentAlignment.BottomCenter;
            btnRiwayat.UseVisualStyleBackColor = false;
            // 
            // pictbxLayanan
            // 
            pictbxLayanan.Anchor = AnchorStyles.Top;
            pictbxLayanan.BackColor = Color.Transparent;
            pictbxLayanan.Image = (Image)resources.GetObject("pictbxLayanan.Image");
            pictbxLayanan.Location = new Point(174, 29);
            pictbxLayanan.Name = "pictbxLayanan";
            pictbxLayanan.Size = new Size(102, 43);
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
            btnReservasi.Location = new Point(8, 15);
            btnReservasi.Name = "btnReservasi";
            btnReservasi.Padding = new Padding(9);
            btnReservasi.Size = new Size(140, 125);
            btnReservasi.TabIndex = 1;
            btnReservasi.Text = "Presensi Sekarang!";
            btnReservasi.TextAlign = ContentAlignment.BottomCenter;
            btnReservasi.UseVisualStyleBackColor = false;
            // 
            // btnLayanan
            // 
            btnLayanan.Anchor = AnchorStyles.Top;
            btnLayanan.BackColor = Color.White;
            btnLayanan.Font = new Font("Bahnschrift Condensed", 15.75F);
            btnLayanan.ForeColor = Color.FromArgb(44, 62, 80);
            btnLayanan.ImageAlign = ContentAlignment.TopCenter;
            btnLayanan.Location = new Point(154, 15);
            btnLayanan.Name = "btnLayanan";
            btnLayanan.Padding = new Padding(9);
            btnLayanan.Size = new Size(140, 125);
            btnLayanan.TabIndex = 0;
            btnLayanan.Text = "Performa\r\n\r\n";
            btnLayanan.TextAlign = ContentAlignment.BottomCenter;
            btnLayanan.UseVisualStyleBackColor = false;
            // 
            // FormHomepageKaryawan
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(gbxShowProfile);
            Controls.Add(gbxMenu);
            Controls.Add(btnProfil);
            Controls.Add(lblHomepageGreet);
            Controls.Add(lblWelcome);
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
        private Button btnRiwayat;
        private PictureBox pictbxLayanan;
        private Button btnReservasi;
        private Button btnLayanan;
        private Button button1;
        private PictureBox pictureBox1;
    }
}