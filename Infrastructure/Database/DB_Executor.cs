using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBOBarberMate.Infrastructure.Database
{
    public static class DB_Executor
    {
        public static int ExecuteNonQuery(string sql, NpgsqlParameter[] parameters = null)
        // Metode untuk eksekusi INSERT, UPDATE, DELETE (non-query), Mengembalikan jumlah baris yang terpengaruh
        {
            try
            {
                using (var conn = DB_ConnectionFactory.CreateConnection())
                {
                    using (var cmd = new NpgsqlCommand(sql, conn))
                    {
                        if (parameters != null) cmd.Parameters.AddRange(parameters);
                        conn.Open();
                        return cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (NpgsqlException e)
            {
                throw new Exception(HandleDatabaseError(e));
            }
        }
        public static DataTable ExecuteQuery(string sql, NpgsqlParameter[] parameters = null)
        // Metode untuk eksekusi SELECT
        {
            try
            {
                DataTable dt = new DataTable();
                using (var conn = DB_ConnectionFactory.CreateConnection())
                {
                    using (var cmd = new NpgsqlCommand(sql, conn))
                    {
                        if (parameters != null) cmd.Parameters.AddRange(parameters);
                        conn.Open();
                        using (var reader = cmd.ExecuteReader())
                        {
                            dt.Load(reader);
                        }
                    }
                }
                return dt;
            }
            catch (NpgsqlException e)
            {
                throw new Exception(HandleDatabaseError(e));
            }
        }
        private static string HandleDatabaseError(NpgsqlException e)
        // mereturn pesan dan status eror spesifik
        {
            switch (e.SqlState)
            {
                case "23505": // unique_violation
                    return "Data sudah terdaftar di sistem (Duplikat).";
                case "23503": // foreign_key_violation
                    return "Data tidak bisa dihapus atau diubah karena masih digunakan oleh data lain.";
                case "08001": // connection_failure
                    return "Gagal terhubung ke database. Periksa koneksi internet atau server.";
                default:
                    return $"Terjadi kesalahan database: {e.Message}";
            }
        }
    }
}