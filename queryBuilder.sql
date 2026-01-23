-- Tabel Master Role
CREATE TABLE roles (
    id_role SERIAL PRIMARY KEY,
    nama_role VARCHAR(20) UNIQUE NOT NULL -- 'Admin', 'Karyawan', 'Customer'
);
INSERT INTO roles (nama_role) VALUES ('Admin'), ('Karyawan'), ('Customer');

-- Tabel Akun
CREATE TABLE akun (
    id_akun SERIAL PRIMARY KEY,
    nama VARCHAR(50) NOT NULL,
    username VARCHAR(50) UNIQUE NOT NULL,
    email VARCHAR(100) UNIQUE NOT NULL,
    password TEXT NOT NULL,
    id_role INT NOT NULL REFERENCES roles(id_role) ON DELETE RESTRICT -- FK roles(id_role)
);
INSERT INTO akun (nama, username, email, password, id_role) VALUES
('Admin User', '1', 'admin@barbermate.com', '6b86b273ff34fce19d6b804eff5a3f5747ada4eaa22f1d49c01e52ddb7875b4b', 1),
('Karyawan John', '2', 'john@barbermate.com', 'd4735e3a265e16eee03f59718b9b5d03019c07d8b6c51f90da3a666eec13ab35', 2),
('Customer Alice', '3', 'alice@barbermate.com', '4e07408562bedb8b60ce05c1decfe3ad16b72230967de01f640b7e4729b49fce', 3)

-- Tabel Inventaris
CREATE TABLE inventory (
    id_barang SERIAL PRIMARY KEY,
    nama_barang VARCHAR(100) NOT NULL,
    stok INT DEFAULT 0,
    satuan VARCHAR(20), -- 'Pcs', 'Botol', dll
    id_akun_pengelola INT REFERENCES akun(id_akun), -- FK akun(id_akun)
    last_updated TIMESTAMP DEFAULT CURRENT_TIMESTAMP
);

-- Tabel Layanan
CREATE TABLE layanan (
    id_layanan SERIAL PRIMARY KEY,
    nama_layanan VARCHAR(100) NOT NULL,
    harga DECIMAL(10, 2) NOT NULL,
    deskripsi TEXT
);

-- Tabel jadwal_karyawan
CREATE TABLE jadwal_karyawan (
    id_jadwal VARCHAR(16) PRIMARY KEY, -- Natural UID (id_akun x id_hari, ex : id_akun=12 id_hari=2(selasa) id_shift = 12_2)
    id_akun INTEGER NOT NULL REFERENCES akun(id_akun) ON DELETE CASCADE, -- FK akn(id_akun)
    hari INTEGER NOT NULL CHECK (hari BETWEEN 0 AND 6), -- sesuai DayOfWeek C# : 0=minggu 1=senin dst
    is_active BOOLEAN NOT NULL DEFAULT true,
    is_tersedia BOOLEAN NOT NULL DEFAULT true,
    CONSTRAINT unique_akun_hari UNIQUE (id_akun, hari) -- make sure tambahan kombinasi id_akunxhari unique
);

