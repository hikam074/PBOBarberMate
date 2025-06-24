using Npgsql;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using PBOBarberMate.App.Model;
using PBOBarberMate.App.Services;
using PBOBarberMate.App.Repository;


namespace PBOBarberMate.View.Layanan
{
    public partial class LayananUC : UserControl
    {
        private readonly AkunService _akunService;
        private readonly SessionService _sessionService;
        private readonly MainApp _mainApp;

        private readonly LayananService _layananService;


        public LayananUC(AkunService akunService, SessionService sessionService, MainApp mainApp)
        {
            InitializeComponent();
            _akunService = akunService;
            _sessionService = sessionService;
            _mainApp = mainApp;

            _layananService = new LayananService(new LayananRepository());

            EnableButton();
            this.Load += FormLayanan_Load;
        }
        private void FormLayanan_Load(object sender, EventArgs e)
        {
            List<M_Layanan> daftarLayanan = _layananService.getAllLayanan();
            MessageBox.Show(daftarLayanan.Count.ToString());
            DataTable dtLayanan = ConvertLayananListToDataTable(daftarLayanan);
            dgvLayanan.DataSource = dtLayanan;
        }
        private DataTable ConvertLayananListToDataTable(List<M_Layanan> layananList)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("ID Layanan", typeof(int));
            dt.Columns.Add("Nama Layanan", typeof(string));
            dt.Columns.Add("Harga", typeof(int));
            foreach (M_Layanan layanan in layananList)
            {
                dt.Rows.Add(layanan.id_layanan, layanan.nama_layanan, layanan.harga);
            }

            return dt;
        }

        private void EnableButton()
        {
            if (_sessionService.CurrentUserRole == AkunRole.admin)
            {
                btnTambah.Visible = true; // Tombol Tambah ditampilkan untuk Admin
            }
            else
            {
                btnTambah.Visible = false; // Tombol Tambah disembunyikan untuk role lain
            }


            //// Periksa kolom sebelum mengatur visibilitas
            //if (dataGridView1.Columns.Contains("Update"))
            //{
            //    dataGridView1.Columns["Update"].Visible = SessionService.role == AkunRole.Admin;
            //}
            //if (dataGridView1.Columns.Contains("Delete"))
            //{
            //    dataGridView1.Columns["Delete"].Visible = SessionService.role == AkunRole.Admin;
            //}
        }


        private void LoadDgv()
        {
            try
            {
                // Mengambil data layanan dari service
                List<M_Layanan> layananData = _layananService.getAllLayanan();

                dgvLayanan.AutoGenerateColumns = false;
                dgvLayanan.Columns.Clear();

                DataGridViewTextBoxColumn nomorColumn = new DataGridViewTextBoxColumn();
                nomorColumn.HeaderText = "No";
                nomorColumn.Name = "nomor";
                // DataPropertyName tidak perlu diset jika Anda mengisi secara manual
                nomorColumn.ReadOnly = true;
                dgvLayanan.Columns.Add(nomorColumn);

                DataGridViewTextBoxColumn namaLayananColumn = new DataGridViewTextBoxColumn();
                namaLayananColumn.HeaderText = "Nama Layanan";
                namaLayananColumn.Name = "nama_layanan";
                namaLayananColumn.DataPropertyName = "nama_layanan";
                dgvLayanan.Columns.Add(namaLayananColumn);

                DataGridViewTextBoxColumn hargaColumn = new DataGridViewTextBoxColumn();
                hargaColumn.HeaderText = "Harga";
                hargaColumn.Name = "harga";
                hargaColumn.DataPropertyName = "harga";
                dgvLayanan.Columns.Add(hargaColumn);

                DataGridViewTextBoxColumn idLayananColumn = new DataGridViewTextBoxColumn();
                idLayananColumn.HeaderText = "ID Layanan";
                idLayananColumn.Name = "id_layanan";
                idLayananColumn.DataPropertyName = "id_layanan";
                idLayananColumn.Visible = false;
                dgvLayanan.Columns.Add(idLayananColumn);

                dgvLayanan.DataSource = layananData;

                // Isi kolom "No"
                for (int i = 0; i < dgvLayanan.Rows.Count; i++)
                {
                    dgvLayanan.Rows[i].Cells["nomor"].Value = (i + 1).ToString();
                }

                // Tambahkan kolom tombol "Edit" dan "Delete" hanya jika admin yang login
                if (_sessionService.CurrentUserRole == AkunRole.admin)
                {
                    if (dgvLayanan.Columns["Update"] == null)
                    {
                        DataGridViewButtonColumn updateButtonColumn = new DataGridViewButtonColumn
                        {
                            Name = "Update",
                            HeaderText = "Aksi",
                            Text = "Edit",
                            UseColumnTextForButtonValue = true
                        };
                        dgvLayanan.Columns.Add(updateButtonColumn);
                    }
                    if (dgvLayanan.Columns["Delete"] == null)
                    {
                        DataGridViewButtonColumn deleteButtonColumn = new DataGridViewButtonColumn
                        {
                            Name = "Delete",
                            HeaderText = "Aksi",
                            Text = "Delete",
                            UseColumnTextForButtonValue = true
                        };
                        dgvLayanan.Columns.Add(deleteButtonColumn);
                    }
                }

                // Tambahkan tombol "Lihat Ulasan" untuk semua role
                if (dgvLayanan.Columns["Lihat Ulasan"] == null)
                {
                    DataGridViewButtonColumn LihatUlasanColumn = new DataGridViewButtonColumn
                    {
                        Name = "Lihat Ulasan",
                        HeaderText = "Lihat Ulasan",
                        Text = "Lihat Ulasan",
                        UseColumnTextForButtonValue = true
                    };
                    dgvLayanan.Columns.Add(LihatUlasanColumn);
                }

                dgvLayanan.AllowUserToAddRows = false;
                dgvLayanan.RowHeadersVisible = false;
                dgvLayanan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                // Atur visibilitas tombol Update dan Delete berdasarkan role
                if (dgvLayanan.Columns.Contains("Update"))
                {
                    dgvLayanan.Columns["Update"].Visible = (_sessionService.CurrentUserRole == AkunRole.admin);
                }
                if (dgvLayanan.Columns.Contains("Delete"))
                {
                    dgvLayanan.Columns["Delete"].Visible = (_sessionService.CurrentUserRole == AkunRole.admin);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error dalam Load Data Layanan: {ex.Message}\n{ex.StackTrace}");
            }
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            //FormTambahLayanan formTambahLayanan = new FormTambahLayanan();
            //LoadDataLayanan();
            //formTambahLayanan.ShowDialog();
            //LoadDataLayanan();
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            //if (e.RowIndex < 0) return;

            //if (e.ColumnIndex == dataGridView1.Columns["Update"].Index)
            //{
            //    try
            //    {
            //        if (dataGridView1.Rows[e.RowIndex].Cells["id_layanan"] == null ||
            //        dataGridView1.Rows[e.RowIndex].Cells["id_layanan"].Value == DBNull.Value) return;

            //        int layananId = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["id_layanan"].Value);

            //        //NpgsqlDataReader LayananData = LayananContext.getLayananByID(layananId);
            //        DataTable layananTable = new DataTable();
            //        //layananTable.Load(LayananData);

            //        if (layananTable.Rows.Count > 0)
            //        {
            //            DataRow row = layananTable.Rows[0];
            //            M_Layanan layanan = new M_Layanan
            //            {
            //                id_layanan = (int)row["id_layanan"],
            //                nama_layanan = row["nama_layanan"].ToString(),
            //                harga = Convert.ToInt32(row["harga"])
            //            };
            //            FormTambahLayanan formTambahLayanan = new FormTambahLayanan();
            //            formTambahLayanan.PopulateForm(layanan);
            //            if (formTambahLayanan.ShowDialog() == DialogResult.OK)
            //            {
            //                LoadDataLayanan();
            //            }
            //            this.Show();
            //        }
            //    }
            //    catch (Exception ex)
            //    {
            //        MessageBox.Show("Error: " + ex.Message);
            //    }
            //}
            //else if (e.ColumnIndex == dataGridView1.Columns["Delete"].Index)
            //{
            //    if (dataGridView1.Rows[e.RowIndex].Cells["id_layanan"] == null ||
            //    dataGridView1.Rows[e.RowIndex].Cells["id_layanan"].Value == DBNull.Value) return;

            //    int layananId = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["id_layanan"].Value);
            //    //LayananContext.DeleteLayanan(layananId);
            //    LoadDataLayanan(); //layanan
            //}

            //else if (e.ColumnIndex == dataGridView1.Columns["Lihat Ulasan"].Index)
            //{
            //    if (dataGridView1.Rows[e.RowIndex].Cells["id_layanan"] == null ||
            //    dataGridView1.Rows[e.RowIndex].Cells["id_layanan"].Value == DBNull.Value) return;

            //    int layananId = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["id_layanan"].Value);

            //    FormUlasan.FormUlasan formUlasan = new FormUlasan.FormUlasan();
            //    formUlasan.id_layanan = layananId;
            //    formUlasan.id_akun = id_akun;
            //    formUlasan.Show();
            //    this.Hide();
            //}
        }
    }
}
