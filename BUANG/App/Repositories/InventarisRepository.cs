using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PBOBarberMate.BUANG.App.Infrastructure;
using PBOBarberMate.BUANG.Core.Entities;


namespace PBOBarberMate.BUANG.App.Repositories
{
    public class InventarisRepository
    {
        private readonly DB_Executor _dbExecutor;

        public InventarisRepository()
        {
            _dbExecutor = new DB_Executor(DB_ConnectionFactory.ConnectionString);
        }


        // METHOD repo SELECT untuk ambil semua data inventaris
        public List<M_Inventaris> getAllInventaris()
        {
            string query = "SELECT * FROM inventaris";
            try
            {
                List<object[]> rawData = _dbExecutor.ExecuteReaderAsRawList(query);
                // Map rawData (List<object[]>) ke List<M_Inventaris>
                return rawData.Select(row => new M_Inventaris(
                    Convert.ToInt32(row[0]),            // id
                    Convert.ToString(row[1]),           // nama_barang
                    Convert.ToInt32(row[2])             // jumlah_barang
                )).ToList();
            }
            catch (Exception ex)
            {
                throw new ApplicationException($"Error in GetAllInventaris: {ex.Message}", ex);
            }
        }

        // METHOD repo SELECT untuk ambil data inventaris dengan ID
        public M_Inventaris getInventarisById(int id)
        {
            string query = "SELECT * FROM inventaris WHERE id_barang = @id";
            NpgsqlParameter[] parameters = { new NpgsqlParameter("@id", id) };
            try
            {
                List<object[]> rawData = _dbExecutor.ExecuteReaderAsRawList(query, parameters);
                if (rawData.Any()) // Jika ada data yang ditemukan
                {
                    object[] row = rawData.First();
                    return new M_Inventaris(
                        Convert.ToInt32(row[0]),            // id
                        Convert.ToString(row[1]),           // nama_barang
                        Convert.ToInt32(row[2])             // jumlah_barang
                    );
                }
                return null;
            }
            catch (Exception ex)
            {
                throw new ApplicationException($"Error in GetInventarisById ({id}): {ex.Message}", ex);
            }
        }

        // METHOD repo INSERT untuk membuat barang
        public int createInventaris(M_Inventaris inventaris)
        {
            string query = "INSERT INTO inventaris (nama_barang, jumlah_barang) VALUES (@nama, @jumlah) RETURNING id_barang;";
            NpgsqlParameter[] parameters = {
                new NpgsqlParameter("@nama", inventaris.nama_barang),
                new NpgsqlParameter("@jumlah", inventaris.jumlah_barang)
            };

            try
            {
                return _dbExecutor.ExecuteScalar<int>(query, parameters);
            }
            catch (Exception ex)
            {
                throw new ApplicationException($"Error in createInventaris for {inventaris.nama_barang}: {ex.Message}", ex);
            }
        }

        // METHOD repo UPDATE untuk menyimpan perubahan layanan
        public bool updateInventaris(M_Inventaris inventaris)
        {
            string query = "UPDATE inventaris SET nama_barang = @nama, jumlah_barang = @jumlah WHERE id_barang = @id";
            NpgsqlParameter[] parameters = {
                new NpgsqlParameter("@id", inventaris.id_barang),
                new NpgsqlParameter("@nama", inventaris.nama_barang),
                new NpgsqlParameter("@jumlah", inventaris.jumlah_barang)
            };
            try
            {
                return _dbExecutor.ExecuteNonQuery(query, parameters) > 0;
            }
            catch (Exception ex)
            {
                throw new ApplicationException($"Error in UpdateInventaris for {inventaris.nama_barang}: {ex.Message}", ex);
            }
        }

        // METHOD repo DELETE untuk hapus layanan
        public bool deleteInventaris(int id)
        {
            string query = "DELETE FROM inventaris WHERE id_barang = @id";
            NpgsqlParameter[] parameters = {
                new NpgsqlParameter("@id", id)
            };
            try
            {
                return _dbExecutor.ExecuteNonQuery(query, parameters) > 0;
            }
            catch (Exception ex)
            {
                throw new ApplicationException($"Error in DeleteInventaris for ID {id}: {ex.Message}", ex);
            }
        }
    }
}
