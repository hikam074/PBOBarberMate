using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using Npgsql;

using System.ComponentModel.DataAnnotations;


namespace PBOBarberMate.App.Model
{
    // ENUM untuk role akun
    public enum AkunRole
    {
        admin = 1,
        karyawan = 2,
        customer = 3
    }
    public class M_Akun : Model
    {
        // ATRIBUT
        [Key] public int id_akun { get; set; }
        public string nama { get; set; }
        public string email { get; set; }
        private string _passwordHash;
        public string Password
        {
            get => _passwordHash;
            set => _passwordHash = hashPassword(value);
        }
        public virtual AkunRole role { get; set; }


        public M_Akun() { }
        public M_Akun(int id_akun, string nama, string email, string hashedPasswordFromDb, AkunRole role)
        {
            this.id_akun = id_akun;
            this.nama = nama;
            this.email = email;
            this._passwordHash = hashedPasswordFromDb;
            this.role = role;
        }
        public M_Akun(string nama, string email, string plainPassword, AkunRole role)
        {
            this.nama = nama;
            this.email = email;
            this.Password = plainPassword;
            this.role = role;
        }

        public static string hashPassword(string password)
        {
            using (SHA256 sha256Hash = SHA256.Create())
            {
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(password));
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