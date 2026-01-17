using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBOBarberMate.BUANG.Core.Entities
{
    public class M_Jadwal
    {
        [Key] public int id_akun;
        [Required] public string nama_karyawan;
        public int id_shift_senin;
        public int id_shift_selasa;
        public int id_shift_rabu;
        public int id_shift_kamis;
        public int id_shift_jumat;
        public int id_shift_sabtu;
        public int id_shift_minggu;

        public M_Jadwal(int _id_akun, string _nama_karyawan)
        {
            id_akun = _id_akun;
            nama_karyawan = _nama_karyawan;
        }
    }
}
