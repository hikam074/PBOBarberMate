using PBOBarberMate.View;

namespace PBOBarberMate.App.Services
{
    public class CommonAdminServices
    {
        public LayananService LayananServiceInstance { get; }
        public InventarisService InventarisServiceInstance { get; }

        public CommonAdminServices(LayananService layananService, InventarisService inventarisService)
        {
            LayananServiceInstance = layananService;
            InventarisServiceInstance = inventarisService;
        }
    }
}