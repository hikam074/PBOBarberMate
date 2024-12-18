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

                    DataTable jadwalShift = PresensiContext.GetJadwalShiftKaryawanAll();
                    if (jadwalShift == null)
                    {
                        MessageBox.Show("Error: Gagal mengambil data jadwal Shift");
                        return;
                    }

                    dataGridViewKelolaKaryawan.Columns.Clear();

                    //DataGridViewTextBoxColumn nomorColumn = new DataGridViewTextBoxColumn();
                    //nomorColumn.HeaderText = "No";
                    //nomorColumn.Name = "nomor";
                    //dataGridViewKelolaKaryawan.Columns.Add(nomorColumn);
                    dataGridViewKelolaKaryawan.DataSource = jadwalShift;




                    if (dataGridViewKelolaKaryawan.Columns["nama_akun"] != null) dataGridViewKelolaKaryawan.Columns["nama_akun"].HeaderText = "nama akun";
                    if (dataGridViewKelolaKaryawan.Columns["id_presensi"] != null) dataGridViewKelolaKaryawan.Columns["id_presensi"].Visible=false;
                    if (dataGridViewKelolaKaryawan.Columns["id_akun"] != null) dataGridViewKelolaKaryawan.Columns["id_akun"].Visible=false;
                    if (dataGridViewKelolaKaryawan.Columns["nama_hari"] != null)
                        dataGridViewKelolaKaryawan.Columns["nama_hari"].HeaderText = "nama hari";
                    if (dataGridViewKelolaKaryawan.Columns["waktu_presensi"] != null)
                        dataGridViewKelolaKaryawan.Columns["waktu_presensi"].HeaderText = "waktu presensi";

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

                    DataGridViewButtonColumn deleteButtonColumn = new DataGridViewButtonColumn
                    {
                        Name = "Hapus",
                        HeaderText = "Hapus",
                        Text = "Hapus",
                        UseColumnTextForButtonValue = true
                    };
                    dataGridViewKelolaKaryawan.Columns.Add(deleteButtonColumn);
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

        
    }
}
