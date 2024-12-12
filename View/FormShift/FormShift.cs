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
                LoadData();

                SetupDataGridView();
            }

            catch (Exception ex)
            {
                MessageBox.Show($"Error loading shift data: {ex.Message}");
            }

        }

        private void LoadData()
        {
            try
            {
                DataTable dataShift = ShiftContext.All(); // Ambil data shift dari database
                dgvJadwalShift.DataSource = dataShift;    // Tampilkan data pada DataGridView
                dgvJadwalShift.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                if (dgvJadwalShift.Columns["nama_akun"] != null)
                    dgvJadwalShift.Columns["nama_akun"].HeaderText = "Nama Karyawan";

                if (dgvJadwalShift.Columns["nama_hari"] != null)
                    dgvJadwalShift.Columns["nama_hari"].HeaderText = "Hari";

                if (dgvJadwalShift.Columns["id_akun"] != null)
                    dgvJadwalShift.Columns["id_akun"].Visible = false;

                if (dgvJadwalShift.Columns["id_hari"] != null)
                    dgvJadwalShift.Columns["id_hari"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error refreshing data: {ex.Message}");
            }
        }

        private void dgvJadwalShift_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvJadwalShift.CellClick += dgvJadwalShift_CellClick;
        }

        private void SetupDataGridView()
        {
            if (dgvJadwalShift.Columns["Ubah"] == null)
            {
                // Tambahkan kolom tombol "Edit"
                DataGridViewButtonColumn editButtonColumn = new DataGridViewButtonColumn();
                editButtonColumn.Name = "Ubah";
                editButtonColumn.HeaderText = "Ubah";
                editButtonColumn.Text = "Ubah";
                editButtonColumn.UseColumnTextForButtonValue = true;
                dgvJadwalShift.Columns.Add(editButtonColumn);
            }

            if (dgvJadwalShift.Columns["Hapus"] == null)
            {
                // Tambahkan kolom tombol "Delete"
                DataGridViewButtonColumn deleteButtonColumn = new DataGridViewButtonColumn();
                deleteButtonColumn.Name = "Hapus";
                deleteButtonColumn.HeaderText = "Hapus";
                deleteButtonColumn.Text = "Hapus";
                deleteButtonColumn.UseColumnTextForButtonValue = true;
                dgvJadwalShift.Columns.Add(deleteButtonColumn);
            }
        }

        private void dgvJadwalShift_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Pastikan baris dan kolom valid
            if (e.RowIndex >= 0)
            {
                string columnName = dgvJadwalShift.Columns[e.ColumnIndex].Name;

                // Jika tombol "Edit" diklik
                if (columnName == "Ubah")
                {
                    int idShift = Convert.ToInt32(dgvJadwalShift.Rows[e.RowIndex].Cells["id_shift"].Value);

                    // Buka form edit dengan ID shift
                    FormTambahJadwal formUpdate = new FormTambahJadwal
                    {
                        IsEditMode = true,
                        ShiftId = idShift
                    };
                    formUpdate.ShowDialog();

                    // Refresh data setelah update
                    LoadData();
                }

                // Jika tombol "Delete" diklik
                else if (columnName == "Hapus")
                {
                    int idShift = Convert.ToInt32(dgvJadwalShift.Rows[e.RowIndex].Cells["id_shift"].Value);

                    // Konfirmasi penghapusan
                    DialogResult result = MessageBox.Show(
                        "Apakah Anda yakin ingin menghapus shift ini?",
                        "Konfirmasi Hapus",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question
                    );

                    if (result == DialogResult.Yes)
                    {
                        try
                        {
                            ShiftContext.DeleteShift(idShift);
                            MessageBox.Show("Shift berhasil dihapus.");
                            LoadData(); // Refresh data setelah delete
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Error: {ex.Message}");
                        }
                    }
                }
            }
        }

        private void btnAddJadwal_Click(object sender, EventArgs e)
        {
            FormTambahJadwal formTambahJadwal = new FormTambahJadwal();
            formTambahJadwal.Show();
            this.Hide();
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
    }
}
