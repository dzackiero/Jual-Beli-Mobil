create database if not exists jualbelimobil;
use jualbelimobil;
drop table if exists buku_penjualan;
drop table if exists pembeli;
drop table if exists mobil;
drop table if exists jenis_mobil;
drop table if exists users;
create table users(
	id_user int unsigned AUTO_INCREMENT PRIMARY KEY,
	username varchar(30) unique,
    
    email varchar(50),
    pw varchar(30)
);
create table jenis_mobil(
	id_jenis int unsigned AUTO_INCREMENT PRIMARY KEY,
    jenis varchar(30)
);
create table mobil(
	id_mobil int unsigned AUTO_INCREMENT primary key,
    id_jenis_mobil int unsigned,
    foreign key(id_jenis_mobil) references jenis_mobil(id_jenis),
    tipe_mobil varchar(30),
    tahun_pembuatan int,
    kondisi varchar(30),
    harga int,
    garansi int,/*bulan*/
    status_terjual tinyint,
    harga_default int
);
create table pembeli(
	id_pembeli int unsigned AUTO_INCREMENT primary key,
    nik int unique,
    nama varchar(30),
    alamat varchar(50)
);
create table buku_penjualan(
	id_penjualan int unsigned AUTO_INCREMENT primary key,
    id_mobil int unsigned,
    foreign key(id_mobil) references mobil(id_mobil),
    
    id_pembeli int unsigned,
    foreign key(id_pembeli) references pembeli(id_pembeli),
    harga_terjual int,
    tanggal_penjualan date
);
