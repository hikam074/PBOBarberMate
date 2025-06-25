using System;
using System.Drawing;
using System.Windows.Forms;

using PBOBarberMate.App.Services;
using PBOBarberMate.App.Repository;
using PBOBarberMate.App.Model;

using PBOBarberMate.View.Homepages;
using PBOBarberMate.View.Auth;
using PBOBarberMate.View.Dashboard;
//using PBOBarberMate.View.FormProfil;


namespace PBOBarberMate.View
{
    public partial class MainApp : Form
    {
        private readonly AkunRepository _akunRepository;
        private readonly SessionService _sessionService;
        private readonly AkunService _akunService;

        private CommonAppServices _commonAppServices;

        private System.Windows.Forms.Panel _contentHostPanel;

        // Pertahankan referensi ke homepage yang sudah dibuat
        private HomepageAdminUC _adminHomepageInstance;
        private HomepageKaryawanUC _karyawanHomepageInstance;
        private HomepageCustomerUC _customerHomepageInstance;

        // Message filter instance
        private OutsideClickListener _outsideClickListener;

        public MainApp()
        {
            InitializeComponent();

            _contentHostPanel = mainContentPanel;

            _akunRepository = new AkunRepository();
            _sessionService = new SessionService();
            _akunService = new AkunService(_akunRepository, _sessionService);

            _commonAppServices = new CommonAppServices(this, _akunService, _sessionService);



            // Pada awalnya, tampilkan LoginUC
            LoadContent(new LoginUC(_commonAppServices));
        }

        // Metode umum untuk memuat UserControl ke panel utama MainApp
        public void LoadContent(UserControl contentUC)
        {
            DisableGlobalClickListener(); // Selalu disable listener saat mengubah konten utama

            // Clear semua referensi homepage saat mengubah konten utama (misal: dari Login ke Homepage)
            _adminHomepageInstance = null;
            _karyawanHomepageInstance = null;
            _customerHomepageInstance = null;

            _contentHostPanel.Controls.Clear();
            contentUC.Dock = DockStyle.Fill;
            _contentHostPanel.Controls.Add(contentUC);

            // Setelah memuat konten, perbarui referensi homepage jika itu adalah instance homepage
            if (contentUC is HomepageAdminUC adminUC)
            {
                _adminHomepageInstance = adminUC;
            }
            else if (contentUC is HomepageKaryawanUC karyawanUC)
            {
                _karyawanHomepageInstance = karyawanUC;
            }
            else if (contentUC is HomepageCustomerUC customerUC)
            {
                _customerHomepageInstance = customerUC;
            }
        }

        // Metode untuk mengarahkan ke homepage yang sesuai berdasarkan role
        public void RedirectToHomepage()
        {
            AkunRole? userRole = _sessionService.CurrentUserRole;

            if (userRole == AkunRole.admin)
            {
                LoadContent(GetHomepageInstance(AkunRole.admin));
                LoadFeatureIntoActiveHomepageContent(new AdminDashboardUC(_commonAppServices, _adminHomepageInstance), "Halaman Utama");
            }
            else if (userRole == AkunRole.karyawan)
            {
                LoadContent(GetHomepageInstance(AkunRole.karyawan));
                LoadFeatureIntoActiveHomepageContent(new KaryawanDashboardUC(_commonAppServices, _karyawanHomepageInstance), "Halaman Utama");
            }
            else if (userRole == AkunRole.customer)
            {
                LoadContent(GetHomepageInstance(AkunRole.customer));
                LoadFeatureIntoActiveHomepageContent(new CustomerDashboardUC(_commonAppServices, _customerHomepageInstance), "Halaman Utama");
            }
            else
            {
                MessageBox.Show("Role pengguna tidak dikenal atau sesi tidak valid.", "Error Redirect", MessageBoxButtons.OK, MessageBoxIcon.Error);
                _akunService.Logout();
                LoadContent(new LoginUC(_commonAppServices));
            }
        }

        // Metode pembantu untuk mendapatkan instance homepage (singleton per role)
        private UserControl GetHomepageInstance(AkunRole role)
        {
            switch (role)
            {
                case AkunRole.admin:
                    if (_adminHomepageInstance == null)
                        _adminHomepageInstance = new HomepageAdminUC(_commonAppServices);
                    return _adminHomepageInstance;
                case AkunRole.karyawan:
                    if (_karyawanHomepageInstance == null)
                        _karyawanHomepageInstance = new HomepageKaryawanUC(_commonAppServices);
                    return _karyawanHomepageInstance;
                case AkunRole.customer:
                    if (_customerHomepageInstance == null)
                        _customerHomepageInstance = new HomepageCustomerUC(_commonAppServices);
                    return _customerHomepageInstance;
                default:
                    throw new InvalidOperationException("Role tidak didukung.");
            }
        }

        // ----- METODE BARU UNTUK NAVIGASI FITUR DALAM HOMEPAGE AKTIF -----
        // Metode ini akan dipanggil oleh Homepage (melalui MainApp) atau UserControl fitur
        public void LoadFeatureIntoActiveHomepageContent(UserControl featureUC, string headerText)
        {
            // Tentukan homepage yang sedang aktif
            dynamic activeHomepage = null;
            if (_sessionService.CurrentUserRole == AkunRole.admin)
            {
                activeHomepage = _adminHomepageInstance;
            }
            else if (_sessionService.CurrentUserRole == AkunRole.karyawan)
            {
                activeHomepage = _karyawanHomepageInstance;
            }
            else if (_sessionService.CurrentUserRole == AkunRole.customer)
            {
                activeHomepage = _customerHomepageInstance;
            }

            if (activeHomepage != null)
            {
                // Delegasikan pemuatan konten dan pembaruan header ke instance homepage yang aktif
                activeHomepage.LoadFeatureContent(featureUC);
                activeHomepage.lblHeaderMenu.Text = headerText; // Akses lblHeaderMenu melalui instance homepage
                activeHomepage.AdjustHeaderPosition();          // Panggil metode adjust posisi header
                activeHomepage.HideProfileBox();                // Pastikan profil disembunyikan
            }
            else
            {
                MessageBox.Show("Tidak ada homepage aktif untuk memuat fitur.", "Error Navigasi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                RedirectToHomepage(); // Kembali ke homepage jika tidak ada yang aktif
            }
        }

        // GLOBAL FUNCTION SHOW UBAH PROFIL
        public void ShowUbahProfilForm()
        {
            // Asumsi FormUbahProfil juga akan diubah menjadi UserControl
            // Dan akan dimuat melalui LoadFeatureIntoActiveHomepageContent
            // Misal: LoadFeatureIntoActiveHomepageContent(new FormUbahProfilUC(_akunService, _sessionService, this), "Ubah Profil");
        }

        public void PerformLogout()
        {
            DialogResult result = MessageBox.Show(
                "Anda yakin ingin logout?",
                "Konfirmasi Logout",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );
            if (result == DialogResult.Yes)
            {
                _akunService.Logout();
                LoadContent(new LoginUC(_commonAppServices));
            }
        }

        public AkunService GetAkunService() => _akunService;
        public SessionService GetSessionService() => _sessionService;

        public void EnableGlobalClickListener(Control popupControl)
        {
            if (_outsideClickListener == null)
            {
                _outsideClickListener = new OutsideClickListener(popupControl, () =>
                {
                    if (_adminHomepageInstance != null)
                    {
                        _adminHomepageInstance.HideProfileBox();
                    }
                    else if (_karyawanHomepageInstance != null)
                    {
                        _karyawanHomepageInstance.HideProfileBox();
                    }
                    else if (_customerHomepageInstance != null)
                    {
                        _customerHomepageInstance.HideProfileBox();
                    }
                });
                Application.AddMessageFilter(_outsideClickListener);
            }
            else
            {
                Application.RemoveMessageFilter(_outsideClickListener);
                _outsideClickListener = new OutsideClickListener(popupControl, () =>
                {
                    if (_adminHomepageInstance != null)
                    {
                        _adminHomepageInstance.HideProfileBox();
                    }
                    else if (_karyawanHomepageInstance != null)
                    {
                        _karyawanHomepageInstance.HideProfileBox();
                    }
                    else if (_customerHomepageInstance != null)
                    {
                        _customerHomepageInstance.HideProfileBox();
                    }
                });
                Application.AddMessageFilter(_outsideClickListener);
            }
        }

        public void DisableGlobalClickListener()
        {
            if (_outsideClickListener != null)
            {
                Application.RemoveMessageFilter(_outsideClickListener);
                _outsideClickListener = null;
            }
        }
    }
}