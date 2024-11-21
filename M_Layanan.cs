using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBOBarberMate.App.Model
{
    public class M_Layanan
    {
        [Key]
        public int id_layanan { get; set; }
        [Required]
        public string nama_layanan { get; set; }
        [Required]
        public int harga { get; set; }
    }
}
