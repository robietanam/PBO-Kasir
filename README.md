# PBO-Kasir

-- DDL COPAS INI--
-- Nama Database Kasir_PBO
-- Buka dulu readme nya jangan langsung copas--
CREATE TABLE barang (
    kode_barang VARCHAR(100) NOT NULL,
    nama_barang VARCHAR(255) NOT NULL,
    harga_dasar numeric(30, 2) NOT NULL,
    harga_jual  numeric(30, 2) NOT NULL,
    stok        INTEGER NOT NULL,
    kategori_id_kategori VARCHAR(100) NOT NULL
);

ALTER TABLE barang ADD CONSTRAINT barang_pk PRIMARY KEY ( kode_barang,
                                                          kategori_id_kategori );

CREATE TABLE kasbon (
    kode_kasbon    VARCHAR(100) NOT NULL,
    nama_bon       VARCHAR(255) NOT NULL,
    atas_nama      VARCHAR(255) NOT NULL,
    jumlah_bon     numeric(30, 2) NOT NULL,
    tanggal_pinjam DATE NOT NULL,
    tenggat_bayar  DATE NOT NULL
);

ALTER TABLE kasbon ADD CONSTRAINT kasbon_pk PRIMARY KEY ( kode_kasbon );

CREATE TABLE kategori (
    id_kategori VARCHAR(100) NOT NULL
);

ALTER TABLE kategori ADD CONSTRAINT kategori_pk PRIMARY KEY ( id_kategori );

CREATE TABLE transaksi (
    id_transaksi      serial NOT NULL,
    jenis_transaksi   VARCHAR(255) NOT NULL,
    nama_pelanggan    VARCHAR(255) NOT NULL Default 'No Name',
    jumlah_pemasukan  numeric(30, 2) NOT NULL,
    tanggal_transaksi DATE NOT NULL Default NOW() ,
    kode_barang       VARCHAR(100),
    kode_kasbon       VARCHAR(100)
);
ALTER TABLE transaksi ADD CONSTRAINT transaksi_pk PRIMARY KEY ( id_transaksi );

CREATE TABLE user_login (
    no_index INTEGER NOT NULL,
    username VARCHAR(255) NOT NULL,
    password VARCHAR(100) NOT NULL
);

ALTER TABLE user_login ADD CONSTRAINT user_login_pk PRIMARY KEY ( no_index );

insert into user_login values ('1','Test','123');
insert into kategori values ('Tanpa Kategori');

