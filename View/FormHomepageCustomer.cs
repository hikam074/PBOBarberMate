﻿using PBOBarberMate.App.Context;
using PBOBarberMate.App.Core;
using PBOBarberMate.App.Model;
using PBOBarberMate.View.FormReservasi;
using PBOBarberMate.View.FormPembayaran;
using PBOBarberMate.View.FormUlasan;
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
        // atribut menampung apakah animasi hovers aktif atau tidak
        private bool hoversActivated = true;


        public FormHomepageCustomer()
        {
            InitializeComponent();
            // mengubah ucapan nama sesuai nama logged
            lblWelcome.Text = UserSession.nama;
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

        private void FormHomepageCustomer_Load(object sender, EventArgs e)
        {
            try
            {
                // mengambil data dari db
                DataTable src = TabelContext.getReservasiMingguIni();
                // membuat size kolom menjadi rata dan memenuhi tabel
                dgvJadwalMingguIni.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                // membuat tabel responsif berdasarkan isi data
                foreach (DataGridViewColumn column in dgvJadwalMingguIni.Columns)
                {
                    column.Width = dgvJadwalMingguIni.Width / dgvJadwalMingguIni.Columns.Count;
                }
                // behaviour table
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
                // mengambil data dari variabel
                dgvJadwalMingguIni.DataSource = src;

                dgvJadwalMingguIni.Columns["tanggal"].HeaderText = "Tanggal";
                dgvJadwalMingguIni.Columns["waktu"].HeaderText = "Waktu";
                dgvJadwalMingguIni.Columns["pelayanan"].HeaderText = "Pelayanan";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Terjadi kesalahan [PBOBarberMate.View.FormHomepageCustomer.FormHomepageCustomer_Load] : {ex}");
            }
        }

        private void btnReservasi_Click(object sender, EventArgs e)
        {
            // beralih ke FormBuatReservasi
            FormBuatReservasi formBuatReservasi = new FormBuatReservasi();
            formBuatReservasi.modeEdit = false;
            formBuatReservasi.Show();
            this.Hide();
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

        private void btnLihatReservasi_Click(object sender, EventArgs e)
        {
            // beralih ke FormLihatReservasi
            FormLihatReservasi formLihatReservasi = new FormLihatReservasi();
            formLihatReservasi.Show();
            this.Hide();
        }

        private void lklbMore_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // beralih ke FormLihatReservasi
            FormLihatReservasi formLihatReservasi = new FormLihatReservasi();
            formLihatReservasi.Show();
            this.Hide();
        }
        private void btnUlasan_Click(object sender, EventArgs e)
        {
            FormLihatPembayaranUntukUlasan form = new FormLihatPembayaranUntukUlasan();
            form.Show();
            this.Hide();
        }
    }
}