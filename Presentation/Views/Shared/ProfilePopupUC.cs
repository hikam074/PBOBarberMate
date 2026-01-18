using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBOBarberMate.Presentation.Views.Shared
{
    using PBOBarberMate.App.Services;
    using PBOBarberMate.Presentation.Forms;

    public partial class ProfilePopupUC : UserControl
    {
        public ProfilePopupUC()
        {
            InitializeComponent();
            LoadUserData();
        }
        private void LoadUserData()
        {
            if (SessionService.IsLoggedIn())
            {
                var user = SessionService.CurrentUser;
                lblProfilRole.Text = SessionService.CurrentUser.NamaRole;
                lblProfilNama.Text = SessionService.CurrentUser.Nama;
                lblProfilEmail.Text = SessionService.CurrentUser.Username;
            }
        }

        private void btnHomepageLogout_Click(object sender, EventArgs e)
        {
            SessionService.EndSession();
            if (this.TopLevelControl is MainApp main)
            {
                main.ShowLogin();
            }
        }

        private void btnUbahProfil_Click(object sender, EventArgs e)
        {
            //
        }
    }
}
