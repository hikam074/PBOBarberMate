using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Security.Cryptography;
using Npgsql;
using PBOBarberMate.Classes;


namespace PBOBarberMate.Classes
{
    public class Akun
    {
        // atribut
        public string email {  get; set; }
        public string nama { get; set; }
        private string password {  get; set; }

        // overload constructor untuk signup
        public Akun(string _email, string _nama, string password)
        {
            this.email = _email;
            this.nama = _nama;
            this.password = password;
            hashPassword();
        }
        // overload constructor untuk login
        public Akun(string _email, string password)
        {
            this.email = _email;
            this.password = password;
            hashPassword();
        }

        // method enkripsi
        public void hashPassword()
        {
            this.password = HashingUtility.hashPassword(password);
        }
        // method get password
        public string getPassword()
        {
            return this.password;
        }
        // method mendaftarkan akun
        public bool signupAkun(DBService dBService)
        {
            if (dBService.isEmailExist(this.email))
            {
                throw new Exception("Email sudah terdaftar! Silahkan login");
            }
            else
            {
                // buat akun
                using (NpgsqlConnection connection = dBService.getConnectToDB())
                {
                    //connection.Open();
                    string insertQuery = "INSERT INTO akun (email, nama, password) VALUES (@email, @nama, @password)";
                    using (NpgsqlCommand insertCommand = new NpgsqlCommand(insertQuery, connection))
                    {
                        insertCommand.Parameters.AddWithValue("email", this.email);
                        insertCommand.Parameters.AddWithValue("nama", this.nama);
                        insertCommand.Parameters.AddWithValue("password", this.getPassword());

                        // memasukkan data ke DB sekaligus mendapatkan return apakah berhasil atau tidak
                        int rowsAffected = insertCommand.ExecuteNonQuery();
                        // return true bila berhasil
                        return rowsAffected > 0;

                    }
                }
            }
        }
        // method masuk ke akun
        public bool loginAkun(DBService dBService)
        {
            // mengosongkan akun.nama untuk menghindari error nullReference
            nama = string.Empty;
            // query melihat akun ada atau tidak
            string query = "SELECT nama FROM akun WHERE email = @email AND password = @password";

            using (NpgsqlConnection connection = dBService.getConnectToDB())
            {
                using (NpgsqlCommand command = new NpgsqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("email", this.email);
                    command.Parameters.AddWithValue("password", this.getPassword());

                    using (NpgsqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            this.nama = reader.GetString(0);
                            nama = this.nama;
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                }
            }
        }
    }

    // class tambahan : hashing
    public static class HashingUtility
    {
        public static string hashPassword(string password)
        {
            using(SHA256 sha256Hash = SHA256.Create())
            {
                // mengubah password menjadi byte array
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(password));
                // menubah byte array menjadi string heksadesimal
                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    sb.Append(bytes[i].ToString("x2"));
                }
                return sb.ToString();
            }
        }
    }
}
