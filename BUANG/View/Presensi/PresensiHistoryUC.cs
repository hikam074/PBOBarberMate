//using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
//using System.Drawing;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Windows.Forms;
//using System.Globalization;
//using Microsoft.VisualBasic.ApplicationServices;
//using static System.Net.Mime.MediaTypeNames;
//using PBOBarberMate.BUANG.App.Model;
//using PBOBarberMate.BUANG.App.Services;

//namespace PBOBarberMate.View.Presensi
//{
//    public partial class PresensiHistoryUC : UserControl
//    {
//        private readonly CommonAppServices _commonServices;
//        private readonly CommonAdminServices _commonAdminServices;
//        private readonly CommonKaryawanServices _commonKaryawanServices;

//        private readonly PresensiService _presensiService;

//        // cache control
//        private List<M_Presensi> _presensiListCache;
//        private Dictionary<DateTime, List<M_Presensi>> _presensiDictByDate;
//        private DateTime _currentStart;
//        private DateTime _currentEnd;
//        private int _currentUserId;
//        private List<Panel> _calendarCells = new();
//        private List<Panel> _calendarHeaders = new();
//        private int _calendarRows;



//        public PresensiHistoryUC(CommonAppServices commonService, CommonKaryawanServices commonKaryawanService)
//        {
//            InitializeComponent();
//            _commonServices = commonService;
//            _commonKaryawanServices = commonKaryawanService;
//            _presensiService = commonKaryawanService.PresensiServiceInstance;
//            // default pilih sebukan ini
//            var start = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
//            var end = start.AddMonths(1);
//            _currentStart = start;
//            _currentEnd = end;
//            _currentUserId = _commonServices.SessionServiceInstance.CurrentUserId;

//            this.Load += PresensiHistoryUC_Load;
//        }
//        public PresensiHistoryUC(CommonAppServices commonService, CommonAdminServices commonAdminService)
//        {
//            InitializeComponent();
//            _commonServices = commonService;
//            _presensiService = commonAdminService.PresensiServiceInstance;


//            this.Load += PresensiHistoryUC_Load;
//        }

//        private void PresensiHistoryUC_Load(object sender, EventArgs e)
//        {
//            try
//            {
//                fetchData(_currentUserId,_currentStart,_currentEnd);

//                LoadDgvPresensi(_currentUserId, _currentStart, _currentEnd);

//                BuildCalendarStructure();

//                // rapikan ui label
//                AdjustLabelShow(lblNamaKaryawan, _commonServices.SessionServiceInstance.CurrentUserName);
//                AdjustLabelShow(lblTanggalRange, $"{_currentStart.ToString("dd MMM yyyy")} - {_currentEnd.ToString("dd MMM yyyy")}");
//            }

//            catch (Exception ex)
//            {
//                MessageBox.Show($"Error loading shift data: {ex.Message}");
//            }
//        }
//        private void AdjustLabelShow(Control c, string text)
//        {
//            int right = c.Right;    // cari right
//            c.Text = text;          // ubah teks
//            c.Left = right - c.Width;   // ubah x
//        }
//        private void fetchData(int userId, DateTime start, DateTime end)
//        {
//            _currentStart = start;
//            _currentEnd = end;

//            _presensiListCache = _presensiService.getPresensiByIdKaryawan(userId, start, end);

//            _presensiDictByDate = _presensiListCache
//                .GroupBy(p => p.waktu_presensi.Date)
//                .ToDictionary(g => g.Key, g => g.ToList());
//        }
//        private void BuildCalendarStructure()
//        {
//            flpCalendar.SuspendLayout();
//            flpCalendar.Controls.Clear();
//            flpCalendar.Padding = new Padding(0);

//            _calendarCells.Clear();
//            _calendarHeaders.Clear();

//            int columns = 7;

//            DateTime firstDay = new DateTime(_currentStart.Year, _currentStart.Month, 1);
//            int startColumn = (int)firstDay.DayOfWeek; // Minggu = 0
//            int daysInMonth = DateTime.DaysInMonth(_currentStart.Year, _currentStart.Month);

//            // hitung total cell & baris kalender
//            int totalCells = startColumn + daysInMonth;
//            _calendarRows = (int)Math.Ceiling(totalCells / 7.0) + 1; // 1 untuk header

//            string[] dayNames = { "Minggu", "Senin", "Selasa", "Rabu", "Kamis", "Jumat", "Sabtu" };

//            foreach (var day in dayNames)
//            {
//                var header = CreateDayHeader(day, 0, 0, 0);
//                _calendarHeaders.Add(header);
//                flpCalendar.Controls.Add(header);
//            }

//            // === OFFSET ===
//            for (int i = 0; i < startColumn; i++)
//            {
//                var empty = CreateEmptyDay(0, 0, 0);
//                _calendarCells.Add(empty);
//                flpCalendar.Controls.Add(empty);
//            }

//            // === DAY PANELS ===
//            for (int day = 1; day <= daysInMonth; day++)
//            {
//                DateTime date = new DateTime(_currentStart.Year, _currentStart.Month, day);
//                _presensiDictByDate.TryGetValue(date, out var presensi);

//                var panel = CreateDayPanel(date, presensi, 0, 0, 0);
//                _calendarCells.Add(panel);
//                flpCalendar.Controls.Add(panel);
//            }

//            flpCalendar.ResumeLayout();
//            UpdateCalendarLayout();//
//        }
//        private void UpdateCalendarLayout()
//        {
//            if (_calendarCells.Count == 0)
//                return;

//            int columns = 7;
//            int gap = 3;

//            int cellWidth = (flpCalendar.ClientSize.Width / columns) - (gap * 2);
//            int cellHeight = (flpCalendar.ClientSize.Height / _calendarRows) - (gap * 2);

//            flpCalendar.SuspendLayout();

//            foreach (var header in _calendarHeaders)
//            {
//                header.Width = cellWidth;
//                header.Height = cellHeight;
//                header.Margin = new Padding(gap);
//            }

//            foreach (var cell in _calendarCells)
//            {
//                cell.Width = cellWidth;
//                cell.Height = cellHeight;
//                cell.Margin = new Padding(gap);
//            }

//            flpCalendar.ResumeLayout();
//        }

//        Panel CreateEmptyDay(int width, int height, int gap)
//        {
//            return new Panel
//            {
//                Width = width,
//                Height = height,
//                Margin = new Padding(gap)
//            };
//        }
//        Control CreatePresensiLabel(M_Presensi p)
//        {
//            return new Label
//            {
//                AutoSize = true,
//                Text = $"{p.waktu_presensi:HH:mm}",
//                Font = new System.Drawing.Font("Segoe UI", 8),
//                ForeColor = Color.DarkGreen,
//                Margin = new Padding(2, 1, 2, 1)
//            };
//        }
//        Panel CreateDayPanel(DateTime date, List<M_Presensi> presensi, int width, int height, int gap)
//        {
//            Panel p = new Panel
//            {
//                Width = width,
//                Height = height,
//                BorderStyle = BorderStyle.FixedSingle,
//                Margin = new Padding(gap),
//                Tag = presensi
//            };

//            Label lblDate = new Label
//            {
//                Text = date.Day.ToString(),
//                Dock = DockStyle.Top,
//                Height = 22,
//                TextAlign = ContentAlignment.MiddleRight,
//                Font = new System.Drawing.Font("Segoe UI", 9, FontStyle.Bold)
//            };

//            FlowLayoutPanel flp = new FlowLayoutPanel
//            {
//                Dock = DockStyle.Fill,
//                FlowDirection = FlowDirection.TopDown,
//                WrapContents = false,
//                AutoScroll = true
//            };

//            if (presensi != null)
//            {
//                foreach (var pr in presensi)
//                    flp.Controls.Add(CreatePresensiLabel(pr));
//            }

//            p.Controls.Add(flp);
//            p.Controls.Add(lblDate);

//            return p;
//        }
//        private Panel CreateDayHeader(string dayName, int width, int height, int gap)
//        {
//            return new Panel
//            {
//                Width = width,
//                Height = height,
//                Margin = new Padding(gap),
//                BackColor = Color.FromArgb(240, 240, 240),
//                Controls =
//        {
//            new Label
//            {
//                Text = dayName,
//                Dock = DockStyle.Fill,
//                TextAlign = ContentAlignment.MiddleCenter,
//                Font = new System.Drawing.Font("Segoe UI", 9, FontStyle.Bold)
//            }
//        }
//            };
//        }

//        private void LoadDgvPresensi(int userId, DateTime start, DateTime end)
//        {
//            List<M_Presensi> presensis = _presensiService.getPresensiByIdKaryawan(userId, start, end);

//            dgvPresensi.Columns.Clear();

//            // kolom dengan header kustom
//            dgvPresensi.Columns.Add(new DataGridViewTextBoxColumn
//            {
//                HeaderText = "ID Presensi",
//                DataPropertyName = "id_presensi",
//                Name = "colIdPresensi"
//            });
//            dgvPresensi.Columns.Add(new DataGridViewTextBoxColumn
//            {
//                HeaderText = "ID Karyawan",
//                DataPropertyName = "id_akun",
//                Name = "colIdAkun"
//            });
//            dgvPresensi.Columns.Add(new DataGridViewTextBoxColumn
//            {
//                HeaderText = "ID Shift",
//                DataPropertyName = "id_shift",
//                Name = "colIdShift"
//            });
//            dgvPresensi.Columns.Add(new DataGridViewTextBoxColumn
//            {
//                HeaderText = "Waktu Presensi",
//                DataPropertyName = "waktu_presensi",
//                Name = "colWaktuPresensi"
//            });

//            dgvPresensi.DataSource = presensis;
//            dgvPresensi.AutoGenerateColumns = false;
//            dgvPresensi.RowHeadersVisible = false;
//            dgvPresensi.AllowUserToAddRows = false;



//            //// Kolom Ubah
//            //if (dgvInventaris.Columns["btnUbah"] == null)
//            //{
//            //    DataGridViewButtonColumn btnUbah = new DataGridViewButtonColumn();
//            //    btnUbah.Name = "btnUbah";
//            //    btnUbah.HeaderText = "Ubah";
//            //    btnUbah.Text = "Ubah";
//            //    btnUbah.UseColumnTextForButtonValue = true;
//            //    dgvInventaris.Columns.Add(btnUbah);
//            //}
//            //// Kolom Hapus
//            //if (dgvInventaris.Columns["btnHapus"] == null)
//            //{
//            //    DataGridViewButtonColumn btnHapus = new DataGridViewButtonColumn();
//            //    btnHapus.Name = "btnHapus";
//            //    btnHapus.HeaderText = "Hapus";
//            //    btnHapus.Text = "Hapus";
//            //    btnHapus.UseColumnTextForButtonValue = true;
//            //    dgvInventaris.Columns.Add(btnHapus);
//            //}
//        }
//        private void flpCalendar_SizeChanged(object sender, EventArgs e)
//        {
//            UpdateCalendarLayout();
//        }
//    }
//}
