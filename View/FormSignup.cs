using Npgsql;
using System;
using System.Windows.Forms;
using PBOBarberMate.App.Model;
using PBOBarberMate.App.Core;
using PBOBarberMate.App.Context;

namespace PBOBarberMate
{
    public partial class FormSignup : Form
    {
        public FormSignup()
        {
            InitializeComponent();
            // nonaktifkan btnSignupSubmit bila yang diisi belum lengkap
            if (tbxSignupEmail.Text == "" || tbxSignupNama.Text == "" || tbxSignupPass.Text == "")
            {
                btnSignupSubmit.Enabled = false;
            }
            // mengaktifkan btnSignupSubmit bila data tidak kosong
            else
            {
                btnSignupSubmit.Enabled = true;
            }
        }

        private void lklblLoginSignupRedirect_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // mengarahkan ke FormLogin
            FormLogin formLogin = new FormLogin();
            formLogin.Show();
            this.Hide();
        }
        private void tbxSignupEmail_TextChanged(object sender, EventArgs e)
        {
            // nonaktifkan btnSignupSubmit bila yang diisi belum lengkap
            if (tbxSignupEmail.Text == "" || tbxSignupNama.Text == "" || tbxSignupPass.Text == "")
            {
                btnSignupSubmit.Enabled = false;
            }
            // mengaktifkan btnSignupSubmit bila data tidak kosong
            else
            {
                btnSignupSubmit.Enabled = true;
            }
        }
        private void tbxSignupNama_TextChanged(object sender, EventArgs e)
        {
            // nonaktifkan btnSignupSubmit bila yang diisi belum lengkap
            if (tbxSignupEmail.Text == "" || tbxSignupNama.Text == "" || tbxSignupPass.Text == "")
            {
                btnSignupSubmit.Enabled = false;
            }
            // mengaktifkan btnSignupSubmit bila data tidak kosong
            else
            {
                btnSignupSubmit.Enabled = true;
            }
        }
        private void tbxSignupPass_TextChanged(object sender, EventArgs e)
        {
            // nonaktifkan btnSignupSubmit bila yang diisi belum lengkap
            if (tbxSignupEmail.Text == "" || tbxSignupNama.Text == "" || tbxSignupPass.Text == "")
            {
                btnSignupSubmit.Enabled = false;
            }
            // mengaktifkan btnSignupSubmit bila data tidak kosong
            else
            {
                btnSignupSubmit.Enabled = true;
            }
        }

        private void btnSignupSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                // membuat class akun untuk digunakan pada pembuatan akun
                M_Customer akun = new M_Customer(tbxSignupEmail.Text, tbxSignupNama.Text, tbxSignupPass.Text);
                // menyimpan akun baru ke db
                bool berhasilDibuat = AkunContext.signup(akun);
                // ketika akun baru berhasil dibuat
                if (berhasilDibuat)
                {
                    MessageBox.Show("Registrasi berhasil! Silahkan login");
                    // beralih ke Form Login
                    FormLogin formLogin = new FormLogin();
                    formLogin.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Email sudah terdaftar! Silahkan login");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Terjadi Kesalahan : {ex.Message}");
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
    }
}
