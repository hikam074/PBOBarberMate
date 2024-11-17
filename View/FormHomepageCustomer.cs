using PBOBarberMate.App.Context;
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
    public partial class FormHomepageCustomer : Form
    {
        // atribut menampung akun
        public M_Customer akun;
        // atribut menampung apakah animasi hovers aktif atau tidak
        private bool hoversActivated = true;


        public FormHomepageCustomer()
        {
            InitializeComponent();
            // menangkap tiap klik event di form
            this.Click += new EventHandler(FormHomepageCustomer_Click);
        }
        private void FormHomepageCustomer_Click(object sender, EventArgs e)
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

        private void FormHomepageCustomer_Load(object sender, EventArgs e)
        {
            try
            {
                DataTable src = TabelContext.getReservasiMingguIni(akun);
                dgvJadwalMingguIni.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                foreach (DataGridViewColumn column in dgvJadwalMingguIni.Columns)
                {
                    column.Width = dgvJadwalMingguIni.Width / dgvJadwalMingguIni.Columns.Count;
                }
                dgvJadwalMingguIni.ScrollBars = ScrollBars.None;

                dgvJadwalMingguIni.AllowUserToAddRows = false;
                dgvJadwalMingguIni.AllowUserToResizeColumns = false;
                dgvJadwalMingguIni.AllowUserToResizeRows = false;
                dgvJadwalMingguIni.RowHeadersVisible = false;
                dgvJadwalMingguIni.ClearSelection();
                dgvJadwalMingguIni.SelectionChanged += (s, e) =>
                {
                    dgvJadwalMingguIni.ClearSelection();
                };

                dgvJadwalMingguIni.DataSource = src;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Terjadi kesalahan : {ex}");
            }
        }
    }
}