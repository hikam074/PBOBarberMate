using System;
using System.Drawing;
using System.Windows.Forms;

namespace PBOBarberMate.Presentation.Views.Auth
{
    using PBOBarberMate.Presentation.Forms;
    using PBOBarberMate.App.Services;
    using PBOBarberMate.Core.Entities;

    public partial class LoginUC : UserControl
    {
        private readonly AkunService _akunService;


        public LoginUC(AkunService akunService)
        {
            InitializeComponent();
            _akunService = akunService;

            tbxLoginPass.PasswordChar = '*';
            UpdateLoginButtonState();
            this.Resize += new EventHandler(FormLogin_Resize);
        }

        private void UpdateLoginButtonState()
        {
            btnLoginSubmit.Enabled = !(string.IsNullOrWhiteSpace(tbxLoginEmail.Text) || string.IsNullOrWhiteSpace(tbxLoginPass.Text));
        }

        private void tbxLoginEmail_TextChanged(object sender, EventArgs e)
        {
            UpdateLoginButtonState();
        }

        private void tbxLoginPass_TextChanged(object sender, EventArgs e)
        {
            UpdateLoginButtonState();
        }

        private void btnLoginSubmit_Click(object sender, EventArgs e)
        {
            M_Akun akun = new M_Akun() { Username = tbxLoginEmail.Text, Password = tbxLoginPass.Text };
            string result = _akunService.Login(akun);

            if (result == "Sukses")
            {
                var user = SessionService.CurrentUser;
                MessageBox.Show($"Selamat datang {user.Nama} ({user.NamaRole})");

                // Pindah ke Dashboard di MainApp
                if (this.ParentForm is MainApp main)
                {
                    main.UpdateUIByRole();
                }
            }
            else
            {
                MessageBox.Show(result, "Login Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lklblLoginSignupRedirect_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // redirect ke signup
            if (this.ParentForm is MainApp main)
            {
                main.ShowRegister();
            }
        }

        private void btnLoginSubmit_MouseEnter(object sender, EventArgs e)
        {
            if (btnLoginSubmit.Enabled)
            {
                btnLoginSubmit.BackColor = Color.FromArgb(243, 156, 18);
                btnLoginSubmit.ForeColor = Color.FromArgb(44, 62, 80);
            }
        }

        private void btnLoginSubmit_MouseLeave(object sender, EventArgs e)
        {
            if (btnLoginSubmit.Enabled)
            {
                btnLoginSubmit.BackColor = Color.FromArgb(44, 62, 80);
                btnLoginSubmit.ForeColor = Color.White;
            }
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            CenterComponentVertically(this.gbxLogin);
            CenterLabelsVertically(this.lblLoginWelcome, this.lblLoginAppName);
        }

        private void FormLogin_Resize(object sender, EventArgs e)
        {
            CenterComponentVertically(this.gbxLogin);
            CenterLabelsVertically(this.lblLoginWelcome, this.lblLoginAppName);
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
