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
    using PBOBarberMate.Core.Interfaces;

    public partial class NavbarUC : UserControl, IMessageFilter
    {
        private readonly INavigationService _nav;
        private ProfilePopupUC _profilePopup;

        public NavbarUC(INavigationService nav)
        {
            InitializeComponent();
            _nav = nav;
            LoadUserData();

            SetupUI();

            lblHeaderMenu.TextChanged += (s, e) => AdjustHeaderPosition();
            this.Resize += (s, e) => {
                AdjustHeaderPosition();
                CloseProfilePopup();
                RepositionPopup();
            };
            Application.AddMessageFilter(this);
        }

        private void btnProfil_Click(object sender, EventArgs e)
        {
            if (_profilePopup == null || _profilePopup.IsDisposed)
            {
                _profilePopup = new ProfilePopupUC();
                _profilePopup.OnActionExecuted = () => CloseProfilePopup();
                // hitung posisi yang lebih akurat relatif terhadap Form
                Point screenPos = btnProfil.PointToScreen(new Point(0, btnProfil.Height));
                Point formPos = this.FindForm().PointToClient(screenPos);

                _profilePopup.Location = new Point(
                    formPos.X + btnProfil.Width - _profilePopup.Width,
                    formPos.Y + 5
                );
                // tambahkan ke Form agar berada di lapisan teratas
                this.FindForm().Controls.Add(_profilePopup);
                _profilePopup.BringToFront();
            }
            else
            {
                CloseProfilePopup();
            }
        }

        public void SetPageTitle(string title)
        {
            lblHeaderMenu.Text = title;
        }
        public void AdjustHeaderPosition()
        {
            lblHeaderMenu.Left = (this.Width - lblHeaderMenu.Width) / 2;
        }
        public bool PreFilterMessage(ref Message m)
        // interface IMessageFilter
        {
            // WM_LBUTTONDOWN = 0x0201
            if (m.Msg == 0x0201 && _profilePopup != null && !_profilePopup.IsDisposed)
            {
                Point mousePos = Control.MousePosition;
                // cek apakah klik berada di dalam area ProfilePopupUC
                Point clickPoint = _profilePopup.PointToClient(mousePos);
                if (_profilePopup.ClientRectangle.Contains(clickPoint))
                {
                    // izinkan pesan berlanjut agar tombol Logout/Ubah bisa menerima klik
                    return false;
                }
                // cek apakah klik di tombol profil (untuk toggle)
                Point clickOnButton = btnProfil.PointToClient(mousePos);
                if (btnProfil.ClientRectangle.Contains(clickOnButton))
                {
                    return false;
                }
                // iika klik benar-benar di luar keduanya, baru tutup
                CloseProfilePopup();
            }
            return false;
        }

        private void LoadUserData()
        {
            if (SessionService.IsLoggedIn())
            {
                btnProfil.Text = SessionService.CurrentUser.Nama;
            }
        }
        private void SetupUI()
        {
            btnProfil.MouseEnter += (s, e) => { btnProfil.BackColor = Color.Gainsboro; pictboxProfil.BackColor = Color.Gainsboro; };
            btnProfil.MouseLeave += (s, e) => { btnProfil.BackColor = Color.White; pictboxProfil.BackColor = Color.White; };
        }
        private void RepositionPopup()
        {
            // fixkan ikon profil
            pictboxProfil.Location = new Point(btnProfil.Location.X - pictboxProfil.Width, btnProfil.Location.Y + (btnProfil.Height - pictboxProfil.Height) / 2);
            // Pastikan popup tetap menempel di bawah tombol profil saat window resize
            if (_profilePopup != null && !_profilePopup.IsDisposed)
            {
                int bottomGap = 5;
                _profilePopup.Location = new Point(
                    btnProfil.Right - _profilePopup.Width,
                    btnProfil.Bottom + bottomGap
                );
            }
        }
        private void CloseProfilePopup()
        {
            if (_profilePopup != null)
            {
                this.FindForm()?.Controls.Remove(_profilePopup);
                _profilePopup.Dispose();
                _profilePopup = null;
            }
        }
    }
}
