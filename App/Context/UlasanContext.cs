using Npgsql;
using PBOBarberMate.App.Core;
using PBOBarberMate.App.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBOBarberMate.App.Context
{
    public class UlasanContext : DBService
    {
        private static string table = "ulasan";

        public static DataTable All(int id)
        {
            string query = $"SELECT u.id_ulasan, u.id_pembayaran, u.rating, u.isi_ulasan, u.tanggal_memberi_ulasan, a.nama_akun " +
                           $"FROM {table} u " +
                           "JOIN pembayaran p ON p.id_pembayaran = u.id_pembayaran " +
                           "JOIN reservasi r ON r.id_reservasi = p.id_reservasi " +
                           "JOIN layanan l on l.id_layanan = r.id_layanan " +
                           "JOIN akun a ON r.id_akun = a.id_akun " +
                           "WHERE l.id_layanan = @id_layanan";
            NpgsqlParameter[] parameters =
{
                new NpgsqlParameter("@id_layanan", id)
            };
            try
            {
                // Panggil queryExecutor untuk mendapatkan NpgsqlDataReader
                using (NpgsqlDataReader reader = queryExecutor(query, parameters)) // Pass 'parameters' here
                {
                    DataTable dataUlasan = new DataTable();
                    dataUlasan.Load(reader); // Memuat data dari DataReader ke DataTable
                    return dataUlasan;
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error in UlasanContext.All(): {ex.Message}", ex);
            }
            finally
            {
                closeConnection();
            }
        }

        public static void AddUlasan(M_Ulasan UlasanBaru)
        {
            string query = $"INSERT INTO {table} (id_pembayaran, rating, isi_ulasan, tanggal_memberi_ulasan) VALUES (@id_pembayaran, @rating, @isi_ulasan, @tanggal_memberi_ulasan";
            NpgsqlParameter[] parameters =
            {
                new NpgsqlParameter("@id_pembayaran", Convert.ToInt32(UlasanBaru.id_pembayaran)), // Tanda kurung ini diperbaiki
                new NpgsqlParameter("@rating", Convert.ToInt32(UlasanBaru.rating)),             // Menutup tanda kurung
                new NpgsqlParameter("@isi_ulasan", UlasanBaru.isi_ulasan),                       // Urutan juga disesuaikan
                new NpgsqlParameter("@tanggal_memberi_ulasan", DateTime.Now)
            };
            commandExecutor(query, parameters);
        }
        public static void UpdateUlasan(M_Ulasan Ulasan)
        {
            string query = $"UPDATE {table} SET rating = @rating, isi_ulasan = @isi_ulasan WHERE id_ulasan = @id_ulasan";
            NpgsqlParameter[] parameters =
            {
                new NpgsqlParameter("@rating", Ulasan.rating),
                new NpgsqlParameter("@isi_ulasan", Ulasan.isi_ulasan),
                new NpgsqlParameter("@id_ulasan", Ulasan.id_ulasan)
            };
            commandExecutor(query, parameters);
        }
        public static void DeleteUlasan(int id)
        {
            string query = $"DELETE FROM {table} WHERE id_ulasan = @id_ulasan";
            NpgsqlParameter[] parameters =
            {
                new NpgsqlParameter("@id_ulasan", id),
            };
            commandExecutor(query, parameters);
        }
        public static int? getIDAkunSesuaiUlasan(int id_akun)
        {
            string query = "SELECT a.id_akun " +
                           "FROM akun a " +
                           "JOIN reservasi r ON r.id_akun = a.id_akun " +
                           "JOIN pembayaran p ON p.id_reservasi = r.id_reservasi " +
                           "JOIN ulasan u ON u.id_pembayaran = p.id_pembayaran " +
                           "WHERE r.id_akun = @id_akun";

            NpgsqlParameter[] parameters =
            {
                new NpgsqlParameter("@id_akun", id_akun)  // Menggunakan id_pembayaran
            };

            // Menjalankan query dan membaca hasilnya
            using (NpgsqlDataReader reader = queryExecutor(query, parameters))
            {
                if (reader.Read())  // Mengecek jika ada data yang dikembalikan
                {
                    return Convert.ToInt32(reader["id_akun"]);  // Mengembalikan nama akun
                }
                else
                {
                    return null;  // Jika tidak ditemukan
                }
            }
        }
        //public static DataTable getUlasanByLayananid(int id)
        //{
        //    string query = $"SELECT u.id_ulasan, u.id_pembayaran, u.rating, u.isi_ulasan, u.tanggal_memberi_ulasan, a.nama_akun " +
        //                   $"FROM {table} u " +
        //                   "JOIN pembayaran p ON p.id_pembayaran = u.id_pembayaran " +
        //                   "JOIN reservasi r ON r.id_reservasi = p.id_reservasi " +
        //                   "JOIN layanan l on l.id_layanan = r.id_layanan " +
        //                   "JOIN akun a ON r.id_akun = a.id_akun " +
        //                   "WHERE l.id_layanan = @id_layanan";

        //    NpgsqlParameter[] parameters =
        //    {
        //        new NpgsqlParameter("@id_layanan", id)
        //    };

        //    DataTable dataUlasan = new DataTable();

        //    try
        //    {
        //        // Use queryExecutor to execute the SELECT query and load the data into the DataTable
        //        using (var reader = DBService.queryExecutor(query, parameters))
        //        {
        //            dataUlasan.Load(reader); // Load data from the DataReader into the DataTable
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show($"Error method getUlasanByLayananid: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }

        //    return dataUlasan;
        //}
    }
}
