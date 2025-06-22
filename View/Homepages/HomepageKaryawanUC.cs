using System;
using System.Windows.Forms;
using System.Drawing;

using PBOBarberMate.App.Services;

using PBOBarberMate.View.Auth;


namespace PBOBarberMate.View.Homepages
{
    public partial class HomepageKaryawanUC : UserControl
    {
        private readonly AkunService _akunService;
        private readonly SessionService _sessionService;
        private readonly MainApp _mainApp;

        public HomepageKaryawanUC(AkunService akunService, SessionService sessionService, MainApp mainApp)
        {
            InitializeComponent();
            _akunService = akunService;
            _sessionService = sessionService;
            _mainApp = mainApp;

            // ubah teks header
            lblHeaderMenu.Text = "Halaman Utama";
            // ubah teks profil
            lblProfilRole.Text = _sessionService.CurrentUserRole.ToString();
            lblProfilNama.Text = _sessionService.CurrentUserName;
            lblProfilEmail.Text = _sessionService.CurrentUserEmail;
            btnProfil.Text = _sessionService.CurrentUserName;

            // Sidebar hover logic
            SetButtonHoverEvents();
            // metode untuk mengatur posisi ikon profil
            AdjustProfilIconPosition();
            AdjustHeaderPosition();
            this.Resize += (s, e) => AdjustProfilIconPosition();
            this.Resize += (S, e) => AdjustHeaderPosition();
        }

        // METHOD DEKLAR ALL HOVER
        private void SetButtonHoverEvents()
        {
            // HOVER SIDEBAR
            SetSidebarHoverEvents(btnPresensi, pictbxPresensi);
            SetSidebarHoverEvents(btnPerforma, pictbxPerforma);
            SetSidebarHoverEvents(btnLayanan, pictbxLayanan);
            SetSidebarHoverEvents(btnInventaris, pictbxInventaris);
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
        private void AdjustHeaderPosition()
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
                Point btnProfilScreenLocation = btnProfil.PointToScreen(Point.Empty);
                Point gbxShowProfileLocationOnUC = this.PointToClient(btnProfilScreenLocation);

                gbxShowProfile.Location = new Point(
                    gbxShowProfileLocationOnUC.X - gbxShowProfile.Width + btnProfil.Width,
                    gbxShowProfileLocationOnUC.Y + btnProfil.Height + 15
                );

                gbxShowProfile.BringToFront();
                _mainApp.EnableGlobalClickListener(gbxShowProfile);
            }
            else
            {
                _mainApp.DisableGlobalClickListener();
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
        private void HomepageKaryawanUC_Load(object sender, EventArgs e)
        { 
            loadFormKaryawan(); 
        }
        public void loadFormKaryawan()
        {
            lblWelcome.Text = "Selamat Datang, " + _sessionService.CurrentUserName + " !";
            // Assuming ShiftContext and PresensiContext will be refactored to use Repositories
            // lblStatusShiftToday.Text = ShiftContext.getShiftByIDToday(_sessionService.CurrentUserId);
            // string waktuPresensi = PresensiContext.isPresensiTodayExist(_sessionService.CurrentUserId);
            // string adashift = ShiftContext.getShiftByIDToday(_sessionService.CurrentUserId);

            // Placeholder logic for now, as contexts are commented out
            string adashift = "Ada"; // Assume shift exists for now
            string waktuPresensi = "N/A"; // Placeholder

            if (adashift == "Ada")
            {
                lblStatusShiftToday.Text = "Ada";
                btnLakukanPresensi.Enabled = true;
            }
            else
            {
                lblStatusShiftToday.Text = "Tidak Ada";
                btnLakukanPresensi.Enabled = false;
            }
            lblStatusPresensiToday.Text = waktuPresensi;
        }




        private void btnLayanan_Click(object sender, EventArgs e)
        {
            HideProfileBox();
            //_mainApp.LoadContent(new FormLayanan()); // Assuming FormLayanan can be loaded as a UserControl directly, or wrap it in one.
                                                     // This will likely need to be a UserControl to fit the new MainApp architecture.
        }
        private void btnInventaris_Click(object sender, EventArgs e)
        {
            HideProfileBox();
            //_mainApp.LoadContent(new FormInventaris.FormInventaris()); // Assuming FormInventaris can be loaded directly.
        }
        private void btnPerforma_Click(object sender, EventArgs e)
        {
            HideProfileBox();
            //_mainApp.LoadContent(new FormPerforma.FormPerforma()); // Assuming FormPerforma can be loaded directly.
        }
        private void btnPresensi_Click(object sender, EventArgs e)
        {
            HideProfileBox();
            // Need to pass the current user's ID
            //_mainApp.LoadContent(new FormPresensi.FormPresensi(_sessionService.CurrentUserId)); // Assuming FormPresensi can be loaded directly.
        }
        private void btnUlasan_Click(object sender, EventArgs e)
        {
            HideProfileBox();
            //_mainApp.LoadContent(new FormLihatPembayaranUntukUlasan());
        }
        private void btnLihatReservasi_Click(object sender, EventArgs e)
        {
            HideProfileBox();
            //_mainApp.LoadContent(new FormLihatReservasi());
        }
        private void btnLakukanPresensi_Click(object sender, EventArgs e)
        {
            // if (PresensiContext.isPresensiTodayExist(_sessionService.CurrentUserId) != null)
            // {
            //     MessageBox.Show($"Data presensi SUDAH ada!", "Presensi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //     loadFormKaryawan();
            //     return;
            // }

            // try
            // {
            //     M_Presensi presensi = new M_Presensi
            //     {
            //         id_akun = _sessionService.CurrentUserId,
            //         id_shift = PresensiContext.getJadwalShiftTodayThisID(_sessionService.CurrentUserId),
            //         waktu_presensi = DateTime.Now
            //     };
            //     MessageBox.Show($"{presensi.id_shift}");

            //     PresensiContext.AddPresensi(presensi);

            //     MessageBox.Show($"Presensi BERHASIL ditambahkan!", "Presensi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            // }
            // catch (Exception ex)
            // {
            //     MessageBox.Show($"GAGAL melakukan presensi: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            // }
            // finally
            // {
            //     loadFormKaryawan();
            // }

            // Placeholder for now
            MessageBox.Show("Presensi functionality is currently commented out.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}