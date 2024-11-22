using PBOBarberMate.App.Context;
using PBOBarberMate.App.Core;
using PBOBarberMate.App.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBOBarberMate.View
{

    public partial class FormUbahProfil : Form
    {
        public FormUbahProfil()
        {
            InitializeComponent();

        }

        private void formPicker()
        {
            if (UserSession.role == AkunRole.Admin)
            {
                FormHomepageAdmin formHomepageAdmin = new FormHomepageAdmin();
                formHomepageAdmin.Show();
                this.Hide();
            }
            else if (UserSession.role == AkunRole.Karyawan)
            {
                FormHomepageKaryawan formHomepageKaryawan = new FormHomepageKaryawan();
                formHomepageKaryawan.Show();
                this.Hide();
            }
            else if (UserSession.role == AkunRole.Customer)
            {
                FormHomepageCustomer formHomepageCustomer = new FormHomepageCustomer();
                formHomepageCustomer.Show();
                this.Hide();
            }
        }

        private void btnKembali_Click(object sender, EventArgs e)
        {
            formPicker();
        }

        private void btnUbahNamaPengguna_Click(object sender, EventArgs e)
        {
            btnBatalUbahNamaPengguna.Visible = true;
            btnSimpanUbahNamaPengguna.Visible = true;
            tbUbahNamaPengguna.Visible = true;
            btnUbahNamaPengguna.Visible = false;
        }

        private void btnBatalUbahNamaPengguna_Click(object sender, EventArgs e)
        {
            btnBatalUbahNamaPengguna.Visible = false;
            btnSimpanUbahNamaPengguna.Visible = false;
            tbUbahNamaPengguna.Visible = false;
            btnUbahNamaPengguna.Visible = true;
        }

        private void btnSimpanUbahNamaPengguna_Click(object sender, EventArgs e)
        {
            if (tbUbahNamaPengguna.Text != "")
            {
                M_Akun akun = new M_Akun(UserSession.email);
                bool namaDiubah = AkunContext.ubahProfil(akun, tbUbahNamaPengguna.Text, "ubahNama");
                if (namaDiubah = true)
                {
                    MessageBox.Show("Nama berhasil diubah!");
                    formPicker();
                }
            }
            else if (tbUbahNamaPengguna.Text == "")
            {
                MessageBox.Show("blm terisi");
            }
        }
        private void btnSimpanUbahEmail_Click(object sender, EventArgs e)
        {
            if (tbUbahEmail.Text != "")
            {
                M_Akun akun = new M_Akun(UserSession.email);
                bool emailDiubah = AkunContext.ubahProfil(akun, tbUbahEmail.Text, "ubahEmail");
                if (emailDiubah = true)
                {
                    MessageBox.Show("Email berhasil diubah!");
                    formPicker();
                }
            }
            else if (tbUbahNamaPengguna.Text == "")
            {
                MessageBox.Show("blm terisi");
            }
        }

        private void btnSimpanUbahPassword_Click(object sender, EventArgs e)
        {
            if (tbUbahPassword.Text != "")
            {
                M_Akun akun = new M_Akun(UserSession.email);
                bool passDiubah = AkunContext.ubahProfil(akun, HashingUtility.hashPassword(tbUbahPassword.Text), "ubahPassword");
                if (passDiubah = true)
                {
                    MessageBox.Show("Password berhasil diubah!");
                    formPicker();
                }
            }
            else if (tbUbahNamaPengguna.Text == "")
            {
                MessageBox.Show("blm terisi");
            }
        }

        private void btnUbahEmail_Click(object sender, EventArgs e)
        {
            btnBatalUbahEmail.Visible = true;
            btnSimpanUbahEmail.Visible = true;
            tbUbahEmail.Visible = true;
            btnUbahEmail.Visible = false;
        }

        private void btnUbahPassword_Click(object sender, EventArgs e)
        {
            btnUbahPassword.Visible = false;
            btnSimpanUbahPassword.Visible = true;
            btnBatalUbahPassword.Visible = true;
            tbUbahPassword.Visible = true;
        }

        private void btnBatalUbahEmail_Click(object sender, EventArgs e)
        {
            btnBatalUbahEmail.Visible = false;
            btnSimpanUbahEmail.Visible = false;
            btnUbahEmail.Visible = true;
            tbUbahEmail.Visible = false;
        }

        private void btnBatalUbahPassword_Click(object sender, EventArgs e)
        {
            btnBatalUbahPassword.Visible = false;
            btnSimpanUbahPassword.Visible = false;
            tbUbahPassword.Visible = false;
            btnUbahPassword.Visible = true;
        }
    }
}