using PBOBarberMate.View;

namespace PBOBarberMate.App.Services
{
    public class CommonAdminServices
    {
        public LayananService LayananServiceInstance { get; }

        public CommonAdminServices(LayananService layananService)
        {
            LayananServiceInstance = layananService;

        }
    }
}