using System;
using System.Windows.Forms;
using System.Drawing;
using Npgsql;

using PBOBarberMate.App.Context;
using PBOBarberMate.App.Core;
using PBOBarberMate.App.Model;
using PBOBarberMate.View;
using PBOBarberMate.View.FormInventaris;
using PBOBarberMate.View.FormPresensi;


namespace PBOBarberMate.View
{
    public partial class FormHomepageKaryawan : Form
    {
        // atribut menampung apakah animasi hovers aktif atau tidak
        private bool hoversActivated = true;


        public FormHomepageKaryawan()
        {
            InitializeComponent();
            // loading data-data latest di form homepage karyawan
            loadFormKaryawan();
            // menangkap tiap klik event di form
            this.Click += new EventHandler(FormHomepageKaryawan_Click);
        }


        public void loadFormKaryawan()
        {
            lblWelcome.Text = UserSession.nama;
            lblStatusShiftToday.Text = ShiftContext.getShiftByIDToday(UserSession.idSession);
            string waktuPresensi = PresensiContext.isPresensiTodayExist(UserSession.idSession);
            string adashift = ShiftContext.getShiftByIDToday(UserSession.idSession);
            if (adashift == "Ada")
            {
                adashift = "-";
                btnLakukanPresensi.Enabled = true;
            }
            else
            {
                btnLakukanPresensi.Enabled = false;
            }
            lblStatusPresensiToday.Text = waktuPresensi;
        }

        private void FormHomepageKaryawan_Load(object sender, EventArgs e)
        {
            loadFormKaryawan();
        }

        private void FormHomepageKaryawan_Click(object sender, EventArgs e)
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

        private void btnLayanan_Click(object sender, EventArgs e)
        {
            // beralih ke FormLayanan
            FormLayanan formLayanan = new FormLayanan();
            formLayanan.Show();
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

        private void btnProfil_Click(object sender, EventArgs e)
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

        private void btnHomepageLogout_Click(object sender, EventArgs e)
        {
            // kembali ke FormLogin
            FormLogin formLogin = new FormLogin();
            // logout dari session
            AkunContext.logout();

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

        private void btnInventaris_Click(object sender, EventArgs e)
        {
            // beralih ke Form Inventaris
            FormInventaris.FormInventaris formInventaris = new FormInventaris.FormInventaris();
            formInventaris.Show();
            this.Hide();
        }

        private void btnPerforma_Click(object sender, EventArgs e)
        {
            FormPerforma.FormPerforma formPerforma = new FormPerforma.FormPerforma();
            formPerforma.Show();
            this.Hide();
        }

        private void btnReservasi_Click(object sender, EventArgs e)
        {
            int idAkun = UserSession.idSession;
            FormPresensi.FormPresensi formPresensi = new FormPresensi.FormPresensi(idAkun);
            formPresensi.Show();
            this.Hide();
        }

        private void btnLakukanPresensi_Click(object sender, EventArgs e)
        {

            // apabila presensi sudah ada
            if (PresensiContext.isPresensiTodayExist(UserSession.idSession) != null)
            {
                // maka kembali
                MessageBox.Show($"Data presensi SUDAH ada!", "Presensi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadFormKaryawan();
                return;
            }

            // Sedangkan kalau belum maka tambahkan presensi
            try
            {
                M_Presensi presensi = new M_Presensi
                {
                    id_akun = UserSession.idSession,
                    id_shift = PresensiContext.getJadwalShiftTodayThisID(UserSession.idSession),
                    waktu_presensi = DateTime.Now
                };
                MessageBox.Show($"{presensi.id_shift}");
                
                PresensiContext.AddPresensi(presensi);

                MessageBox.Show($"Presensi BERHASIL ditambahkan!", "Presensi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"GAGAL melakukan presensi: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                loadFormKaryawan();
            }
        }
    }
}