using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBOBarberMate.Presentation.Views.Auth
{
    using PBOBarberMate.App.Services;
    using PBOBarberMate.Core.Common;
    using PBOBarberMate.Core.Entities;
    using PBOBarberMate.Core.Interfaces;
    using PBOBarberMate.Presentation.Forms;

    //SessionService.NotifyProfileChanged(); kalo perubahan berhasil panggil ini selebum show message berhasil

    public partial class UbahProfilUC : UserControl, IPageFeature
    {
        public string PageTitle => "Ubah Profil";
        private readonly AkunService _service;
        private readonly INavigationService _nav;

        public UbahProfilUC(AkunService service, INavigationService nav)
        {
            InitializeComponent();
            _service = service;
            _nav = nav;
            SetupUI();
        }
        private void SetupUI()
        {
            // btnCancel hover
            btnCancel.MouseEnter += (s, e) => { btnCancel.BackColor = Color.Orange; pictbxBack.BackColor = Color.Orange; };
            btnCancel.MouseLeave += (s, e) => { btnCancel.BackColor = Color.WhiteSmoke; pictbxBack.BackColor = Color.WhiteSmoke; };
            // btnAdd hover
            btnSimpan.MouseEnter += (s, e) =>
            {
                btnSimpan.BackColor = Color.Green; btnSimpan.ForeColor = Color.White;
                pictbxAddHov.BackColor = Color.Green; pictbxAddHov.Visible = true; pictbxAddHov.BringToFront();
                pictbxAdd.Visible = false;
            };
            btnSimpan.MouseLeave += (s, e) =>
            {
                btnSimpan.BackColor = Color.WhiteSmoke; btnSimpan.ForeColor = Color.Black;
                pictbxAddHov.Visible = false;
                pictbxAdd.Visible = true;
            };
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            _nav.NavigateToDashboard();
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            if (!((tbxNama.Text.Length > 0) || (tbxEmail.Text.Length > 0) || (tbxUsername.Text.Length > 0) || (tbxPassword.Text.Length > 0))) return;
            DialogResult confirm = MessageBox.Show(
                $"Apakah Anda yakin?",
                "Konfirmasi",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
);
            if (confirm == DialogResult.Yes)
            {
                var akunBaru = new M_Akun
                {
                    IdAkun = SessionService.CurrentUser.IdAkun,
                    Nama = tbxNama.Text,
                    Email = tbxEmail.Text,
                    Username = tbxEmail.Text,
                    Password = tbxPassword.Text
                };
                Result<bool> result = _service.UbahProfil(akunBaru);
                if (result.IsSuccess)
                {
                    MessageBox.Show(result.Message);
                    //redirect ke DashboardUC
                    _nav.NavigateToDashboard();
                }
                else
                {
                    MessageBox.Show(result.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
    }
}