using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;


namespace PBOBarberMate.App.Model
{
    public class M_Customer : M_Akun
    {
        // ATRIBUT
        public override AkunRole role => AkunRole.customer;
    }
}