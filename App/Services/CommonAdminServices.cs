using PBOBarberMate.View;

namespace PBOBarberMate.App.Services
{
    public class CommonAdminServices
    {
        public LayananService LayananServiceInstance { get; }
        public InventarisService InventarisServiceInstance { get; }
        public ShiftService ShiftServiceInstance { get; }

        public CommonAdminServices(LayananService layananService, InventarisService inventarisService, ShiftService shiftService)
        {
            LayananServiceInstance = layananService;
            InventarisServiceInstance = inventarisService;
            ShiftServiceInstance = shiftService;
        }
    }
}