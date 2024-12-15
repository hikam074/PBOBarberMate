using System;
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
                DataTable dataPembayaran = PembayaranContext.getDataPembayaran(UserSession.idSession);
                dgvDataPembayaran.DataSource = dataPembayaran;

                // membuat object tombol ulas

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

                if (dgvDataPembayaran.Columns.Contains("id_akun"))
                {
                    dgvDataPembayaran.Columns["id_akun"].Visible = false;
                }
                if (dgvDataPembayaran.Columns.Contains("id_pembayaran"))
                {
                    dgvDataPembayaran.Columns["id_pembayaran"].Visible = false;
                }
                if (dgvDataPembayaran.Columns.Contains("id_reservasi"))
                {
                    dgvDataPembayaran.Columns["id_reservasi"].Visible = false;
                }

                // Update tombol untuk setiap baris berdasarkan ulasan yang ada
                foreach (DataGridViewRow row in dgvDataPembayaran.Rows)
                {
                    if (row.Cells["id_pembayaran"].Value != null)
                    {
                        int idPembayaran = Convert.ToInt32(row.Cells["id_pembayaran"].Value);

                        // Mengecek apakah ulasan sudah ada
                        if (UlasanContext.CheckUlasanExist(idPembayaran))
                        {
                            if (!dgvDataPembayaran.Columns.Contains("Ulas"))
                            {
                                DataGridViewButtonColumn UlasanBtnColumn = new DataGridViewButtonColumn
                                {
                                    Name = "Ulas",
                                    HeaderText = "Aksi",
                                    Text = "Sudah Dinilai",
                                    ReadOnly = true,
                                    UseColumnTextForButtonValue = true
                                };
                                // menambahkan objek ke kolom dan row
                                dgvDataPembayaran.Columns.Add(UlasanBtnColumn);
                            }
                        }
                        else
                        {
                            if (!dgvDataPembayaran.Columns.Contains("Ulas"))
                            {
                                DataGridViewButtonColumn UlasanBtnColumn = new DataGridViewButtonColumn
                                {
                                    Name = "Ulas",
                                    HeaderText = "Aksi",
                                    Text = "Beri nilai",
                                    ReadOnly = false,
                                    UseColumnTextForButtonValue = true
                                };
                                // menambahkan objek ke kolom dan row
                                dgvDataPembayaran.Columns.Add(UlasanBtnColumn);
                            }
                        }
                    }
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
                if (dgvDataPembayaran.Rows[e.RowIndex].Cells["Ulas"].ReadOnly)
                {
                    //MessageBox.Show("Tombol sudah dinilai dan tidak dapat diklik.");
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
        }


        private void btnKembali_Click(object sender, EventArgs e)
        {
            // kembali ke homepage
            FormHomepageCustomer formHomepageCustomer = new FormHomepageCustomer();
            formHomepageCustomer.Show();
            this.Hide();
        }
    }
}
