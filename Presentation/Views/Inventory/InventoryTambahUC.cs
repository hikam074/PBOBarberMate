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

    public partial class InventoryTambahUC : UserControl, IPageFeature
    {
        public string PageTitle => _isEditMode ? "Ubah Barang" : "Tambah Barang Baru";
        private readonly InventoryService _service;
        private readonly INavigationService _nav;
        // mode edit
        public readonly bool _isEditMode;
        public readonly M_Inventory _dataDiedit;

        public InventoryTambahUC(InventoryService service, INavigationService nav)
        {
            InitializeComponent();
            _service = service;
            _nav = nav;
            _isEditMode = false;
            SetupUI();
        }
        public InventoryTambahUC(InventoryService service, INavigationService nav, M_Inventory barang)
        {
            InitializeComponent();
            _service = service;
            _nav = nav;
            _isEditMode = true;
            _dataDiedit = barang;
            SetupUI();
            FillForm(_dataDiedit);
            SetupFormByRole();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            DialogResult confirm = MessageBox.Show(
                $"Apakah Anda yakin?",
                "Konfirmasi",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );
            if (confirm == DialogResult.Yes)
            {
                var barang = new M_Inventory
                {
                    NamaBarang = tbxNama.Text,
                    Stok = (int)numStok.Value,
                    Satuan = tbxSatuan.Text
                };
                Result<bool> result;
                if (_isEditMode)
                {
                    barang.IdBarang = _dataDiedit.IdBarang;
                    result = _service.PerbaruiBarang(barang);
                }
                else
                {
                    result = _service.TambahBarang(barang);
                }
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
        private void btnCancel_Click(object sender, EventArgs e)
        {
            _nav.LoadFitur(new InventoryUC(_service, _nav));
        }

        private void SetupUI()
        {
            // btnCancel hover
            btnCancel.MouseEnter += (s, e) => { btnCancel.BackColor = Color.Orange; pictbxBack.BackColor = Color.Orange; };
            btnCancel.MouseLeave += (s, e) => { btnCancel.BackColor = Color.WhiteSmoke; pictbxBack.BackColor = Color.WhiteSmoke; };
            // btnAdd hover
            btnAdd.MouseEnter += (s, e) =>
            {
                btnAdd.BackColor = Color.Green; btnAdd.ForeColor = Color.White;
                pictbxAddHov.BackColor = Color.Green; pictbxAddHov.Visible = true; pictbxAddHov.BringToFront();
                pictbxAdd.Visible = false;
            };
            btnAdd.MouseLeave += (s, e) =>
            {
                btnAdd.BackColor = Color.WhiteSmoke; btnAdd.ForeColor = Color.Black;
                pictbxAddHov.Visible = false;
                pictbxAdd.Visible = true;
            };
            // btnAdd disable first
            UpdateAddButtonState();
            // update text
            lblTambahInventory.Text = _isEditMode ? $"Ubah Barang \"{_dataDiedit.NamaBarang}\"" : "Tambahkan Barang Baru";
            btnAdd.Text = _isEditMode ? "    Simpan" : "     Tambahkan";
        }
        private void FillForm(M_Inventory barang)
        {
            tbxNama.Text = barang.NamaBarang;
            numStok.Value = barang.Stok;
            tbxSatuan.Text = barang.Satuan;
        }
        private void SetupFormByRole()
        {
            var user = SessionService.CurrentUser;
            bool isAdmin = user.IdRole == (int)UserRole.Admin;
            // nama, satuan = admin only
            tbxNama.ReadOnly = !isAdmin;
            tbxSatuan.ReadOnly = !isAdmin;
            // stok = all
            numStok.ReadOnly = false;
        }
        public void UpdateAddButtonState()
        {
            btnAdd.Enabled = !(string.IsNullOrWhiteSpace(tbxNama.Text) || decimal.IsNegative(numStok.Value) || string.IsNullOrWhiteSpace(tbxSatuan.Text));
        }

        private void tbxNama_TextChanged(object sender, EventArgs e)
        {
            UpdateAddButtonState();
        }
        private void tbxJumlah_TextChanged(object sender, EventArgs e)
        {
            UpdateAddButtonState();
        }
        private void numStok_ValueChanged(object sender, EventArgs e)
        {
            UpdateAddButtonState();
        }
    }
}
