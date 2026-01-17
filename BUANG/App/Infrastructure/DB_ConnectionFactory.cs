using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBOBarberMate.BUANG.App.Infrastructure
{
    public static class DB_ConnectionFactory
    {
        private static readonly string dbHost = "localhost";
        private static readonly string dbDatabase = "BarberMate";
        private static readonly string dbUsername = "postgres";
        private static readonly string dbPassword = "dammahom51";
        private static readonly string dbPort = "5432";

        public static string ConnectionString =>
            $"Host={dbHost};Port={dbPort};Username={dbUsername};Password={dbPassword};Database={dbDatabase}";
    }
}
