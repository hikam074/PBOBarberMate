using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using PBOBarberMate.App.Model;
using PBOBarberMate.App.Core;
using System.Data;


namespace PBOBarberMate.App.Context
{
    public class PembayaranContext : DBService
    {
        public static DataTable getDataReservasiByNama(DateOnly tanggal, string akunFull)
        {
            StringBuilder sb = new StringBuilder();
            foreach (char c in akunFull)
            {
                sb.Append('%');
                sb.Append(c);
            }
          
            string akun = sb.ToString() + '%';
            // Membuat DataTable
            DataTable tabelReservasi = new DataTable();
            tabelReservasi.Columns.Add("ID Reservasi", typeof(int));
            tabelReservasi.Columns.Add("Nama",typeof(string));
            tabelReservasi.Columns.Add("Waktu", typeof(string));
            tabelReservasi.Columns.Add("Layanan", typeof(string));
            tabelReservasi.Columns.Add("Harga", typeof(int));

            string query = "SELECT r.id_reservasi, a.nama_akun, r.waktu, l.nama_layanan, l.harga FROM reservasi r JOIN layanan l ON (r.id_layanan = l.id_layanan) JOIN akun a ON (r.id_akun = a.id_akun) WHERE a.nama_akun ILIKE @id AND r.tanggal = @tanggal";
            NpgsqlParameter[] parameters = new NpgsqlParameter[]
            {
                new NpgsqlParameter("@id", akun),
                new NpgsqlParameter("@tanggal", tanggal)
            };
            try
            {
                // mendapatkan data layanan
                using (NpgsqlDataReader reader = queryExecutor(query, parameters))
                {
                    while (reader.Read())
                    {
                        // mendapatkan id_reservasi
                        int id_reservasi = reader.GetInt32(0);
                        // mendapatkan nama_akun
                        string nama_akun = reader.GetString(1);
                        // mendapatkan waktu
                        TimeSpan waktuSpan = reader.GetTimeSpan(2);
                        TimeOnly waktu = TimeOnly.FromTimeSpan(waktuSpan);
                        // mendapatkan nama_layanan
                        string nama_layanan = reader.GetString(3);
                        // mendapatkan data harga
                        int harga = reader.GetInt32(4);
                        // menambahkan data ke list
                        tabelReservasi.Rows.Add(id_reservasi, nama_akun, waktu.ToString("HH:mm"), nama_layanan, harga);
                    }
                }
                // mengambalikan list
                return tabelReservasi;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Terjadi kesalahan [PBOBrberMate.App.Context.ReservasiContext.getDataLayananByIdNama]: {ex}");
                return null;
            }
        }
    }
}
