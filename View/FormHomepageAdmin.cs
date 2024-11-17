using System;
using System.Windows.Forms;
using Npgsql;

using PBOBarberMate.App.Context;
using PBOBarberMate.App.Core;
using PBOBarberMate.App.Model;
using PBOBarberMate.View;

namespace PBOBarberMate.View
{
    public partial class FormHomepageAdmin : Form
    {
        // atribut menampung akun
        public M_Admin akun;
        // atribut menampung apakah animasi hovers aktif atau tidak
        private bool hoversActivated = true;


        public FormHomepageAdmin()
        {
            InitializeComponent();
            // menangkap tiap klik event di form
            this.Click += new EventHandler(FormHomepageAdmin_Click);
        }
        private void FormHomepageAdmin_Click(object sender, EventArgs e)
        {
            Point cursorPosition = this.PointToClient(Cursor.Position);
            // ketika klik event tidak berada di gbxShowProfile
            if (!gbxShowProfile.Bounds.Contains(cursorPosition))
            {
                // maka gbxShowProfile dihilangkan
                gbxShowProfile.Visible = false;
                // lalu mengembalikan warna btnProfil ke default
                btnProfil.BackColor = Color.FromArgb(44, 62, 80);
                btnProfil.ForeColor = Color.White;
                // mengaktifkan kembali animasi hovers
                hoversActivated = true;
            }
        }
        private void btnProfil_MouseEnter(object sender, EventArgs e)
        {
            // ketika animasi hovers dinonaktifkan, maka warna tidak diubah
            if (hoversActivated == false) { return; }
            // mengubah warna ketika kursor berada di btnProfil
            btnProfil.BackColor = Color.FromArgb(243, 156, 18);
            btnProfil.ForeColor = Color.FromArgb(44, 62, 80);
        }
        private void btnProfil_MouseLeave(object sender, EventArgs e)
        {
            // ketika animasi hovers dinonaktifkan, maka warna tidak diubah
            if (hoversActivated == false) { return; }
            // mengubah warna ketika kursor keluar dari area btnProfil
            btnProfil.BackColor = Color.FromArgb(44, 62, 80);
            btnProfil.ForeColor = Color.White;
        }
        private void btnProfil_Click(object sender, EventArgs e)
        {
            // kalau box profil belum muncul
            if (gbxShowProfile.Visible == false)
            {
                // memunculkan profil
                gbxShowProfile.Visible = true;
                // memunculkan isi profil
                lblProfilRole.Text = akun.role.ToString();
                lblProfilNama.Text = lblWelcome.Text;
                lblProfilEmail.Text = akun.email;
                // mengubah warna btnProfil
                btnProfil.BackColor = Color.White;
                btnProfil.ForeColor = Color.FromArgb(44, 62, 80);
                // membuat hover dinonaktifkan
                hoversActivated = false;
            }
            else // kalau box profil sudah muncul maka jadi tombol close
            {
                // gbxShowProfile dihilangkan
                gbxShowProfile.Visible = false;
                // lalu mengembalikan warna btnProfil ke default
                btnProfil.BackColor = Color.FromArgb(44, 62, 80);
                btnProfil.ForeColor = Color.White;
                // mengaktifkan kembali animasi hovers
                hoversActivated = true;
            }
        }
        private void btnUbahProfil_Click(object sender, EventArgs e)
        {
            // beralih ke FormUbahProfil
            FormUbahProfil formUbahProfil = new FormUbahProfil();
            // ShowDialog digunakan bila form sebelumnya tidak bisa dilakukan interaksi hingga form baru ini ditutup
            formUbahProfil.ShowDialog();
            // menyembunyikan gbxShowProfile
            gbxShowProfile.Visible = false;
            // mengembalikan warna btnProfil ke default
            btnProfil.BackColor = Color.FromArgb(44, 62, 80);
            btnProfil.ForeColor = Color.White;
            // mengaktifkan kembali animasi hovers
            hoversActivated = true;
        }
        private void btnHomepageLogout_Click(object sender, EventArgs e)
        {
            // kembali ke FormLogin
            FormLogin formLogin = new FormLogin();
            formLogin.Show();

            this.Hide();
        }
        private void btnUbahProfil_MouseEnter(object sender, EventArgs e)
        {
            // mengubah warna ketika kursor berada di btnUbahProfil
            btnUbahProfil.BackColor = Color.FromArgb(243, 156, 18);
            btnUbahProfil.ForeColor = Color.FromArgb(44, 62, 80);
        }
        private void btnUbahProfil_MouseLeave(object sender, EventArgs e)
        {
            // mengubah warna ketika kursor keluar dari area btnUbahProfil
            btnUbahProfil.BackColor = SystemColors.Control;
            btnUbahProfil.ForeColor = Color.FromArgb(44, 62, 80);
        }
        private void btnHomepageLogout_MouseEnter(object sender, EventArgs e)
        {
            // mengubah warna ketika kursor berada di btnHomepageLogout
            btnHomepageLogout.BackColor = Color.FromArgb(243, 156, 18);
            btnHomepageLogout.ForeColor = Color.FromArgb(44, 62, 80);
        }
        private void btnHomepageLogout_MouseLeave(object sender, EventArgs e)
        {
            // mengubah warna ketika kursor keluar dari area btnHomepageLogout
            btnHomepageLogout.BackColor = SystemColors.Control;
            btnHomepageLogout.ForeColor = Color.FromArgb(44, 62, 80);
        }

        private void btnLayanan_Click(object sender, EventArgs e)
        {
            FormLayanan formLayanan = new FormLayanan();
            this.Hide();
            formLayanan.Show();
        }
    }
}
