using System;
using Npgsql;

using PBOBarberMate;
using PBOBarberMate.App.Context;
using PBOBarberMate.App.Core;
using PBOBarberMate.App.Model;


namespace PBOBarberMate.App.Core
{
    public class DBService
    {
        // ATRIBUT kredensial db
        private static readonly string dbHost = "localhost";
        private static readonly string dbDatabase = "PBO_BarberMate";
        private static readonly string dbUsername = "postgres";
        private static readonly string dbPassword = "dammahom51";
        private static readonly string dbPort = "5432";
        // ATRIBUT Npgsql
        private static NpgsqlConnection connection;
        private static NpgsqlCommand command;


        // METHOD buka koneksi ke DB
        public static void openConnection()
        {
            connection = new NpgsqlConnection($"Host={dbHost};Port={dbPort};Username={dbUsername};Password={dbPassword};Database={dbDatabase}");
            connection.Open();
            command = new NpgsqlCommand();
            command.Connection = connection;
            command.Parameters.Clear();
        }
        // METHOD tutup koneksi dari DB
        public static void closeConnection()
        {
            // tutup koneksi jika koneksi belum tertutup
            if (connection != null && connection.State != System.Data.ConnectionState.Closed)
            {
                command.Parameters.Clear();
                connection.Close();
            }
        }
        // METHOD query INSERT UPDATE DELETE
        public static int commandExecutor(string query, NpgsqlParameter[] parameters = null)
        {
            try
            {
                openConnection();
                command.CommandText = query;
                if (parameters != null)
                {
                    command.Parameters.AddRange(parameters);
                }
                command.Prepare();
                // mengetahui apakah berhasil dilakukan
                int rowsAffected = command.ExecuteNonQuery();
                command.Parameters.Clear();
                return rowsAffected;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            // menutup connection secara otomatis 
            finally
            {
                closeConnection();
            }
        }
        // METHOD query SELECT
        public static NpgsqlDataReader queryExecutor(string query, NpgsqlParameter[] parameters = null)
        {
            try
            {
                openConnection();
                command.CommandText = query;
                if (parameters != null)
                {
                    command.Parameters.AddRange(parameters);
                }
                command.Prepare();
                NpgsqlDataReader reader = command.ExecuteReader();
                return reader;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            // WARNING : untuk SELECT koneksi harus ditutup secara manual pada kode yang menggunakannya, tidak disini
            // namun bila menggunakan using maka tidak perlu menutup koneksi karena using akan menutup koneksi secara otomatis
        }
    }
}
