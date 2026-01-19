using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBOBarberMate.Presentation.Views.Shared.Sidebars
{
    using PBOBarberMate.App.Services;
    using PBOBarberMate.Core.Interfaces;
    using PBOBarberMate.Infrastructure.Repositories;
    using PBOBarberMate.Presentation.Views.Layanan;

    public partial class SidebarCustomerUC : UserControl
    {
        private readonly INavigationService _nav;

        public SidebarCustomerUC(INavigationService nav)
        {
            InitializeComponent();
            _nav = nav;
            SetButtonHoverEvents();
        }

        private void btnLayanan_Click(object sender, EventArgs e)
        {
            ILayananRepository repo = new LayananRepository();
            LayananService service = new LayananService(repo);
            LayananUC layananUC = new LayananUC(service, _nav);
            _nav.LoadFitur(layananUC);
        }

        private void SetButtonHoverEvents()
        {
            SetSidebarHoverEvents(btnReservasi, pictbxReservasi);
            SetSidebarHoverEvents(btnLihatReservasi, pictbxLihatReservasi);
            SetSidebarHoverEvents(btnLayanan, pictbxLayanan);
            SetSidebarHoverEvents(btnUlasan, pictbxUlasan);

        }
        private void SetSidebarHoverEvents(Control button, Control relatedControl)
        {
            button.MouseEnter += (s, e) => { button.BackColor = Color.White; relatedControl.BackColor = Color.Gainsboro; };
            button.MouseLeave += (s, e) => { button.BackColor = Color.Transparent; relatedControl.BackColor = Color.Transparent; };
        }
    }
}
