using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

using PBOBarberMate.App.Model;
using PBOBarberMate.App.Repository;
using PBOBarberMate.App.Utils;


namespace PBOBarberMate.App.Services
{
    public class ShiftService
    {
        private readonly ShiftRepository _shiftRepository;
        private readonly AkunRepository _akunRepository;

        public ShiftService(ShiftRepository shiftRepository, AkunRepository akunRepository)
        {
            _shiftRepository = shiftRepository;
            _akunRepository = akunRepository;
        }

        public List<M_Jadwal> getAllShift()
        {
            try
            {
                List<M_Jadwal> dataShift = _shiftRepository.getAllShift();
                List<M_Akun> dataAllKaryawan = _akunRepository.getAllAkun(AkunRole.karyawan);
                // ubah dataShift jadi dict biar mudah
                var shiftDictionary = dataShift.ToDictionary(s => s.id_akun, s => s);
                // cocokkan semua karyawan ke shift
                foreach (var karyawan in dataAllKaryawan)
                {
                    if (!shiftDictionary.ContainsKey(karyawan.id_akun))
                    {
                        // Buat entry baru untuk karyawan shift kosongan
                        var newJadwal = new M_Jadwal(karyawan.id_akun, karyawan.nama)
                        {
                            id_shift_senin = 0,
                            id_shift_selasa = 0,
                            id_shift_rabu = 0,
                            id_shift_kamis = 0,
                            id_shift_jumat = 0,
                            id_shift_sabtu = 0,
                            id_shift_minggu = 0
                        };
                        dataShift.Add(newJadwal);
                    }
                }

                return dataShift;
            }
            catch (Exception ex)
            {
                throw new ApplicationException($"ShiftService: Gagal getAllShift. Error: {ex.Message}", ex);
            }
        }

        public M_Shift getShiftbyIdKaryawan(int id_karyawan)
        {
            Hari idHari = HariUtils.GetIdHariFromDate(DateTime.Now);
            try
            {
                M_Shift shiftKaryawan = _shiftRepository.getShiftByIdKaryawan(id_karyawan, idHari);
                return shiftKaryawan;
            }
            catch (Exception e)
            {
                throw new ApplicationException($"ShiftService: Gagal getShiftbyIdKaryawan. Error: {e.Message}", e);
            }
        }
        public bool addShift(int id_karyawan, int id_hari)
        {
            int id_shift = int.Parse( id_karyawan.ToString() + id_hari.ToString() );
            Hari hari = (Hari)id_hari;
            M_Shift shiftBaru = new M_Shift(id_shift, id_karyawan, hari, true);
            try
            {
                // apakah existed
                M_Shift existing = _shiftRepository.getShiftById(shiftBaru.id_shift);
                bool berhasil = false;
                if (existing != null)
                {
                    berhasil = _shiftRepository.activateShift(shiftBaru.id_shift);
                } else
                {
                    berhasil = _shiftRepository.addShift(shiftBaru) > 0;
                }
                return berhasil;
            }
            catch (Exception ex)
            {
                throw new ApplicationException($"ShiftService: Gagal addShift. Error: {ex.Message}", ex);
            }
        }
        public bool deactivateShift(int id)
        {
            try
            {
                return _shiftRepository.deactivateShift(id);
            }
            catch (ApplicationException ex)
            {
                throw new ApplicationException($"ShiftService: Gagal deactivateShift. Error: {ex.Message}", ex);
            }
        }
    }
}
