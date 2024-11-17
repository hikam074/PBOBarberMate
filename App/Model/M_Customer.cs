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
    public class M_Customer : M_Akun
    {
        // ATRIBUT
        public AkunRole role = AkunRole.Customer;


        // CONSTRUCTOR
        public M_Customer(string email, string password) : base(email, password)
        {
            // assign role otomatis
            this.role = AkunRole.Customer;
        }
        public M_Customer(string email, string nama, string password) : base(email, nama, password)
        {
            // assign role otomatis
            this.role = AkunRole.Customer;
        }
    }
}
