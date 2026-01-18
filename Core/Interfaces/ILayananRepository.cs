using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBOBarberMate.Core.Interfaces
{
    using PBOBarberMate.Core.Entities;

    public interface ILayananRepository
    {
        List<M_Layanan> GetAll();
        bool Insert(M_Layanan layanan);
        bool Update(M_Layanan layanan);
        bool Delete(int idLayanan);
    }
}
