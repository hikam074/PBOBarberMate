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
    public class M_Admin : M_Akun
    {
        // ATRIBUT
        public override AkunRole role => AkunRole.admin;
    }
}