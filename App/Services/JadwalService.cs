using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace PBOBarberMate.App.Services
{
    using PBOBarberMate.Core.Entities;
    using PBOBarberMate.Core.Interfaces;
    using PBOBarberMate.Core.Common;
    using PBOBarberMate.Core.Enums;
    using System.Data;

    public class JadwalService
    {
        private readonly IJadwalRepository _repo;

        public JadwalService(IJadwalRepository repo)
        {
            _repo = repo;
        }
        public Result<List<M_Jadwal>> AmbilSemuaJadwal()
        {
            try
            {
                var data = _repo.GetAllJadwal();
                return Result<List<M_Jadwal>>.Success(data);
            }
            catch (Exception e)
            {
                return Result<List<M_Jadwal>>.Failure(e.Message);
            }
        }
        public Result<DataTable> AmbilMatriksJadwal()
        {
            var allJadwal = _repo.GetAllJadwal();
            DataTable matrix = new DataTable();
            matrix.Columns.Add("IdAkun", typeof(int));
            matrix.Columns.Add("Nama Karyawan", typeof(string));
            string[] namaHari = { "Minggu", "Senin", "Selasa", "Rabu", "Kamis", "Jumat", "Sabtu" };
            for (int i = 0; i < namaHari.Length; i++)
            {
                matrix.Columns.Add(namaHari[i], typeof(string));
            }
            var grupKaryawan = allJadwal.GroupBy(j => new { j.IdAkun, j.NamaKaryawan });
            foreach (var grup in  grupKaryawan)
            {
                DataRow row = matrix.NewRow();
                row["IdAkun"] = grup.Key.IdAkun;
                row["Nama Karyawan"] = grup.Key.NamaKaryawan;
                for (int i = 0; i < namaHari.Length; i++)
                {
                    var jadwalHari = grup.FirstOrDefault(j => j.Hari == i);
                    // penamaan\
                    if (jadwalHari == null || !jadwalHari.IsActive)
                    {
                        row[namaHari[i]] = "Libur";
                    }
                    else
                    {
                        row[namaHari[i]] = jadwalHari.IsTersedia ? "Tersedia" : "Sibuk/Tidak di tempat";
                    }
                }
                matrix.Rows.Add(row);
            }
            return Result<DataTable>.Success(matrix);
        }
        public Result<bool> ToggleStatusKerja(M_Jadwal jadwal)
        {
            if (SessionService.CurrentUser.IdRole != (int)UserRole.Admin) return Result<bool>.Failure("Role tidak berwenang");
            try
            {
                _repo.UpsertJadwal(jadwal);
                return Result<bool>.Success(true, "Jadwal berhasi dibuat/diperbarui");
            }
            catch (Exception e)
            {
                return Result<bool>.Failure(e.Message);
            }
        }
    }
}
