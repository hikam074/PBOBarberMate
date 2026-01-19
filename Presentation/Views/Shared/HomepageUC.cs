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

            contentAreaPanel.MouseDown += (s, e) => this.ParentForm?.Focus();
            sidebarPanel.MouseDown += (s, e) => this.ParentForm?.Focus();
        }

        private void AssembleComponent()
        {
            LoadSidebarByRole();
            LoadNavbar();
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
                _navbar.AdjustHeaderPosition();
            }
            contentAreaPanel.Controls.Clear();
            uc.Dock = DockStyle.Fill;
            contentAreaPanel.Controls.Add(uc);
        }
    }
}