using Npgsql;
using System;
using System.Windows.Forms;

namespace PBOBarberMate.Presentation.Views.Auth
{
    using Microsoft.VisualBasic.ApplicationServices;
    using PBOBarberMate.App.Services;
    using PBOBarberMate.Core.Entities;
    using PBOBarberMate.Presentation.Forms;

    public partial class SignupUC : UserControl
    {
        private readonly AkunService _akunService;

        public SignupUC(AkunService akunService)
        {
            InitializeComponent();
            _akunService = akunService;
            UpdateSubmitButtonState();
        }
        private void lklblLoginSignupRedirect_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // mengarahkan ke LoginUC
            if (this.ParentForm is MainApp main)
            {
                main.ShowLogin();
            }
        }
        private void btnSignupSubmit_Click(object sender, EventArgs e)
        {
            M_Akun akun = new M_Akun()
            {
                Nama = tbxSignupNama.Text,
                Username = tbxSignupUsername.Text,
                Email = tbxSignupEmail.Text,
                Password = tbxSignupPass.Text,
            };
            var result = _akunService.Register(akun);

            if (result.IsSuccess)
            {
                MessageBox.Show(result.Message, "Berhasil", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // mengarahkan ke LoginUC
                if (this.ParentForm is MainApp main)
                {
                    main.ShowLogin();
                }
            }
            else
            {
                MessageBox.Show(result.Message, "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnSignupSubmit_MouseEnter(object sender, EventArgs e)
        {
            // animasi hovers hanya akan aktif ketika tombolnya aktif(dapat diklik)
            if (btnSignupSubmit.Enabled == true)
            {
                btnSignupSubmit.BackColor = Color.FromArgb(243, 156, 18);
                btnSignupSubmit.ForeColor = Color.FromArgb(44, 62, 80);
            }
        }
        private void btnSignupSubmit_MouseLeave(object sender, EventArgs e)
        {
            // animasi hovers hanya akan aktif ketika tombolnya aktif(dapat diklik)
            if (btnSignupSubmit.Enabled == true)
            {
                btnSignupSubmit.BackColor = Color.FromArgb(44, 62, 80);
                btnSignupSubmit.ForeColor = Color.White;
            }
        }
        private void UpdateSubmitButtonState()
        {
            // nonaktifkan btnSignupSubmit bila yang diisi belum lengkap
            if (tbxSignupEmail.Text == "" || tbxSignupUsername.Text == "" || tbxSignupNama.Text == "" || tbxSignupPass.Text == "")
            {
                btnSignupSubmit.Enabled = false;
            }
            // mengaktifkan btnSignupSubmit bila data tidak kosong
            else
            {
                btnSignupSubmit.Enabled = true;
            }
        }
        private void tbxSignupUsername_TextChanged(object sender, EventArgs e)
        {
            UpdateSubmitButtonState();
        }
        private void tbxSignupEmail_TextChanged(object sender, EventArgs e)
        {
            UpdateSubmitButtonState();
        }
        private void tbxSignupNama_TextChanged(object sender, EventArgs e)
        {
            UpdateSubmitButtonState();
        }
        private void tbxSignupPass_TextChanged(object sender, EventArgs e)
        {
            UpdateSubmitButtonState();
        }
    }
}