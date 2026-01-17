//namespace PBOBarberMate.View.Homepages
//{
//    partial class HomepageCustomerUC
//    {
//        /// <summary>
//        /// Required designer variable.
//        /// </summary>
//        private System.ComponentModel.IContainer components = null;

//        /// <summary>
//        /// Clean up any resources being used.
//        /// </summary>
//        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
//        protected override void Dispose(bool disposing)
//        {
//            if (disposing && (components != null))
//            {
//                components.Dispose();
//            }
//            base.Dispose(disposing);
//        }

//        #region Windows Form Designer generated code

//        /// <summary>
//        /// Required method for Designer support - do not modify
//        /// the contents of this method with the code editor.
//        /// </summary>
//        private void InitializeComponent()
//        {
//            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomepageCustomerUC));
//            headerPanel = new Panel();
//            btnProfil = new Button();
//            pictboxProfil = new PictureBox();
//            pictboxHome = new PictureBox();
//            lblHeaderMenu = new Label();
//            lblHomepageGreet = new Label();
//            gbxShowProfile = new GroupBox();
//            lblProfilEmail = new Label();
//            lblProfilRole = new Label();
//            btnUbahProfil = new Button();
//            lblProfilNama = new Label();
//            btnHomepageLogout = new Button();
//            sidebarPanel = new Panel();
//            pictbxUlasan = new PictureBox();
//            btnUlasan = new Button();
//            pictbxLihatReservasi = new PictureBox();
//            btnLihatReservasi = new Button();
//            pictbxLayanan = new PictureBox();
//            btnLayanan = new Button();
//            pictbxReservasi = new PictureBox();
//            btnReservasi = new Button();
//            contentAreaPanel = new Panel();
//            headerPanel.SuspendLayout();
//            ((System.ComponentModel.ISupportInitialize)pictboxProfil).BeginInit();
//            ((System.ComponentModel.ISupportInitialize)pictboxHome).BeginInit();
//            gbxShowProfile.SuspendLayout();
//            sidebarPanel.SuspendLayout();
//            ((System.ComponentModel.ISupportInitialize)pictbxUlasan).BeginInit();
//            ((System.ComponentModel.ISupportInitialize)pictbxLihatReservasi).BeginInit();
//            ((System.ComponentModel.ISupportInitialize)pictbxLayanan).BeginInit();
//            ((System.ComponentModel.ISupportInitialize)pictbxReservasi).BeginInit();
//            SuspendLayout();
//            // 
//            // headerPanel
//            // 
//            headerPanel.BackColor = Color.FromArgb(44, 62, 80);
//            headerPanel.Controls.Add(btnProfil);
//            headerPanel.Controls.Add(pictboxProfil);
//            headerPanel.Controls.Add(pictboxHome);
//            headerPanel.Controls.Add(lblHeaderMenu);
//            headerPanel.Controls.Add(lblHomepageGreet);
//            headerPanel.Dock = DockStyle.Top;
//            headerPanel.Location = new Point(0, 0);
//            headerPanel.Name = "headerPanel";
//            headerPanel.Size = new Size(944, 50);
//            headerPanel.TabIndex = 7;
//            // 
//            // btnProfil
//            // 
//            btnProfil.Anchor = AnchorStyles.Top | AnchorStyles.Right;
//            btnProfil.AutoSize = true;
//            btnProfil.AutoSizeMode = AutoSizeMode.GrowAndShrink;
//            btnProfil.BackColor = Color.White;
//            btnProfil.Cursor = Cursors.Hand;
//            btnProfil.FlatAppearance.BorderSize = 0;
//            btnProfil.FlatStyle = FlatStyle.Flat;
//            btnProfil.Font = new Font("Bahnschrift Condensed", 12F);
//            btnProfil.ForeColor = Color.Black;
//            btnProfil.Location = new Point(884, 11);
//            btnProfil.Name = "btnProfil";
//            btnProfil.Size = new Size(48, 29);
//            btnProfil.TabIndex = 3;
//            btnProfil.Text = "Profil";
//            btnProfil.TextImageRelation = TextImageRelation.ImageBeforeText;
//            btnProfil.UseVisualStyleBackColor = false;
//            btnProfil.Click += btnProfil_Click;
//            // 
//            // pictboxProfil
//            // 
//            pictboxProfil.BackColor = Color.White;
//            pictboxProfil.Image = (Image)resources.GetObject("pictboxProfil.Image");
//            pictboxProfil.Location = new Point(852, 11);
//            pictboxProfil.Name = "pictboxProfil";
//            pictboxProfil.Size = new Size(29, 29);
//            pictboxProfil.SizeMode = PictureBoxSizeMode.Zoom;
//            pictboxProfil.TabIndex = 8;
//            pictboxProfil.TabStop = false;
//            // 
//            // pictboxHome
//            // 
//            pictboxHome.Cursor = Cursors.Hand;
//            pictboxHome.Image = (Image)resources.GetObject("pictboxHome.Image");
//            pictboxHome.Location = new Point(3, 3);
//            pictboxHome.Name = "pictboxHome";
//            pictboxHome.Size = new Size(45, 45);
//            pictboxHome.SizeMode = PictureBoxSizeMode.CenterImage;
//            pictboxHome.TabIndex = 7;
//            pictboxHome.TabStop = false;
//            pictboxHome.Click += pictboxHome_Click;
//            // 
//            // lblHeaderMenu
//            // 
//            lblHeaderMenu.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
//            lblHeaderMenu.AutoSize = true;
//            lblHeaderMenu.BackColor = Color.Transparent;
//            lblHeaderMenu.Font = new Font("Bahnschrift Condensed", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
//            lblHeaderMenu.ForeColor = Color.White;
//            lblHeaderMenu.Location = new Point(442, 13);
//            lblHeaderMenu.Name = "lblHeaderMenu";
//            lblHeaderMenu.Size = new Size(13, 23);
//            lblHeaderMenu.TabIndex = 0;
//            lblHeaderMenu.Text = ".";
//            lblHeaderMenu.TextAlign = ContentAlignment.MiddleLeft;
//            // 
//            // lblHomepageGreet
//            // 
//            lblHomepageGreet.AutoSize = true;
//            lblHomepageGreet.BackColor = Color.Transparent;
//            lblHomepageGreet.Font = new Font("Bahnschrift Condensed", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
//            lblHomepageGreet.ForeColor = Color.White;
//            lblHomepageGreet.Location = new Point(53, 13);
//            lblHomepageGreet.Name = "lblHomepageGreet";
//            lblHomepageGreet.Size = new Size(84, 23);
//            lblHomepageGreet.TabIndex = 5;
//            lblHomepageGreet.Text = "BarberMate";
//            lblHomepageGreet.TextAlign = ContentAlignment.MiddleRight;
//            // 
//            // gbxShowProfile
//            // 
//            gbxShowProfile.Anchor = AnchorStyles.Top | AnchorStyles.Right;
//            gbxShowProfile.BackColor = Color.FromArgb(44, 62, 80);
//            gbxShowProfile.Controls.Add(lblProfilEmail);
//            gbxShowProfile.Controls.Add(lblProfilRole);
//            gbxShowProfile.Controls.Add(btnUbahProfil);
//            gbxShowProfile.Controls.Add(lblProfilNama);
//            gbxShowProfile.Controls.Add(btnHomepageLogout);
//            gbxShowProfile.ForeColor = Color.FromArgb(44, 62, 80);
//            gbxShowProfile.Location = new Point(759, 50);
//            gbxShowProfile.Margin = new Padding(0);
//            gbxShowProfile.Name = "gbxShowProfile";
//            gbxShowProfile.Size = new Size(170, 144);
//            gbxShowProfile.TabIndex = 11;
//            gbxShowProfile.TabStop = false;
//            gbxShowProfile.Visible = false;
//            // 
//            // lblProfilEmail
//            // 
//            lblProfilEmail.Anchor = AnchorStyles.Top | AnchorStyles.Right;
//            lblProfilEmail.BackColor = Color.Transparent;
//            lblProfilEmail.Font = new Font("Bahnschrift Light Condensed", 9F);
//            lblProfilEmail.ForeColor = Color.White;
//            lblProfilEmail.Location = new Point(6, 80);
//            lblProfilEmail.Name = "lblProfilEmail";
//            lblProfilEmail.Size = new Size(158, 23);
//            lblProfilEmail.TabIndex = 3;
//            lblProfilEmail.Text = "isi_email";
//            lblProfilEmail.TextAlign = ContentAlignment.TopRight;
//            // 
//            // lblProfilRole
//            // 
//            lblProfilRole.Anchor = AnchorStyles.Top | AnchorStyles.Right;
//            lblProfilRole.Font = new Font("Bahnschrift SemiLight Condensed", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
//            lblProfilRole.ForeColor = Color.White;
//            lblProfilRole.Location = new Point(6, 15);
//            lblProfilRole.Name = "lblProfilRole";
//            lblProfilRole.Size = new Size(158, 21);
//            lblProfilRole.TabIndex = 2;
//            lblProfilRole.Text = "nama_role";
//            lblProfilRole.TextAlign = ContentAlignment.TopRight;
//            // 
//            // btnUbahProfil
//            // 
//            btnUbahProfil.Anchor = AnchorStyles.Top | AnchorStyles.Right;
//            btnUbahProfil.BackColor = SystemColors.Control;
//            btnUbahProfil.Font = new Font("Bahnschrift Light Condensed", 9F);
//            btnUbahProfil.ForeColor = Color.FromArgb(44, 62, 80);
//            btnUbahProfil.Location = new Point(75, 108);
//            btnUbahProfil.Name = "btnUbahProfil";
//            btnUbahProfil.Size = new Size(39, 30);
//            btnUbahProfil.TabIndex = 1;
//            btnUbahProfil.Text = "Ubah";
//            btnUbahProfil.UseVisualStyleBackColor = false;
//            btnUbahProfil.Click += btnUbahProfil_Click;
//            // 
//            // lblProfilNama
//            // 
//            lblProfilNama.Anchor = AnchorStyles.Top | AnchorStyles.Right;
//            lblProfilNama.Font = new Font("Bahnschrift Condensed", 11.25F);
//            lblProfilNama.ForeColor = Color.White;
//            lblProfilNama.Location = new Point(6, 35);
//            lblProfilNama.Name = "lblProfilNama";
//            lblProfilNama.Size = new Size(158, 42);
//            lblProfilNama.TabIndex = 0;
//            lblProfilNama.Text = "Nama_Pengguna";
//            lblProfilNama.TextAlign = ContentAlignment.TopRight;
//            // 
//            // btnHomepageLogout
//            // 
//            btnHomepageLogout.Anchor = AnchorStyles.Top | AnchorStyles.Right;
//            btnHomepageLogout.BackColor = SystemColors.Control;
//            btnHomepageLogout.Font = new Font("Bahnschrift Light Condensed", 9F);
//            btnHomepageLogout.ForeColor = Color.FromArgb(44, 62, 80);
//            btnHomepageLogout.Location = new Point(120, 108);
//            btnHomepageLogout.Name = "btnHomepageLogout";
//            btnHomepageLogout.Size = new Size(43, 30);
//            btnHomepageLogout.TabIndex = 1;
//            btnHomepageLogout.Text = "Logout";
//            btnHomepageLogout.UseVisualStyleBackColor = false;
//            btnHomepageLogout.Click += btnHomepageLogout_Click;
//            // 
//            // sidebarPanel
//            // 
//            sidebarPanel.BackColor = Color.FromArgb(145, 197, 249);
//            sidebarPanel.Controls.Add(pictbxUlasan);
//            sidebarPanel.Controls.Add(btnUlasan);
//            sidebarPanel.Controls.Add(pictbxLihatReservasi);
//            sidebarPanel.Controls.Add(btnLihatReservasi);
//            sidebarPanel.Controls.Add(pictbxLayanan);
//            sidebarPanel.Controls.Add(btnLayanan);
//            sidebarPanel.Controls.Add(pictbxReservasi);
//            sidebarPanel.Controls.Add(btnReservasi);
//            sidebarPanel.Dock = DockStyle.Left;
//            sidebarPanel.Location = new Point(0, 50);
//            sidebarPanel.Name = "sidebarPanel";
//            sidebarPanel.Size = new Size(200, 451);
//            sidebarPanel.TabIndex = 0;
//            // 
//            // pictbxUlasan
//            // 
//            pictbxUlasan.BackColor = Color.Transparent;
//            pictbxUlasan.Image = (Image)resources.GetObject("pictbxUlasan.Image");
//            pictbxUlasan.Location = new Point(17, 180);
//            pictbxUlasan.Name = "pictbxUlasan";
//            pictbxUlasan.Size = new Size(25, 25);
//            pictbxUlasan.SizeMode = PictureBoxSizeMode.StretchImage;
//            pictbxUlasan.TabIndex = 12;
//            pictbxUlasan.TabStop = false;
//            // 
//            // btnUlasan
//            // 
//            btnUlasan.BackColor = Color.Transparent;
//            btnUlasan.Cursor = Cursors.Hand;
//            btnUlasan.FlatAppearance.BorderSize = 0;
//            btnUlasan.FlatStyle = FlatStyle.Flat;
//            btnUlasan.Font = new Font("Bahnschrift Condensed", 15.75F);
//            btnUlasan.ForeColor = Color.Black;
//            btnUlasan.Location = new Point(3, 172);
//            btnUlasan.Name = "btnUlasan";
//            btnUlasan.Size = new Size(191, 40);
//            btnUlasan.TabIndex = 11;
//            btnUlasan.Text = "          Beri Penilaian";
//            btnUlasan.TextAlign = ContentAlignment.MiddleLeft;
//            btnUlasan.UseVisualStyleBackColor = false;
//            btnUlasan.Click += btnUlasan_Click;
//            // 
//            // pictbxLihatReservasi
//            // 
//            pictbxLihatReservasi.BackColor = Color.Transparent;
//            pictbxLihatReservasi.Image = (Image)resources.GetObject("pictbxLihatReservasi.Image");
//            pictbxLihatReservasi.Location = new Point(17, 88);
//            pictbxLihatReservasi.Name = "pictbxLihatReservasi";
//            pictbxLihatReservasi.Size = new Size(25, 25);
//            pictbxLihatReservasi.SizeMode = PictureBoxSizeMode.StretchImage;
//            pictbxLihatReservasi.TabIndex = 9;
//            pictbxLihatReservasi.TabStop = false;
//            // 
//            // btnLihatReservasi
//            // 
//            btnLihatReservasi.BackColor = Color.Transparent;
//            btnLihatReservasi.Cursor = Cursors.Hand;
//            btnLihatReservasi.FlatAppearance.BorderSize = 0;
//            btnLihatReservasi.FlatStyle = FlatStyle.Flat;
//            btnLihatReservasi.Font = new Font("Bahnschrift Condensed", 15.75F);
//            btnLihatReservasi.ForeColor = Color.Black;
//            btnLihatReservasi.Location = new Point(3, 80);
//            btnLihatReservasi.Name = "btnLihatReservasi";
//            btnLihatReservasi.Size = new Size(191, 40);
//            btnLihatReservasi.TabIndex = 8;
//            btnLihatReservasi.Text = "          Reservasi Anda";
//            btnLihatReservasi.TextAlign = ContentAlignment.MiddleLeft;
//            btnLihatReservasi.UseVisualStyleBackColor = false;
//            btnLihatReservasi.Click += btnLihatReservasi_Click;
//            // 
//            // pictbxLayanan
//            // 
//            pictbxLayanan.BackColor = Color.Transparent;
//            pictbxLayanan.Image = (Image)resources.GetObject("pictbxLayanan.Image");
//            pictbxLayanan.Location = new Point(17, 134);
//            pictbxLayanan.Name = "pictbxLayanan";
//            pictbxLayanan.Size = new Size(25, 25);
//            pictbxLayanan.SizeMode = PictureBoxSizeMode.StretchImage;
//            pictbxLayanan.TabIndex = 7;
//            pictbxLayanan.TabStop = false;
//            // 
//            // btnLayanan
//            // 
//            btnLayanan.BackColor = Color.Transparent;
//            btnLayanan.Cursor = Cursors.Hand;
//            btnLayanan.FlatAppearance.BorderSize = 0;
//            btnLayanan.FlatStyle = FlatStyle.Flat;
//            btnLayanan.Font = new Font("Bahnschrift Condensed", 15.75F);
//            btnLayanan.ForeColor = Color.Black;
//            btnLayanan.Location = new Point(3, 126);
//            btnLayanan.Name = "btnLayanan";
//            btnLayanan.Size = new Size(191, 40);
//            btnLayanan.TabIndex = 0;
//            btnLayanan.Text = "          Lihat Layanan";
//            btnLayanan.TextAlign = ContentAlignment.MiddleLeft;
//            btnLayanan.UseVisualStyleBackColor = false;
//            btnLayanan.Click += btnLayanan_Click;
//            // 
//            // pictbxReservasi
//            // 
//            pictbxReservasi.BackColor = Color.Transparent;
//            pictbxReservasi.Image = (Image)resources.GetObject("pictbxReservasi.Image");
//            pictbxReservasi.Location = new Point(17, 28);
//            pictbxReservasi.Name = "pictbxReservasi";
//            pictbxReservasi.Size = new Size(25, 25);
//            pictbxReservasi.SizeMode = PictureBoxSizeMode.StretchImage;
//            pictbxReservasi.TabIndex = 7;
//            pictbxReservasi.TabStop = false;
//            // 
//            // btnReservasi
//            // 
//            btnReservasi.BackColor = Color.Transparent;
//            btnReservasi.Cursor = Cursors.Hand;
//            btnReservasi.FlatAppearance.BorderSize = 0;
//            btnReservasi.FlatStyle = FlatStyle.Flat;
//            btnReservasi.Font = new Font("Bahnschrift Condensed", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
//            btnReservasi.ForeColor = Color.Black;
//            btnReservasi.Location = new Point(3, 6);
//            btnReservasi.Name = "btnReservasi";
//            btnReservasi.Size = new Size(191, 68);
//            btnReservasi.TabIndex = 1;
//            btnReservasi.Text = "          Reservasi\r\n          Sekarang";
//            btnReservasi.TextAlign = ContentAlignment.MiddleLeft;
//            btnReservasi.UseVisualStyleBackColor = false;
//            btnReservasi.Click += btnReservasi_Click;
//            // 
//            // contentAreaPanel
//            // 
//            contentAreaPanel.BackColor = Color.Transparent;
//            contentAreaPanel.Dock = DockStyle.Fill;
//            contentAreaPanel.Location = new Point(200, 50);
//            contentAreaPanel.Name = "contentAreaPanel";
//            contentAreaPanel.Size = new Size(744, 451);
//            contentAreaPanel.TabIndex = 12;
//            // 
//            // HomepageCustomerUC
//            // 
//            AutoScaleDimensions = new SizeF(7F, 15F);
//            AutoScaleMode = AutoScaleMode.Font;
//            BackColor = Color.White;
//            Controls.Add(contentAreaPanel);
//            Controls.Add(sidebarPanel);
//            Controls.Add(headerPanel);
//            Controls.Add(gbxShowProfile);
//            Name = "HomepageCustomerUC";
//            Size = new Size(944, 501);
//            headerPanel.ResumeLayout(false);
//            headerPanel.PerformLayout();
//            ((System.ComponentModel.ISupportInitialize)pictboxProfil).EndInit();
//            ((System.ComponentModel.ISupportInitialize)pictboxHome).EndInit();
//            gbxShowProfile.ResumeLayout(false);
//            sidebarPanel.ResumeLayout(false);
//            ((System.ComponentModel.ISupportInitialize)pictbxUlasan).EndInit();
//            ((System.ComponentModel.ISupportInitialize)pictbxLihatReservasi).EndInit();
//            ((System.ComponentModel.ISupportInitialize)pictbxLayanan).EndInit();
//            ((System.ComponentModel.ISupportInitialize)pictbxReservasi).EndInit();
//            ResumeLayout(false);
//        }

//        #endregion
//        private System.Windows.Forms.Panel headerPanel;
//        private System.Windows.Forms.Panel sidebarPanel;
//        private System.Windows.Forms.Panel contentAreaPanel;

//        // Header Panel Controls
//        public System.Windows.Forms.Label lblHeaderMenu;
//        private System.Windows.Forms.Label lblHomepageGreet;
//        private System.Windows.Forms.Button btnProfil;
//        private System.Windows.Forms.PictureBox pictboxProfil;
//        private System.Windows.Forms.PictureBox pictboxHome;

//        // Profile Group Box Controls
//        private System.Windows.Forms.GroupBox gbxShowProfile;
//        private System.Windows.Forms.Label lblProfilEmail;
//        private System.Windows.Forms.Label lblProfilRole;
//        private System.Windows.Forms.Button btnUbahProfil;
//        private System.Windows.Forms.Label lblProfilNama;
//        private System.Windows.Forms.Button btnHomepageLogout;

//        // Sidebar Panel Buttons and PictureBoxes
//        private System.Windows.Forms.Button btnReservasi;
//        private System.Windows.Forms.PictureBox pictbxReservasi;
//        private System.Windows.Forms.Button btnLayanan;
//        private System.Windows.Forms.PictureBox pictbxLayanan;
//        private System.Windows.Forms.Button btnLihatReservasi;
//        private System.Windows.Forms.PictureBox pictbxLihatReservasi;
//        private System.Windows.Forms.Button btnUlasan;
//        private System.Windows.Forms.PictureBox pictbxUlasan;
//    }
//}