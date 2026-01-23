using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBOBarberMate.Core.Entities
{
    public class M_Jadwal
    {
        public string IdJadwal { get; set; }
        public int IdAkun { get; set; }
        public string NamaKaryawan { get; set; }
        public int Hari { get; set; }
        public bool IsActive { get; set; }
        public bool IsTersedia { get; set; }
        public string StatusDisplay => IsActive ? (IsTersedia ? "Masuk" : "Izin") : "Libur";

        //public M_Jadwal(string _id_jadwal, int _id_akun, int _hari, bool _is_active, bool _is_tersedia)
        //{
        //    IdJadwal = _id_jadwal;
        //    IdAkun = _id_akun;
        //    Hari = _hari;
        //    IsActive = _is_active;
        //    IsTersedia = _is_tersedia;
        //}
    }
}