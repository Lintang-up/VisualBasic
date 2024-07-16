-- phpMyAdmin SQL Dump
-- version 5.2.0
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Jul 07, 2023 at 03:08 PM
-- Server version: 10.4.24-MariaDB
-- PHP Version: 7.4.29

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `visual_hotel`
--

-- --------------------------------------------------------

--
-- Table structure for table `ruangan`
--

CREATE TABLE `ruangan` (
  `idRuangan` int(11) NOT NULL,
  `nomorRuangan` int(11) NOT NULL,
  `tipeRuangan` varchar(50) NOT NULL,
  `jumlahHunian` int(11) NOT NULL,
  `status` enum('Di Huni','Kosong') NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `ruangan`
--

INSERT INTO `ruangan` (`idRuangan`, `nomorRuangan`, `tipeRuangan`, `jumlahHunian`, `status`) VALUES
(1, 101, 'Single', 1, 'Di Huni'),
(2, 102, 'Single', 1, 'Di Huni'),
(3, 103, 'Single', 1, 'Kosong'),
(4, 104, 'Double', 2, 'Kosong'),
(5, 105, 'Double', 2, 'Kosong'),
(6, 106, 'Double', 2, 'Kosong'),
(7, 107, 'Deluxe', 4, 'Kosong'),
(8, 108, 'Deluxe', 4, 'Kosong'),
(9, 109, 'Deluxe', 4, 'Kosong'),
(10, 110, 'Kids', 2, 'Kosong'),
(11, 111, 'Kids', 2, 'Kosong'),
(12, 112, 'Kids', 2, 'Kosong'),
(13, 113, 'Single', 1, 'Kosong');

-- --------------------------------------------------------

--
-- Table structure for table `tamu`
--

CREATE TABLE `tamu` (
  `idTamu` int(11) NOT NULL,
  `nama` varchar(50) NOT NULL,
  `alamat` varchar(100) NOT NULL,
  `ktp` varchar(20) NOT NULL,
  `noHp` varchar(20) NOT NULL,
  `jenisKelamin` enum('Laki-laki','Perempuan') NOT NULL,
  `status` enum('menunggu','menghuni','pulang') NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `tamu`
--

INSERT INTO `tamu` (`idTamu`, `nama`, `alamat`, `ktp`, `noHp`, `jenisKelamin`, `status`) VALUES
(1, 'satu nusa', 'bangsa indonesia', '0987654321234567', '087909888777', 'Laki-laki', 'menghuni'),
(2, 'kedua', 'diduakan itu sakit', '090909090909090', '090909090909', 'Laki-laki', 'menghuni'),
(3, 'budianto', 'klaten, klaten, jawa tengah', '3300999900998811', '086789876543', 'Laki-laki', 'menunggu'),
(4, 'tri murti', 'jalan ki ageng gribig, klaten utara, klaten', '3367876543190865', '085666444555', 'Perempuan', 'menunggu'),
(5, 'Tentara Hitam', 'Indonesia bagian timur ', '3609876543768954', '088111222333', 'Laki-laki', 'menunggu'),
(6, 'berby', 'amerika serikat', '0000000000000000', '021909346778', 'Perempuan', 'menunggu');

-- --------------------------------------------------------

--
-- Table structure for table `transaksi`
--

CREATE TABLE `transaksi` (
  `idTransaksi` varchar(20) NOT NULL,
  `namaTamu` varchar(50) NOT NULL,
  `nomorRuangan` int(11) NOT NULL,
  `tipeRuangan` varchar(50) NOT NULL,
  `tarifKamar` int(11) NOT NULL,
  `tanggalCheckIn` date NOT NULL,
  `tanggalCheckOut` date NOT NULL,
  `jumlahHari` int(11) NOT NULL,
  `jumlahDewasa` int(11) NOT NULL,
  `jumlahAnak` int(11) NOT NULL,
  `diskonInap` int(11) NOT NULL,
  `tipeMember` varchar(50) NOT NULL,
  `diskonMember` int(11) NOT NULL,
  `subTotal` int(11) NOT NULL,
  `uangMuka` int(11) NOT NULL,
  `totalKurang` int(11) NOT NULL,
  `bayar` int(11) NOT NULL,
  `kembalian` int(11) NOT NULL,
  `idTamu` int(11) NOT NULL,
  `idRuangan` int(11) NOT NULL,
  `status` enum('Belum Lunas','Lunas') NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `transaksi`
--

INSERT INTO `transaksi` (`idTransaksi`, `namaTamu`, `nomorRuangan`, `tipeRuangan`, `tarifKamar`, `tanggalCheckIn`, `tanggalCheckOut`, `jumlahHari`, `jumlahDewasa`, `jumlahAnak`, `diskonInap`, `tipeMember`, `diskonMember`, `subTotal`, `uangMuka`, `totalKurang`, `bayar`, `kembalian`, `idTamu`, `idRuangan`, `status`) VALUES
('TransID-0001', 'satu nusa', 101, 'Single', 100000, '2023-07-07', '2023-07-08', 1, 1, 0, 0, 'Tidak Ada', 0, 100000, 50000, 50000, 0, 0, 1, 1, 'Belum Lunas'),
('TransID-0002', 'kedua', 102, 'Single', 100000, '2023-07-07', '2023-07-22', 15, 2, 0, 20000, 'VIP', 25000, 1455000, 500000, 955000, 0, 0, 2, 2, 'Belum Lunas');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `ruangan`
--
ALTER TABLE `ruangan`
  ADD PRIMARY KEY (`idRuangan`);

--
-- Indexes for table `tamu`
--
ALTER TABLE `tamu`
  ADD PRIMARY KEY (`idTamu`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `ruangan`
--
ALTER TABLE `ruangan`
  MODIFY `idRuangan` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=16;

--
-- AUTO_INCREMENT for table `tamu`
--
ALTER TABLE `tamu`
  MODIFY `idTamu` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
