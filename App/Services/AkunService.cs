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
    using PBOBarberMate.Core.Common;

    public class AkunService
    {
        private readonly IAkunRepository _akunRepo;

        public AkunService(IAkunRepository repo)
        {
            _akunRepo = repo;
        }

        public Result<M_Akun> Login(M_Akun akun)
        {
            var user = _akunRepo.GetByUsername(akun.Username);
            if (user == null) return Result<M_Akun>.Failure("User tidak ditemukan");
            if (user.Password != SecurityHelper.hashPassword(akun.Password)) return Result<M_Akun>.Failure("Password salah");
            // simpan di session kalau benar
            SessionService.StartSession(user);
            return Result<M_Akun>.Success(user, "Login Berhasil");
        }
        public Result<bool> Register(M_Akun akun)
        {
            try
            {
                akun.Password = SecurityHelper.hashPassword(akun.Password);
                akun.IdRole = (int)UserRole.Customer;
                bool success = _akunRepo.Insert(akun);
                return Result<bool>.Success(true, "Registrasi Berhasil, silahkan login");
            }
            catch (Exception e)
            {
                return Result<bool>.Failure(e.Message);
            }
        }
    }
}
