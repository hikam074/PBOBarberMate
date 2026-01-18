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
    using PBOBarberMate.Core.Entities;
    using PBOBarberMate.Core.Interfaces;

    public partial class InventoryTambahUC : UserControl, IPageFeature
    {
        //public readonly bool _isEditMode;
        //public readonly M_Inventaris _inventarisDiedit;


        public string PageTitle => "Tambah Barang Baru";
        private readonly InventoryService _service;
        private readonly INavigationService _nav;

        public InventoryTambahUC(InventoryService service, INavigationService nav)
        {
            InitializeComponent();
            _service = service;
            _nav = nav;
            //_isEditMode = false;
            SetCancelButtonlHoverEvents(btnCancel, pictbxBack);
            SetAddButtonlHoverEvents(btnAdd, pictbxAdd, pictbxAddHov);
        }

        private void InventarisTambahUC_Load(object sender, EventArgs e)
        {
            UpdateAddButtonState();
            //if (_commonServices.SessionServiceInstance.CurrentUserRole == AkunRole.admin)
            //{
            //    tbxNama.Enabled = true;
            //}
            //else
            //{
            //    tbxNama.Enabled = false;
            //}
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
                var result = _service.TambahBarang(barang);
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





            //if (!ValidateInput())
            //{
            //    return;
            //}
            //// ambil data dari V
            //string nama = tbxNama.Text;
            //int jumlah = Int32.Parse(tbxJumlah.Text);
            //// konfirmasi berhasil
            //bool berhasil = false;

            //// konfirmasi
            //DialogResult confirm = MessageBox.Show(
            //    $"Apakah Anda yakin?",
            //    "Konfirmasi",
            //    MessageBoxButtons.YesNo,
            //    MessageBoxIcon.Question
            //);
            //// konfirmasi yes
            //if (confirm == DialogResult.Yes)
            //{
            //    if (!_isEditMode)
            //    {
            //        berhasil = _inventarisService.addInventaris(nama, jumlah);
            //        if (berhasil)
            //        {
            //            MessageBox.Show("Data \"" + nama + "\" Berhasil Ditambahkan!");
            //        }
            //    }
            //    else
            //    {
            //        // ambil id
            //        int id_diedit = _inventarisDiedit.id_barang;

            //        // lakukan
            //        berhasil = _inventarisService.updateInventaris(id_diedit, nama, jumlah);
            //        if (berhasil)
            //        {
            //            MessageBox.Show("Data \"" + nama + "\" Berhasil diubah!");
            //        }
            //    }
            //    if (berhasil)
            //    {
            //        _commonServices.MainAppInstance.LoadFeatureIntoActiveHomepageContent(new InventarisUC(_commonServices, _inventarisService), "Inventaris Barang");
            //    }
            //}

        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            _nav.LoadFitur(new InventoryUC(_service, _nav));
        }

        //public InventarisTambahUC(CommonAppServices commonServices, InventarisService inventarisService, M_Inventaris inventarisDiedit)
        //{
        //    InitializeComponent();

        //    _commonServices = commonServices;

        //    _inventarisService = inventarisService;

        //    _isEditMode = true;
        //    _inventarisDiedit = inventarisDiedit;

        //    // penyesuaian view
        //    tbxNama.Text = inventarisDiedit.nama_barang;
        //    tbxJumlah.Text = inventarisDiedit.jumlah_barang.ToString();
        //    btnAdd.Text = "      Simpan Perubahan";
        //    lblTambahInventaris.Text = "Ubah Inventaris " + inventarisDiedit.nama_barang;
        //    SetCancelButtonlHoverEvents(btnCancel, pictbxBack);
        //    SetAddButtonlHoverEvents(btnAdd, pictbxAdd, pictbxAddHov);
        //    AdjustPictbxAddPosition();
        //}

        private void SetCancelButtonlHoverEvents(Control button, Control relatedControl)
        {
            button.MouseEnter += (s, e) => { button.BackColor = Color.Orange; relatedControl.BackColor = Color.Orange; };
            button.MouseLeave += (s, e) => { button.BackColor = Color.WhiteSmoke; relatedControl.BackColor = Color.WhiteSmoke; };
        }
        private void SetAddButtonlHoverEvents(Control button, Control relatedControl, Control relatedHovControl)
        {
            button.MouseEnter += (s, e) =>
            {
                button.BackColor = Color.Green; button.ForeColor = Color.White;
                relatedHovControl.BackColor = Color.Green; relatedHovControl.Visible = true; relatedHovControl.BringToFront();
                relatedControl.Visible = false;
            };
            button.MouseLeave += (s, e) =>
            {
                button.BackColor = Color.WhiteSmoke; button.ForeColor = Color.Black;
                relatedHovControl.Visible = false;
                relatedControl.Visible = true;
            };
        }
        //private void AdjustPictbxAddPosition()
        //{
        //    if (btnAdd != null && pictbxAdd != null && pictbxAddHov != null)
        //    {
        //        int x = btnAdd.Location.X + 7;
        //        int y = btnAdd.Location.Y + (btnAdd.Height - pictbxAdd.Height) / 2;

        //        pictbxAddHov.Location = new Point(x, y);
        //        pictbxAdd.Location = new Point(x, y);
        //        pictbxAdd.BringToFront();
        //    }
        //}
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
