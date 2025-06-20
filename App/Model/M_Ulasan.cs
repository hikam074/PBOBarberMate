using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBOBarberMate.App.Model
{
    public class M_Ulasan : Model
    {
        [Key] public int id_ulasan {  get; set; }
        [Required] public int id_pembayaran { get; set; }
        [Required] public int rating { get; set; }
        public string isi_ulasan { get; set; }
        [Required] public DateTime tanggal_memberi_ulasan { get; set; }
    }
}
