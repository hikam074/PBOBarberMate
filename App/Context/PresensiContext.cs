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
        public static DataTable GetJadwalShiftKaryawanAll()
        {
            string query = $@"
                SELECT p.id_presensi,a.nama_akun, sk.id_shift, dh.nama_hari AS Hari, p.waktu_presensi
                FROM shift_karyawan sk
                join akun a on sk.id_akun = a.id_akun
                JOIN detail_hari dh ON sk.id_hari = dh.id_hari
                LEFT JOIN presensi p ON sk.id_shift = p.id_shift
                WHERE p.waktu_presensi IS NOT NULL;
                ";

            Console.WriteLine(query);
            try
            {
                using (NpgsqlDataReader reader = queryExecutor(query))
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
        public static DataTable GetJadwalPresensiKaryawan()
        {
            string query = $@"
                SELECT p.id_presensi,a.id_akun,a.nama_akun, sk.id_shift, dh.nama_hari AS Hari, p.waktu_presensi
                FROM shift_karyawan sk
                JOIN detail_hari dh ON sk.id_hari = dh.id_hari
                LEFT JOIN presensi p ON sk.id_shift = p.id_shift
                join akun a on p.id_akun = a.id_akun
                WHERE p.waktu_presensi IS NOT NULL";

            Console.WriteLine(query);


            try
            {
                using (NpgsqlDataReader reader = queryExecutor(query))
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
        public static DataTable GetJadwalShiftKaryawanbyIdPresensi(int idPresensi)
        {
            string query = $@"
                SELECT p.id_presensi,a.id_akun,a.nama_akun, sk.id_shift, dh.nama_hari AS Hari, p.waktu_presensi
                FROM shift_karyawan sk
                JOIN detail_hari dh ON sk.id_hari = dh.id_hari
                LEFT JOIN presensi p ON sk.id_shift = p.id_shift
                join akun a on p.id_akun = a.id_akun
                WHERE p.waktu_presensi IS NOT NULL and p.id_presensi = @id_presensi";

            NpgsqlParameter[] parameters =
            {
                new NpgsqlParameter("@id_presensi", idPresensi)
            };

            try
            {
                using (NpgsqlDataReader reader = queryExecutor(query))
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
        public static DataTable GetJadwalShiftKaryawanbyIdAkun(int idAkun)
        {
            string query = $@"
                select sk.id_shift, dh.nama_hari from shift_karyawan sk
                join detail_hari dh on sk.id_hari = dh.id_hari
                join akun a on a.id_akun = sk.id_akun
                where a.id_akun = @id_akun";

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
        public static void getInfoAkunKaryawan(M_Presensi presensi)
        {
            string query = $@"
                select a.id_akun, a.nama_akun, sk.id_shift, dh.nama_hari as hari
                from shift_karyawan sk
                join akun a on sk.id_akun = a.id_akun
                join detail_hari dh on sk.id_hari = dh.id_hari
                where a.id_akun = @id_akun";

            NpgsqlParameter[] parameters =
            {
                new NpgsqlParameter("@id_akun", presensi.id_akun),
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
        //Mengecek apakah karyawan sudah melakukan presensi pada shift tertentu
        public static DataTable getInfoNamaKaryawan()
        {
            string query = $@"
                select nama_akun
                from akun
                where akun_role_id = 2";

            //NpgsqlParameter[] parameters =
            //{
            //    new NpgsqlParameter("@id_akun", presensi.id_akun),
            //};

            try
            {
                using (NpgsqlDataReader reader = queryExecutor(query))
                {
                    DataTable jadwalData = new DataTable();
                    jadwalData.Load(reader);
                    return jadwalData;
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error in : {ex.Message}", ex);
            }
        }
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
                string query = "SELECT sk.id_shift FROM shift_karyawan sk JOIN detail_hari dh ON (dh.id_hari  = sk.id_hari) WHERE sk.id_akun = @idAkun AND dh.hari_sql = EXTRACT(DOW FROM CURRENT_DATE)";

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

        internal static void DeletePresensi(int idpresensi)
        {
            string query = $@"
                DELETE FROM {table} where id_presensi = @id_presensi";

            NpgsqlParameter[] parameters =
            {
                new NpgsqlParameter("@id_presensi", idpresensi),
            };


        public static DataTable getDataPresensiById(int id)
        {
            string query = @"
                SELECT 
                    waktu_presensi
                FROM 
                    presensi
                WHERE 
                    id_presensi = @id";
            try
            {
                commandExecutor(query, parameters);
            }
            catch (Exception ex)
            {
                throw new Exception($"Error in PresensiContext.AddPresensi(): {ex.Message}", ex);
            }
        }
        public static void UpdatePresensi(int idPresensi,int idAkun,int idShift, DateTime waktuPresensi)
        {
            MessageBox.Show(waktuPresensi.ToString());
            string query = $@"
                update presensi SET id_akun = @id_akun, id_shift = @id_shift, waktu_presensi = @waktu_presensi where id_presensi = @id_presensi";

            NpgsqlParameter[] parameters =
            {
                new NpgsqlParameter("@id_presensi", idPresensi),
                new NpgsqlParameter("@id_akun", idAkun),
                new NpgsqlParameter("@id_shift", idShift),
                new NpgsqlParameter("@waktu_presensi", waktuPresensi)
            };

            try
            {
                commandExecutor(query, parameters);
            }
            catch (Exception ex)
            {
                throw new Exception($"Error in PresensiContext.UpdateContext(): {ex.Message}", ex);
            }
        }
    }
}
