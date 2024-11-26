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
using PBOBarberMate.App.Model;


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
            List<string> dataWaktu = ReservasiContext.getDataWaktuByTanggal(dtpTanggal.Value);
            cbxWaktu.Items.AddRange(dataWaktu.ToArray());

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
                idLayananDipilih = selected.Key;
                string NamaDipilih = selected.Value;
                lblConfirmLayanan.Text = NamaDipilih;
            }
        }
        private int idLayananDipilih;

        private void dtpTanggal_ValueChanged(object sender, EventArgs e)
        {
            lblConfirmTanggal.Text = dtpTanggal.Value.ToLongDateString();
            if (cbxWaktu.Items != null)
            {
                cbxWaktu.Items.Clear();
                loadcbxWaktuData(dtpTanggal.Value.ToShortDateString());
            }
            else
            {
                loadcbxWaktuData(dtpTanggal.Value.ToShortDateString());
            }
        }

        private void cbxWaktu_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblConfirmWaktu.Text = cbxWaktu.SelectedItem.ToString();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            DialogResult lanjut = MessageBox.Show(
                "Apakah anda yakin?",
                "Konfirmasi",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );
            if (lanjut == DialogResult.Yes)
            {
                M_Reservasi reservasi = new M_Reservasi(idLayananDipilih, DateOnly.FromDateTime(dtpTanggal.Value), TimeOnly.Parse(cbxWaktu.SelectedItem.ToString()));
                bool berhasilReservasi = ReservasiContext.addreservasi(reservasi);
                if (berhasilReservasi == true)
                {
                    FormHomepageCustomer formHomepageCustomer = new FormHomepageCustomer();
                    formHomepageCustomer.Show();
                    this.Hide();
                }
            }
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

        private void FormBuatReservasi_Load(object sender, EventArgs e)
        {

        }
    }
}