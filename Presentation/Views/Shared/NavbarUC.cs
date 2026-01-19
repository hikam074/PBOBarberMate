using PBOBarberMate.App.Services;
using PBOBarberMate.Core.Interfaces;
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
    public partial class NavbarUC : UserControl
    {
        private readonly INavigationService _nav;
        private ProfilePopupUC _profilePopup;

        public NavbarUC(INavigationService nav)
        {
            InitializeComponent();
            _nav = nav;
            LoadUserData();


            //SetButtonHoverEvents();
            //AdjustProfilIconPosition();
            //AdjustHeaderPosition();

            //this.Resize += (s, e) => AdjustProfilIconPosition();
            //this.Resize += (S, e) => AdjustHeaderPosition();
        }
        private void LoadUserData()
        {
            if (SessionService.IsLoggedIn())
            {
                btnProfil.Text = SessionService.CurrentUser.Nama;
            }
        }
        public void SetPageTitle(string title)
        {
            lblHeaderMenu.Text = title;
        }
        //private void SetButtonHoverEvents()
        //{
        //    SetProfilHoverEvents(btnProfil, pictboxProfil);
        //}
        //private void AdjustProfilIconPosition()
        //{
        //    pictboxProfil.Location = new Point(btnProfil.Location.X - pictboxProfil.Width, btnProfil.Location.Y + (btnProfil.Height - pictboxProfil.Height) / 2);
        //    // Pastikan ikon berada di depan tombol dan grup profil
        //    pictboxProfil.BringToFront();
        //    btnProfil.BringToFront();
        //}
        //public void AdjustHeaderPosition()
        //{
        //    lblHeaderMenu.Left = (this.Width - lblHeaderMenu.Width) / 2;
        //}
        //private void SetProfilHoverEvents(Control button, Control relatedControl)
        //{
        //    button.MouseEnter += (s, e) => { button.BackColor = Color.Gainsboro; relatedControl.BackColor = Color.Gainsboro; };
        //    button.MouseLeave += (s, e) => { button.BackColor = Color.White; relatedControl.BackColor = Color.White; };
        //}

        private void btnProfil_Click(object sender, EventArgs e)
        {
            int bottomGap = 15;
            if (_profilePopup == null || _profilePopup.IsDisposed)
            {
                _profilePopup = new ProfilePopupUC();
                _profilePopup.Location = new Point(
                    btnProfil.Right - _profilePopup.Width,
                    btnProfil.Bottom + bottomGap
                    );
                this.Controls.Add(_profilePopup);
                _profilePopup.BringToFront();
                _profilePopup.Focus();
                _profilePopup.Anchor = AnchorStyles.Top | AnchorStyles.Right;
                // close ketika klik diluar
                _profilePopup.Leave += (s, args) => { this.Controls.Remove(_profilePopup); _profilePopup.Dispose(); };
            }
            else
            {
                this.Controls.Remove(_profilePopup);
                _profilePopup.Dispose();
            }
        }
    }
}
