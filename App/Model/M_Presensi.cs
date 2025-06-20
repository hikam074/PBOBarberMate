using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBOBarberMate.App.Model
{
    public class M_Presensi : Model
    {
        [Key] public int id_presensi { get; set; }
        [Required] public int id_akun { get; set; }
        [Required] public int id_shift { get; set; }
        [Required] public DateTime waktu_presensi { get; set; }
    }
}