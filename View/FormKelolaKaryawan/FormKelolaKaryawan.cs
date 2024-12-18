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

namespace PBOBarberMate.View.FormKelolaKaryawan
{
    public partial class FormKelolaKaryawan : Form
    {
        public FormKelolaKaryawan()
        {
            InitializeComponent();
            MenampilkanKehadiranKaryawan();
        }
        public void MenampilkanKehadiranKaryawan()
        {
            {
                try
                {
                    dataGridViewKelolaKaryawan.AllowUserToAddRows = false;
                    DataGridViewDaftarKaryawan.AllowUserToAddRows = false;

                    DataTable jadwalShift = PresensiContext.GetJadwalShiftKaryawanAll();
                    if (jadwalShift == null)
                    {
                        MessageBox.Show("Error: Gagal mengambil data jadwal Shift");
                        return;
                    }

                    dataGridViewKelolaKaryawan.Columns.Clear();
                    DataGridViewDaftarKaryawan.Columns.Clear();


                    //DataGridViewTextBoxColumn nomorColumn = new DataGridViewTextBoxColumn();
                    //nomorColumn.HeaderText = "No";
                    //nomorColumn.Name = "nomor";
                    //dataGridViewKelolaKaryawan.Columns.Add(nomorColumn);
                    dataGridViewKelolaKaryawan.DataSource = jadwalShift;

                    if (dataGridViewKelolaKaryawan.Columns["nama_akun"] != null) dataGridViewKelolaKaryawan.Columns["nama_akun"].HeaderText = "nama akun";
                    if (dataGridViewKelolaKaryawan.Columns["id_presensi"] != null) dataGridViewKelolaKaryawan.Columns["id_presensi"].Visible = false;
                    if (dataGridViewKelolaKaryawan.Columns["id_akun"] != null) dataGridViewKelolaKaryawan.Columns["id_akun"].Visible = false;
                    if (dataGridViewKelolaKaryawan.Columns["nama_hari"] != null)
                        dataGridViewKelolaKaryawan.Columns["nama_hari"].HeaderText = "nama hari";
                    if (dataGridViewKelolaKaryawan.Columns["waktu_presensi"] != null)
                        dataGridViewKelolaKaryawan.Columns["waktu_presensi"].HeaderText = "waktu presensi";

                    DataTable daftarKaryawan = KaryawanContext.getInfoNamaKaryawan();
                    if (daftarKaryawan == null)
                    {
                        MessageBox.Show("Error: Gagal mengambil Daftar Karyawan");
                        return;
                    }
                    DataGridViewDaftarKaryawan.DataSource = daftarKaryawan;

                    if (DataGridViewDaftarKaryawan.Columns["nama_akun"] != null) DataGridViewDaftarKaryawan.Columns["nama_akun"].HeaderText = "Nama Karyawan";
                    if (DataGridViewDaftarKaryawan.Columns["id_akun"] != null) DataGridViewDaftarKaryawan.Columns["id_akun"].Visible = false;

                    //for (int i = 0; i < dataGridViewKelolaKaryawan.Rows.Count; i++)
                    //{
                    //    dataGridViewKelolaKaryawan.Rows[i].Cells["nomor"].Value = (i + 1).ToString();
                    //}

                    DataGridViewButtonColumn updateButtonColumn = new DataGridViewButtonColumn
                    {
                        Name = "Ubah",
                        HeaderText = "Ubah",
                        Text = "Ubah",
                        UseColumnTextForButtonValue = true
                    };
                    dataGridViewKelolaKaryawan.Columns.Add(updateButtonColumn);
                    DataGridViewButtonColumn updateButtonColumnKaryawan = new DataGridViewButtonColumn
                    {
                        Name = "Ubah",
                        HeaderText = "Ubah",
                        Text = "Ubah",
                        UseColumnTextForButtonValue = true
                    };
                    DataGridViewDaftarKaryawan.Columns.Add(updateButtonColumnKaryawan);

                    DataGridViewButtonColumn deleteButtonColumn = new DataGridViewButtonColumn
                    {
                        Name = "Hapus",
                        HeaderText = "Hapus",
                        Text = "Hapus",
                        UseColumnTextForButtonValue = true
                    };
                    dataGridViewKelolaKaryawan.Columns.Add(deleteButtonColumn);
                    DataGridViewButtonColumn deleteButtonColumnKaryawan = new DataGridViewButtonColumn
                    {
                        Name = "Hapus",
                        HeaderText = "Hapus",
                        Text = "Hapus",
                        UseColumnTextForButtonValue = true
                    };
                    DataGridViewDaftarKaryawan.Columns.Add(deleteButtonColumnKaryawan);

                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error dalam LoadDataMahasiswa: {ex.Message}\n{ex.StackTrace}");
                }
            }

        }

        private void dataGridViewKelolaKaryawan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            if (e.ColumnIndex == dataGridViewKelolaKaryawan.Columns["Ubah"].Index)
            {
                try
                {

                    int presensiId = Convert.ToInt32(dataGridViewKelolaKaryawan.Rows[e.RowIndex].Cells["id_presensi"].Value);
                    DataTable presensiData = PresensiContext.GetJadwalShiftKaryawanbyIdPresensi(presensiId);

                    if (presensiData.Rows.Count > 0)
                    {
                        DataRow row = presensiData.Rows[0];
                        M_Presensi presensiKaryawan = new M_Presensi
                        {
                            id_presensi = (int)row["id_presensi"],
                            nama_akun = (string)row["nama_akun"],
                            id_akun = (int)row["id_akun"],
                            id_shift = (int)row["id_shift"],
                            hari = (string)row["Hari"],
                            waktu_presensi = (DateTime)row["waktu_presensi"]
                        };
                        FiturPresensiKaryawan updatePresensiKaryawan = new FiturPresensiKaryawan();
                        updatePresensiKaryawan.PopulateForm(presensiKaryawan);
                        updatePresensiKaryawan.ShowDialog();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
            else if (e.ColumnIndex == dataGridViewKelolaKaryawan.Columns["Hapus"].Index)
            {
                try
                {
                    int idPresensi = Convert.ToInt32(dataGridViewKelolaKaryawan.Rows[e.RowIndex].Cells["id_presensi"].Value);
                    PresensiContext.DeletePresensi(idPresensi);
                    MenampilkanKehadiranKaryawan();
                    MessageBox.Show("Data berhasil dihapus");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }

            }
            
        }

        private void btnKembali_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FiturTambahKaryawan tambahKaryawan = new FiturTambahKaryawan();
            tambahKaryawan.ShowDialog();
        }

        private void DataGridViewDaftarKaryawan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == DataGridViewDaftarKaryawan.Columns["Ubah"].Index)
            {
                try
                {

                    int idAkun = Convert.ToInt32(DataGridViewDaftarKaryawan.Rows[e.RowIndex].Cells["id_akun"].Value);
                    DataTable karyawanData = KaryawanContext.getInfoAkun(idAkun);

                    if (karyawanData.Rows.Count > 0)
                    {
                        DataRow row = karyawanData.Rows[0];
                        FiturTambahKaryawan updateKaryawan = new FiturTambahKaryawan();
                        updateKaryawan.PopulateForm((string)row["nama_akun"], (string)row["email"], (string)row["password"], idAkun);
                        updateKaryawan.ShowDialog();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
            else if (e.ColumnIndex == DataGridViewDaftarKaryawan.Columns["Hapus"].Index)
            {
                try
                {
                    int idAkun = Convert.ToInt32(DataGridViewDaftarKaryawan.Rows[e.RowIndex].Cells["id_akun"].Value);
                    KaryawanContext.DeleteKaryawan(idAkun);
                    MenampilkanKehadiranKaryawan();
                    MessageBox.Show("Data berhasil dihapus");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }

            }
        }
    }
}
