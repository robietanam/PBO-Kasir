# PBO-Kasir

-- DDL COPAS INI--
-- Nama Database Kasir_PBO
-- Buka dulu readme nya jangan langsung copas--
CREATE TABLE barang (
    kode_barang          VARCHAR(100) NOT NULL,
    nama_barang          VARCHAR(255) NOT NULL,
    harga_dasar          numeric(30,2) NOT NULL,
    harga_jual           numeric(30,2) NOT NULL,
    stok                 INTEGER NOT NULL,
    kategori_id_kategori VARCHAR(100)
);

ALTER TABLE barang ADD CONSTRAINT barang_pk PRIMARY KEY ( kode_barang );


CREATE TABLE kasbon (
    kode_kasbon    VARCHAR(100) NOT NULL,
    nama_bon       VARCHAR(255) NOT NULL,
    atas_nama      VARCHAR(255) NOT NULL,
    jumlah_bon	   numeric(30,2) NOT NULL,
    tanggal_pinjam DATE NOT NULL Default Now()::date,
    tenggat_bayar  DATE NOT NULL
);

ALTER TABLE kasbon ADD CONSTRAINT kasbon_pk PRIMARY KEY ( kode_kasbon );

CREATE TABLE kategori (
    id_kategori   VARCHAR(100) NOT NULL
);

ALTER TABLE kategori ADD CONSTRAINT kategori_pk PRIMARY KEY ( id_kategori );

CREATE TABLE transaksi (
    id_transaksi       Serial  ,
    jenis_transaksi    VARCHAR(255) NOT NULL,
    nama_pelanggan     VARCHAR(255) NOT NULL Default 'Unknown',
    jumlah_pemasukan   Money NOT NULL,
    Tanggal_Transaksi  DATE NOT NULL Default Now()::date,
    barang_kode_barang VARCHAR(100),
    kasbon_kode_kasbon VARCHAR(100)
);

ALTER TABLE transaksi ADD CONSTRAINT transaksi_pk PRIMARY KEY ( id_transaksi );

ALTER TABLE barang
    ADD CONSTRAINT barang_kategori_fk FOREIGN KEY ( kategori_id_kategori )
        REFERENCES kategori ( id_kategori );

ALTER TABLE transaksi
    ADD CONSTRAINT transaksi_barang_fk FOREIGN KEY ( barang_kode_barang )
        REFERENCES barang ( kode_barang );

ALTER TABLE transaksi
    ADD CONSTRAINT transaksi_kasbon_fk FOREIGN KEY ( kasbon_kode_kasbon )
        REFERENCES kasbon ( kode_kasbon );
