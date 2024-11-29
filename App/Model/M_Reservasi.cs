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

        // overloading constructor untuk verifikasi reservasi
        public M_Reservasi(int id_layanan, DateOnly tanggal_direservasi, TimeOnly waktu_direservasi)
        {
            this.id_layanan = id_layanan;
            this.tanggal_direservasi = tanggal_direservasi;
            this.waktu_direservasi = waktu_direservasi;
        }
        // overloading constructor untuk membuat reservasi
        public M_Reservasi(int id_layanan, int id_karyawan, DateOnly tanggal_direservasi, TimeOnly waktu_direservasi, int nomor_meja)
        {
            this.id_layanan = id_layanan;
            this.id_karyawan = id_karyawan;
            this.tanggal_direservasi = tanggal_direservasi;
            this.waktu_direservasi = waktu_direservasi;
            this.nomor_meja = nomor_meja;
            this.status_reservasi = reservasiStatus.dijadwalkan;
        }
    }
}
