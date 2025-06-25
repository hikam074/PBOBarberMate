using System;
using System.Windows.Forms;
using System.Drawing;

using PBOBarberMate.App.Services;

using PBOBarberMate.View.Auth;
using PBOBarberMate.View.Layanan;
using PBOBarberMate.App.Repository;
using PBOBarberMate.View.Inventaris;


namespace PBOBarberMate.View.Homepages
{
    public partial class HomepageKaryawanUC : UserControl
    {
        private readonly CommonAppServices _commonServices;
        private readonly CommonKaryawanServices _commonKaryawanServices;

        public HomepageKaryawanUC(CommonAppServices commonServices)
        {
            InitializeComponent();
            _commonServices = commonServices;

            LayananService _layananService = new LayananService(new LayananRepository());
            InventarisService _inventarisService = new InventarisService(new InventarisRepository());
            _commonKaryawanServices = new CommonKaryawanServices(_layananService, _inventarisService);

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
            // SET UI
            lblProfilRole.Text = _commonServices.SessionServiceInstance.CurrentUserRole.ToString();
            lblProfilNama.Text = _commonServices.SessionServiceInstance.CurrentUserName;
            lblProfilEmail.Text = _commonServices.SessionServiceInstance.CurrentUserEmail;
            btnProfil.Text = _commonServices.SessionServiceInstance.CurrentUserName;
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
                _commonServices.MainAppInstance.DisableGlobalClickListener(); // Disable listener when profile box is hidden
            }
        }
        // REDIRECT HOMEPAGE
        private void pictboxHome_Click(object sender, EventArgs e)
        {
            _commonServices.MainAppInstance.RedirectToHomepage();
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
                _commonServices.MainAppInstance.EnableGlobalClickListener(gbxShowProfile);
            }
            else
            {
                _commonServices.MainAppInstance.DisableGlobalClickListener();
            }
        }
        // REDIRECT UBAH PROFIL
        private void btnUbahProfil_Click(object sender, EventArgs e)
        {
            HideProfileBox();
            _commonServices.MainAppInstance.ShowUbahProfilForm();
        }
        // LOGOUT
        private void btnHomepageLogout_Click(object sender, EventArgs e)
        {
            HideProfileBox();
            _commonServices.MainAppInstance.PerformLogout();
        }
        // Memuat UserControl fitur ke dalam area konten utama homepage ini (contentAreaPanel).
        public void LoadFeatureContent(UserControl featureUC)
        {
            contentAreaPanel.Controls.Clear(); // Bersihkan panel dari konten sebelumnya
            featureUC.Dock = DockStyle.Fill;   // Pastikan UserControl mengisi seluruh panel
            contentAreaPanel.Controls.Add(featureUC);
        }


        private void btnLayanan_Click(object sender, EventArgs e)
        {
            _commonServices.MainAppInstance.LoadFeatureIntoActiveHomepageContent(new LayananUC(_commonServices, _commonKaryawanServices.LayananServiceInstance), "Layanan");
        }
        private void btnInventaris_Click(object sender, EventArgs e)
        {
            _commonServices.MainAppInstance.LoadFeatureIntoActiveHomepageContent(new InventarisUC(_commonServices, _commonKaryawanServices.InventarisServiceInstance), "Inventaris Barang");
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