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

namespace PBOBarberMate.View.FormInventaris
{
    public partial class FormTambahInventaris : Form
    {
        public bool IseditMode { get; set; }
        public int InventarisID { get; set; }
        public FormTambahInventaris()
        {
            InitializeComponent();
            UpdateButtonText();
        }

        private void FormTambahInventaris_Load(object sender, EventArgs e)
        {

        }
        public void PopulateForm(M_Inventaris inventaris)
        {
            textBox1.Text = inventaris.nama_barang;
            textBox2.Text = inventaris.jumlah_barang.ToString();
            IseditMode = true;
            InventarisID = inventaris.id_barang;
            UpdateButtonText();
        }
        private void UpdateButtonText()
        {
            btnAdd.Text = IseditMode ? "Update" : "Add";
        }
        private bool ValidateInput()
        {
            if (string.IsNullOrEmpty(textBox1.Text) | string.IsNullOrEmpty(textBox2.Text))
            {
                return false;
            }
            return true;
        }
        private void ClearFields()
        {
            textBox1.Clear();
            textBox2.Clear();
        }

        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            if (!ValidateInput())
            {
                MessageBox.Show("Mohon Isi Semua Data");
                return;
            }
            M_Inventaris inventaris = new M_Inventaris { nama_barang = textBox1.Text, jumlah_barang = Convert.ToInt32(textBox2.Text) };
            if (IseditMode)
            {
                inventaris.id_barang = InventarisID;
                InventarisContext.UpdateInventaris(inventaris);
                MessageBox.Show("Inventaris Berhasil Diperbarui");
            }
            else
            {
                InventarisContext.AddInventaris(inventaris);
                MessageBox.Show("Inventaris Berhasil Ditambah");
            }
            ClearFields();
            this.DialogResult = DialogResult.OK;
            this.Hide();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
