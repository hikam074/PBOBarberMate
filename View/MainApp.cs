using System;
using System.Windows.Forms;
using PBOBarberMate.App.Services; // Untuk AkunService dan SessionService
using PBOBarberMate.App.Repository; // Untuk AkunRepository
using PBOBarberMate.App.Model;     // Untuk AkunRole

using PBOBarberMate.View.Homepages; 
using PBOBarberMate.View.Auth;


namespace PBOBarberMate.View // Namespace disesuaikan
{
    // Menggunakan nama 'MainApp' sesuai preferensi Anda
    public partial class MainApp : Form
    {
        // Instansi Service Layer yang akan digunakan di seluruh aplikasi
        // Dibuat 'readonly' dan diinisialisasi sekali di konstruktor
        private readonly AkunRepository _akunRepository;
        private readonly SessionService _sessionService;
        private readonly AkunService _akunService;

        // Panel tunggal yang akan menampung semua UserControl utama
        private System.Windows.Forms.Panel _contentHostPanel;

        public MainApp()
        {
            InitializeComponent(); // Ini akan menginisialisasi _contentHostPanel dari desainer

            // Inisialisasi Service Layer
            _akunRepository = new AkunRepository();
            _sessionService = new SessionService();
            _akunService = new AkunService(_akunRepository, _sessionService);

            // Inisialisasi _contentHostPanel di sini jika tidak dari desainer
            // Atau pastikan properti this.Controls.Add(this.mainContentPanel); sudah ada
            _contentHostPanel = new Panel();
            _contentHostPanel.Dock = DockStyle.Fill;
            this.Controls.Add(_contentHostPanel);


            // Muat LoginUC sebagai tampilan awal
            this.LoadContent(new LoginUC(_akunService, _sessionService, this));
        }

        // Memuat UserControl baru sebagai konten utama ke dalam contentHostPanel.
        public void LoadContent(UserControl contentUC)
        {
            _contentHostPanel.Controls.Clear(); // Bersihkan panel dari konten sebelumnya
            contentUC.Dock = DockStyle.Fill;   // Pastikan UserControl mengisi seluruh panel
            _contentHostPanel.Controls.Add(contentUC);
        }

        // Mengarahkan pengguna ke halaman beranda (dashboard) yang sesuai berdasarkan role sesi.
        public void RedirectToHomepage()
        {
            AkunRole? userRole = _sessionService.CurrentUserRole;

            if (userRole == AkunRole.admin)
            {
                LoadContent(new HomepageAdminUC(_akunService, _sessionService, this));
            }
            else if (userRole == AkunRole.karyawan)
            {
                //LoadContent(new HomepageKaryawanUC(_akunService, _sessionService, this));
            }
            else if (userRole == AkunRole.customer)
            {
                //LoadContent(new HomepageCustomerUC(_akunService, _sessionService, this));
            }
            else
            {
                MessageBox.Show("Role pengguna tidak dikenal atau sesi tidak valid.", "Error Redirect", MessageBoxButtons.OK, MessageBoxIcon.Error);
                _akunService.Logout(); // Pastikan sesi dibersihkan
                LoadContent(new LoginUC(_akunService, _sessionService, this)); // Kembali ke login
            }
        }

        // Metode getter untuk Service Layer, agar bisa diakses oleh UserControl yang dimuat
        public AkunService GetAkunService() => _akunService;
        public SessionService GetSessionService() => _sessionService;

        // Mungkin Anda perlu juga getters untuk Repository jika ada service lain
        // public AkunRepository GetAkunRepository() => _akunRepository;
    }
}