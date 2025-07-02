using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBOBarberMate.App.Infrastructure
{
    public static class DB_ConnectionFactory
    {
        private static readonly string dbHost = "-";
        private static readonly string dbDatabase = "-";
        private static readonly string dbUsername = "-";
        private static readonly string dbPassword = "-";
        private static readonly string dbPort = "-";

        public static string ConnectionString =>
            $"Host={dbHost};Port={dbPort};Username={dbUsername};Password={dbPassword};Database={dbDatabase}";
    }
}
