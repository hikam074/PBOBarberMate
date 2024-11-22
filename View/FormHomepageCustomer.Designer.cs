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
            btnRiwayat = new Button();
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
            gbxShowProfile.Location = new Point(615, 50);
            gbxShowProfile.Margin = new Padding(0);
            gbxShowProfile.Name = "gbxShowProfile";
            gbxShowProfile.Size = new Size(170, 144);
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
            // lblHomepageGreet
            // 
            lblHomepageGreet.AutoSize = true;
            lblHomepageGreet.Font = new Font("Bahnschrift Condensed", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblHomepageGreet.ForeColor = Color.FromArgb(44, 62, 80);
            lblHomepageGreet.Location = new Point(25, 20);
            lblHomepageGreet.Name = "lblHomepageGreet";
            lblHomepageGreet.Size = new Size(33, 23);
            lblHomepageGreet.TabIndex = 10;
            lblHomepageGreet.Text = "Hai,";
            // 
            // btnProfil
            // 
            btnProfil.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnProfil.BackColor = Color.FromArgb(44, 62, 80);
            btnProfil.Font = new Font("Bahnschrift Condensed", 12F);
            btnProfil.ForeColor = Color.White;
            btnProfil.Location = new Point(730, 10);
            btnProfil.Name = "btnProfil";
            btnProfil.Size = new Size(55, 36);
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
            btnLayanan.Location = new Point(154, 15);
            btnLayanan.Name = "btnLayanan";
            btnLayanan.Padding = new Padding(9);
            btnLayanan.Size = new Size(140, 125);
            btnLayanan.TabIndex = 0;
            btnLayanan.Text = "Lihat\r\nLayanan";
            btnLayanan.TextAlign = ContentAlignment.BottomCenter;
            btnLayanan.UseVisualStyleBackColor = false;
            // 
            // gbxMenu
            // 
            gbxMenu.Anchor = AnchorStyles.Top;
            gbxMenu.BackColor = Color.White;
            gbxMenu.Controls.Add(pictbxUlasan);
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
            gbxMenu.TabIndex = 8;
            gbxMenu.TabStop = false;
            // 
            // pictbxUlasan
            // 
            pictbxUlasan.Anchor = AnchorStyles.Top;
            pictbxUlasan.Image = (Image)resources.GetObject("pictbxUlasan.Image");
            pictbxUlasan.Location = new Point(466, 29);
            pictbxUlasan.Name = "pictbxUlasan";
            pictbxUlasan.Size = new Size(100, 43);
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
            btnUlasan.Location = new Point(446, 15);
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
            btnRiwayat.Text = "Riwayat Kunjungan";
            btnRiwayat.TextAlign = ContentAlignment.BottomCenter;
            btnRiwayat.UseVisualStyleBackColor = false;
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.Font = new Font("Bahnschrift Condensed", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblWelcome.ForeColor = Color.FromArgb(44, 62, 80);
            lblWelcome.Location = new Point(18, 40);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(181, 58);
            lblWelcome.TabIndex = 7;
            lblWelcome.Text = "Pengguna";
            // 
            // dgvJadwalMingguIni
            // 
            dgvJadwalMingguIni.Anchor = AnchorStyles.Top;
            dgvJadwalMingguIni.BackgroundColor = Color.White;
            dgvJadwalMingguIni.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvJadwalMingguIni.GridColor = Color.FromArgb(44, 62, 80);
            dgvJadwalMingguIni.Location = new Point(112, 320);
            dgvJadwalMingguIni.Name = "dgvJadwalMingguIni";
            dgvJadwalMingguIni.Size = new Size(595, 97);
            dgvJadwalMingguIni.TabIndex = 12;
            // 
            // lblJadwalMingguIni
            // 
            lblJadwalMingguIni.Anchor = AnchorStyles.Top;
            lblJadwalMingguIni.AutoSize = true;
            lblJadwalMingguIni.Font = new Font("Bahnschrift Condensed", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblJadwalMingguIni.ForeColor = Color.FromArgb(44, 62, 80);
            lblJadwalMingguIni.Location = new Point(112, 294);
            lblJadwalMingguIni.Name = "lblJadwalMingguIni";
            lblJadwalMingguIni.Size = new Size(173, 23);
            lblJadwalMingguIni.TabIndex = 13;
            lblJadwalMingguIni.Text = "Reservasi terdekat anda :";
            // 
            // lklbMore
            // 
            lklbMore.Anchor = AnchorStyles.Top;
            lklbMore.AutoSize = true;
            lklbMore.Location = new Point(595, 420);
            lklbMore.Name = "lklbMore";
            lklbMore.Size = new Size(112, 15);
            lklbMore.TabIndex = 14;
            lklbMore.TabStop = true;
            lklbMore.Text = "Lihat lebih banyak...";
            // 
            // FormHomepageCustomer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(lklbMore);
            Controls.Add(lblJadwalMingguIni);
            Controls.Add(dgvJadwalMingguIni);
            Controls.Add(gbxShowProfile);
            Controls.Add(lblHomepageGreet);
            Controls.Add(btnProfil);
            Controls.Add(gbxMenu);
            Controls.Add(lblWelcome);
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
        private Button btnRiwayat;
        private PictureBox pictbxReservasiSekarang;
        private DataGridView dgvJadwalMingguIni;
        private Label lblJadwalMingguIni;
        private LinkLabel lklbMore;
        private Button btnUlasan;
        private PictureBox pictbxUlasan;
    }
}