using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

using PBOBarberMate.App.Infrastructure;
using PBOBarberMate.App.Model;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;


namespace PBOBarberMate.App.Repository
{
    public class AkunRepository
    {
        private readonly DB_Executor _dbExecutor;
        
        public AkunRepository()
        {
            _dbExecutor = new DB_Executor(DB_ConnectionFactory.ConnectionString);
        }


        // METHOD repo SELECT untuk ambil semua data akun
        public List<M_Akun> getAllAkun() {
            string query = "SELECT id_akun, nama_akun, email, password, akun_role_id FROM akun";
            try
            {
                List<object[]> rawData = _dbExecutor.ExecuteReaderAsRawList(query);
                // Map rawData (List<object[]>) ke List<M_Akun>
                return rawData.Select(row => new M_Akun(
                    Convert.ToInt32(row[0]),            // id_akun
                    Convert.ToString(row[1]),           // nama_akun
                    Convert.ToString(row[2]),           // email
                    Convert.ToString(row[3]),           // password (sudah hash)
                    (AkunRole)Convert.ToInt32(row[4])   // akun_role_id
                )).ToList();
            }
            catch (Exception ex)
            {
                throw new ApplicationException($"Error in GetAllAkun: {ex.Message}", ex);
            }
        }
        // METHOD repo SELECT untuk ambil semua data akun
        public List<M_Karyawan> getAllKaryawan()
        {
            string query = "SELECT id_akun, nama_akun, email FROM akun WHERE akun_role_id = @id";
            NpgsqlParameter[] parameters = { new NpgsqlParameter("@id", (int)AkunRole.karyawan) };
            try
            {
                List<object[]> rawData = _dbExecutor.ExecuteReaderAsRawList(query, parameters);
                return rawData.Select(row => new M_Karyawan(
                    Convert.ToInt32(row[0]),            // id
                    Convert.ToString(row[1]),           // nama
                    Convert.ToString(row[2])            // email
                )).ToList();
                return null;
            }
            catch (Exception ex)
            {
                throw new ApplicationException($"Error in GetAllKaryawan: {ex.Message}", ex);
            }
        }

        // METHOD repo SELECT untuk ambil data akun dengan EMAIL
        public M_Akun getAkunByEmail(string email)
        {
            string query = "SELECT id_akun, nama_akun, email, password, akun_role_id FROM akun WHERE email = @email";
            NpgsqlParameter[] parameters = { new NpgsqlParameter("@email", email) };
            try
            {
                List<object[]> rawData = _dbExecutor.ExecuteReaderAsRawList(query, parameters);
                if (rawData.Any())
                {
                    object[] row = rawData.First();
                    return new M_Akun(
                        Convert.ToInt32(row[0]),
                        Convert.ToString(row[1]),
                        Convert.ToString(row[2]),
                        Convert.ToString(row[3]),
                        (AkunRole)Convert.ToInt32(row[4])
                    );
                }
                return null;
            }
            catch (Exception ex)
            {
                throw new ApplicationException($"Error in GetAkunByEmail ({email}): {ex.Message}", ex);
            }
        }

        // METHOD repo SELECT untuk ambil data akun dengan ID
        public M_Akun getAkunById(int id) {
            string query = "SELECT id_akun, nama_akun, email, password, akun_role_id FROM akun WHERE id_akun = @id";
            NpgsqlParameter[] parameters = { new NpgsqlParameter("@id", id) };
            try
            {
                List<object[]> rawData = _dbExecutor.ExecuteReaderAsRawList(query, parameters);
                if (rawData.Any()) // Jika ada data yang ditemukan
                {
                    object[] row = rawData.First();
                    return new M_Akun(
                        Convert.ToInt32(row[0]),            // id_akun
                        Convert.ToString(row[1]),           // nama_akun
                        Convert.ToString(row[2]),           // email
                        Convert.ToString(row[3]),           // password (sudah hash)
                        (AkunRole)Convert.ToInt32(row[4])   // akun_role_id
                    );
                }
                return null;
            }
            catch (Exception ex)
            {
                throw new ApplicationException($"Error in GetAkunById ({id}): {ex.Message}", ex);
            }
        }

        // METHOD repo INSERT untuk membuat akun
        public int createAkun(M_Akun akun) {
            string query = "INSERT INTO akun (nama_akun, email, password, akun_role_id) VALUES (@nama, @email, @password, @role_id) RETURNING id_akun;";
            NpgsqlParameter[] parameters = {
                new NpgsqlParameter("@nama", akun.nama),
                new NpgsqlParameter("@email", akun.email),
                new NpgsqlParameter("@password", akun.Password),
                new NpgsqlParameter("@role_id", (int)akun.role)
            };

            try
            {
                return _dbExecutor.ExecuteScalar<int>(query, parameters);
            }
            catch (Exception ex)
            {
                throw new ApplicationException($"Error in AddAkun for {akun.email}: {ex.Message}", ex);
            }
        }

        // METHOD repo UPDATE untuk menyimpan perubahan akun
        public bool UpdateAkun(M_Akun akun, int id) {
            string query;
            if (akun.Password == null)
            {
                query = "UPDATE akun SET nama_akun = @nama, email = @email, akun_role_id = @role_id WHERE id_akun = @id_akun";
            }
            else
            {
                query = "UPDATE akun SET nama_akun = @nama, email = @email, password = @password, akun_role_id = @role_id WHERE id_akun = @id_akun";
            }
            NpgsqlParameter[] parameters = {
                new NpgsqlParameter("@nama", akun.nama),
                new NpgsqlParameter("@email", akun.email),
                new NpgsqlParameter("@password", akun.Password),
                new NpgsqlParameter("@role_id", (int)akun.role),
                new NpgsqlParameter("@id_akun", id)
            };
            try
            {
                return _dbExecutor.ExecuteNonQuery(query, parameters) > 0;
            }
            catch (Exception ex)
            {
                throw new ApplicationException($"Error in UpdateAkun for {akun.email}: {ex.Message}", ex);
            }
        }

        // METHOD repo DELETE untuk hapus akun
        public bool DeleteAkun(int id)
        {
            string query = "DELETE FROM akun WHERE id_akun = @id";
            NpgsqlParameter[] parameters = {
                new NpgsqlParameter("@id", id)
            };
            try
            {
                return _dbExecutor.ExecuteNonQuery(query, parameters) > 0;
            }
            catch (Exception ex)
            {
                throw new ApplicationException($"Error in DeleteAkun for ID {id}: {ex.Message}", ex);
            }
        }
    }
}
