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
using PBOBarberMate.View.FormReservasi;


namespace PBOBarberMate.App.Context
{
    public class ReservasiContext : DBService
    {
        public static List<KeyValuePair<int, string>> getDataLayananByIdNama()
        {
            // membuat list wadah
            var listLayanan = new List<KeyValuePair<int, string>>();
            string query = "SELECT id_layanan, nama_layanan FROM layanan";
            try
            {
                // mendapatkan data layanan
                using (NpgsqlDataReader reader = queryExecutor(query))
                {
                    while (reader.Read())
                    {
                        // mendapatkan id_layanan
                        int id_layanan = reader.GetInt32(0);
                        // mendapatkan nama_layanan
                        string nama_layanan = reader.GetString(1);
                        // menambahkan id_layanan, nama_layanan ke wadah
                        listLayanan.Add(new KeyValuePair<int, string>(id_layanan, nama_layanan));
                    }
                }
                // mengambalikan list
                return listLayanan;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Terjadi kesalahan [PBOBrberMate.App.Context.ReservasiContext.getDataLayananByIdNama]: {ex}");
                return null;
            }
        }

        public static List<string> getDataWaktuByTanggal(DateTime tanggal)
        {
            try
            {
                // buka jam 08.00 berdasarkan studi kasus
                int openJam = 8;
                // tutup jam 21.00 berdasarkan studi kasus, sehingga layanan diasumsikan 1 jam maka maksimal reservasi pukul 20.00
                int closeJam = 20;
                // wadah jam-jam berapa sayang tersedia
                List<string> slotJam = new List<string>();
                // membuat jam dari 08.00 - 21.00 per jam
                for (int hour = openJam; hour <= closeJam; hour++)
                {
                    for (int minute = 0; minute < 60; minute += 60)
                    {
                        // menambahkan jam ke wadah
                        slotJam.Add($"{hour:D2}:{minute:D2}");
                    }
                }

                string query = "SELECT waktu FROM reservasi WHERE tanggal = @tanggal";
                NpgsqlParameter[] parameters = new NpgsqlParameter[]
                {
                    new NpgsqlParameter("@tanggal", tanggal.Date)
                };
                // wadah jam berapa saya yang telah direservasi
                List<string> waktuTelahDireservasi = new List<string>();
                // mendapatkan jam-jam yang telah direservasi
                using (NpgsqlDataReader reader = queryExecutor(query, parameters))
                {
                    while (reader.Read())
                    {
                        TimeSpan waktu = reader.GetFieldValue<TimeSpan>(0);
                        string waktuString = waktu.ToString(@"hh\:mm");
                        // menambahkan data jam-jam yang telah direservasi ke wadah
                        waktuTelahDireservasi.Add(waktuString);
                    }
                }
                // menghapus jam-jam di wadah alljam yang telah direservasi, menyisakan jam yang benar-benar tersedia
                slotJam.RemoveAll(time => waktuTelahDireservasi.Contains(time));
                // mengembalikan jam sisa tersedia
                return slotJam;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Terjadi kesalahan [PBOBrberMate.App.Context.ReservasiContext.getDataWaktuByTanggal]: {ex}");
                return null;
            }
        }

        public static List<int> getKaryawanTersedia(DateOnly tanggal, TimeOnly waktu)
        {
            try
            {
                // membuat wadah list karyawan yang kosong di tanggal, jam itu
                List<int> idKaryawanTersedia = new List<int>();
                // casting waktu agarbisa dipakai di db
                DateTime date_time = tanggal.ToDateTime(waktu);
                string query = "SELECT id_karyawan FROM reservasi WHERE tanggal = @tanggal AND waktu = @waktu";
                NpgsqlParameter[] parameters = new NpgsqlParameter[]
                {
                    new NpgsqlParameter("@tanggal", date_time.Date),
                    new NpgsqlParameter("@waktu", date_time.TimeOfDay)
                };
                // mendapatkan id karyawan-karyawan mana yang tidak kosong di tanggal,waktu itu dari db reservasi
                using (NpgsqlDataReader reader = queryExecutor(query, parameters))
                {
                    // membuat wadah set id karyawan yang tidak kosong
                    HashSet<int> karyawanTerjadwal = new HashSet<int>();
                    while (reader.Read())
                    {
                        // menambahkan id karyawan-laryawan yang tidak kosong ke wadah set
                        karyawanTerjadwal.Add(reader.GetInt32(0));
                    }
                    string queryKaryawan = "SELECT id_akun FROM akun WHERE akun_role_id = @role";
                    NpgsqlParameter[] parametersKaryawan = new NpgsqlParameter[]
                    {
                        new NpgsqlParameter("@role", (int)AkunRole.Karyawan)
                    };
                    // mendapatkan id akun dari karyawan itu dari db akun
                    using (NpgsqlDataReader readerKaryawan = queryExecutor(queryKaryawan, parametersKaryawan))
                    {
                        while (readerKaryawan.Read())
                        {
                            int idKaryawan = readerKaryawan.GetInt32(0);
                            // bila karyawan itu tidak terjadwal di tanggal,waktu itu dan ada nomor mejanya
                            if (!karyawanTerjadwal.Contains(idKaryawan) && getNomorMeja(idKaryawan) != -1)
                            {
                                // menambahkan data karyawan yang free
                                idKaryawanTersedia.Add(idKaryawan);
                            }
                        }
                    }
                }
                // mengembalikan data karyawan yang free
                return idKaryawanTersedia;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Terjadi kesalahan [PBOBrberMate..App.Context.ReservasiContext.getKaryawanTersedia]: {ex}");
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
            // mendapatkan idmeja dari karyawan
            using (NpgsqlDataReader reader = queryExecutor(query, parameters))
            {
                if (reader.Read())
                {
                    // memiliki nomor meja, mengembalikan nomor meja
                    return reader.GetInt32(0);
                }
                else
                {
                    // tidak memiliki nomor meja (berati bukan barbernya)
                    return -1;
                }
            }
        }

        public static bool addreservasi(M_Reservasi reservasi)
        {
            try
            {
                // membuat wadah list karyawan yang tersedia
                List<int> karyawanTersedia = getKaryawanTersedia(reservasi.tanggal_direservasi, reservasi.waktu_direservasi);
                if (karyawanTersedia.Count == 0)
                {
                    // tidak ada karyawan yang kosong di tanggal,waktu itu
                    MessageBox.Show("Mohon Maaf tidak ada barber yang tersedia di waktu yang anda pilih! Silahkan pilih waktu dan/atau tanggal lain");
                    return false;
                }
                // ada karyawan yang kosong di tanggal,waktu itu
                else
                {
                    // memakai randomisasi
                    Random random = new Random();
                    // memilih karyawan tersedia secara random
                    int karyawanDipilih = karyawanTersedia[random.Next(karyawanTersedia.Count)];
                    // membaut object reservasi
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
                    // menambahkan data ke db
                    int rowsAffected = commandExecutor(query, parameters);
                    // bilaberhasil menambahkan data
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
                MessageBox.Show($"Terjadi Kesalahan [PBOBrberMate..App.Context.ReservasiContext.addReservasi]: {ex}");
                return false;
            }
        }

        public static DataTable getReservasiExceptSelesai(string email)
        {
            string query = $"SELECT r.id_reservasi, l.nama_layanan, r.tanggal, r.waktu, l.harga, rs.nama_status_reservasi FROM reservasi r JOIN akun a ON (r.id_akun = a.id_akun) JOIN layanan l ON (r.id_layanan = l.id_layanan) JOIN reservasi_status rs ON (r.id_status_reservasi = rs.id_status_reservasi) WHERE a.email = @email AND rs.nama_status_reservasi <> 'selesai' ORDER BY (r.tanggal - CURRENT_DATE) ASC, r.waktu ASC;";
            NpgsqlParameter[] parameters = new NpgsqlParameter[]
            {
                new NpgsqlParameter("@email", email)
            };
            try
            {
                // mendapatkan reservasi selain yang selesai dari db reservasi
                using (NpgsqlDataReader reader = queryExecutor(query, parameters))
                {
                    DataTable dataLayanan = new DataTable();
                    dataLayanan.Load(reader);
                    return dataLayanan;
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Terjadi kesalahan [PBOBrberMate.App.Context.ReservasiContext.getReservasiExceptSelesai]: {ex}");
            }
        }

        public static DataTable getReservasiAll()
        {
            string query = $"SELECT r.id_reservasi, a.nama_akun, r.id_akun, l.nama_layanan, r.tanggal, r.waktu, l.harga FROM reservasi r JOIN akun a ON (r.id_akun = a.id_akun) JOIN layanan l ON (r.id_layanan = l.id_layanan) JOIN reservasi_status rs ON (r.id_status_reservasi = rs.id_status_reservasi) WHERE rs.nama_status_reservasi = 'dijadwalkan'";
            try
            {
                // mendapatkan semua reservasi dari db
                using (NpgsqlDataReader reader = queryExecutor(query))
                {
                    DataTable dataLayanan = new DataTable();
                    dataLayanan.Load(reader);
                    return dataLayanan;
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Terjadi kesalahan [PBOBrberMate.App.Context.ReservasiContext.getReservasiAll]: {ex}");
            }
        }

        public static int updateReservasi(M_Reservasi reservasi, int id)
        {
            try
            {
                string query = $"UPDATE reservasi SET tanggal = @tanggal, waktu  = @waktu WHERE id_reservasi = @id_reservasi";
                NpgsqlParameter[] parameters =
                {
                new NpgsqlParameter("@tanggal", reservasi.tanggal_direservasi),
                new NpgsqlParameter("@waktu", reservasi.waktu_direservasi),
                new NpgsqlParameter("@id_reservasi", id)
                };
                // mengubah data reservasai yang dipilih, mengembalikan apakah berhasil atau tidak
                return commandExecutor(query, parameters);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Terjadi kesalahan [App.Context.ReservasiContext.updateReservasi] : {ex}");
                return -1;
            }
        }

        public static int batalkanReservasi(int id)
        {
            try
            {
                string query = $"UPDATE reservasi SET id_status_reservasi = @id_status WHERE id_reservasi = @id_reservasi";
                NpgsqlParameter[] parameters =
                {
                new NpgsqlParameter("@id_reservasi", id),
                new NpgsqlParameter("@id_status", (int)reservasiStatus.dibatalkan)
                };
                // membatalkan reservasi yang dipilih, mengembalikan apakah berhasil atau tidak
                return commandExecutor(query, parameters);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Terjadi kesalahan [App.Context.ReservasiContext.hapusReservasi] : {ex}");
                return -1;
            }
        }
    }
}