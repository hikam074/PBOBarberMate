using Npgsql;
using PBOBarberMate.App.Core;
using PBOBarberMate.App.Model;
using System;
using System.Data;


namespace PBOBarberMate.App.Context
{
    public class ShiftContext : DBService
    {
        private static string table = "shift_karyawan";

        // Mengambil semua data shift_karyawan dengan join ke tabel akun dan detail_hari
        public static DataTable All()
        {
            string query = $@"
                SELECT sk.id_shift, sk.id_akun, a.nama_akun, sk.id_hari, dh.nama_hari
                FROM {table} sk
                JOIN akun a ON sk.id_akun = a.id_akun
                JOIN detail_hari dh ON sk.id_hari = dh.id_hari
                WHERE a.akun_role_id = 2";
            try
            {
                using (NpgsqlDataReader reader = queryExecutor(query, null))
                {
                    DataTable dataShift = new DataTable();
                    dataShift.Load(reader);
                    return dataShift;
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error in ShiftContext.All(): {ex.Message}", ex);
            }
        }

        // Mengambil semua data akun
        public static DataTable GetAkunList()
        {
            string query = "SELECT id_akun, nama_akun FROM akun WHERE akun_role_id = 2";  // Asumsi ada tabel akun dengan id_akun dan nama_akun
            try
            {
                using (NpgsqlDataReader reader = queryExecutor(query, null))
                {
                    DataTable dataAkun = new DataTable();
                    dataAkun.Load(reader);
                    return dataAkun;
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error in ShiftContext.GetAkunList(): {ex.Message}", ex);
            }
        }

        // Mengambil semua data hari
        public static DataTable GetHariList()
        {
            string query = "SELECT id_hari, nama_hari FROM detail_hari";  // Asumsi ada tabel detail_hari dengan id_hari dan nama_hari
            try
            {
                using (NpgsqlDataReader reader = queryExecutor(query, null))
                {
                    DataTable dataHari = new DataTable();
                    dataHari.Load(reader);
                    return dataHari;
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error in ShiftContext.GetHariList(): {ex.Message}", ex);
            }
        }


        // Mengambil data shift_karyawan berdasarkan ID dengan informasi akun dan hari
        public static DataTable GetShiftByID(int id)
        {
            string query = $@"
                SELECT sk.id_shift, sk.id_akun, a.nama_akun, sk.id_hari, dh.nama_hari
                FROM {table} sk
                JOIN akun a ON sk.id_akun = a.id_akun
                JOIN detail_hari dh ON sk.id_hari = dh.id_hari
                WHERE sk.id_shift = @id_shift";

            NpgsqlParameter[] parameters =
            {
                new NpgsqlParameter("@id_shift", id)
            };
            try
            {
                using (NpgsqlDataReader reader = queryExecutor(query, parameters))
                {
                    DataTable dataShift = new DataTable();
                    dataShift.Load(reader);
                    return dataShift;
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error in ShiftContext.GetShiftByID(): {ex.Message}", ex);
            }
        }

        public static string getShiftByIDToday(int id)
        {
            string query = "SELECT sk.* FROM shift_karyawan sk JOIN detail_hari dh ON (sk.id_hari = dh.id_hari) WHERE sk.id_akun = @id AND dh.hari_sql = EXTRACT(DOW FROM CURRENT_DATE)";

            NpgsqlParameter[] parameters =
            {
                new NpgsqlParameter("@id", id)
            };
            try
            {
                using (NpgsqlDataReader reader = queryExecutor(query, parameters))
                {
                    DataTable dataShift = new DataTable();
                    dataShift.Load(reader);
                    if (dataShift.Rows.Count == 0)
                    {
                        return "Tidak Ada";
                    }
                    else
                    {
                        return "Ada";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Terjadi Kesalahan [PBOBarberMate.App.Context.ShiftContext.getShiftByIDToday(): {ex}");
                return "[Error]";
            }
        }

        // Menambahkan data shift_karyawan baru
        public static void AddShift(M_Shift shiftBaru)
        {
            string query = $"INSERT INTO {table} (id_akun, id_hari) VALUES (@id_akun, @id_hari)";
            NpgsqlParameter[] parameters =
            {
                new NpgsqlParameter("@id_akun", shiftBaru.id_akun),
                new NpgsqlParameter("@id_hari", shiftBaru.id_hari)
            };
            commandExecutor(query, parameters);
        }

        // Memperbarui data shift_karyawan
        public static void UpdateShift(M_Shift shift)
        {
            string query = $"UPDATE {table} SET id_akun = @id_akun, id_hari = @id_hari WHERE id_shift = @id_shift";
            NpgsqlParameter[] parameters =
            {
                new NpgsqlParameter("@id_akun", shift.id_akun),
                new NpgsqlParameter("@id_hari", shift.id_hari),
                new NpgsqlParameter("@id_shift", shift.id_shift)
            };
            commandExecutor(query, parameters);
        }

        // Menghapus data shift_karyawan berdasarkan ID
        public static void DeleteShift(int id)
        {
            string query = $"DELETE FROM {table} WHERE id_shift = @id_shift";
            NpgsqlParameter[] parameters =
            {
                new NpgsqlParameter("@id_shift", id)
            };
            commandExecutor(query, parameters);
        }
    }
}