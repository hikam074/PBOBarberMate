using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBOBarberMate.Core.Entities
{
    public class M_Layanan
    {
        public int IdLayanan { get; set; }
        public string NamaLayanan { get; set; }
        public decimal Harga { get; set; }
        public string Deskripsi { get; set; }
    }
}
