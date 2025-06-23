using PBOBarberMate.App.Model;
using PBOBarberMate.App.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBOBarberMate.App.Services
{
    internal class LayananService
    {
        private readonly LayananRepository _layananRepository;

        public LayananService(LayananRepository layananRepository)
        {
            _layananRepository = layananRepository;
        }

        public List<M_Layanan> getAllLayanan()
        {
            try
            {
                return _layananRepository.getAllLayanan();
            }
            catch (ApplicationException ex)
            {
                throw new ApplicationException($"LayananService: Gagal mendapatkan semua layanan. Error: {ex.Message}", ex);
            }
        }

        public M_Layanan getLayananById(int id)
        {
            try
            {
                return _layananRepository.getLayananById(id);
            }
            catch (ApplicationException ex)
            {
                throw new ApplicationException($"LayananService: Gagal mendapatkan layanan dengan ID {id}. Error: {ex.Message}", ex);
            }
        }

        public bool addLayanan(M_Layanan layanan)
        {
            try
            {
                int newLayananId = _layananRepository.createLayanan(layanan);
                return newLayananId > 0;
            }
            catch (ApplicationException ex)
            {
                throw new ApplicationException($"LayananService: Gagal menambahkan layanan. Error: {ex.Message}", ex);
            }
        }

        public bool updateLayanan(M_Layanan layanan)
        {
            try
            {
                return _layananRepository.updateLayanan(layanan);
            }
            catch (ApplicationException ex)
            {
                throw new ApplicationException($"LayananService: Gagal memperbarui layanan. Error: {ex.Message}", ex);
            }
        }

        public bool deleteLayanan(int id)
        {
            try
            {
                return _layananRepository.deleteLayanan(id);
            }
            catch (ApplicationException ex)
            {
                throw new ApplicationException($"LayananService: Gagal menghapus layanan. Error: {ex.Message}", ex);
            }
        }
    }
}
