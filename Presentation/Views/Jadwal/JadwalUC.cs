using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBOBarberMate.Presentation.Views.Jadwal
{
    using PBOBarberMate.App.Services;
    using PBOBarberMate.Core.Common;
    using PBOBarberMate.Core.Entities;
    using PBOBarberMate.Core.Enums;
    using PBOBarberMate.Core.Interfaces;
    using PBOBarberMate.Presentation.Views.Inventory;

    public partial class JadwalUC : UserControl, IPageFeature
    {
        public string PageTitle => "Daftar Inventory";
        private readonly JadwalService _service;
        private readonly INavigationService _nav;

        public JadwalUC(JadwalService service, INavigationService nav)
        {
            InitializeComponent();

            _service = service;
            _nav = nav;

            SetupUI();
            LoadDataToGrid();


        }

        private void SetupUI()
        {
            // hide kiat selain admin
            if (SessionService.CurrentUser.IdRole != (int)UserRole.Admin) lblKiat.Visible = false;
            // hide btn presensi sekarang selain karyawan
            if (SessionService.CurrentUser.IdRole != (int)UserRole.Karyawan) { btnPresensi.Visible = false; pictbxAdd.Visible = false; }

        }
        private void LoadDataToGrid()
        {
            var result = _service.AmbilMatriksJadwal();
            if (result.IsSuccess)
            {
                dgvJadwal.DataSource = null;
                dgvJadwal.DataSource = result.Data;
                dgvJadwal.Columns["IdAkun"].Visible = false; // Sembunyikan ID
                dgvJadwal.Columns["Nama Karyawan"].ReadOnly = true;
                dgvJadwal.Columns["Nama Karyawan"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                string[] namaHari = { "Minggu", "Senin", "Selasa", "Rabu", "Kamis", "Jumat", "Sabtu" };
                foreach (string hari in namaHari)
                {
                    if (dgvJadwal.Columns.Contains(hari))
                    {
                        dgvJadwal.Columns[hari].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                        dgvJadwal.Columns[hari].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    }
                }
            }
            else
            {
                MessageBox.Show(result.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnPresensi_Click(object sender, EventArgs e)
        {
            //    try
            //    {
            //        M_Shift shift = _shiftService.getShiftbyIdKaryawan(_commonServices.SessionServiceInstance.CurrentUserId);
            //        if (shift != null)
            //        {
            //            M_Presensi presensi = _presensiService.getPresensiByIdKaryawan(_commonServices.SessionServiceInstance.CurrentUserId);
            //            if (presensi == null)
            //            {
            //                bool berhasil = _presensiService.addPresensi(_commonServices.SessionServiceInstance.CurrentUserId);
            //                if (berhasil)
            //                {
            //                    MessageBox.Show("Data presensi berhasil diperbarui!");
            //                }
            //                else
            //                {
            //                    MessageBox.Show("Terjadi Kesalahan, silahkan coba lagi!");
            //                }
            //            }
            //            else
            //            {
            //                MessageBox.Show("Anda sudah presensi hari ini!");
            //            }
            //        }
            //        else
            //        {
            //            MessageBox.Show("Anda tidak ada jadwal shift hari ini!");
            //        }
            //    }
            //    catch (Exception ex)
            //    {
            //        MessageBox.Show($"Terjadi kesalahan saat menambahkan: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    }
            //    finally
            //    {
            //        this.LoadDgvShift();
            //    }
            //}
        }

        private void dgvJadwal_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // hanya admin yang bisa cell click
            if (SessionService.CurrentUser.IdRole != (int)UserRole.Admin) return;
            // jika bukan kolom hari maka batalkan
            string[] daftarHari = { "Minggu", "Senin", "Selasa", "Rabu", "Kamis", "Jumat", "Sabtu" };
            string colName = dgvJadwal.Columns[e.ColumnIndex].Name;
            if (!daftarHari.Contains(colName))
            {
                return;
            }
            // locate data
            var row = dgvJadwal.Rows[e.RowIndex];
            string nama = row.Cells["Nama Karyawan"].Value.ToString();
            string hari = dgvJadwal.Columns[e.ColumnIndex].Name;
            // show dialog
            using (var dialog = new FormPilihanStatus(nama, hari))
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    int idAkun = (int)row.Cells["IdAkun"].Value;
                    int hariIndex = Array.IndexOf(daftarHari, hari);

                    M_Jadwal jadwal = new M_Jadwal()
                    {
                        IdJadwal = $"{idAkun}_{hariIndex}",
                        IdAkun = idAkun,
                        Hari = hariIndex,
                        IsActive = dialog.IsActiveResult,
                        IsTersedia = dialog.IsTersediaResult
                    };
                    Result<bool> result = _service.ToggleStatusKerja(jadwal);
                    if (result.IsSuccess)
                    {
                        MessageBox.Show(result.Message);
                        //redirect ke JadwalUC
                        _nav.LoadFitur(new JadwalUC(_service, _nav));
                    }
                    else
                    {
                        MessageBox.Show(result.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                };
            };
        }

        private void dgvJadwal_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 2) return;

            string colName = dgvJadwal.Columns[e.ColumnIndex].Name;
            string[] namaHari = { "Minggu", "Senin", "Selasa", "Rabu", "Kamis", "Jumat", "Sabtu" };
            string hariIni = namaHari[(int)DateTime.Now.DayOfWeek];

            int currentLoggedId = SessionService.CurrentUser.IdAkun;
            int rowUserId = (int)dgvJadwal.Rows[e.RowIndex].Cells["IdAkun"].Value;

            bool isHariIni = colName == hariIni;
            bool isBarisUserLogin = rowUserId == currentLoggedId;
            string val = e.Value?.ToString(); // mengambil nama kolom
            bool isLibur = val == "Libur";

            // reset warna
            e.CellStyle.Font = dgvJadwal.Font;
            e.CellStyle.ForeColor = Color.Black;
            // pewarnaan
            if (isBarisUserLogin)
            {
                // sel hari ini + logged = hijau
                if (isHariIni)
                {
                    e.CellStyle.BackColor = Color.LightGreen;
                    e.CellStyle.Font = new Font(dgvJadwal.Font, FontStyle.Bold);
                }
                // baris hari lain logged = hijau pudar
                else
                {
                    e.CellStyle.BackColor = Color.FromArgb(210, 245, 210);
                }
                // sel libur logged = merah
                if (val == "Libur") e.CellStyle.ForeColor = Color.DarkRed;
            }
            else if (isHariIni)
            {
                // kolom hari ini = biru
                e.CellStyle.BackColor = Color.AliceBlue;
            }
            else
            {
                // unlogged libur = gray
                if (val == "Libur")
                {
                    e.CellStyle.BackColor = Color.FromArgb(240, 240, 240);
                    e.CellStyle.ForeColor = Color.Gray;
                }
                // unlogged sibuk = krem
                else if (val == "Sibuk/Tidak di tempat")
                {
                    e.CellStyle.BackColor = Color.Cornsilk; 
                }
                // unlogged tersedia = white
                else // Tersedia
                {
                    e.CellStyle.BackColor = Color.White;
                }
            }
        }
    }
}