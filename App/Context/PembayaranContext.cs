using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using PBOBarberMate.App.Model;
using PBOBarberMate.App.Core;
using System.Data;
using PBOBarberMate.View.FormPembayaran;


namespace PBOBarberMate.App.Context
{
    public class PembayaranContext : DBService
    {
        public static DataTable getDataReservasiByNama(DateOnly tanggal, string akunFull)
        {
            // membuat realtime search method sederhana
            StringBuilder sb = new StringBuilder();
            // dengan menambahkan '%' di tiap char
            foreach (char c in akunFull)
            {
                sb.Append('%');
                sb.Append(c);
            }
            // menyatukan kembali char yang telah ditambah '%'
            string akun = sb.ToString() + '%';
            // Membuat DataTable
            DataTable tabelReservasi = new DataTable();
            // menambahkan kolom
            tabelReservasi.Columns.Add("ID Reservasi", typeof(int));
            tabelReservasi.Columns.Add("Nama",typeof(string));
            tabelReservasi.Columns.Add("Waktu", typeof(string));
            tabelReservasi.Columns.Add("Layanan", typeof(string));
            tabelReservasi.Columns.Add("Harga", typeof(int));

            string query = "SELECT r.id_reservasi, a.nama_akun, r.waktu, l.nama_layanan, l.harga FROM reservasi r JOIN layanan l ON (r.id_layanan = l.id_layanan) JOIN akun a ON (r.id_akun = a.id_akun) WHERE (a.nama_akun ILIKE @nama) AND (r.tanggal = @tanggal) AND r.id_status_reservasi = @id_status";
            NpgsqlParameter[] parameters = new NpgsqlParameter[]
            {
                new NpgsqlParameter("@nama", akun),
                new NpgsqlParameter("@tanggal", tanggal),
                new NpgsqlParameter("@id_status", (int)reservasiStatus.dijadwalkan)
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
                return tabelReservasi;
            }
        }
        public static bool addPembayaran(M_Pembayaran pembayaran)
        {
            try
            {
                string query = "INSERT INTO pembayaran (id_reservasi, harga, id_metode_pembayaran) VALUES (@id_reservasi, @harga, @id_metode_pembayaran)";
                NpgsqlParameter[] parameters = new NpgsqlParameter[]
                {
                    new NpgsqlParameter("@id_reservasi", pembayaran.idReservasi),
                    new NpgsqlParameter("@harga", pembayaran.harga),
                    new NpgsqlParameter("@id_metode_pembayaran", (int)pembayaran.metodePembayaran)
                };

                int rowsInserted = commandExecutor(query, parameters);

                string updateQuery = "UPDATE reservasi SET id_status_reservasi = @status WHERE id_reservasi = @id";
                NpgsqlParameter[] updateParameters = new NpgsqlParameter[]
                {
                    new NpgsqlParameter("@status", (int)reservasiStatus.selesai),
                    new NpgsqlParameter("id", pembayaran.idReservasi)
                };

                int rowsAffected = commandExecutor(updateQuery, updateParameters);

                return rowsInserted == rowsAffected;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Terjadi kesalahan [PBOBarberMate.App.Context.PembayaranContext.addPembayaran] : {ex}");
                return false;
            }
        }

        //public static void addHistoriPembayaran(M_HistoriPembayaran pembayaran)
        //{
        //    try
        //    {
        //        string query = "INSERT INTO histori_pembayaran (id_reservasi, harga, id_metode_pembayaran) VALUES (@id_reservasi, @harga, @id_metode_pembayaran)";
        //        NpgsqlParameter[] parameters = new NpgsqlParameter[]
        //        {
        //            new NpgsqlParameter("@id_reservasi", pembayaran.idReservasi),
        //            new NpgsqlParameter("@harga", pembayaran.harga),
        //            new NpgsqlParameter("@id_metode_pembayaran", (int)pembayaran.metodePembayaran)
        //        };
                
        //        int rowsInserted = commandExecutor(query, parameters);
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show($"Terjadi kesalahan [PBOBarberMate.App.Context.PembayaranContext.addHistoriPembayaran] : {ex}");
        //    }
        //}

        public static DataTable getDataPembayaran(int idAkun)
        {
            string query = "SELECT r.id_akun, l.nama_layanan, p.id_pembayaran, p.id_reservasi, p.harga, mp.nama_metode_pembayaran, p.tanggal_dibayar FROM pembayaran p JOIN reservasi r ON (p.id_reservasi = r.id_reservasi) JOIN layanan l ON (r.id_layanan = l.id_layanan) JOIN metode_pembayaran mp ON (p.id_metode_pembayaran = mp.id_metode_pembayaran) WHERE r.id_akun = @id";
            NpgsqlParameter[] parameters = new NpgsqlParameter[]
            {
                new NpgsqlParameter("@id", idAkun)
            };
            try
            {
                // mendapatkan semua pembayaran dari db
                using (NpgsqlDataReader reader = queryExecutor(query, parameters))
                {
                    DataTable dataPembayaran = new DataTable();
                    dataPembayaran.Load(reader);
                    return dataPembayaran;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex}");
                return null;
            }
        }
    }
}
