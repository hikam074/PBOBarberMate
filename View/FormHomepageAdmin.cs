using System;
using System.Windows.Forms;
using Npgsql;

using PBOBarberMate.App.Context;
using PBOBarberMate.App.Core;
using PBOBarberMate.App.Model;
using PBOBarberMate.View;
using PBOBarberMate.View.FormInventaris;
using PBOBarberMate.View.FormReservasi;
namespace PBOBarberMate.View
{
    public partial class FormHomepageAdmin : Form
    {
        // atribut menampung apakah animasi hovers aktif atau tidak
        private bool hoversActivated = true;


        public FormHomepageAdmin()
        {
            InitializeComponent();
            // mengubah ucapan nama sesuai nama logged
            lblWelcome.Text = UserSession.nama;
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

        private void btnProfil_Click(object sender, EventArgs e)
        {
            // kalau box profil belum muncul
            if (gbxShowProfile.Visible == false)
            {
                // memunculkan profil
                gbxShowProfile.Visible = true;
                // memunculkan isi profil
                lblProfilRole.Text = UserSession.role.ToString();
                lblProfilNama.Text = UserSession.nama;
                lblProfilEmail.Text = UserSession.email;
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
            formUbahProfil.Show();
            this.Hide();
            // menyembunyikan gbxShowProfile
            gbxShowProfile.Visible = false;
            // mengembalikan warna btnProfil ke default
            btnProfil.BackColor = Color.FromArgb(44, 62, 80);
            btnProfil.ForeColor = Color.White;
            // mengaktifkan kembali animasi hovers
            hoversActivated = true;
        }

        private void btnLayanan_Click(object sender, EventArgs e)
        {
            // beralih ke FormLayanan
            FormLayanan formLayanan = new FormLayanan();
            formLayanan.Show();
            this.Hide();
        }

        private void btnInventaris_Click(object sender, EventArgs e)
        {
            // beralih ke FormInventaris
            FormInventaris.FormInventaris formInventaris = new FormInventaris.FormInventaris();
            formInventaris.Show();
            this.Hide();
        }

        private void btnReservasi_Click(object sender, EventArgs e)
        {
            // beralih ke FormLihatReservasi
            FormLihatReservasi formLihatReservasi = new FormLihatReservasi();
            formLihatReservasi.Show();
            this.Hide();
        }

        private void btnHomepageLogout_Click(object sender, EventArgs e)
        {
            // kembali ke FormLogin
            FormLogin formLogin = new FormLogin();
            // logout dari session
            AkunContext.logout();

            formLogin.Show();
            this.Hide();
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
    }
}