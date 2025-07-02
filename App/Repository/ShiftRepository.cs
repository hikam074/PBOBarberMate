using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Npgsql;

using PBOBarberMate.App.Infrastructure;
using PBOBarberMate.App.Model;
using PBOBarberMate.View.Layanan;
using PBOBarberMate.View.Shift;


namespace PBOBarberMate.App.Repository
{
    public class ShiftRepository
    {
        private readonly DB_Executor _dbExecutor;

        public ShiftRepository()
        {
            _dbExecutor = new DB_Executor(DB_ConnectionFactory.ConnectionString);
        }

        //public List<M_Shift> getAllShiftAsTabular()
        //{
        //    string query = "SELECT" +
        //        "a.nama_akun AS Karyawan, " +
        //        "MAX(CASE WHEN h.id_hari = 1 THEN sk.id_shift::TEXT ELSE '' END) AS Senin, " +
        //        "MAX(CASE WHEN h.id_hari = 2 THEN sk.id_shift::TEXT ELSE '' END) AS Selasa, " +
        //        "MAX(CASE WHEN h.id_hari = 3 THEN sk.id_shift::TEXT ELSE '' END) AS Rabu, " +
        //        "MAX(CASE WHEN h.id_hari = 4 THEN sk.id_shift::TEXT ELSE '' END) AS Kamis, " +
        //        "MAX(CASE WHEN h.id_hari = 5 THEN sk.id_shift::TEXT ELSE '' END) AS Jumat, " +
        //        "MAX(CASE WHEN h.id_hari = 6 THEN sk.id_shift::TEXT ELSE '' END) AS Sabtu, " +
        //        "MAX(CASE WHEN h.id_hari = 7 THEN sk.id_shift::TEXT ELSE '' END) AS Minggu " +
        //        "FROM shift_karyawan sk " +
        //        "JOIN akun a ON sk.id_akun = a.id_akun " +
        //        "JOIN detail_hari h ON sk.id_hari = h.id_hari " +
        //        "GROUP BY a.nama_akun " +
        //        "ORDER BY a.nama_akun";
        //    try
        //    {
        //        List<object[]> rawData = _dbExecutor.ExecuteReaderAsRawList(query);
        //        // Map rawData (List<object[]>) ke List<M_Shift>
        //        return null;


        //    }
        //    catch (Exception ex)
        //    {
        //        throw new ApplicationException($"Error in getAllShiftAsTabular: {ex.Message}", ex);
        //    }
        //}
        public List<M_Jadwal> getAllShift()
        {
            string query = "SELECT " +
                "s.id_shift, s.id_akun, a.nama_akun, s.id_hari, d.nama_hari " +
                "FROM shift_karyawan s " +
                "JOIN akun a ON (s.id_akun = a.id_akun) " +
                "JOIN detail_hari d ON (s.id_hari = d.id_hari)";
            try
            {
                List<object[]> rawData = _dbExecutor.ExecuteReaderAsRawList(query);
                // wadah
                var jadwalMapping = new Dictionary<int, M_Jadwal>();
                // mapping 
                foreach (var data in rawData)
                {
                    // Konversi elemen object[] menjadi atribut M_Jadwal
                    int id_shift = Convert.ToInt32(data[0]);
                    int id_akun = Convert.ToInt32(data[1]);
                    string nama_karyawan = Convert.ToString(data[2]);
                    int id_hari = Convert.ToInt32(data[3]);

                    if (!jadwalMapping.ContainsKey(id_akun))
                    {
                        jadwalMapping[id_akun] = new M_Jadwal(id_akun, nama_karyawan);
                    }

                    var jadwal = jadwalMapping[id_akun];
                    // atribut berdasarkan id_hari
                    switch (id_hari)
                    {
                        case 1: jadwal.id_shift_senin = id_shift; break;
                        case 2: jadwal.id_shift_selasa = id_shift; break;
                        case 3: jadwal.id_shift_rabu = id_shift; break;
                        case 4: jadwal.id_shift_kamis = id_shift; break;
                        case 5: jadwal.id_shift_jumat = id_shift; break;
                        case 6: jadwal.id_shift_sabtu = id_shift; break;
                        case 7: jadwal.id_shift_minggu = id_shift; break;
                    }
                }
                return jadwalMapping.Values.ToList();
            }
            catch (Exception ex)
            {
                throw new ApplicationException($"Error in getAllShift: {ex.Message}", ex);
            }
        }
        public int addShift(M_Shift shift)
        {
            string query = "INSERT INTO shift_karyawan (id_shift, id_akun, id_hari) VALUES (@idShift, @idKaryawan, @idHari)";
            NpgsqlParameter[] parameters = {
                new NpgsqlParameter("@idShift", shift.id_shift),
                new NpgsqlParameter("@idKaryawan", shift.id_akun),
                new NpgsqlParameter("idHari", (int)shift.hari)
            };
            try
            {
                return _dbExecutor.ExecuteScalar<int>(query, parameters);
            }
            catch (Exception ex)
            {
                throw new ApplicationException($"Error in addShift: {ex.Message}", ex);
            }
        }
        public bool deleteShift(int id)
        {
            string query = "DELETE FROM shift_karyawan WHERE id_shift = @id";
            NpgsqlParameter[] parameters = {
                new NpgsqlParameter("@id", id)
            };
            try
            {
                return _dbExecutor.ExecuteNonQuery(query, parameters) > 0;
            }
            catch (Exception ex)
            {
                throw new ApplicationException($"Error in DeleteShift for ID {id}: {ex.Message}", ex);
            }
        }
    }
}
