using PBOBarberMate.View;

namespace PBOBarberMate.App.Services
{
    public class CommonKaryawanServices
    {
        public LayananService LayananServiceInstance { get; }
        public InventarisService InventarisServiceInstance { get; }
        public ShiftService ShiftServiceInstance { get; }
        public PresensiService PresensiServiceInstance { get; }

        public CommonKaryawanServices(LayananService layananService, InventarisService inventarisService, ShiftService shiftService, PresensiService presensiService)
        {
            LayananServiceInstance = layananService;
            InventarisServiceInstance = inventarisService;
            ShiftServiceInstance = shiftService;
            PresensiServiceInstance = presensiService;
        }
    }
}