using Npgsql;
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

namespace PBOBarberMate.View.FormInventaris
{
    public partial class FormInventaris2 : Form
    {
        public FormInventaris2()
        {
            InitializeComponent();
            EnableBtn();
            this.Load += FormInventaris_Load;
        }

        private void FormInventaris_Load(object sender, EventArgs e)
        {
            LoadDataInventaris();
        }
        private void EnableBtn()
        {
            if (UserSession.role == AkunRole.Admin)
            {
                btnTambah.Visible = true; // Tombol Tambah ditampilkan untuk Admin
            }
            else
            {
                btnTambah.Visible = false; // Tombol Tambah disembunyikan untuk role lain
            }

            // Periksa kolom sebelum mengatur visibilitas
            if (dataGridView1.Columns.Contains("Update"))
            {
                dataGridView1.Columns["Update"].Visible = UserSession.role == AkunRole.Admin;
            }
            if (dataGridView1.Columns.Contains("Delete"))
            {
                dataGridView1.Columns["Delete"].Visible = UserSession.role == AkunRole.Admin;
            }
        }
        private void LoadDataInventaris()
        {
            try
            {
                dataGridView1.AllowUserToAddRows = false;

                DataTable InventarisData = InventarisContext.All();
                if (InventarisData == null)
                {
                    MessageBox.Show("Error: Gagal mengambil data Layanan");
                    return;
                }

                dataGridView1.Columns.Clear();

                DataGridViewTextBoxColumn nomorColumn = new DataGridViewTextBoxColumn();
                nomorColumn.HeaderText = "No";
                nomorColumn.Name = "nomor";
                dataGridView1.Columns.Add(nomorColumn);

                dataGridView1.DataSource = InventarisData;

                if (dataGridView1.Columns["id_barang"] != null)
                    dataGridView1.Columns["id_barang"].Visible = false;
                if (dataGridView1.Columns["nama_barang"] != null)
                    dataGridView1.Columns["nama_barang"].HeaderText = "Nama Branag";
                if (dataGridView1.Columns["jumlah_barang"] != null)
                    dataGridView1.Columns["jumlah_barang"].HeaderText = "Jumlah Barang";

                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    dataGridView1.Rows[i].Cells["nomor"].Value = (i + 1).ToString();
                }


                DataGridViewButtonColumn updateButtonColumn = new DataGridViewButtonColumn
                {
                    Name = "Update",
                    HeaderText = "Update",
                    Text = "Edit",
                    UseColumnTextForButtonValue = true
                };
                dataGridView1.Columns.Add(updateButtonColumn);

                DataGridViewButtonColumn deleteButtonColumn = new DataGridViewButtonColumn
                {
                    Name = "Delete",
                    HeaderText = "Delete",
                    Text = "Delete",
                    UseColumnTextForButtonValue = true
                };
                dataGridView1.Columns.Add(deleteButtonColumn);
                EnableBtn();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error dalam Load Data Inventaris: {ex.Message}\n{ex.StackTrace}");
            }
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            FormTambahInventaris formTambahinventaris = new FormTambahInventaris();
            LoadDataInventaris();
            formTambahinventaris.ShowDialog();
            LoadDataInventaris();
        }

        private void btnKembali_Click(object sender, EventArgs e)
        {
            if (UserSession.role == AkunRole.Admin)
            {
                FormHomepageAdmin admin = new FormHomepageAdmin();
                this.Hide();
                admin.Show();
            }
            if (UserSession.role == AkunRole.Karyawan)
            {
                FormHomepageKaryawan Karyawan = new FormHomepageKaryawan();
                this.Hide();
                Karyawan.Show();
            }
            if (UserSession.role == AkunRole.Customer)
            {
                FormHomepageCustomer Customer = new FormHomepageCustomer();
                this.Hide();
                Customer.Show();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            if (e.ColumnIndex == dataGridView1.Columns["Update"].Index)
            {
                try
                {
                    if (dataGridView1.Rows[e.RowIndex].Cells["id_barang"] == null ||
                    dataGridView1.Rows[e.RowIndex].Cells["id_barang"].Value == DBNull.Value) return;

                    int inventarisId = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["id_barang"].Value);

                    NpgsqlDataReader InventarisData = InventarisContext.getInventarisByID(inventarisId);
                    DataTable inventarisTable = new DataTable();
                    inventarisTable.Load(InventarisData);

                    if (inventarisTable.Rows.Count > 0)
                    {
                        DataRow row = inventarisTable.Rows[0];
                        M_Inventaris inventaris = new M_Inventaris
                        {
                            id_barang = (int)row["id_barang"],
                            nama_barang = row["nama_barang"].ToString(),
                            jumlah_barang = Convert.ToInt32(row["jumlah_barang"])
                        };
                        FormTambahInventaris formTambahinventaris = new FormTambahInventaris();
                        formTambahinventaris.PopulateForm(inventaris);
                        if (formTambahinventaris.ShowDialog() == DialogResult.OK)
                        {
                            LoadDataInventaris();
                        }
                        this.Show();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
            else if (e.ColumnIndex == dataGridView1.Columns["Delete"].Index)
            {
                if (dataGridView1.Rows[e.RowIndex].Cells["id_barang"] == null ||
                dataGridView1.Rows[e.RowIndex].Cells["id_barang"].Value == DBNull.Value) return;

                int inventarisId = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["id_barang"].Value);
                InventarisContext.DeleteInventaris(inventarisId);
                LoadDataInventaris();
            }
        }
    }
}
