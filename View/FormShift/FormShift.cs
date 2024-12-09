using PBOBarberMate.App.Context;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBOBarberMate.View.FormShift
{
    public partial class FormShift : Form
    {
        public FormShift()
        {
            InitializeComponent();
        }

        private void FormShift_Load(object sender, EventArgs e)
        {
            try
            {
                DataTable dataShift = ShiftContext.All();

                dgvJadwalShift.DataSource = dataShift;

                dgvJadwalShift.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }

            catch (Exception ex)
            {
                MessageBox.Show($"Error loading shift data: {ex.Message}");
            }

        }

        private void dgvJadwalShift_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAddJadwal_Click(object sender, EventArgs e)
        {
            FormTambahJadwal formTambahJadwal = new FormTambahJadwal();
            formTambahJadwal.Show();
            this.Hide();
        }

        private void btnKembali_Click(object sender, EventArgs e)
        {
            FormHomepageAdmin formHomepageAdmin = new FormHomepageAdmin();
            this.Hide();
            formHomepageAdmin.Show();
        }
    }
}
