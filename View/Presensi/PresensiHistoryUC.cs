
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
        private readonly CommonAppServices _commonServices;
        private readonly CommonAdminServices _commonAdminServices;
        private readonly CommonKaryawanServices _commonKaryawanServices;

        private readonly PresensiService _presensiService;


        public PresensiHistoryUC(CommonAppServices commonService, CommonKaryawanServices commonKaryawanService)
        {
            InitializeComponent();
            _commonServices = commonService;
            _commonKaryawanServices = commonKaryawanService;
            _presensiService = commonKaryawanService.PresensiServiceInstance;
            this.Load += PresensiHistoryUC_Load;
        }
        public PresensiHistoryUC(CommonAppServices commonService, CommonAdminServices commonAdminService)
        {
            InitializeComponent();
            _commonServices = commonService;
            _presensiService = commonAdminService.PresensiServiceInstance;
            this.Load += PresensiHistoryUC_Load;
        }

        private void PresensiHistoryUC_Load(object sender, EventArgs e)
        {
            try
            {
                // default pilih sebukan ini
                var start = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
                var end = start.AddMonths(1);
                LoadDgvPresensi(_commonServices.SessionServiceInstance.CurrentUserId, start, end);
                // rapikan ui label
                AdjustLabelShow(lblNamaKaryawan, _commonServices.SessionServiceInstance.CurrentUserName);
                AdjustLabelShow(lblTanggalRange, $"{start.ToString("dd MMM yyyy")} - {end.ToString("dd MMM yyyy")}");
            }

            catch (Exception ex)
            {
                MessageBox.Show($"Error loading shift data: {ex.Message}");
            }
        }
        private void AdjustLabelShow(Control c, string text)
        {
            int right = c.Right;    // cari right
            c.Text = text;          // ubah teks
            c.Left = right - c.Width;   // ubah x
        }
        private void LoadDgvPresensi(int userId, DateTime start, DateTime end)
        {
            
            List<M_Presensi> presensis = _presensiService.getPresensiByIdKaryawan(userId, start, end);

            dgvPresensi.Columns.Clear();

            // kolom dengan header kustom
            dgvPresensi.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "ID Presensi",
                DataPropertyName = "id_presensi",
                Name = "colIdPresensi"
            });
            dgvPresensi.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "ID Karyawan",
                DataPropertyName = "id_akun",
                Name = "colIdAkun"
            });
            dgvPresensi.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "ID Shift",
                DataPropertyName = "id_shift",
                Name = "colIdShift"
            });
            dgvPresensi.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Waktu Presensi",
                DataPropertyName = "waktu_presensi",
                Name = "colWaktuPresensi"
            });

            dgvPresensi.DataSource = presensis;
            dgvPresensi.AutoGenerateColumns = false;
            dgvPresensi.RowHeadersVisible = false;
            dgvPresensi.AllowUserToAddRows = false;

            

            //// Kolom Ubah
            //if (dgvInventaris.Columns["btnUbah"] == null)
            //{
            //    DataGridViewButtonColumn btnUbah = new DataGridViewButtonColumn();
            //    btnUbah.Name = "btnUbah";
            //    btnUbah.HeaderText = "Ubah";
            //    btnUbah.Text = "Ubah";
            //    btnUbah.UseColumnTextForButtonValue = true;
            //    dgvInventaris.Columns.Add(btnUbah);
            //}
            //// Kolom Hapus
            //if (dgvInventaris.Columns["btnHapus"] == null)
            //{
            //    DataGridViewButtonColumn btnHapus = new DataGridViewButtonColumn();
            //    btnHapus.Name = "btnHapus";
            //    btnHapus.HeaderText = "Hapus";
            //    btnHapus.Text = "Hapus";
            //    btnHapus.UseColumnTextForButtonValue = true;
            //    dgvInventaris.Columns.Add(btnHapus);
            //}
        }
        private void LoadJadwalShift()
        {
            try
            {
                ////DataTable jadwalShift = PresensiContext.GetJadwalShiftKaryawan(idAkun);
                ////if (jadwalShift.Columns.Contains("waktu_presensi") && jadwalShift.Columns["waktu_presensi"].ReadOnly)
                ////{
                ////    jadwalShift.Columns["waktu_presensi"].ReadOnly = false;
                ////}


                ////for (int i = 0; i < jadwalShift.Rows.Count; i++)
                ////{
                ////    DataRow row = jadwalShift.Rows[i];
                ////    object waktuPresensi = row["waktu_presensi"];

                ////    // Jika waktu_presensi bernilai DBNull, biarkan kosong
                ////    if (waktuPresensi == DBNull.Value)
                ////    {
                ////        row["waktu_presensi"] = DBNull.Value; // Tetap kosong

                ////    }
                ////}


                ////dgvPresensi.DataSource = jadwalShift;

                //if (dgvPresensi.Columns.Contains("id_shift"))
                //{
                //    dgvPresensi.Columns["id_shift"].Visible = false;
                //}

                //dgvPresensi.DefaultCellStyle.ForeColor = Color.Black; // Warna teks

                //// Menambahkan kolom Button
                //if (!dgvPresensi.Columns.Contains("Button"))
                //{
                //    DataGridViewButtonColumn buttonColumn = new DataGridViewButtonColumn
                //    {
                //        Name = "Button",
                //        HeaderText = "Presensi",
                //        Text = "Presensi Sekarang",
                //        UseColumnTextForButtonValue = true
                //    };
                //    dgvPresensi.Columns.Add(buttonColumn);
                //}
                //dgvPresensi.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                //// membuat size kolom menjadi rata danmemenuhi tabel

                //// membuat tabel responsif berdasarkan isi data
                //foreach (DataGridViewColumn column in dgvPresensi.Columns)
                //{
                //    column.Width = dgvPresensi.Width / dgvPresensi.Columns.Count;
                //}
                //dgvPresensi.AllowUserToAddRows = false;
                //dgvPresensi.AllowUserToResizeColumns = false;
                //dgvPresensi.AllowUserToResizeRows = false;
                //dgvPresensi.RowHeadersVisible = false;
                //dgvPresensi.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saat memuat jadwal shift: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
