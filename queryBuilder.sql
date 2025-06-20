-- Buat Tipe ENUM untuk akun_role
CREATE TYPE akun_role_enum AS ENUM ('admin', 'karyawan', 'customer');

-- 1. Tabel akun_role (untuk menyimpan definisi role)
CREATE TABLE akun_role (
    id_role SERIAL PRIMARY KEY,
    nama_role VARCHAR(50) NOT NULL UNIQUE
);

-- Masukkan data role
INSERT INTO akun_role (nama_role) VALUES ('admin'), ('karyawan'), ('customer');

-- 2. Tabel akun
CREATE TABLE akun (
    id_akun SERIAL PRIMARY KEY,
    nama_akun VARCHAR(100) NOT NULL,
    email VARCHAR(100) NOT NULL UNIQUE,
    password VARCHAR(255) NOT NULL, -- Simpan hash password di sini
    akun_role_id INTEGER NOT NULL,
    FOREIGN KEY (akun_role_id) REFERENCES akun_role(id_role)
);

-- Masukkan akun dummy (password harus di-hash, contoh ini hanya untuk ilustrasi)
INSERT INTO akun (nama_akun, email, password, akun_role_id) VALUES
('Admin User', 'admin@barbermate.com', '32a0c44c5c7d853e5e43a9f0f12c6a0c2e366b5b5c92c5a08343167727e02e1c', 1),
('Karyawan John', 'john@barbermate.com', '928d363b9f485145b20677464ce74c3d25ad9116e11893c8375a0c326d97c36a', 2),
('Customer Alice', 'alice@barbermate.com', '7c4a8d09ca3762af61e59520943dc26494f8941ba9241f80211f56b9c97c17d2', 3),
('hikam074', 'hikam123@gmail.com', '7c4a8d09ca3762af61e59520943dc26494f8941ba9241f80211f56b9c97c17d2', 3),
('brilsyah', 'brilsyah@gmail.com', 'f49747976e534f37e4cf0cf1d93b1641a052ff3997d9ce9c39830835f83c1aa0', 3);


-- 3. Tabel inventaris
CREATE TABLE inventaris (
    id_barang SERIAL PRIMARY KEY,
    nama_barang VARCHAR(100) NOT NULL,
    jumlah_barang INTEGER NOT NULL DEFAULT 0
);

-- 4. Tabel layanan
CREATE TABLE layanan (
    id_layanan SERIAL PRIMARY KEY,
    nama_layanan VARCHAR(100) NOT NULL,
    harga INTEGER NOT NULL
);

-- 5. Tabel detail_hari (untuk Hari dalam Shift)
CREATE TABLE detail_hari (
    id_hari SERIAL PRIMARY KEY,
    nama_hari VARCHAR(20) NOT NULL UNIQUE,
    hari_sql INTEGER NOT NULL UNIQUE -- Untuk mapping ke EXTRACT(DOW FROM CURRENT_DATE) (0=Minggu, 1=Senin, ..., 6=Sabtu)
);

-- Masukkan data hari
INSERT INTO detail_hari (nama_hari, hari_sql) VALUES
('minggu', 0), ('senin', 1), ('selasa', 2), ('rabu', 3), ('kamis', 4), ('jumat', 5), ('sabtu', 6);

-- 6. Tabel shift_karyawan
CREATE TABLE shift_karyawan (
    id_shift SERIAL PRIMARY KEY,
    id_akun INTEGER NOT NULL, -- FK ke akun (karyawan)
    id_hari INTEGER NOT NULL, -- FK ke detail_hari
    FOREIGN KEY (id_akun) REFERENCES akun(id_akun),
    FOREIGN KEY (id_hari) REFERENCES detail_hari(id_hari)
);

-- 7. Tabel presensi
CREATE TABLE presensi (
    id_presensi SERIAL PRIMARY KEY,
    id_akun INTEGER NOT NULL, -- FK ke akun (karyawan)
    id_shift INTEGER NOT NULL, -- FK ke shift_karyawan (opsional, bisa juga ke detail_hari langsung jika presensi tidak selalu terkait shift spesifik)
    waktu_presensi TIMESTAMP NOT NULL DEFAULT CURRENT_TIMESTAMP,
    FOREIGN KEY (id_akun) REFERENCES akun(id_akun),
    FOREIGN KEY (id_shift) REFERENCES shift_karyawan(id_shift)
);

-- 8. Tabel reservasi_status (untuk status reservasi)
CREATE TABLE reservasi_status (
    id_status_reservasi SERIAL PRIMARY KEY,
    nama_status_reservasi VARCHAR(50) NOT NULL UNIQUE
);

-- Masukkan data status reservasi
INSERT INTO reservasi_status (nama_status_reservasi) VALUES ('dijadwalkan'), ('selesai'), ('dibatalkan');

-- 9. Tabel reservasi
CREATE TABLE reservasi (
    id_reservasi SERIAL PRIMARY KEY,
    id_akun INTEGER NOT NULL,     -- FK ke akun (customer)
    id_karyawan INTEGER NOT NULL, -- FK ke akun (karyawan)
    id_layanan INTEGER NOT NULL,  -- FK ke layanan
    tanggal DATE NOT NULL,
    waktu TIME NOT NULL,
    tanggal_melakukan_reservasi TIMESTAMP NOT NULL DEFAULT CURRENT_TIMESTAMP,
    id_status_reservasi INTEGER NOT NULL, -- FK ke reservasi_status
    nomor_meja INTEGER, -- Jika ada konsep meja barber yang berbeda
    FOREIGN KEY (id_akun) REFERENCES akun(id_akun),
    FOREIGN KEY (id_karyawan) REFERENCES akun(id_akun),
    FOREIGN KEY (id_layanan) REFERENCES layanan(id_layanan),
    FOREIGN KEY (id_status_reservasi) REFERENCES reservasi_status(id_status_reservasi)
);

-- 10. Tabel metode_pembayaran
CREATE TABLE metode_pembayaran (
    id_metode_pembayaran SERIAL PRIMARY KEY,
    nama_metode_pembayaran VARCHAR(50) NOT NULL UNIQUE
);

-- Masukkan data metode pembayaran
INSERT INTO metode_pembayaran (nama_metode_pembayaran) VALUES ('transfer'), ('tunai'), ('e-wallet');

-- 11. Tabel pembayaran
CREATE TABLE pembayaran (
    id_pembayaran SERIAL PRIMARY KEY,
    id_reservasi INTEGER NOT NULL, -- FK ke reservasi
    harga INTEGER NOT NULL,
    id_metode_pembayaran INTEGER NOT NULL, -- FK ke metode_pembayaran
    tanggal_dibayar TIMESTAMP NOT NULL DEFAULT CURRENT_TIMESTAMP,
    FOREIGN KEY (id_reservasi) REFERENCES reservasi(id_reservasi),
    FOREIGN KEY (id_metode_pembayaran) REFERENCES metode_pembayaran(id_metode_pembayaran)
);

-- 12. Tabel ulasan
CREATE TABLE ulasan (
    id_ulasan SERIAL PRIMARY KEY,
    id_pembayaran INTEGER NOT NULL, -- FK ke pembayaran
    rating INTEGER NOT NULL CHECK (rating >= 1 AND rating <= 5),
    isi_ulasan TEXT,
    tanggal_memberi_ulasan TIMESTAMP NOT NULL DEFAULT CURRENT_TIMESTAMP,
    FOREIGN KEY (id_pembayaran) REFERENCES pembayaran(id_pembayaran)
);

-- 13. Tabel meja_barber (tambahan jika setiap karyawan barber punya meja spesifik)
-- Asumsi setiap meja hanya bisa dipegang oleh 1 karyawan pada satu waktu.
CREATE TABLE meja_barber (
    id_meja SERIAL PRIMARY KEY,
    nama_meja VARCHAR(50) NOT NULL UNIQUE,
    id_karyawan INTEGER UNIQUE, -- FK ke akun (karyawan)
    FOREIGN KEY (id_karyawan) REFERENCES akun(id_akun)
);