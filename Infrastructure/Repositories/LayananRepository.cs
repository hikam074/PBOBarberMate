using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace PBOBarberMate.Infrastructure.Repositories
{
    using PBOBarberMate.Core.Entities;
    using PBOBarberMate.Core.Interfaces;
    using PBOBarberMate.Infrastructure.Database;
    
    public class LayananRepository : ILayananRepository
    {
        public List<M_Layanan> GetAll()
        {
            string sql = "SELECT * FROM layanan";
            DataTable dt = DB_Executor.ExecuteQuery(sql);
            List<M_Layanan> list = new List<M_Layanan>();

            foreach (DataRow row in dt.Rows)
            {
                list.Add(new M_Layanan()
                {
                    IdLayanan = (int)row["id_layanan"],
                    NamaLayanan = row["nama_layanan"].ToString(),
                    Harga = (decimal)row["harga"],
                    Deskripsi = row["deskripsi"].ToString()
                });
            }
            return list;
        }
        public bool Insert(M_Layanan layanan)
        {
            string sql = "INSERT INTO layanan (nama_layanan, harga, deskripsi) VALUES (@nama, @harga, @deskripsi)";
            var p = new NpgsqlParameter[] {
                new NpgsqlParameter("@nama", layanan.NamaLayanan),
                new NpgsqlParameter("@harga", layanan.Harga),
                new NpgsqlParameter("@deskripsi", layanan.Deskripsi)
            };
            return DB_Executor.ExecuteNonQuery(sql, p) > 0;
        }
        public bool Update(M_Layanan layanan)
        {
            string sql = "UPDATE layanan SET nama_layanan = @namaLayanan, harga = @harga, deskripsi = @deskripsi WHERE id_layanan = @idLayanan";
            var p = new NpgsqlParameter[]
            {
                new NpgsqlParameter("@namaLayanan", layanan.NamaLayanan),
                new NpgsqlParameter("@harga", layanan.Harga),
                new NpgsqlParameter("@deskripsi", layanan.Deskripsi),
                new NpgsqlParameter("@idLayanan", layanan.IdLayanan)
            };
            return DB_Executor.ExecuteNonQuery(sql, p) > 0;
        }
        public bool Delete(int idLayanan)
        {
            string sql = "DELETE FROM layanan WHERE id_layanan = @idLayanan";
            var p = new NpgsqlParameter[]
            {
                new NpgsqlParameter("@idLayanan", idLayanan)
            };
            return DB_Executor.ExecuteNonQuery(sql, p) > 0;
        }
    }
}