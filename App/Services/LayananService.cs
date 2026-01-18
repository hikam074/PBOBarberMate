using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBOBarberMate.App.Services
{
    using PBOBarberMate.Core.Common;
    using PBOBarberMate.Core.Entities;
    using PBOBarberMate.Core.Enums;
    using PBOBarberMate.Core.Interfaces;

    public class LayananService
    {
        private readonly ILayananRepository _repo;

        public LayananService(ILayananRepository repo)
        {
            _repo = repo;
        }

        public Result<List<M_Layanan>> AmbilSemuaLayanan()
        {
            try
            {
                var data = _repo.GetAll();
                return Result<List<M_Layanan>>.Success(data);
            }
            catch (Exception e)
            {
                return Result<List<M_Layanan>>.Failure(e.Message);
            }
        }
        public Result<bool> TambahLayanan(M_Layanan layanan)
        {
            if (SessionService.CurrentUser.IdRole != (int)UserRole.Admin) return Result<bool>.Failure("Role tidak berwenang");
            try
            {
                if (layanan.Harga <= 0) return Result<bool>.Failure("harga tidak boleh minus");
                _repo.Insert(layanan);
                return Result<bool>.Success(true, "Layanan baru berhasil ditambahkan");
            }
            catch (Exception e)
            {
                return Result<bool>.Failure(e.Message);
            }
        }
        public Result<bool> PerbaruiLayanan(M_Layanan layanan)
        {
            if (SessionService.CurrentUser.IdRole != (int)UserRole.Admin) return Result<bool>.Failure("Role tidak berwenang");
            try
            {
                if (layanan.Harga <= 0) return Result<bool>.Failure("harga tidak boleh minus");
                _repo.Update(layanan);
                return Result<bool>.Success(true, "Layanan berhasil diperbarui");
            }
            catch (Exception e)
            {
                return Result<bool>.Failure(e.Message);
            }
        }
        public Result<bool> HapusLayanan(int idLayanan)
        {
            if (SessionService.CurrentUser.IdRole != (int)UserRole.Admin) return Result<bool>.Failure("Role tidak berwenang");
            try
            {
                _repo.Delete(idLayanan);
                return Result<bool>.Success(true, "Layanan berhasil dihapus");
            }
            catch (Exception e)
            {
                return Result<bool>.Failure(e.Message);
            }
        }
    }
}
