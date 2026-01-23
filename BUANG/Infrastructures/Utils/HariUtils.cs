//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using PBOBarberMate.Core.Entities;

//namespace PBOBarberMate.BUANG.Infrastructures.Utils
//{
//    public static class HariUtils
//    {
//        public static Hari GetIdHariFromDate(DateTime tanggal)
//        {
//            return tanggal.DayOfWeek switch
//            {
//                DayOfWeek.Monday => Hari.senin,
//                DayOfWeek.Tuesday => Hari.selasa,
//                DayOfWeek.Wednesday => Hari.rabu,
//                DayOfWeek.Thursday => Hari.kamis,
//                DayOfWeek.Friday => Hari.jumat,
//                DayOfWeek.Saturday => Hari.sabtu,
//                DayOfWeek.Sunday => Hari.minggu,
//                _ => throw new ArgumentOutOfRangeException()
//            };
//        }
//    }
//}
