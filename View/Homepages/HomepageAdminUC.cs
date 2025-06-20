using System;
using System.Drawing;
using System.Windows.Forms;
using PBOBarberMate.App.Services;
using PBOBarberMate.App.Model;

using PBOBarberMate.View;
using PBOBarberMate.View.Auth;
using PBOBarberMate.View.Dashboard;
using PBOBarberMate.View.Homepages; // Untuk HomepageAdminUC, HomepageKaryawanUC, HomepageCustomerUC

// Import UserControls untuk fitur
using PBOBarberMate.View.FormInventaris;
using PBOBarberMate.View.FormReservasi;
using PBOBarberMate.View.FormShift;
using PBOBarberMate.View.FormKelolaKaryawan;
using PBOBarberMate.View.FormKelolaCustomer;
using PBOBarberMate.View.FormPembayaran;
using PBOBarberMate.View.FormUlasan;


namespace PBOBarberMate.View.Homepages // Namespace baru untuk homepages
{
    public partial class HomepageAdminUC : UserControl
    {
        private readonly AkunService _akunService;
        private readonly SessionService _sessionService;
        private readonly MainApp _mainApp; // Referensi ke MainApp untuk navigasi global

        // Panel yang akan menampung konten fitur spesifik Admin
        // NOTE: _featureContentPanel kini adalah contentAreaPanel dari Designer.cs
        // private System.Windows.Forms.Panel _featureContentPanel;

        public HomepageAdminUC(AkunService akunService, SessionService sessionService, MainApp mainApp)
        {
            InitializeComponent(); // Ini akan menginisialisasi sidebarPanel, headerPanel, contentAreaPanel, dll.

            _akunService = akunService;
            _sessionService = sessionService;
            _mainApp = mainApp;

            // Muat konten default saat Homepage Admin dimuat (misal, tampilan menu utama)
            LoadFeatureContent(new AdminDashboardUC(_akunService, _sessionService, _mainApp, this));
            // Teruskan referensi HomepageAdminUC agar AdminMenuUC bisa memanggil LoadFeatureContent

            // Tampilkan info selamat datang
            lblWelcome.Text = _sessionService.CurrentUserName;
            lblProfilRole.Text = _sessionService.CurrentUserRole.ToString();
            lblProfilNama.Text = _sessionService.CurrentUserName;
            lblProfilEmail.Text = _sessionService.CurrentUserEmail;

            // Tambahkan event handler untuk hover pada tombol profil jika masih diperlukan
            btnProfil.MouseEnter += (s, e) => { if (btnProfil.Enabled) { btnProfil.BackColor = Color.FromArgb(243, 156, 18); btnProfil.ForeColor = Color.FromArgb(44, 62, 80); } };
            btnProfil.MouseLeave += (s, e) => { if (btnProfil.Enabled) { btnProfil.BackColor = Color.FromArgb(44, 62, 80); btnProfil.ForeColor = Color.White; } };
            btnHomepageLogout.MouseEnter += (s, e) => { btnHomepageLogout.BackColor = Color.FromArgb(243, 156, 18); btnHomepageLogout.ForeColor = Color.FromArgb(44, 62, 80); };
            btnHomepageLogout.MouseLeave += (s, e) => { btnHomepageLogout.BackColor = SystemColors.Control; btnHomepageLogout.ForeColor = Color.FromArgb(44, 62, 80); };
            btnUbahProfil.MouseEnter += (s, e) => { btnUbahProfil.BackColor = Color.FromArgb(243, 156, 18); btnUbahProfil.ForeColor = Color.FromArgb(44, 62, 80); };
            btnUbahProfil.MouseLeave += (s, e) => { btnUbahProfil.BackColor = SystemColors.Control; btnUbahProfil.ForeColor = Color.FromArgb(44, 62, 80); };

            // Tambahkan event handler untuk setiap tombol sidebar (untuk animasi hover jika diinginkan)
            // Atau Anda bisa membuat method universal untuk ini jika banyak tombol
            // Contoh untuk satu tombol:
            btnLayanan.MouseEnter += (s, e) => { btnLayanan.BackColor = Color.FromArgb(243, 156, 18); };
            btnLayanan.MouseLeave += (s, e) => { btnLayanan.BackColor = Color.FromArgb(44, 62, 80); };
            // Ulangi untuk semua btnXyz di sidebarPanel

            // Pastikan event HomepageAdminUC_Click diaktifkan di designer atau di sini
            this.Click += new System.EventHandler(this.HomepageAdminUC_Click);

        }

        /// <summary>
        /// Memuat UserControl fitur ke dalam area konten utama homepage ini (contentAreaPanel).
        /// </summary>
        /// <param name="featureUC">UserControl fitur yang akan dimuat.</param>
        public void LoadFeatureContent(UserControl featureUC)
        {
            contentAreaPanel.Controls.Clear(); // Bersihkan panel dari konten sebelumnya
            featureUC.Dock = DockStyle.Fill;   // Pastikan UserControl mengisi seluruh panel
            contentAreaPanel.Controls.Add(featureUC);


        }

        // --- Event Handlers Sidebar (Akan memanggil LoadFeatureContent) ---

        private void btnLayanan_Click(object sender, EventArgs e)
        {
            //LoadFeatureContent(new FormLayananUC(_akunService, _sessionService, _mainApp));
        }

        private void btnInventaris_Click(object sender, EventArgs e)
        {
            //LoadFeatureContent(new FormInventarisUC(_akunService, _sessionService, _mainApp));
        }

        private void btnShift_Click(object sender, EventArgs e)
        {
            //LoadFeatureContent(new FormShiftUC(_akunService, _sessionService, _mainApp));
        }

        private void btnReservasi_Click(object sender, EventArgs e)
        {
            //LoadFeatureContent(new FormLihatReservasiUC(_akunService, _sessionService, _mainApp));
        }

        private void btnPembayaran_Click(object sender, EventArgs e)
        {
            //LoadFeatureContent(new FormAddPembayaranUC(_akunService, _sessionService, _mainApp));
        }

        private void btnKunjungan_Click(object sender, EventArgs e)
        {
            //LoadFeatureContent(new FormLihatPembayaranUntukUlasanUC(_akunService, _sessionService, _mainApp));
        }

        private void btnKaryawan_Click(object sender, EventArgs e)
        {
            //LoadFeatureContent(new FormKelolaKaryawanUC(_akunService, _sessionService, _mainApp));
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            //LoadFeatureContent(new FormKelolaCustomerUC(_akunService, _sessionService, _mainApp));
        }

        // --- Event Handlers Profil/Logout (akan memanggil MainApp untuk navigasi global) ---

        private void btnProfil_Click(object sender, EventArgs e)
        {
            // Ubah visibilitas gbxShowProfile
            gbxShowProfile.Visible = !gbxShowProfile.Visible;

            // Jika gbxShowProfile menjadi terlihat, pastikan ia berada di paling depan
            if (gbxShowProfile.Visible)
            {
                // Hitung posisi gbxShowProfile relatif terhadap HomepageAdminUC
                // agar muncul tepat di bawah btnProfil
                Point btnProfilScreenLocation = btnProfil.PointToScreen(Point.Empty); // Posisi btnProfil di layar
                Point gbxShowProfileLocation = this.PointToClient(btnProfilScreenLocation); // Konversi ke koordinat UserControl

                // Atur lokasi gbxShowProfile
                gbxShowProfile.Location = new Point(
                    gbxShowProfileLocation.X - gbxShowProfile.Width + btnProfil.Width, // Sesuaikan agar rata kanan dengan btnProfil
                    gbxShowProfileLocation.Y + btnProfil.Height + 5 // Beri sedikit jarak dari btnProfil
                );

                gbxShowProfile.BringToFront(); // Pastikan gbxShowProfile berada di lapisan paling depan
            }
        }

        private void btnUbahProfil_Click(object sender, EventArgs e)
        {
            // Pindah ke FormUbahProfilUC di panel konten UTAMA (MainApp)
            //_mainApp.LoadContent(new FormUbahProfilUC(_akunService, _sessionService, _mainApp));
        }

        private void btnHomepageLogout_Click(object sender, EventArgs e)
        {
            _akunService.Logout(); // Lakukan logout melalui service
            _mainApp.LoadContent(new LoginUC(_akunService, _sessionService, _mainApp)); // Kembali ke FormLoginUC
        }

        // --- Logika UI (Click di luar GbxProfil) ---
        private void HomepageAdminUC_Click(object sender, EventArgs e)
        {
            // Menutup gbxShowProfile jika diklik di luar area box profil
            Point cursorPosition = this.PointToClient(Cursor.Position);
            // Periksa apakah gbxShowProfile terlihat dan klik di luar batasnya
            if (gbxShowProfile.Visible && !gbxShowProfile.Bounds.Contains(cursorPosition))
            {
                gbxShowProfile.Visible = false;
                // Kembalikan warna btnProfil jika ada logika hover yang dinonaktifkan
                // if (hoversActivated == false) { btnProfil.BackColor = Color.FromArgb(44, 62, 80); btnProfil.ForeColor = Color.White; }
            }
        }

        private void pictbxHome_Click(object sender, EventArgs e)
        {
            _mainApp.RedirectToHomepage();
        }
    }
}