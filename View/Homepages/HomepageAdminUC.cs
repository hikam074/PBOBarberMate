using System;
using System.Drawing;
using System.Windows.Forms;

using PBOBarberMate.App.Services; // Untuk AkunService dan SessionService

using PBOBarberMate.View.Auth;


namespace PBOBarberMate.View.Homepages
{
    public partial class HomepageAdminUC : UserControl
    {
        private readonly AkunService _akunService;
        private readonly SessionService _sessionService;
        private readonly MainApp _mainForm; // Referensi ke form utama

        // Konstruktor sekarang menerima AkunService, SessionService, dan MainApplicationForm
        public HomepageAdminUC(AkunService akunService, SessionService sessionService, MainApp mainForm)
        {
            InitializeComponent();
            _akunService = akunService;
            _sessionService = sessionService;
            _mainForm = mainForm;

            lblWelcome.Text = _sessionService.CurrentUserName; // Gunakan SessionService untuk data user
        }

        // Metode-metode lain seperti sebelumnya, tetapi navigasi akan memanggil _mainForm.LoadContent()
        // Contoh:
        private void btnProfil_Click(object sender, EventArgs e)
        {
            // Tampilkan profil box, atau bisa juga muat UserControl FormUbahProfil jika ada
            // Contoh sederhana:
            gbxShowProfile.Visible = !gbxShowProfile.Visible;
            if (gbxShowProfile.Visible)
            {
                lblProfilRole.Text = _sessionService.CurrentUserRole.ToString();
                lblProfilNama.Text = _sessionService.CurrentUserName;
                lblProfilEmail.Text = _sessionService.CurrentUserEmail;
            }
            // Sesuaikan warna tombol profil seperti sebelumnya
        }

        private void btnUbahProfil_Click(object sender, EventArgs e)
        {
            // Muat FormUbahProfil (UserControl) ke panel utama
            //_mainForm.LoadContent(new FormUbahProfil(_akunService, _sessionService, _mainForm));
        }

        private void btnHomepageLogout_Click(object sender, EventArgs e)
        {
            _akunService.Logout(); // Lakukan logout melalui service
            _mainForm.LoadContent(new LoginUC(_akunService, _sessionService, _mainForm)); // Kembali ke FormLogin
        }

        private void btnLayanan_Click(object sender, EventArgs e)
        {
            // Muat FormLayanan (UserControl) ke panel utama
            //_mainForm.LoadContent(new FormLayanan(_mainForm.GetAkunService(), _mainForm.GetSessionService(), _mainForm));
        }

        private void btnInventaris_Click(object sender, EventArgs e)
        {
            // Muat FormInventaris (UserControl)
            //_mainForm.LoadContent(new FormInventaris.FormInventaris(_mainForm.GetAkunService(), _mainForm.GetSessionService(), _mainForm));
        }

        private void btnShift_Click(object sender, EventArgs e)
        {
            // Muat FormShift (UserControl)
            //_mainForm.LoadContent(new FormShift.FormShift(_mainForm.GetAkunService(), _mainForm.GetSessionService(), _mainForm));
        }

        private void btnReservasi_Click(object sender, EventArgs e)
        {
            // Muat FormLihatReservasi (UserControl)
            //_mainForm.LoadContent(new FormReservasi.FormLihatReservasi(_mainForm.GetAkunService(), _mainForm.GetSessionService(), _mainForm));
        }

        private void btnPembayaran_Click(object sender, EventArgs e)
        {
            // Muat FormAddPembayaran (UserControl)
            //_mainForm.LoadContent(new FormPembayaran.FormAddPembayaran(_mainForm.GetAkunService(), _mainForm.GetSessionService(), _mainForm));
        }

        private void btnKunjungan_Click(object sender, EventArgs e)
        {
            // Muat FormLihatPembayaranUntukUlasan (UserControl)
            //_mainForm.LoadContent(new FormPembayaran.FormLihatPembayaranUntukUlasan(_mainForm.GetAkunService(), _mainForm.GetSessionService(), _mainForm));
        }

        private void btnKaryawan_Click(object sender, EventArgs e)
        {
            // Muat FormKelolaKaryawan (UserControl)
            //_mainForm.LoadContent(new FormKelolaKaryawan.FormKelolaKaryawan(_mainForm.GetAkunService(), _mainForm.GetSessionService(), _mainForm));
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            // Muat FormKelolaCustomer (UserControl)
            //_mainForm.LoadContent(new FormKelolaCustomer.FormKelolaCustomer(_mainForm.GetAkunService(), _mainForm.GetSessionService(), _mainForm));
        }

        // Contoh untuk event Click pada Form (UserControl) itu sendiri
        private void FormHomepageAdmin_Click(object sender, EventArgs e)
        {
            Point cursorPosition = this.PointToClient(Cursor.Position);
            if (!gbxShowProfile.Bounds.Contains(cursorPosition))
            {
                gbxShowProfile.Visible = false;
                // Sesuaikan logika warna tombol profil jika diperlukan
            }
        }
    }
}