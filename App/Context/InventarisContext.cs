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
    public class InventarisContext : DBService
    {
        private static string table = "inventaris";

        public static DataTable All()
        {
            string query = $"SELECT * FROM {table}";
            try
            {
                // Panggil queryExecutor untuk mendapatkan NpgsqlDataReader
                using (NpgsqlDataReader reader = queryExecutor(query, null))
                {
                    DataTable dataInventaris = new DataTable();
                    dataInventaris.Load(reader); // Memuat data dari DataReader ke DataTable
                    return dataInventaris;
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error in InventarisContext.All(): {ex.Message}", ex);
            }
        }
        public static NpgsqlDataReader getInventarisByID(int id)
        {
            string query = $"SELECT * FROM {table} where id_barang = @id_barang";
            NpgsqlParameter[] parameters =
            {
                new NpgsqlParameter("@id_barang", id)
            };
            NpgsqlDataReader dataInventaris = queryExecutor(query, parameters);
            return dataInventaris;
        }
        public static void AddInventaris(M_Inventaris Inventarisbaru)
        {
            string query = $"INSERT INTO {table} (nama_barang, jumlah_barang) VALUES (@nama_barang, @jumlah_barang)";
            NpgsqlParameter[] parameters =
            {
                new NpgsqlParameter("@nama_barang", Inventarisbaru.nama_barang),
                new NpgsqlParameter("@jumlah_barang", Convert.ToInt32(Inventarisbaru.jumlah_barang)),
            };
            commandExecutor(query, parameters);
        }
        public static void UpdateInventaris(M_Inventaris inventaris)
        {
            string query = $"UPDATE {table} SET nama_barang = @nama_barang, jumlah_barang = @jumlah_barang WHERE id_barang = @id_barang";
            NpgsqlParameter[] parameters =
            {
                new NpgsqlParameter("@nama_barang", inventaris.nama_barang),
                new NpgsqlParameter("@jumlah_barang", inventaris.jumlah_barang),
                new NpgsqlParameter("@id_barang", inventaris.id_barang)
            };
            commandExecutor(query, parameters);
        }
        public static void DeleteInventaris(int id)
        {
            string query = $"DELETE FROM {table} WHERE id_barang = @id_barang";
            NpgsqlParameter[] parameters =
            {
                new NpgsqlParameter("@id_barang", id),
            };
            commandExecutor(query, parameters);
        }
    }
}
