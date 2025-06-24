using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBOBarberMate.App.Infrastructure
{
    internal class DB_Executor
    {
        private readonly string _connectionString;

        // Konstruktor: Menerima connection string
        public DB_Executor(string connectionString)
        {
            _connectionString = connectionString;
        }

        // Metode untuk eksekusi INSERT, UPDATE, DELETE (non-query)
        // Mengembalikan jumlah baris yang terpengaruh
        public int ExecuteNonQuery(string query, NpgsqlParameter[] parameters = null)
        {
            try
            {
                using (NpgsqlConnection conn = new NpgsqlConnection(_connectionString))
                {
                    conn.Open();
                    using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                    {
                        if (parameters != null)
                        {
                            cmd.Parameters.AddRange(parameters);
                        }
                        return cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException($"Database NonQuery failed for query: {query}. Error: {ex.Message}", ex);
            }
        }

        // Metode untuk eksekusi SELECT yang mengembalikan satu nilai (misalnya ID yang baru dibuat, COUNT(*))
        public T ExecuteScalar<T>(string query, NpgsqlParameter[] parameters = null)
        {
            try
            {
                using (NpgsqlConnection conn = new NpgsqlConnection(_connectionString))
                {
                    conn.Open();
                    using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                    {
                        if (parameters != null)
                        {
                            cmd.Parameters.AddRange(parameters);
                        }
                        object result = cmd.ExecuteScalar();
                        if (result == null || result == DBNull.Value)
                        {
                            return default(T); // Mengembalikan nilai default untuk tipe T jika null
                        }
                        return (T)Convert.ChangeType(result, typeof(T)); // Konversi tipe data
                    }
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException($"Database Scalar query failed for query: {query}. Error: {ex.Message}", ex);
            }
        }

        // Metode untuk eksekusi SELECT yang mengembalikan banyak baris sebagai List<object[]>
        // Ini adalah cara yang efisien di lapisan ini, karena semua data dibaca dan koneksi ditutup.
        // Repository akan memetakan object[] ini ke objek Model.
        public List<object[]> ExecuteReaderAsRawList(string query, NpgsqlParameter[] parameters = null)
        {
            List<object[]> rows = new List<object[]>();
            try
            {
                using (NpgsqlConnection conn = new NpgsqlConnection(_connectionString))
                {
                    conn.Open();
                    using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                    {
                        if (parameters != null)
                        {
                            cmd.Parameters.AddRange(parameters);
                        }
                        using (NpgsqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                object[] rowValues = new object[reader.FieldCount];
                                reader.GetValues(rowValues); // Membaca semua nilai kolom untuk baris saat ini
                                rows.Add(rowValues);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException($"Database Reader query failed for query: {query}. Error: {ex.Message}", ex);
            }
            return rows;
        }
    }
}