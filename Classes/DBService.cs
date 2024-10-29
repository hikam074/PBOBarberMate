using System;
using PBOBarberMate.Classes;
using Npgsql;

namespace PBOBarberMate.Classes
{
    public class DBService
    {
        private string _connectionString;
        public DBService(string connectionString)
        {
            this._connectionString = connectionString;
        }

        // method melakukan koneksi dengan db
        public NpgsqlConnection getConnectToDB()
        { 
            NpgsqlConnection connection = new NpgsqlConnection(_connectionString);
            connection.Open();
            return connection;
        }

        // method mengecek email sudah ada atau belum di db
        public bool isEmailExist(string email)
        {
            using (NpgsqlConnection connection = getConnectToDB())
            {
                //connection.Open();
                string query = "SELECT COUNT(*) FROM akun WHERE email = @email";
                using (NpgsqlCommand command = new NpgsqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("email", email);
                    int userCount = Convert.ToInt32(command.ExecuteScalar());
                    // return true bila user ditemukan
                    return userCount > 0;
                }
            }
        }
    }
}
