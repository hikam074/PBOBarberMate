using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PBOBarberMate.App.Core;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using Npgsql;

using PBOBarberMate.App.Context;
using PBOBarberMate.App.Model;


namespace PBOBarberMate.App.Core
{
    public class CekAkun
    {
        // METHOD mengecek apakah akun yang dicari ditemukan di DB
        public static string cekAkunAda(M_Akun akun)
        {
            string query = "SELECT nama_akun FROM akun WHERE email = @email";
            var parameters = new NpgsqlParameter[]
            {
                new NpgsqlParameter("@email", akun.email),
            };
            // mengeksekusi query
            using (var reader = DBService.queryExecutor(query, parameters))
            {
                // ketika data akun yang disubmit berhasil ditemukan
                if (reader.HasRows)
                {
                    reader.Read();
                    // mengambil .nama akun dari hasil SELECT
                    string nama_akun = reader.GetString(0);
                    return nama_akun;
                }
                else
                {
                    return null;
                }
            }
        }
        // METHOD mengecek aoakah login bisa dilakukan
        public static bool cekLogin(M_Akun akun)
        {
            string query = "SELECT nama_akun FROM akun WHERE email = @email AND password = @password";
            var parameters = new NpgsqlParameter[]
            {
                new NpgsqlParameter("@email", akun.email),
                new NpgsqlParameter("@password", akun.getPassword())
            };
            // eksekusi query
            using (var reader = DBService.queryExecutor(query, parameters))
            {
                // ketika data yang disubmit ditemukan di DB
                if (reader.HasRows)
                {
                    return true;
                }
                // ketika data yang disubmit tidak ditemukan di DB
                else
                {
                    return false;
                }
            }
        }
        // METHOD mengecek role dari suatu akun
        public static int cekRole(M_Akun akun)
        {
            string query = "SELECT ar.id_role FROM akun_role ar JOIN akun a ON (a.akun_role_id = ar.id_role) WHERE a.email = @email AND a.password = @password";
            var parameters = new NpgsqlParameter[]
            {
                new NpgsqlParameter("@email", akun.email),
                new NpgsqlParameter("@password", akun.getPassword())
            };
            // megeksesusi query
            using (var reader = DBService.queryExecutor(query, parameters))
            {
                // ketika role ditemukan
                if (reader.HasRows)
                {
                    reader.Read();
                    // mendapatkan informasi role
                    int idRole = reader.GetInt32(0);
                    return idRole;
                }
                else
                {
                    return -1;
                }
            }
        }
        public static int cekId(string akun)
        {
            string query = "SELECT id_akun FROM akun WHERE email = @email";
            var parameters = new NpgsqlParameter[]
            {
                new NpgsqlParameter("@email", akun)
            };
            // megeksesusi query
            using (var reader = DBService.queryExecutor(query, parameters))
            {
                // ketika id ditemukan
                if (reader.HasRows)
                {
                    reader.Read();
                    // mendapatkan informasi role
                    int id = reader.GetInt32(0);
                    return id;
                }
                else
                {
                    return -1;
                }
            }
        }
    }
}
