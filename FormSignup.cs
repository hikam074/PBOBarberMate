using Npgsql;
using System;
using System.Windows.Forms;
using CobaWinForm.Classes;

namespace CobaWinForm
{
    public partial class FormSignup : Form
    {
        private AkunService akunService;

        public FormSignup()
        {
            InitializeComponent();
            string connectionString = "Host=localhost;Port=5432;Username=postgres;Password=dammahom51;Database=HeyBrew";
            DBService dBService = new DBService(connectionString);
            akunService = new AkunService(dBService);

            if (tbxSignupEmail.Text == "" || tbxSignupNama.Text == "" || tbxSignupPass.Text == "")
            {
                btnSignupSubmit.Enabled = false;
            }
            else
            {
                btnSignupSubmit.Enabled = true;
            }
        }

        private void lklblLoginSignupRedirect_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormLogin formLogin = new FormLogin();
            formLogin.Show();

            this.Hide();
        }
        private void tbxSignupEmail_TextChanged(object sender, EventArgs e)
        {
            if (tbxSignupEmail.Text == "" || tbxSignupNama.Text == "" || tbxSignupPass.Text == "")
            {
                btnSignupSubmit.Enabled = false;
            }
            else
            {
                btnSignupSubmit.Enabled = true;
            }
        }
        private void tbxSignupNama_TextChanged(object sender, EventArgs e)
        {
            if (tbxSignupEmail.Text == "" || tbxSignupNama.Text == "" || tbxSignupPass.Text == "")
            {
                btnSignupSubmit.Enabled = false;
            }
            else
            {
                btnSignupSubmit.Enabled = true;
            }
        }
        private void tbxSignupPass_TextChanged(object sender, EventArgs e)
        {
            if (tbxSignupEmail.Text == "" || tbxSignupNama.Text == "" || tbxSignupPass.Text == "")
            {
                btnSignupSubmit.Enabled = false;
            }
            else
            {
                btnSignupSubmit.Enabled = true;
            }
        }

        private void btnSignupSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                // membuat akun
                Akun akun = new Akun(tbxSignupEmail.Text, tbxSignupNama.Text, tbxSignupPass.Text);

                // menyimpan akun baru ke db
                bool berhasilDibuat = akunService.signupAkun(akun);

                if (berhasilDibuat)
                {
                    MessageBox.Show("Registrasi berhasil! Silahkan login");
                    tbxSignupEmail.Clear();
                    tbxSignupNama.Clear();
                    tbxSignupPass.Clear();

                    // beralih ke Form Login
                    FormLogin formLogin = new FormLogin();
                    formLogin.Show();
                    this.Hide();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Terjadi Kesalahan : {ex.Message}");
            }

        }

        private void btnSignupSubmit_MouseEnter(object sender, EventArgs e)
        {
            if (btnSignupSubmit.Enabled == true)
            {
                btnSignupSubmit.BackColor = Color.FromArgb(243, 156, 18);
                btnSignupSubmit.ForeColor = Color.FromArgb(44, 62, 80);
            }
        }

        private void btnSignupSubmit_MouseLeave(object sender, EventArgs e)
        {
            if (btnSignupSubmit.Enabled == true)
            {
                btnSignupSubmit.BackColor = Color.FromArgb(44, 62, 80);
                btnSignupSubmit.ForeColor = Color.White;
            }
        }
    }
}
