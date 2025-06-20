namespace PBOBarberMate.View.Homepages
{
    partial class HomepageAdminUC
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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomepageAdminUC));
            headerPanel = new Panel();
            gbxShowProfile = new GroupBox();
            lblProfilEmail = new Label();
            lblProfilRole = new Label();
            btnUbahProfil = new Button();
            lblProfilNama = new Label();
            btnHomepageLogout = new Button();
            lblWelcome = new Label();
            lblHomepageGreet = new Label();
            btnProfil = new Button();
            sidebarPanel = new Panel();
            btnCustomer = new Button();
            pictbxCustomer = new PictureBox();
            btnKaryawan = new Button();
            pictbxKaryawan = new PictureBox();
            pictbxReservasi = new PictureBox();
            btnKunjungan = new Button();
            pictbxKunjungan = new PictureBox();
            btnPembayaran = new Button();
            pictbxPembayaran = new PictureBox();
            btnReservasi = new Button();
            btnLayanan = new Button();
            pictbxLayanan = new PictureBox();
            btnInventaris = new Button();
            pictbxInventaris = new PictureBox();
            btnShift = new Button();
            pictbxShift = new PictureBox();
            contentAreaPanel = new Panel();
            pictbxHome = new PictureBox();
            headerPanel.SuspendLayout();
            gbxShowProfile.SuspendLayout();
            sidebarPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictbxCustomer).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictbxKaryawan).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictbxReservasi).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictbxKunjungan).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictbxPembayaran).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictbxLayanan).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictbxInventaris).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictbxShift).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictbxHome).BeginInit();
            SuspendLayout();
            // 
            // headerPanel
            // 
            headerPanel.BackColor = Color.Turquoise;
            headerPanel.Controls.Add(pictbxHome);
            headerPanel.Controls.Add(gbxShowProfile);
            headerPanel.Controls.Add(lblWelcome);
            headerPanel.Controls.Add(lblHomepageGreet);
            headerPanel.Controls.Add(btnProfil);
            headerPanel.Dock = DockStyle.Top;
            headerPanel.Location = new Point(0, 0);
            headerPanel.Name = "headerPanel";
            headerPanel.Size = new Size(944, 50);
            headerPanel.TabIndex = 7;
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
            gbxShowProfile.Location = new Point(697, 7);
            gbxShowProfile.Margin = new Padding(0);
            gbxShowProfile.Name = "gbxShowProfile";
            gbxShowProfile.Size = new Size(170, 144);
            gbxShowProfile.TabIndex = 6;
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
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.BackColor = Color.Transparent;
            lblWelcome.Font = new Font("Bahnschrift Condensed", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblWelcome.ForeColor = Color.Black;
            lblWelcome.Location = new Point(178, 13);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(72, 23);
            lblWelcome.TabIndex = 0;
            lblWelcome.Text = "Pengguna";
            lblWelcome.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblHomepageGreet
            // 
            lblHomepageGreet.AutoSize = true;
            lblHomepageGreet.BackColor = Color.Transparent;
            lblHomepageGreet.Font = new Font("Bahnschrift Condensed", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblHomepageGreet.ForeColor = Color.Black;
            lblHomepageGreet.Location = new Point(70, 13);
            lblHomepageGreet.Name = "lblHomepageGreet";
            lblHomepageGreet.Size = new Size(118, 23);
            lblHomepageGreet.TabIndex = 5;
            lblHomepageGreet.Text = "Selamat Datang, ";
            lblHomepageGreet.TextAlign = ContentAlignment.MiddleRight;
            // 
            // btnProfil
            // 
            btnProfil.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnProfil.BackColor = Color.FromArgb(44, 62, 80);
            btnProfil.Font = new Font("Bahnschrift Condensed", 12F);
            btnProfil.ForeColor = Color.White;
            btnProfil.Location = new Point(870, 7);
            btnProfil.Name = "btnProfil";
            btnProfil.Size = new Size(55, 36);
            btnProfil.TabIndex = 3;
            btnProfil.Text = "Profil";
            btnProfil.UseVisualStyleBackColor = false;
            btnProfil.Click += btnProfil_Click;
            // 
            // sidebarPanel
            // 
            sidebarPanel.BackColor = Color.PaleTurquoise;
            sidebarPanel.Controls.Add(btnCustomer);
            sidebarPanel.Controls.Add(pictbxCustomer);
            sidebarPanel.Controls.Add(btnKaryawan);
            sidebarPanel.Controls.Add(pictbxKaryawan);
            sidebarPanel.Controls.Add(pictbxReservasi);
            sidebarPanel.Controls.Add(btnKunjungan);
            sidebarPanel.Controls.Add(pictbxKunjungan);
            sidebarPanel.Controls.Add(btnPembayaran);
            sidebarPanel.Controls.Add(pictbxPembayaran);
            sidebarPanel.Controls.Add(btnReservasi);
            sidebarPanel.Controls.Add(btnLayanan);
            sidebarPanel.Controls.Add(pictbxLayanan);
            sidebarPanel.Controls.Add(btnInventaris);
            sidebarPanel.Controls.Add(pictbxInventaris);
            sidebarPanel.Controls.Add(btnShift);
            sidebarPanel.Controls.Add(pictbxShift);
            sidebarPanel.Dock = DockStyle.Left;
            sidebarPanel.Location = new Point(0, 50);
            sidebarPanel.Name = "sidebarPanel";
            sidebarPanel.Size = new Size(200, 451);
            sidebarPanel.TabIndex = 0;
            // 
            // btnCustomer
            // 
            btnCustomer.BackColor = Color.Transparent;
            btnCustomer.FlatAppearance.BorderSize = 0;
            btnCustomer.FlatStyle = FlatStyle.Flat;
            btnCustomer.Font = new Font("Bahnschrift Condensed", 15.75F);
            btnCustomer.ForeColor = Color.Black;
            btnCustomer.ImageAlign = ContentAlignment.MiddleLeft;
            btnCustomer.Location = new Point(44, 348);
            btnCustomer.Name = "btnCustomer";
            btnCustomer.Size = new Size(150, 40);
            btnCustomer.TabIndex = 5;
            btnCustomer.Text = "Kelola Customer";
            btnCustomer.TextAlign = ContentAlignment.MiddleLeft;
            btnCustomer.UseVisualStyleBackColor = false;
            btnCustomer.Click += btnCustomer_Click;
            // 
            // pictbxCustomer
            // 
            pictbxCustomer.Image = (Image)resources.GetObject("pictbxCustomer.Image");
            pictbxCustomer.Location = new Point(17, 357);
            pictbxCustomer.Name = "pictbxCustomer";
            pictbxCustomer.Size = new Size(25, 25);
            pictbxCustomer.SizeMode = PictureBoxSizeMode.StretchImage;
            pictbxCustomer.TabIndex = 7;
            pictbxCustomer.TabStop = false;
            // 
            // btnKaryawan
            // 
            btnKaryawan.BackColor = Color.Transparent;
            btnKaryawan.FlatAppearance.BorderSize = 0;
            btnKaryawan.FlatStyle = FlatStyle.Flat;
            btnKaryawan.Font = new Font("Bahnschrift Condensed", 15.75F);
            btnKaryawan.ForeColor = Color.Black;
            btnKaryawan.Location = new Point(44, 164);
            btnKaryawan.Name = "btnKaryawan";
            btnKaryawan.Size = new Size(150, 40);
            btnKaryawan.TabIndex = 4;
            btnKaryawan.Text = "Kelola Karyawan";
            btnKaryawan.TextAlign = ContentAlignment.MiddleLeft;
            btnKaryawan.UseVisualStyleBackColor = false;
            btnKaryawan.Click += btnKaryawan_Click;
            // 
            // pictbxKaryawan
            // 
            pictbxKaryawan.Image = (Image)resources.GetObject("pictbxKaryawan.Image");
            pictbxKaryawan.Location = new Point(17, 172);
            pictbxKaryawan.Name = "pictbxKaryawan";
            pictbxKaryawan.Size = new Size(25, 25);
            pictbxKaryawan.SizeMode = PictureBoxSizeMode.StretchImage;
            pictbxKaryawan.TabIndex = 8;
            pictbxKaryawan.TabStop = false;
            // 
            // pictbxReservasi
            // 
            pictbxReservasi.BackColor = Color.Transparent;
            pictbxReservasi.Image = (Image)resources.GetObject("pictbxReservasi.Image");
            pictbxReservasi.Location = new Point(17, 14);
            pictbxReservasi.Name = "pictbxReservasi";
            pictbxReservasi.Size = new Size(25, 25);
            pictbxReservasi.SizeMode = PictureBoxSizeMode.StretchImage;
            pictbxReservasi.TabIndex = 7;
            pictbxReservasi.TabStop = false;
            // 
            // btnKunjungan
            // 
            btnKunjungan.BackColor = Color.Transparent;
            btnKunjungan.FlatAppearance.BorderSize = 0;
            btnKunjungan.FlatStyle = FlatStyle.Flat;
            btnKunjungan.Font = new Font("Bahnschrift Condensed", 15.75F);
            btnKunjungan.ForeColor = Color.Black;
            btnKunjungan.ImageAlign = ContentAlignment.MiddleLeft;
            btnKunjungan.Location = new Point(44, 98);
            btnKunjungan.Name = "btnKunjungan";
            btnKunjungan.Size = new Size(150, 60);
            btnKunjungan.TabIndex = 3;
            btnKunjungan.Text = "Riwayat\r\nKunjungan";
            btnKunjungan.TextAlign = ContentAlignment.MiddleLeft;
            btnKunjungan.UseVisualStyleBackColor = false;
            btnKunjungan.Click += btnKunjungan_Click;
            // 
            // pictbxKunjungan
            // 
            pictbxKunjungan.Image = (Image)resources.GetObject("pictbxKunjungan.Image");
            pictbxKunjungan.Location = new Point(17, 116);
            pictbxKunjungan.Name = "pictbxKunjungan";
            pictbxKunjungan.Size = new Size(25, 25);
            pictbxKunjungan.SizeMode = PictureBoxSizeMode.StretchImage;
            pictbxKunjungan.TabIndex = 9;
            pictbxKunjungan.TabStop = false;
            // 
            // btnPembayaran
            // 
            btnPembayaran.BackColor = Color.Transparent;
            btnPembayaran.FlatAppearance.BorderSize = 0;
            btnPembayaran.FlatStyle = FlatStyle.Flat;
            btnPembayaran.Font = new Font("Bahnschrift Condensed", 15.75F);
            btnPembayaran.ForeColor = Color.Black;
            btnPembayaran.Location = new Point(44, 52);
            btnPembayaran.Name = "btnPembayaran";
            btnPembayaran.Size = new Size(150, 40);
            btnPembayaran.TabIndex = 2;
            btnPembayaran.Text = "Pembayaran";
            btnPembayaran.TextAlign = ContentAlignment.MiddleLeft;
            btnPembayaran.UseVisualStyleBackColor = false;
            btnPembayaran.Click += btnPembayaran_Click;
            // 
            // pictbxPembayaran
            // 
            pictbxPembayaran.Image = (Image)resources.GetObject("pictbxPembayaran.Image");
            pictbxPembayaran.Location = new Point(17, 60);
            pictbxPembayaran.Name = "pictbxPembayaran";
            pictbxPembayaran.Size = new Size(25, 25);
            pictbxPembayaran.SizeMode = PictureBoxSizeMode.StretchImage;
            pictbxPembayaran.TabIndex = 7;
            pictbxPembayaran.TabStop = false;
            // 
            // btnReservasi
            // 
            btnReservasi.BackColor = Color.Transparent;
            btnReservasi.FlatAppearance.BorderSize = 0;
            btnReservasi.FlatStyle = FlatStyle.Flat;
            btnReservasi.Font = new Font("Bahnschrift Condensed", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnReservasi.ForeColor = Color.Black;
            btnReservasi.Location = new Point(44, 6);
            btnReservasi.Name = "btnReservasi";
            btnReservasi.Size = new Size(150, 40);
            btnReservasi.TabIndex = 1;
            btnReservasi.Text = "Kelola Reservasi";
            btnReservasi.TextAlign = ContentAlignment.MiddleLeft;
            btnReservasi.UseVisualStyleBackColor = false;
            btnReservasi.Click += btnReservasi_Click;
            // 
            // btnLayanan
            // 
            btnLayanan.BackColor = Color.Transparent;
            btnLayanan.FlatAppearance.BorderSize = 0;
            btnLayanan.FlatStyle = FlatStyle.Flat;
            btnLayanan.Font = new Font("Bahnschrift Condensed", 15.75F);
            btnLayanan.ForeColor = Color.Black;
            btnLayanan.Location = new Point(44, 256);
            btnLayanan.Name = "btnLayanan";
            btnLayanan.Size = new Size(150, 40);
            btnLayanan.TabIndex = 0;
            btnLayanan.Text = "Kelola Layanan";
            btnLayanan.TextAlign = ContentAlignment.MiddleLeft;
            btnLayanan.UseVisualStyleBackColor = false;
            btnLayanan.Click += btnLayanan_Click;
            // 
            // pictbxLayanan
            // 
            pictbxLayanan.Image = (Image)resources.GetObject("pictbxLayanan.Image");
            pictbxLayanan.Location = new Point(17, 264);
            pictbxLayanan.Name = "pictbxLayanan";
            pictbxLayanan.Size = new Size(25, 25);
            pictbxLayanan.SizeMode = PictureBoxSizeMode.StretchImage;
            pictbxLayanan.TabIndex = 7;
            pictbxLayanan.TabStop = false;
            // 
            // btnInventaris
            // 
            btnInventaris.BackColor = Color.Transparent;
            btnInventaris.FlatAppearance.BorderSize = 0;
            btnInventaris.FlatStyle = FlatStyle.Flat;
            btnInventaris.Font = new Font("Bahnschrift Condensed", 15.75F);
            btnInventaris.ForeColor = Color.Black;
            btnInventaris.Location = new Point(44, 302);
            btnInventaris.Name = "btnInventaris";
            btnInventaris.Size = new Size(150, 40);
            btnInventaris.TabIndex = 10;
            btnInventaris.Text = "Kelola Inventaris";
            btnInventaris.TextAlign = ContentAlignment.MiddleLeft;
            btnInventaris.UseVisualStyleBackColor = false;
            btnInventaris.Click += btnInventaris_Click;
            // 
            // pictbxInventaris
            // 
            pictbxInventaris.Image = (Image)resources.GetObject("pictbxInventaris.Image");
            pictbxInventaris.Location = new Point(17, 311);
            pictbxInventaris.Name = "pictbxInventaris";
            pictbxInventaris.Size = new Size(25, 25);
            pictbxInventaris.SizeMode = PictureBoxSizeMode.StretchImage;
            pictbxInventaris.TabIndex = 11;
            pictbxInventaris.TabStop = false;
            // 
            // btnShift
            // 
            btnShift.BackColor = Color.Transparent;
            btnShift.FlatAppearance.BorderSize = 0;
            btnShift.FlatStyle = FlatStyle.Flat;
            btnShift.Font = new Font("Bahnschrift Condensed", 15.75F);
            btnShift.ForeColor = Color.Black;
            btnShift.Location = new Point(44, 210);
            btnShift.Name = "btnShift";
            btnShift.Size = new Size(150, 40);
            btnShift.TabIndex = 12;
            btnShift.Text = "Kelola Shift";
            btnShift.TextAlign = ContentAlignment.MiddleLeft;
            btnShift.UseVisualStyleBackColor = false;
            btnShift.Click += btnShift_Click;
            // 
            // pictbxShift
            // 
            pictbxShift.Image = (Image)resources.GetObject("pictbxShift.Image");
            pictbxShift.Location = new Point(17, 218);
            pictbxShift.Name = "pictbxShift";
            pictbxShift.Size = new Size(25, 25);
            pictbxShift.SizeMode = PictureBoxSizeMode.StretchImage;
            pictbxShift.TabIndex = 13;
            pictbxShift.TabStop = false;
            // 
            // contentAreaPanel
            // 
            contentAreaPanel.BackColor = Color.WhiteSmoke;
            contentAreaPanel.Dock = DockStyle.Fill;
            contentAreaPanel.Location = new Point(200, 50);
            contentAreaPanel.Name = "contentAreaPanel";
            contentAreaPanel.Size = new Size(744, 451);
            contentAreaPanel.TabIndex = 1;
            // 
            // pictbxHome
            // 
            pictbxHome.Image = (Image)resources.GetObject("pictbxHome.Image");
            pictbxHome.Location = new Point(34, 12);
            pictbxHome.Name = "pictbxHome";
            pictbxHome.Size = new Size(25, 25);
            pictbxHome.SizeMode = PictureBoxSizeMode.StretchImage;
            pictbxHome.TabIndex = 8;
            pictbxHome.TabStop = false;
            pictbxHome.Click += pictbxHome_Click;
            // 
            // HomepageAdminUC
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(contentAreaPanel);
            Controls.Add(sidebarPanel);
            Controls.Add(headerPanel);
            Name = "HomepageAdminUC";
            Size = new Size(944, 501);
            Click += HomepageAdminUC_Click;
            headerPanel.ResumeLayout(false);
            headerPanel.PerformLayout();
            gbxShowProfile.ResumeLayout(false);
            sidebarPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictbxCustomer).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictbxKaryawan).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictbxReservasi).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictbxKunjungan).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictbxPembayaran).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictbxLayanan).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictbxInventaris).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictbxShift).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictbxHome).EndInit();
            ResumeLayout(false);
        }

        #endregion
        // Deklarasi komponen baru
        private System.Windows.Forms.Panel headerPanel;
        private System.Windows.Forms.Panel sidebarPanel;
        private System.Windows.Forms.Panel contentAreaPanel;

        // Komponen yang dipindahkan ke headerPanel
        public System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Label lblHomepageGreet;
        private System.Windows.Forms.Button btnProfil;
        private System.Windows.Forms.GroupBox gbxShowProfile;

        // Komponen di dalam gbxShowProfile
        private System.Windows.Forms.Label lblProfilEmail;
        private System.Windows.Forms.Label lblProfilRole;
        private System.Windows.Forms.Button btnUbahProfil;
        private System.Windows.Forms.Label lblProfilNama;
        private System.Windows.Forms.Button btnHomepageLogout; // Dipindahkan ke gbxShowProfile

        // Komponen di sidebarPanel (sudah dideklarasikan sebelumnya, hanya diurutkan ulang)
        private System.Windows.Forms.Button btnCustomer;
        private System.Windows.Forms.PictureBox pictbxCustomer;
        private System.Windows.Forms.Button btnKaryawan;
        private System.Windows.Forms.PictureBox pictbxKaryawan;
        private System.Windows.Forms.Button btnKunjungan;
        private System.Windows.Forms.PictureBox pictbxKunjungan;
        private System.Windows.Forms.Button btnPembayaran;
        private System.Windows.Forms.PictureBox pictbxPembayaran;
        private System.Windows.Forms.Button btnReservasi;
        private System.Windows.Forms.PictureBox pictbxReservasi;
        private System.Windows.Forms.Button btnLayanan;
        private System.Windows.Forms.PictureBox pictbxLayanan;
        private System.Windows.Forms.Button btnInventaris;
        private System.Windows.Forms.PictureBox pictbxInventaris;
        private System.Windows.Forms.Button btnShift;
        private System.Windows.Forms.PictureBox pictbxShift;
        private PictureBox pictbxHome;
    }
}
