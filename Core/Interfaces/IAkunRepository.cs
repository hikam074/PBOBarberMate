using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBOBarberMate.Core.Interfaces
{
    using PBOBarberMate.Core.Entities;
    public interface IAkunRepository
    {
        M_Akun GetByUsername(string username);
        bool Insert(M_Akun Akun);
    }
}
