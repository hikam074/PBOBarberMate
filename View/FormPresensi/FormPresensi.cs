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
                if (jadwalShift.Columns["Button"] == null)
                {
                    jadwalShift.Columns.Add("Button", typeof(string));
                }

                foreach (DataRow row in jadwalShift.Rows)
                {
                    row["Button"] = "Presensi";
                }

                dgvPresensi.DataSource = jadwalShift;

                // Menambahkan kolom Button
                if (!dgvPresensi.Columns.Contains("Button"))
                {
                    DataGridViewButtonColumn buttonColumn = new DataGridViewButtonColumn
                    {
                        Name = "Button",
                        HeaderText = "Aksi",
                        Text = "Presensi",
                        UseColumnTextForButtonValue = true
                    };
                    dgvPresensi.Columns.Add(buttonColumn);
                }
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

                // Cek apakah presensi sudah dilakukan
                if (PresensiContext.IsPresensiExist(idAkun, idShift))
                {
                    MessageBox.Show($"Anda sudah melakukan presensi untuk shift hari {hari}.", "Presensi", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
    }
}
