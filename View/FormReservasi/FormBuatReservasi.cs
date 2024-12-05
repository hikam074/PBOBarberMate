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


namespace PBOBarberMate.View.FormReservasi
{
    public partial class FormBuatReservasi : Form
    {
        public bool modeEdit { get; set; }
        public int editedReservasiID { get; set; }
        private int idLayananDipilih;


        public FormBuatReservasi()
        {
            InitializeComponent();
            // mengatur minimal tanggal yang dapat dipilih untuk reservasi adalah h-1
            dtpTanggal.MinDate = DateTime.Now.AddDays(1);
            // mengganti nama pereservasi dengan nama logged
            lblConfirmNama.Text = UserSession.nama;
            // load data layanan
            loadcbxLayananData();
            // mengganti tampilan untuk mode edit
            updateForEditText();
        }

        private void loadcbxLayananData()
        {
            // mendapatkan data layanan dari db
            var dataLayanan = ReservasiContext.getDataLayananByIdNama();
            // menambahkan data layanan ke cbxLayanan
            foreach (var layanan in dataLayanan)
            {
                cbxLayanan.Items.Add(layanan);
            }
            // menjadikan yang dimunculkan di cbxLayanan adalah namanya
            cbxLayanan.DisplayMember = "Value";
            // menjadikan yang diambil dari cbxLayanan untuk diinteraksikan di db adalah id_layanan nya
            cbxLayanan.ValueMember = "Key";
        }

        private void loadcbxWaktuData(string date)
        {
            // mendapatkan data waktu berdasarkan kesediaan waktu di tanggal yang dipilih
            List<string> dataWaktu = ReservasiContext.getDataWaktuByTanggal(dtpTanggal.Value);
            // menambahkan list ke cbxWaktu
            cbxWaktu.Items.AddRange(dataWaktu.ToArray());
        }

        private void updateForEditText()
        {
            // mengubah lblHeading.Text sesuai kondisi mode edit true / false
            lblHeading.Text = modeEdit ? "Ubah Reservasi" : "Buat Reservasi";
            // mengubah btnSubmit.Text sesuai kondisi mode edit true / false
            btnSubmit.Text = modeEdit ? "Simpan Perubahan" : "Buat Reservasi";
        }

        public void changeToEdit(int id)
        {
            // beralih ke mode edit
            modeEdit = true;
            // mendapatkan id_reservasi berapa yang diedit
            editedReservasiID = id;
            // mengganti tampilanmenjadi tampilan edit
            updateForEditText();
        }

        private void btnKembali_Click(object sender, EventArgs e)
        {
            // bila bukan mode edit maka kembali ke FormHomepage Customer
            if (modeEdit == false)
            {
                FormHomepageCustomer formHomepageCustomer = new FormHomepageCustomer();
                formHomepageCustomer.Show();
                this.Hide();
            }
            // bila mode edit maka form ini ditutup dan bisa kembali menggunakan form sebelumnya
            else
            {
                this.modeEdit = false;
                this.Hide();
            }
        }

        private void cbxLayanan_SelectedIndexChanged(object sender, EventArgs e)
        {
            // bila cbxLayanan sudah dipilih sebelumnya maka nilai yang dipilih akan diupdate
            if (cbxLayanan.SelectedIndex != null)
            {
                // mengambil apa yang dipilih
                KeyValuePair<int, string> selected = (KeyValuePair<int, string>)cbxLayanan.SelectedItem;
                // mengambil id_layanan dari KeyValuePair selected
                idLayananDipilih = selected.Key;
                // mengambil nama_layanan dari KeyValuePair selected
                string NamaDipilih = selected.Value;
                // mengubah lblConfirmLayanan.Text menjadi yang terbaru
                lblConfirmLayanan.Text = NamaDipilih;
            }
        }

        private void dtpTanggal_ValueChanged(object sender, EventArgs e)
        {
            // mengubah lblConfirmTanggal.Text menjadi nilai terbaru
            lblConfirmTanggal.Text = dtpTanggal.Value.ToLongDateString();
            // bila cbxWaktu sudah dipilih sebelumnya
            if (cbxWaktu.Items != null)
            {
                // maka cbxWaktu dikosongkan
                cbxWaktu.Items.Clear();
                // kemudian diisi dengan data terbaru
                loadcbxWaktuData(dtpTanggal.Value.ToShortDateString());
            }
            // bila cbxWaktu kosong
            else
            {
                // maka cbxWaktu diisi berdasarkan tersedianya jam di db
                loadcbxWaktuData(dtpTanggal.Value.ToShortDateString());
            }
        }

        private void cbxWaktu_SelectedIndexChanged(object sender, EventArgs e)
        {
            // mengubah lblConfirmWaktu.Text sesuai nilai yang dipilih
            lblConfirmWaktu.Text = cbxWaktu.SelectedItem.ToString();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            // membuat object MessageBox untuk konfirmasi
            DialogResult lanjut = MessageBox.Show(
                "Apakah anda yakin?",
                "Konfirmasi",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );
            // memunculkan MessageBox
            if (lanjut == DialogResult.Yes) // konfirmasi yes untuk membuat/mengubah data
            {
                // bila tidak sedang di mode edit
                if (modeEdit == false)
                {
                    // maka reservasi akan ditambahkan
                    // membuat object terlebih dahulu, dan pengecekan-pengecekan
                    M_Reservasi reservasi = new M_Reservasi(idLayananDipilih, DateOnly.FromDateTime(dtpTanggal.Value), TimeOnly.Parse(cbxWaktu.SelectedItem.ToString()));
                    // menambahkan reservasi ke db
                    bool berhasilReservasi = ReservasiContext.addreservasi(reservasi);
                    // bila reservasi berhasil ditambahkan
                    if (berhasilReservasi == true)
                    {
                        MessageBox.Show("Reservasi berhasil ditambahkan!");
                        // kembali ke FormHomepageReservasi
                        FormHomepageCustomer formHomepageCustomer = new FormHomepageCustomer();
                        formHomepageCustomer.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Error! Tidak dapat menambahkan reservasi");
                    }
                }
                // bila sedang di mode edit
                else if (modeEdit == true)
                {
                    // maka reservasi akan diedit
                    // membuat object terlebih dahulu, dan pengecekan-pengecekan
                    M_Reservasi reservasi = new M_Reservasi(idLayananDipilih, DateOnly.FromDateTime(dtpTanggal.Value), TimeOnly.Parse(cbxWaktu.SelectedItem.ToString()));
                    // mengubah reservasi dipilih di db
                    int berhasilReservasi = ReservasiContext.updateReservasi(reservasi, editedReservasiID);
                    // bila reservasi berhasil diedit
                    if (berhasilReservasi > 0 )
                    {
                        MessageBox.Show("Reservasi berhasil diubah!");
                        this.modeEdit = false;
                        // kembali ke form sebelumnya
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Error! Tidak dapat mengubah reservasi");
                    }
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