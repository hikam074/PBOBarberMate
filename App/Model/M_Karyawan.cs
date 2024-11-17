using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

using PBOBarberMate.App.Context;
using PBOBarberMate.App.Core;

namespace PBOBarberMate.App.Model
{
    public class M_Karyawan : M_Akun
    {
        // ATRIBUT
        public AkunRole role = AkunRole.Karyawan;


        // CONSTRUCTOR
        public M_Karyawan(string email, string password) : base(email, password)
        {
            // assign role otomatis
            this.role = AkunRole.Karyawan;
        }
    }
}
