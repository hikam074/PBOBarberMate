using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using PBOBarberMate.App.Model;
using PBOBarberMate.App.Repository;


namespace PBOBarberMate.App.Services
{
    public class LayananService
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

        public bool addLayanan(string layanan, int harga)
        {
            try
            {
                M_Layanan layananBaru = new M_Layanan(layanan, harga);
                // eksekusi
                int newLayananId = _layananRepository.createLayanan(layananBaru);
                return newLayananId > 0;
            }
            catch (ApplicationException ex)
            {
                throw new ApplicationException($"LayananService: Gagal menambahkan layanan. Error: {ex.Message}", ex);
            }
        }

        public bool updateLayanan(int id, string layanan, int harga)
        {
            try
            {
                M_Layanan layananBaru = new M_Layanan(id, layanan, harga);
                return _layananRepository.updateLayanan(layananBaru);
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
