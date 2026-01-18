namespace PBOBarberMate.Presentation.Views.Auth
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
            btnProfil = new Button();
            pictboxProfil = new PictureBox();
            pictboxHome = new PictureBox();
            lblHeaderMenu = new Label();
            lblHomepageGreet = new Label();
            sidebarPanel = new Panel();
            pictbxPembayaran = new PictureBox();
            pictbxCustomer = new PictureBox();
            pictbxKaryawan = new PictureBox();
            pictbxReservasi = new PictureBox();
            pictbxKunjungan = new PictureBox();
            btnPembayaran = new Button();
            btnReservasi = new Button();
            pictbxInventaris = new PictureBox();
            pictbxShift = new PictureBox();
            btnKunjungan = new Button();
            btnKaryawan = new Button();
            btnShift = new Button();
            btnInventaris = new Button();
            btnCustomer = new Button();
            pictbxLayanan = new PictureBox();
            btnLayanan = new Button();
            contentAreaPanel = new Panel();
            headerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictboxProfil).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictboxHome).BeginInit();
            sidebarPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictbxPembayaran).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictbxCustomer).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictbxKaryawan).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictbxReservasi).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictbxKunjungan).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictbxInventaris).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictbxShift).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictbxLayanan).BeginInit();
            SuspendLayout();
            // 
            // headerPanel
            // 
            headerPanel.BackColor = Color.FromArgb(44, 62, 80);
            headerPanel.Controls.Add(btnProfil);
            headerPanel.Controls.Add(pictboxProfil);
            headerPanel.Controls.Add(pictboxHome);
            headerPanel.Controls.Add(lblHeaderMenu);
            headerPanel.Controls.Add(lblHomepageGreet);
            headerPanel.Dock = DockStyle.Top;
            headerPanel.Location = new Point(0, 0);
            headerPanel.Name = "headerPanel";
            headerPanel.Size = new Size(944, 50);
            headerPanel.TabIndex = 7;
            headerPanel.Resize += headerPanel_Resize;
            // 
            // btnProfil
            // 
            btnProfil.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnProfil.AutoSize = true;
            btnProfil.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnProfil.BackColor = Color.White;
            btnProfil.Cursor = Cursors.Hand;
            btnProfil.FlatAppearance.BorderSize = 0;
            btnProfil.FlatStyle = FlatStyle.Flat;
            btnProfil.Font = new Font("Bahnschrift Condensed", 12F);
            btnProfil.ForeColor = Color.Black;
            btnProfil.Location = new Point(884, 11);
            btnProfil.Name = "btnProfil";
            btnProfil.Size = new Size(48, 29);
            btnProfil.TabIndex = 3;
            btnProfil.Text = "Profil";
            btnProfil.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnProfil.UseVisualStyleBackColor = false;
            btnProfil.Click += btnProfil_Click;
            // 
            // pictboxProfil
            // 
            pictboxProfil.BackColor = Color.White;
            pictboxProfil.Image = (Image)resources.GetObject("pictboxProfil.Image");
            pictboxProfil.Location = new Point(852, 11);
            pictboxProfil.Name = "pictboxProfil";
            pictboxProfil.Size = new Size(29, 29);
            pictboxProfil.SizeMode = PictureBoxSizeMode.Zoom;
            pictboxProfil.TabIndex = 8;
            pictboxProfil.TabStop = false;
            // 
            // pictboxHome
            // 
            pictboxHome.Cursor = Cursors.Hand;
            pictboxHome.Image = (Image)resources.GetObject("pictboxHome.Image");
            pictboxHome.Location = new Point(3, 3);
            pictboxHome.Name = "pictboxHome";
            pictboxHome.Size = new Size(45, 45);
            pictboxHome.SizeMode = PictureBoxSizeMode.CenterImage;
            pictboxHome.TabIndex = 7;
            pictboxHome.TabStop = false;
            pictboxHome.Click += pictboxHome_Click;
            // 
            // lblHeaderMenu
            // 
            lblHeaderMenu.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblHeaderMenu.AutoSize = true;
            lblHeaderMenu.BackColor = Color.Transparent;
            lblHeaderMenu.Font = new Font("Bahnschrift Condensed", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHeaderMenu.ForeColor = Color.White;
            lblHeaderMenu.Location = new Point(442, 13);
            lblHeaderMenu.Name = "lblHeaderMenu";
            lblHeaderMenu.Size = new Size(13, 23);
            lblHeaderMenu.TabIndex = 0;
            lblHeaderMenu.Text = ".";
            lblHeaderMenu.TextAlign = ContentAlignment.MiddleLeft;
            lblHeaderMenu.TextChanged += lblHeaderMenu_TextChanged;
            // 
            // lblHomepageGreet
            // 
            lblHomepageGreet.AutoSize = true;
            lblHomepageGreet.BackColor = Color.Transparent;
            lblHomepageGreet.Font = new Font("Bahnschrift Condensed", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblHomepageGreet.ForeColor = Color.White;
            lblHomepageGreet.Location = new Point(53, 13);
            lblHomepageGreet.Name = "lblHomepageGreet";
            lblHomepageGreet.Size = new Size(84, 23);
            lblHomepageGreet.TabIndex = 5;
            lblHomepageGreet.Text = "BarberMate";
            lblHomepageGreet.TextAlign = ContentAlignment.MiddleRight;
            // 
            // sidebarPanel
            // 
            sidebarPanel.BackColor = Color.FromArgb(145, 197, 249);
            sidebarPanel.Controls.Add(pictbxPembayaran);
            sidebarPanel.Controls.Add(pictbxCustomer);
            sidebarPanel.Controls.Add(pictbxKaryawan);
            sidebarPanel.Controls.Add(pictbxReservasi);
            sidebarPanel.Controls.Add(pictbxKunjungan);
            sidebarPanel.Controls.Add(btnPembayaran);
            sidebarPanel.Controls.Add(btnReservasi);
            sidebarPanel.Controls.Add(pictbxInventaris);
            sidebarPanel.Controls.Add(pictbxShift);
            sidebarPanel.Controls.Add(btnKunjungan);
            sidebarPanel.Controls.Add(btnKaryawan);
            sidebarPanel.Controls.Add(btnShift);
            sidebarPanel.Controls.Add(btnInventaris);
            sidebarPanel.Controls.Add(btnCustomer);
            sidebarPanel.Controls.Add(pictbxLayanan);
            sidebarPanel.Controls.Add(btnLayanan);
            sidebarPanel.Dock = DockStyle.Left;
            sidebarPanel.Location = new Point(0, 50);
            sidebarPanel.Name = "sidebarPanel";
            sidebarPanel.Size = new Size(200, 451);
            sidebarPanel.TabIndex = 0;
            // 
            // pictbxPembayaran
            // 
            pictbxPembayaran.BackColor = Color.Transparent;
            pictbxPembayaran.Image = (Image)resources.GetObject("pictbxPembayaran.Image");
            pictbxPembayaran.Location = new Point(17, 60);
            pictbxPembayaran.Name = "pictbxPembayaran";
            pictbxPembayaran.Size = new Size(25, 25);
            pictbxPembayaran.SizeMode = PictureBoxSizeMode.StretchImage;
            pictbxPembayaran.TabIndex = 7;
            pictbxPembayaran.TabStop = false;
            // 
            // pictbxCustomer
            // 
            pictbxCustomer.BackColor = Color.Transparent;
            pictbxCustomer.Image = (Image)resources.GetObject("pictbxCustomer.Image");
            pictbxCustomer.Location = new Point(17, 357);
            pictbxCustomer.Name = "pictbxCustomer";
            pictbxCustomer.Size = new Size(25, 25);
            pictbxCustomer.SizeMode = PictureBoxSizeMode.StretchImage;
            pictbxCustomer.TabIndex = 7;
            pictbxCustomer.TabStop = false;
            // 
            // pictbxKaryawan
            // 
            pictbxKaryawan.BackColor = Color.Transparent;
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
            // pictbxKunjungan
            // 
            pictbxKunjungan.BackColor = Color.Transparent;
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
            btnPembayaran.Cursor = Cursors.Hand;
            btnPembayaran.FlatAppearance.BorderSize = 0;
            btnPembayaran.FlatStyle = FlatStyle.Flat;
            btnPembayaran.Font = new Font("Bahnschrift Condensed", 15.75F);
            btnPembayaran.ForeColor = Color.Black;
            btnPembayaran.Location = new Point(3, 52);
            btnPembayaran.Name = "btnPembayaran";
            btnPembayaran.Size = new Size(191, 40);
            btnPembayaran.TabIndex = 2;
            btnPembayaran.Text = "          Pembayaran";
            btnPembayaran.TextAlign = ContentAlignment.MiddleLeft;
            btnPembayaran.UseVisualStyleBackColor = false;
            btnPembayaran.Click += btnPembayaran_Click;
            // 
            // btnReservasi
            // 
            btnReservasi.BackColor = Color.Transparent;
            btnReservasi.Cursor = Cursors.Hand;
            btnReservasi.FlatAppearance.BorderSize = 0;
            btnReservasi.FlatStyle = FlatStyle.Flat;
            btnReservasi.Font = new Font("Bahnschrift Condensed", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnReservasi.ForeColor = Color.Black;
            btnReservasi.Location = new Point(3, 6);
            btnReservasi.Name = "btnReservasi";
            btnReservasi.Size = new Size(191, 40);
            btnReservasi.TabIndex = 1;
            btnReservasi.Text = "          Kelola Reservasi";
            btnReservasi.TextAlign = ContentAlignment.MiddleLeft;
            btnReservasi.UseVisualStyleBackColor = false;
            btnReservasi.Click += btnReservasi_Click;
            // 
            // pictbxInventaris
            // 
            pictbxInventaris.BackColor = Color.Transparent;
            pictbxInventaris.Image = (Image)resources.GetObject("pictbxInventaris.Image");
            pictbxInventaris.Location = new Point(17, 311);
            pictbxInventaris.Name = "pictbxInventaris";
            pictbxInventaris.Size = new Size(25, 25);
            pictbxInventaris.SizeMode = PictureBoxSizeMode.StretchImage;
            pictbxInventaris.TabIndex = 11;
            pictbxInventaris.TabStop = false;
            // 
            // pictbxShift
            // 
            pictbxShift.BackColor = Color.Transparent;
            pictbxShift.Image = (Image)resources.GetObject("pictbxShift.Image");
            pictbxShift.Location = new Point(17, 218);
            pictbxShift.Name = "pictbxShift";
            pictbxShift.Size = new Size(25, 25);
            pictbxShift.SizeMode = PictureBoxSizeMode.StretchImage;
            pictbxShift.TabIndex = 13;
            pictbxShift.TabStop = false;
            // 
            // btnKunjungan
            // 
            btnKunjungan.BackColor = Color.Transparent;
            btnKunjungan.Cursor = Cursors.Hand;
            btnKunjungan.FlatAppearance.BorderSize = 0;
            btnKunjungan.FlatStyle = FlatStyle.Flat;
            btnKunjungan.Font = new Font("Bahnschrift Condensed", 15.75F);
            btnKunjungan.ForeColor = Color.Black;
            btnKunjungan.ImageAlign = ContentAlignment.MiddleLeft;
            btnKunjungan.Location = new Point(3, 98);
            btnKunjungan.Name = "btnKunjungan";
            btnKunjungan.Size = new Size(191, 60);
            btnKunjungan.TabIndex = 3;
            btnKunjungan.Text = "          Riwayat\r\n          Kunjungan";
            btnKunjungan.TextAlign = ContentAlignment.MiddleLeft;
            btnKunjungan.UseVisualStyleBackColor = false;
            btnKunjungan.Click += btnKunjungan_Click;
            // 
            // btnKaryawan
            // 
            btnKaryawan.BackColor = Color.Transparent;
            btnKaryawan.Cursor = Cursors.Hand;
            btnKaryawan.FlatAppearance.BorderSize = 0;
            btnKaryawan.FlatStyle = FlatStyle.Flat;
            btnKaryawan.Font = new Font("Bahnschrift Condensed", 15.75F);
            btnKaryawan.ForeColor = Color.Black;
            btnKaryawan.Location = new Point(3, 164);
            btnKaryawan.Name = "btnKaryawan";
            btnKaryawan.Size = new Size(191, 40);
            btnKaryawan.TabIndex = 4;
            btnKaryawan.Text = "          Kelola Karyawan";
            btnKaryawan.TextAlign = ContentAlignment.MiddleLeft;
            btnKaryawan.UseVisualStyleBackColor = false;
            btnKaryawan.Click += btnKaryawan_Click;
            // 
            // btnShift
            // 
            btnShift.BackColor = Color.Transparent;
            btnShift.Cursor = Cursors.Hand;
            btnShift.FlatAppearance.BorderSize = 0;
            btnShift.FlatStyle = FlatStyle.Flat;
            btnShift.Font = new Font("Bahnschrift Condensed", 15.75F);
            btnShift.ForeColor = Color.Black;
            btnShift.Location = new Point(3, 210);
            btnShift.Name = "btnShift";
            btnShift.Size = new Size(191, 40);
            btnShift.TabIndex = 12;
            btnShift.Text = "          Kelola Shift";
            btnShift.TextAlign = ContentAlignment.MiddleLeft;
            btnShift.UseVisualStyleBackColor = false;
            btnShift.Click += btnShift_Click;
            // 
            // btnInventaris
            // 
            btnInventaris.BackColor = Color.Transparent;
            btnInventaris.Cursor = Cursors.Hand;
            btnInventaris.FlatAppearance.BorderSize = 0;
            btnInventaris.FlatStyle = FlatStyle.Flat;
            btnInventaris.Font = new Font("Bahnschrift Condensed", 15.75F);
            btnInventaris.ForeColor = Color.Black;
            btnInventaris.Location = new Point(3, 302);
            btnInventaris.Name = "btnInventaris";
            btnInventaris.Size = new Size(191, 40);
            btnInventaris.TabIndex = 10;
            btnInventaris.Text = "          Kelola Inventory";
            btnInventaris.TextAlign = ContentAlignment.MiddleLeft;
            btnInventaris.UseVisualStyleBackColor = false;
            btnInventaris.Click += btnInventory_Click;
            // 
            // btnCustomer
            // 
            btnCustomer.BackColor = Color.Transparent;
            btnCustomer.Cursor = Cursors.Hand;
            btnCustomer.FlatAppearance.BorderSize = 0;
            btnCustomer.FlatStyle = FlatStyle.Flat;
            btnCustomer.Font = new Font("Bahnschrift Condensed", 15.75F);
            btnCustomer.ForeColor = Color.Black;
            btnCustomer.ImageAlign = ContentAlignment.MiddleLeft;
            btnCustomer.Location = new Point(3, 348);
            btnCustomer.Name = "btnCustomer";
            btnCustomer.Size = new Size(191, 40);
            btnCustomer.TabIndex = 5;
            btnCustomer.Text = "          Kelola Customer";
            btnCustomer.TextAlign = ContentAlignment.MiddleLeft;
            btnCustomer.UseVisualStyleBackColor = false;
            btnCustomer.Click += btnCustomer_Click;
            // 
            // pictbxLayanan
            // 
            pictbxLayanan.BackColor = Color.Transparent;
            pictbxLayanan.Image = (Image)resources.GetObject("pictbxLayanan.Image");
            pictbxLayanan.Location = new Point(17, 264);
            pictbxLayanan.Name = "pictbxLayanan";
            pictbxLayanan.Size = new Size(25, 25);
            pictbxLayanan.SizeMode = PictureBoxSizeMode.StretchImage;
            pictbxLayanan.TabIndex = 7;
            pictbxLayanan.TabStop = false;
            // 
            // btnLayanan
            // 
            btnLayanan.BackColor = Color.Transparent;
            btnLayanan.Cursor = Cursors.Hand;
            btnLayanan.FlatAppearance.BorderSize = 0;
            btnLayanan.FlatStyle = FlatStyle.Flat;
            btnLayanan.Font = new Font("Bahnschrift Condensed", 15.75F);
            btnLayanan.ForeColor = Color.Black;
            btnLayanan.Location = new Point(3, 256);
            btnLayanan.Name = "btnLayanan";
            btnLayanan.Size = new Size(191, 40);
            btnLayanan.TabIndex = 0;
            btnLayanan.Text = "          Kelola Layanan";
            btnLayanan.TextAlign = ContentAlignment.MiddleLeft;
            btnLayanan.UseVisualStyleBackColor = false;
            btnLayanan.Click += btnLayanan_Click;
            // 
            // contentAreaPanel
            // 
            contentAreaPanel.BackColor = Color.Transparent;
            contentAreaPanel.Dock = DockStyle.Fill;
            contentAreaPanel.Location = new Point(200, 50);
            contentAreaPanel.Name = "contentAreaPanel";
            contentAreaPanel.Size = new Size(744, 451);
            contentAreaPanel.TabIndex = 1;
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
            headerPanel.ResumeLayout(false);
            headerPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictboxProfil).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictboxHome).EndInit();
            sidebarPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictbxPembayaran).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictbxCustomer).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictbxKaryawan).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictbxReservasi).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictbxKunjungan).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictbxInventaris).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictbxShift).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictbxLayanan).EndInit();
            ResumeLayout(false);
        }

        #endregion
        // Deklarasi komponen baru
        private System.Windows.Forms.Panel headerPanel;
        private System.Windows.Forms.Panel sidebarPanel;
        private System.Windows.Forms.Panel contentAreaPanel;

        // Komponen yang dipindahkan ke headerPanel
        public System.Windows.Forms.Label lblHeaderMenu;
        private System.Windows.Forms.Label lblHomepageGreet;
        private System.Windows.Forms.Button btnProfil;

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
        private PictureBox pictboxHome;
        private PictureBox pictboxProfil;
    }
}
