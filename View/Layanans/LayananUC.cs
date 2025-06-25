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

using PBOBarberMate.App.Model;
using PBOBarberMate.App.Services;
using PBOBarberMate.App.Repository;


namespace PBOBarberMate.View.Layanan
{
    public partial class LayananUC : UserControl
    {
        private readonly CommonAppServices _commonServices;
        private readonly LayananService _layananService;


        public LayananUC(CommonAppServices commonServices, LayananService layananService)
        {
            InitializeComponent();
            _commonServices = commonServices;
            _layananService = layananService;

            this.Load += FormLayanan_Load;
        }

        private void FormLayanan_Load(object sender, EventArgs e)
        {
            LoadDgvLayanan();
            EnableButtonAdd();
            SetAddButtonlHoverEvents(btnTambah, pictbxAdd, pictbxAddHov);
            AdjustPictbxAddPosition();
        }
        private void SetAddButtonlHoverEvents(Control button, Control relatedControl, Control relatedHovControl)
        {
            button.MouseEnter += (s, e) => { 
                button.BackColor = SystemColors.Highlight; button.ForeColor = Color.White; 
                relatedControl.Visible = false; relatedHovControl.Visible = true; relatedHovControl.BringToFront(); relatedHovControl.BackColor = SystemColors.Highlight; 
            };
            button.MouseLeave += (s, e) => { 
                button.BackColor = Color.WhiteSmoke; button.ForeColor = Color.Black; 
                relatedControl.Visible = true; relatedHovControl.Visible = false; relatedControl.BringToFront();
            };
        }
        private void AdjustPictbxAddPosition()
        {
            if (btnTambah != null && pictbxAdd != null && pictbxAddHov != null)
            {
                int x = btnTambah.Location.X + 7;
                int y = btnTambah.Location.Y + (btnTambah.Height - pictbxAdd.Height) / 2;

                pictbxAddHov.Location = new Point(x, y);
                pictbxAdd.Location = new Point(x, y);
                pictbxAdd.BringToFront();

            }
        }
        // NAMPILKAN SEMUA DATA LAYANAN
        private void LoadDgvLayanan()
        {
            List<M_Layanan> daftarLayanan = _layananService.getAllLayanan();
            DataTable dtLayanan = ConvertLayananListToDataTable(daftarLayanan);
            dgvLayanan.DataSource = dtLayanan;
            dgvLayanan.AutoGenerateColumns = false;
            dgvLayanan.RowHeadersVisible = false;
            dgvLayanan.AllowUserToAddRows = false;
            // Kolom Ubah
            if (dgvLayanan.Columns["btnUbah"] == null)
            {
                DataGridViewButtonColumn btnUbah = new DataGridViewButtonColumn();
                btnUbah.Name = "btnUbah";
                btnUbah.HeaderText = "Ubah";
                btnUbah.Text = "Ubah";
                btnUbah.UseColumnTextForButtonValue = true;
                dgvLayanan.Columns.Add(btnUbah);
            }
            // Kolom Hapus
            if (dgvLayanan.Columns["btnHapus"] == null)
            {
                DataGridViewButtonColumn btnHapus = new DataGridViewButtonColumn();
                btnHapus.Name = "btnHapus";
                btnHapus.HeaderText = "Hapus";
                btnHapus.Text = "Hapus";
                btnHapus.UseColumnTextForButtonValue = true;
                dgvLayanan.Columns.Add(btnHapus);
            }
        }
        // METHOD MEMBUAT DATA TABLE DARI DATA OBJECT
        private DataTable ConvertLayananListToDataTable(List<M_Layanan> layananList)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("ID Layanan", typeof(int));
            dt.Columns.Add("Nama Layanan", typeof(string));
            dt.Columns.Add("Harga", typeof(int));
            foreach (M_Layanan layanan in layananList)
            {
                dt.Rows.Add(layanan.id_layanan, layanan.nama_layanan, layanan.harga);
            }

            return dt;
        }
        // METHOD AKTIFKAN TOMBOL KHUSUS ADMIN
        private void EnableButtonAdd()
        {
            // atur tombol add layanan
            if (_commonServices.SessionServiceInstance.CurrentUserRole == AkunRole.admin)
            {
                btnTambah.Visible = true;
            }
            // atur tombol edit layanan
            if (dgvLayanan.Columns.Contains("btnUbah"))
            {
                dgvLayanan.Columns["btnUbah"].Visible = (_commonServices.SessionServiceInstance.CurrentUserRole == AkunRole.admin);
            }
            // atur tombol hapus layanan
            if (dgvLayanan.Columns.Contains("btnHapus"))
            {
                dgvLayanan.Columns["btnHapus"].Visible = (_commonServices.SessionServiceInstance.CurrentUserRole == AkunRole.admin);
            }
        }


        // REDIRECT KE TAMBAH LAYANAN
        private void btnTambah_Click(object sender, EventArgs e)
        {
            _commonServices.MainAppInstance.LoadFeatureIntoActiveHomepageContent(new LayananTambahUC(_commonServices, _layananService), "Tambah Layanan");
        }

        // EVENT HANDLER TOMBOL UBAH DAN HAPUS
        private void dgvLayanan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Pastikan baris yang diklik valid (bukan header atau baris kosong)
            if (e.RowIndex < 0) return;

            // Dapatkan ID Layanan dari baris yang diklik
            int idLayanan = Convert.ToInt32(dgvLayanan.Rows[e.RowIndex].Cells["ID Layanan"].Value);

            // Jika tombol "Ubah" yang diklik
            if (e.ColumnIndex == dgvLayanan.Columns["btnUbah"].Index)
            {
                // Dapatkan objek M_Layanan lengkap untuk diedit
                M_Layanan layananUntukDiedit = _layananService.getLayananById(idLayanan);

                if (layananUntukDiedit != null)
                {
                    // Muat LayananTambahUC dalam mode edit dengan data layanan
                    _commonServices.MainAppInstance.LoadFeatureIntoActiveHomepageContent(new LayananTambahUC(_commonServices, _layananService, layananUntukDiedit), "Ubah Layanan");
                }
                else
                {
                    MessageBox.Show("Data layanan tidak ditemukan.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            // Jika tombol "Hapus" yang diklik
            else if (e.ColumnIndex == dgvLayanan.Columns["btnHapus"].Index)
            {
                DialogResult confirm = MessageBox.Show(
                    $"Apakah Anda yakin ingin menghapus layanan ini (ID Layanan: {idLayanan})?",
                    "Konfirmasi Hapus",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (confirm == DialogResult.Yes)
                {
                    try
                    {
                        bool success = _layananService.deleteLayanan(idLayanan);
                        if (success)
                        {
                            MessageBox.Show("Layanan berhasil dihapus.", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadDgvLayanan(); // Muat ulang data setelah penghapusan
                        }
                        else
                        {
                            MessageBox.Show("Gagal menghapus layanan.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Terjadi kesalahan saat menghapus: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
