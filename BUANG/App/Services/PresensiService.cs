//using PBOBarberMate.App.Utils;
//using PBOBarberMate.BUANG.App.Model;
//using PBOBarberMate.BUANG.App.Repositories;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Runtime.InteropServices.Marshalling;
//using System.Text;
//using System.Threading.Tasks;

//namespace PBOBarberMate.BUANG.App.Services
//{
//    public class PresensiService
//    {
//        private readonly PresensiRepository _presensiRepository;
//        private readonly ShiftService _shiftService;

//        public PresensiService(PresensiRepository presensiRepository, ShiftService shiftService)
//        {
//            _presensiRepository = presensiRepository;
//            _shiftService = shiftService;
//        }
//        public List<M_Presensi> getPresensiByIdKaryawan(int id_karyawan, DateTime start_date, DateTime end_date)
//        {
//            try
//            {
//                return _presensiRepository.getPresensiByIdKaryawan(start_date, end_date, id_karyawan);
//            }
//            catch (Exception ex)
//            {
//                throw new ApplicationException($"PresensiService: Gagal getPresensiByIdKaryawan. Error: {ex.Message}", ex);
//            }
//        }
//        public M_Presensi getPresensiByIdKaryawan(int id_karyawan)
//        {
//            try
//            {
//                DateTime now = DateTime.Now.Date;
//                return _presensiRepository.getPresensiByIdKaryawan(id_karyawan, now);
//            }
//            catch (Exception ex)
//            {
//                throw new ApplicationException($"PresensiService: Gagal getPresensiByIdKaryawan. Error: {ex.Message}", ex);
//            }
//        }
//        public bool addPresensi(int id_karyawan)
//        {
//            M_Shift shift = _shiftService.getShiftbyIdKaryawan(id_karyawan);
//            if (shift.is_active == false)
//            {
//                throw new ApplicationException("Shift tidak ada untuk hari tersebut");
//            }
//            M_Presensi presensiBaru = new M_Presensi(id_karyawan, shift.id_shift);
//            try
//            {
//                int berhasil = _presensiRepository.addPresensi(presensiBaru);
//                return berhasil > 0;

//            }
//            catch (Exception ex)
//            {
//                throw new ApplicationException($"PresensiService: Gagal addPresensi. Error: {ex.Message}", ex);
//            }
//        }
//        public bool deletePresensi(int id_karyawan)
//        {
//            M_Shift shift = _shiftService.getShiftbyIdKaryawan(id_karyawan);
//            M_Presensi presensiExisting = new M_Presensi(id_karyawan, shift.id_shift);
//            try
//            {
//                int berhasil = _presensiRepository.deletePresensi(presensiExisting);
//                return berhasil > 0;

//            }
//            catch (Exception ex)
//            {
//                throw new ApplicationException($"PresensiService: Gagal deletePresensi. Error: {ex.Message}", ex);
//            }
//        }
//    }
//}
