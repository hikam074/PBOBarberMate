using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PBOBarberMate.App.Model;


namespace PBOBarberMate.App.Model
{
    public enum keteranganHistoriPembayaran
    {
        ditambahkan = 1,
        diubah = 2,
        dihapus = 3
    }

    public class M_HistoriPembayaran : M_Pembayaran
    {
        public keteranganHistoriPembayaran keteranganHistori;

        public M_HistoriPembayaran(int id_reservasi, int harga, int metode_pembayaran, keteranganHistoriPembayaran keterangan) : base (id_reservasi, harga, metode_pembayaran)
        {
            this.keteranganHistori = keterangan;
        }
    }
}
