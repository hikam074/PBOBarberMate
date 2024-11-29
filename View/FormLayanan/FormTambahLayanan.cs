using PBOBarberMate.App.Context;
using PBOBarberMate.App.Model;
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

namespace PBOBarberMate.View
{
    public partial class FormTambahLayanan : Form
    {
        public bool IseditMode {  get; set; }
        public int LayananId { get; set; }
        public FormTambahLayanan()
        {
            InitializeComponent();
            UpdateButtonText();

        }

        private void FormTambahLayanan_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!ValidateInput())
            {
                MessageBox.Show("Mohon Isi Semua Data");
                return;
            }
            M_Layanan layanan = new M_Layanan { nama_layanan = textBox1.Text, harga = Convert.ToInt32(textBox2.Text)};
            if (IseditMode)
            {
                layanan.id_layanan = LayananId;
                LayananContext.UpdateLayanan(layanan);
                MessageBox.Show("Layanan Berhasil Diperbarui");
            }
            else
            {
                //layanan.id_layanan = LayananId;
                LayananContext.AddLayanan(layanan);
                MessageBox.Show("Layanan Berhasil Ditambah");
            }
            ClearFields();
            this.DialogResult = DialogResult.OK;
            this.Hide();
        }
        public void PopulateForm(M_Layanan layanan)
        {
            textBox1.Text = layanan.nama_layanan;
            textBox2.Text = layanan.harga.ToString();
            IseditMode = true;
            LayananId = layanan.id_layanan;
            UpdateButtonText();
        }

        private void UpdateButtonText()
        {
            btnAdd.Text = IseditMode ? "Update" : "Add";
        }
        private bool ValidateInput()
        {
            if (string.IsNullOrEmpty(textBox1.Text) | string.IsNullOrEmpty(textBox2.Text)){
                return false;
            }
            return true;
        }
        private void ClearFields()
        {
            textBox1.Clear();
            textBox2.Clear();
        }
    }
}
