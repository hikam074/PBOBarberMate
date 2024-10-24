using System;
using Npgsql;
using CobaWinForm.Classes;
using System.Drawing.Text;

namespace CobaWinForm
{
    public partial class FormLogin : Form
    {
        // deklar akunService agar bisa digunakan tidak hanya di FormLogin()
        private AkunService akunService;

        public FormLogin()
        {
            InitializeComponent();
            string connectionString = "Host=localhost;Port=5432;Username=postgres;Password=dammahom51;Database=HeyBrew";
            DBService dBService = new DBService(connectionString);
            akunService = new AkunService(dBService);

            if (tbxLoginEmail.Text == "" || tbxLoginPass.Text == "")
            {
                btnLoginSubmit.Enabled = false;
            }
            else
            {
                btnLoginSubmit.Enabled = true;
            }
        }
        private void tbxLoginEmail_TextChanged(object sender, EventArgs e)
        {
            if (tbxLoginEmail.Text == "" || tbxLoginPass.Text == "")
            {
                btnLoginSubmit.Enabled = false;
            }
            else
            {
                btnLoginSubmit.Enabled = true;
            }
        }
        private void tbxLoginPass_TextChanged(object sender, EventArgs e)
        {
            if (tbxLoginEmail.Text == "" || tbxLoginPass.Text == "")
            {
                btnLoginSubmit.Enabled = false;
            }
            else
            {
                btnLoginSubmit.Enabled = true;
            }
        }
        private void btnLoginSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                Akun akun = new Akun(tbxLoginEmail.Text, tbxLoginPass.Text);
                if (akunService.loginAkun(akun, out string nama))
                {
                    // berhasil login
                    FormHomepage formHomepage = new FormHomepage();
                    formHomepage.lblWelcome.Text = $"Selamat Datang, {akun.nama}";
                    formHomepage.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Email atau password anda salah! Silahkan coba lagi");
                    tbxLoginEmail.Clear();
                    tbxLoginPass.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Terjadi Kesalahan  : {ex.Message}");
            }
        }
        private void lklblLoginSignupRedirect_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormSignup formSignup = new FormSignup();
            formSignup.Show();

            this.Hide();
        }

        private void btnLoginSubmit_MouseEnter(object sender, EventArgs e)
        {
            if (btnLoginSubmit.Enabled == true)
            {
                btnLoginSubmit.BackColor = Color.FromArgb(243, 156, 18);
                btnLoginSubmit.ForeColor = Color.FromArgb(44, 62, 80);
            }
        }

        private void btnLoginSubmit_MouseLeave(object sender, EventArgs e)
        {
            if (btnLoginSubmit.Enabled == true)
            {
                btnLoginSubmit.BackColor = Color.FromArgb(44, 62, 80);
                btnLoginSubmit.ForeColor = Color.White;
            }
        }
    }
}
