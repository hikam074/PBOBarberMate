using System;
using System.Windows.Forms;
using Npgsql;
using PBOBarberMate.Classes;

namespace PBOBarberMate
{
    public partial class FormHomepage : Form
    {
        public FormHomepage()
        {
            InitializeComponent();

        }

        private void btnHomepageLogout_Click(object sender, EventArgs e)
        {
            FormLogin formLogin = new FormLogin();
            formLogin.Show();

            this.Hide();
        }
    }
}
