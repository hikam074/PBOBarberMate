using System;
using System.Drawing;
using System.Windows.Forms;
using System.Xml.Linq;

namespace PBOBarberMate.Presentation.Views.Shared
{
    using PBOBarberMate.App.Services;
    using PBOBarberMate.Core.Interfaces;
    using PBOBarberMate.Core.Enums;
    using PBOBarberMate.Presentation.Views.Shared.Sidebars;

    public partial class HomepageUC : UserControl, INavigationService
    {
        private NavbarUC _navbar;

        public HomepageUC()
        {
            InitializeComponent();

            AssembleComponent();





            //SetButtonHoverEvents();

            //AdjustProfilIconPosition();
            //AdjustHeaderPosition();

            //this.Resize += (s, e) => AdjustProfilIconPosition();
            //this.Resize += (S, e) => AdjustHeaderPosition();
        }

        //private void btnProfil_Click(object sender, EventArgs e)
        //// Show ProfilePopupUC
        //{
        //    int bottomGap = 15;
        //    if (_profilePopup == null || _profilePopup.IsDisposed)
        //    {
        //        _profilePopup = new ProfilePopupUC();
        //        _profilePopup.Location = new Point(
        //            btnProfil.Right - _profilePopup.Width,
        //            btnProfil.Bottom + bottomGap
        //            );
        //        this.Controls.Add(_profilePopup);
        //        _profilePopup.BringToFront();
        //        _profilePopup.Focus();
        //        _profilePopup.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        //        // close ketika klik diluar
        //        _profilePopup.Leave += (s, args) => { this.Controls.Remove(_profilePopup); _profilePopup.Dispose(); };
        //    }
        //    else
        //    {
        //        this.Controls.Remove(_profilePopup);
        //        _profilePopup.Dispose();
        //    }
        //}
        //private void pictboxHome_Click(object sender, EventArgs e)
        //// REDIRECT HOMEPAGE
        //{
        //    //_commonServices.MainAppInstance.RedirectToHomepage();
        //}

        private void AssembleComponent()
        {
            LoadNavbar();
            LoadSidebarByRole();
        }
        private void LoadNavbar()
        {
            _navbar = new NavbarUC(this);
            _navbar.Dock = DockStyle.Fill;
            headerPanel.Controls.Clear();
            headerPanel.Controls.Add(_navbar);
        }
        private void LoadSidebarByRole()
        {
            var role = SessionService.CurrentUser;
            UserControl selectedSidebar;
            switch (role.IdRole)
            {
                case (int)UserRole.Admin:
                    selectedSidebar = new SidebarAdminUC(this);
                    break;
                case (int)UserRole.Karyawan:
                    selectedSidebar = new SidebarKaryawanUC(this);
                    break;
                default:
                    selectedSidebar = new SidebarCustomerUC(this);
                    break;
            }
            selectedSidebar.Dock = DockStyle.Fill;
            sidebarPanel.Controls.Clear();
            sidebarPanel.Controls.Add(selectedSidebar);
        }
        public void LoadFitur(UserControl uc)
        {
            if (uc is IPageFeature feature)
            {
                _navbar.SetPageTitle(feature.PageTitle);
            }
            contentAreaPanel.Controls.Clear();
            uc.Dock = DockStyle.Fill;
            contentAreaPanel.Controls.Add(uc);
        }
        //private void SetButtonHoverEvents()
        // METHOD DEKLAR ALL HOVER
        //{
            //SetProfilHoverEvents(btnProfil, pictboxProfil);
        //}
        //private void AdjustProfilIconPosition()
        //// METHOD PROFIL ICON STICKS TO PROFIL NAME
        //{
        //    pictboxProfil.Location = new Point(btnProfil.Location.X - pictboxProfil.Width, btnProfil.Location.Y + (btnProfil.Height - pictboxProfil.Height) / 2);
        //    // Pastikan ikon berada di depan tombol dan grup profil
        //    pictboxProfil.BringToFront();
        //    btnProfil.BringToFront();
        //}
        //public void AdjustHeaderPosition()
        //// METHOD HEADER RESPONSIF
        //{
        //    lblHeaderMenu.Left = (headerPanel.Width - lblHeaderMenu.Width) / 2;
        //}
        //private void SetProfilHoverEvents(Control button, Control relatedControl)
        //{
        //    button.MouseEnter += (s, e) => { button.BackColor = Color.Gainsboro; relatedControl.BackColor = Color.Gainsboro; };
        //    button.MouseLeave += (s, e) => { button.BackColor = Color.White; relatedControl.BackColor = Color.White; };
        //}

        //private void lblHeaderMenu_TextChanged(object sender, EventArgs e)
        //{
        //    AdjustHeaderPosition();
        //}
        private void headerPanel_Resize(object sender, EventArgs e)
        {
            //AdjustHeaderPosition();
        }
    }
}