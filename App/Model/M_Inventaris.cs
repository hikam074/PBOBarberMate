using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace PBOBarberMate.App.Model
{
    public class M_Inventaris : Model
    {
        [Key] public int id_barang {  get; set; }
        [Required] public string nama_barang { get; set; }
        [Required] public int jumlah_barang { get; set; } = 0;
    }
}