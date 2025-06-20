using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
        [Key] public int idPembayaran { get; set; }
        [Required] public int idReservasi { get; set; }
        [Required] public int harga { get; set; }
        [Required] public metodePembayaran metodePembayaran { get; set; }
    }
}