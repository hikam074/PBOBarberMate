using PBOBarberMate.App.Context;
using PBOBarberMate.App.Model;
using PBOBarberMate.View.FormPembayaran;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PBOBarberMate.View.FormUlasan
{
    public partial class FormTambahUlasan : Form
    {
        public int id_pembayaran {  get; set; }
        public int id_layanan { get; set; }
        public int id_ulasan { get; set; }
        public bool IseditMode { get; set; }
        public FormTambahUlasan()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void bintang1_Click(object sender, EventArgs e)
        {
            if (bintang1.Visible = true)
            {
                bintang1.Visible = true;
                bintang2.Visible = false;
                bintang3.Visible = false;
                bintang4.Visible = false;
                bintang5.Visible = false;
            }
        }

        private void bintang2_Click(object sender, EventArgs e)
        {
            if (bintang2.Visible)
            {
                bintang1.Visible = true;
                bintang2.Visible = true;
                bintang3.Visible = false;
                bintang4.Visible = false;
                bintang5.Visible = false;
            }
        }

        private void bintang3_Click(object sender, EventArgs e)
        {
            if (bintang3.Visible)
            {
                bintang1.Visible = true;
                bintang2.Visible = true;
                bintang3.Visible = true;
                bintang4.Visible = false;
                bintang5.Visible = false;
            }
        }

        private void bintang4_Click(object sender, EventArgs e)
        {
            if (bintang4.Visible)
            {
                bintang1.Visible = true;
                bintang2.Visible = true;
                bintang3.Visible = true;
                bintang4.Visible = true;
                bintang5.Visible = false;
            }
        }

        private void bintang5_Click(object sender, EventArgs e)
        {
            if (bintang5.Visible)
            {
                bintang1.Visible = true;
                bintang2.Visible = true;
                bintang3.Visible = true;
                bintang4.Visible = true;
                bintang5.Visible = true;
            }
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            bintang1.Visible = true;
            bintang2.Visible = false;
            bintang3.Visible = false;
            bintang4.Visible = false;
            bintang5.Visible = false;
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            bintang1.Visible = true;
            bintang2.Visible = true;
            bintang3.Visible = false;
            bintang4.Visible = false;
            bintang5.Visible = false;
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            bintang1.Visible = true;
            bintang2.Visible = true;
            bintang3.Visible = true;
            bintang4.Visible = false;
            bintang5.Visible = false;
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            bintang1.Visible = true;
            bintang2.Visible = true;
            bintang3.Visible = true;
            bintang4.Visible = true;
            bintang5.Visible = false;
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            bintang1.Visible = true;
            bintang2.Visible = true;
            bintang3.Visible = true;
            bintang4.Visible = true;
            bintang5.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!ValidateInput())
            {
                MessageBox.Show("Mohon Isi Semua Data");
                return;
            }


            M_Ulasan ulasan = new M_Ulasan 
            {
                isi_ulasan = textBox1.Text, 
                id_pembayaran = id_pembayaran, 
            };
            if (bintang1.Visible)
            {
                ulasan.rating = 1;
            }
            if (bintang2.Visible)
            {
                ulasan.rating = 2;
            }
            if (bintang3.Visible)
            {
                ulasan.rating = 3;
            }
            if (bintang4.Visible)
            {
                ulasan.rating = 4;
            }
            if (bintang5.Visible)
            {
                ulasan.rating = 5;
            }

            MessageBox.Show($"Isi Ulasan: {ulasan.isi_ulasan}, Rating: {ulasan.rating}, ID Ulasan: {id_ulasan}");


            if (IseditMode == true)
            {
                ulasan.id_ulasan = id_ulasan;
                UlasanContext.UpdateUlasan(ulasan);
                MessageBox.Show("Ulasan Berhasil Diperbarui");
                FormLayanan formLayanan = new FormLayanan();
                formLayanan.Show();
                this.Hide();
            }
            else
            {
                //layanan.id_layanan = LayananId;
                UlasanContext.AddUlasan(ulasan);
                MessageBox.Show("Ulasan Berhasil Ditambah");
                this.DialogResult = DialogResult.OK;
                this.Hide();
                FormLayanan formLayanan = new FormLayanan();
                formLayanan.Show();
                this.Hide();
            }

            ClearFields();

        }

        private bool ValidateInput()
        {
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                return false;
            }
            return true;
        }
        public void PopulateForm(M_Ulasan ulasan)
        {
            // Isi ulasan ke textbox
            textBox1.Text = ulasan.isi_ulasan;

            // Tampilkan bintang sesuai rating ulasan
            bintang1.Visible = ulasan.rating >= 1;
            bintang2.Visible = ulasan.rating >= 2;
            bintang3.Visible = ulasan.rating >= 3;
            bintang4.Visible = ulasan.rating >= 4;
            bintang5.Visible = ulasan.rating >= 5;

            // Pastikan id_pembayaran terkait diatur
            id_pembayaran = ulasan.id_pembayaran;
        }

        private void ClearFields()
        {
            textBox1.Clear();
            bintang1.Visible = false;
            bintang2.Visible = false;
            bintang3.Visible = false;
            bintang4.Visible = false;
            bintang5.Visible = false;
        }

        private void FormTambahUlasan_Load(object sender, EventArgs e)
        {
            if (IseditMode)
            {
                button1.Text = "Perbarui Komentar"; // Ubah teks tombol menjadi "Perbarui Komentar"
                M_Ulasan ulasan = UlasanContext.getUlasanByID(id_ulasan); // Ambil data ulasan berdasarkan ID
                if (ulasan != null)
                {
                    PopulateForm(ulasan); // Isi form dengan data ulasan
                }
            }
            else
            {
                button1.Text = "Tambahkan Komentar"; // Teks tombol untuk mode tambah
            }
        }
    }
}
