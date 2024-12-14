using Npgsql;
using PBOBarberMate.App.Core;
using PBOBarberMate.App.Model;
using System;
using System.Data;

namespace PBOBarberMate.App.Context
{
    public class UlasanContext : DBService
    {
        private static string table = "ulasan";

        // Fetch all reviews for a given service (id_layanan)
        public static DataTable All(int id)
        {
            string query = $"SELECT u.id_ulasan, u.id_pembayaran, u.rating, u.isi_ulasan, u.tanggal_memberi_ulasan, a.nama_akun, a.id_akun " +
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
                using (NpgsqlDataReader reader = queryExecutor(query, parameters))
                {
                    DataTable dataUlasan = new DataTable();
                    dataUlasan.Load(reader); // Load data from DataReader into DataTable
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

        // Add a new review
        public static void AddUlasan(M_Ulasan UlasanBaru)
        {
            string query = $"INSERT INTO {table} (id_pembayaran, rating, isi_ulasan, tanggal_memberi_ulasan) VALUES (@id_pembayaran, @rating, @isi_ulasan, @tanggal_memberi_ulasan)";
            NpgsqlParameter[] parameters =
            {
                new NpgsqlParameter("@id_pembayaran", Convert.ToInt32(UlasanBaru.id_pembayaran)),
                new NpgsqlParameter("@rating", Convert.ToInt32(UlasanBaru.rating)),
                new NpgsqlParameter("@isi_ulasan", UlasanBaru.isi_ulasan),
                new NpgsqlParameter("@tanggal_memberi_ulasan", DateTime.Now)
            };

            commandExecutor(query, parameters);
        }

        // Update an existing review
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

        // Delete a review
        public static void DeleteUlasan(int id)
        {
            string query = $"DELETE FROM {table} WHERE id_ulasan = @id_ulasan";
            NpgsqlParameter[] parameters =
            {
                new NpgsqlParameter("@id_ulasan", id)
            };

            commandExecutor(query, parameters);
        }
        public static M_Ulasan getUlasanByID(int id)
        {
            string query = $"SELECT * FROM {table} where id_ulasan = @id_ulasan";
            NpgsqlParameter[] parameters =
            {
                new NpgsqlParameter("@id_ulasan", id)
            };

            try
            {
                using (NpgsqlDataReader reader = queryExecutor(query, parameters))
                {
                    if (reader != null && reader.HasRows)
                    {
                        reader.Read();
                        M_Ulasan ulasan = new M_Ulasan
                        {
                            id_ulasan = Convert.ToInt32(reader["id_ulasan"]),
                            id_pembayaran = Convert.ToInt32(reader["id_pembayaran"]),
                            rating = Convert.ToInt32(reader["rating"]),
                            isi_ulasan = reader["isi_ulasan"].ToString(),
                            tanggal_memberi_ulasan = Convert.ToDateTime(reader["tanggal_memberi_ulasan"])
                        };
                        return ulasan;
                    }
                    return null; // Kembalikan null jika data tidak ditemukan
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
                return null;
            }
        }
    }
}
