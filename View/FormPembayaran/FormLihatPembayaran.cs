﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBOBarberMate.View.FormPembayaran
{
    public partial class FormLihatPembayaran : Form
    {
        public FormLihatPembayaran()
        {
            InitializeComponent();
        }

        private void btnKembali_Click(object sender, EventArgs e)
        {
            // kembali ke homepage
            FormHomepageAdmin formHomepageAdmin = new FormHomepageAdmin();
            formHomepageAdmin.Show();
            this.Hide();
        }
    }
}
