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
using System.Globalization;

namespace PBOBarberMate.View.FormPresensi
{
    public partial class FormPresensi : Form
    {
        private int idAkun;
        public FormPresensi(int akunId)
        {
            idAkun = akunId;
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
                DataTable jadwalShift = PresensiContext.GetJadwalShiftKaryawan(idAkun);
                if (jadwalShift.Columns.Contains("waktu_presensi") && jadwalShift.Columns["waktu_presensi"].ReadOnly)
                {
                    jadwalShift.Columns["waktu_presensi"].ReadOnly = false;
                }


                for (int i = 0; i < jadwalShift.Rows.Count; i++)
                {
                    DataRow row = jadwalShift.Rows[i];
                    object waktuPresensi = row["waktu_presensi"];

                    // Jika waktu_presensi bernilai DBNull, biarkan kosong
                    if (waktuPresensi == DBNull.Value)
                    {
                        row["waktu_presensi"] = DBNull.Value; // Tetap kosong

                    }
                }


                dgvPresensi.DataSource = jadwalShift;

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

        private void dgvPresensi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvPresensi.Columns[e.ColumnIndex] is DataGridViewButtonColumn)
            {
                // Ambil data dari baris yang diklik
                int idShift = Convert.ToInt32(dgvPresensi.Rows[e.RowIndex].Cells["id_shift"].Value);
                string hari = dgvPresensi.Rows[e.RowIndex].Cells["Hari"].Value.ToString();
                object waktuPresensi = dgvPresensi.Rows[e.RowIndex].Cells["waktu_presensi"].Value;

                // Cek apakah presensi sudah dilakukan
                if (waktuPresensi != null && waktuPresensi != DBNull.Value)
                {
                    MessageBox.Show("Anda sudah melakukan presensi untuk shift ini.", "Presensi Gagal", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string hariSekarang = DateTime.Now.ToString("dddd", new CultureInfo("id-ID")); // Bahasa Indonesia
                if (!hari.Equals(hariSekarang, StringComparison.OrdinalIgnoreCase))
                {
                    MessageBox.Show($"Presensi hanya dapat dilakukan pada hari {hari}.", "Presensi Gagal", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Tambahkan presensi
                try
                {
                    M_Presensi presensi = new M_Presensi
                    {
                        id_akun = idAkun,
                        id_shift = idShift,
                        waktu_presensi = DateTime.Now
                    };

                    PresensiContext.AddPresensi(presensi);

                    MessageBox.Show($"Presensi berhasil untuk shift hari {hari} pada {DateTime.Now}.", "Presensi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Reload jadwal setelah presensi berhasil
                    LoadJadwalShift();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Gagal melakukan presensi: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void lblPresensi_Click(object sender, EventArgs e)
        {

        }

        private void btnKembali_Click(object sender, EventArgs e)
        {
            // Buka FormHomepageKaryawan
            FormHomepageKaryawan formHomepageKaryawan = new FormHomepageKaryawan();
            formHomepageKaryawan.Show();

            // Tutup form saat ini (FormPresensi)
            this.Close();
        }
    }
}
