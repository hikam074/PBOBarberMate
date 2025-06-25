using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;


namespace PBOBarberMate.App.Model
{
    public class M_Karyawan : M_Akun
    {
        // ATRIBUT
        public override AkunRole role => AkunRole.karyawan;

        public M_Karyawan(int id_akun, string nama, string email) : base ()
        {
            this.id_akun = id_akun;
            this.nama = nama;
            this.email = email;
        }
        public M_Karyawan(M_Akun akun)
        {
            this.id_akun = akun.id_akun;
            this.nama = akun.nama;
            this.email = akun.email;
            this.role = akun.role;
        }
    }
}