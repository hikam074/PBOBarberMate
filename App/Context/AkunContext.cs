using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

using PBOBarberMate.App.Core;
using PBOBarberMate.App.Model;


namespace PBOBarberMate.App.Context
{
    public class AkunContext : DBService
    {
        // METHOD untuk login
        public static void login(M_Akun akun)
        {
            string query = "SELECT nama_akun FROM akun WHERE email = @email AND password = @password";
            var parameters = new NpgsqlParameter[]
            {
                new NpgsqlParameter("@email", akun.email),
                new NpgsqlParameter("@password", akun.getPassword())
            };
            // mengeksekusi query
            using (var reader = DBService.queryExecutor(query, parameters))
            {
                // ketika data akun yang disubmit berhasil ditemukan
                if (reader.HasRows)
                {
                    reader.Read();
                    // mengambil .nama akun dari hasil SELECT
                    akun.nama = reader.GetString(0);
                    // menyimpan data login ke session
                    UserSession.email = akun.email;
                    UserSession.nama = akun.nama;
                    UserSession.idSession = CekAkun.cekId(akun.email);
                    UserSession.role = (AkunRole)CekAkun.cekRole(akun);
                }
                else
                {
                    MessageBox.Show("Ada Kesalahan! [PBOBarberMate.App.Context.AkunContext.login]");
                }
            }
        }
        // METHOD untuk signup
        public static bool signup(M_Akun akun)
        {
            // ketika akun sudah ada
            if (CekAkun.cekAkunAda(akun) != null)
            {
                // maka signup gagal/false
                return false;
            }
            // ketika akun belum ada
            else
            {
                // buat akun
                string insertQuery = "INSERT INTO akun (email, nama_akun, password, akun_role_id) VALUES (@email, @nama, @password, @id_role)";
                var parameters = new NpgsqlParameter[]
                {
                    new NpgsqlParameter("email", akun.email),
                    new NpgsqlParameter("nama", akun.nama),
                    new NpgsqlParameter("password", akun.getPassword()),
                    new NpgsqlParameter("id_role", (int)AkunRole.Customer)
                };
                try
                {
                    // memasukkan data ke DB sekaligus mendapatkan return apakah berhasil atau tidak
                    int rowsAffected = DBService.commandExecutor(insertQuery, parameters);
                    // return true bila berhasil
                    return rowsAffected > 0;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Terjadi kesalahan [PBOBarberMate.App.Context.AkunContext.signup] : {ex}");
                    return false;
                }
                
            }
        }
        public static void logout()
        {
            // menghapus semua data logged
            UserSession.email = null;
            UserSession.nama = null;
            UserSession.role = null;
        }

        public static bool ubahProfil(M_Akun akun, string data_baru, string ubahyangmana)
        { 
            if (ubahyangmana == "ubahNama")
            {
                string updateQuery = "UPDATE akun SET nama_akun=@nama_baru WHERE email=@email";
                var parameters = new NpgsqlParameter[]
                {
                    new NpgsqlParameter("nama_baru", data_baru),
                    new NpgsqlParameter("email", akun.email),
                };
                try
                {
                    // memasukkan data ke DB sekaligus mendapatkan return apakah berhasil atau tidak
                    int rowsAffected = DBService.commandExecutor(updateQuery, parameters);

                    UserSession.nama = data_baru;
                    // return true bila berhasil
                    return rowsAffected > 0;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Terjadi kesalahan [PBOBarberMate.App.Context.AkunContext.ubahProfil] : {ex}");
                    return false;
                }
            }
            else if (ubahyangmana == "ubahEmail")
            {
                string updateQuery = "UPDATE akun SET email=@email_baru WHERE email=@email";
                var parameters = new NpgsqlParameter[]
                {
                    new NpgsqlParameter("email_baru", data_baru),
                    new NpgsqlParameter("email", akun.email),
                };
                try
                {
                    // memasukkan data ke DB sekaligus mendapatkan return apakah berhasil atau tidak
                    int rowsAffected = DBService.commandExecutor(updateQuery, parameters);

                    UserSession.email = data_baru;
                    // return true bila berhasil
                    return rowsAffected > 0;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Terjadi kesalahan [PBOBarberMate.App.Context.AkunContext.ubahProfil] : {ex}");
                    return false;
                }
            }
            else
            {
                string updateQuery = "UPDATE akun SET password=@password_baru WHERE email=@email";
                var parameters = new NpgsqlParameter[]
                {
                    new NpgsqlParameter("password_baru", data_baru),
                    new NpgsqlParameter("email", akun.email),
                };
                try
                {
                    // memasukkan data ke DB sekaligus mendapatkan return apakah berhasil atau tidak
                    int rowsAffected = DBService.commandExecutor(updateQuery, parameters);
                    // return true bila berhasil
                    return rowsAffected > 0;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Terjadi kesalahan [PBOBarberMate.App.Context.AkunContext.ubahProfil] : {ex}");
                    return false;
                }
            }
        }
    }
}
