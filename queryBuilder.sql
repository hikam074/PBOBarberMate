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
CREATE TABLE inventaris (
    id_barang SERIAL PRIMARY KEY,
    nama_barang VARCHAR(100) NOT NULL,
    stok INT DEFAULT 0,
    satuan VARCHAR(20), -- 'Pcs', 'Botol', dll
    id_akun_pengelola INT REFERENCES akun(id_akun), -- FK akun(id_akun)
    last_updated TIMESTAMP DEFAULT CURRENT_TIMESTAMP
);

