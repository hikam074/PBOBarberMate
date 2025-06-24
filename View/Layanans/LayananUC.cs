using Npgsql;

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
using PBOBarberMate.App.Repository;


namespace PBOBarberMate.View.Layanan
{
    public partial class LayananUC : UserControl
    {
        private readonly AkunService _akunService;
        private readonly SessionService _sessionService;
        private readonly MainApp _mainApp;

        private readonly LayananService _layananService;


        public LayananUC(AkunService akunService, SessionService sessionService, MainApp mainApp)
        {
            InitializeComponent();
            _akunService = akunService;
            _sessionService = sessionService;
            _mainApp = mainApp;
            _layananService = new LayananService(new LayananRepository());

            this.Load += FormLayanan_Load;
        }
        private void FormLayanan_Load(object sender, EventArgs e)
        {
            LoadDgvLayanan();
            EnableButtonAdd();
        }
        private void LoadDgvLayanan()
        {
            List<M_Layanan> daftarLayanan = _layananService.getAllLayanan();
            DataTable dtLayanan = ConvertLayananListToDataTable(daftarLayanan);
            dgvLayanan.DataSource = dtLayanan;
            dgvLayanan.AutoGenerateColumns = false;
            dgvLayanan.RowHeadersVisible = false;
            dgvLayanan.AllowUserToAddRows = false;
        }
        private DataTable ConvertLayananListToDataTable(List<M_Layanan> layananList)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("ID Layanan", typeof(int));
            dt.Columns.Add("Nama Layanan", typeof(string));
            dt.Columns.Add("Harga", typeof(int));
            foreach (M_Layanan layanan in layananList)
            {
                dt.Rows.Add(layanan.id_layanan, layanan.nama_layanan, layanan.harga);
            }

            return dt;
        }

        private void EnableButtonAdd()
        {
            if (_sessionService.CurrentUserRole == AkunRole.admin)
            {
                btnTambah.Visible = true; // Tombol Tambah ditampilkan untuk Admin
            }
            else
            {
                btnTambah.Visible = false; // Tombol Tambah disembunyikan untuk role lain
            }
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            _mainApp.LoadFeatureIntoActiveHomepageContent(new LayananTambahUC(_mainApp, _akunService, _sessionService), "Tambah Layanan");
        }
    }
}
