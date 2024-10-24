using System;

using Npgsql;

namespace CobaWinForm.Classes
{
    public class AkunService
    {
        // atribut
        private DBService _DBService;

        // constructor
        public AkunService(DBService dBService)
        {
            _DBService = dBService;
        }

        // method mendaftarkan akun
        public bool signupAkun(Akun akun)
        {
            if (_DBService.isEmailExist(akun.email))
            {
                throw new Exception("Email sudah terdaftar! Silahkan login");
            }
            else
            {
                return _DBService.buatAkun(akun);
            }
        }
        public bool loginAkun(Akun akun, out string nama)
        {
            // mengosongkan akun.nama untuk menghindari error nullReference
            nama = string.Empty;
            // query melihat akun ada atau tidak
            string query = "SELECT nama FROM akun WHERE email = @email AND password = @password";

            using (NpgsqlConnection connection = _DBService.getConnectToDB())
            {
                using (NpgsqlCommand command = new NpgsqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("email", akun.email);
                    command.Parameters.AddWithValue("password", akun.getPassword());
                    
                    using (NpgsqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            akun.nama = reader.GetString(0);

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
}
