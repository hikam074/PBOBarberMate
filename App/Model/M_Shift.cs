using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBOBarberMate.App.Model
{
    public enum Hari
    {
        minggu = 0,
        senin = 1,
        selasa = 2,
        rabu = 3,
        kamis = 4,
        jumat = 5,
        sabtu = 6,
    }
    public class M_Shift
    {
        [Key] public int id_shift { get; set; }
        [Required] public int id_akun { get; set; }
        [Required] public Hari hari { get; set; }

    }
}