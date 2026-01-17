using Npgsql;
using System;
using System.Windows.Forms;

namespace PBOBarberMate.Presentation.Views.Auth
{
    using Microsoft.VisualBasic.ApplicationServices;
    using PBOBarberMate.App.Services;
    using PBOBarberMate.Core.Entities;
    using PBOBarberMate.Presentation.Forms;

    public partial class SignupUC : UserControl
    {
        private readonly AkunService _akunService;

        public SignupUC(AkunService akunService)
        {
            InitializeComponent();
            _akunService = akunService;
        }

        private void lklblLoginSignupRedirect_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // mengarahkan ke FormLogin
            if (this.ParentForm is MainApp main)
            {
                main.ShowLogin();
            }
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
            M_Akun akun = new M_Akun()
            {
                Nama = tbxSignupNama.Text,
                Username = tbxSignupUsername.Text,
                Email = tbxSignupEmail.Text,
                Password = tbxSignupPass.Text,
            };
            string result = _akunService.Register(akun);

            if (result == "Sukses")
            {
                MessageBox.Show("Akun anda berhasil dibuat! Silahkan login");
                // mengarahkan ke FormLogin
                if (this.ParentForm is MainApp main)
                {
                    main.ShowLogin();
                }
            }
            else
            {
                MessageBox.Show(result, "Register Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
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