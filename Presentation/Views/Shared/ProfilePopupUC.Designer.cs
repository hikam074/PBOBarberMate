namespace PBOBarberMate.Presentation.Views.Shared
{
    partial class ProfilePopupUC
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
            lblProfilEmail = new Label();
            lblProfilRole = new Label();
            btnUbahProfil = new Button();
            lblProfilNama = new Label();
            btnHomepageLogout = new Button();
            lblProfilUsername = new Label();
            SuspendLayout();
            // 
            // lblProfilEmail
            // 
            lblProfilEmail.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblProfilEmail.BackColor = Color.Transparent;
            lblProfilEmail.Font = new Font("Bahnschrift Light Condensed", 9F);
            lblProfilEmail.ForeColor = Color.White;
            lblProfilEmail.Location = new Point(7, 94);
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
            lblProfilRole.Location = new Point(7, 9);
            lblProfilRole.Name = "lblProfilRole";
            lblProfilRole.Size = new Size(158, 21);
            lblProfilRole.TabIndex = 2;
            lblProfilRole.Text = "nama_role";
            lblProfilRole.TextAlign = ContentAlignment.TopRight;
            // 
            // btnUbahProfil
            // 
            btnUbahProfil.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnUbahProfil.BackColor = Color.White;
            btnUbahProfil.Cursor = Cursors.Hand;
            btnUbahProfil.Font = new Font("Bahnschrift Light Condensed", 9F);
            btnUbahProfil.ForeColor = Color.Black;
            btnUbahProfil.Location = new Point(77, 127);
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
            lblProfilNama.Location = new Point(7, 29);
            lblProfilNama.Name = "lblProfilNama";
            lblProfilNama.Size = new Size(158, 42);
            lblProfilNama.TabIndex = 0;
            lblProfilNama.Text = "Nama_Pengguna";
            lblProfilNama.TextAlign = ContentAlignment.TopRight;
            // 
            // btnHomepageLogout
            // 
            btnHomepageLogout.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnHomepageLogout.BackColor = Color.White;
            btnHomepageLogout.Cursor = Cursors.Hand;
            btnHomepageLogout.Font = new Font("Bahnschrift Light Condensed", 9F);
            btnHomepageLogout.ForeColor = Color.Black;
            btnHomepageLogout.Location = new Point(122, 127);
            btnHomepageLogout.Name = "btnHomepageLogout";
            btnHomepageLogout.Size = new Size(43, 30);
            btnHomepageLogout.TabIndex = 1;
            btnHomepageLogout.Text = "Logout";
            btnHomepageLogout.UseVisualStyleBackColor = false;
            btnHomepageLogout.Click += btnHomepageLogout_Click;
            // 
            // lblProfilUsername
            // 
            lblProfilUsername.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblProfilUsername.BackColor = Color.Transparent;
            lblProfilUsername.Font = new Font("Bahnschrift Light Condensed", 9F);
            lblProfilUsername.ForeColor = Color.White;
            lblProfilUsername.Location = new Point(7, 71);
            lblProfilUsername.Name = "lblProfilUsername";
            lblProfilUsername.Size = new Size(158, 23);
            lblProfilUsername.TabIndex = 4;
            lblProfilUsername.Text = "isi_username";
            lblProfilUsername.TextAlign = ContentAlignment.TopRight;
            // 
            // ProfilePopupUC
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(44, 62, 80);
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(lblProfilUsername);
            Controls.Add(lblProfilEmail);
            Controls.Add(lblProfilRole);
            Controls.Add(lblProfilNama);
            Controls.Add(btnUbahProfil);
            Controls.Add(btnHomepageLogout);
            Name = "ProfilePopupUC";
            Size = new Size(168, 160);
            ResumeLayout(false);
        }

        #endregion
        private Label lblProfilEmail;
        private Label lblProfilRole;
        private Button btnUbahProfil;
        private Label lblProfilNama;
        private Button btnHomepageLogout;
        private Label lblProfilUsername;
    }
}
