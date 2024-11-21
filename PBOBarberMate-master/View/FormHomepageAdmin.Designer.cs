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
            lblWelcome = new Label();
            btnHomepageLogout = new Button();
            gbxMenu = new GroupBox();
            btnCustomer = new Button();
            btnKaryawan = new Button();
            btnUlasan = new Button();
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
            gbxShowProfile.SuspendLayout();
            SuspendLayout();
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.Font = new Font("Bahnschrift Condensed", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblWelcome.Location = new Point(18, 40);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(181, 58);
            lblWelcome.TabIndex = 0;
            lblWelcome.Text = "Pengguna";
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
            // gbxMenu
            // 
            gbxMenu.BackColor = Color.Ivory;
            gbxMenu.Controls.Add(btnCustomer);
            gbxMenu.Controls.Add(btnKaryawan);
            gbxMenu.Controls.Add(btnUlasan);
            gbxMenu.Controls.Add(btnPembayaran);
            gbxMenu.Controls.Add(btnReservasi);
            gbxMenu.Controls.Add(btnLayanan);
            gbxMenu.Location = new Point(215, 145);
            gbxMenu.Name = "gbxMenu";
            gbxMenu.Size = new Size(413, 237);
            gbxMenu.TabIndex = 2;
            gbxMenu.TabStop = false;
            // 
            // btnCustomer
            // 
            btnCustomer.Font = new Font("Bahnschrift Condensed", 12F);
            btnCustomer.Location = new Point(143, 125);
            btnCustomer.Name = "btnCustomer";
            btnCustomer.Size = new Size(124, 97);
            btnCustomer.TabIndex = 5;
            btnCustomer.Text = "Customer";
            btnCustomer.UseVisualStyleBackColor = true;
            // 
            // btnKaryawan
            // 
            btnKaryawan.Font = new Font("Bahnschrift Condensed", 12F);
            btnKaryawan.Location = new Point(13, 125);
            btnKaryawan.Name = "btnKaryawan";
            btnKaryawan.Size = new Size(124, 97);
            btnKaryawan.TabIndex = 4;
            btnKaryawan.Text = "Karyawan";
            btnKaryawan.UseVisualStyleBackColor = true;
            // 
            // btnUlasan
            // 
            btnUlasan.Font = new Font("Bahnschrift Condensed", 12F);
            btnUlasan.Location = new Point(273, 125);
            btnUlasan.Name = "btnUlasan";
            btnUlasan.Size = new Size(124, 97);
            btnUlasan.TabIndex = 3;
            btnUlasan.Text = "Ulasan";
            btnUlasan.UseVisualStyleBackColor = true;
            // 
            // btnPembayaran
            // 
            btnPembayaran.Font = new Font("Bahnschrift Condensed", 12F);
            btnPembayaran.Location = new Point(273, 22);
            btnPembayaran.Name = "btnPembayaran";
            btnPembayaran.Size = new Size(124, 97);
            btnPembayaran.TabIndex = 2;
            btnPembayaran.Text = "Pembayaran";
            btnPembayaran.UseVisualStyleBackColor = true;
            // 
            // btnReservasi
            // 
            btnReservasi.Font = new Font("Bahnschrift Condensed", 12F);
            btnReservasi.Location = new Point(143, 22);
            btnReservasi.Name = "btnReservasi";
            btnReservasi.Size = new Size(124, 97);
            btnReservasi.TabIndex = 1;
            btnReservasi.Text = "Reservasi";
            btnReservasi.UseVisualStyleBackColor = true;
            // 
            // btnLayanan
            // 
            btnLayanan.Font = new Font("Bahnschrift Condensed", 12F);
            btnLayanan.Location = new Point(13, 22);
            btnLayanan.Name = "btnLayanan";
            btnLayanan.Size = new Size(124, 97);
            btnLayanan.TabIndex = 0;
            btnLayanan.Text = "Layanan";
            btnLayanan.UseVisualStyleBackColor = true;
            // 
            // btnProfil
            // 
            btnProfil.BackColor = Color.FromArgb(44, 62, 80);
            btnProfil.Font = new Font("Bahnschrift Condensed", 12F);
            btnProfil.ForeColor = Color.White;
            btnProfil.Location = new Point(730, 10);
            btnProfil.Name = "btnProfil";
            btnProfil.Size = new Size(55, 36);
            btnProfil.TabIndex = 3;
            btnProfil.Text = "Profil";
            btnProfil.UseVisualStyleBackColor = false;
            btnProfil.Click += btnProfil_Click;
            btnProfil.MouseEnter += btnProfil_MouseEnter;
            btnProfil.MouseLeave += btnProfil_MouseLeave;
            // 
            // lblHomepageGreet
            // 
            lblHomepageGreet.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblHomepageGreet.AutoSize = true;
            lblHomepageGreet.Font = new Font("Bahnschrift Condensed", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblHomepageGreet.Location = new Point(25, 20);
            lblHomepageGreet.Name = "lblHomepageGreet";
            lblHomepageGreet.Size = new Size(33, 23);
            lblHomepageGreet.TabIndex = 5;
            lblHomepageGreet.Text = "Hai,";
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
            // FormHomepageAdmin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Ivory;
            ClientSize = new Size(800, 450);
            Controls.Add(gbxShowProfile);
            Controls.Add(lblHomepageGreet);
            Controls.Add(btnProfil);
            Controls.Add(gbxMenu);
            Controls.Add(lblWelcome);
            Name = "FormHomepageAdmin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "BarberMate : Dashboard";
            Click += FormHomepageAdmin_Click;
            gbxMenu.ResumeLayout(false);
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
        private Button btnUlasan;
        private Button btnPembayaran;
        private Label lblHomepageGreet;
        private GroupBox gbxShowProfile;
        private Button btnUbahProfil;
        private Label lblProfilNama;
        private Label lblProfilEmail;
        private Label lblProfilRole;
    }
}