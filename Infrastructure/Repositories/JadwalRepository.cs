using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace PBOBarberMate.Infrastructure.Repositories
{
    using PBOBarberMate.Core.Interfaces;
    using PBOBarberMate.Core.Entities;
    using PBOBarberMate.Infrastructure.Database;
    
    public class JadwalRepository : IJadwalRepository
    {
        public List<M_Jadwal> GetAllJadwal()
        {
            string sql = "SELECT j.*, a.nama AS \"Nama Karyawan\" " +
                "FROM jadwal_karyawan j " +
                "JOIN akun a ON (j.id_akun = a.id_akun)";
            DataTable dt = DB_Executor.ExecuteQuery(sql);
            List<M_Jadwal> list = new List<M_Jadwal>();

            foreach (DataRow row in dt.Rows)
            {
                list.Add(new M_Jadwal()
                {
                    IdJadwal = row["id_jadwal"].ToString(),
                    IdAkun = (int)row["id_akun"],
                    NamaKaryawan = row["Nama Karyawan"].ToString(),
                    Hari = (int)row["hari"],
                    IsActive = (bool)row["is_active"],
                    IsTersedia = (bool)row["is_tersedia"]
                });
            }
            return list;
        }
        public bool UpsertJadwal(M_Jadwal jadwal)
        {
            string sql = "INSERT INTO jadwal_karyawan (id_jadwal, id_akun, hari, is_active) " +
                "VALUES (@idJadwal, @idAkun, @hari, @active) " +
                "ON CONFLICT (id_jadwal) DO UPDATE SET is_active = @active, is_tersedia = @tersedia";
            NpgsqlParameter[] parameters = {
                new NpgsqlParameter("@idJadwal", jadwal.IdJadwal),
                new NpgsqlParameter("@idAkun", jadwal.IdAkun),
                new NpgsqlParameter("@hari", jadwal.Hari),
                new NpgsqlParameter("@active", jadwal.IsActive),
                new NpgsqlParameter("@tersedia", jadwal.IsTersedia)
            };
            return DB_Executor.ExecuteNonQuery(sql, parameters) > 0;
        }
        public bool UpdateKetersediaan(string idJadwal, bool tersedia)
        {
            string sql = "UPDATE jadwal_karyawan SET is_available = @status WHERE id_jadwal = @id";
            NpgsqlParameter[] parameters = {
                new NpgsqlParameter("@id", idJadwal),
                new NpgsqlParameter("@status", tersedia)
            };
            return DB_Executor.ExecuteNonQuery(sql, parameters) > 0;
        }
    }
}
