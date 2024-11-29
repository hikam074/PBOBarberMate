using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using Npgsql;

using PBOBarberMate.App.Context;
using PBOBarberMate.App.Core;


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
        // AATRIBUT
        public string id;
        public string nama;
        public string email;
        private string password { get; set; }
        public AkunRole role;


        // overload CONSTRUCTOR untuk signup
        public M_Akun(string _email, string _nama, string password)
        {
            email = _email;
            nama = _nama;
            this.password = password;
            hashPassword();
        }
        // overload CONSTRUCTOR untuk login
        public M_Akun(string _email, string password)
        {
            email = _email;
            this.password = password;
            hashPassword();
        }
        public M_Akun(string email)
        {
            this.email = email;
        } 


        // METHOD enkripsi password menggunakan SHA-256
        public void hashPassword()
        {
            password = HashingUtility.hashPassword(password);
        }
        // METHOD get password (karena private modifier)
        public string getPassword()
        {
            return password;
        }
    }

    // CLASS TAMBAHAN : hashing
    public static class HashingUtility
    {
        public static string hashPassword(string password)
        {
            using (SHA256 sha256Hash = SHA256.Create())
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
