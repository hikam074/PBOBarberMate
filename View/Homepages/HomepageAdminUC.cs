using System;
using System.Drawing;
using System.Windows.Forms;
using System.Xml.Linq;


using PBOBarberMate.App.Services;
using PBOBarberMate.App.Repository;

using PBOBarberMate.View.Auth;
using PBOBarberMate.View.Dashboard;
using PBOBarberMate.View.Layanan;



namespace PBOBarberMate.View.Homepages
{
    public partial class HomepageAdminUC : UserControl
    {
        private readonly AkunService _akunService;
        private readonly SessionService _sessionService;
        private readonly MainApp _mainApp;

        private readonly LayananService _layananService;

        public HomepageAdminUC(AkunService akunService, SessionService sessionService, MainApp mainApp)
        {
            InitializeComponent();
            _akunService = akunService;
            _sessionService = sessionService;
            _mainApp = mainApp;

            _layananService = new LayananService(new LayananRepository());





            // Muat konten default saat Homepage Admin dimuat (misal, tampilan menu utama)
            //LoadFeatureContent(new AdminDashboardUC(_akunService, _sessionService, _mainApp, this));
            // ubah teks header
            lblHeaderMenu.Text = "Halaman Utama";
            // ubah teks profil
            lblProfilRole.Text = _sessionService.CurrentUserRole.ToString();
            lblProfilNama.Text = _sessionService.CurrentUserName;
            lblProfilEmail.Text = _sessionService.CurrentUserEmail;
            btnProfil.Text = _sessionService.CurrentUserName;
            // Sidebar hover logic
            SetButtonHoverEvents();
            // Panggil metode untuk mengatur posisi ikon profil
            AdjustProfilIconPosition();
            AdjustHeaderPosition();
            this.Resize += (s, e) => AdjustProfilIconPosition();
            this.Resize += (S, e) => AdjustHeaderPosition();
        }
        // METHOD DEKLAR ALL HOVER
        private void SetButtonHoverEvents()
        {
            // HOVER SIDEBAR
            SetSidebarHoverEvents(btnReservasi, pictbxReservasi);
            SetSidebarHoverEvents(btnPembayaran, pictbxPembayaran);
            SetSidebarHoverEvents(btnKunjungan, pictbxKunjungan);
            SetSidebarHoverEvents(btnKaryawan, pictbxKaryawan);
            SetSidebarHoverEvents(btnShift, pictbxShift);
            SetSidebarHoverEvents(btnLayanan, pictbxLayanan);
            SetSidebarHoverEvents(btnInventaris, pictbxInventaris);
            SetSidebarHoverEvents(btnCustomer, pictbxCustomer);
            // HOVER PROFIL
            SetProfilHoverEvents(btnProfil, pictboxProfil);
            SetProfilHoverEvents(btnUbahProfil);
            SetProfilHoverEvents(btnHomepageLogout);
        }
        // METHOD PROFIL ICON STICKS TO PROFIL NAME
        private void AdjustProfilIconPosition()
        {
            pictboxProfil.Location = new Point(btnProfil.Location.X - pictboxProfil.Width, btnProfil.Location.Y + (btnProfil.Height - pictboxProfil.Height) / 2);
            // Pastikan ikon berada di depan tombol dan grup profil
            pictboxProfil.BringToFront();
            btnProfil.BringToFront();
        }
        // METHOD HEADER RESPONSIF
        public void AdjustHeaderPosition()
        {
            lblHeaderMenu.Left = (headerPanel.Width - lblHeaderMenu.Width) / 2;
        }
        // METHOD DEKLAR SIDEBAR HOVER IN OUT
        private void SetSidebarHoverEvents(Control button, Control relatedControl)
        {
            button.MouseEnter += (s, e) => { button.BackColor = Color.White; relatedControl.BackColor = Color.Gainsboro; };
            button.MouseLeave += (s, e) => { button.BackColor = Color.Transparent; relatedControl.BackColor = Color.Transparent; };
        }
        // METHOD DEKLAR PROFIL HOVER IN OUT
        private void SetProfilHoverEvents(Control button)
        {
            button.MouseEnter += (s, e) => { button.BackColor = Color.Gainsboro; };
            button.MouseLeave += (s, e) => { button.BackColor = Color.White; };
        }
        // METHOD OVERLOAD DEKLAR PROFIL HOVER IN OUT
        private void SetProfilHoverEvents(Control button, Control relatedControl)
        {
            button.MouseEnter += (s, e) => { button.BackColor = Color.Gainsboro; relatedControl.BackColor = Color.Gainsboro; };
            button.MouseLeave += (s, e) => { button.BackColor = Color.White; relatedControl.BackColor = Color.White; };
        }
        // METHOD HIDE GBXPROFIL
        public void HideProfileBox()
        {
            if (gbxShowProfile.Visible)
            {
                gbxShowProfile.Visible = false;
                _mainApp.DisableGlobalClickListener(); // Disable listener when profile box is hidden
            }
        }
        // REDIRECT HOMEPAGE
        private void pictboxHome_Click(object sender, EventArgs e)
        {
            _mainApp.RedirectToHomepage();
        }
        // SHOW GBXPROFIL
        private void btnProfil_Click(object sender, EventArgs e)
        {
            gbxShowProfile.Visible = !gbxShowProfile.Visible;

            if (gbxShowProfile.Visible)
            {
                // Convert btnProfil's location from headerPanel coordinates to HomepageAdminUC coordinates
                Point btnProfilScreenLocation = btnProfil.PointToScreen(Point.Empty);
                Point gbxShowProfileLocationOnUC = this.PointToClient(btnProfilScreenLocation);

                gbxShowProfile.Location = new Point(
                    gbxShowProfileLocationOnUC.X - gbxShowProfile.Width + btnProfil.Width,
                    gbxShowProfileLocationOnUC.Y + btnProfil.Height + 15
                );

                gbxShowProfile.BringToFront(); // Ensure it's on top of everything
                _mainApp.EnableGlobalClickListener(gbxShowProfile); // Inform MainApp to listen for clicks outside
            }
            else
            {
                _mainApp.DisableGlobalClickListener(); // Disable listener when profile box is hidden
            }
        }
        // REDIRECT UBAH PROFIL
        private void btnUbahProfil_Click(object sender, EventArgs e)
        {
            HideProfileBox();
            _mainApp.ShowUbahProfilForm();
        }
        // LOGOUT
        private void btnHomepageLogout_Click(object sender, EventArgs e)
        {
            HideProfileBox();
            _mainApp.PerformLogout();
        }
        // Memuat UserControl fitur ke dalam area konten utama homepage ini (contentAreaPanel).
        public void LoadFeatureContent(UserControl featureUC)
        {
            contentAreaPanel.Controls.Clear(); // Bersihkan panel dari konten sebelumnya
            featureUC.Dock = DockStyle.Fill;   // Pastikan UserControl mengisi seluruh panel
            contentAreaPanel.Controls.Add(featureUC);
        }




        // METHOD KETIKA LOAD HALAMAN
        private void HomepageAdminUC_Load(object sender, EventArgs e)
        {
            //
        }




        private void btnLayanan_Click(object sender, EventArgs e)
        {
            _mainApp.LoadFeatureIntoActiveHomepageContent(new LayananUC(_akunService, _sessionService, _mainApp, _layananService), "Layanan");
        }
        private void btnInventaris_Click(object sender, EventArgs e)
        {
            //LoadFeatureContent(new FormInventarisUC(_akunService, _sessionService, _mainApp));
            HideProfileBox(); // Hide profile if visible when navigating
        }
        private void btnShift_Click(object sender, EventArgs e)
        {
            //LoadFeatureContent(new FormShiftUC(_akunService, _sessionService, _mainApp));
            HideProfileBox(); // Hide profile if visible when navigating
        }
        private void btnReservasi_Click(object sender, EventArgs e)
        {
            //LoadFeatureContent(new FormLihatReservasiUC(_akunService, _sessionService, _mainApp));
            HideProfileBox(); // Hide profile if visible when navigating
        }
        private void btnPembayaran_Click(object sender, EventArgs e)
        {
            //LoadFeatureContent(new FormAddPembayaranUC(_akunService, _sessionService, _mainApp));
            HideProfileBox(); // Hide profile if visible when navigating
        }
        private void btnKunjungan_Click(object sender, EventArgs e)
        {
            //LoadFeatureContent(new FormLihatPembayaranUntukUlasanUC(_akunService, _sessionService, _mainApp));
            HideProfileBox(); // Hide profile if visible when navigating
        }
        private void btnKaryawan_Click(object sender, EventArgs e)
        {
            //LoadFeatureContent(new FormKelolaKaryawanUC(_akunService, _sessionService, _mainApp));
            HideProfileBox(); // Hide profile if visible when navigating
        }
        private void btnCustomer_Click(object sender, EventArgs e)
        {
            //LoadFeatureContent(new FormKelolaCustomerUC(_akunService, _sessionService, _mainApp));
            HideProfileBox(); // Hide profile if visible when navigating
        }
    }
}