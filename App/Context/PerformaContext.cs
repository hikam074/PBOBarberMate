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
        public static NpgsqlDataReader getUlasanByID(int id)
        {
            string query = $@"
                            select avg(u.rating) as averageRating
                            from {table} u
                            join pembayaran p on u.id_pembayaran = p.id_pembayaran
                            left join reservasi r on p.id_reservasi = r.id_reservasi
                            where r.id_karyawan = @id_karyawan";

            NpgsqlParameter[] parameters =
            {
                new NpgsqlParameter("@id_layanan", id)
            };
            NpgsqlDataReader dataLayanan = queryExecutor(query, parameters);
            return dataLayanan;
        }
    }
}
