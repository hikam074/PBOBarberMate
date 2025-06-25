using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PBOBarberMate.App.Model;
using PBOBarberMate.App.Services;
using PBOBarberMate.View.Layanan;


namespace PBOBarberMate.View.KelolaKaryawan
{
    public partial class KelolaKaryawanTambahUC : UserControl
    {
        private readonly CommonAppServices _commonServices;
        public readonly bool _isEditMode;
        public readonly M_Karyawan _karyawanDiedit;

        public KelolaKaryawanTambahUC(CommonAppServices commonServices)
        {
            InitializeComponent();

            _commonServices = commonServices;
            _isEditMode = false;

            SetCancelButtonlHoverEvents(btnCancel, pictbxBack);
            SetAddButtonlHoverEvents(btnAdd, pictbxAdd, pictbxAddHov);
            AdjustPictbxAddPosition();
        }
        public KelolaKaryawanTambahUC(CommonAppServices commonServices, M_Karyawan karyawanDiedit)
        {
            InitializeComponent();

            _commonServices = commonServices;

            _isEditMode = true;
            _karyawanDiedit = karyawanDiedit;

            // penyesuaian view
            tbxNama.Text = _karyawanDiedit.nama;
            tbxEmail.Text = _karyawanDiedit.email;
            btnAdd.Text = "     Simpan Perubahan";
            lblTambah.Text = "Ubah Data Karyawan " + _karyawanDiedit.nama;
            SetCancelButtonlHoverEvents(btnCancel, pictbxBack);
            SetAddButtonlHoverEvents(btnAdd, pictbxAdd, pictbxAddHov);
            AdjustPictbxAddPosition();
            tbxPassword.Enabled = false;
        }

        private void SetCancelButtonlHoverEvents(Control button, Control relatedControl)
        {
            button.MouseEnter += (s, e) => { button.BackColor = Color.Orange; relatedControl.BackColor = Color.Orange; };
            button.MouseLeave += (s, e) => { button.BackColor = Color.WhiteSmoke; relatedControl.BackColor = Color.WhiteSmoke; };
        }
        private void SetAddButtonlHoverEvents(Control button, Control relatedControl, Control relatedHovControl)
        {
            button.MouseEnter += (s, e) =>
            {
                button.BackColor = Color.Green; button.ForeColor = Color.White;
                relatedHovControl.BackColor = Color.Green; relatedHovControl.Visible = true; relatedHovControl.BringToFront();
                relatedControl.Visible = false;
            };
            button.MouseLeave += (s, e) =>
            {
                button.BackColor = Color.WhiteSmoke; button.ForeColor = Color.Black;
                relatedHovControl.Visible = false;
                relatedControl.Visible = true;
            };
        }
        private void AdjustPictbxAddPosition()
        {
            if (btnAdd != null && pictbxAdd != null && pictbxAddHov != null)
            {
                int x = btnAdd.Location.X + 7;
                int y = btnAdd.Location.Y + (btnAdd.Height - pictbxAdd.Height) / 2;

                pictbxAddHov.Location = new Point(x, y);
                pictbxAdd.Location = new Point(x, y);
                pictbxAdd.BringToFront();

            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            _commonServices.MainAppInstance.LoadFeatureIntoActiveHomepageContent(new KelolaKaryawanUC(_commonServices), "Kelola Karyawan");
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!ValidateInput())
            {
                return;
            }
            // ambil data dari V
            string nama = tbxNama.Text;
            string email = tbxEmail.Text;
            string password = tbxPassword.Text;
            // konfirmasi berhasil
            bool berhasil = false;

            // konfirmasi
            DialogResult confirm = MessageBox.Show(
                $"Apakah Anda yakin?",
                "Konfirmasi",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );
            // konfirmasi yes
            if (confirm == DialogResult.Yes)
            {
                if (!_isEditMode)
                {
                    berhasil = _commonServices.AkunServiceInstance.addAkun(nama, email, password, AkunRole.karyawan);
                    if (berhasil)
                    {
                        MessageBox.Show("Data \"" + nama + "\" Berhasil Ditambahkan!");
                    }
                }
                else
                {
                    // ambil id
                    int id_diedit = _karyawanDiedit.id_akun;
                    // lakukan
                    berhasil = _commonServices.AkunServiceInstance.updateAkun(nama, email, password, AkunRole.karyawan, id_diedit);
                    if (berhasil)
                    {
                        MessageBox.Show("Data \"" + nama + "\" Berhasil diubah!");
                    }
                }
                if (berhasil)
                {
                    _commonServices.MainAppInstance.LoadFeatureIntoActiveHomepageContent(new KelolaKaryawanUC(_commonServices), "Kelola Karyawan");
                }
            }
        }
        private bool ValidateInput()
        {
            // not null
            if (string.IsNullOrWhiteSpace(tbxNama.Text) || string.IsNullOrWhiteSpace(tbxEmail.Text) || (string.IsNullOrWhiteSpace(tbxPassword.Text) && (_isEditMode == false)))
            {
                MessageBox.Show("Data tidak boleh kosong.", "Validasi Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            // ujicoba email
            string email = tbxEmail.Text;
            M_Akun karyawanDariDB = _commonServices.AkunServiceInstance.getAkunByEmail(email);
            if (
                ((karyawanDariDB != null) && _isEditMode == false) ||                               // kalau datanya ada dan bukan mode edit
                ((karyawanDariDB != null) && (karyawanDariDB.id_akun != _karyawanDiedit.id_akun))   // kalau datanya ada dan id yg ada itu g sama dgn id kita
                )
            {
                MessageBox.Show("Email ini Sudah Digunakan.", "Validasi Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private void tbxNama_TextChanged(object sender, EventArgs e)
        {
            UpdateAddButtonState();
        }

        private void tbxEmail_TextChanged(object sender, EventArgs e)
        {
            UpdateAddButtonState();
        }

        private void tbxPassword_TextChanged(object sender, EventArgs e)
        {
            UpdateAddButtonState();
        }
        // METHOD ACTIVING ADD BTN IF NOT EMPTY
        public void UpdateAddButtonState()
        {
            btnAdd.Enabled = !(string.IsNullOrWhiteSpace(tbxNama.Text) || string.IsNullOrWhiteSpace(tbxEmail.Text) || (string.IsNullOrWhiteSpace(tbxPassword.Text) && (_isEditMode == false)));
        }
    }
}
