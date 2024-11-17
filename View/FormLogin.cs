using System;
using System.Drawing.Text;
using Npgsql;

using PBOBarberMate.App.Context;
using PBOBarberMate.App.Core;
using PBOBarberMate.App.Model;
using PBOBarberMate.View;


namespace PBOBarberMate
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
            // membuat password yang diketikkan disensor
            tbxLoginPass.PasswordChar= '*';

            // nonaktifkan btnLoginSubmit bila yang diisi belum lengkap
            if (tbxLoginEmail.Text == "" || tbxLoginPass.Text == "")
            {
                btnLoginSubmit.Enabled = false;
            }
            // mengaktifkan btnLoginSubmit bila data tidak kosong
            else
            {
                btnLoginSubmit.Enabled = true;
            }
        }
        private void tbxLoginEmail_TextChanged(object sender, EventArgs e)
        {
            // nonaktifkan btnLoginSubmit bila yang diisi belum lengkap
            if (tbxLoginEmail.Text == "" || tbxLoginPass.Text == "")
            {
                btnLoginSubmit.Enabled = false;
            }
            // mengaktifkan btnLoginSubmit bila data tidak kosong
            else
            {
                btnLoginSubmit.Enabled = true;
            }
        }
        private void tbxLoginPass_TextChanged(object sender, EventArgs e)
        {

            // nonaktifkan btnLoginSubmit bila yang diisi belum lengkap
            if (tbxLoginEmail.Text == "" || tbxLoginPass.Text == "")
            {
                btnLoginSubmit.Enabled = false;
            }
            // mengaktifkan btnLoginSubmit bila data tidak kosong
            else
            {
                btnLoginSubmit.Enabled = true;
            }
        }
        private void btnLoginSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                // membuat class akun untuk digunakan pada pengecekan
                M_Akun akun = new M_Akun(tbxLoginEmail.Text, tbxLoginPass.Text);
                // apakah akun yang hendak dibuat itu sudah ada di DB
                if (CekAkun.cekAkunAda(akun) !=null)
                {
                    // apakah data yang dimasukkan cocok dengan data di DB
                    if (CekAkun.cekLogin(akun) == true)
                    {
                        // mengarahkan tampilan after-login ke masing-masing role
                        if (CekAkun.cekRole(akun) == 1)
                        {
                            // admin
                            M_Admin admin = new M_Admin(tbxLoginEmail.Text, tbxLoginPass.Text);
                            // melakukan login
                            AkunContext.login(admin);
                            // mengarahkan ke FormHomepageAdmin
                            FormHomepageAdmin formHomepageAdmin = new FormHomepageAdmin();
                            // menyimpan data login di form selanjutnya
                            formHomepageAdmin.akun = admin;
                            formHomepageAdmin.lblWelcome.Text = $"{admin.nama}";
                            formHomepageAdmin.Show();
                            this.Hide();
                        }
                        else if (CekAkun.cekRole(akun) == 2)
                        {
                            // karyawan
                            M_Karyawan karyawan = new M_Karyawan(tbxLoginEmail.Text, tbxLoginPass.Text);
                            // melakukan login
                            AkunContext.login(karyawan);
                            // mengarahkan ke FormHomepageKaryawan
                            FormHomepageKaryawan formHomepageKaryawan = new FormHomepageKaryawan();
                            // menyimpan data login di form selanjutnya
                            formHomepageKaryawan.akun = karyawan;
                            formHomepageKaryawan.lblWelcome.Text = $"{karyawan.nama}";

                            formHomepageKaryawan.Show();
                            this.Hide();
                        }
                        else if (CekAkun.cekRole(akun) == 3)
                        {
                            // customer
                            M_Customer customer = new M_Customer(tbxLoginEmail.Text, tbxLoginPass.Text);
                            // melakukan login
                            AkunContext.login(customer);
                            // mengarahkan ke FormHomepageCustomer
                            FormHomepageCustomer formHomepageCustomer = new FormHomepageCustomer();
                            // menyimpan data login di form selanjutnya
                            formHomepageCustomer.akun = customer;
                            formHomepageCustomer.lblWelcome.Text = $"{customer.nama}";

                            formHomepageCustomer.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Role anda tidak terdaftar! Silahkan hubungi administrator");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Email atau Password anda salah! Silahkan coba lagi");
                    }
                }
                else
                {
                    MessageBox.Show("Akun belum terdaftar! Silahkan Register");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Terjadi Kesalahan  : {ex.Message}");
            }
        }
        private void lklblLoginSignupRedirect_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // mengarahkan ke FormSignup
            FormSignup formSignup = new FormSignup();
            formSignup.Show();
            this.Hide();
        }

        private void btnLoginSubmit_MouseEnter(object sender, EventArgs e)
        {
            // animasi hovers hanya akan aktif ketika tombolnya aktif(dapat diklik)
            if (btnLoginSubmit.Enabled == true)
            {
                btnLoginSubmit.BackColor = Color.FromArgb(243, 156, 18);
                btnLoginSubmit.ForeColor = Color.FromArgb(44, 62, 80);
            }
        }

        private void btnLoginSubmit_MouseLeave(object sender, EventArgs e)
        {
            // animasi hovers hanya akan aktif ketika tombolnya aktif(dapat diklik)
            if (btnLoginSubmit.Enabled == true)
            {
                btnLoginSubmit.BackColor = Color.FromArgb(44, 62, 80);
                btnLoginSubmit.ForeColor = Color.White;
            }
        }
    }
}
