using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace PBOBarberMate.Presentation.Views.Inventory
{
    using PBOBarberMate.App.Services;
    using PBOBarberMate.Core.Common;
    using PBOBarberMate.Core.Entities;
    using PBOBarberMate.Core.Enums;
    using PBOBarberMate.Core.Interfaces;

    public partial class InventoryUC : UserControl, IPageFeature
    {
        public string PageTitle => "Daftar Inventory";
        private readonly InventoryService _service;
        private readonly INavigationService _nav;

        public InventoryUC(InventoryService service, INavigationService nav)
        {
            InitializeComponent();
            _service = service;
            _nav = nav;
            LoadDataToGrid();
            SetupUIByRole();
        }

        private void SetupUIByRole()
        {
            bool isAdmin = SessionService.CurrentUser.IdRole == (int)UserRole.Admin;
            bool isKaryawan = SessionService.CurrentUser.IdRole == (int)UserRole.Karyawan;
            btnTambah.Visible = isAdmin;
            pictbxAdd.Visible = isAdmin;
            pictbxAddHov.Visible = isAdmin;
            // atur tombol edit layanan
            if (dgvInventory.Columns.Contains("btnUbah"))
            {
                dgvInventory.Columns["btnUbah"].Visible = isAdmin || isKaryawan;
            }
            // atur tombol hapus layanan
            if (dgvInventory.Columns.Contains("btnHapus"))
            {
                dgvInventory.Columns["btnHapus"].Visible = isAdmin;
            }
        }
        private void LoadDataToGrid()
        {
            var result = _service.AmbilSemuaBarang();
            if (result.IsSuccess)
            {
                dgvInventory.DataSource = null;
                dgvInventory.DataSource = result.Data;
                dgvInventory.Columns["IdBarang"].Visible = false; // Sembunyikan ID
                dgvInventory.Columns["NamaBarang"].HeaderText = "Nama Barang";
                dgvInventory.Columns["Stok"].HeaderText = "Jumlah Stok";
                dgvInventory.Columns["IdAkunPengelola"].Visible = false; // Sembunyikan ID
                dgvInventory.Columns["NamaPengelola"].HeaderText = "Diinput Oleh";

                bool isAdmin = SessionService.CurrentUser.IdRole == (int)UserRole.Admin;
                bool isKaryawan = SessionService.CurrentUser.IdRole == (int)UserRole.Karyawan;
                // Kolom Ubah
                if (dgvInventory.Columns["btnUbah"] == null)
                {
                    DataGridViewButtonColumn btnUbah = new DataGridViewButtonColumn();
                    btnUbah.Name = "btnUbah";
                    btnUbah.HeaderText = "Aksi";
                    btnUbah.Text = "Ubah";
                    btnUbah.UseColumnTextForButtonValue = true;
                    dgvInventory.Columns.Add(btnUbah);
                }
                // Kolom Hapus
                if (dgvInventory.Columns["btnHapus"] == null)
                {
                    DataGridViewButtonColumn btnHapus = new DataGridViewButtonColumn();
                    btnHapus.Name = "btnHapus";
                    btnHapus.HeaderText = "Aksi";
                    btnHapus.Text = "Hapus";
                    btnHapus.UseColumnTextForButtonValue = true;
                    dgvInventory.Columns.Add(btnHapus);
                }
            }
            else
            {
                MessageBox.Show(result.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
           _nav.LoadFitur(new InventoryTambahUC(_service, _nav));
        }
        private void dgvInventory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // pastikan baris yang diklik valid (bukan header atau baris kosong)
            if (e.RowIndex < 0) return;
            // get object dari baris yang diklik
            M_Inventory barangDipilih = (M_Inventory)dgvInventory.Rows[e.RowIndex].DataBoundItem;
            // Jika tombol "Ubah" yang diklik
            if (e.ColumnIndex == dgvInventory.Columns["btnUbah"].Index)
            {
                _nav.LoadFitur(new InventoryTambahUC(_service, _nav, barangDipilih));
            }
            // Jika tombol "Hapus" yang diklik
            else if (e.ColumnIndex == dgvInventory.Columns["btnHapus"].Index)
            {
                DialogResult confirm = MessageBox.Show(
                    $"Apakah Anda yakin ingin menghapus inventory ini (ID Barang: {barangDipilih.IdBarang})?",
                    "Konfirmasi Hapus",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );
                if (confirm == DialogResult.Yes)
                {
                    Result<bool> result = _service.HapusBarang(barangDipilih);
                    if (result.IsSuccess)
                    {
                        MessageBox.Show(result.Message);
                        //redirect ke InventoryUC
                        _nav.LoadFitur(new InventoryUC(_service, _nav));
                    }
                    else
                    {
                        MessageBox.Show(result.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }
    }
}
