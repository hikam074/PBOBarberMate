using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
        [Key] public int id_reservasi { get; set; }
        [Required] public int id_karyawan { get; set; }
        [Required] public int id_layanan { get; set; }
        [Required] public DateOnly tanggal_direservasi { get; set; }
        [Required] public TimeOnly waktu_direservasi { get; set; }
        [Required] public DateTime tanggal_melakuan_reservasi { get; set; }
        [Required] public reservasiStatus status_reservasi { get; set; } = reservasiStatus.dijadwalkan;
        public int nomor_meja;
    }
}