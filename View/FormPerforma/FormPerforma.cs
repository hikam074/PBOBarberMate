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

        public FormPerforma(int id_karyawan)
        {
            InitializeComponent();
            this.id_karyawan = id_karyawan;
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
                DataTable PerformaData = PerformaContext.getUlasanByID();
                if (PerformaData == null)
                {
                    MessageBox.Show("Error: Gagal mengambil data performa");
                    return;
                }

                Label avgratinglabel = new Label();
                avgratinglabel = PerformaData
                avgratinglabel.Text = $"Rating anda adalah : {"averageRating":F2}";
                avgratinglabel.Location = new Point(51, 160);
                this.Controls.Add(avgratinglabel);
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

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
