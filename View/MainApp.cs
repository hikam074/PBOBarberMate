using System;
using System.Windows.Forms;

using PBOBarberMate.App.Services; 
using PBOBarberMate.App.Repository; 
using PBOBarberMate.App.Model;    

using PBOBarberMate.View.Homepages; 
using PBOBarberMate.View.Auth;


namespace PBOBarberMate.View
{
    public partial class MainApp : Form
    {
        // Instansi Service Layer yang akan digunakan di seluruh aplikasi
        private readonly AkunRepository _akunRepository;
        private readonly SessionService _sessionService;
        private readonly AkunService _akunService;

        // Panel tunggal yang akan menampung semua UserControl utama
        private System.Windows.Forms.Panel _contentHostPanel;

        public MainApp()
        {
            InitializeComponent();

            _contentHostPanel = mainContentPanel;

            // Inisialisasi Service Layer
            _akunRepository = new AkunRepository();
            _sessionService = new SessionService();
            _akunService = new AkunService(_akunRepository, _sessionService);

            // Muat LoginUC sebagai tampilan awal
            this.LoadContent(new LoginUC(_akunService, _sessionService, this));
        }

        // Memuat UserControl baru sebagai konten utama ke dalam contentHostPanel.
        public void LoadContent(UserControl contentUC)
        {
            _contentHostPanel.Controls.Clear(); // Bersihkan panel dari konten sebelumnya
            contentUC.Dock = DockStyle.Fill;   // Pastikan UserControl mengisi seluruh panel
            mainContentPanel.Controls.Add(contentUC);
        }

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