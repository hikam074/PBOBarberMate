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
    using PBOBarberMate.Presentation.Views.Inventory;
    using PBOBarberMate.Presentation.Views.Layanan;
    using PBOBarberMate.Presentation.Views.Jadwal;

    public partial class SidebarAdminUC : UserControl
    {
        private readonly INavigationService _nav;

        public SidebarAdminUC(INavigationService nav)
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
        private void btnInventory_Click(object sender, EventArgs e)
        {
            IInventoryRepository repo = new InventoryRepository();
            InventoryService service = new InventoryService(repo);
            InventoryUC inventoryUC = new InventoryUC(service, _nav);
            _nav.LoadFitur(inventoryUC);
        }
        private void btnJadwal_Click(object sender, EventArgs e)
        {
            IJadwalRepository repo = new JadwalRepository();
            JadwalService service = new JadwalService(repo);
            JadwalUC inventoryUC = new JadwalUC(service, _nav);
            _nav.LoadFitur(inventoryUC);
        }

        private void SetButtonHoverEvents()
        {
            SetSidebarHoverEvents(btnReservasi, pictbxReservasi);
            SetSidebarHoverEvents(btnPembayaran, pictbxPembayaran);
            SetSidebarHoverEvents(btnKunjungan, pictbxKunjungan);
            SetSidebarHoverEvents(btnKaryawan, pictbxKaryawan);
            SetSidebarHoverEvents(btnJadwal, pictbxShift);
            SetSidebarHoverEvents(btnLayanan, pictbxLayanan);
            SetSidebarHoverEvents(btnInventory, pictbxInventory);
            SetSidebarHoverEvents(btnCustomer, pictbxCustomer);
        }
        private void SetSidebarHoverEvents(Control button, Control relatedControl)
        {
            button.MouseEnter += (s, e) => { button.BackColor = Color.White; relatedControl.BackColor = Color.Gainsboro; };
            button.MouseLeave += (s, e) => { button.BackColor = Color.Transparent; relatedControl.BackColor = Color.Transparent; };
        }


    }
}
