using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace PBOBarberMate.Infrastructure.Repositories
{
    using Npgsql;
    using PBOBarberMate.Core.Entities;
    using PBOBarberMate.Core.Interfaces;
    using PBOBarberMate.Infrastructure.Database;

    public class InventoryRepository : IInventoryRepository
    {
        public List<M_Inventory> GetAll()
        {
            string sql = "SELECT i.*, a.nama as nama_pengelola FROM inventory i LEFT JOIN akun a ON i.id_akun_pengelola = a.id_akun";
            DataTable dt = DB_Executor.ExecuteQuery(sql);
            List<M_Inventory> list = new List<M_Inventory>();

            foreach (DataRow row in dt.Rows)
            {
                list.Add(new M_Inventory
                {
                    IdBarang = (int)row["id_barang"],
                    NamaBarang = row["nama_barang"].ToString(),
                    Stok = (int)row["stok"],
                    Satuan = row["satuan"].ToString(),
                    NamaPengelola = row["nama_pengelola"].ToString()
                });
            }
            return list;
        }
        public bool Insert(M_Inventory barang)
        {
            string sql = "INSERT INTO inventory (nama_barang, stok, satuan, id_akun_pengelola) VALUES (@nama, @stok, @satuan, @adminId)";
            var p = new NpgsqlParameter[] {
                new NpgsqlParameter("@nama", barang.NamaBarang),
                new NpgsqlParameter("@stok", barang.Stok),
                new NpgsqlParameter("@satuan", barang.Satuan),
                new NpgsqlParameter("@adminId", barang.IdAkunPengelola)
            };
            return DB_Executor.ExecuteNonQuery(sql, p) > 0;
        }
        public bool Update(M_Inventory barang)
        {
            string sql = "UPDATE inventory SET nama_barang = @namaBarang, stok = @jumlahStok, satuan = @satuan WHERE id_barang = @idBarang";
            var p = new NpgsqlParameter[]
            {
                new NpgsqlParameter("@namaBarang", barang.NamaBarang),
                new NpgsqlParameter("@jumlahStok", barang.Stok),
                new NpgsqlParameter("@satuan", barang.Satuan),
                new NpgsqlParameter("@idBarang", barang.IdBarang)
            };
            return DB_Executor.ExecuteNonQuery(sql, p) > 0;
        }
        public bool UpdateStok(int idBarang, int jumlahStok)
        {
            string sql = "UPDATE inventory SET stok = @jumlahStok WHERE id_barang = @idBarang";
            var p = new NpgsqlParameter[]
            {
                new NpgsqlParameter("@jumlahStok", jumlahStok),
                new NpgsqlParameter("@idBarang", idBarang)
            };
            return DB_Executor.ExecuteNonQuery(sql, p) > 0;
        }
        public bool Delete(int idBarang)
        {
            string sql = "DELETE FROM inventory WHERE id_barang = @idBarang";
            var p = new NpgsqlParameter[]
            {
                new NpgsqlParameter("@idBarang", idBarang)
            };
            return DB_Executor.ExecuteNonQuery(sql, p) > 0;
        }
    }
}
