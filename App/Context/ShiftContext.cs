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
                SELECT sk.id_shift, a.nama_akun, dh.nama_hari
                FROM {table} sk
                JOIN akun a ON sk.id_akun = a.id_akun
                JOIN detail_hari dh ON sk.id_hari = dh.id_hari";
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

        // Mengambil data shift_karyawan berdasarkan ID dengan informasi akun dan hari
        public static DataTable GetShiftByID(int id)
        {
            string query = $@"
                SELECT sk.id_shift, a.nama_akun, dh.nama_hari
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