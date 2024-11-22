using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBOBarberMate.App.Model
{
    public enum reservasiStatus
    {
        dijadwalkan = 1,
        selesai = 2,
        dibatalkan = 3
    }
    public class M_Reservasi
    {
        public int id_reservasi;
        public int id_karyawan;
        public int id_layanan;
        public DateOnly tanggal_direservasi;
        public TimeOnly waktu_direservasi;
        public DateTime tanggal_melakuan_reservasi;
        public reservasiStatus status_reservasi;
        public int nomor_meja;
    }
}
