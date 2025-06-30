using PBOBarberMate.App.Model;
using PBOBarberMate.App.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                throw new ApplicationException($"ShiftService: Gagal mengambil jadwal karyawan. Error: {ex.Message}", ex);
            }
        }


    }
}
