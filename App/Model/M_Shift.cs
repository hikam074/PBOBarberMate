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
        senin = 1,
        selasa = 2,
        rabu = 3,
        kamis = 4,
        jumat = 5,
        sabtu = 6,
        minggu = 7,
    }
    public class M_Shift : Model
    {
        [Key] public int id_shift { get; set; }
        [Required] public int id_akun { get; set; }
        [Required] public Hari hari { get; set; }
        public bool is_active { get; set; }

        public M_Shift(int _id_shift, int _id_akun, Hari _hari, bool _is_active)
        {
            this.id_shift = _id_shift;
            this.id_akun = _id_akun;
            this.hari = _hari;
            this.is_active = _is_active;
        }
    }
}