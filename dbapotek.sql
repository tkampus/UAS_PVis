-- phpMyAdmin SQL Dump
-- version 5.3.0-dev+20220511.c3fb567b13
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Waktu pembuatan: 31 Bulan Mei 2022 pada 20.41
-- Versi server: 10.4.24-MariaDB
-- Versi PHP: 8.1.4

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `dbapotek`
--

-- --------------------------------------------------------

--
-- Struktur dari tabel `databarang`
--

CREATE TABLE `databarang` (
  `id_barang` int(5) UNSIGNED NOT NULL,
  `nama_barang` varchar(20) NOT NULL,
  `perusahaan` varchar(30) NOT NULL,
  `harga_beli` int(10) UNSIGNED NOT NULL,
  `harga_jual` int(10) UNSIGNED NOT NULL,
  `stock` int(3) NOT NULL,
  `exp` varchar(30) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data untuk tabel `databarang`
--

INSERT INTO `databarang` (`id_barang`, `nama_barang`, `perusahaan`, `harga_beli`, `harga_jual`, `stock`, `exp`) VALUES
(1, 'Paracetamol', 'PT. Kimia Farma', 8000, 10000, 30, '2022-12-31'),
(2, 'Aspirin', 'PT. Kimia Farma', 2000, 5000, 12, '2022-06-10'),
(3, 'Nerilon', 'PT. Interbat', 55000, 67000, 24, '2023-05-19'),
(4, 'Mometason', 'PT. Ferron Par', 43000, 50000, 24, '2023-12-27'),
(5, 'Cetirizine', 'Sampharindo Perdana', 3000, 5000, 10, '2022-08-27'),
(6, 'Methlyprednisolone', 'Hexpharm Jaya', 8000, 12000, 12, '2022-10-11'),
(7, 'Domperidone', 'PT. Pharmaceuticals', 5000, 9000, 20, '2022-11-25'),
(8, 'Paramex', 'PT. Interbat', 1000, 3000, 50, '2026-07-01'),
(9, 'Imboost', 'Hexpham Jaya', 15000, 21500, 16, '2022-08-26'),
(10, 'Stimuno', 'PT. Anak Sehat', 20000, 28000, 15, '2022-10-13'),
(11, 'Captopril', 'PT. Ferron Par', 500, 1000, 50, '2022-08-23'),
(12, 'Amlodipine', 'PT. Interbat', 1500, 2500, 25, '2024-03-06'),
(13, 'Aspirin', 'Sampharindo Perdana', 4000, 7000, 32, '2023-12-22'),
(14, 'Asetomifen', 'PT. Kimia Farma', 15000, 20000, 22, '2023-09-27'),
(15, 'Diazepam', 'PT. Xerona ', 25000, 35000, 15, '2022-09-30');

-- --------------------------------------------------------

--
-- Struktur dari tabel `detail_transaksi`
--

CREATE TABLE `detail_transaksi` (
  `id_detail` int(11) NOT NULL,
  `id_transaksi` varchar(30) NOT NULL,
  `id_barang` int(11) NOT NULL,
  `jumlah_item` int(11) NOT NULL,
  `harga_jual` int(11) NOT NULL,
  `subtotal` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data untuk tabel `detail_transaksi`
--

INSERT INTO `detail_transaksi` (`id_detail`, `id_transaksi`, `id_barang`, `jumlah_item`, `harga_jual`, `subtotal`) VALUES
(1, '637896429412278363', 3, 1, 67000, 67000),
(2, '637896429412278363', 4, 1, 50000, 50000),
(3, '637896430701591523', 2, 2, 5000, 10000),
(4, '637896433066531933', 15, 1, 35000, 35000),
(5, '637896433575276956', 11, 1, 1000, 1000),
(6, '637896433575276956', 2, 1, 5000, 5000),
(7, '637896433575276956', 8, 1, 3000, 3000),
(8, '637896434267293530', 9, 1, 21500, 21500);

-- --------------------------------------------------------

--
-- Struktur dari tabel `transaksi`
--

CREATE TABLE `transaksi` (
  `id_transaksi` varchar(30) NOT NULL,
  `waktu_transaksi` datetime NOT NULL,
  `total_belanja` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data untuk tabel `transaksi`
--

INSERT INTO `transaksi` (`id_transaksi`, `waktu_transaksi`, `total_belanja`) VALUES
('637896429412278363', '2022-06-01 01:16:44', 117000),
('637896430701591523', '2022-06-01 01:18:04', 10000),
('637896433066531933', '2022-06-01 01:22:09', 35000),
('637896433575276956', '2022-06-01 01:23:37', 9000),
('637896434267293530', '2022-06-01 01:23:55', 21500);

-- --------------------------------------------------------

--
-- Struktur dari tabel `user`
--

CREATE TABLE `user` (
  `id_user` int(5) NOT NULL,
  `username` varchar(8) NOT NULL,
  `password` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data untuk tabel `user`
--

INSERT INTO `user` (`id_user`, `username`, `password`) VALUES
(1, 'admin', '21232f297a57a5a743894a0e4a801fc3'),
(2, 'kasir', 'c7911af3adbd12a035b289556d96470a'),
(3, 'arif', '0ff6c3ace16359e41e37d40b8301d67f'),
(4, 'delvit', 'a2257dcfae80b1dd3f890d30a05e10c8'),
(5, 'putri', '4093fed663717c843bea100d17fb67c8'),
(6, 'mutiah', 'f474a4957072560d488399edcb09044a'),
(7, 'najmi', '37dd68c84560cbe599ee7187db518006');

--
-- Indexes for dumped tables
--

--
-- Indeks untuk tabel `databarang`
--
ALTER TABLE `databarang`
  ADD PRIMARY KEY (`id_barang`) USING BTREE;

--
-- Indeks untuk tabel `detail_transaksi`
--
ALTER TABLE `detail_transaksi`
  ADD PRIMARY KEY (`id_detail`);

--
-- Indeks untuk tabel `transaksi`
--
ALTER TABLE `transaksi`
  ADD PRIMARY KEY (`id_transaksi`);

--
-- Indeks untuk tabel `user`
--
ALTER TABLE `user`
  ADD PRIMARY KEY (`id_user`);

--
-- AUTO_INCREMENT untuk tabel yang dibuang
--

--
-- AUTO_INCREMENT untuk tabel `databarang`
--
ALTER TABLE `databarang`
  MODIFY `id_barang` int(5) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=16;

--
-- AUTO_INCREMENT untuk tabel `detail_transaksi`
--
ALTER TABLE `detail_transaksi`
  MODIFY `id_detail` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=9;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;



