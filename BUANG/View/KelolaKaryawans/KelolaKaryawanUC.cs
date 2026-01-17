//using PBOBarberMate.View.Layanan;
//using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
//using System.Drawing;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Windows.Forms;
//using PBOBarberMate.BUANG.App.Services;
//using PBOBarberMate.BUANG.App.Utils;
//using PBOBarberMate.BUANG.Core.Entities;


//namespace PBOBarberMate.View.KelolaKaryawan
//{
//    public partial class KelolaKaryawanUC : UserControl
//    {
//        private readonly CommonAppServices _commonServices;

//        public KelolaKaryawanUC(CommonAppServices commonServices)
//        {
//            InitializeComponent();

//            _commonServices = commonServices;
//        }

//        private void KelolaKaryawanUC_Load(object sender, EventArgs e)
//        {
//            LoadDgvKaryawan();
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
//        // NAMPILKAN SEMUA DATA KARYAWAN
//        private void LoadDgvKaryawan()
//        {
//            List<M_Karyawan> karyawans = _commonServices.AkunServiceInstance.getAllKaryawan();
//            // set juga var global internal
//            karyawanList = karyawans;

//            dgvKaryawan.AutoGenerateColumns = false;
//            dgvKaryawan.Columns.Clear();

//            // kolom dengan header kustom
//            dgvKaryawan.Columns.Add(new DataGridViewTextBoxColumn
//            {
//                HeaderText = "ID Karyawan",
//                DataPropertyName = "id_akun",
//                Name = "colId"
//            });
//            dgvKaryawan.Columns.Add(new DataGridViewTextBoxColumn
//            {
//                HeaderText = "Nama Lengkap",
//                DataPropertyName = "nama",
//                Name = "colNama"
//            });
//            dgvKaryawan.Columns.Add(new DataGridViewTextBoxColumn
//            {
//                HeaderText = "Alamat Email",
//                DataPropertyName = "email",
//                Name = "colEmail"
//            });

//            dgvKaryawan.DataSource = karyawans;
//            dgvKaryawan.RowHeadersVisible = false;
//            dgvKaryawan.AllowUserToAddRows = false;

//            // Kolom Ubah
//            if (dgvKaryawan.Columns["btnUbah"] == null)
//            {
//                DataGridViewButtonColumn btnUbah = new DataGridViewButtonColumn();
//                btnUbah.Name = "btnUbah";
//                btnUbah.HeaderText = "Ubah";
//                btnUbah.Text = "Ubah";
//                btnUbah.UseColumnTextForButtonValue = true;
//                dgvKaryawan.Columns.Add(btnUbah);
//            }
//            // Kolom Hapus
//            if (dgvKaryawan.Columns["btnHapus"] == null)
//            {
//                DataGridViewButtonColumn btnHapus = new DataGridViewButtonColumn();
//                btnHapus.Name = "btnHapus";
//                btnHapus.HeaderText = "Hapus";
//                btnHapus.Text = "Hapus";
//                btnHapus.UseColumnTextForButtonValue = true;
//                dgvKaryawan.Columns.Add(btnHapus);
//            }
//        }

//        private void btnTambah_Click(object sender, EventArgs e)
//        {
//            _commonServices.MainAppInstance.LoadFeatureIntoActiveHomepageContent(new KelolaKaryawanTambahUC(_commonServices), "Tambah Karyawan");
//        }

//        private void dgvKaryawan_CellContentClick(object sender, DataGridViewCellEventArgs e)
//        {
//            // Pastikan baris yang diklik valid (bukan header atau baris kosong)
//            if (e.RowIndex < 0) return;

//            // Dapatkan ID Layanan dari baris yang diklik
//            int id = Convert.ToInt32(dgvKaryawan.Rows[e.RowIndex].Cells["colId"].Value);

//            // Jika tombol "Ubah" yang diklik
//            if (e.ColumnIndex == dgvKaryawan.Columns["btnUbah"].Index)
//            {
//                // Dapatkan objek M_Layanan lengkap untuk diedit
//                M_Akun akunDiedit = _commonServices.AkunServiceInstance.getAkunById(id);
//                M_Karyawan karyawanDiedit = new M_Karyawan(akunDiedit);

//                if (karyawanDiedit != null)
//                {
//                    // Muat LayananTambahUC dalam mode edit dengan data layanan
//                    _commonServices.MainAppInstance.LoadFeatureIntoActiveHomepageContent(new KelolaKaryawanTambahUC(_commonServices, karyawanDiedit), "Ubah Data Karyawan");
//                }
//                else
//                {
//                    MessageBox.Show("Data karyawan tidak ditemukan.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
//                }
//            }
//            // Jika tombol "Hapus" yang diklik
//            else if (e.ColumnIndex == dgvKaryawan.Columns["btnHapus"].Index)
//            {
//                DialogResult confirm = MessageBox.Show(
//                    $"Apakah Anda yakin ingin menghapus karyawan ini (ID karyawan: {id})?",
//                    "Konfirmasi Hapus",
//                    MessageBoxButtons.YesNo,
//                    MessageBoxIcon.Question
//                );

//                if (confirm == DialogResult.Yes)
//                {
//                    try
//                    {
//                        bool success = _commonServices.AkunServiceInstance.deleteAkun(id);
//                        if (success)
//                        {
//                            MessageBox.Show("Karyawan berhasil dihapus.", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
//                            LoadDgvKaryawan(); // Muat ulang data setelah penghapusan
//                        }
//                        else
//                        {
//                            MessageBox.Show("Gagal menghapus karyawan.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
//                        }
//                    }
//                    catch (Exception ex)
//                    {
//                        MessageBox.Show($"Terjadi kesalahan saat menghapus: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
//                    }
//                }
//            }
//        }

//        private List<M_Karyawan> karyawanList;
//        private void dgvKaryawan_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
//        {
//            DataGridViewSorter.Sort(dgvKaryawan, e, ref karyawanList);
//        }
//    }
//}