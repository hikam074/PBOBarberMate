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
    public partial class FormEditPembayaran : Form
    {
        public int id_reservasi;
        public int id_pembayaran;


        public FormEditPembayaran()
        {
            InitializeComponent();
            LoadEnumMetodePembayaran();
            //lblConfirmLayanan.Text = "";
            //lblConfirmNama.Text = "";
            //lblConfirmTanggal.Text = "";
            //lblConfirmWaktu.Text = "";
        }


        public void LoadEnumMetodePembayaran()
        {
            var enumMetode = Enum.GetValues(typeof(metodePembayaran));
            foreach (var metode in enumMetode)
            {
                cbxMetodePembayaran.Items.Add(metode);

            }
        }

        private void btnKembali_Click(object sender, EventArgs e)
        {
            // kembali ke homepage
            FormHomepageAdmin formHomepageAdmin = new FormHomepageAdmin();
            formHomepageAdmin.Show();
            this.Hide();
        }

        private void cbxMetodePembayaran_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblConfirmMetodePembayaran.Text = cbxMetodePembayaran.SelectedItem.ToString();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            M_Pembayaran pembayaran = new M_Pembayaran(id_pembayaran, Convert.ToInt32(lblConfirmHarga.Text), (int)(metodePembayaran)Enum.Parse(typeof(metodePembayaran), cbxMetodePembayaran.SelectedItem.ToString()));
            bool berhasil_bayar = PembayaranContext.updatePembayaran(pembayaran);
            if (berhasil_bayar == true)
            {
                MessageBox.Show("Pembayaran berhasil ditambahkan!");
                FormHomepageAdmin formHomepageAdmin = new FormHomepageAdmin();
                formHomepageAdmin.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Data gagal ditambahkan!");
            }
        }

        private void tbxHarga_TextChanged(object sender, EventArgs e)
        {
            lblConfirmHarga.Text = tbxHarga.Text;
        }
    }
}