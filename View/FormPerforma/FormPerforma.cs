using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using Npgsql;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PBOBarberMate.App.Context;
using System.Windows.Forms.DataVisualization.Charting;


namespace PBOBarberMate.View.FormPerforma
{
    public partial class FormPerforma : Form
    {
        private int id_karyawan;

        public FormPerforma()
        {
            InitializeComponent();
            this.Load += FormPerforma_Load;
        }

        private void FormPerforma_Load(object sender, EventArgs e)
        {
            LoadPerforma();
        }

        private void LoadPerforma()
        {
            try
            {
                DataTable PerformaData = PerformaContext.getUlasanByID(id_karyawan);
                if (PerformaData == null || PerformaData.Rows.Count == 0)
                {
                    MessageBox.Show("Error: Gagal mengambil data performa");
                    return;
                }

                double averageRating = PerformaData.Rows[0]["averageRating"] != DBNull.Value
                    ? Convert.ToDouble(PerformaData.Rows[0]["averageRating"]) : 0;

                Label avgratinglabel = new Label();
                avgratinglabel.Text = $"Anda mendapat rating sebesar {averageRating:F2}, tingkatkan kinerja anda!";
                avgratinglabel.Location = new Point(53, 110);
                avgratinglabel.AutoSize = true;
                this.Controls.Add(avgratinglabel);

                dataGridView1.AllowUserToAddRows = false;
                DataTable UlasanData = PerformaContext.All();
                if (UlasanData == null)
                {
                    MessageBox.Show("Error: Gagal mengambil ulasan customer");
                    return;
                }
                dataGridView1.Columns.Clear();

                DataGridViewTextBoxColumn nomorColumn = new DataGridViewTextBoxColumn();
                nomorColumn.HeaderText = "No";
                nomorColumn.Name = "nomor";
                dataGridView1.Columns.Add(nomorColumn);

                dataGridView1.DataSource = UlasanData;
                if (dataGridView1.Columns["ulasan"] != null)
                    dataGridView1.Columns["ulasan"].HeaderText = "Ulasan";
                if (dataGridView1.Columns["tanggal"] != null)
                    dataGridView1.Columns["tanggal"].HeaderText = "Detail Waktu";

                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    dataGridView1.Rows[i].Cells["nomor"].Value = (i + 1).ToString();
                }

                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dataGridView1.AutoResizeColumns();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error dalam Load Data Performa: {ex.Message}\n{ex.StackTrace}");
            }
        }

        private void btkembali_Click(object sender, EventArgs e)
        {
            FormHomepageKaryawan Karyawan = new FormHomepageKaryawan();
            this.Hide();
            Karyawan.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
        }
    }
}
