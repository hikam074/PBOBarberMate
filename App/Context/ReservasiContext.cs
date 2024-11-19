using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Npgsql;
using PBOBarberMate.App.Core;
using PBOBarberMate.App.Model;
using PBOBarberMate.View;


namespace PBOBarberMate.App.Context
{
    public class ReservasiContext : DBService
    {
        public static List<KeyValuePair<int, string>> getDataLayananByIdNama()
        {
            var listLayanan = new List<KeyValuePair<int, string>>();
            string query = "SELECT id_layanan, nama_layanan FROM layanan";
            try
            {
                using (NpgsqlDataReader reader = queryExecutor(query))
                {
                    while (reader.Read())
                    {
                        int id_layanan = reader.GetInt32(0);
                        string nama_layanan = reader.GetString(1);
                        listLayanan.Add(new KeyValuePair<int, string>(id_layanan, nama_layanan));
                    }
                }
                return listLayanan;
            }
            catch (Exception ex)
            {
                throw new Exception($"Terjadi kesalahan [.App.Context.ReservasiContext]: {ex.Message}");
                return null;
            }
        }
        public static List<string> getDataWaktuByTanggal()
        {
            string query = "SELECT waktu FROM reservasi WHERE tanggal = @tanggal";



            return null;
        }
        //public bool addreservasi(M_Akun akun)
        //{

        //}
    }
}
