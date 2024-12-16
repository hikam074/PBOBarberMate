using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBOBarberMate.App.Model
{
    public enum metodePembayaran
    {
        Transfer = 1,
        Tunai = 2,
        E_Wallet = 3
    }
    public class M_Pembayaran
    {
        public int idPembayaran;
        public int idReservasi;
        public int harga;
        public metodePembayaran metodePembayaran;

        public M_Pembayaran(int id_reservasi, int harga, int metode_pembayaran)
        {
            this.idReservasi = id_reservasi;
            this.harga = harga;
            this.metodePembayaran = (metodePembayaran)metode_pembayaran;
        }
    }
}
