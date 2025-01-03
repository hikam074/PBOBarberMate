﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PBOBarberMate.App.Context;
using PBOBarberMate.App.Core;
using PBOBarberMate.App.Model;
using PBOBarberMate.View.FormReservasi;
using PBOBarberMate.View.FormUlasan;


namespace PBOBarberMate.View.FormPembayaran
{
    public partial class FormLihatPembayaranUntukUlasan : Form
    {
        public FormLihatPembayaranUntukUlasan()
        {
            InitializeComponent();
            
            LoadDataPembayaran();
        }


        public void LoadDataPembayaran()
        {
            try
            {
                if (UserSession.role == AkunRole.Customer)
                {
                    DataTable dataPembayaran = PembayaranContext.getDataPembayaran(UserSession.idSession);
                    dgvDataPembayaran.DataSource = dataPembayaran;
                }
                else
                {
                    DataTable dataPembayaran = PembayaranContext.getDataPembayaran();
                    dgvDataPembayaran.DataSource = dataPembayaran;
                }

                if (!dgvDataPembayaran.Columns.Contains("Ulas"))
                {
                    DataGridViewButtonColumn ulasanBtnColumn = new DataGridViewButtonColumn
                    {
                        Name = "Ulas",
                        HeaderText = "Aksi",
                        Text = "Beri Ulasan",
                        UseColumnTextForButtonValue = true
                    };
                    dgvDataPembayaran.Columns.Add(ulasanBtnColumn);
                }

                if (!dgvDataPembayaran.Columns.Contains("Ubah"))
                {
                    DataGridViewButtonColumn ulasanBtnColumn = new DataGridViewButtonColumn
                    {
                        Name = "Edit",
                        HeaderText = "Aksi",
                        Text = "Ubah",
                        UseColumnTextForButtonValue = true
                    };
                    dgvDataPembayaran.Columns.Add(ulasanBtnColumn);
                }

                //// Perbarui tombol untuk setiap baris
                //foreach (DataGridViewRow row in dgvDataPembayaran.Rows)
                //{
                //    if (row.Cells["id_pembayaran"].Value != null)
                //    {
                //        int idPembayaran = Convert.ToInt32(row.Cells["id_pembayaran"].Value);

                //        // Periksa apakah ulasan sudah ada
                //        if (UlasanContext.CheckUlasanExist(idPembayaran))
                //        {
                //            row.Cells["Ulas"].Value = "Sudah Dinilai";
                //            ((DataGridViewButtonCell)row.Cells["Ulas"]).ReadOnly = true;
                //        }
                //        else
                //        {
                //            row.Cells["Ulas"].Value = "Beri Nilai";
                //            ((DataGridViewButtonCell)row.Cells["Ulas"]).ReadOnly = false;
                //        }
                //    }
                //}

                // behaviour table
                dgvDataPembayaran.AllowUserToAddRows = false;
                    dgvDataPembayaran.RowHeadersVisible = false;
                    dgvDataPembayaran.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    // method kustomisasi tabel
                    void SetHeaderText(DataGridView dgv, string columnName, string headerText)
                    {
                        if (dgv.Columns[columnName] != null)
                        {
                            dgv.Columns[columnName].HeaderText = headerText;
                        }
                    }
                    // menggunakan method kustomisasi
                    SetHeaderText(dgvDataPembayaran, "nama_layanan", "Layanan");
                    SetHeaderText(dgvDataPembayaran, "harga", "Harga");
                    SetHeaderText(dgvDataPembayaran, "nama_metode_pembayaran", "Metode Pembayaran");
                    SetHeaderText(dgvDataPembayaran, "tanggal_dibayar", "Tanggal Pembayaran");
                    SetHeaderText(dgvDataPembayaran, "id_akun", "ID Akun");
                    SetHeaderText(dgvDataPembayaran, "nama_akun", "Nama Customer");

                    if (dgvDataPembayaran.Columns.Contains("id_akun") && UserSession.role == AkunRole.Customer)
                    {
                        dgvDataPembayaran.Columns["id_akun"].Visible = false;
                    }
                    if (dgvDataPembayaran.Columns.Contains("nama_akun") && UserSession.role == AkunRole.Customer)
                    {
                        dgvDataPembayaran.Columns["nama_akun"].Visible = false;
                    }
                    if (dgvDataPembayaran.Columns.Contains("id_pembayaran"))
                    {
                        dgvDataPembayaran.Columns["id_pembayaran"].Visible = false;
                    }
                    if (dgvDataPembayaran.Columns.Contains("id_reservasi"))
                    {
                        dgvDataPembayaran.Columns["id_reservasi"].Visible = false;
                    }
                if (dgvDataPembayaran.Columns.Contains("id_metode_pembayaran"))
                {
                    dgvDataPembayaran.Columns["id_metode_pembayaran"].Visible = false;
                }
                if (dgvDataPembayaran.Columns.Contains("Ulas") && UserSession.role != AkunRole.Customer)
                    {
                        dgvDataPembayaran.Columns["Ulas"].Visible = false;
                    }
                if (dgvDataPembayaran.Columns.Contains("Edit") && UserSession.role != AkunRole.Admin)
                {
                    dgvDataPembayaran.Columns["Edit"].Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex}");
            }
        }

        private void dgvDataPembayaran_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // bila yang diklik bukan kolom apa-apa
            if (e.RowIndex < 0) return;
            // bila yang diklik adalah tombol ulas
            if (e.ColumnIndex == dgvDataPembayaran.Columns["Ulas"].Index)
            {
                int idPembayaran = Convert.ToInt32(dgvDataPembayaran.Rows[e.RowIndex].Cells["id_pembayaran"].Value);

                // Periksa apakah ulasan sudah ada
                if (UlasanContext.CheckUlasanExist(idPembayaran))
                {
                    MessageBox.Show("Pembayaran ini sudah dinilai. Tidak dapat memberikan ulasan lagi.");
                    return;
                }
                try
                {
                    // mengambil id pembayaran
                    int pembayaranID = Convert.ToInt32(dgvDataPembayaran.Rows[e.RowIndex].Cells["id_pembayaran"].Value);
                    // menampilkan popup form tujuan
                    FormTambahUlasan formTambahUlasan = new FormTambahUlasan();
                    formTambahUlasan.id_pembayaran = pembayaranID;
                    formTambahUlasan.Show();
                    this.Hide();
                    // load data setelah edit
                    LoadDataPembayaran();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Terjadi Kesalahan [PBOBarberMate.View.FormPembayaran.FormLihatPembayaranUntukUlasan.dgvDataPembayaran_CellContentClick./tombolUlas/] : {ex}");
                }
            }
            if (e.ColumnIndex == dgvDataPembayaran.Columns["Edit"].Index)
            {
                int idPembayaran = Convert.ToInt32(dgvDataPembayaran.Rows[e.RowIndex].Cells["id_pembayaran"].Value);

                try
                {
                    // mengambil id pembayaran
                    int pembayaranID = Convert.ToInt32(dgvDataPembayaran.Rows[e.RowIndex].Cells["id_pembayaran"].Value);
                    // menampilkan popup form tujuan
                    FormEditPembayaran formEditPembayaran = new FormEditPembayaran();
                    formEditPembayaran.lblConfirmLayanan.Text = dgvDataPembayaran.Rows[e.RowIndex].Cells["nama_layanan"].Value.ToString();
                    formEditPembayaran.lblConfirmNama.Text = dgvDataPembayaran.Rows[e.RowIndex].Cells["nama_akun"].Value.ToString();

                    // Ambil nilai dari DataGridView dan konversi menjadi string
                    string tanggalDibayarStr = dgvDataPembayaran.Rows[e.RowIndex].Cells["tanggal_dibayar"].Value.ToString();

                    // Parse string ke DateTime
                    DateTime tanggalDibayar = DateTime.Parse(tanggalDibayarStr);

                    // Format tanggal dan waktu sesuai kebutuhan
                    string tanggal = tanggalDibayar.ToString("yyyy-MM-dd"); // Hanya tanggal (contoh: 2024-12-16)
                    string waktu = tanggalDibayar.ToString("HH:mm:ss");     // Hanya waktu (contoh: 12:07:12)

                    formEditPembayaran.lblConfirmTanggal.Text = tanggal;
                    formEditPembayaran.lblConfirmWaktu.Text = waktu;
                    formEditPembayaran.id_pembayaran = idPembayaran;

                    // Ambil nilai id_metode_pembayaran dari DataGridView
                    object idMetodePembayaranValue = dgvDataPembayaran.Rows[e.RowIndex].Cells["id_metode_pembayaran"].Value;

                    // Pastikan nilainya tidak null
                    if (idMetodePembayaranValue != null)
                    {
                        int idMetodePembayaran = Convert.ToInt32(idMetodePembayaranValue);

                        // Cocokkan dengan enum metodePembayaran dan set combobox
                        if (Enum.IsDefined(typeof(metodePembayaran), idMetodePembayaran))
                        {
                            formEditPembayaran.cbxMetodePembayaran.SelectedItem = (metodePembayaran)idMetodePembayaran;
                        }
                        else
                        {
                            MessageBox.Show("Metode pembayaran tidak valid.");
                        }
                    }

                    formEditPembayaran.Show();
                    this.Hide();
                    // load data setelah edit
                    LoadDataPembayaran();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Terjadi Kesalahan [PBOBarberMate.View.FormPembayaran.FormLihatPembayaranUntukUlasan.dgvDataPembayaran_CellContentClick./tombolUlas/] : {ex}");
                }
            }
        }


        private void btnKembali_Click(object sender, EventArgs e)
        {
            // menampilkan form homepage admin bila logged sebagai admin
            if (UserSession.role == AkunRole.Admin)
            {
                FormHomepageAdmin formHomepageAdmin = new FormHomepageAdmin();
                formHomepageAdmin.Show();
                this.Hide();
            }
            // menampilkan form homepage karyawan bila logged sebagai karyawan
            else if (UserSession.role == AkunRole.Karyawan)
            {
                FormHomepageKaryawan formHomepageKaryawan = new FormHomepageKaryawan();
                formHomepageKaryawan.Show();
                this.Hide();
            }
            // menampilkan form homepage customer bila logged sebagai customer
            else if (UserSession.role == AkunRole.Customer)
            {
                FormHomepageCustomer formHomepageCustomer = new FormHomepageCustomer();
                formHomepageCustomer.Show();
                this.Hide();
            }
        }
    }
}
