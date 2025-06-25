using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PBOBarberMate.App.Model;
using PBOBarberMate.App.Repository;


namespace PBOBarberMate.App.Services
{
    public class InventarisService
    {
        private readonly InventarisRepository _inventarisRepository;

        public InventarisService(InventarisRepository inventarisRepository)
        {
            _inventarisRepository = inventarisRepository;
        }



        public List<M_Inventaris> getAllInventaris()
        {
            try
            {
                return _inventarisRepository.getAllInventaris();
            }
            catch (ApplicationException ex)
            {
                throw new ApplicationException($"InventarisService: Gagal mendapatkan semua inventaris. Error: {ex.Message}", ex);
            }
        }

        public M_Inventaris getInventarisById(int id)
        {
            try
            {
                return _inventarisRepository.getInventarisById(id);
            }
            catch (ApplicationException ex)
            {
                throw new ApplicationException($"InventarisService: Gagal mendapatkan inventaris dengan ID {id}. Error: {ex.Message}", ex);
            }
        }

        public bool addInventaris(string nama, int jumlah)
        {
            try
            {
                M_Inventaris barangbaru = new M_Inventaris(nama, jumlah);
                // eksekusi
                int newBarang = _inventarisRepository.createInventaris(barangbaru);
                return newBarang > 0;
            }
            catch (ApplicationException ex)
            {
                throw new ApplicationException($"InventarisService: Gagal menambahkan inventaris. Error: {ex.Message}", ex);
            }
        }

        public bool updateInventaris(int id, string nama, int jumlah)
        {
            try
            {
                M_Inventaris barangBaru = new M_Inventaris(id, nama, jumlah);
                return _inventarisRepository.updateInventaris(barangBaru);
            }
            catch (ApplicationException ex)
            {
                throw new ApplicationException($"InventarisService: Gagal memperbarui inventaris. Error: {ex.Message}", ex);
            }
        }

        public bool deleteInventaris(int id)
        {
            try
            {
                return _inventarisRepository.deleteInventaris(id);
            }
            catch (ApplicationException ex)
            {
                throw new ApplicationException($"InventarisService: Gagal menghapus inventaris. Error: {ex.Message}", ex);
            }
        }
    }
}
