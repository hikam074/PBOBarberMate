using PBOBarberMate.View;

namespace PBOBarberMate.App.Services
{
    public class CommonAppServices
    {
        public MainApp MainAppInstance { get; }
        public AkunService AkunServiceInstance { get; }
        public SessionService SessionServiceInstance { get; }

        public CommonAppServices(MainApp mainApp, AkunService akunService, SessionService sessionService)
        {
            MainAppInstance = mainApp;
            AkunServiceInstance = akunService;
            SessionServiceInstance = sessionService;
        }
    }
}