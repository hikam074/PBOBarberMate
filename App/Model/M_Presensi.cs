using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace PBOBarberMate.App.Model
{
    internal class M_Presensi
    {
        [Key]
        public int id_presensi { get; set; }
        public DataSetDateTime timestamp { get; set; }
        
    }
}
