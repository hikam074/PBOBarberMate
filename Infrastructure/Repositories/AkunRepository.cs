using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBOBarberMate.Infrastructure.Repositories
{
    using PBOBarberMate.Core.Entities;
    using PBOBarberMate.Core.Interfaces;
    using PBOBarberMate.Infrastructure.Database;
    using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

    public class AkunRepository : IAkunRepository
    {
        public M_Akun GetByUsername(string username)
        {
            string sql = @"
                SELECT a.id_akun, a.nama, a.username, a.email, a.password, a.id_role, r.nama_role 
                FROM akun a
                INNER JOIN roles r ON a.id_role = r.id_role
                WHERE a.username = @username";

            var parameters = new NpgsqlParameter[] {
                new NpgsqlParameter("@username", username)
            };

            DataTable dt = DB_Executor.ExecuteQuery(sql, parameters);

            if (dt.Rows.Count > 0)
            {
                return new M_Akun
                {
                    IdAkun = (int)dt.Rows[0]["id_akun"],
                    Nama = dt.Rows[0]["nama"].ToString(),
                    Username = dt.Rows[0]["username"].ToString(),
                    Email = dt.Rows[0]["email"].ToString(),
                    Password = dt.Rows[0]["password"].ToString(),
                    IdRole = (int)dt.Rows[0]["id_role"],
                    NamaRole = dt.Rows[0]["nama_role"].ToString() // Terisi otomatis dari JOIN
                };
            }
            return null;
        }
        public M_Akun GetById(int id)
        {
            string sql = @"
                SELECT a.id_akun, a.nama, a.username, a.email, a.password, a.id_role, r.nama_role 
                FROM akun a
                INNER JOIN roles r ON a.id_role = r.id_role
                WHERE a.id_akun = @id";

            var parameters = new NpgsqlParameter[] {
                new NpgsqlParameter("@id", id)
            };

            DataTable dt = DB_Executor.ExecuteQuery(sql, parameters);

            if (dt.Rows.Count > 0)
            {
                return new M_Akun
                {
                    IdAkun = (int)dt.Rows[0]["id_akun"],
                    Nama = dt.Rows[0]["nama"].ToString(),
                    Username = dt.Rows[0]["username"].ToString(),
                    Email = dt.Rows[0]["email"].ToString(),
                    Password = dt.Rows[0]["password"].ToString(),
                    IdRole = (int)dt.Rows[0]["id_role"],
                    NamaRole = dt.Rows[0]["nama_role"].ToString() // Terisi otomatis dari JOIN
                };
            }
            return null;
        }
        public bool Insert(M_Akun akun)
        {
            string sql = "INSERT INTO akun (nama, username, email, password, id_role) VALUES (@nama, @username, @email, @password, @idRole)";
            var parameters = new NpgsqlParameter[] {
                new NpgsqlParameter("@nama", akun.Nama),
                new NpgsqlParameter("@username", akun.Username),
                new NpgsqlParameter("@email", akun.Email),
                new NpgsqlParameter("@password", akun.Password),
                new NpgsqlParameter("@idRole", akun.IdRole),
            };
            return DB_Executor.ExecuteNonQuery(sql, parameters) > 0;
        }
        public bool Update(M_Akun akun)
        {
            string sql = "UPDATE akun SET " +
                "nama = COALESCE(@nama), " +
                "username = @username, " +
                "email = @email, " +
                "password = @password " +
                "WHERE id_akun = @idAkun";
            var parameters = new NpgsqlParameter[] {
                new NpgsqlParameter("@nama", string.IsNullOrEmpty(akun.Nama) ? (object)DBNull.Value : akun.Nama),
                new NpgsqlParameter("@username", string.IsNullOrEmpty(akun.Username) ? (object)DBNull.Value : akun.Username),
                new NpgsqlParameter("@email", string.IsNullOrEmpty(akun.Email) ?(object) DBNull.Value : akun.Email),
                new NpgsqlParameter("@password", string.IsNullOrEmpty(akun.Password) ?(object) DBNull.Value : akun.Password),
                new NpgsqlParameter("@idAkun", akun.IdAkun)
            };
            return DB_Executor.ExecuteNonQuery(sql, parameters) > 0;
        }
    }
}
