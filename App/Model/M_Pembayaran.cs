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
        transfer = 1,
        tunai = 2,
        e_wallet = 3
    }
    public class M_Pembayaran
    {
        [Key] public int idPembayaran { get; set; }
        [Required] public int idReservasi { get; set; }
        [Required] public int harga { get; set; }
        [Required] public metodePembayaran metodePembayaran { get; set; }
    }
}