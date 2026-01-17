namespace PBOBarberMate.Presentation.Views.Auth
{
    partial class SignupUC
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
            lblLoginSignupRedirect = new Label();
            lklblLoginSignupRedirect = new LinkLabel();
            gbxSignup = new GroupBox();
            btnSignupSubmit = new Button();
            tbxSignupNama = new TextBox();
            lblSignupNama = new Label();
            tbxSignupEmail = new TextBox();
            lblLoginSubheading = new Label();
            lblSignupPass = new Label();
            lblSignupEmail = new Label();
            tbxSignupPass = new TextBox();
            lblSignupAppName = new Label();
            lblSginupWelcome = new Label();
            tbxSignupUsername = new TextBox();
            lblSignupUsername = new Label();
            gbxSignup.SuspendLayout();
            SuspendLayout();
            // 
            // lblLoginSignupRedirect
            // 
            lblLoginSignupRedirect.Anchor = AnchorStyles.Top;
            lblLoginSignupRedirect.AutoSize = true;
            lblLoginSignupRedirect.BackColor = Color.Transparent;
            lblLoginSignupRedirect.ForeColor = SystemColors.ControlDarkDark;
            lblLoginSignupRedirect.Location = new Point(135, 265);
            lblLoginSignupRedirect.Name = "lblLoginSignupRedirect";
            lblLoginSignupRedirect.Size = new Size(110, 15);
            lblLoginSignupRedirect.TabIndex = 13;
            lblLoginSignupRedirect.Text = "Sudah punya akun?";
            // 
            // lklblLoginSignupRedirect
            // 
            lklblLoginSignupRedirect.Anchor = AnchorStyles.Top;
            lklblLoginSignupRedirect.AutoSize = true;
            lklblLoginSignupRedirect.BackColor = Color.Transparent;
            lklblLoginSignupRedirect.Location = new Point(241, 265);
            lklblLoginSignupRedirect.Name = "lklblLoginSignupRedirect";
            lklblLoginSignupRedirect.Size = new Size(37, 15);
            lklblLoginSignupRedirect.TabIndex = 12;
            lklblLoginSignupRedirect.TabStop = true;
            lklblLoginSignupRedirect.Text = "Login";
            lklblLoginSignupRedirect.LinkClicked += lklblLoginSignupRedirect_LinkClicked;
            // 
            // gbxSignup
            // 
            gbxSignup.Anchor = AnchorStyles.None;
            gbxSignup.BackColor = Color.FromArgb(236, 240, 241);
            gbxSignup.Controls.Add(lblSignupUsername);
            gbxSignup.Controls.Add(tbxSignupUsername);
            gbxSignup.Controls.Add(lblLoginSignupRedirect);
            gbxSignup.Controls.Add(lklblLoginSignupRedirect);
            gbxSignup.Controls.Add(btnSignupSubmit);
            gbxSignup.Controls.Add(tbxSignupNama);
            gbxSignup.Controls.Add(lblSignupNama);
            gbxSignup.Controls.Add(tbxSignupEmail);
            gbxSignup.Controls.Add(lblLoginSubheading);
            gbxSignup.Controls.Add(lblSignupPass);
            gbxSignup.Controls.Add(lblSignupEmail);
            gbxSignup.Controls.Add(tbxSignupPass);
            gbxSignup.Location = new Point(464, 106);
            gbxSignup.Name = "gbxSignup";
            gbxSignup.Size = new Size(400, 300);
            gbxSignup.TabIndex = 11;
            gbxSignup.TabStop = false;
            // 
            // btnSignupSubmit
            // 
            btnSignupSubmit.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            btnSignupSubmit.BackColor = Color.FromArgb(44, 62, 80);
            btnSignupSubmit.CausesValidation = false;
            btnSignupSubmit.Enabled = false;
            btnSignupSubmit.Font = new Font("Bahnschrift Condensed", 12F);
            btnSignupSubmit.ForeColor = Color.White;
            btnSignupSubmit.Location = new Point(165, 215);
            btnSignupSubmit.Name = "btnSignupSubmit";
            btnSignupSubmit.Size = new Size(80, 40);
            btnSignupSubmit.TabIndex = 16;
            btnSignupSubmit.Text = "Buat Akun";
            btnSignupSubmit.UseVisualStyleBackColor = false;
            btnSignupSubmit.Click += btnSignupSubmit_Click;
            btnSignupSubmit.MouseEnter += btnSignupSubmit_MouseEnter;
            btnSignupSubmit.MouseLeave += btnSignupSubmit_MouseLeave;
            // 
            // tbxSignupNama
            // 
            tbxSignupNama.Anchor = AnchorStyles.Top;
            tbxSignupNama.Location = new Point(18, 102);
            tbxSignupNama.Name = "tbxSignupNama";
            tbxSignupNama.Size = new Size(365, 23);
            tbxSignupNama.TabIndex = 14;
            tbxSignupNama.TextChanged += tbxSignupNama_TextChanged;
            // 
            // lblSignupNama
            // 
            lblSignupNama.Anchor = AnchorStyles.Top;
            lblSignupNama.AutoSize = true;
            lblSignupNama.BackColor = Color.Transparent;
            lblSignupNama.Location = new Point(18, 87);
            lblSignupNama.Name = "lblSignupNama";
            lblSignupNama.Size = new Size(39, 15);
            lblSignupNama.TabIndex = 15;
            lblSignupNama.Text = "Nama";
            // 
            // tbxSignupEmail
            // 
            tbxSignupEmail.Anchor = AnchorStyles.Top;
            tbxSignupEmail.Location = new Point(18, 62);
            tbxSignupEmail.Name = "tbxSignupEmail";
            tbxSignupEmail.Size = new Size(365, 23);
            tbxSignupEmail.TabIndex = 1;
            tbxSignupEmail.TextChanged += tbxSignupEmail_TextChanged;
            // 
            // lblLoginSubheading
            // 
            lblLoginSubheading.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblLoginSubheading.AutoSize = true;
            lblLoginSubheading.BackColor = Color.Transparent;
            lblLoginSubheading.Font = new Font("Bahnschrift Condensed", 14.25F);
            lblLoginSubheading.Location = new Point(18, 15);
            lblLoginSubheading.Name = "lblLoginSubheading";
            lblLoginSubheading.Size = new Size(362, 23);
            lblLoginSubheading.TabIndex = 4;
            lblLoginSubheading.Text = "Silahkan lengkapi data dibawah untuk membuat akun!";
            // 
            // lblSignupPass
            // 
            lblSignupPass.Anchor = AnchorStyles.Top;
            lblSignupPass.AutoSize = true;
            lblSignupPass.BackColor = Color.Transparent;
            lblSignupPass.Location = new Point(18, 168);
            lblSignupPass.Name = "lblSignupPass";
            lblSignupPass.Size = new Size(57, 15);
            lblSignupPass.TabIndex = 5;
            lblSignupPass.Text = "Password";
            // 
            // lblSignupEmail
            // 
            lblSignupEmail.Anchor = AnchorStyles.Top;
            lblSignupEmail.AutoSize = true;
            lblSignupEmail.BackColor = Color.Transparent;
            lblSignupEmail.Location = new Point(18, 47);
            lblSignupEmail.Name = "lblSignupEmail";
            lblSignupEmail.Size = new Size(36, 15);
            lblSignupEmail.TabIndex = 3;
            lblSignupEmail.Text = "Email";
            // 
            // tbxSignupPass
            // 
            tbxSignupPass.Anchor = AnchorStyles.Top;
            tbxSignupPass.Location = new Point(18, 183);
            tbxSignupPass.Name = "tbxSignupPass";
            tbxSignupPass.Size = new Size(365, 23);
            tbxSignupPass.TabIndex = 2;
            tbxSignupPass.TextChanged += tbxSignupPass_TextChanged;
            // 
            // lblSignupAppName
            // 
            lblSignupAppName.Anchor = AnchorStyles.None;
            lblSignupAppName.BackColor = Color.Transparent;
            lblSignupAppName.Font = new Font("Bahnschrift Condensed", 42F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSignupAppName.ForeColor = Color.White;
            lblSignupAppName.Location = new Point(134, 241);
            lblSignupAppName.Name = "lblSignupAppName";
            lblSignupAppName.Size = new Size(286, 72);
            lblSignupAppName.TabIndex = 13;
            lblSignupAppName.Text = "BarberMate!";
            // 
            // lblSginupWelcome
            // 
            lblSginupWelcome.Anchor = AnchorStyles.None;
            lblSginupWelcome.BackColor = Color.Transparent;
            lblSginupWelcome.Font = new Font("Bahnschrift Light Condensed", 32.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSginupWelcome.ForeColor = Color.White;
            lblSginupWelcome.Location = new Point(134, 186);
            lblSginupWelcome.Name = "lblSginupWelcome";
            lblSginupWelcome.Size = new Size(286, 61);
            lblSginupWelcome.TabIndex = 12;
            lblSginupWelcome.Text = "Selamat datang di";
            // 
            // tbxSignupUsername
            // 
            tbxSignupUsername.Anchor = AnchorStyles.Top;
            tbxSignupUsername.Location = new Point(18, 143);
            tbxSignupUsername.Name = "tbxSignupUsername";
            tbxSignupUsername.Size = new Size(365, 23);
            tbxSignupUsername.TabIndex = 17;
            // 
            // lblSignupUsername
            // 
            lblSignupUsername.Anchor = AnchorStyles.Top;
            lblSignupUsername.AutoSize = true;
            lblSignupUsername.BackColor = Color.Transparent;
            lblSignupUsername.Location = new Point(18, 128);
            lblSignupUsername.Name = "lblSignupUsername";
            lblSignupUsername.Size = new Size(60, 15);
            lblSignupUsername.TabIndex = 18;
            lblSignupUsername.Text = "Username";
            // 
            // SignupUC
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(44, 62, 80);
            Controls.Add(lblSignupAppName);
            Controls.Add(lblSginupWelcome);
            Controls.Add(gbxSignup);
            Name = "SignupUC";
            Size = new Size(1008, 537);
            gbxSignup.ResumeLayout(false);
            gbxSignup.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label lblLoginSignupRedirect;
        private LinkLabel lklblLoginSignupRedirect;
        private GroupBox gbxSignup;
        private TextBox tbxSignupEmail;
        private Label lblLoginSubheading;
        private Label lblSignupPass;
        private Label lblSignupEmail;
        private TextBox tbxSignupPass;
        private TextBox tbxSignupNama;
        private Label lblSignupNama;
        private Button btnSignupSubmit;
        private Label lblSignupAppName;
        private Label lblSginupWelcome;
        private Label lblSignupUsername;
        private TextBox tbxSignupUsername;
    }
}