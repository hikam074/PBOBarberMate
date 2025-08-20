using PBOBarberMate.App.Model;
using PBOBarberMate.App.Repository;
using PBOBarberMate.App.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBOBarberMate.App.Services
{
    public class PresensiService
    {
        private readonly PresensiRepository _presensiRepository;
        private readonly ShiftService _shiftService;

        public PresensiService(PresensiRepository presensiRepository, ShiftService shiftService)
        {
            _presensiRepository = presensiRepository;
            _shiftService = shiftService;
        }

        public M_Presensi getPresensiById(int id_karyawan)
        {
            try
            {
                DateTime now = DateTime.Now.Date;
                return _presensiRepository.getPresensiById(id_karyawan, now);
            }
            catch (Exception ex)
            {
                throw new ApplicationException($"PresensiService: Gagal mendapatkan data presensi. Error: {ex.Message}", ex);
            }
        }
        public bool addPresensi(int id_karyawan)
        {
            M_Shift shift = _shiftService.getShiftbyIdKaryawan(id_karyawan);
            M_Presensi presensiBaru = new M_Presensi(id_karyawan, shift.id_shift);
            try
            {
                int berhasil = _presensiRepository.addPresensi(presensiBaru);
                return berhasil > 0;

            }
            catch (Exception ex)
            {
                throw new ApplicationException($"PresensiService: Gagal menambahkan data presensi. Error: {ex.Message}", ex);
            }
        }

        //public bool deleteShift(int id) harusnya edit
        //{
        //try
        //{
        //    return _shiftRepository.deleteShift(id);
        //}
        //catch (ApplicationException ex)
        //{
        //    throw new ApplicationException($"ShiftService: Gagal menghapus shift. Error: {ex.Message}", ex);
        //}
        //}
    }
}
