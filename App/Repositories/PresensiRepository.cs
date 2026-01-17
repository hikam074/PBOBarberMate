using Npgsql;
using PBOBarberMate.App.Infrastructure;
using PBOBarberMate.App.Model;
using PBOBarberMate.View.Shift;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBOBarberMate.App.Repository
{
    public class PresensiRepository
    {
        private readonly DB_Executor _dbExecutor;

        public PresensiRepository()
        {
            _dbExecutor = new DB_Executor(DB_ConnectionFactory.ConnectionString);
        }

        public List<M_Presensi> getPresensiByIdKaryawan(DateTime start_date, DateTime end_date, int id_karyawan)
        {
            string query = "SELECT p.id_presensi, p.id_akun, p.id_shift, p.waktu_presensi " +
                "FROM presensi p " +
                "WHERE p.id_akun = @id_karyawan AND (p.waktu_presensi >= @start_date AND p.waktu_presensi < @end_date)";
            NpgsqlParameter[] parameters =
                {
                    new NpgsqlParameter("@id_karyawan", id_karyawan),
                    new NpgsqlParameter("@start_date", start_date),
                    new NpgsqlParameter("@end_date", end_date)
                };
            try
            {
                List<object[]> rawData = _dbExecutor.ExecuteReaderAsRawList(query, parameters);
                // Map rawData (List<object[]>) ke List<M_Presensi>
                return rawData.Select(row => new M_Presensi(
                    Convert.ToInt32(row[0]),    // id_presensi
                    Convert.ToInt32(row[1]),    // id_akun
                    Convert.ToInt32(row[2]),    // id_shift
                    Convert.ToDateTime(row[3])  // waktu_presensi
                )).ToList();
            }
            catch (Exception ex)
            {
                throw new ApplicationException($"PresensiRepository : Gagal getPresensiByIdKaryawan. Error : {ex.Message}", ex);
            }
        }
        public M_Presensi getPresensiByIdKaryawan(int id_karyawan, DateTime now)
        {
            string query = "SELECT * FROM presensi WHERE id_akun = @idKaryawan AND DATE(waktu_presensi) = @now";
            NpgsqlParameter[] parameters =
            {
                new NpgsqlParameter("idKaryawan", id_karyawan),
                new NpgsqlParameter("now", now)
            };
            try
            {
                List<object[]> rawData = _dbExecutor.ExecuteReaderAsRawList(query, parameters);
                if (rawData.Any())
                {
                    object[] row = rawData.First();
                    return new M_Presensi(
                        Convert.ToInt32(row[0]),
                        Convert.ToInt32(row[1]),
                        Convert.ToInt32(row[2]),
                        Convert.ToDateTime(row[3])
                    );
                }
                return null;
            }
            catch (Exception ex)
            {
                throw new ApplicationException($"PresensiRepository : gagal mengambil data id presensi by id karyawan. Error {ex.Message}", ex);
            }
        }
        public int addPresensi(M_Presensi presensi_baru)
        {
            string query = "INSERT INTO presensi (id_akun, id_shift, waktu_presensi) VALUES (@idKaryawan, @idShift, @waktu) RETURNING id_presensi";
            NpgsqlParameter[] parameters = {
                new NpgsqlParameter("idKaryawan", presensi_baru.id_akun),
                new NpgsqlParameter("idShift", presensi_baru.id_shift),
                new NpgsqlParameter("waktu", presensi_baru.waktu_presensi)
            };
            try
            {
                return _dbExecutor.ExecuteScalar<int>(query, parameters);
            }
            catch (Exception ex)
            {
                throw new ApplicationException($"Error in addPresensi: {ex.Message}", ex);
            }
        }
        public int deletePresensi(M_Presensi presensi)
        {
            string query = "DELETE FROM presensi WHERE id_preseni = @id";
            NpgsqlParameter[] parameters = {

                new NpgsqlParameter("id_presensi", presensi.id_presensi)
            };
            try
            {
                return _dbExecutor.ExecuteScalar<int>(query, parameters);
            }
            catch (Exception ex)
            {
                throw new ApplicationException($"Error in deletePresensi: {ex.Message}", ex);
            }
        }
    }
}

//public class M_Presensi : Model
//{
//    [Key] public int id_presensi { get; set; }
//    [Required] public int id_akun { get; set; }
//    [Required] public int id_shift { get; set; }
//    [Required] public DateTime waktu_presensi { get; set; }
//}
