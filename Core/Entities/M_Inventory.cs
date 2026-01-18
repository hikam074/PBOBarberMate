using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBOBarberMate.Core.Entities
{
    public class M_Inventory
    {
        public int IdBarang {  get; set; }
        public string NamaBarang { get; set; }
        public int Stok {  get; set; }
        public string Satuan { get; set; }
        public int IdAkunPengelola { get; set; }
        public string NamaPengelola { get; set; }

    }
}