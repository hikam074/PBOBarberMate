using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBOBarberMate.App.Services
{
    using PBOBarberMate.Core.Common;
    using PBOBarberMate.Core.Entities;
    using PBOBarberMate.Core.Interfaces;

    public class InventoryService
    {
        private readonly IInventoryRepository _repo;

        public InventoryService(IInventoryRepository repo)
        {
            _repo = repo;
        }

        public Result<List<M_Inventory>> AmbilSemuaBarang()
        {
            try
            {
                var data = _repo.GetAll();
                return Result<List<M_Inventory>>.Success(data);
            }
            catch (Exception e)
            {
                return Result<List<M_Inventory>>.Failure(e.Message);
            }
        }
        public Result<bool> TambahBarang(M_Inventory barang)
        {
            try
            {
                barang.IdAkunPengelola = SessionService.CurrentUser.IdAkun;
                if (barang.Stok < 0) return Result<bool>.Failure("Stok tidak boleh minus");
                _repo.Insert(barang);
                return Result<bool>.Success(true, "Barang berhasil ditambahkan");
            }
            catch (Exception e)
            {
                return Result<bool>.Failure(e.Message);
            }
        }
    }
}
