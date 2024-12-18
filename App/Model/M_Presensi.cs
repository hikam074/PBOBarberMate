using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBOBarberMate.App.Model
{
    public class M_Presensi
    {
        public int id_presensi { get; set; }
        public string nama_akun { get; set; }
        public int id_akun { get; set; }
        public int id_shift { get; set; }
        public string hari {  get; set; }
        public DateTime waktu_presensi { get; set; }
    }
}
