using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBOBarberMate.App.Model
{
    public class M_Layanan : Model
    {
        [Key] public int id_layanan { get; set; }
        [Required] public string nama_layanan { get; set; }
        [Required] public int harga { get; set; }


        // CONSTRUCTOR CREATE
        public M_Layanan(string nama_layanan, int harga) { }
        // CONSTRUCTOR GET
        public M_Layanan(int id_layanan, string nama_layanan, int harga) { }
    }
}