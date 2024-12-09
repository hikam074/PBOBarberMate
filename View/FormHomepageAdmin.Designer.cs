namespace PBOBarberMate.View
{
    partial class FormHomepageAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHomepageAdmin));
            lblWelcome = new Label();
            btnHomepageLogout = new Button();
            gbxMenu = new GroupBox();
            pictbxShift = new PictureBox();
            btnShift = new Button();
            pictbxInventaris = new PictureBox();
            btnInventaris = new Button();
            pictbxKunjungan = new PictureBox();
            pictbxKaryawan = new PictureBox();
            pictbxCustomer = new PictureBox();
            pictbxPembayaran = new PictureBox();
            pictbxReservasi = new PictureBox();
            pictbxLayanan = new PictureBox();
            btnCustomer = new Button();
            btnKaryawan = new Button();
            btnKunjungan = new Button();
            btnPembayaran = new Button();
            btnReservasi = new Button();
            btnLayanan = new Button();
            btnProfil = new Button();
            lblHomepageGreet = new Label();
            gbxShowProfile = new GroupBox();
            lblProfilEmail = new Label();
            lblProfilRole = new Label();
            btnUbahProfil = new Button();
            lblProfilNama = new Label();
            gbxMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictbxShift).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictbxInventaris).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictbxKunjungan).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictbxKaryawan).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictbxCustomer).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictbxPembayaran).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictbxReservasi).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictbxLayanan).BeginInit();
            gbxShowProfile.SuspendLayout();
            SuspendLayout();
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
            lblWelcome.TabIndex = 0;
            lblWelcome.Text = "Pengguna";
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
            // gbxMenu
            // 
            gbxMenu.Anchor = AnchorStyles.Top;
            gbxMenu.BackColor = Color.White;
            gbxMenu.Controls.Add(pictbxShift);
            gbxMenu.Controls.Add(btnShift);
            gbxMenu.Controls.Add(pictbxInventaris);
            gbxMenu.Controls.Add(btnInventaris);
            gbxMenu.Controls.Add(pictbxKunjungan);
            gbxMenu.Controls.Add(pictbxKaryawan);
            gbxMenu.Controls.Add(pictbxCustomer);
            gbxMenu.Controls.Add(pictbxPembayaran);
            gbxMenu.Controls.Add(pictbxReservasi);
            gbxMenu.Controls.Add(pictbxLayanan);
            gbxMenu.Controls.Add(btnCustomer);
            gbxMenu.Controls.Add(btnKaryawan);
            gbxMenu.Controls.Add(btnKunjungan);
            gbxMenu.Controls.Add(btnPembayaran);
            gbxMenu.Controls.Add(btnReservasi);
            gbxMenu.Controls.Add(btnLayanan);
            gbxMenu.Location = new Point(159, 217);
            gbxMenu.Margin = new Padding(4, 5, 4, 5);
            gbxMenu.Name = "gbxMenu";
            gbxMenu.Padding = new Padding(4, 5, 4, 5);
            gbxMenu.Size = new Size(857, 472);
            gbxMenu.TabIndex = 2;
            gbxMenu.TabStop = false;
            // 
            // pictbxShift
            // 
            pictbxShift.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pictbxShift.Enabled = false;
            pictbxShift.Image = (Image)resources.GetObject("pictbxShift.Image");
            pictbxShift.Location = new Point(703, 55);
            pictbxShift.Margin = new Padding(4, 5, 4, 5);
            pictbxShift.Name = "pictbxShift";
            pictbxShift.Size = new Size(71, 72);
            pictbxShift.SizeMode = PictureBoxSizeMode.CenterImage;
            pictbxShift.TabIndex = 13;
            pictbxShift.TabStop = false;
            // 
            // btnShift
            // 
            btnShift.Anchor = AnchorStyles.Top;
            btnShift.BackColor = Color.White;
            btnShift.Font = new Font("Bahnschrift Condensed", 15.75F);
            btnShift.ForeColor = Color.FromArgb(44, 62, 80);
            btnShift.Location = new Point(641, 28);
            btnShift.Margin = new Padding(4, 5, 4, 5);
            btnShift.Name = "btnShift";
            btnShift.Padding = new Padding(13, 15, 13, 15);
            btnShift.Size = new Size(200, 208);
            btnShift.TabIndex = 12;
            btnShift.Text = "Kelola\r\nShift";
            btnShift.TextAlign = ContentAlignment.BottomCenter;
            btnShift.UseVisualStyleBackColor = false;
            // 
            // pictbxInventaris
            // 
            pictbxInventaris.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pictbxInventaris.Enabled = false;
            pictbxInventaris.Image = (Image)resources.GetObject("pictbxInventaris.Image");
            pictbxInventaris.Location = new Point(703, 273);
            pictbxInventaris.Margin = new Padding(4, 5, 4, 5);
            pictbxInventaris.Name = "pictbxInventaris";
            pictbxInventaris.Size = new Size(71, 72);
            pictbxInventaris.SizeMode = PictureBoxSizeMode.CenterImage;
            pictbxInventaris.TabIndex = 11;
            pictbxInventaris.TabStop = false;
            // 
            // btnInventaris
            // 
            btnInventaris.Anchor = AnchorStyles.Top;
            btnInventaris.BackColor = Color.White;
            btnInventaris.Font = new Font("Bahnschrift Condensed", 15.75F);
            btnInventaris.ForeColor = Color.FromArgb(44, 62, 80);
            btnInventaris.Location = new Point(641, 247);
            btnInventaris.Margin = new Padding(4, 5, 4, 5);
            btnInventaris.Name = "btnInventaris";
            btnInventaris.Padding = new Padding(13, 15, 13, 15);
            btnInventaris.Size = new Size(200, 208);
            btnInventaris.TabIndex = 10;
            btnInventaris.Text = "Kelola\r\nStok barang";
            btnInventaris.TextAlign = ContentAlignment.BottomCenter;
            btnInventaris.UseVisualStyleBackColor = false;
            btnInventaris.Click += btnInventaris_Click;
            // 
            // pictbxKunjungan
            // 
            pictbxKunjungan.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pictbxKunjungan.Enabled = false;
            pictbxKunjungan.Image = (Image)resources.GetObject("pictbxKunjungan.Image");
            pictbxKunjungan.Location = new Point(497, 273);
            pictbxKunjungan.Margin = new Padding(4, 5, 4, 5);
            pictbxKunjungan.Name = "pictbxKunjungan";
            pictbxKunjungan.Size = new Size(71, 72);
            pictbxKunjungan.SizeMode = PictureBoxSizeMode.CenterImage;
            pictbxKunjungan.TabIndex = 9;
            pictbxKunjungan.TabStop = false;
            // 
            // pictbxKaryawan
            // 
            pictbxKaryawan.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pictbxKaryawan.Enabled = false;
            pictbxKaryawan.Image = (Image)resources.GetObject("pictbxKaryawan.Image");
            pictbxKaryawan.Location = new Point(79, 273);
            pictbxKaryawan.Margin = new Padding(4, 5, 4, 5);
            pictbxKaryawan.Name = "pictbxKaryawan";
            pictbxKaryawan.Size = new Size(71, 72);
            pictbxKaryawan.SizeMode = PictureBoxSizeMode.CenterImage;
            pictbxKaryawan.TabIndex = 8;
            pictbxKaryawan.TabStop = false;
            // 
            // pictbxCustomer
            // 
            pictbxCustomer.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pictbxCustomer.BackgroundImageLayout = ImageLayout.Center;
            pictbxCustomer.Enabled = false;
            pictbxCustomer.Image = (Image)resources.GetObject("pictbxCustomer.Image");
            pictbxCustomer.Location = new Point(287, 273);
            pictbxCustomer.Margin = new Padding(4, 5, 4, 5);
            pictbxCustomer.Name = "pictbxCustomer";
            pictbxCustomer.Size = new Size(71, 72);
            pictbxCustomer.SizeMode = PictureBoxSizeMode.CenterImage;
            pictbxCustomer.TabIndex = 7;
            pictbxCustomer.TabStop = false;
            // 
            // pictbxPembayaran
            // 
            pictbxPembayaran.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pictbxPembayaran.BackColor = Color.Transparent;
            pictbxPembayaran.BackgroundImageLayout = ImageLayout.Center;
            pictbxPembayaran.Enabled = false;
            pictbxPembayaran.Image = (Image)resources.GetObject("pictbxPembayaran.Image");
            pictbxPembayaran.Location = new Point(497, 55);
            pictbxPembayaran.Margin = new Padding(4, 5, 4, 5);
            pictbxPembayaran.Name = "pictbxPembayaran";
            pictbxPembayaran.Size = new Size(71, 72);
            pictbxPembayaran.SizeMode = PictureBoxSizeMode.CenterImage;
            pictbxPembayaran.TabIndex = 7;
            pictbxPembayaran.TabStop = false;
            // 
            // pictbxReservasi
            // 
            pictbxReservasi.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pictbxReservasi.BackColor = Color.Transparent;
            pictbxReservasi.Enabled = false;
            pictbxReservasi.Image = (Image)resources.GetObject("pictbxReservasi.Image");
            pictbxReservasi.Location = new Point(287, 55);
            pictbxReservasi.Margin = new Padding(4, 5, 4, 5);
            pictbxReservasi.Name = "pictbxReservasi";
            pictbxReservasi.Size = new Size(71, 72);
            pictbxReservasi.SizeMode = PictureBoxSizeMode.CenterImage;
            pictbxReservasi.TabIndex = 7;
            pictbxReservasi.TabStop = false;
            // 
            // pictbxLayanan
            // 
            pictbxLayanan.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pictbxLayanan.BackColor = Color.Transparent;
            pictbxLayanan.Enabled = false;
            pictbxLayanan.Image = (Image)resources.GetObject("pictbxLayanan.Image");
            pictbxLayanan.Location = new Point(79, 55);
            pictbxLayanan.Margin = new Padding(4, 5, 4, 5);
            pictbxLayanan.Name = "pictbxLayanan";
            pictbxLayanan.Size = new Size(71, 72);
            pictbxLayanan.SizeMode = PictureBoxSizeMode.CenterImage;
            pictbxLayanan.TabIndex = 7;
            pictbxLayanan.TabStop = false;
            // 
            // btnCustomer
            // 
            btnCustomer.Anchor = AnchorStyles.Top;
            btnCustomer.BackColor = Color.White;
            btnCustomer.Font = new Font("Bahnschrift Condensed", 15.75F);
            btnCustomer.ForeColor = Color.FromArgb(44, 62, 80);
            btnCustomer.Location = new Point(224, 247);
            btnCustomer.Margin = new Padding(4, 5, 4, 5);
            btnCustomer.Name = "btnCustomer";
            btnCustomer.Padding = new Padding(13, 15, 13, 15);
            btnCustomer.Size = new Size(200, 208);
            btnCustomer.TabIndex = 5;
            btnCustomer.Text = "Kelola\r\nCustomer";
            btnCustomer.TextAlign = ContentAlignment.BottomCenter;
            btnCustomer.UseVisualStyleBackColor = false;
            btnCustomer.Click += btnCustomer_Click;
            // 
            // btnKaryawan
            // 
            btnKaryawan.Anchor = AnchorStyles.Top;
            btnKaryawan.BackColor = Color.White;
            btnKaryawan.Font = new Font("Bahnschrift Condensed", 15.75F);
            btnKaryawan.ForeColor = Color.FromArgb(44, 62, 80);
            btnKaryawan.Location = new Point(16, 247);
            btnKaryawan.Margin = new Padding(4, 5, 4, 5);
            btnKaryawan.Name = "btnKaryawan";
            btnKaryawan.Padding = new Padding(13, 15, 13, 15);
            btnKaryawan.Size = new Size(200, 208);
            btnKaryawan.TabIndex = 4;
            btnKaryawan.Text = "Kelola\r\nKaryawan";
            btnKaryawan.TextAlign = ContentAlignment.BottomCenter;
            btnKaryawan.UseVisualStyleBackColor = false;
            // 
            // btnKunjungan
            // 
            btnKunjungan.Anchor = AnchorStyles.Top;
            btnKunjungan.BackColor = Color.White;
            btnKunjungan.Font = new Font("Bahnschrift Condensed", 15.75F);
            btnKunjungan.ForeColor = Color.FromArgb(44, 62, 80);
            btnKunjungan.Location = new Point(433, 247);
            btnKunjungan.Margin = new Padding(4, 5, 4, 5);
            btnKunjungan.Name = "btnKunjungan";
            btnKunjungan.Padding = new Padding(13, 15, 13, 15);
            btnKunjungan.Size = new Size(200, 208);
            btnKunjungan.TabIndex = 3;
            btnKunjungan.Text = "Riwayat\r\nKunjungan";
            btnKunjungan.TextAlign = ContentAlignment.BottomCenter;
            btnKunjungan.UseVisualStyleBackColor = false;
            // 
            // btnPembayaran
            // 
            btnPembayaran.Anchor = AnchorStyles.Top;
            btnPembayaran.BackColor = Color.White;
            btnPembayaran.Font = new Font("Bahnschrift Condensed", 15.75F);
            btnPembayaran.ForeColor = Color.FromArgb(44, 62, 80);
            btnPembayaran.Location = new Point(433, 28);
            btnPembayaran.Margin = new Padding(4, 5, 4, 5);
            btnPembayaran.Name = "btnPembayaran";
            btnPembayaran.Padding = new Padding(0, 15, 0, 15);
            btnPembayaran.Size = new Size(200, 208);
            btnPembayaran.TabIndex = 2;
            btnPembayaran.Text = "Pembayaran\r\n      \r\n";
            btnPembayaran.TextAlign = ContentAlignment.BottomCenter;
            btnPembayaran.UseVisualStyleBackColor = false;
            // 
            // btnReservasi
            // 
            btnReservasi.Anchor = AnchorStyles.Top;
            btnReservasi.BackColor = Color.White;
            btnReservasi.BackgroundImageLayout = ImageLayout.Zoom;
            btnReservasi.Font = new Font("Bahnschrift Condensed", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnReservasi.ForeColor = Color.FromArgb(44, 62, 80);
            btnReservasi.ImageAlign = ContentAlignment.TopCenter;
            btnReservasi.Location = new Point(224, 28);
            btnReservasi.Margin = new Padding(4, 5, 4, 5);
            btnReservasi.Name = "btnReservasi";
            btnReservasi.Padding = new Padding(13, 15, 13, 15);
            btnReservasi.Size = new Size(200, 208);
            btnReservasi.TabIndex = 1;
            btnReservasi.Text = "Kelola\r\nReservasi";
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
            btnLayanan.Location = new Point(16, 28);
            btnLayanan.Margin = new Padding(4, 5, 4, 5);
            btnLayanan.Name = "btnLayanan";
            btnLayanan.Padding = new Padding(13, 15, 13, 15);
            btnLayanan.Size = new Size(200, 208);
            btnLayanan.TabIndex = 0;
            btnLayanan.Text = "Kelola\r\nLayanan";
            btnLayanan.TextAlign = ContentAlignment.BottomCenter;
            btnLayanan.UseVisualStyleBackColor = false;
            btnLayanan.Click += btnLayanan_Click;
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
            btnProfil.TabIndex = 3;
            btnProfil.Text = "Profil";
            btnProfil.UseVisualStyleBackColor = false;
            btnProfil.Click += btnProfil_Click;
            btnProfil.MouseEnter += btnProfil_MouseEnter;
            btnProfil.MouseLeave += btnProfil_MouseLeave;
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
            lblHomepageGreet.TabIndex = 5;
            lblHomepageGreet.Text = "Hai,";
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
            // FormHomepageAdmin
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1143, 748);
            Controls.Add(gbxShowProfile);
            Controls.Add(lblHomepageGreet);
            Controls.Add(btnProfil);
            Controls.Add(gbxMenu);
            Controls.Add(lblWelcome);
            Margin = new Padding(4, 5, 4, 5);
            Name = "FormHomepageAdmin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "BarberMate : Dashboard";
            Click += FormHomepageAdmin_Click;
            gbxMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictbxShift).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictbxInventaris).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictbxKunjungan).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictbxKaryawan).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictbxCustomer).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictbxPembayaran).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictbxReservasi).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictbxLayanan).EndInit();
            gbxShowProfile.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public Label lblWelcome;
        private Button btnHomepageLogout;
        private GroupBox gbxMenu;
        private Button btnReservasi;
        private Button btnLayanan;
        private Button btnProfil;
        private Button btnCustomer;
        private Button btnKaryawan;
        private Button btnKunjungan;
        private Button btnPembayaran;
        private Label lblHomepageGreet;
        private GroupBox gbxShowProfile;
        private Button btnUbahProfil;
        private Label lblProfilNama;
        private Label lblProfilEmail;
        private Label lblProfilRole;
        private PictureBox pictbxLayanan;
        private PictureBox pictbxReservasi;
        private PictureBox pictbxPembayaran;
        private PictureBox pictbxCustomer;
        private PictureBox pictbxKaryawan;
        private PictureBox pictbxKunjungan;
        private Button btnInventaris;
        private PictureBox pictbxInventaris;
        private Button btnShift;
        private PictureBox pictbxShift;
    }
}