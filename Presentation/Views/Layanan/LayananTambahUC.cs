using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBOBarberMate.Presentation.Views.Layanan
{
    using PBOBarberMate.App.Services;
    using PBOBarberMate.Core.Common;
    using PBOBarberMate.Core.Entities;
    using PBOBarberMate.Core.Interfaces;

    public partial class LayananTambahUC : UserControl, IPageFeature
    {
        public string PageTitle => _isEditMode ? "Ubah Layanan" : "Tambah layanan Baru";
        private readonly LayananService _service;
        private readonly INavigationService _nav;
        // mode edit
        public readonly bool _isEditMode;
        public readonly M_Layanan _dataDiedit;

        public LayananTambahUC(LayananService service, INavigationService nav)
        {
            InitializeComponent();
            _service = service;
            _nav = nav;
            _isEditMode = false;
            SetupUI();
        }
        public LayananTambahUC(LayananService service, INavigationService nav, M_Layanan layanan)
        {
            InitializeComponent();
            _service = service;
            _nav = nav;
            _isEditMode = true;
            _dataDiedit = layanan;
            SetupUI();
            FillForm(_dataDiedit);
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
                var layanan = new M_Layanan()
                {
                    NamaLayanan = tbxNama.Text,
                    Harga = (decimal)numHarga.Value,
                    Deskripsi = tbxDeskripsi.Text
                };
                Result<bool> result;
                if (_isEditMode)
                {
                    layanan.IdLayanan = _dataDiedit.IdLayanan;
                    result = _service.PerbaruiLayanan(layanan);
                }
                else
                {
                    result = _service.TambahLayanan(layanan);
                }
                if (result.IsSuccess)
                {
                    MessageBox.Show(result.Message);
                    //redirect ke LayananUC
                    _nav.LoadFitur(new LayananUC(_service, _nav));
                }
                else
                {
                    MessageBox.Show(result.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            _nav.LoadFitur(new LayananUC(_service, _nav));
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
            lblTambahLayanan.Text = _isEditMode ? $"Ubah Layanan \"{_dataDiedit.NamaLayanan}\"" : "Tambahkan Layanan Baru";
            btnAdd.Text = _isEditMode ? "    Simpan" : "     Tambahkan";
        }
        private void FillForm(M_Layanan layanan)
        {
            tbxNama.Text = layanan.NamaLayanan;
            numHarga.Value = layanan.Harga;
            tbxDeskripsi.Text = layanan.Deskripsi;
        }
        public void UpdateAddButtonState()
        {
            btnAdd.Enabled = !(string.IsNullOrWhiteSpace(tbxNama.Text) || numHarga.Value < 0);
        }

        private void tbxNama_TextChanged(object sender, EventArgs e)
        {
            UpdateAddButtonState();
        }
        private void numHarga_ValueChanged(object sender, EventArgs e)
        {
            UpdateAddButtonState();
        }
    }
}
