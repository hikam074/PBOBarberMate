using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using Npgsql;

using PBOBarberMate.App.Context;
using PBOBarberMate.App.Core;
using System.ComponentModel.DataAnnotations;


namespace PBOBarberMate.App.Model
{
    // ENUM untuk role akun
    public enum AkunRole
    {
        Admin = 1,
        Karyawan = 2,
        Customer = 3
    }
    public class M_Akun
    {
        // ATRIBUT
        [Key] public int id_akun { get; set; }
        public string nama { get; set; }
        public string email { get; set; }
        private string _password;
        public string Password
        {
            get => _password;
            set => _password = this.hashPassword(value);
        }
        public virtual AkunRole role { get; }
        public string hashPassword(string password)
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