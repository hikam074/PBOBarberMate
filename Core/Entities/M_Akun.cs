using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBOBarberMate.Core.Entities
{
    public class M_Akun
    {
        public int IdAkun { get; set; }
        public string Nama { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string Password {  get; set; }
        public int IdRole { get; set; } // FK ID ROLE
        public string NamaRole { get; set; } // Navigation Property: Menampung detail role hasil JOIN
    }
}
