using PBOBarberMate.View;

namespace PBOBarberMate.App.Services
{
    public class CommonKaryawanServices
    {
        public LayananService LayananServiceInstance { get; }

        public CommonKaryawanServices(LayananService layananService)
        {
            LayananServiceInstance = layananService;

        }
    }
}