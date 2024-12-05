using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using PBOBarberMate.App.Context;
using PBOBarberMate.App.Core;
using PBOBarberMate.App.Model;


namespace PBOBarberMate.View.FormPembayaran
{
    public partial class FormAddPembayaran : Form
    {
        public int id_reservasi;


        public FormAddPembayaran()
        {
            InitializeComponent();
            dgvPilihReservasi.CellClick += dgvPilihReservasi_CellClick;
            LoadEnumMetodePembayaran();
        }


        public void LoadEnumMetodePembayaran()
        {
            var enumMetode = Enum.GetValues(typeof(metodePembayaran));
            foreach (var metode in enumMetode)
            {
                cbxMetodePembayaran.Items.Add(metode);

            }
        }

        //public void LoadDataReservasi()
        //{
        //    try
        //    {
        //        //DataTable daftarReservasi = PembayaranContext.getDataReservasiByNama(DateOnly.FromDateTime(dtpTanggal.Value), );

        //        //dgvPilihReservasi.DataSource = daftarReservasi;
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show($"Terjadi kesalahan [PBOBarberMate.View.FormPembayaran.FormAddPembayaran.LoadDataReservasi] : {ex}");
        //    }
        //}

        private void btnKembali_Click(object sender, EventArgs e)
        {
            // kembali ke homepage
            FormHomepageAdmin formHomepageAdmin = new FormHomepageAdmin();
            formHomepageAdmin.Show();
            this.Hide();
        }

        private void dtpTanggal_ValueChanged(object sender, EventArgs e)
        {
            lblConfirmTanggal.Text = dtpTanggal.Value.ToLongDateString();
            tbxNama.Text = null;
            dgvPilihReservasi.DataSource = null;
            tbxNama.Text = null;
            lblConfirmNama.Text = "---";
            lblConfirmLayanan.Text = "---";
            lblConfirmWaktu.Text = "---";
            lblConfirmHarga.Text = "---";
        }

        private void tbxNama_TextChanged(object sender, EventArgs e)
        {
            try
            {
                // membuat datatable untuk ditampilkan di dgvPilihReservasi
                DataTable daftarReservasi = PembayaranContext.getDataReservasiByNama(DateOnly.FromDateTime(dtpTanggal.Value), tbxNama.Text);
                // assign data ke datagridview
                dgvPilihReservasi.DataSource = daftarReservasi;
                // menghilangkan kolom id_reservasi
                if (dgvPilihReservasi.Columns.Contains("ID Reservasi"))
                {
                    dgvPilihReservasi.Columns["ID Reservasi"].Visible = false;
                }
                if (dgvPilihReservasi.Columns.Contains("Harga"))
                {
                    dgvPilihReservasi.Columns["Harga"].Visible = false;
                }
                // behaviour table
                dgvPilihReservasi.AllowUserToAddRows = false;
                dgvPilihReservasi.RowHeadersVisible = false;
                dgvPilihReservasi.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvPilihReservasi.Columns["Waktu"].Width = 48;
                dgvPilihReservasi.Columns["Layanan"].Width = 100;
                dgvPilihReservasi.Columns["Nama"].Width = 138;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Terjadi kesalahan [PBOBarberMate.View.FormPembayaran.FormAddPembayaran.tbxNama_TextChanged]");
            }
        }

        private void dgvPilihReservasi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                lblConfirmNama.Text = dgvPilihReservasi.Rows[e.RowIndex].Cells[1].Value.ToString();
                lblConfirmWaktu.Text = dgvPilihReservasi.Rows[e.RowIndex].Cells[2].Value.ToString();
                lblConfirmLayanan.Text = dgvPilihReservasi.Rows[e.RowIndex].Cells[3].Value.ToString();
                lblConfirmHarga.Text = dgvPilihReservasi.Rows[e.RowIndex].Cells[4].Value.ToString();
                this.id_reservasi = Convert.ToInt32(dgvPilihReservasi.Rows[e.RowIndex].Cells[0].Value);
            }
        }

        private void cbxMetodePembayaran_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblConfirmMetodePembayaran.Text = cbxMetodePembayaran.SelectedItem.ToString();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            M_Pembayaran pembayaran = new M_Pembayaran(id_reservasi, Convert.ToInt32(lblConfirmHarga.Text), cbxMetodePembayaran.SelectedIndex);
            MessageBox.Show("yeay");
        }
    }
}