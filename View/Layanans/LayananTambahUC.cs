

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
        public static bool IseditMode { get; set; }

        private readonly MainApp _mainApp;
        private readonly AkunService _akunService;
        private readonly SessionService _sessionService;

        public LayananTambahUC(MainApp mainApp, AkunService akunService, SessionService sessionService)
        {
            InitializeComponent();

            _mainApp = mainApp;
            _akunService = akunService;
            _sessionService = sessionService;

            //this.IseditMode ? "Update" : "Add";
            //UpdateButtonText();

            UpdateAddButtonState();

        }

        private void FormTambahLayanan_Load(object sender, EventArgs e)
        {

        }
        // KEMBALI KE LIHAT LAYANAN
        private void btnCancel_Click(object sender, EventArgs e)
        {
            _mainApp.LoadFeatureIntoActiveHomepageContent(new LayananUC(_akunService, _sessionService, _mainApp), "Layanan");
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!ValidateInput())
            {
                MessageBox.Show("Mohon Isi Semua Data");
                return;
            }
            //M_Layanan layanan = new M_Layanan { nama_layanan = textBox1.Text, harga = Convert.ToInt32(textBox2.Text)};
            if (IseditMode)
            {
                //layanan.id_layanan = LayananId;
                //LayananContext.UpdateLayanan(layanan);
                //MessageBox.Show("Layanan Berhasil Diperbarui");
            }
            else
            {
                //layanan.id_layanan = LayananId;
                //LayananContext.AddLayanan(layanan);
                //MessageBox.Show("Layanan Berhasil Ditambah");
            }
            tbxNamaLayanan.Clear();
            tbxHargaLayanan.Clear();
            //this.DialogResult = DialogResult.OK;
            //this.Hide();
        }
        public void PopulateForm(M_Layanan layanan)
        {
            tbxNamaLayanan.Text = layanan.nama_layanan;
            tbxHargaLayanan.Text = layanan.harga.ToString();
            IseditMode = true;
            //LayananId = layanan.id_layanan;
            //UpdateButtonText();
        }




        private bool ValidateInput()
        {
            if (string.IsNullOrEmpty(tbxNamaLayanan.Text) | string.IsNullOrEmpty(tbxHargaLayanan.Text))
            {
                return false;
            }
            return true;
        }

        private void tbxNamaLayanan_TextChanged(object sender, EventArgs e)
        {
            UpdateAddButtonState();
        }

        private void tbxHargaLayanan_TextChanged(object sender, EventArgs e)
        {
            UpdateAddButtonState();
        }
        public void UpdateAddButtonState()
        {
            btnAdd.Enabled = !(string.IsNullOrWhiteSpace(tbxNamaLayanan.Text) || string.IsNullOrWhiteSpace(tbxHargaLayanan.Text));
        }
    }
}
