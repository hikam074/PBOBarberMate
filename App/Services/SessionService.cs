using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBOBarberMate.App.Services
{
    using PBOBarberMate.Core.Entities;
    public static class SessionService
    {
        public static M_Akun CurrentUser { get; private set; }
        public static event Action OnProfileUpdated;

        public static void StartSession(M_Akun user)
        {
            CurrentUser = user;
        }
        public static void UpdateSession(M_Akun dataBaru)
        {
            if (dataBaru == null) return;
            if (CurrentUser != null && dataBaru.IdAkun == CurrentUser.IdAkun)
            {
                CurrentUser = dataBaru;
                OnProfileUpdated?.Invoke(); // trigger event di navbar agar perubahan langsuyng terlihat
            }
        }
        public static void EndSession()
        {
            CurrentUser = null;
        }

        public static bool IsLoggedIn() => CurrentUser != null;

        // Helper untuk cek apakah admin
        public static bool IsAdmin() => CurrentUser?.NamaRole == "Admin";
    }
}
