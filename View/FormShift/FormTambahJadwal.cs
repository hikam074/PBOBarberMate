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
using PBOBarberMate.App.Model;

namespace PBOBarberMate.View.FormShift
{
    public partial class FormTambahJadwal : Form
    {
        public bool IsEditMode { get; set; }
        public int ShiftId { get; set; }

        public FormTambahJadwal()
        {
            InitializeComponent();
            UpdateButtonText();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblAddJadwal_Click(object sender, EventArgs e)
        {

        }

        private void FormTambahJadwal_Load(object sender, EventArgs e)
        {
            LoadAkunList();
            LoadHariList();
        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            FormShift formShift = new FormShift();
            this.Hide();
            formShift.Show();
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            if (!ValidateInput())
            {
                MessageBox.Show("Mohon pilih Nama Akun dan Hari.");
                return;
            }

            // Buat objek jadwal baru
            M_Shift shift = new M_Shift();

            shift.id_akun = Convert.ToInt32(comboBoxAkun.SelectedValue);
            shift.id_hari = Convert.ToInt32(comboBoxHari.SelectedValue);

            // Mode edit atau tambah
            if (IsEditMode)
            {
                shift.id_shift = ShiftId;
                ShiftContext.UpdateShift(shift);
                MessageBox.Show("Jadwal berhasil diperbarui.");
            }
            else
            {
                ShiftContext.AddShift(shift);
                MessageBox.Show("Jadwal berhasil ditambahkan.");
            }

            // Bersihkan input dan tutup form
            this.DialogResult = DialogResult.OK;
            this.Hide();
        }

        public void PopulateForm(M_Shift shift)
        {
            comboBoxAkun.SelectedValue = shift.id_akun;
            comboBoxHari.SelectedValue = shift.id_hari;
            IsEditMode = true;
            ShiftId = shift.id_shift;
            UpdateButtonText();
        }

        private void UpdateButtonText()
        {
            // Ubah teks tombol berdasarkan mode (Tambah/Edit)
            btnTambah.Text = IsEditMode ? "Update" : "Add";
        }

        private void LoadAkunList()
        {
            try
            {
                // Ambil data akun dari ShiftContext
                DataTable akunList = ShiftContext.GetAkunList();

                // Isi comboBoxAkun dengan data akun
                comboBoxAkun.DataSource = akunList;
                comboBoxAkun.DisplayMember = "nama_akun"; // Tampilkan nama akun
                comboBoxAkun.ValueMember = "id_akun"; // Gunakan id_akun sebagai nilai yang dipilih
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading Akun list: {ex.Message}");
            }
        }

        private void LoadHariList()
        {
            try
            {
                // Ambil data hari dari ShiftContext
                DataTable hariList = ShiftContext.GetHariList();

                // Isi comboBoxHari dengan data hari
                comboBoxHari.DataSource = hariList;
                comboBoxHari.DisplayMember = "nama_hari"; // Tampilkan nama hari
                comboBoxHari.ValueMember = "id_hari"; // Gunakan id_hari sebagai nilai yang dipilih
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading Hari list: {ex.Message}");
            }
        }

        private bool ValidateInput()
        {
            return comboBoxAkun.SelectedValue != null && comboBoxHari.SelectedValue != null;
        }

        private void comboBoxHari_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxAkun_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
