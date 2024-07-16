-- phpMyAdmin SQL Dump
-- version 5.2.0
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Waktu pembuatan: 21 Jun 2023 pada 16.10
-- Versi server: 10.4.27-MariaDB
-- Versi PHP: 7.4.33

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `vb_datapasien`
--

-- --------------------------------------------------------

--
-- Struktur dari tabel `data_obat`
--

CREATE TABLE `data_obat` (
  `kodeobat` varchar(20) NOT NULL,
  `namaobat` varchar(20) NOT NULL,
  `hargaobat` double NOT NULL,
  `apoteker` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data untuk tabel `data_obat`
--

INSERT INTO `data_obat` (`kodeobat`, `namaobat`, `hargaobat`, `apoteker`) VALUES
('AMX', 'Amoxicillin', 20000, 'ilham'),
('GN', 'Ganja', 150000, 'ilham'),
('PCL', 'Paracetamol', 14000, 'ilham'),
('ViC', 'Vitamin C', 10000, 'ilham');

-- --------------------------------------------------------

--
-- Struktur dari tabel `data_pasien`
--

CREATE TABLE `data_pasien` (
  `ID_Pasien` bigint(20) NOT NULL,
  `Nama_pasien` varchar(50) NOT NULL,
  `alamat_pasien` varchar(100) NOT NULL,
  `jenis_kelamin` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data untuk tabel `data_pasien`
--

INSERT INTO `data_pasien` (`ID_Pasien`, `Nama_pasien`, `alamat_pasien`, `jenis_kelamin`) VALUES
(62023002, 'Andika', 'solo', 'laki laki'),
(62023003, 'Gopal', 'karanganyar', 'laki laki'),
(62023004, 'Kipas', 'jogja', 'laki laki');

-- --------------------------------------------------------

--
-- Struktur dari tabel `transaksi`
--

CREATE TABLE `transaksi` (
  `KodeTransaksi` bigint(20) NOT NULL,
  `KodeRM` varchar(10) NOT NULL,
  `Nama` varchar(50) NOT NULL,
  `KodeObat` varchar(20) NOT NULL,
  `NamaObat` varchar(20) NOT NULL,
  `HargaObat` double NOT NULL,
  `JumlahObat` double NOT NULL,
  `JumlahHarga` double NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data untuk tabel `transaksi`
--

INSERT INTO `transaksi` (`KodeTransaksi`, `KodeRM`, `Nama`, `KodeObat`, `NamaObat`, `HargaObat`, `JumlahObat`, `JumlahHarga`) VALUES
(10001, '62023003', 'Gopal', 'GN', 'Ganja', 150000, 4, 600000),
(10002, '62023003', 'Gopal', 'AMX', 'Amoxicillin', 20000, 4, 80000),
(10003, '62023003', 'Gopal', 'PCL', 'Paracetamol', 14000, 4, 600000);

--
-- Indexes for dumped tables
--

--
-- Indeks untuk tabel `data_obat`
--
ALTER TABLE `data_obat`
  ADD PRIMARY KEY (`kodeobat`);

--
-- Indeks untuk tabel `data_pasien`
--
ALTER TABLE `data_pasien`
  ADD PRIMARY KEY (`ID_Pasien`);

--
-- Indeks untuk tabel `transaksi`
--
ALTER TABLE `transaksi`
  ADD PRIMARY KEY (`KodeTransaksi`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
