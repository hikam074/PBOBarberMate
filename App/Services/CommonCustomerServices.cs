using PBOBarberMate.View;

namespace PBOBarberMate.App.Services
{
    public class CommonCustomerServices
    {
        public LayananService LayananServiceInstance { get; }

        public CommonCustomerServices(LayananService layananService)
        {
            LayananServiceInstance = layananService;

        }
    }
}