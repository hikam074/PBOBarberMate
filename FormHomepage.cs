using System;
using System.Windows.Forms;
using Npgsql;
using CobaWinForm.Classes;

namespace CobaWinForm
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
