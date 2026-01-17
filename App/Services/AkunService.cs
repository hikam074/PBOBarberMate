using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBOBarberMate.App.Services
{
    using PBOBarberMate.Infrastructure.Repositories;
    using PBOBarberMate.Core.Entities;
    using PBOBarberMate.Core.Interfaces;
    using PBOBarberMate.Core.Utils;
    using PBOBarberMate.Core.Enums;

    public class AkunService
    {
        private readonly IAkunRepository _akunRepo;

        public AkunService(IAkunRepository repo)
        {
            _akunRepo = repo;
        }

        public string Login(M_Akun akun)
        {
            var user = _akunRepo.GetByUsername(akun.Username);
            if (user == null) return "User tidak ditemukan";
            if (user.Password != SecurityHelper.hashPassword(akun.Password)) return "Password salah";
            // simpan di session kalau benar
            SessionService.StartSession(user);
            return "Sukses";
        }
        public string Register(M_Akun akun)
        {
            akun.Password = SecurityHelper.hashPassword(akun.Password);
            akun.IdRole = (int)UserRole.Customer;
            bool success = _akunRepo.Insert(akun);
            return success ? "Sukses" : "Gagal" ;
        }
    }
}
