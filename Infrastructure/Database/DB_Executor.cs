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
        public static DataTable ExecuteQuery(string sql, NpgsqlParameter[] parameters = null)
        // Metode untuk eksekusi SELECT
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
    }
}