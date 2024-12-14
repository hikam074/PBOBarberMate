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
using Syncfusion.UI.Xaml.Charts;


namespace PBOBarberMate.View.FormPerforma
{
    public partial class FormPerforma : Form
    {
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
                DataTable PerformaData = PerformaContext.getUlasanByID();
                //if (PerformaData == null)
                //{
                //    MessageBox.Show("Error: Gagal mengambil data performa");
                //    return;
                //}
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
    }
}
