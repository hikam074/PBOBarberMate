using System;

using Npgsql;

namespace CobaWinForm.Classes
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
        // method membuat akun baru ke db
        public bool buatAkun(Akun akun)
        {
            using (NpgsqlConnection connection = getConnectToDB())
            {
                //connection.Open();
                string insertQuery = "INSERT INTO akun (email, nama, password) VALUES (@email, @nama, @password)";
                using (NpgsqlCommand insertCommand = new NpgsqlCommand(insertQuery, connection))
                {
                    insertCommand.Parameters.AddWithValue("email", akun.email);
                    insertCommand.Parameters.AddWithValue("nama", akun.nama);
                    insertCommand.Parameters.AddWithValue("password", akun.getPassword());

                    // memasukkan data ke DB sekaligus mendapatkan return apakah berhasil atau tidak
                    int rowsAffected = insertCommand.ExecuteNonQuery();
                    // return true bila berhasil
                    return rowsAffected > 0;

                }
            }
        }
    }
}
