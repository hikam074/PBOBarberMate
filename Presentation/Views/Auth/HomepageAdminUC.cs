using System;
using System.Drawing;
using System.Windows.Forms;
using System.Xml.Linq;

namespace PBOBarberMate.Presentation.Views.Auth
{
    using PBOBarberMate.App.Services;
    using PBOBarberMate.Core.Interfaces;
    using PBOBarberMate.Infrastructure.Repositories;
    using PBOBarberMate.Presentation.Views.Inventory;
    using PBOBarberMate.Presentation.Views.Shared;

    public partial class HomepageAdminUC : UserControl, INavigationService
    {
        private ProfilePopupUC _profilePopup;

        public HomepageAdminUC()
        {
            InitializeComponent();
            SetButtonHoverEvents();
            btnProfil.Text = SessionService.CurrentUser.Nama;
            AdjustProfilIconPosition();
            AdjustHeaderPosition();

            this.Resize += (s, e) => AdjustProfilIconPosition();
            this.Resize += (S, e) => AdjustHeaderPosition();
        }

        private void btnProfil_Click(object sender, EventArgs e)
        // Show ProfilePopupUC
        {
            int bottomGap = 15;
            if (_profilePopup == null || _profilePopup.IsDisposed)
            {
                _profilePopup = new ProfilePopupUC();
                _profilePopup.Location = new Point(
                    btnProfil.Right - _profilePopup.Width,
                    btnProfil.Bottom + bottomGap
                    );
                this.Controls.Add(_profilePopup);
                _profilePopup.BringToFront();
                _profilePopup.Focus();
                _profilePopup.Anchor = AnchorStyles.Top | AnchorStyles.Right;
                // close ketika klik diluar
                _profilePopup.Leave += (s, args) => { this.Controls.Remove(_profilePopup); _profilePopup.Dispose(); };
            }
            else
            {
                this.Controls.Remove(_profilePopup);
                _profilePopup.Dispose();
            }
        }
        private void btnLayanan_Click(object sender, EventArgs e)
        {
            //_commonServices.MainAppInstance.LoadFeatureIntoActiveHomepageContent(new LayananUC(_commonServices, _commonAdminServices.LayananServiceInstance), "Layanan");
        }
        private void btnInventory_Click(object sender, EventArgs e)
        {
            IInventoryRepository repo = new InventoryRepository();
            InventoryService service = new InventoryService(repo);
            InventoryUC inventoryUC = new InventoryUC(service, this);
            this.LoadFitur(inventoryUC);
        }
        private void btnShift_Click(object sender, EventArgs e)
        {
            //_commonServices.MainAppInstance.LoadFeatureIntoActiveHomepageContent(new ShiftUC(_commonServices, _commonAdminServices), "Shift");
        }
        private void btnReservasi_Click(object sender, EventArgs e)
        {
            //LoadFeatureContent(new FormLihatReservasiUC(_akunService, _sessionService, _mainApp));
            //HideProfileBox(); // Hide profile if visible when navigating
        }
        private void btnPembayaran_Click(object sender, EventArgs e)
        {
            //LoadFeatureContent(new FormAddPembayaranUC(_akunService, _sessionService, _mainApp));
            //HideProfileBox(); // Hide profile if visible when navigating
        }
        private void btnKunjungan_Click(object sender, EventArgs e)
        {
            //LoadFeatureContent(new FormLihatPembayaranUntukUlasanUC(_akunService, _sessionService, _mainApp));
            //HideProfileBox(); // Hide profile if visible when navigating
        }
        private void btnKaryawan_Click(object sender, EventArgs e)
        {
            //_commonServices.MainAppInstance.LoadFeatureIntoActiveHomepageContent(new KelolaKaryawanUC(_commonServices), "Kelola Karyawan");
        }
        private void btnCustomer_Click(object sender, EventArgs e)
        {
            //_commonServices.MainAppInstance.LoadFeatureIntoActiveHomepageContent(new KelolaCustomerUC(_commonServices), "Kelola Customer");
        }
        private void pictboxHome_Click(object sender, EventArgs e)
        // REDIRECT HOMEPAGE
        {
            //_commonServices.MainAppInstance.RedirectToHomepage();
        }

        public void LoadFitur(UserControl uc)
        {
            if (uc is IPageFeature feature)
            {
                lblHeaderMenu.Text = feature.PageTitle;
                AdjustHeaderPosition();
            }

            contentAreaPanel.Controls.Clear();
            uc.Dock = DockStyle.Fill;
            contentAreaPanel.Controls.Add(uc);
        }
        private void SetButtonHoverEvents()
        // METHOD DEKLAR ALL HOVER
        {
            SetSidebarHoverEvents(btnReservasi, pictbxReservasi);
            SetSidebarHoverEvents(btnPembayaran, pictbxPembayaran);
            SetSidebarHoverEvents(btnKunjungan, pictbxKunjungan);
            SetSidebarHoverEvents(btnKaryawan, pictbxKaryawan);
            SetSidebarHoverEvents(btnShift, pictbxShift);
            SetSidebarHoverEvents(btnLayanan, pictbxLayanan);
            SetSidebarHoverEvents(btnInventaris, pictbxInventaris);
            SetSidebarHoverEvents(btnCustomer, pictbxCustomer);
            SetProfilHoverEvents(btnProfil, pictboxProfil);
        }
        private void AdjustProfilIconPosition()
        // METHOD PROFIL ICON STICKS TO PROFIL NAME
        {
            pictboxProfil.Location = new Point(btnProfil.Location.X - pictboxProfil.Width, btnProfil.Location.Y + (btnProfil.Height - pictboxProfil.Height) / 2);
            // Pastikan ikon berada di depan tombol dan grup profil
            pictboxProfil.BringToFront();
            btnProfil.BringToFront();
        }
        public void AdjustHeaderPosition()
        // METHOD HEADER RESPONSIF
        {
            lblHeaderMenu.Left = (headerPanel.Width - lblHeaderMenu.Width) / 2;
        }
        private void SetSidebarHoverEvents(Control button, Control relatedControl)
        // METHOD DEKLAR SIDEBAR HOVER IN OUT
        {
            button.MouseEnter += (s, e) => { button.BackColor = Color.White; relatedControl.BackColor = Color.Gainsboro; };
            button.MouseLeave += (s, e) => { button.BackColor = Color.Transparent; relatedControl.BackColor = Color.Transparent; };
        }
        // METHOD OVERLOAD DEKLAR PROFIL HOVER IN OUT
        private void SetProfilHoverEvents(Control button, Control relatedControl)
        {
            button.MouseEnter += (s, e) => { button.BackColor = Color.Gainsboro; relatedControl.BackColor = Color.Gainsboro; };
            button.MouseLeave += (s, e) => { button.BackColor = Color.White; relatedControl.BackColor = Color.White; };
        }

        private void lblHeaderMenu_TextChanged(object sender, EventArgs e)
        {
            AdjustHeaderPosition();
        }

        private void headerPanel_Resize(object sender, EventArgs e)
        {
            AdjustHeaderPosition();
        }
    }
}