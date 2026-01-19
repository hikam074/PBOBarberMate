using System;
using System.Drawing;
using System.Windows.Forms;

namespace PBOBarberMate.Presentation.Forms
{
    using PBOBarberMate.App.Services;
    using PBOBarberMate.Core.Enums;
    using PBOBarberMate.Core.Interfaces;
    using PBOBarberMate.Infrastructure.Repositories;
    using PBOBarberMate.Presentation.Views.Auth;
    using PBOBarberMate.Presentation.Views.Shared;

    public partial class MainApp : Form
    {
        public MainApp()
        {
            InitializeComponent();
            ShowLogin();
            this.FormClosing += MainApp_FormClosing;
        }
        public void ShowLogin()
        {
            IAkunRepository repo = new AkunRepository();
            AkunService service = new AkunService(repo);
            LoginUC login = new LoginUC(service);

            mainPanel.Controls.Clear();
            login.Dock = DockStyle.Fill;
            mainPanel.Controls.Add(login);
        }
        public void ShowRegister()
        {
            IAkunRepository repo = new AkunRepository();
            AkunService service = new AkunService(repo);
            SignupUC signup = new SignupUC(service);

            mainPanel.Controls.Clear();
            signup.Dock = DockStyle.Fill;
            mainPanel.Controls.Add(signup);
        }
        public void UpdateUIByRole()
        {
            // cegah unauthorized
            if (!SessionService.IsLoggedIn()) return;

            var user = SessionService.CurrentUser;
            mainPanel.Controls.Clear();

            // pemilihan homepage
            UserControl homepage;
            switch (user.IdRole)
            {
                case (int)UserRole.Admin:
                    homepage = new HomepageUC();
                    break;
                default:
                    homepage = new HomepageUC();
                    break;
            }

            homepage.Dock = DockStyle.Fill;
            mainPanel.Controls.Add(homepage);
        }

        private void MainApp_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
