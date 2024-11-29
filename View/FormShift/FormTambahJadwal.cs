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
    public partial class FormTambahJadwal : Form
    {
        public FormTambahJadwal()
        {
            InitializeComponent();
        }

        private void btnKembali_Click(object sender, EventArgs e)
        {
            FormShift formShift = new FormShift();
            formShift.Show();
            this.Hide();
        }

        private void btnTambahkan_Click(object sender, EventArgs e)
        {

        }
    }
}
