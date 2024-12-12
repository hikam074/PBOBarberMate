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

        public static DataTable All()
        {
            string query = $"SELECT * FROM {table}";
            try
            {
                // Panggil queryExecutor untuk mendapatkan NpgsqlDataReader
                using (NpgsqlDataReader reader = queryExecutor(query, null))
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
        }
        public static NpgsqlDataReader getUlasanByID(int id)
        {
            string query = $"SELECT * FROM {table} where id_ulasan = @id_ulasan";
            NpgsqlParameter[] parameters =
            {
                new NpgsqlParameter("@id_ulasan", id)
            };
            NpgsqlDataReader dataUlasan = queryExecutor(query, parameters);
            return dataUlasan;
        }
        public static void AddUlasan(M_Ulasan UlasanBaru)
        {
            string query = $"INSERT INTO {table} (id_pembayaran, rating, isi_ulasan) VALUES (@id_pembayaran, @rating, @isi_ulasan)";
            NpgsqlParameter[] parameters =
            {
                new NpgsqlParameter("@id_pembayaran", Convert.ToInt32(UlasanBaru.id_pembayaran)), // Tanda kurung ini diperbaiki
                new NpgsqlParameter("@rating", Convert.ToInt32(UlasanBaru.rating)),             // Menutup tanda kurung
                new NpgsqlParameter("@isi_ulasan", UlasanBaru.isi_ulasan)                       // Urutan juga disesuaikan

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
    }
}
