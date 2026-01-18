//using PBOBarberMate.BUANG.Core.Entities;
//using System;

//namespace PBOBarberMate.BUANG.App.Services
//{
//    public class SessionService
//    {
//        public string CurrentUserEmail { get; private set; }
//        public string CurrentUserName { get; private set; }
//        public int CurrentUserId { get; private set; }
//        public AkunRole? CurrentUserRole { get; private set; } // Role bisa null jika belum login

//        // Mengatur data sesi pengguna setelah login berhasil
//        public void SetSession(string email, string nama, int id, AkunRole role)
//        {
//            CurrentUserEmail = email;
//            CurrentUserName = nama;
//            CurrentUserId = id;
//            CurrentUserRole = role;
//        }

//        // Menghapus data sesi saat pengguna logout.
//        public void ClearSession()
//        {
//            CurrentUserEmail = null;
//            CurrentUserName = null;
//            CurrentUserId = 0;
//            CurrentUserRole = null;
//        }

//        // Memeriksa apakah ada pengguna yang sedang login
//        public bool IsLoggedIn() => CurrentUserEmail != null;
//    }
//}
