using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Security.Cryptography;


namespace CobaWinForm.Classes
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

        // method
        public void hashPassword()
        {
            this.password = HashingUtility.hashPassword(password);
        }
        public string getPassword()
        {
            return this.password;
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
