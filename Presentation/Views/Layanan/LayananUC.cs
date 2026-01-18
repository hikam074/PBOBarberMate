using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace PBOBarberMate.Presentation.Views.Layanan
{
    using PBOBarberMate.App.Services;
    using PBOBarberMate.Core.Common;
    using PBOBarberMate.Core.Entities;
    using PBOBarberMate.Core.Enums;
    using PBOBarberMate.Core.Interfaces;
    using PBOBarberMate.Presentation.Views.Inventory;

    public partial class LayananUC : UserControl, IPageFeature
    {
        public string PageTitle => "Daftar Layanan";
        private readonly LayananService _service;
        private readonly INavigationService _nav;

        public LayananUC(LayananService service, INavigationService nav)
        {
            InitializeComponent();
            _service = service;
            _nav = nav;
            LoadDataToGrid();
            SetupUIByRole();
        }

        private void SetupUIByRole()
        {
            bool isAdmin = SessionService.CurrentUser.IdRole == (int)UserRole.Admin;
            // munculkan btnAdd kalau admin
            btnTambah.Visible = isAdmin;
            pictbxAdd.Visible = isAdmin;
            pictbxAddHov.Visible = isAdmin;
            // atur tombol edit layanan
            if (dgvLayanan.Columns.Contains("btnUbah"))
            {
                dgvLayanan.Columns["btnUbah"].Visible = isAdmin;
            }
            // atur tombol hapus layanan
            if (dgvLayanan.Columns.Contains("btnHapus"))
            {
                dgvLayanan.Columns["btnHapus"].Visible = isAdmin;
            }
            // set hover btnTambah
            btnTambah.MouseEnter += (s, e) =>
            {
                btnTambah.BackColor = SystemColors.Highlight; btnTambah.ForeColor = Color.White;
                pictbxAdd.Visible = false; pictbxAddHov.Visible = true; pictbxAddHov.BringToFront(); pictbxAddHov.BackColor = SystemColors.Highlight;
            };
            btnTambah.MouseLeave += (s, e) =>
            {
                btnTambah.BackColor = Color.WhiteSmoke; btnTambah.ForeColor = Color.Black;
                pictbxAdd.Visible = true; pictbxAddHov.Visible = false; pictbxAddHov.BringToFront();
            };
        }
        private void LoadDataToGrid()
        {
            var result = _service.AmbilSemuaLayanan();
            if (result.IsSuccess)
            {
                dgvLayanan.DataSource = null;
                dgvLayanan.DataSource = result.Data;
                dgvLayanan.Columns["IdLayanan"].Visible = false; // Sembunyikan ID
                dgvLayanan.Columns["NamaLayanan"].HeaderText = "Nama Layanan";
                dgvLayanan.Columns["Harga"].HeaderText = "harga";
                dgvLayanan.Columns["Deskripsi"].HeaderText = "Deskripsi";
                // Kolom Ubah
                if (dgvLayanan.Columns["btnUbah"] == null)
                {
                    DataGridViewButtonColumn btnUbah = new DataGridViewButtonColumn();
                    btnUbah.Name = "btnUbah";
                    btnUbah.HeaderText = "Aksi";
                    btnUbah.Text = "Ubah";
                    btnUbah.UseColumnTextForButtonValue = true;
                    dgvLayanan.Columns.Add(btnUbah);
                }
                // Kolom Hapus
                if (dgvLayanan.Columns["btnHapus"] == null)
                {
                    DataGridViewButtonColumn btnHapus = new DataGridViewButtonColumn();
                    btnHapus.Name = "btnHapus";
                    btnHapus.HeaderText = "Aksi";
                    btnHapus.Text = "Hapus";
                    btnHapus.UseColumnTextForButtonValue = true;
                    dgvLayanan.Columns.Add(btnHapus);
                }
            }
            else
            {
                MessageBox.Show(result.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            _nav.LoadFitur(new LayananTambahUC(_service, _nav));
        }
        private void dgvLayanan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // pastikan baris yang diklik valid (bukan header atau baris kosong)
            if (e.RowIndex < 0) return;
            // get object dari baris yang diklik
            M_Layanan layananDipilih = (M_Layanan)dgvLayanan.Rows[e.RowIndex].DataBoundItem;
            // jika tombol "Ubah" yang diklik
            if (e.ColumnIndex == dgvLayanan.Columns["btnUbah"].Index)
            {
                _nav.LoadFitur(new LayananTambahUC(_service, _nav, layananDipilih));
            }
            // jika tombol "Hapus" yang diklik
            else if (e.ColumnIndex == dgvLayanan.Columns["btnHapus"].Index)
            {
                DialogResult confirm = MessageBox.Show(
                    $"Apakah Anda yakin ingin menghapus layanan ini (ID Layanan: {layananDipilih.IdLayanan})?",
                    "Konfirmasi Hapus",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );
                if (confirm == DialogResult.Yes)
                {
                    Result<bool> result = _service.HapusLayanan(layananDipilih.IdLayanan);
                    if (result.IsSuccess)
                    {
                        MessageBox.Show(result.Message);
                        //redirect ke LayananUC
                        _nav.LoadFitur(new LayananUC(_service, _nav));
                    }
                    else
                    {
                        MessageBox.Show(result.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }
    }
}
