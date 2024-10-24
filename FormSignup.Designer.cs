namespace CobaWinForm
{
    partial class FormSignup
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
            gbxLogin = new GroupBox();
            btnSignupSubmit = new Button();
            tbxSignupNama = new TextBox();
            lblSignupNama = new Label();
            tbxSignupEmail = new TextBox();
            lblLoginSubheading = new Label();
            lblSignupPass = new Label();
            lblSignupEmail = new Label();
            tbxSignupPass = new TextBox();
            lblSignupWelcome = new Label();
            gbxLogin.SuspendLayout();
            SuspendLayout();
            // 
            // lblLoginSignupRedirect
            // 
            lblLoginSignupRedirect.Anchor = AnchorStyles.Top;
            lblLoginSignupRedirect.AutoSize = true;
            lblLoginSignupRedirect.Location = new Point(134, 262);
            lblLoginSignupRedirect.Name = "lblLoginSignupRedirect";
            lblLoginSignupRedirect.Size = new Size(110, 15);
            lblLoginSignupRedirect.TabIndex = 13;
            lblLoginSignupRedirect.Text = "Sudah punya akun?";
            // 
            // lklblLoginSignupRedirect
            // 
            lklblLoginSignupRedirect.Anchor = AnchorStyles.Top;
            lklblLoginSignupRedirect.AutoSize = true;
            lklblLoginSignupRedirect.Location = new Point(241, 262);
            lklblLoginSignupRedirect.Name = "lklblLoginSignupRedirect";
            lklblLoginSignupRedirect.Size = new Size(37, 15);
            lklblLoginSignupRedirect.TabIndex = 12;
            lklblLoginSignupRedirect.TabStop = true;
            lklblLoginSignupRedirect.Text = "Login";
            lklblLoginSignupRedirect.LinkClicked += lklblLoginSignupRedirect_LinkClicked;
            // 
            // gbxLogin
            // 
            gbxLogin.Anchor = AnchorStyles.Top;
            gbxLogin.Controls.Add(lblLoginSignupRedirect);
            gbxLogin.Controls.Add(lklblLoginSignupRedirect);
            gbxLogin.Controls.Add(btnSignupSubmit);
            gbxLogin.Controls.Add(tbxSignupNama);
            gbxLogin.Controls.Add(lblSignupNama);
            gbxLogin.Controls.Add(tbxSignupEmail);
            gbxLogin.Controls.Add(lblLoginSubheading);
            gbxLogin.Controls.Add(lblSignupPass);
            gbxLogin.Controls.Add(lblSignupEmail);
            gbxLogin.Controls.Add(tbxSignupPass);
            gbxLogin.Location = new Point(208, 108);
            gbxLogin.Name = "gbxLogin";
            gbxLogin.Size = new Size(400, 297);
            gbxLogin.TabIndex = 11;
            gbxLogin.TabStop = false;
            // 
            // btnSignupSubmit
            // 
            btnSignupSubmit.Anchor = AnchorStyles.Top;
            btnSignupSubmit.Location = new Point(169, 213);
            btnSignupSubmit.Name = "btnSignupSubmit";
            btnSignupSubmit.Size = new Size(75, 37);
            btnSignupSubmit.TabIndex = 16;
            btnSignupSubmit.Text = "Buat Akun";
            btnSignupSubmit.UseVisualStyleBackColor = true;
            btnSignupSubmit.Click += btnSignupSubmit_Click;
            // 
            // tbxSignupNama
            // 
            tbxSignupNama.Anchor = AnchorStyles.Top;
            tbxSignupNama.Location = new Point(18, 126);
            tbxSignupNama.Name = "tbxSignupNama";
            tbxSignupNama.Size = new Size(365, 23);
            tbxSignupNama.TabIndex = 14;
            tbxSignupNama.TextChanged += tbxSignupNama_TextChanged;
            // 
            // lblSignupNama
            // 
            lblSignupNama.Anchor = AnchorStyles.Top;
            lblSignupNama.AutoSize = true;
            lblSignupNama.Location = new Point(18, 108);
            lblSignupNama.Name = "lblSignupNama";
            lblSignupNama.Size = new Size(39, 15);
            lblSignupNama.TabIndex = 15;
            lblSignupNama.Text = "Nama";
            // 
            // tbxSignupEmail
            // 
            tbxSignupEmail.Anchor = AnchorStyles.Top;
            tbxSignupEmail.Location = new Point(18, 76);
            tbxSignupEmail.Name = "tbxSignupEmail";
            tbxSignupEmail.Size = new Size(365, 23);
            tbxSignupEmail.TabIndex = 1;
            tbxSignupEmail.TextChanged += tbxSignupEmail_TextChanged;
            // 
            // lblLoginSubheading
            // 
            lblLoginSubheading.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblLoginSubheading.AutoSize = true;
            lblLoginSubheading.Location = new Point(59, 19);
            lblLoginSubheading.Name = "lblLoginSubheading";
            lblLoginSubheading.Size = new Size(294, 15);
            lblLoginSubheading.TabIndex = 4;
            lblLoginSubheading.Text = "Silahkan lengkapi data dibawah untuk membuat akun!";
            // 
            // lblSignupPass
            // 
            lblSignupPass.Anchor = AnchorStyles.Top;
            lblSignupPass.AutoSize = true;
            lblSignupPass.Location = new Point(18, 156);
            lblSignupPass.Name = "lblSignupPass";
            lblSignupPass.Size = new Size(57, 15);
            lblSignupPass.TabIndex = 5;
            lblSignupPass.Text = "Password";
            // 
            // lblSignupEmail
            // 
            lblSignupEmail.Anchor = AnchorStyles.Top;
            lblSignupEmail.AutoSize = true;
            lblSignupEmail.Location = new Point(18, 58);
            lblSignupEmail.Name = "lblSignupEmail";
            lblSignupEmail.Size = new Size(36, 15);
            lblSignupEmail.TabIndex = 3;
            lblSignupEmail.Text = "Email";
            // 
            // tbxSignupPass
            // 
            tbxSignupPass.Anchor = AnchorStyles.Top;
            tbxSignupPass.Location = new Point(18, 174);
            tbxSignupPass.Name = "tbxSignupPass";
            tbxSignupPass.Size = new Size(365, 23);
            tbxSignupPass.TabIndex = 2;
            tbxSignupPass.TextChanged += tbxSignupPass_TextChanged;
            // 
            // lblSignupWelcome
            // 
            lblSignupWelcome.Anchor = AnchorStyles.Top;
            lblSignupWelcome.AutoSize = true;
            lblSignupWelcome.Font = new Font("Gill Sans MT", 32.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSignupWelcome.Location = new Point(152, 31);
            lblSignupWelcome.Name = "lblSignupWelcome";
            lblSignupWelcome.Size = new Size(506, 60);
            lblSignupWelcome.TabIndex = 10;
            lblSignupWelcome.Text = "Welcome To HeyBrew!";
            // 
            // FormSignup
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(gbxLogin);
            Controls.Add(lblSignupWelcome);
            Name = "FormSignup";
            Text = "FormSignup";
            gbxLogin.ResumeLayout(false);
            gbxLogin.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblLoginSignupRedirect;
        private LinkLabel lklblLoginSignupRedirect;
        private GroupBox gbxLogin;
        private TextBox tbxSignupEmail;
        private Label lblLoginSubheading;
        private Label lblSignupPass;
        private Label lblSignupEmail;
        private TextBox tbxSignupPass;
        private Label lblSignupWelcome;
        private TextBox tbxSignupNama;
        private Label lblSignupNama;
        private Button btnSignupSubmit;
    }
}