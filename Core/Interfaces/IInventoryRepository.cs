using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBOBarberMate.Core.Interfaces
{
    using PBOBarberMate.Core.Entities;

    public interface IInventoryRepository
    {
        List<M_Inventory> GetAll();
        bool Insert(M_Inventory barang);
        bool Update(M_Inventory barang);
        bool UpdateStok(int idBarang, int jumlahStok);
        bool Delete(int idbarang);
    }
}
