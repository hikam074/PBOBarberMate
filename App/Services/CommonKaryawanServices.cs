using PBOBarberMate.View;

namespace PBOBarberMate.App.Services
{
    public class CommonKaryawanServices
    {
        public LayananService LayananServiceInstance { get; }
        public InventarisService InventarisServiceInstance { get; }

        public CommonKaryawanServices(LayananService layananService, InventarisService inventarisServiceInstance)
        {
            LayananServiceInstance = layananService;
            InventarisServiceInstance = inventarisServiceInstance;
        }
    }
}