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
    public partial class FormBuatReservasi : Form
    {
        public FormBuatReservasi()
        {
            InitializeComponent();
        }

        private void btnKembali_Click(object sender, EventArgs e)
        {
            FormHomepageCustomer formHomepageCustomer = new FormHomepageCustomer();

            formHomepageCustomer.Show();
            this.Hide();
        }
    }
}
