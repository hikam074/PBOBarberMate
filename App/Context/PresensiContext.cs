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
    public class PresensiContext : DBService
    {
        private static string table = "presensi"; // Tabel presensi

        // Mengambil jadwal shift karyawan berdasarkan ID akun (hanya untuk akun_role_id = 2)
        public static DataTable GetJadwalShiftKaryawan(int idAkun)
        {
            string query = $@"
                SELECT sk.id_shift, dh.nama_hari AS Hari, p.waktu_presensi
                FROM shift_karyawan sk
                JOIN detail_hari dh ON sk.id_hari = dh.id_hari
                LEFT JOIN presensi p ON sk.id_shift = p.id_shift AND p.id_akun = @id_akun
                WHERE sk.id_akun = @id_akun";

            Console.WriteLine(query);

            NpgsqlParameter[] parameters =
            {
                new NpgsqlParameter("@id_akun", idAkun)
            };

            try
            {
                using (NpgsqlDataReader reader = queryExecutor(query, parameters))
                {
                    DataTable jadwalData = new DataTable();
                    jadwalData.Load(reader);
                    return jadwalData;
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error in PresensiContext.GetJadwalShiftKaryawan(): {ex.Message}", ex);
            }
        }

        // Menambahkan presensi baru
        public static void AddPresensi(M_Presensi presensi)
        {
            string query = $@"
                INSERT INTO {table} (id_akun, id_shift, waktu_presensi)
                VALUES (@id_akun, @id_shift, @waktu_presensi)";

            NpgsqlParameter[] parameters =
            {
                new NpgsqlParameter("@id_akun", presensi.id_akun),
                new NpgsqlParameter("@id_shift", presensi.id_shift),
                new NpgsqlParameter("@waktu_presensi", presensi.waktu_presensi)
            };

            try
            {
                commandExecutor(query, parameters);
            }
            catch (Exception ex)
            {
                throw new Exception($"Error in PresensiContext.AddPresensi(): {ex.Message}", ex);
            }
        }

        // Mengecek apakah karyawan sudah melakukan presensi pada shift tertentu
        public static bool IsPresensiExist(int idAkun, int idShift)
        {
            string query = $@"
                SELECT COUNT(*) 
                FROM {table}
                WHERE id_akun = @id_akun AND id_shift = @id_shift";

            NpgsqlParameter[] parameters =
            {
                new NpgsqlParameter("@id_akun", idAkun),
                new NpgsqlParameter("@id_shift", idShift)
            };

            try
            {
                using (NpgsqlDataReader reader = queryExecutor(query, parameters))
                {
                    if (reader.Read())
                    {
                        return reader.GetInt32(0) > 0;
                    }
                    return false;
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error in PresensiContext.IsPresensiExist(): {ex.Message}", ex);
            }
        }

        public static string isPresensiTodayExist(int idAkun)
        {
            string query = "SELECT TO_CHAR(waktu_presensi, 'HH24:MI:SS') AS waktu_presensi FROM presensi WHERE id_akun = @id_akun AND DATE(waktu_presensi) = CURRENT_DATE ;";

            NpgsqlParameter[] parameters =
            {
                new NpgsqlParameter("@id_akun", idAkun)
            };

            try
            {
                using (NpgsqlDataReader reader = queryExecutor(query, parameters))
                {
                    if (reader.Read())
                    {

                        return reader["waktu_presensi"].ToString();
                    }
                    else
                    {
                        return null;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Terjadi kesalahan [PBOBarberMate.App.Context.PresensiContext.isPresensiodayExist] : {ex}");
                return null;
            }
        }
        public static int getJadwalShiftTodayThisID(int idAkun)
        {
            try
            {
                string query = "SELECT id_shift FROM shift_karyawan WHERE id_akun = @idAkun AND id_hari = EXTRACT(DOW FROM CURRENT_DATE)";

                NpgsqlParameter[] parameters = { new NpgsqlParameter("@idAkun", idAkun) };
                using (NpgsqlDataReader reader = queryExecutor(query, parameters))
                {
                    if (reader.Read())
                    {
                        return Convert.ToInt32(reader["id_shift"]);
                    }
                    else
                    {
                        return -1;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Terjadi kesalahan [PBOBarberMate.App.Context.PresensiContext.getJadwalShiftTodayThisID] : {ex}");
                return -1;
            }
        }
    }
}
