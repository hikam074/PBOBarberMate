using Npgsql;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PBOBarberMate.View.FormReservasi
{
    public partial class FormLihatReservasi : Form
    {
        public FormLihatReservasi()
        {
            InitializeComponent();
            // mengubah visibilitas tombol aksi
            ActivatingBtn();
            // menangkap event load untuk loading data
            this.Load += FormLihatReservasi_Load;
            // mengubah judul sesuai role
            if (UserSession.role != AkunRole.Customer)
            {
                lblTitle.Text = "Jadwal Reservasi";
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

        private void FormLihatReservasi_Load(object sender, EventArgs e)
        {
            // mengambil data dari db
            LoadDataReservasi();
        }

        private void LoadDataReservasi()
        {
            try
            {
                // mengambil data dari db
                if (UserSession.role == AkunRole.Customer)
                {
                    DataTable dataReservasi = ReservasiContext.getReservasiExceptSelesai(UserSession.email.ToString());
                    // tidak ada yang kembali setelah diminta
                    if (dataReservasi == null)
                    {
                        MessageBox.Show("Error: Gagal mengambil data Layanan");
                        return;
                    }
                    // menggunakan data yang telah diambil untuk ditampilkan
                    dgvDataReservasi.DataSource = dataReservasi;
                }
                else
                {
                    DataTable dataReservasi = ReservasiContext.getReservasiAll();
                    // tidak ada yang kembali setelah diminta
                    if (dataReservasi == null)
                    {
                        MessageBox.Show("Error: Gagal mengambil data Layanan");
                        return;
                    }
                    // menggunakan data yang telah diambil untuk ditampilkan
                    dgvDataReservasi.DataSource = dataReservasi;
                }
                // membuat object tombol edit
                if (!dgvDataReservasi.Columns.Contains("Update"))
                {
                    DataGridViewButtonColumn updateButtonColumn = new DataGridViewButtonColumn
                    {
                        Name = "Update",
                        HeaderText = "Aksi",
                        Text = "Ubah",
                        UseColumnTextForButtonValue = true
                    };
                    // menambahkan objek ke kolom dan row
                    dgvDataReservasi.Columns.Add(updateButtonColumn);
                }
                // membuat object tombol batalkan
                if (!dgvDataReservasi.Columns.Contains("Delete"))
                {
                    DataGridViewButtonColumn deleteButtonColumn = new DataGridViewButtonColumn
                    {
                        Name = "Delete",
                        HeaderText = "Aksi",
                        Text = "Batalkan",
                        UseColumnTextForButtonValue = true
                    };
                    // menambahkan objek ke kolom dan row
                    dgvDataReservasi.Columns.Add(deleteButtonColumn);
                }
                // method kustomisasi tabel
                void SetHeaderText(DataGridView dgv, string columnName, string headerText)
                {
                    if (dgv.Columns[columnName] != null)
                    {
                        dgv.Columns[columnName].HeaderText = headerText;
                    }
                }
                // menggunakan method kustomisasi
                SetHeaderText(dgvDataReservasi, "id_reservasi", "ID Reservasi");
                SetHeaderText(dgvDataReservasi, "nama_layanan", "Layanan");
                SetHeaderText(dgvDataReservasi, "tanggal", "Tanggal");
                SetHeaderText(dgvDataReservasi, "waktu", "Waktu");
                SetHeaderText(dgvDataReservasi, "harga", "Harga");
                SetHeaderText(dgvDataReservasi, "nama_status_reservasi", "Status");
                SetHeaderText(dgvDataReservasi, "id_akun", "ID");
                SetHeaderText(dgvDataReservasi, "nama_akun", "Nama");
                // masih kustomisasi column header
                dgvDataReservasi.Columns["id_reservasi"].Width = 68;
                dgvDataReservasi.Columns["tanggal"].Width = 68;
                dgvDataReservasi.Columns["waktu"].Width = 52;
                dgvDataReservasi.Columns["harga"].Width = 68;
                if (dgvDataReservasi.Columns.Contains("nama_status_reservasi"))
                {
                    dgvDataReservasi.Columns["nama_status_reservasi"].Width = 84;
                }
                dgvDataReservasi.Columns["Update"].Width = 48;
                dgvDataReservasi.Columns["Delete"].Width = 72;
                // behaviour table
                dgvDataReservasi.AllowUserToAddRows = false;
                dgvDataReservasi.RowHeadersVisible = false;
                dgvDataReservasi.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                // mengaktifkan tombol aksi
                ActivatingBtn();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Terjadi Kesalahan [PBOBarberMate.View.FormReservasi.FormLihatReservasi.LoadDataReservasi] : {ex}");
            }
        }

        private void ActivatingBtn()
        {
            // Periksa kolom sebelum mengatur visibilitas
            if (dgvDataReservasi.Columns.Contains("Update"))
            {
                dgvDataReservasi.Columns["Update"].Visible = UserSession.role == AkunRole.Customer;
            }
            if (dgvDataReservasi.Columns.Contains("Delete"))
            {
                dgvDataReservasi.Columns["Delete"].Visible = UserSession.role == AkunRole.Customer;
            }
        }

        private void dgvDataReservasi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // bila yang diklik bukan kolom apa-apa
            if (e.RowIndex < 0) return;
            // bila yang diklik adalah tombol update
            if (e.ColumnIndex == dgvDataReservasi.Columns["Update"].Index)
            {
                try
                {
                    // bila update diklik adalah data berstatus selain dijadwalkan atau isinya null maka tidak dilakukan apa-apa 
                    if (dgvDataReservasi.Rows[e.RowIndex].Cells["id_reservasi"] == null || dgvDataReservasi.Rows[e.RowIndex].Cells["id_reservasi"].Value == DBNull.Value || dgvDataReservasi.Rows[e.RowIndex].Cells["nama_status_reservasi"].Value.ToString() != reservasiStatus.dijadwalkan.ToString())
                    {
                        return;
                    }
                    // mengambil id reservasi
                    int reservasiID = Convert.ToInt32(dgvDataReservasi.Rows[e.RowIndex].Cells["id_reservasi"].Value);
                    // menampilkan popup form ubah reservasi
                    FormBuatReservasi formBuatReservasi = new FormBuatReservasi();
                    formBuatReservasi.changeToEdit(reservasiID);
                    formBuatReservasi.Show();
                    // load data setelah edit
                    LoadDataReservasi();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Terjadi Kesalahan [PBOBarberMate.View.FormReservasi.FormLihatReservasi.dgvDataReservasi_CellContentClick./tombolUpdate/] : {ex}");
                }
            }
            // bila yang dikllik adalah tombol delete
            else if (e.ColumnIndex == dgvDataReservasi.Columns["Delete"].Index)
            {
                try
                {
                    // bila update diklik adalah data berstatus dibatalkan atau isinya null maka tidak dilakukan apa-apa 
                    if (dgvDataReservasi.Rows[e.RowIndex].Cells["id_reservasi"] == null || dgvDataReservasi.Rows[e.RowIndex].Cells["id_reservasi"].Value == DBNull.Value || dgvDataReservasi.Rows[e.RowIndex].Cells["nama_status_reservasi"].Value.ToString() == reservasiStatus.dibatalkan.ToString())
                    {
                        return;
                    }
                    // bila update diklik adalah data berstatus selesai atau isinya null maka tidak dilakukan apa-apa 
                    if (dgvDataReservasi.Rows[e.RowIndex].Cells["nama_status_reservasi"].Value.ToString() == reservasiStatus.selesai.ToString())
                    {
                        MessageBox.Show("Pesanan ini telah selesai! Tidak dapat dibatalkan");
                        return;
                    }
                    // membuat MessageBox anda yakin
                    DialogResult lanjut = MessageBox.Show(
                        "Apakah anda yakin?",
                        "Konfirmasi",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question
                    );
                    // menampilkan MessageBox
                    if (lanjut == DialogResult.Yes) // bila konfirmasi yes untuk membatalkan
                    {
                        // memengambil id reservasi dari baris
                        int reservasiID = Convert.ToInt32(dgvDataReservasi.Rows[e.RowIndex].Cells["id_reservasi"].Value);
                        // melakukan pembatalan reservasi
                        int berhasilHapus = ReservasiContext.batalkanReservasi(reservasiID);
                        // berhasil batalkan
                        if (berhasilHapus > 0)
                        {
                            MessageBox.Show("Reservasi Berhasil dibatalkan!");
                        }
                        // gagal batalkan
                        else
                        {
                            MessageBox.Show("Tidak dapat menghapus!");
                        }
                    }
                    // load data setelah melakukan apapun
                    LoadDataReservasi();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Terjadi Kesalahan [PBOBarberMate.View.FormReservasi.FormLihatReservasi.dgvDataReservasi_CellContentClick./tombolBatal/] : {ex}");
                }
            }
        }
    }
}
