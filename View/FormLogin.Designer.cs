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
            lblLoginWelcome.Location = new Point(30, 155);
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
            tbxLoginPass.Location = new Point(18, 174);
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
            lblLoginSubheading.Font = new Font("Bahnschrift Condensed", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblLoginSubheading.Location = new Point(18, 34);
            lblLoginSubheading.Name = "lblLoginSubheading";
            lblLoginSubheading.Size = new Size(365, 23);
            lblLoginSubheading.TabIndex = 4;
            lblLoginSubheading.Text = "Gunakan email dan password untuk login";
            lblLoginSubheading.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblLoginHeadingPass
            // 
            lblLoginHeadingPass.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblLoginHeadingPass.AutoSize = true;
            lblLoginHeadingPass.Location = new Point(18, 150);
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
            gbxLogin.Location = new Point(360, 75);
            gbxLogin.Name = "gbxLogin";
            gbxLogin.Size = new Size(400, 300);
            gbxLogin.TabIndex = 7;
            gbxLogin.TabStop = false;
            // 
            // lblLoginSignupRedirect
            // 
            lblLoginSignupRedirect.Anchor = AnchorStyles.Top;
            lblLoginSignupRedirect.AutoSize = true;
            lblLoginSignupRedirect.ForeColor = SystemColors.ControlDarkDark;
            lblLoginSignupRedirect.Location = new Point(59, 265);
            lblLoginSignupRedirect.Name = "lblLoginSignupRedirect";
            lblLoginSignupRedirect.Size = new Size(197, 15);
            lblLoginSignupRedirect.TabIndex = 9;
            lblLoginSignupRedirect.Text = "Bukan admin && belum punya akun?";
            // 
            // btnLoginSubmit
            // 
            btnLoginSubmit.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnLoginSubmit.BackColor = Color.FromArgb(44, 62, 80);
            btnLoginSubmit.Font = new Font("Bahnschrift Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLoginSubmit.ForeColor = Color.White;
            btnLoginSubmit.Location = new Point(165, 215);
            btnLoginSubmit.Name = "btnLoginSubmit";
            btnLoginSubmit.Size = new Size(80, 40);
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
            lklblLoginSignupRedirect.Location = new Point(253, 265);
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
            lblLoginAppName.Location = new Point(30, 210);
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
            StartPosition = FormStartPosition.CenterScreen;
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
