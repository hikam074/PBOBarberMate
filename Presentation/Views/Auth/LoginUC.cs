using System;
using System.Drawing;
using System.Windows.Forms;

namespace PBOBarberMate.Presentation.Views.Auth
{
    using PBOBarberMate.Presentation.Forms;
    using PBOBarberMate.App.Services;
    using PBOBarberMate.Core.Entities;

    public partial class LoginUC : UserControl
    {
        private readonly AkunService _akunService;


        public LoginUC(AkunService akunService)
        {
            InitializeComponent();
            _akunService = akunService;

            tbxLoginPass.PasswordChar = '*';
            UpdateSubmitButtonState();
        }

        private void btnLoginSubmit_Click(object sender, EventArgs e)
        {
            M_Akun akun = new M_Akun() { Username = tbxLoginEmail.Text, Password = tbxLoginPass.Text };
            var result = _akunService.Login(akun);

            if (result.IsSuccess)
            {
                var user = SessionService.CurrentUser;
                MessageBox.Show($"Selamat datang {user.Nama} ({user.NamaRole})");

                // Pindah ke Dashboard di MainApp
                if (this.ParentForm is MainApp main)
                {
                    main.UpdateUIByRole();
                }
            }
            else
            {
                MessageBox.Show(result.Message, "Login Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lklblLoginSignupRedirect_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // redirect ke signup
            if (this.ParentForm is MainApp main)
            {
                main.ShowRegister();
            }
        }

        private void btnLoginSubmit_MouseEnter(object sender, EventArgs e)
        {
            if (btnLoginSubmit.Enabled)
            {
                btnLoginSubmit.BackColor = Color.FromArgb(243, 156, 18);
                btnLoginSubmit.ForeColor = Color.FromArgb(44, 62, 80);
            }
        }
        private void btnLoginSubmit_MouseLeave(object sender, EventArgs e)
        {
            if (btnLoginSubmit.Enabled)
            {
                btnLoginSubmit.BackColor = Color.FromArgb(44, 62, 80);
                btnLoginSubmit.ForeColor = Color.White;
            }
        }
        private void UpdateSubmitButtonState()
        {
            btnLoginSubmit.Enabled = !(string.IsNullOrWhiteSpace(tbxLoginEmail.Text) || string.IsNullOrWhiteSpace(tbxLoginPass.Text));
        }
        private void tbxLoginEmail_TextChanged(object sender, EventArgs e)
        {
            UpdateSubmitButtonState();
        }
        private void tbxLoginPass_TextChanged(object sender, EventArgs e)
        {
            UpdateSubmitButtonState();
        }
    }
}
