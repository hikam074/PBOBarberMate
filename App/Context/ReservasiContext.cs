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
                MessageBox.Show($"Terjadi kesalahan [.App.Context.ReservasiContext]: {ex}");
                return null;
            }
        }

        public static List<string> getDataWaktuByTanggal(DateTime tanggal)
        {
            try
            {
                int openJam = 8;
                int closeJam = 20;
                List<string> slotJam = new List<string>();

                for (int hour = openJam; hour <= closeJam; hour++)
                {
                    for (int minute = 0; minute < 60; minute += 60)
                    {
                        slotJam.Add($"{hour:D2}:{minute:D2}");
                    }
                }

                string query = "SELECT waktu FROM reservasi WHERE tanggal = @tanggal";
                NpgsqlParameter[] parameters = new NpgsqlParameter[]
                {
                    new NpgsqlParameter("@tanggal", tanggal.Date)
                };

                List<string> waktuTelahDireservasi = new List<string>();

                using (NpgsqlDataReader reader = queryExecutor(query, parameters))
                {
                    while (reader.Read())
                    {
                        TimeSpan waktu = reader.GetFieldValue<TimeSpan>(0);
                        string waktuString = waktu.ToString(@"hh\:mm");
                        waktuTelahDireservasi.Add(waktuString);
                    }
                }
                slotJam.RemoveAll(time => waktuTelahDireservasi.Contains(time));

                return slotJam;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Terjadi kesalahan [.App.Context.ReservasiContext]: {ex}");
                return null;
            }
        }

        public static List<int> getKaryawanTersedia(DateOnly tanggal, TimeOnly waktu)
        {
            try
            {
                List<int> idKaryawanTersedia = new List<int>();
                DateTime date_time = tanggal.ToDateTime(waktu);
                string query = "SELECT id_karyawan FROM reservasi WHERE tanggal = @tanggal AND waktu = @waktu";
                NpgsqlParameter[] parameters = new NpgsqlParameter[]
                {
                    new NpgsqlParameter("@tanggal", date_time.Date),
                    new NpgsqlParameter("@waktu", date_time.TimeOfDay)
                };

                using (NpgsqlDataReader reader = queryExecutor(query, parameters))
                {
                    HashSet<int> karyawanTerjadwal = new HashSet<int>();
                    while (reader.Read())
                    {
                        karyawanTerjadwal.Add(reader.GetInt32(0));
                    }
                    string queryKaryawan = "SELECT id_akun FROM akun WHERE akun_role_id = @role";
                    NpgsqlParameter[] parametersKaryawan = new NpgsqlParameter[]
                    {
                        new NpgsqlParameter("@role", (int)AkunRole.Karyawan)
                    };
                    using (NpgsqlDataReader readerKaryawan = queryExecutor(queryKaryawan, parametersKaryawan))
                    {
                        while (readerKaryawan.Read())
                        {
                            int idKaryawan = readerKaryawan.GetInt32(0);
                            if (!karyawanTerjadwal.Contains(idKaryawan) && getNomorMeja(idKaryawan) != -1)
                            {
                                idKaryawanTersedia.Add(idKaryawan);
                            }
                        }
                    }
                }
                return idKaryawanTersedia;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Terjadi kesalahan [.App.Context.ReservasiContext]: {ex}");
                return null;
            }
        }

        public static int getNomorMeja(int idKaryawan)
        {
            string query = "SELECT id_meja FROM meja_barber WHERE id_karyawan = @idKaryawan";
            NpgsqlParameter[] parameters = new NpgsqlParameter[]
            {
                new NpgsqlParameter("@idKaryawan", idKaryawan)
            };
            using (NpgsqlDataReader reader = queryExecutor(query, parameters))
            {
                if (reader.Read())
                {
                    return reader.GetInt32(0);
                }
                else
                {
                    return -1;
                }
            }
        }

        public static bool addreservasi(M_Reservasi reservasi)
        {
            try
            {

                List<int> karyawanTersedia = getKaryawanTersedia(reservasi.tanggal_direservasi, reservasi.waktu_direservasi);
                if (karyawanTersedia.Count == 0)
                {
                    MessageBox.Show("Mohon Maaf tidak ada barber yang tersedia di waktu yang anda pilih! Silahkan pilih waktu dan/atau tanggal lain");
                    return false;
                }
                else
                {

                    Random random = new Random();

                    int karyawanDipilih = karyawanTersedia[random.Next(karyawanTersedia.Count)];

                    M_Reservasi buatReservasi = new M_Reservasi(
                        reservasi.id_layanan,
                        karyawanDipilih,
                        reservasi.tanggal_direservasi,
                        reservasi.waktu_direservasi,
                        getNomorMeja(karyawanDipilih)
                        );
                    string query = "INSERT INTO reservasi(tanggal, waktu, id_akun, id_layanan, id_status_reservasi, id_karyawan) VALUES (@tanggal, @waktu, @id_akun, @id_layanan, @id_status_reservasi, @id_karyawan)";
                    NpgsqlParameter[] parameters = new NpgsqlParameter[]
                    {
                        new NpgsqlParameter("@tanggal", buatReservasi.tanggal_direservasi),
                        new NpgsqlParameter("@waktu", buatReservasi.waktu_direservasi),
                        new NpgsqlParameter("@id_akun", UserSession.idSession),
                        new NpgsqlParameter("@id_layanan", buatReservasi.id_layanan),
                        new NpgsqlParameter("@id_status_reservasi", (int)reservasiStatus.dijadwalkan),
                        new NpgsqlParameter("@id_karyawan", buatReservasi.id_karyawan)
                    };
                    int rowsAffected = commandExecutor(query, parameters);
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Reservasi Berhasil dilakukan!");
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("Terjadi kesalahan ketika menambahkan data! Coba lagi");
                        return false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Terjadi Kesalahan [.App.Context.ReservasiContext]: {ex}");
                return false;
            }
        }
    }
}