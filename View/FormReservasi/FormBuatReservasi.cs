using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using PBOBarberMate.App.Core;
using PBOBarberMate.App.Context;


namespace PBOBarberMate.View
{
    public partial class FormBuatReservasi : Form
    {
        public FormBuatReservasi()
        {
            InitializeComponent();
            lblConfirmNama.Text = UserSession.nama;
            loadcbxLayananData();
        }
        private void loadcbxLayananData()
        {
            var dataLayanan = ReservasiContext.getDataLayananByIdNama();
            foreach (var layanan in dataLayanan)
            {
                cbxLayanan.Items.Add(layanan);
            }
            cbxLayanan.DisplayMember = "Value";
            cbxLayanan.ValueMember = "Key";
        }
        private void loadcbxWaktuData(string date)
        {
            var dataWaktu = ReservasiContext.getDataWaktuByTanggal();
        }
        private void btnKembali_Click(object sender, EventArgs e)
        {
            FormHomepageCustomer formHomepageCustomer = new FormHomepageCustomer();
            formHomepageCustomer.Show();
            this.Hide();
        }

        private void cbxLayanan_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxLayanan.SelectedIndex != null)
            {
                KeyValuePair<int, string> selected = (KeyValuePair<int, string>)cbxLayanan.SelectedItem;
                int IdDipilih = selected.Key;
                string NamaDipilih = selected.Value;

                lblConfirmLayanan.Text = NamaDipilih;
            }
        }
        private void dtpTanggal_ValueChanged(object sender, EventArgs e)
        {
            lblConfirmTanggal.Text = dtpTanggal.Value.ToLongDateString();
            loadcbxWaktuData(dtpTanggal.Value.ToShortDateString());
        }
        private void lblConfirmNama_TextChanged(object sender, EventArgs e)
        {
            if (lblConfirmNama.Text == "---" || lblConfirmLayanan.Text == "---" || lblConfirmTanggal.Text == "---" || lblConfirmWaktu.Text == "---")
            {
                btnSubmit.Enabled = false;
            }
            else
            {
                btnSubmit.Enabled = true;
            }
        }
        private void lblConfirmLayanan_TextChanged(object sender, EventArgs e)
        {
            if (lblConfirmNama.Text == "---" || lblConfirmLayanan.Text == "---" || lblConfirmTanggal.Text == "---" || lblConfirmWaktu.Text == "---")
            {
                btnSubmit.Enabled = false;
            }
            else
            {
                btnSubmit.Enabled = true;
            }
        }
        private void lblConfirmTanggal_TextChanged(object sender, EventArgs e)
        {
            if (lblConfirmNama.Text == "---" || lblConfirmLayanan.Text == "---" || lblConfirmTanggal.Text == "---" || lblConfirmWaktu.Text == "---")
            {
                btnSubmit.Enabled = false;
            }
            else
            {
                btnSubmit.Enabled = true;
            }
        }
        private void lblConfirmWaktu_TextChanged(object sender, EventArgs e)
        {
            if (lblConfirmNama.Text == "---" || lblConfirmLayanan.Text == "---" || lblConfirmTanggal.Text == "---" || lblConfirmWaktu.Text == "---")
            {
                btnSubmit.Enabled = false;
            }
            else
            {
                btnSubmit.Enabled = true;
            }
        }
    }
}
