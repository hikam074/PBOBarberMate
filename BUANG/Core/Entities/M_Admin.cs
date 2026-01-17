using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;


namespace PBOBarberMate.BUANG.Core.Entities
{
    public class M_Admin : M_Akun
    {
        // ATRIBUT
        public override AkunRole role => AkunRole.admin;
    }
}