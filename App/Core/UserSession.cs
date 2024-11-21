using PBOBarberMate.App.Model;
using PBOBarberMate.App.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBOBarberMate.App.Core
{
    public static class UserSession
    {
        public static string email;
        public static string nama;
        public static int idSession;
        public static AkunRole? role { get; set; }
    }
}
