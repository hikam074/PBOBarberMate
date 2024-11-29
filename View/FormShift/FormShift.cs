using PBOBarberMate.App.Context;
using PBOBarberMate.App.Core;
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

        private void btnKembali_Click(object sender, EventArgs e)
        {
            // menampilkan form homepage admin bila logged sebagai admin
            if (UserSession.role == AkunRole.Admin)
            {
                FormHomepageAdmin formHomepageAdmin = new FormHomepageAdmin();
                formHomepageAdmin.Show();
                this.Hide();
            }
            // menampilkan form homepage karyawan bila logged sebagai karyawan
            else if (UserSession.role == AkunRole.Karyawan)
            {
                FormHomepageKaryawan formHomepageKaryawan = new FormHomepageKaryawan();
                formHomepageKaryawan.Show();
                this.Hide();
            }
            // menampilkan form homepage customer bila logged sebagai customer
            else if (UserSession.role == AkunRole.Customer)
            {
                FormHomepageCustomer formHomepageCustomer = new FormHomepageCustomer();
                formHomepageCustomer.Show();
                this.Hide();
            }
        }

        private void btnAddJadwal_Click(object sender, EventArgs e)
        {
            FormTambahJadwal formTambahJadwal = new FormTambahJadwal();
            formTambahJadwal.Show();
            this.Hide();
        }
    }
}
