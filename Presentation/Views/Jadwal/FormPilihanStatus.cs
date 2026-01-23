using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBOBarberMate.Presentation.Views.Jadwal
{
    public partial class FormPilihanStatus : Form
    {
        public bool IsActiveResult { get; private set; }  
        public bool IsTersediaResult { get; private set; }

        public FormPilihanStatus(string namaKaryawan, string hari)
        {
            InitializeComponent();
            lblInfo.Text = $"Jadwal \"{namaKaryawan}\" hari \"{hari}\"";
        }

        private void btnTersedia_Click(object sender, EventArgs e)
        {
            IsActiveResult = true;
            IsTersediaResult = true;
            this.DialogResult = DialogResult.OK;
        }

        private void btnSibuk_Click(object sender, EventArgs e)
        {
            IsActiveResult = true;
            IsTersediaResult = false;
            this.DialogResult= DialogResult.OK;
        }

        private void btnLibur_Click(object sender, EventArgs e)
        {
            IsActiveResult = false;
            IsTersediaResult = false;
            this.DialogResult = DialogResult.OK;
        }
    }
}
