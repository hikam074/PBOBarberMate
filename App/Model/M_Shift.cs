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
        Senin = 1,
        Selasa = 2,
        Rabu = 3,
        Kamis = 4,
        Jumat = 5,
        Sabtu = 6,
        Minggu = 7
    }
    public class M_Shift
    {
        [Key] public int id_shift { get; set; }
        [Required] public int id_akun { get; set; }
        [Required] public Hari hari { get; set; }

    }
}