using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

using PBOBarberMate.App.Core;
using PBOBarberMate.App.Model;


namespace PBOBarberMate.App.Context
{
    public class TabelContext : DBService
    {
        public static DataTable getReservasiMingguIni()
        {
            try
            {
                string query = "SELECT r.tanggal AS Tanggal, r.waktu AS Waktu,l.nama_layanan AS Pelayanan FROM reservasi r JOIN akun a ON (r.id_akun = a.id_akun) JOIN layanan l ON (r.id_layanan = l.id_layanan) WHERE (a.email = @email) AND (r.id_status_reservasi = @status_reservasi) AND (r.tanggal > CURRENT_DATE) AND (r.tanggal > CURRENT_DATE OR (r.tanggal = CURRENT_DATE AND r.waktu > CURRENT_TIME)) ORDER BY (r.tanggal - CURRENT_DATE) ASC, r.waktu ASC LIMIT 3";
                var parameters = new NpgsqlParameter[]
                {
                    new NpgsqlParameter("@email", UserSession.email),
                    new NpgsqlParameter("@date",DateTime.Now)
                    {
                        DbType = System.Data.DbType.Date
                    },
                    new NpgsqlParameter("@status_reservasi", (int)reservasiStatus.dijadwalkan)
                    
                };
                // mendapatkan data reservasi terdekat
                using (var reader = DBService.queryExecutor(query, parameters))
                {
                    var dataTable = new DataTable();
                    dataTable.Load(reader);
                    return dataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Terjadi kesalahan [PBOBarberMate.App.Context.TabelContext.getReservasiMingguIni]: {ex}");
                return null;
            }
        }
    }
}
