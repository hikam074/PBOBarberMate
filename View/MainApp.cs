using System;
using System.Drawing;
using System.Windows.Forms;

using PBOBarberMate.App.Services;
using PBOBarberMate.App.Repository;
using PBOBarberMate.App.Model;

using PBOBarberMate.View.Homepages;
using PBOBarberMate.View.Auth;
//using PBOBarberMate.View.FormProfil;


namespace PBOBarberMate.View
{
    public partial class MainApp : Form
    {
        private readonly AkunRepository _akunRepository;
        private readonly SessionService _sessionService;
        private readonly AkunService _akunService;

        private System.Windows.Forms.Panel _contentHostPanel;

        private HomepageAdminUC _currentAdminHomepage;
        private HomepageKaryawanUC _currentKaryawanHomepage;
        private HomepageCustomerUC _currentCustomerHomepage;

        // Message filter instance
        private OutsideClickListener _outsideClickListener;

        public MainApp()
        {
            InitializeComponent();

            _contentHostPanel = mainContentPanel;

            _akunRepository = new AkunRepository();
            _sessionService = new SessionService();
            _akunService = new AkunService(_akunRepository, _sessionService);

            this.LoadContent(new LoginUC(_akunService, _sessionService, this));
        }

        public void LoadContent(UserControl contentUC)
        {
            // Disable listener before clearing content
            DisableGlobalClickListener();
            _currentAdminHomepage = null;
            _currentKaryawanHomepage = null;
            _currentCustomerHomepage = null;

            _contentHostPanel.Controls.Clear();
            contentUC.Dock = DockStyle.Fill;
            mainContentPanel.Controls.Add(contentUC);

            if (contentUC is HomepageAdminUC adminUC)
            {
                _currentAdminHomepage = adminUC;
            }
            else if (contentUC is HomepageKaryawanUC karyawanUC)
            {
                _currentKaryawanHomepage = karyawanUC;
            }
            else if (contentUC is HomepageCustomerUC customerUC)
            {
                _currentCustomerHomepage = customerUC;
            }
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
                LoadContent(new HomepageKaryawanUC(_akunService, _sessionService, this));
            }
            else if (userRole == AkunRole.customer)
            {
                LoadContent(new HomepageCustomerUC(_akunService, _sessionService, this)); // Placeholder for Customer homepage
            }
            else
            {
                MessageBox.Show("Role pengguna tidak dikenal atau sesi tidak valid.", "Error Redirect", MessageBoxButtons.OK, MessageBoxIcon.Error);
                _akunService.Logout();
                LoadContent(new LoginUC(_akunService, _sessionService, this));
            }
        }
        // GLOBAL FUNCTION SHOW UBAH PROFIL
        public void ShowUbahProfilForm()
        {
            //LoadContent(new FormUbahProfil());
        }
        // GKOBAL FUNCTION LOGOUT
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
                LoadContent(new LoginUC(_akunService, _sessionService, this));
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
                    if (_currentAdminHomepage != null)
                    {
                        _currentAdminHomepage.HideProfileBox();
                    }
                    else if (_currentKaryawanHomepage != null)
                    {
                        _currentKaryawanHomepage.HideProfileBox();
                    }
                    else if (_currentCustomerHomepage != null)
                    {
                        _currentCustomerHomepage.HideProfileBox();
                    }
                });
                Application.AddMessageFilter(_outsideClickListener);
            }
            else
            {
                Application.RemoveMessageFilter(_outsideClickListener);
                _outsideClickListener = new OutsideClickListener(popupControl, () =>
                {
                    if (_currentAdminHomepage != null)
                    {
                        _currentAdminHomepage.HideProfileBox();
                    }
                    else if (_currentKaryawanHomepage != null)
                    {
                        _currentKaryawanHomepage.HideProfileBox();
                    }
                    else if (_currentCustomerHomepage != null)
                    {
                        _currentCustomerHomepage.HideProfileBox();
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