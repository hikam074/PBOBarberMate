using PBOBarberMate.App.Context;
using PBOBarberMate.App.Core;
using PBOBarberMate.App.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBOBarberMate.View.FormUlasan
{
    public partial class FormUlasan : Form
    {
        public int id_pembayaran;
        public int id_layanan;
        public int id_akun;
        public FormUlasan()
        {
            InitializeComponent();
            DisplayUlasan();
        }

        private void DisplayUlasan()
        {
            // Ambil data ulasan dari database
            DataTable ulasanData = UlasanContext.All(id_layanan);

            // Bersihkan panel container setiap kali menampilkan ulang
            panelUlasanContainer.Controls.Clear();

            int panelSpacing = 10; // Jarak antar panel ulasan
            int totalHeight = 0; // Untuk menghitung tinggi total

            // Menampilkan setiap ulasan dalam panel
            foreach (DataRow row in ulasanData.Rows)
            {
                // Membuat panel untuk ulasan baru
                Panel ulasanPanel = new Panel
                {
                    Width = panelUlasanContainer.Width - 25, // Memberikan margin
                    Height = 200,
                    BorderStyle = BorderStyle.FixedSingle,
                    Padding = new Padding(10),
                    Margin = new Padding(5)
                };

                // Mendapatkan informasi ulasan
                int idPembayaran = Convert.ToInt32(row["id_pembayaran"]);  // Mengambil id_pembayaran dari ulasan
                string namaAkun = row["nama_akun"].ToString(); ;  // Memanggil fungsi getNamaAkun untuk mendapatkan nama akun
                string isiUlasan = row["isi_ulasan"].ToString();
                int rating = Convert.ToInt32(row["rating"]);
                DateTime tanggal = Convert.ToDateTime(row["tanggal_memberi_ulasan"]);

                // Label untuk nama akun
                Label labelNamaAkun = new Label
                {
                    Text = namaAkun,
                    AutoSize = true,
                    Font = new Font("Arial", 10, FontStyle.Bold),
                    Location = new Point(10, 10)
                };

                // Label untuk isi ulasan
                Label labelIsiUlasan = new Label
                {
                    Text = isiUlasan,
                    AutoSize = true,
                    MaximumSize = new Size(ulasanPanel.Width - 20, 0), // Agar teks melipat
                    Location = new Point(10, 70)
                };


                Panel ratingPanel = new Panel
                {
                    Size = new Size(150, 30), // Ukuran panel cukup untuk bintang
                    Location = new Point(10, 35), // Lokasi di bawah nama akun
                    BackColor = Color.Transparent // Agar tidak mengganggu tampilan
                };

                // Label untuk tanggal
                Label labelTanggal = new Label
                {
                    Text = tanggal.ToString("dd MMM yyyy"),
                    AutoSize = true,
                    Font = new Font("Arial", 8, FontStyle.Italic),
                    ForeColor = Color.Gray,
                    Location = new Point(10, ulasanPanel.Height - 30)
                };

                // Menambahkan kontrol ke dalam panel ulasan
                ulasanPanel.Controls.Add(labelNamaAkun);
                ulasanPanel.Controls.Add(ratingPanel);
                ulasanPanel.Controls.Add(labelIsiUlasan);
                ulasanPanel.Controls.Add(labelTanggal);


                int panelHeight = labelNamaAkun.Height +
                          ratingPanel.Height +
                          labelIsiUlasan.PreferredHeight +
                          labelTanggal.Height +
                          30; // Tambahkan padding internal
                ulasanPanel.Height = Math.Max(panelHeight, 100); // Berikan tinggi minimum untuk estetika

                labelTanggal.Location = new Point(10, ulasanPanel.Height - labelTanggal.Height - 1);

                DisplayRatingStars(ratingPanel, rating);

                int? idAkunPembuatUlasan = UlasanContext.getIDAkunSesuaiUlasan(UserSession.idSession);

                if (idAkunPembuatUlasan.HasValue)
                {
                    Console.WriteLine($"ID Akun: {idAkunPembuatUlasan.Value}");
                }
                else
                {
                    Console.WriteLine("ID Akun Tidak Ditemukan");
                }

                // Tombol untuk Update dan Delete (hanya jika ulasan berumur kurang dari 30 hari)
                if (idAkunPembuatUlasan == UserSession.idSession)
                {
                    if ((DateTime.Now - tanggal).TotalDays < 30)
                    {
                        Button BtnUpdate = new Button
                        {
                            Text = "Update",  // Text yang akan ditampilkan pada tombol
                            Width = 80,      // Lebar tombol
                            Height = 25,      // Tinggi tombol
                            Location = new Point(637, 5), // Lokasi tombol di dalam form/panel
                            BackColor = Color.White,  // Warna latar belakang tombol
                            FlatStyle = FlatStyle.Flat // Menentukan jenis tombol datar
                        };
                        ulasanPanel.Controls.Add(BtnUpdate);
                        BtnUpdate.Click += (sender, e) =>
                        {
                            FormTambahUlasan formTambahUlasan = new FormTambahUlasan();
                            formTambahUlasan.ShowDialog();
                            this.Hide();
                        };

                        Button BtnDelete = new Button
                        {
                            Text = "Delete",  // Text yang akan ditampilkan pada tombol
                            Width = 80,      // Lebar tombol
                            Height = 25,      // Tinggi tombol
                            Location = new Point(550, 5), // Lokasi tombol di dalam form/panel
                            BackColor = Color.White,  // Warna latar belakang tombol
                            FlatStyle = FlatStyle.Flat // Menentukan jenis tombol datar
                        };
                        ulasanPanel.Controls.Add(BtnDelete);
                        BtnDelete.Click += (sender, e) => UlasanContext.DeleteUlasan(Convert.ToInt32(row["id_ulasan"]));
                        panelUlasanContainer.Controls.Remove(ulasanPanel);
                        DisplayUlasan();
                    }
                }
                
                ulasanPanel.Location = new Point(10, totalHeight);
                panelUlasanContainer.Controls.Add(ulasanPanel);

                // Update tinggi total
                totalHeight += ulasanPanel.Height + panelSpacing;
            }
            panelUlasanContainer.Height = totalHeight;
        }
        private void DisplayRatingStars(Panel ratingPanel, int rating)
        {
            // Bersihkan panel rating terlebih dahulu
            ratingPanel.Controls.Clear();

            // Dapatkan posisi awal dan ukuran dari bintang1 sebagai template
            PictureBox templateStar = bintang1; // Asumsikan bintang1 adalah PictureBox template yang ada di form
            Point startPosition = new Point(0, 0);
            Size starSize = templateStar.Size;

            // Loop untuk menambahkan bintang sesuai jumlah rating
            for (int i = 0; i < rating; i++)
            {
                PictureBox starPictureBox = new PictureBox
                {
                    Image = templateStar.Image, // Gunakan gambar dari template
                    SizeMode = templateStar.SizeMode, // Gunakan pengaturan dari template
                    Size = starSize,
                    Location = new Point(startPosition.X + i * (starSize.Width + 5), startPosition.Y) // Jarak horizontal antar bintang
                };

                // Tambahkan bintang ke panel
                ratingPanel.Controls.Add(starPictureBox);
            }
        }


        private void FormUlasan_Load(object sender, EventArgs e)
        {
            DisplayUlasan();
        }

        private void btnKembali_Click(object sender, EventArgs e)
        {
            FormLayanan formLayanan = new FormLayanan();
            formLayanan.Show();
            this.Hide();
        }
    }
}
