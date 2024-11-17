using Npgsql;
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

namespace PBOBarberMate.View
{
    public partial class FormLayanan : Form
    {
        public FormLayanan()
        {
            InitializeComponent();
            this.Load += FormLayanan_Load;
        }
        private void FormLayanan_Load(object sender, EventArgs e)
        {
            LoadDataLayanan();
        }

        private void LoadDataLayanan()
        {
            try
            {
                dataGridView1.AllowUserToAddRows = false;

                DataTable LayananData = LayananContext.All();
                if (LayananData == null)
                {
                    MessageBox.Show("Error: Gagal mengambil data Layanan");
                    return;
                }

                dataGridView1.Columns.Clear();

                DataGridViewTextBoxColumn nomorColumn = new DataGridViewTextBoxColumn();
                nomorColumn.HeaderText = "No";
                nomorColumn.Name = "nomor";
                dataGridView1.Columns.Add(nomorColumn);

                dataGridView1.DataSource = LayananData;

                if (dataGridView1.Columns["id_layanan"] != null)
                    dataGridView1.Columns["id_layanan"].Visible = false;
                if (dataGridView1.Columns["nama_layanan"] != null)
                    dataGridView1.Columns["nama_layanan"].HeaderText = "Nama Layanan";
                if (dataGridView1.Columns["harga"] != null)
                    dataGridView1.Columns["harga"].HeaderText = "Harga";

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
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error dalam Load Data Layanan: {ex.Message}\n{ex.StackTrace}");
            }
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            FormTambahLayanan formTambahLayanan = new FormTambahLayanan();
            this.Hide();
            if (formTambahLayanan.ShowDialog() == DialogResult.OK)
            {
                LoadDataLayanan();
            }
            formTambahLayanan.Show();
        }

        private void btnKembali_Click(object sender, EventArgs e)
        {
            FormHomepageAdmin admin = new FormHomepageAdmin();
            this.Hide();
            admin.Show();
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            if (e.ColumnIndex == dataGridView1.Columns["Update"].Index)
            {
                try
                {
                    if (dataGridView1.Rows[e.RowIndex].Cells["id_layanan"] == null ||
                    dataGridView1.Rows[e.RowIndex].Cells["id_layanan"].Value == DBNull.Value) return;

                    int layananId = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["id_layanan"].Value);

                    NpgsqlDataReader LayananData = LayananContext.getLayananByID(layananId);
                    DataTable layananTable = new DataTable();
                    layananTable.Load(LayananData);

                    if (layananTable.Rows.Count > 0)
                    {
                        DataRow row = layananTable.Rows[0];
                        M_Layanan layanan = new M_Layanan
                        {
                            id_layanan = (int)row["id_layanan"],
                            nama_layanan = row["nama_layanan"].ToString(),
                            harga = Convert.ToInt32(row["harga"])
                        };

                        this.Hide();
                        FormTambahLayanan formTambahLayanan = new FormTambahLayanan();
                        formTambahLayanan.PopulateForm(layanan);
                        if (formTambahLayanan.ShowDialog() == DialogResult.OK)
                        {
                            LoadDataLayanan();
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
                if (dataGridView1.Rows[e.RowIndex].Cells["id_layanan"] == null ||
                dataGridView1.Rows[e.RowIndex].Cells["id_layanan"].Value == DBNull.Value) return;

                int layananId = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["id_layanan"].Value);
                LayananContext.DeleteLayanan(layananId);
                LoadDataLayanan();
            }
        }
    }
}
