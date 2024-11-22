namespace PBOBarberMate.View
{
    partial class FormUbahProfil
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
            btnKembali = new Button();
            lblProfilEmail = new Label();
            lblProfilNama = new Label();
            lblProfilPassword = new Label();
            btnUbahNamaPengguna = new Button();
            btnUbahEmail = new Button();
            btnUbahPassword = new Button();
            tbUbahNamaPengguna = new TextBox();
            btnBatalUbahNamaPengguna = new Button();
            btnSimpanUbahNamaPengguna = new Button();
            tbUbahEmail = new TextBox();
            btnBatalUbahEmail = new Button();
            btnSimpanUbahEmail = new Button();
            tbUbahPassword = new TextBox();
            btnBatalUbahPassword = new Button();
            btnSimpanUbahPassword = new Button();
            SuspendLayout();
            // 
            // btnKembali
            // 
            btnKembali.Location = new Point(12, 12);
            btnKembali.Name = "btnKembali";
            btnKembali.Size = new Size(75, 39);
            btnKembali.TabIndex = 0;
            btnKembali.Text = "Kembali";
            btnKembali.UseVisualStyleBackColor = true;
            btnKembali.Click += btnKembali_Click;
            // 
            // lblProfilEmail
            // 
            lblProfilEmail.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblProfilEmail.BackColor = Color.Transparent;
            lblProfilEmail.Font = new Font("Bahnschrift Light Condensed", 9F);
            lblProfilEmail.ForeColor = Color.White;
            lblProfilEmail.Location = new Point(81, 138);
            lblProfilEmail.Name = "lblProfilEmail";
            lblProfilEmail.Size = new Size(158, 23);
            lblProfilEmail.TabIndex = 5;
            lblProfilEmail.Text = "isi_email";
            // 
            // lblProfilNama
            // 
            lblProfilNama.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblProfilNama.Font = new Font("Bahnschrift Condensed", 11.25F);
            lblProfilNama.ForeColor = Color.White;
            lblProfilNama.Location = new Point(81, 93);
            lblProfilNama.Name = "lblProfilNama";
            lblProfilNama.Size = new Size(158, 42);
            lblProfilNama.TabIndex = 4;
            lblProfilNama.Text = "Nama";
            // 
            // lblProfilPassword
            // 
            lblProfilPassword.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblProfilPassword.BackColor = Color.Transparent;
            lblProfilPassword.Font = new Font("Bahnschrift Light Condensed", 9F);
            lblProfilPassword.ForeColor = Color.White;
            lblProfilPassword.Location = new Point(81, 181);
            lblProfilPassword.Name = "lblProfilPassword";
            lblProfilPassword.Size = new Size(158, 23);
            lblProfilPassword.TabIndex = 6;
            lblProfilPassword.Text = "Password";
            // 
            // btnUbahNamaPengguna
            // 
            btnUbahNamaPengguna.BackColor = Color.White;
            btnUbahNamaPengguna.FlatAppearance.BorderColor = Color.FromArgb(44, 62, 80);
            btnUbahNamaPengguna.FlatAppearance.BorderSize = 0;
            btnUbahNamaPengguna.FlatAppearance.MouseDownBackColor = Color.FromArgb(44, 62, 80);
            btnUbahNamaPengguna.FlatAppearance.MouseOverBackColor = Color.FromArgb(44, 62, 80);
            btnUbahNamaPengguna.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnUbahNamaPengguna.ForeColor = Color.Black;
            btnUbahNamaPengguna.Location = new Point(490, 90);
            btnUbahNamaPengguna.Name = "btnUbahNamaPengguna";
            btnUbahNamaPengguna.Size = new Size(151, 26);
            btnUbahNamaPengguna.TabIndex = 7;
            btnUbahNamaPengguna.Text = "Ubah Nama Pengguna";
            btnUbahNamaPengguna.UseVisualStyleBackColor = false;
            btnUbahNamaPengguna.Click += btnUbahNamaPengguna_Click;
            // 
            // btnUbahEmail
            // 
            btnUbahEmail.BackColor = Color.White;
            btnUbahEmail.FlatAppearance.BorderColor = Color.FromArgb(44, 62, 80);
            btnUbahEmail.FlatAppearance.BorderSize = 0;
            btnUbahEmail.FlatAppearance.MouseDownBackColor = Color.FromArgb(44, 62, 80);
            btnUbahEmail.FlatAppearance.MouseOverBackColor = Color.FromArgb(44, 62, 80);
            btnUbahEmail.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnUbahEmail.ForeColor = Color.Black;
            btnUbahEmail.Location = new Point(490, 132);
            btnUbahEmail.Name = "btnUbahEmail";
            btnUbahEmail.Size = new Size(151, 26);
            btnUbahEmail.TabIndex = 8;
            btnUbahEmail.Text = "Ubah Email";
            btnUbahEmail.UseVisualStyleBackColor = false;
            btnUbahEmail.Click += btnUbahEmail_Click;
            // 
            // btnUbahPassword
            // 
            btnUbahPassword.BackColor = Color.White;
            btnUbahPassword.FlatAppearance.BorderColor = Color.FromArgb(44, 62, 80);
            btnUbahPassword.FlatAppearance.BorderSize = 0;
            btnUbahPassword.FlatAppearance.MouseDownBackColor = Color.FromArgb(44, 62, 80);
            btnUbahPassword.FlatAppearance.MouseOverBackColor = Color.FromArgb(44, 62, 80);
            btnUbahPassword.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnUbahPassword.ForeColor = Color.Black;
            btnUbahPassword.Location = new Point(490, 175);
            btnUbahPassword.Name = "btnUbahPassword";
            btnUbahPassword.Size = new Size(151, 26);
            btnUbahPassword.TabIndex = 9;
            btnUbahPassword.Text = "Ubah Password";
            btnUbahPassword.UseVisualStyleBackColor = false;
            btnUbahPassword.Click += btnUbahPassword_Click;
            // 
            // tbUbahNamaPengguna
            // 
            tbUbahNamaPengguna.Location = new Point(197, 92);
            tbUbahNamaPengguna.Name = "tbUbahNamaPengguna";
            tbUbahNamaPengguna.Size = new Size(279, 23);
            tbUbahNamaPengguna.TabIndex = 10;
            tbUbahNamaPengguna.Visible = false;
            // 
            // btnBatalUbahNamaPengguna
            // 
            btnBatalUbahNamaPengguna.Location = new Point(490, 90);
            btnBatalUbahNamaPengguna.Name = "btnBatalUbahNamaPengguna";
            btnBatalUbahNamaPengguna.Size = new Size(69, 26);
            btnBatalUbahNamaPengguna.TabIndex = 11;
            btnBatalUbahNamaPengguna.Text = "Batal";
            btnBatalUbahNamaPengguna.UseVisualStyleBackColor = true;
            btnBatalUbahNamaPengguna.Visible = false;
            btnBatalUbahNamaPengguna.Click += btnBatalUbahNamaPengguna_Click;
            // 
            // btnSimpanUbahNamaPengguna
            // 
            btnSimpanUbahNamaPengguna.Location = new Point(572, 90);
            btnSimpanUbahNamaPengguna.Name = "btnSimpanUbahNamaPengguna";
            btnSimpanUbahNamaPengguna.Size = new Size(69, 26);
            btnSimpanUbahNamaPengguna.TabIndex = 12;
            btnSimpanUbahNamaPengguna.Text = "Simpan";
            btnSimpanUbahNamaPengguna.UseVisualStyleBackColor = true;
            btnSimpanUbahNamaPengguna.Visible = false;
            btnSimpanUbahNamaPengguna.Click += btnSimpanUbahNamaPengguna_Click;
            // 
            // tbUbahEmail
            // 
            tbUbahEmail.Location = new Point(197, 135);
            tbUbahEmail.Name = "tbUbahEmail";
            tbUbahEmail.Size = new Size(279, 23);
            tbUbahEmail.TabIndex = 13;
            tbUbahEmail.Visible = false;
            // 
            // btnBatalUbahEmail
            // 
            btnBatalUbahEmail.Location = new Point(490, 132);
            btnBatalUbahEmail.Name = "btnBatalUbahEmail";
            btnBatalUbahEmail.Size = new Size(69, 26);
            btnBatalUbahEmail.TabIndex = 14;
            btnBatalUbahEmail.Text = "Batal";
            btnBatalUbahEmail.UseVisualStyleBackColor = true;
            btnBatalUbahEmail.Visible = false;
            btnBatalUbahEmail.Click += btnBatalUbahEmail_Click;
            // 
            // btnSimpanUbahEmail
            // 
            btnSimpanUbahEmail.Location = new Point(572, 132);
            btnSimpanUbahEmail.Name = "btnSimpanUbahEmail";
            btnSimpanUbahEmail.Size = new Size(69, 26);
            btnSimpanUbahEmail.TabIndex = 15;
            btnSimpanUbahEmail.Text = "Simpan";
            btnSimpanUbahEmail.UseVisualStyleBackColor = true;
            btnSimpanUbahEmail.Visible = false;
            btnSimpanUbahEmail.Click += btnSimpanUbahEmail_Click;
            // 
            // tbUbahPassword
            // 
            tbUbahPassword.Location = new Point(197, 181);
            tbUbahPassword.Name = "tbUbahPassword";
            tbUbahPassword.Size = new Size(279, 23);
            tbUbahPassword.TabIndex = 16;
            tbUbahPassword.Visible = false;
            // 
            // btnBatalUbahPassword
            // 
            btnBatalUbahPassword.Location = new Point(490, 175);
            btnBatalUbahPassword.Name = "btnBatalUbahPassword";
            btnBatalUbahPassword.Size = new Size(69, 26);
            btnBatalUbahPassword.TabIndex = 17;
            btnBatalUbahPassword.Text = "Batal";
            btnBatalUbahPassword.UseVisualStyleBackColor = true;
            btnBatalUbahPassword.Visible = false;
            btnBatalUbahPassword.Click += btnBatalUbahPassword_Click;
            // 
            // btnSimpanUbahPassword
            // 
            btnSimpanUbahPassword.Location = new Point(572, 175);
            btnSimpanUbahPassword.Name = "btnSimpanUbahPassword";
            btnSimpanUbahPassword.Size = new Size(69, 26);
            btnSimpanUbahPassword.TabIndex = 18;
            btnSimpanUbahPassword.Text = "Simpan";
            btnSimpanUbahPassword.UseVisualStyleBackColor = true;
            btnSimpanUbahPassword.Visible = false;
            btnSimpanUbahPassword.Click += btnSimpanUbahPassword_Click;
            // 
            // FormUbahProfil
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(44, 62, 80);
            ClientSize = new Size(800, 450);
            Controls.Add(btnSimpanUbahPassword);
            Controls.Add(btnBatalUbahPassword);
            Controls.Add(tbUbahPassword);
            Controls.Add(btnSimpanUbahEmail);
            Controls.Add(btnBatalUbahEmail);
            Controls.Add(tbUbahEmail);
            Controls.Add(btnSimpanUbahNamaPengguna);
            Controls.Add(btnBatalUbahNamaPengguna);
            Controls.Add(tbUbahNamaPengguna);
            Controls.Add(btnUbahPassword);
            Controls.Add(btnUbahEmail);
            Controls.Add(btnUbahNamaPengguna);
            Controls.Add(lblProfilPassword);
            Controls.Add(lblProfilEmail);
            Controls.Add(lblProfilNama);
            Controls.Add(btnKembali);
            Name = "FormUbahProfil";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "BarberMate : Ubah Profil";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnKembali;
        public Label lblProfilEmail;
        public Label lblProfilNama;
        private Label lblProfilPassword;
        private Button btnUbahNamaPengguna;
        private Button btnUbahEmail;
        private Button btnUbahPassword;
        private TextBox tbUbahNamaPengguna;
        private Button btnBatalUbahNamaPengguna;
        private Button btnSimpanUbahNamaPengguna;
        private TextBox tbUbahEmail;
        private Button btnBatalUbahEmail;
        private Button btnSimpanUbahEmail;
        private TextBox tbUbahPassword;
        private Button btnBatalUbahPassword;
        private Button btnSimpanUbahPassword;
    }
}