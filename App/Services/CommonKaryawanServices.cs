using PBOBarberMate.View;

namespace PBOBarberMate.App.Services
{
    public class CommonKaryawanServices
    {
        public LayananService LayananServiceInstance { get; }
        public InventarisService InventarisServiceInstance { get; }
        public ShiftService ShiftServiceInstance { get; }

        public CommonKaryawanServices(LayananService layananService, InventarisService inventarisServiceInstance, ShiftService shiftServiceInstance)
        {
            LayananServiceInstance = layananService;
            InventarisServiceInstance = inventarisServiceInstance;
            ShiftServiceInstance = shiftServiceInstance;
        }
    }
}