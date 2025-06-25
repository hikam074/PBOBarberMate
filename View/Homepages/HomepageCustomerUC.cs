using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


using PBOBarberMate.App.Services;
using PBOBarberMate.App.Repository;

using PBOBarberMate.View.Auth;
using PBOBarberMate.View.Layanan;


namespace PBOBarberMate.View.Homepages
{
    public partial class HomepageCustomerUC : UserControl
    {
        private readonly CommonAppServices _commonServices;
        private readonly CommonCustomerServices _commonCustomerServices;

        public HomepageCustomerUC(CommonAppServices commonServices)
        {
            InitializeComponent();
            _commonServices = commonServices;

            LayananService _layananService = new LayananService(new LayananRepository());
            _commonCustomerServices = new CommonCustomerServices(_layananService);

            // Set hover events for buttons
            SetButtonHoverEvents();
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
            SetSidebarHoverEvents(btnReservasi, pictbxReservasi);
            SetSidebarHoverEvents(btnLihatReservasi, pictbxLihatReservasi);
            SetSidebarHoverEvents(btnLayanan, pictbxLayanan);
            SetSidebarHoverEvents(btnUlasan, pictbxUlasan);
            // HOVER PROFIL
            SetProfilHoverEvents(btnProfil, pictboxProfil);
            SetProfilHoverEvents(btnUbahProfil);
            SetProfilHoverEvents(btnHomepageLogout);
        }
        // METHOD PROFIL ICON STICKS TO PROFIL NAME
        private void AdjustProfilIconPosition()
        {
            pictboxProfil.Location = new Point(btnProfil.Location.X - pictboxProfil.Width, btnProfil.Location.Y + (btnProfil.Height - pictboxProfil.Height) / 2);
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
                _commonServices.MainAppInstance.DisableGlobalClickListener();
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



        private void btnReservasi_Click(object sender, EventArgs e)
        {
            HideProfileBox();
            //_commonServices.MainAppInstance.LoadContent(new FormBuatReservasi()); // Assuming FormBuatReservasi can be loaded directly
        }
        private void btnLayanan_Click(object sender, EventArgs e)
        {
            _commonServices.MainAppInstance.LoadFeatureIntoActiveHomepageContent(new LayananUC(_commonServices, _commonCustomerServices.LayananServiceInstance), "Layanan");
        }
        private void btnLihatReservasi_Click(object sender, EventArgs e)
        {
            HideProfileBox();
            //_commonServices.MainAppInstance.LoadContent(new FormLihatReservasi()); // Assuming FormLihatReservasi can be loaded directly
        }
        private void btnUlasan_Click(object sender, EventArgs e)
        {
            HideProfileBox();
            //_commonServices.MainAppInstance.LoadContent(new FormLihatPembayaranUntukUlasan()); // Assuming FormLihatPembayaranUntukUlasan can be loaded directly
        }
        private void lklbMore_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            HideProfileBox();
            //_commonServices.MainAppInstance.LoadContent(new FormLihatReservasi()); // Assuming FormLihatReservasi can be loaded directly
        }
    }
}