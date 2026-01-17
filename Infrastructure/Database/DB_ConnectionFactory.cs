using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBOBarberMate.Infrastructure.Database
{
    public static class DB_ConnectionFactory
    {
        private static readonly string dbHost = "localhost";
        private static readonly string dbDatabase = "PBO";
        private static readonly string dbUsername = "postgres";
        private static readonly string dbPassword = "dammahom51";
        private static readonly string dbPort = "5432";
        public static string _connectionString =>
            $"Host={dbHost};Port={dbPort};Username={dbUsername};Password={dbPassword};Database={dbDatabase}";
        public static NpgsqlConnection CreateConnection()
        {
            return new NpgsqlConnection(_connectionString);
        }
    }
}
