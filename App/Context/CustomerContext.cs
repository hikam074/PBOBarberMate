using Npgsql;
using PBOBarberMate.App.Core;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace PBOBarberMate.App.Context
{
    public class CustomerContext : DBService
    {
        private static string table = "akun";


        //Mengambil semua data customer
        public static DataTable All()
        {
            string query = $@"select * from {table} where akun_role_id = 3";

            try
            {
                using (NpgsqlDataReader reader = queryExecutor(query, null))
                {
                    DataTable datacustomer = new DataTable();
                    datacustomer.Load(reader); // Memuat data dari DataReader ke DataTable
                    return datacustomer;
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error in Customer.Context.All(): {ex.Message}", ex);
            }
        }
    }
}
