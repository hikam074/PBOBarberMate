
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
using System.Globalization;
using PBOBarberMate.App.Services;

namespace PBOBarberMate.View.Presensi
{
    public partial class PresensiHistoryUC : UserControl
    {
        private int idAkun;
        public PresensiHistoryUC(CommonAppServices commonService, ShiftService shiftService, CommonAdminServices commonAdminServices)
        {
            InitializeComponent();
        }

        private void FormPresensi_Load(object sender, EventArgs e)
        {
            try
            {
                LoadJadwalShift();
            }

            catch (Exception ex)
            {
                MessageBox.Show($"Error loading shift data: {ex.Message}");
            }
        }

        private void LoadJadwalShift()
        {
            try
            {
                //DataTable jadwalShift = PresensiContext.GetJadwalShiftKaryawan(idAkun);
                //if (jadwalShift.Columns.Contains("waktu_presensi") && jadwalShift.Columns["waktu_presensi"].ReadOnly)
                //{
                //    jadwalShift.Columns["waktu_presensi"].ReadOnly = false;
                //}


                //for (int i = 0; i < jadwalShift.Rows.Count; i++)
                //{
                //    DataRow row = jadwalShift.Rows[i];
                //    object waktuPresensi = row["waktu_presensi"];

                //    // Jika waktu_presensi bernilai DBNull, biarkan kosong
                //    if (waktuPresensi == DBNull.Value)
                //    {
                //        row["waktu_presensi"] = DBNull.Value; // Tetap kosong

                //    }
                //}


                //dgvPresensi.DataSource = jadwalShift;

                if (dgvPresensi.Columns.Contains("id_shift"))
                {
                    dgvPresensi.Columns["id_shift"].Visible = false;
                }

                dgvPresensi.DefaultCellStyle.ForeColor = Color.Black; // Warna teks

                // Menambahkan kolom Button
                if (!dgvPresensi.Columns.Contains("Button"))
                {
                    DataGridViewButtonColumn buttonColumn = new DataGridViewButtonColumn
                    {
                        Name = "Button",
                        HeaderText = "Presensi",
                        Text = "Presensi Sekarang",
                        UseColumnTextForButtonValue = true
                    };
                    dgvPresensi.Columns.Add(buttonColumn);
                }
                dgvPresensi.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                // membuat size kolom menjadi rata danmemenuhi tabel

                // membuat tabel responsif berdasarkan isi data
                foreach (DataGridViewColumn column in dgvPresensi.Columns)
                {
                    column.Width = dgvPresensi.Width / dgvPresensi.Columns.Count;
                }
                dgvPresensi.AllowUserToAddRows = false;
                dgvPresensi.AllowUserToResizeColumns = false;
                dgvPresensi.AllowUserToResizeRows = false;
                dgvPresensi.RowHeadersVisible = false;
                dgvPresensi.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saat memuat jadwal shift: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
