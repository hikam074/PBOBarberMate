using Npgsql;
using System;
using System.Windows.Forms;
using PBOBarberMate.App.Model;
using PBOBarberMate.App.Services;
using PBOBarberMate.View;

namespace PBOBarberMate.View.Auth
{
    public partial class SignupUC : UserControl
    {
        private readonly AkunService _akunService;
        private readonly SessionService _sessionService;
        private readonly MainApp _mainForm; // Referensi ke form utama
        
        public SignupUC(AkunService akunService, SessionService sessionService, MainApp mainForm)
        {
            InitializeComponent();
            _akunService = akunService;
            _sessionService = sessionService;
            _mainForm = mainForm; // Simpan referensi form utama

            // nonaktifkan btnSignupSubmit bila yang diisi belum lengkap
            if (tbxSignupEmail.Text == "" || tbxSignupNama.Text == "" || tbxSignupPass.Text == "")
            {
                btnSignupSubmit.Enabled = false;
            }
            // mengaktifkan btnSignupSubmit bila data tidak kosong
            else
            {
                btnSignupSubmit.Enabled = true;
            }
        }

        private void lklblLoginSignupRedirect_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // mengarahkan ke FormLogin
            _mainForm.LoadContent(new LoginUC(_mainForm.GetAkunService(), _mainForm.GetSessionService(), _mainForm));
        }

        private void tbxSignupEmail_TextChanged(object sender, EventArgs e)
        {
            // nonaktifkan btnSignupSubmit bila yang diisi belum lengkap
            if (tbxSignupEmail.Text == "" || tbxSignupNama.Text == "" || tbxSignupPass.Text == "")
            {
                btnSignupSubmit.Enabled = false;
            }
            // mengaktifkan btnSignupSubmit bila data tidak kosong
            else
            {
                btnSignupSubmit.Enabled = true;
            }
        }
        private void tbxSignupNama_TextChanged(object sender, EventArgs e)
        {
            // nonaktifkan btnSignupSubmit bila yang diisi belum lengkap
            if (tbxSignupEmail.Text == "" || tbxSignupNama.Text == "" || tbxSignupPass.Text == "")
            {
                btnSignupSubmit.Enabled = false;
            }
            // mengaktifkan btnSignupSubmit bila data tidak kosong
            else
            {
                btnSignupSubmit.Enabled = true;
            }
        }
        private void tbxSignupPass_TextChanged(object sender, EventArgs e)
        {
            // nonaktifkan btnSignupSubmit bila yang diisi belum lengkap
            if (tbxSignupEmail.Text == "" || tbxSignupNama.Text == "" || tbxSignupPass.Text == "")
            {
                btnSignupSubmit.Enabled = false;
            }
            // mengaktifkan btnSignupSubmit bila data tidak kosong
            else
            {
                btnSignupSubmit.Enabled = true;
            }
        }

        private void btnSignupSubmit_Click(object sender, EventArgs e)
        {
            string email = tbxSignupEmail.Text;
            string nama = tbxSignupNama.Text;
            string password = tbxSignupPass.Text;

            try
            {
                bool signupBerhasil = _akunService.Signup(nama, email, password);

                if (signupBerhasil)
                {
                    // redirect ke homepage
                    _mainForm.RedirectToHomepage();
                }
                else
                {
                    MessageBox.Show("Email atau Password Anda salah! Silakan coba lagi.", "Login Gagal", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (ApplicationException ex)
            {
                MessageBox.Show($"Terjadi kesalahan sistem: {ex.Message}\nMohon coba lagi nanti.", "Error Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Terjadi kesalahan tidak terduga: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnSignupSubmit_MouseEnter(object sender, EventArgs e)
        {
            // animasi hovers hanya akan aktif ketika tombolnya aktif(dapat diklik)
            if (btnSignupSubmit.Enabled == true)
            {
                btnSignupSubmit.BackColor = Color.FromArgb(243, 156, 18);
                btnSignupSubmit.ForeColor = Color.FromArgb(44, 62, 80);
            }
        }

        private void btnSignupSubmit_MouseLeave(object sender, EventArgs e)
        {
            // animasi hovers hanya akan aktif ketika tombolnya aktif(dapat diklik)
            if (btnSignupSubmit.Enabled == true)
            {
                btnSignupSubmit.BackColor = Color.FromArgb(44, 62, 80);
                btnSignupSubmit.ForeColor = Color.White;
            }
        }

        private void FormSignup_Load(object sender, EventArgs e)
        {
            CenterComponentVertically(this.gbxSignup);
            CenterLabelsVertically(this.lblSginupWelcome, this.lblSignupAppName);
        }

        private void FormSignup_Resize(object sender, EventArgs e)
        {
            CenterComponentVertically(this.gbxSignup);
            CenterLabelsVertically(this.lblSginupWelcome, this.lblSignupAppName);
        }

        private void CenterComponentVertically(Control component)
        {
            if (component == null) return;
            // Hitung posisi Y untuk memusatkan komponen di dalam parent-nya (yaitu FormLogin)
            int y = (this.ClientSize.Height - component.Height) / 2;
            // Atur lokasi komponen, posisi X tetap seperti semula
            component.Location = new Point(component.Location.X, y);
        }

        // Memusatkan grup label hanya secara vertikal (posisi horizontal diatur terpisah)
        private void CenterLabelsVertically(Label lblWelcome, Label lblAppName)
        {
            if (lblWelcome == null || lblAppName == null) return;

            // Memposisikan lblWelcome di atas lblAppName, lalu memusatkan keduanya sebagai grup vertikal
            // Hitung total tinggi kedua label dan spasi antar mereka jika ada
            int spacing = 5;
            int totalHeight = lblWelcome.Height + spacing + lblAppName.Height;
            // Hitung posisi Y untuk bagian atas lblWelcome agar grup terpusat secara vertikal
            int groupY = (this.ClientSize.Height - totalHeight) / 2;
            // Hanya atur posisi Y
            lblWelcome.Location = new Point(
                lblWelcome.Location.X, // Posisi X tetap
                groupY
            );

            lblAppName.Location = new Point(
                lblAppName.Location.X, // Posisi X tetap
                groupY + lblWelcome.Height + spacing
            );
        }
    }
}