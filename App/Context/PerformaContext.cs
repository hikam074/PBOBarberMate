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

        public static DataTable getUlasanByID(int id)
        {
            string query = $@"
                select u.rating
                from {table} u
                join pembayaran p on u.id_pembayaran = p.id_pembayaran
                left join reservasi r on p.id_reservasi = r.id_reservasi and id_karyawan = @id_shift";

            NpgsqlParameter[] parameters =
            {
                new NpgsqlParameter("@id_shift", id)
            };
            try
            {
                using (NpgsqlDataReader reader = queryExecutor(query, parameters))
                {
                    DataTable dataShift = new DataTable();
                    dataShift.Load(reader);
                    return dataShift;
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error in PerformaContext.getUlasanByID(): {ex.Message}", ex);
            }
        }
    }
}
