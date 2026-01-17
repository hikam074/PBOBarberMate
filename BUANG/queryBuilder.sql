-- Tabel akun_role (untuk menyimpan definisi role, CONST)
CREATE TABLE akun_role (
    id_role SERIAL PRIMARY KEY,
    nama_role VARCHAR(50) NOT NULL UNIQUE
);
INSERT INTO akun_role (nama_role) VALUES ('admin'), ('karyawan'), ('customer');

-- Tabel akun
CREATE TABLE akun (
    id_akun SERIAL PRIMARY KEY,
    nama_akun VARCHAR(100) NOT NULL,
    username VARCHAR(100) NOT NULL UNIQUE,
    email VARCHAR(100) NOT NULL UNIQUE,
    password VARCHAR(255) NOT NULL, -- Simpan hash password SHA256 disini
    id_role INTEGER NOT NULL REFERENCES akun_role(id_role)
);
INSERT INTO akun (nama_akun, username, email, password, akun_role_id) VALUES
('Admin User', '1', 'admin@barbermate.com', '6b86b273ff34fce19d6b804eff5a3f5747ada4eaa22f1d49c01e52ddb7875b4b', 1),
('Karyawan John', '2', 'john@barbermate.com', 'd4735e3a265e16eee03f59718b9b5d03019c07d8b6c51f90da3a666eec13ab35', 2),
('Customer Alice', '3', 'alice@barbermate.com', '4e07408562bedb8b60ce05c1decfe3ad16b72230967de01f640b7e4729b49fce', 3),
('hikam074', 'hikam074', 'hikam123@gmail.com', '9dd768dcda7a1a26bd07b09bee193c11ffd7bc71a501f5bf6e26351186e1fdd7', 3),
('brilsyah', 'brilsyah', 'brilsyah@gmail.com', '0e7639fbab36f9bf959f09c889b944a688941eb72ac2ba712d6523d17263b974', 3);

-- Tabel meja_barber
CREATE TABLE meja_barber (
    id_meja SERIAL PRIMARY KEY,
    nama_meja VARCHAR(50) NOT NULL UNIQUE,
    id_karyawan INTEGER NOT NULL REFERENCES akun(id_akun)
);

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
    id_akun INTEGER NOT NULL REFERENCES akun(id_akun), -- FK ke akun (karyawan)
    id_hari INTEGER NOT NULL REFERENCES detail_hari(id_hari), -- FK ke detail_hari
    is_active BOOLEAN NOT NULL DEFAULT true
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

-- 8. Tabel reservasi_status (untuk status reservasi, CONST)
CREATE TABLE reservasi_status (
    id_status_reservasi SERIAL PRIMARY KEY,
    nama_status_reservasi VARCHAR(50) NOT NULL UNIQUE
);
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

