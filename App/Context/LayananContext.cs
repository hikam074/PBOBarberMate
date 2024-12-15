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
    public class LayananContext : DBService
    {
        private static string table = "layanan";

        public static DataTable All()
        {
            string query = $"SELECT * FROM {table}";
            try
            {
                // Panggil queryExecutor untuk mendapatkan NpgsqlDataReader
                using (NpgsqlDataReader reader = queryExecutor(query, null))
                {
                    DataTable dataLayanan = new DataTable();
                    dataLayanan.Load(reader); // Memuat data dari DataReader ke DataTable
                    return dataLayanan;
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error in LayananContext.All(): {ex.Message}", ex);
            }
            finally
            {
                closeConnection();
            }
        }
        public static NpgsqlDataReader getLayananByID(int id)
        {
            string query = $"SELECT * FROM {table} where id_layanan = @id_layanan";
            NpgsqlParameter[] parameters =
            {
                new NpgsqlParameter("@id_layanan", id)
            };
            NpgsqlDataReader dataLayanan = queryExecutor(query, parameters);
            return dataLayanan;
        }
        public static void AddLayanan(M_Layanan LayananBaru)
        {
            string query = $"INSERT INTO {table} (nama_layanan, harga) VALUES (@nama_layanan, @harga)";
            NpgsqlParameter[] parameters =
            {
                new NpgsqlParameter("@nama_layanan", LayananBaru.nama_layanan),
                new NpgsqlParameter("@harga", Convert.ToInt32(LayananBaru.harga)),
            };
            commandExecutor(query, parameters);
        }
        public static void UpdateLayanan(M_Layanan Layanan)
        {
            string query = $"UPDATE {table} SET nama_layanan = @nama_layanan, harga = @harga WHERE id_layanan = @id_layanan";
            NpgsqlParameter[] parameters =
            {
                new NpgsqlParameter("@nama_layanan", Layanan.nama_layanan),
                new NpgsqlParameter("@harga", Layanan.harga),
                new NpgsqlParameter("@id_layanan", Layanan.id_layanan)
            };
            commandExecutor(query, parameters);
        }

        public static void DeleteLayanan(int id)
        {
            string query = $"DELETE FROM {table} WHERE id_layanan = @id_layanan";
            NpgsqlParameter[] parameters =
            {
                new NpgsqlParameter("@id_layanan", id),
            };
            commandExecutor(query, parameters);
        }
    }
}
