namespace PBOBarberMate
{
    partial class FormLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblLoginWelcome = new Label();
            tbxLoginEmail = new TextBox();
            tbxLoginPass = new TextBox();
            lblLoginHeadingEmail = new Label();
            lblLoginSubheading = new Label();
            lblLoginHeadingPass = new Label();
            gbxLogin = new GroupBox();
            lblLoginSignupRedirect = new Label();
            btnLoginSubmit = new Button();
            lklblLoginSignupRedirect = new LinkLabel();
            lblLoginAppName = new Label();
            gbxLogin.SuspendLayout();
            SuspendLayout();
            // 
            // lblLoginWelcome
            // 
            lblLoginWelcome.Anchor = AnchorStyles.Top;
            lblLoginWelcome.BackColor = Color.Transparent;
            lblLoginWelcome.Font = new Font("Bahnschrift Light Condensed", 32.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblLoginWelcome.ForeColor = Color.White;
            lblLoginWelcome.Location = new Point(24, 159);
            lblLoginWelcome.Name = "lblLoginWelcome";
            lblLoginWelcome.Size = new Size(286, 61);
            lblLoginWelcome.TabIndex = 0;
            lblLoginWelcome.Text = "Selamat datang di";
            // 
            // tbxLoginEmail
            // 
            tbxLoginEmail.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tbxLoginEmail.Location = new Point(18, 110);
            tbxLoginEmail.Name = "tbxLoginEmail";
            tbxLoginEmail.Size = new Size(365, 23);
            tbxLoginEmail.TabIndex = 1;
            tbxLoginEmail.TextChanged += tbxLoginEmail_TextChanged;
            // 
            // tbxLoginPass
            // 
            tbxLoginPass.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tbxLoginPass.Location = new Point(18, 171);
            tbxLoginPass.Name = "tbxLoginPass";
            tbxLoginPass.Size = new Size(365, 23);
            tbxLoginPass.TabIndex = 2;
            tbxLoginPass.TextChanged += tbxLoginPass_TextChanged;
            // 
            // lblLoginHeadingEmail
            // 
            lblLoginHeadingEmail.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblLoginHeadingEmail.AutoSize = true;
            lblLoginHeadingEmail.Location = new Point(18, 84);
            lblLoginHeadingEmail.Name = "lblLoginHeadingEmail";
            lblLoginHeadingEmail.Size = new Size(36, 15);
            lblLoginHeadingEmail.TabIndex = 3;
            lblLoginHeadingEmail.Text = "Email";
            // 
            // lblLoginSubheading
            // 
            lblLoginSubheading.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblLoginSubheading.AutoSize = true;
            lblLoginSubheading.Font = new Font("Bahnschrift Condensed", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblLoginSubheading.Location = new Point(75, 34);
            lblLoginSubheading.Name = "lblLoginSubheading";
            lblLoginSubheading.Size = new Size(275, 23);
            lblLoginSubheading.TabIndex = 4;
            lblLoginSubheading.Text = "Gunakan email dan password untuk login";
            // 
            // lblLoginHeadingPass
            // 
            lblLoginHeadingPass.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblLoginHeadingPass.AutoSize = true;
            lblLoginHeadingPass.Location = new Point(18, 145);
            lblLoginHeadingPass.Name = "lblLoginHeadingPass";
            lblLoginHeadingPass.Size = new Size(57, 15);
            lblLoginHeadingPass.TabIndex = 5;
            lblLoginHeadingPass.Text = "Password";
            // 
            // gbxLogin
            // 
            gbxLogin.Anchor = AnchorStyles.Top;
            gbxLogin.BackColor = Color.FromArgb(236, 240, 241);
            gbxLogin.Controls.Add(lblLoginSignupRedirect);
            gbxLogin.Controls.Add(btnLoginSubmit);
            gbxLogin.Controls.Add(lklblLoginSignupRedirect);
            gbxLogin.Controls.Add(tbxLoginEmail);
            gbxLogin.Controls.Add(lblLoginSubheading);
            gbxLogin.Controls.Add(lblLoginHeadingPass);
            gbxLogin.Controls.Add(lblLoginHeadingEmail);
            gbxLogin.Controls.Add(tbxLoginPass);
            gbxLogin.Location = new Point(365, 54);
            gbxLogin.Name = "gbxLogin";
            gbxLogin.Size = new Size(400, 314);
            gbxLogin.TabIndex = 7;
            gbxLogin.TabStop = false;
            // 
            // lblLoginSignupRedirect
            // 
            lblLoginSignupRedirect.Anchor = AnchorStyles.Top;
            lblLoginSignupRedirect.AutoSize = true;
            lblLoginSignupRedirect.ForeColor = SystemColors.ControlDarkDark;
            lblLoginSignupRedirect.Location = new Point(103, 282);
            lblLoginSignupRedirect.Name = "lblLoginSignupRedirect";
            lblLoginSignupRedirect.Size = new Size(111, 15);
            lblLoginSignupRedirect.TabIndex = 9;
            lblLoginSignupRedirect.Text = "Belum punya akun?";
            // 
            // btnLoginSubmit
            // 
            btnLoginSubmit.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnLoginSubmit.BackColor = Color.FromArgb(44, 62, 80);
            btnLoginSubmit.Font = new Font("Bahnschrift Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLoginSubmit.ForeColor = Color.White;
            btnLoginSubmit.Location = new Point(164, 226);
            btnLoginSubmit.Name = "btnLoginSubmit";
            btnLoginSubmit.Size = new Size(75, 37);
            btnLoginSubmit.TabIndex = 17;
            btnLoginSubmit.Text = "Masuk";
            btnLoginSubmit.UseVisualStyleBackColor = false;
            btnLoginSubmit.Click += btnLoginSubmit_Click;
            btnLoginSubmit.MouseEnter += btnLoginSubmit_MouseEnter;
            btnLoginSubmit.MouseLeave += btnLoginSubmit_MouseLeave;
            // 
            // lklblLoginSignupRedirect
            // 
            lklblLoginSignupRedirect.Anchor = AnchorStyles.Top;
            lklblLoginSignupRedirect.AutoSize = true;
            lklblLoginSignupRedirect.ForeColor = SystemColors.ControlDarkDark;
            lklblLoginSignupRedirect.Location = new Point(210, 282);
            lklblLoginSignupRedirect.Name = "lklblLoginSignupRedirect";
            lklblLoginSignupRedirect.Size = new Size(93, 15);
            lklblLoginSignupRedirect.TabIndex = 8;
            lklblLoginSignupRedirect.TabStop = true;
            lklblLoginSignupRedirect.Text = "Daftar Sekarang!";
            lklblLoginSignupRedirect.LinkClicked += lklblLoginSignupRedirect_LinkClicked;
            // 
            // lblLoginAppName
            // 
            lblLoginAppName.Anchor = AnchorStyles.Top;
            lblLoginAppName.BackColor = Color.Transparent;
            lblLoginAppName.Font = new Font("Bahnschrift Condensed", 42F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLoginAppName.ForeColor = Color.White;
            lblLoginAppName.Location = new Point(24, 214);
            lblLoginAppName.Name = "lblLoginAppName";
            lblLoginAppName.Size = new Size(286, 72);
            lblLoginAppName.TabIndex = 8;
            lblLoginAppName.Text = "BarberMate!";
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(44, 62, 80);
            ClientSize = new Size(800, 450);
            Controls.Add(lblLoginAppName);
            Controls.Add(gbxLogin);
            Controls.Add(lblLoginWelcome);
            Name = "FormLogin";
            Text = "BarberMate : Login";
            gbxLogin.ResumeLayout(false);
            gbxLogin.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label lblLoginWelcome;
        private TextBox tbxLoginEmail;
        private TextBox tbxLoginPass;
        private Label lblLoginHeadingEmail;
        private Label lblLoginSubheading;
        private Label lblLoginHeadingPass;
        private GroupBox gbxLogin;
        private LinkLabel lklblLoginSignupRedirect;
        private Label lblLoginSignupRedirect;
        private Button btnLoginSubmit;
        private Label lblLoginAppName;
    }
}
