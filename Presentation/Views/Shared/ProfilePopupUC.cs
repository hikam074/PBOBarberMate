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
    using PBOBarberMate.Core.Interfaces;
    using PBOBarberMate.App.Services;
    using PBOBarberMate.Infrastructure.Repositories;
    using PBOBarberMate.Presentation.Views.Auth;

    public partial class ProfilePopupUC : UserControl
    {
        public Action OnActionExecuted { get; set; }
        private readonly INavigationService _nav;

        public ProfilePopupUC(INavigationService nav)
        {
            InitializeComponent();
            _nav = nav;
            LoadUserData();
            SetupUI();
        }

        private void LoadUserData()
        {
            if (SessionService.IsLoggedIn())
            {
                var user = SessionService.CurrentUser;
                lblProfilRole.Text = SessionService.CurrentUser.NamaRole;
                lblProfilNama.Text = SessionService.CurrentUser.Nama;
                lblProfilUsername.Text = SessionService.CurrentUser.Username;
                lblProfilEmail.Text = SessionService.CurrentUser.Email;
            }
        }
        private void SetupUI()
        {
            btnUbahProfil.MouseEnter += (s, e) => { btnUbahProfil.BackColor = SystemColors.Highlight; btnUbahProfil.ForeColor = Color.White; };
            btnUbahProfil.MouseLeave += (s, e) => { btnUbahProfil.BackColor = Color.White; btnUbahProfil.ForeColor = Color.Black; };
            btnHomepageLogout.MouseEnter += (s, e) => { btnHomepageLogout.BackColor = Color.Red; btnHomepageLogout.ForeColor = Color.White; };
            btnHomepageLogout.MouseLeave += (s, e) => { btnHomepageLogout.BackColor = Color.White; btnHomepageLogout.ForeColor = Color.Black; };
        }

        private void btnHomepageLogout_Click(object sender, EventArgs e)
        {
            DialogResult confirm = MessageBox.Show(
                $"Apakah Anda yakin?",
                "Konfirmasi",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );
            if (confirm == DialogResult.Yes)
            {
                var parentForm = this.FindForm() as MainApp;
                

                SessionService.EndSession();
                if (parentForm != null)
                {
                    parentForm.ShowLogin();
                }

            }
            OnActionExecuted?.Invoke();
        }
        private void btnUbahProfil_Click(object sender, EventArgs e)
        {
            OnActionExecuted?.Invoke();

            IAkunRepository repo = new AkunRepository();
            AkunService service = new AkunService(repo);
            UbahProfilUC ubahProfilUC = new UbahProfilUC(service, _nav);
            _nav.LoadFitur(ubahProfilUC);
        }
    }
}
