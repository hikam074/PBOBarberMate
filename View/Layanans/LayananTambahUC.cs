

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


using PBOBarberMate.App.Model;
using PBOBarberMate.App.Services;


namespace PBOBarberMate.View.Layanan
{
    public partial class LayananTambahUC : UserControl
    {
        public readonly bool _isEditMode;
        public readonly M_Layanan _layananDiedit;

        private readonly CommonAppServices _commonServices;

        private readonly LayananService _layananService;

        public LayananTambahUC(CommonAppServices commonServices, LayananService layananService)
        {
            InitializeComponent();

            _commonServices = commonServices;

            _layananService = layananService;

            _isEditMode = false;

            SetCancelButtonlHoverEvents(btnCancel, pictbxBack);
            SetAddButtonlHoverEvents(btnAdd, pictbxAdd);
        }

        public LayananTambahUC(CommonAppServices commonServices, LayananService layananService, M_Layanan layananDiedit)
        {
            InitializeComponent();

            _commonServices = commonServices;

            _layananService = layananService;

            _isEditMode = true;
            _layananDiedit = layananDiedit;

            // penyesuaian view
            tbxNamaLayanan.Text = layananDiedit.nama_layanan;
            tbxHargaLayanan.Text = layananDiedit.harga.ToString();
            btnAdd.Text = "Simpan Perubahan";
            lblTambahLayanan.Text = "Ubah Layanan " + layananDiedit.nama_layanan;
            SetCancelButtonlHoverEvents(btnCancel, pictbxBack);
            SetAddButtonlHoverEvents(btnAdd, pictbxAdd);
        }

        private void SetCancelButtonlHoverEvents(Control button, Control relatedControl)
        {
            button.MouseEnter += (s, e) => { button.BackColor = Color.Orange; relatedControl.BackColor = Color.Orange; };
            button.MouseLeave += (s, e) => { button.BackColor = Color.WhiteSmoke; relatedControl.BackColor = Color.WhiteSmoke; };
        }
        private void SetAddButtonlHoverEvents(Control button, Control relatedControl)
        {
            button.MouseEnter += (s, e) => { 
                button.BackColor = Color.Green; button.ForeColor = Color.White;
                relatedControl.BackColor = Color.Green;// relatedControl.image
            };
            button.MouseLeave += (s, e) => { 
                button.BackColor = Color.WhiteSmoke; button.ForeColor = Color.Black;
                relatedControl.BackColor = Color.WhiteSmoke;
            };
        }

        // KEMBALI KE LIHAT LAYANAN
        private void btnCancel_Click(object sender, EventArgs e)
        {
            _commonServices.MainAppInstance.LoadFeatureIntoActiveHomepageContent(new LayananUC(_commonServices, _layananService), "Layanan");
        }



        private void FormTambahLayanan_Load(object sender, EventArgs e)
        {
            UpdateAddButtonState();
        }

        // SUBMIT DATA KE DATABASE
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!ValidateInput())
            {
                return;
            }
            // ambil data dari V
            string nama_layanan_baru = tbxNamaLayanan.Text;
            int harga_baru = Int32.Parse(tbxHargaLayanan.Text);
            // konfirmasi berhasil
            bool berhasil = false;

            // konfirmasi
            DialogResult confirm = MessageBox.Show(
                $"Apakah Anda yakin?",
                "Konfirmasi",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );
            // konfirmasi yes
            if (confirm == DialogResult.Yes)
            {
                if (!_isEditMode)
                {
                    berhasil = _layananService.addLayanan(nama_layanan_baru, harga_baru);
                    if (berhasil) 
                    {
                        MessageBox.Show("Data \"" + nama_layanan_baru + "\" Berhasil Ditambahkan!");
                    }
                }
                else
                {
                    // ambil id
                    int id_diedit = _layananDiedit.id_layanan;
                    // lakukan
                    berhasil = _layananService.updateLayanan(id_diedit, nama_layanan_baru, harga_baru);
                    if (berhasil)
                    {
                        MessageBox.Show("Data \"" + nama_layanan_baru + "\" Berhasil diubah!");
                    }
                }
                if (berhasil)
                {
                    _commonServices.MainAppInstance.LoadFeatureIntoActiveHomepageContent(new LayananUC(_commonServices, _layananService), "Layanan");
                }
            }

        }


        private bool ValidateInput()
        {
            // not null
            if (string.IsNullOrWhiteSpace(tbxNamaLayanan.Text) || string.IsNullOrWhiteSpace(tbxHargaLayanan.Text))
            {
                MessageBox.Show("Nama Layanan dan Harga tidak boleh kosong.", "Validasi Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            // harga = int
            if (!int.TryParse(tbxHargaLayanan.Text, out _)) // Menggunakan '_' sebagai discard variable karena kita tidak butuh nilai parsed di sini, hanya sukses/gagalnya
            {
                MessageBox.Show("Harga harus berupa angka.", "Validasi Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }


        // ACTIVING ADD BTN IF NOT EMPTY
        private void tbxNamaLayanan_TextChanged(object sender, EventArgs e)
        {
            UpdateAddButtonState();
        }
        // ACTIVING ADD BTN IF NOT EMPTY
        private void tbxHargaLayanan_TextChanged(object sender, EventArgs e)
        {
            UpdateAddButtonState();
        }
        // METHOD ACTIVING ADD BTN IF NOT EMPTY
        public void UpdateAddButtonState()
        {
            btnAdd.Enabled = !(string.IsNullOrWhiteSpace(tbxNamaLayanan.Text) || string.IsNullOrWhiteSpace(tbxHargaLayanan.Text));
        }
    }
}
