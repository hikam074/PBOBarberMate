namespace PBOBarberMate.Presentation.Views.Auth
{
    partial class UbahProfilUC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UbahProfilUC));
            lblEmail = new Label();
            lblNama = new Label();
            lblUsername = new Label();
            tbxNama = new TextBox();
            tbxEmail = new TextBox();
            tbxPassword = new TextBox();
            gbxProfil = new GroupBox();
            tbxUsername = new TextBox();
            lblPassword = new Label();
            pictbxAdd = new PictureBox();
            btnSimpan = new Button();
            pictbxAddHov = new PictureBox();
            pictbxBack = new PictureBox();
            btnCancel = new Button();
            gbxProfil.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictbxAdd).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictbxAddHov).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictbxBack).BeginInit();
            SuspendLayout();
            // 
            // lblEmail
            // 
            lblEmail.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblEmail.BackColor = Color.Transparent;
            lblEmail.Font = new Font("Bahnschrift Condensed", 11.25F);
            lblEmail.ForeColor = Color.White;
            lblEmail.Location = new Point(50, 106);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(100, 25);
            lblEmail.TabIndex = 5;
            lblEmail.Text = "Email";
            // 
            // lblNama
            // 
            lblNama.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblNama.Font = new Font("Bahnschrift Condensed", 11.25F);
            lblNama.ForeColor = Color.White;
            lblNama.Location = new Point(50, 50);
            lblNama.Name = "lblNama";
            lblNama.Size = new Size(100, 25);
            lblNama.TabIndex = 4;
            lblNama.Text = "Nama";
            // 
            // lblUsername
            // 
            lblUsername.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblUsername.BackColor = Color.Transparent;
            lblUsername.Font = new Font("Bahnschrift Condensed", 11.25F);
            lblUsername.ForeColor = Color.White;
            lblUsername.Location = new Point(50, 164);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(100, 25);
            lblUsername.TabIndex = 6;
            lblUsername.Text = "Username";
            // 
            // tbxNama
            // 
            tbxNama.Cursor = Cursors.IBeam;
            tbxNama.Location = new Point(147, 50);
            tbxNama.Name = "tbxNama";
            tbxNama.Size = new Size(344, 23);
            tbxNama.TabIndex = 10;
            // 
            // tbxEmail
            // 
            tbxEmail.Cursor = Cursors.IBeam;
            tbxEmail.Location = new Point(147, 106);
            tbxEmail.Name = "tbxEmail";
            tbxEmail.Size = new Size(344, 23);
            tbxEmail.TabIndex = 13;
            // 
            // tbxPassword
            // 
            tbxPassword.Cursor = Cursors.IBeam;
            tbxPassword.Location = new Point(147, 225);
            tbxPassword.Name = "tbxPassword";
            tbxPassword.Size = new Size(344, 23);
            tbxPassword.TabIndex = 16;
            // 
            // gbxProfil
            // 
            gbxProfil.Controls.Add(tbxUsername);
            gbxProfil.Controls.Add(lblPassword);
            gbxProfil.Controls.Add(lblNama);
            gbxProfil.Controls.Add(tbxPassword);
            gbxProfil.Controls.Add(lblEmail);
            gbxProfil.Controls.Add(tbxEmail);
            gbxProfil.Controls.Add(lblUsername);
            gbxProfil.Controls.Add(tbxNama);
            gbxProfil.Location = new Point(100, 100);
            gbxProfil.Name = "gbxProfil";
            gbxProfil.Size = new Size(544, 300);
            gbxProfil.TabIndex = 17;
            gbxProfil.TabStop = false;
            // 
            // tbxUsername
            // 
            tbxUsername.Cursor = Cursors.IBeam;
            tbxUsername.Location = new Point(147, 164);
            tbxUsername.Name = "tbxUsername";
            tbxUsername.Size = new Size(344, 23);
            tbxUsername.TabIndex = 18;
            // 
            // lblPassword
            // 
            lblPassword.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblPassword.BackColor = Color.Transparent;
            lblPassword.Font = new Font("Bahnschrift Condensed", 11.25F);
            lblPassword.ForeColor = Color.White;
            lblPassword.Location = new Point(50, 225);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(100, 25);
            lblPassword.TabIndex = 17;
            lblPassword.Text = "Password";
            // 
            // pictbxAdd
            // 
            pictbxAdd.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictbxAdd.BackColor = Color.WhiteSmoke;
            pictbxAdd.Image = (Image)resources.GetObject("pictbxAdd.Image");
            pictbxAdd.Location = new Point(561, 52);
            pictbxAdd.Name = "pictbxAdd";
            pictbxAdd.Size = new Size(15, 15);
            pictbxAdd.SizeMode = PictureBoxSizeMode.Zoom;
            pictbxAdd.TabIndex = 35;
            pictbxAdd.TabStop = false;
            // 
            // btnSimpan
            // 
            btnSimpan.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSimpan.AutoSize = true;
            btnSimpan.BackColor = SystemColors.Control;
            btnSimpan.Cursor = Cursors.Hand;
            btnSimpan.Font = new Font("Bahnschrift Condensed", 11.25F);
            btnSimpan.ForeColor = Color.Black;
            btnSimpan.Location = new Point(553, 40);
            btnSimpan.Name = "btnSimpan";
            btnSimpan.Size = new Size(91, 39);
            btnSimpan.TabIndex = 34;
            btnSimpan.Text = "      Simpan";
            btnSimpan.UseVisualStyleBackColor = false;
            btnSimpan.Click += btnSimpan_Click;
            // 
            // pictbxAddHov
            // 
            pictbxAddHov.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictbxAddHov.BackColor = Color.WhiteSmoke;
            pictbxAddHov.Image = (Image)resources.GetObject("pictbxAddHov.Image");
            pictbxAddHov.Location = new Point(561, 52);
            pictbxAddHov.Name = "pictbxAddHov";
            pictbxAddHov.Size = new Size(15, 15);
            pictbxAddHov.SizeMode = PictureBoxSizeMode.Zoom;
            pictbxAddHov.TabIndex = 36;
            pictbxAddHov.TabStop = false;
            // 
            // pictbxBack
            // 
            pictbxBack.BackColor = SystemColors.Control;
            pictbxBack.Image = (Image)resources.GetObject("pictbxBack.Image");
            pictbxBack.Location = new Point(107, 54);
            pictbxBack.Name = "pictbxBack";
            pictbxBack.Size = new Size(12, 12);
            pictbxBack.SizeMode = PictureBoxSizeMode.Zoom;
            pictbxBack.TabIndex = 38;
            pictbxBack.TabStop = false;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = SystemColors.Control;
            btnCancel.Cursor = Cursors.Hand;
            btnCancel.Font = new Font("Bahnschrift Condensed", 11.25F);
            btnCancel.ForeColor = Color.Black;
            btnCancel.Location = new Point(100, 40);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 39);
            btnCancel.TabIndex = 37;
            btnCancel.Text = "Batalkan";
            btnCancel.TextAlign = ContentAlignment.MiddleRight;
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // UbahProfilUC
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(44, 62, 80);
            Controls.Add(pictbxBack);
            Controls.Add(btnCancel);
            Controls.Add(pictbxAdd);
            Controls.Add(btnSimpan);
            Controls.Add(pictbxAddHov);
            Controls.Add(gbxProfil);
            Name = "UbahProfilUC";
            Size = new Size(744, 451);
            gbxProfil.ResumeLayout(false);
            gbxProfil.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictbxAdd).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictbxAddHov).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictbxBack).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        public Label lblEmail;
        public Label lblNama;
        private Label lblUsername;
        private TextBox tbxNama;
        private TextBox tbxEmail;
        private TextBox tbxPassword;
        private GroupBox gbxProfil;
        private Label lblPassword;
        private TextBox tbxUsername;
        private PictureBox pictbxAdd;
        private Button btnSimpan;
        private PictureBox pictbxAddHov;
        private PictureBox pictbxBack;
        private Button btnCancel;
    }
}