using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace PBOBarberMate.Presentation.Views.Inventory
{
    using PBOBarberMate.App.Services;
    using PBOBarberMate.Core.Enums;
    using PBOBarberMate.Core.Interfaces;

    public partial class InventoryUC : UserControl, IPageFeature
    {
        public string PageTitle => "Daftar Inventory";
        private readonly InventoryService _service;
        private readonly INavigationService _nav;

        public InventoryUC(InventoryService service, INavigationService nav)
        {
            InitializeComponent();
            _service = service;
            _nav = nav;
            SetupUIByRole();
        }

        private void SetupUIByRole()
        {
            bool isAdmin = SessionService.CurrentUser.IdRole == (int)UserRole.Admin;
            bool isKaryawan = SessionService.CurrentUser.IdRole == (int)UserRole.Karyawan;
            btnTambah.Visible = isAdmin;
            pictbxAdd.Visible = isAdmin;
            pictbxAddHov.Visible = isAdmin;
            // atur tombol edit layanan
            if (dgvInventory.Columns.Contains("btnUbah"))
            {
                dgvInventory.Columns["btnUbah"].Visible = isAdmin || isKaryawan;
            }
            // atur tombol hapus layanan
            if (dgvInventory.Columns.Contains("btnHapus"))
            {
                dgvInventory.Columns["btnHapus"].Visible = isAdmin;
            }
        }
        private void LoadDataToGrid()
        {
            var result = _service.AmbilSemuaBarang();
            if (result.IsSuccess)
            {
                dgvInventory.DataSource = null;
                dgvInventory.DataSource = result.Data;
                dgvInventory.Columns["IdBarang"].Visible = false; // Sembunyikan ID
                dgvInventory.Columns["NamaBarang"].HeaderText = "Nama Barang";
                dgvInventory.Columns["Stok"].HeaderText = "Jumlah Stok";
                dgvInventory.Columns["IdAkunPengelola"].Visible = false; // Sembunyikan ID
                dgvInventory.Columns["NamaPengelola"].HeaderText = "Diinput Oleh";
            }
            else
            {
                MessageBox.Show(result.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // REDIRECT KE TAMBAH INVENTARIS
        private void btnTambah_Click(object sender, EventArgs e)
        {
           _nav.LoadFitur(new InventoryTambahUC(_service, _nav));
        }


        //private void dgvInventaris_CellContentClick(object sender, DataGridViewCellEventArgs e)
        //{
        //            // Pastikan baris yang diklik valid (bukan header atau baris kosong)
        //            if (e.RowIndex< 0) return;
        //            // Dapatkan ID dari baris yang diklik
        //            int id_inventaris = Convert.ToInt32(dgvInventaris.Rows[e.RowIndex].Cells["colId"].Value);

        //            // Jika tombol "Ubah" yang diklik
        //            if (e.ColumnIndex == dgvInventaris.Columns["btnUbah"].Index)
        //            {
        //                // Dapatkan objek M_Inventaris lengkap untuk diedit
        //                M_Inventaris inventarisDiedit = _inventarisService.getInventarisById(id_inventaris);
        //                if (inventarisDiedit != null)
        //                {
        //                    //_commonServices.MainAppInstance.LoadFeatureIntoActiveHomepageContent(new InventarisTambahUC(_commonServices, _inventarisService, inventarisDiedit), "Ubah Inventaris");
        //                }
        //                else
        //                {
        //                    MessageBox.Show("Data inventaris tidak ditemukan.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //                }
        //}
        //            // Jika tombol "Hapus" yang diklik
        //            else if (e.ColumnIndex == dgvInventaris.Columns["btnHapus"].Index)
        //{
        //    DialogResult confirm = MessageBox.Show(
        //        $"Apakah Anda yakin ingin menghapus inventaris ini (ID Barang: {id_inventaris})?",
        //        "Konfirmasi Hapus",
        //        MessageBoxButtons.YesNo,
        //        MessageBoxIcon.Question
        //    );

        //    if (confirm == DialogResult.Yes)
        //    {
        //        try
        //        {
        //            bool success = _inventarisService.deleteInventaris(id_inventaris);
        //            if (success)
        //            {
        //                MessageBox.Show("Inventaris berhasil dihapus.", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //                LoadDgvInventaris(); // Muat ulang data setelah penghapusan
        //            }
        //            else
        //            {
        //                MessageBox.Show("Gagal menghapus inventaris.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //            }
        //        }
        //        catch (Exception ex)
        //        {
        //            MessageBox.Show($"Terjadi kesalahan saat menghapus: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        }
        //    }
        //}
        //}



        private void dgvInventory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // pastikan baris yang diklik valid (bukan header atau baris kosong)
            if (e.RowIndex < 0) return;
            // Dapatkan ID dari baris yang diklik
            int id_inventaris = Convert.ToInt32(dgvInventory.Rows[e.RowIndex].Cells["colId"].Value);

            // Jika tombol "Ubah" yang diklik
            if (e.ColumnIndex == dgvInventory.Columns["btnUbah"].Index)
            {

            }
            // Jika tombol "Hapus" yang diklik
            else if (e.ColumnIndex == dgvInventory.Columns["btnHapus"].Index)
            {
                DialogResult confirm = MessageBox.Show(
                    $"Apakah Anda yakin ingin menghapus inventaris ini (ID Barang: {id_inventaris})?",
                    "Konfirmasi Hapus",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (confirm == DialogResult.Yes)
                {
                    //
                }
            }
        }

        private void dgvInventory_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //DataGridViewSorter.Sort(dgvInventaris, e, ref inventarisList);
        }

        private void InventoryUC_Load(object sender, EventArgs e)
        {
            LoadDataToGrid();
            //List<M_Inventaris> daftarInventaris = _inventarisService.getAllInventaris();
            //// set juga var global internal
            //inventarisList = daftarInventaris;

            //dgvInventaris.AutoGenerateColumns = false;
            //dgvInventaris.Columns.Clear();

            //// kolom dengan header kustom
            //dgvInventaris.Columns.Add(new DataGridViewTextBoxColumn
            //{
            //    HeaderText = "ID Barang",
            //    DataPropertyName = "id_barang",
            //    Name = "colId"
            //});
            //dgvInventaris.Columns.Add(new DataGridViewTextBoxColumn
            //{
            //    HeaderText = "Nama Barang",
            //    DataPropertyName = "nama_barang",
            //    Name = "colNama"
            //});
            //dgvInventaris.Columns.Add(new DataGridViewTextBoxColumn
            //{
            //    HeaderText = "Jumlah",
            //    DataPropertyName = "jumlah_barang",
            //    Name = "colJumlah"
            //});

            //dgvInventaris.DataSource = daftarInventaris;
            //dgvInventaris.RowHeadersVisible = false;
            //dgvInventaris.AllowUserToAddRows = false;

            //// Kolom Ubah
            //if (dgvInventaris.Columns["btnUbah"] == null)
            //{
            //    DataGridViewButtonColumn btnUbah = new DataGridViewButtonColumn();
            //    btnUbah.Name = "btnUbah";
            //    btnUbah.HeaderText = "Ubah";
            //    btnUbah.Text = "Ubah";
            //    btnUbah.UseColumnTextForButtonValue = true;
            //    dgvInventaris.Columns.Add(btnUbah);
            //}
            //// Kolom Hapus
            //if (dgvInventaris.Columns["btnHapus"] == null)
            //{
            //    DataGridViewButtonColumn btnHapus = new DataGridViewButtonColumn();
            //    btnHapus.Name = "btnHapus";
            //    btnHapus.HeaderText = "Hapus";
            //    btnHapus.Text = "Hapus";
            //    btnHapus.UseColumnTextForButtonValue = true;
            //    dgvInventaris.Columns.Add(btnHapus);
            //}
        }
    }
}
