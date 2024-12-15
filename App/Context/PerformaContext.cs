using Npgsql;
using PBOBarberMate.App.Core;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBOBarberMate.App.Context
{
    public class PerformaContext : DBService
    {
        private static string table = "ulasan";

        
        // query rata rata rating 
        public static double getUlasanByID(int id)
        {
            string query = $@"
                            select avg(u.rating) as averageRating
                            from {table} u
                            join pembayaran p on u.id_pembayaran = p.id_pembayaran
                            left join reservasi r on p.id_reservasi = r.id_reservasi
                            where r.id_karyawan = @id_karyawan";

            try
            {
                NpgsqlParameter[] parameters =
                {
                    new NpgsqlParameter("@id_karyawan", id)
                };
                using (NpgsqlDataReader reader = queryExecutor(query, parameters))
                {
                    if (reader.Read()) { return reader.IsDBNull(reader.GetOrdinal("average_rating")) ? 0 : reader.GetDouble(reader.GetOrdinal("average_rating")); }
                    return 0;
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error in PerformaContext.getUlasanByID(): {ex.Message}", ex);
            }
        }

        //internal static DataTable getUlasanByID()
        //{
        //    throw new NotImplementedException();
        //}
    }
}
