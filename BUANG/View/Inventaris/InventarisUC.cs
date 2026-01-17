//using Npgsql;
//using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
//using System.Drawing;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Windows.Forms;
//using PBOBarberMate.View.Layanan;
//using PBOBarberMate.BUANG.App.Services;
//using PBOBarberMate.BUANG.App.Utils;
//using PBOBarberMate.BUANG.Core.Entities;


//namespace PBOBarberMate.View.Inventaris
//{
//    public partial class InventarisUC : UserControl
//    {
//        private readonly CommonAppServices _commonServices;
//        private readonly InventarisService _inventarisService;

//        public InventarisUC(CommonAppServices commonServices, InventarisService inventarisService)
//        {
//            InitializeComponent();
//            _commonServices = commonServices;
//            _inventarisService = inventarisService;
//            this.Load += FormInventaris_Load;
//        }

//        private void FormInventaris_Load(object sender, EventArgs e)
//        {
//            LoadDgvInventaris();
//            EnableButtonAdd();
//            SetAddButtonlHoverEvents(btnTambah, pictbxAdd, pictbxAddHov);
//            AdjustPictbxAddPosition();
//        }

//        private void SetAddButtonlHoverEvents(Control button, Control relatedControl, Control relatedHovControl)
//        {
//            button.MouseEnter += (s, e) =>
//            {
//                button.BackColor = SystemColors.Highlight; button.ForeColor = Color.White;
//                relatedControl.Visible = false; relatedHovControl.Visible = true; relatedHovControl.BringToFront(); relatedHovControl.BackColor = SystemColors.Highlight;
//            };
//            button.MouseLeave += (s, e) =>
//            {
//                button.BackColor = Color.WhiteSmoke; button.ForeColor = Color.Black;
//                relatedControl.Visible = true; relatedHovControl.Visible = false; relatedControl.BringToFront();
//            };
//        }
//        private void AdjustPictbxAddPosition()
//        {
//            if (btnTambah != null && pictbxAdd != null && pictbxAddHov != null)
//            {
//                int x = btnTambah.Location.X + 7;
//                int y = btnTambah.Location.Y + (btnTambah.Height - pictbxAdd.Height) / 2;

//                pictbxAddHov.Location = new Point(x, y);
//                pictbxAdd.Location = new Point(x, y);
//                pictbxAdd.BringToFront();

//            }
//        }
//        // METHOD AKTIFKAN TOMBOL KHUSUS ADMIN
//        private void EnableButtonAdd()
//        {
//            // atur tombol add layanan
//            if (_commonServices.SessionServiceInstance.CurrentUserRole == AkunRole.admin)
//            {
//                btnTambah.Visible = true;
//                pictbxAdd.Visible = true;
//                pictbxAddHov.Visible = true;
//            }
//            // atur tombol edit layanan
//            if (dgvInventaris.Columns.Contains("btnUbah"))
//            {
//                dgvInventaris.Columns["btnUbah"].Visible = (
//                    (_commonServices.SessionServiceInstance.CurrentUserRole == AkunRole.admin) ||
//                    (_commonServices.SessionServiceInstance.CurrentUserRole == AkunRole.karyawan)
//                    );
//            }
//            // atur tombol hapus layanan
//            if (dgvInventaris.Columns.Contains("btnHapus"))
//            {
//                dgvInventaris.Columns["btnHapus"].Visible = (_commonServices.SessionServiceInstance.CurrentUserRole == AkunRole.admin);
//            }
//        }
//        // NAMPILKAN SEMUA DATA INVENTARIS
//        private void LoadDgvInventaris()
//        {
//            List<M_Inventaris> daftarInventaris = _inventarisService.getAllInventaris();
//            // set juga var global internal
//            inventarisList = daftarInventaris;

//            dgvInventaris.AutoGenerateColumns = false;
//            dgvInventaris.Columns.Clear();

//            // kolom dengan header kustom
//            dgvInventaris.Columns.Add(new DataGridViewTextBoxColumn
//            {
//                HeaderText = "ID Barang",
//                DataPropertyName = "id_barang",
//                Name = "colId"
//            });
//            dgvInventaris.Columns.Add(new DataGridViewTextBoxColumn
//            {
//                HeaderText = "Nama Barang",
//                DataPropertyName = "nama_barang",
//                Name = "colNama"
//            });
//            dgvInventaris.Columns.Add(new DataGridViewTextBoxColumn
//            {
//                HeaderText = "Jumlah",
//                DataPropertyName = "jumlah_barang",
//                Name = "colJumlah"
//            });

//            dgvInventaris.DataSource = daftarInventaris;
//            dgvInventaris.RowHeadersVisible = false;
//            dgvInventaris.AllowUserToAddRows = false;

//            // Kolom Ubah
//            if (dgvInventaris.Columns["btnUbah"] == null)
//            {
//                DataGridViewButtonColumn btnUbah = new DataGridViewButtonColumn();
//                btnUbah.Name = "btnUbah";
//                btnUbah.HeaderText = "Ubah";
//                btnUbah.Text = "Ubah";
//                btnUbah.UseColumnTextForButtonValue = true;
//                dgvInventaris.Columns.Add(btnUbah);
//            }
//            // Kolom Hapus
//            if (dgvInventaris.Columns["btnHapus"] == null)
//            {
//                DataGridViewButtonColumn btnHapus = new DataGridViewButtonColumn();
//                btnHapus.Name = "btnHapus";
//                btnHapus.HeaderText = "Hapus";
//                btnHapus.Text = "Hapus";
//                btnHapus.UseColumnTextForButtonValue = true;
//                dgvInventaris.Columns.Add(btnHapus);
//            }
//        }

//        // REDIRECT KE TAMBAH INVENTARIS
//        private void btnTambah_Click(object sender, EventArgs e)
//        {
//            _commonServices.MainAppInstance.LoadFeatureIntoActiveHomepageContent(new InventarisTambahUC(_commonServices, _inventarisService), "Tambah Inventaris");
//        }


//        private void dgvInventaris_CellContentClick(object sender, DataGridViewCellEventArgs e)
//        {
//            // Pastikan baris yang diklik valid (bukan header atau baris kosong)
//            if (e.RowIndex < 0) return;
//            // Dapatkan ID dari baris yang diklik
//            int id_inventaris = Convert.ToInt32(dgvInventaris.Rows[e.RowIndex].Cells["colId"].Value);

//            // Jika tombol "Ubah" yang diklik
//            if (e.ColumnIndex == dgvInventaris.Columns["btnUbah"].Index)
//            {
//                // Dapatkan objek M_Inventaris lengkap untuk diedit
//                M_Inventaris inventarisDiedit = _inventarisService.getInventarisById(id_inventaris);
//                if (inventarisDiedit != null)
//                {
//                    _commonServices.MainAppInstance.LoadFeatureIntoActiveHomepageContent(new InventarisTambahUC(_commonServices, _inventarisService, inventarisDiedit), "Ubah Inventaris");
//                }
//                else
//                {
//                    MessageBox.Show("Data inventaris tidak ditemukan.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
//                }
//            }
//            // Jika tombol "Hapus" yang diklik
//            else if (e.ColumnIndex == dgvInventaris.Columns["btnHapus"].Index)
//            {
//                DialogResult confirm = MessageBox.Show(
//                    $"Apakah Anda yakin ingin menghapus inventaris ini (ID Barang: {id_inventaris})?",
//                    "Konfirmasi Hapus",
//                    MessageBoxButtons.YesNo,
//                    MessageBoxIcon.Question
//                );

//                if (confirm == DialogResult.Yes)
//                {
//                    try
//                    {
//                        bool success = _inventarisService.deleteInventaris(id_inventaris);
//                        if (success)
//                        {
//                            MessageBox.Show("Inventaris berhasil dihapus.", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
//                            LoadDgvInventaris(); // Muat ulang data setelah penghapusan
//                        }
//                        else
//                        {
//                            MessageBox.Show("Gagal menghapus inventaris.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
//                        }
//                    }
//                    catch (Exception ex)
//                    {
//                        MessageBox.Show($"Terjadi kesalahan saat menghapus: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
//                    }
//                }
//            }
//        }

//        private List<M_Inventaris> inventarisList;
//        private void dgvInventaris_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
//        {
//            DataGridViewSorter.Sort(dgvInventaris, e, ref inventarisList);
//        }
//    }
//}
