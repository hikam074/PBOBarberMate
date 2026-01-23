using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBOBarberMate.Core.Interfaces
{
    using PBOBarberMate.Core.Entities;

    public interface IJadwalRepository
    {
        List<M_Jadwal> GetAllJadwal();
        bool UpsertJadwal(M_Jadwal jadwal);
        bool UpdateKetersediaan(string idJadwal, bool tersedia);
    }
}
