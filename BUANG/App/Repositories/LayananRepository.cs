using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PBOBarberMate.BUANG.App.Infrastructure;
using PBOBarberMate.BUANG.App.Model;


namespace PBOBarberMate.BUANG.App.Repositories
{
    public class LayananRepository
    {
        private readonly DB_Executor _dbExecutor;

        public LayananRepository()
        {
            _dbExecutor = new DB_Executor(DB_ConnectionFactory.ConnectionString);
        }


        // METHOD repo SELECT untuk ambil semua data layanan
        public List<M_Layanan> getAllLayanan()
        {
            string query = "SELECT * FROM layanan";
            try
            {
                List<object[]> rawData = _dbExecutor.ExecuteReaderAsRawList(query);
                // Map rawData (List<object[]>) ke List<M_Akun>
                return rawData.Select(row => new M_Layanan(
                    Convert.ToInt32(row[0]),            // id_layanan
                    Convert.ToString(row[1]),           // nama_layanan
                    Convert.ToInt32(row[2])             // harga
                )).ToList();
            }
            catch (Exception ex)
            {
                throw new ApplicationException($"Error in GetAllLayanan: {ex.Message}", ex);
            }
        }

        // METHOD repo SELECT untuk ambil data layanan dengan ID
        public M_Layanan getLayananById(int id)
        {
            string query = "SELECT * FROM layanan WHERE id_layanan = @id";
            NpgsqlParameter[] parameters = { new NpgsqlParameter("@id", id) };
            try
            {
                List<object[]> rawData = _dbExecutor.ExecuteReaderAsRawList(query, parameters);
                if (rawData.Any()) // Jika ada data yang ditemukan
                {
                    object[] row = rawData.First();
                    return new M_Layanan(
                        Convert.ToInt32(row[0]),            // id_layanan
                        Convert.ToString(row[1]),           // nama_layanan
                        Convert.ToInt32(row[2])             // harga
                    );
                }
                return null;
            }
            catch (Exception ex)
            {
                throw new ApplicationException($"Error in GetLayananById ({id}): {ex.Message}", ex);
            }
        }

        // METHOD repo INSERT untuk membuat layanan
        public int createLayanan(M_Layanan layanan)
        {
            string query = "INSERT INTO layanan (nama_layanan, harga) VALUES (@nama, @harga) RETURNING id_layanan;";
            NpgsqlParameter[] parameters = {
                new NpgsqlParameter("@nama", layanan.nama_layanan),
                new NpgsqlParameter("@harga", layanan.harga)
            };

            try
            {
                return _dbExecutor.ExecuteScalar<int>(query, parameters);
            }
            catch (Exception ex)
            {
                throw new ApplicationException($"Error in createLayanan for {layanan.nama_layanan}: {ex.Message}", ex);
            }
        }

        // METHOD repo UPDATE untuk menyimpan perubahan layanan
        public bool updateLayanan(M_Layanan layanan)
        {
            string query = "UPDATE layanan SET nama_layanan = @nama, harga = @harga WHERE id_layanan = @id";
            NpgsqlParameter[] parameters = {
                new NpgsqlParameter("@id", layanan.id_layanan),
                new NpgsqlParameter("@nama", layanan.nama_layanan),
                new NpgsqlParameter("@harga", layanan.harga)
            };
            try
            {
                return _dbExecutor.ExecuteNonQuery(query, parameters) > 0;
            }
            catch (Exception ex)
            {
                throw new ApplicationException($"Error in UpdateLayanan for {layanan.nama_layanan}: {ex.Message}", ex);
            }
        }

        // METHOD repo DELETE untuk hapus layanan
        public bool deleteLayanan(int id)
        {
            string query = "DELETE FROM layanan WHERE id_layanan = @id";
            NpgsqlParameter[] parameters = {
                new NpgsqlParameter("@id", id)
            };
            try
            {
                return _dbExecutor.ExecuteNonQuery(query, parameters) > 0;
            }
            catch (Exception ex)
            {
                throw new ApplicationException($"Error in DeleteLayanan for ID {id}: {ex.Message}", ex);
            }
        }
    }
}
