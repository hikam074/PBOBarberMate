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
    internal class PresensiContext : DBService
    {
        public static DataTable All()
        {
            string query = @"
            SELECT 
            a.id_presensi
            a.nama_akun,
            p.waktu_presensi,
            FROM 
            presensi p
            JOIN 
            akun a ON p.id_akun = a.id_akun";

            DataTable dataMahasiswa = queryExecutorDataTable(query);
            
            return dataMahasiswa;
        }
        public static DataTable getDataPresensiById(int id)
        {
            string query = @"
                SELECT 
                    waktu_presensi
                FROM 
                    presensi
                WHERE 
                    id_presensi = @id";

            NpgsqlParameter[] parameters =
            {
                new NpgsqlParameter("@id", NpgsqlTypes.NpgsqlDbType.Integer) { Value = id }
            };

            DataTable dataMahasiswa = queryExecutorDataTable(query, parameters);
            return dataMahasiswa;
        }
        public static void DeletePresensi(int id)
        {
            string table = "presensi";
            string query = $"DELETE FROM {table} WHERE id_presensi = @id";

            NpgsqlParameter[] parameters =
            {
                new NpgsqlParameter("@id", id)
            };

            commandExecutor(query, parameters);
        }
    }
}
