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

        public M_Inventaris(string _nama_barang, int _jumlah_barang)
        {
            this.nama_barang = _nama_barang;
            this.jumlah_barang = _jumlah_barang;
        }
        public M_Inventaris(int _id_barang, string _nama_barang, int _jumlah_barang)
        {
            this.id_barang = _id_barang;
            this.nama_barang = _nama_barang;
            this.jumlah_barang = _jumlah_barang;
        }
    }
}