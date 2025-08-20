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
using PBOBarberMate.App.Utils;
using PBOBarberMate.View.Auth;


namespace PBOBarberMate.View.Shift
{
    public partial class ShiftUC : UserControl
    {
        private readonly CommonAppServices _commonServices;
        private readonly CommonAdminServices _commonAdminServices;
        private readonly CommonKaryawanServices _commonKaryawanServices;
        private readonly ShiftService _shiftService;
        private readonly PresensiService _presensiService;
        private List<M_Jadwal> jadwalList;


        public ShiftUC(CommonAppServices commonService, CommonAdminServices commonAdminServices)
        {
            InitializeComponent();

            _commonServices = commonService;
            _commonAdminServices = commonAdminServices;
            _shiftService = commonAdminServices.ShiftServiceInstance;
            _presensiService = commonAdminServices.PresensiServiceInstance;

            // hide kiat selain admin
            if (!(_commonServices.SessionServiceInstance.CurrentUserRole == AkunRole.admin)) { lblKiat.Visible = false; }
            // hide btn presensi sekarang selain karyawan
            if (!(_commonServices.SessionServiceInstance.CurrentUserRole == AkunRole.karyawan)) { btnPresensi.Visible = false; pictbxAdd.Visible = false; }
        }   
        public ShiftUC(CommonAppServices commonService, CommonKaryawanServices commonKaryawanService)
        {
            InitializeComponent();

            _commonServices = commonService;
            _commonKaryawanServices = commonKaryawanService;
            _shiftService = commonKaryawanService.ShiftServiceInstance;
            _presensiService = commonKaryawanService.PresensiServiceInstance;

            // hide kiat karena bukan admin
            if (!(_commonServices.SessionServiceInstance.CurrentUserRole == AkunRole.admin)) { lblKiat.Visible = false; }
        }

        private void FormShift_Load(object sender, EventArgs e)
        {
            try
            {
                LoadDgvShift();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading shift data: {ex.Message}");
            }
        }
        private void LoadDgvShift()
        {
            dgvShift.AutoGenerateColumns = false;
            dgvShift.Columns.Clear();
            CreateCustomColumns();

            dgvShift.RowHeadersVisible = false;
            dgvShift.AllowUserToAddRows = false;
            dgvShift.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            if (dgvShift.Columns.Count > 0)
            {
                dgvShift.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }

            // sortir id bersangkutan diatas untuk logged in karyawan
            var allJadwal = _shiftService.getAllShift();
            var currentUser = _commonServices.SessionServiceInstance.CurrentUserId;

            jadwalList = allJadwal
                .OrderByDescending(j => j.id_akun == currentUser)
                .ToList();


            // Binding ke DataGridView
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = jadwalList;
            dgvShift.DataSource = bindingSource;


        }
        private void CreateCustomColumns()
        {

            // Kolom Nama Karyawan
            dgvShift.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "NamaKaryawan",
                HeaderText = "Nama Karyawan",
                DataPropertyName = nameof(M_Jadwal.nama_karyawan),
                ReadOnly = true
            });
            // Kolom Shift untuk setiap hari
            AddShiftColumn("ShiftSenin", "Senin", nameof(M_Jadwal.id_shift_senin));
            AddShiftColumn("ShiftSelasa", "Selasa", nameof(M_Jadwal.id_shift_selasa));
            AddShiftColumn("ShiftRabu", "Rabu", nameof(M_Jadwal.id_shift_rabu));
            AddShiftColumn("ShiftKamis", "Kamis", nameof(M_Jadwal.id_shift_kamis));
            AddShiftColumn("ShiftJumat", "Jumat", nameof(M_Jadwal.id_shift_jumat));
            AddShiftColumn("ShiftSabtu", "Sabtu", nameof(M_Jadwal.id_shift_sabtu));
            AddShiftColumn("ShiftMinggu", "Minggu", nameof(M_Jadwal.id_shift_minggu));
        }

        private void AddShiftColumn(string name, string header, string dataProperty)
        {
            dgvShift.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = name,
                HeaderText = header,
                DataPropertyName = dataProperty,
                ReadOnly = true
            });
        }
        private void dgvShift_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex < 0 || e.RowIndex >= jadwalList.Count) return;

            var jadwal = jadwalList[e.RowIndex];
            var currentUserId = _commonServices.SessionServiceInstance.CurrentUserId;
            string namaKolomHariIni = GetColumnNameForToday();
            var colName = dgvShift.Columns[e.ColumnIndex].Name;

            if (colName == "NamaKaryawan")
            {
                e.Value = jadwal.nama_karyawan ?? "???";
                e.FormattingApplied = true;
            }
            else if (colName.StartsWith("Shift"))
            {
                int shiftId = colName switch
                {
                    "ShiftSenin" => jadwal.id_shift_senin,
                    "ShiftSelasa" => jadwal.id_shift_selasa,
                    "ShiftRabu" => jadwal.id_shift_rabu,
                    "ShiftKamis" => jadwal.id_shift_kamis,
                    "ShiftJumat" => jadwal.id_shift_jumat,
                    "ShiftSabtu" => jadwal.id_shift_sabtu,
                    "ShiftMinggu" => jadwal.id_shift_minggu,
                    _ => 0
                };

                e.Value = (shiftId != 0) ? "Ada" : "-";
                e.FormattingApplied = true;
            }

            bool isHariIni = colName == namaKolomHariIni;
            bool isBarisUserLogin = jadwal.id_akun == currentUserId;

            if (isHariIni && isBarisUserLogin)
            {
                // sel milik user logged dan kolom hari ini
                e.CellStyle.BackColor = Color.GreenYellow;
            }
            else if (isHariIni)
            {
                // kolom hari ini
                e.CellStyle.BackColor = Color.LightBlue;
            }
            else if (isBarisUserLogin)
            {
                // baris user logged in
                e.CellStyle.BackColor = Color.LightGreen;
            }
        }

        private string GetColumnNameForToday()
        {
            return DateTime.Today.DayOfWeek switch
            {
                DayOfWeek.Monday => "ShiftSenin",
                DayOfWeek.Tuesday => "ShiftSelasa",
                DayOfWeek.Wednesday => "ShiftRabu",
                DayOfWeek.Thursday => "ShiftKamis",
                DayOfWeek.Friday => "ShiftJumat",
                DayOfWeek.Saturday => "ShiftSabtu",
                DayOfWeek.Sunday => "ShiftMinggu",
                _ => ""
            };
        }

        private void dgvShift_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // hanya admin yang bis add & delete
            if (!(_commonServices.SessionServiceInstance.CurrentUserRole == AkunRole.admin)) { return; }
            // cek index valid
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                var jadwal = jadwalList[e.RowIndex]; // data asli 
                var columnName = dgvShift.Columns[e.ColumnIndex].Name; // Nama kolom

                int idShift = columnName switch
                {
                    "ShiftSenin" => jadwal.id_shift_senin,
                    "ShiftSelasa" => jadwal.id_shift_selasa,
                    "ShiftRabu" => jadwal.id_shift_rabu,
                    "ShiftKamis" => jadwal.id_shift_kamis,
                    "ShiftJumat" => jadwal.id_shift_jumat,
                    "ShiftSabtu" => jadwal.id_shift_sabtu,
                    "ShiftMinggu" => jadwal.id_shift_minggu,
                    _ => -1 // Nilai default jika kolom tidak dikenali
                };
                int idHari = columnName switch
                {
                    "ShiftSenin" => 1,
                    "ShiftSelasa" => 2,
                    "ShiftRabu" => 3,
                    "ShiftKamis" => 4,
                    "ShiftJumat" => 5,
                    "ShiftSabtu" => 6,
                    "ShiftMinggu" => 7,
                    _ => -1 // Nilai default jika kolom tidak dikenali
                };

                if (idShift == -1 || idHari == -1)
                {
                    return;
                }
                // Jika ID Shift == 0, tambahkan shift baru
                if (idShift == 0)
                {
                    DialogResult result = MessageBox.Show(
                        $"Anda yakin menambahkan '{columnName}' untuk '{jadwal.nama_karyawan}'?",
                        "Tambahkan Shift Baru",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question
                    );
                    if (result == DialogResult.Yes)
                    {
                        try
                        {
                            bool success = _shiftService.addShift(jadwal.id_akun, idHari);
                            if (success)
                            {
                                MessageBox.Show($"Shift '{jadwal.nama_karyawan} - {columnName}' berhasil ditambahkan.", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("Gagal menambah shift.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Terjadi kesalahan saat menambahkan: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        finally
                        {
                            _commonServices.MainAppInstance.LoadFeatureIntoActiveHomepageContent(new ShiftUC(_commonServices, _commonAdminServices), "Shift");
                        }
                    }
                }
                // jika id ada maka hapus
                else
                {
                    DialogResult result = MessageBox.Show(
                        $"Anda yakin menghapus '{columnName}' untuk '{jadwal.nama_karyawan}'?",
                        "Hapus Shift",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question
                    );
                    if (result == DialogResult.Yes)
                    {
                        try
                        {
                            bool success = _shiftService.deleteShift(idShift);
                            if (success)
                            {
                                MessageBox.Show("Shift berhasil dihapus.", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("Gagal menghapus shift.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Terjadi kesalahan saat menghapus: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        finally
                        {
                            //_commonServices.MainAppInstance.LoadFeatureIntoActiveHomepageContent(new ShiftUC(_commonServices, _commonAdminServices.ShiftServiceInstance, _commonAdminServices.PresensiServiceInstance, _commonAdminServices), "Shift");
                            this.LoadDgvShift();
                        }
                    }
                }
            }
        }

        private void btnPresensi_Click(object sender, EventArgs e)
        {
            try
            {
                M_Shift shift = _shiftService.getShiftbyIdKaryawan(_commonServices.SessionServiceInstance.CurrentUserId);
                if (shift != null)
                {
                    M_Presensi presensi = _presensiService.getPresensiById(_commonServices.SessionServiceInstance.CurrentUserId);
                    if (presensi == null)
                    {
                        bool berhasil = _presensiService.addPresensi(_commonServices.SessionServiceInstance.CurrentUserId);
                        if (berhasil)
                        {
                            MessageBox.Show("Data presensi berhasil diperbarui!");
                        }
                        else
                        {
                            MessageBox.Show("Terjadi Kesalahan, silahkan coba lagi!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Anda sudah presensi hari ini!");
                    }
                }
                else
                {
                    MessageBox.Show("Anda tidak ada jadwal shift hari ini!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Terjadi kesalahan saat menambahkan: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                this.LoadDgvShift();
            }
        }
    }
}
