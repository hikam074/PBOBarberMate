using PBOBarberMate.App.Model;
using PBOBarberMate.View.FormReservasi;
using PBOBarberMate.View.FormPembayaran;
using PBOBarberMate.View.FormUlasan;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PBOBarberMate.App.Services;
using PBOBarberMate.View.Auth;

namespace PBOBarberMate.View.Homepages
{
    public partial class HomepageCustomerUC : UserControl
    {
        private readonly AkunService _akunService;
        private readonly SessionService _sessionService;
        private readonly MainApp _mainApp; // Referensi ke form utama

        public HomepageCustomerUC(AkunService akunService, SessionService sessionService, MainApp mainApp)
        {
            InitializeComponent();
            _akunService = akunService;
            _sessionService = sessionService;
            _mainApp = mainApp;

            // Set initial header and profile info
            lblHeaderMenu.Text = "Halaman Utama";
            lblProfilRole.Text = _sessionService.CurrentUserRole.ToString();
            lblProfilNama.Text = _sessionService.CurrentUserName;
            lblProfilEmail.Text = _sessionService.CurrentUserEmail;
            btnProfil.Text = _sessionService.CurrentUserName;
            lblWelcome.Text = "Selamat Datang, " + _sessionService.CurrentUserName + "!";

            // Set hover events for buttons
            SetButtonHoverEvents();
            AdjustProfilIconPosition();
            AdjustHeaderPosition();

            this.Resize += (s, e) => AdjustProfilIconPosition();
            this.Resize += (S, e) => AdjustHeaderPosition();
        }

        private void SetButtonHoverEvents()
        {
            // HOVER SIDEBAR
            SetSidebarHoverEvents(btnReservasi, pictbxReservasi);
            SetSidebarHoverEvents(btnLihatReservasi, pictbxLihatReservasi);
            SetSidebarHoverEvents(btnLayanan, pictbxLayanan);
            SetSidebarHoverEvents(btnUlasan, pictbxUlasan);
            // HOVER PROFIL
            SetProfilHoverEvents(btnProfil, pictboxProfil);
            SetProfilHoverEvents(btnUbahProfil);
            SetProfilHoverEvents(btnHomepageLogout);
        }

        private void AdjustProfilIconPosition()
        {
            pictboxProfil.Location = new Point(btnProfil.Location.X - pictboxProfil.Width, btnProfil.Location.Y + (btnProfil.Height - pictboxProfil.Height) / 2);
            pictboxProfil.BringToFront();
            btnProfil.BringToFront();
        }

        private void AdjustHeaderPosition()
        {
            lblHeaderMenu.Left = (headerPanel.Width - lblHeaderMenu.Width) / 2;
        }

        private void SetSidebarHoverEvents(Control button, Control relatedControl)
        {
            button.MouseEnter += (s, e) => { button.BackColor = Color.White; relatedControl.BackColor = Color.Gainsboro; };
            button.MouseLeave += (s, e) => { button.BackColor = Color.Transparent; relatedControl.BackColor = Color.Transparent; };
        }

        private void SetProfilHoverEvents(Control button)
        {
            button.MouseEnter += (s, e) => { button.BackColor = Color.Gainsboro; };
            button.MouseLeave += (s, e) => { button.BackColor = Color.White; };
        }

        private void SetProfilHoverEvents(Control button, Control relatedControl)
        {
            button.MouseEnter += (s, e) => { button.BackColor = Color.Gainsboro; relatedControl.BackColor = Color.Gainsboro; };
            button.MouseLeave += (s, e) => { button.BackColor = Color.White; relatedControl.BackColor = Color.White; };
        }

        public void HideProfileBox()
        {
            if (gbxShowProfile.Visible)
            {
                gbxShowProfile.Visible = false;
                _mainApp.DisableGlobalClickListener();
            }
        }

        private void HomepageCustomerUC_Load(object sender, EventArgs e)
        {
            //try
            //{
            //    // mengambil data dari db
            //    //DataTable src = TabelContext.getReservasiMingguIni();
            //    // membuat size kolom menjadi rata dan memenuhi tabel
            //    dgvJadwalMingguIni.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            //    // membuat tabel responsif berdasarkan isi data
            //    foreach (DataGridViewColumn column in dgvJadwalMingguIni.Columns)
            //    {
            //        column.Width = dgvJadwalMingguIni.Width / dgvJadwalMingguIni.Columns.Count;
            //    }
            //    // behaviour table
            //    dgvJadwalMingguIni.ScrollBars = ScrollBars.None;
            //    dgvJadwalMingguIni.AllowUserToAddRows = false;
            //    dgvJadwalMingguIni.AllowUserToResizeColumns = false;
            //    dgvJadwalMingguIni.AllowUserToResizeRows = false;
            //    dgvJadwalMingguIni.RowHeadersVisible = false;
            //    dgvJadwalMingguIni.ClearSelection();
            //    dgvJadwalMingguIni.SelectionChanged += (s, e) =>
            //    {
            //        dgvJadwalMingguIni.ClearSelection();
            //    };
            //    // mengambil data dari variabel
            //    dgvJadwalMingguIni.DataSource = src;

            //    dgvJadwalMingguIni.Columns["tanggal"].HeaderText = "Tanggal";
            //    dgvJadwalMingguIni.Columns["waktu"].HeaderText = "Waktu";
            //    dgvJadwalMingguIni.Columns["pelayanan"].HeaderText = "Pelayanan";
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show($"Terjadi kesalahan [PBOBarberMate.View.FormHomepageCustomer.FormHomepageCustomer_Load] : {ex}");
            //}
        }

        private void btnReservasi_Click(object sender, EventArgs e)
        {
            HideProfileBox();
            //_mainApp.LoadContent(new FormBuatReservasi()); // Assuming FormBuatReservasi can be loaded directly
        }

        private void btnLayanan_Click(object sender, EventArgs e)
        {
            HideProfileBox();
            //_mainApp.LoadContent(new FormLayanan()); // Assuming FormLayanan can be loaded directly
        }

        private void btnProfil_Click(object sender, EventArgs e)
        {
            gbxShowProfile.Visible = !gbxShowProfile.Visible;

            if (gbxShowProfile.Visible)
            {
                Point btnProfilScreenLocation = btnProfil.PointToScreen(Point.Empty);
                Point gbxShowProfileLocationOnUC = this.PointToClient(btnProfilScreenLocation);

                gbxShowProfile.Location = new Point(
                    gbxShowProfileLocationOnUC.X - gbxShowProfile.Width + btnProfil.Width,
                    gbxShowProfileLocationOnUC.Y + btnProfil.Height + 15
                );

                gbxShowProfile.BringToFront();
                _mainApp.EnableGlobalClickListener(gbxShowProfile);
            }
            else
            {
                _mainApp.DisableGlobalClickListener();
            }
        }

        private void btnUbahProfil_Click(object sender, EventArgs e)
        {
            HideProfileBox();
            //_mainApp.LoadContent(new FormUbahProfil()); // Assuming FormUbahProfil can be loaded directly
        }

        private void btnHomepageLogout_Click(object sender, EventArgs e)
        {
            _akunService.Logout();
            _mainApp.LoadContent(new LoginUC(_akunService, _sessionService, _mainApp));
        }

        private void btnLihatReservasi_Click(object sender, EventArgs e)
        {
            HideProfileBox();
            //_mainApp.LoadContent(new FormLihatReservasi()); // Assuming FormLihatReservasi can be loaded directly
        }

        private void lklbMore_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            HideProfileBox();
            //_mainApp.LoadContent(new FormLihatReservasi()); // Assuming FormLihatReservasi can be loaded directly
        }

        private void btnUlasan_Click(object sender, EventArgs e)
        {
            HideProfileBox();
            //_mainApp.LoadContent(new FormLihatPembayaranUntukUlasan()); // Assuming FormLihatPembayaranUntukUlasan can be loaded directly
        }

        private void pictboxHome_Click(object sender, EventArgs e)
        {
            _mainApp.RedirectToHomepage();
        }
    }
}