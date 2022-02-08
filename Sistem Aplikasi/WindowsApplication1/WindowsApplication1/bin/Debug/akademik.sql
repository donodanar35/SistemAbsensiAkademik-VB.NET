-- phpMyAdmin SQL Dump
-- version 4.4.12
-- http://www.phpmyadmin.net
--
-- Host: 127.0.0.1
-- Generation Time: 11 Apr 2019 pada 01.08
-- Versi Server: 5.6.25
-- PHP Version: 5.5.27

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `akademik`
--

-- --------------------------------------------------------

--
-- Struktur dari tabel `dabsensi_pegawai`
--

CREATE TABLE IF NOT EXISTS `dabsensi_pegawai` (
  `ID_PEGAWAI` varchar(100) NOT NULL,
  `ID_APEGAWAI` varchar(100) NOT NULL,
  `STATUS` varchar(10) DEFAULT NULL,
  `KETERANGAN` varchar(250) DEFAULT NULL,
  `HADIR` int(11) NOT NULL DEFAULT '0',
  `IZIN` int(11) NOT NULL DEFAULT '0',
  `ALFA` int(11) NOT NULL DEFAULT '0'
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data untuk tabel `dabsensi_pegawai`
--

INSERT INTO `dabsensi_pegawai` (`ID_PEGAWAI`, `ID_APEGAWAI`, `STATUS`, `KETERANGAN`, `HADIR`, `IZIN`, `ALFA`) VALUES
('1', '1-2212-Gasal', 'Hadir', '', 1, 0, 0),
('1', '10-2212-Gasal', 'Hadir', '', 1, 0, 0),
('1', '2-2212-Gasal', 'Hadir', '', 1, 0, 0),
('1', '3-2212-Gasal', 'Hadir', '', 1, 0, 0),
('1', '4-2019-Gasal', 'Hadir', '', 1, 0, 0),
('1', '5-2019-Gasal', 'Hadir', '', 1, 0, 0),
('1', '6-2212-Gasal', 'Hadir', '', 1, 0, 0),
('1', '7-2212-Gasal', 'Hadir', '', 1, 0, 0),
('1', '8-2212-Gasal', 'Hadir', '', 1, 0, 0),
('1', '9-2212-Gasal', 'Hadir', '', 1, 0, 0),
('3', '10-2212-Gasal', 'Hadir', '', 1, 0, 0),
('3', '2-2212-Gasal', 'Hadir', '', 1, 0, 0),
('3', '3-2212-Gasal', 'Izin', '', 0, 1, 0),
('3', '5-2019-Gasal', 'Hadir', '', 1, 0, 0),
('3', '6-2212-Gasal', 'Hadir', '', 1, 0, 0),
('3', '7-2212-Gasal', 'Hadir', '', 1, 0, 0),
('3', '8-2212-Gasal', 'Hadir', '', 1, 0, 0),
('3', '9-2212-Gasal', 'Hadir', '', 1, 0, 0),
('4', '10-2212-Gasal', 'Hadir', '', 1, 0, 0),
('4', '2-2212-Gasal', 'Hadir', '', 1, 0, 0),
('4', '3-2212-Gasal', 'Alfa', '', 0, 0, 1),
('4', '5-2019-Gasal', 'Hadir', '', 1, 0, 0),
('4', '6-2212-Gasal', 'Hadir', '', 1, 0, 0),
('4', '7-2212-Gasal', 'Hadir', '', 1, 0, 0),
('4', '8-2212-Gasal', 'Hadir', '', 1, 0, 0),
('4', '9-2212-Gasal', 'Hadir', '', 1, 0, 0),
('5', '10-2212-Gasal', 'Hadir', '', 1, 0, 0),
('5', '2-2212-Gasal', 'Hadir', '', 1, 0, 0),
('5', '3-2212-Gasal', 'Alfa', '', 0, 0, 1),
('5', '5-2019-Gasal', 'Hadir', '', 1, 0, 0),
('5', '6-2212-Gasal', 'Hadir', '', 1, 0, 0),
('5', '7-2212-Gasal', 'Hadir', '', 1, 0, 0),
('5', '8-2212-Gasal', 'Hadir', '', 1, 0, 0),
('5', '9-2212-Gasal', 'Hadir', '', 1, 0, 0),
('6', '10-2212-Gasal', 'Hadir', '', 1, 0, 0),
('6', '6-2212-Gasal', 'Hadir', '', 1, 0, 0),
('6', '7-2212-Gasal', 'Hadir', '', 1, 0, 0),
('6', '8-2212-Gasal', 'Hadir', '', 1, 0, 0),
('6', '9-2212-Gasal', 'Hadir', '', 1, 0, 0),
('7', '10-2212-Gasal', 'Hadir', '', 1, 0, 0),
('7', '6-2212-Gasal', 'Hadir', '', 1, 0, 0),
('7', '7-2212-Gasal', 'Hadir', '', 1, 0, 0),
('7', '8-2212-Gasal', 'Hadir', '', 1, 0, 0),
('7', '9-2212-Gasal', 'Hadir', '', 1, 0, 0),
('8', '10-2212-Gasal', 'Hadir', '', 1, 0, 0),
('8', '6-2212-Gasal', 'Hadir', '', 1, 0, 0),
('8', '7-2212-Gasal', 'Hadir', '', 1, 0, 0),
('8', '8-2212-Gasal', 'Hadir', '', 1, 0, 0),
('8', '9-2212-Gasal', 'Hadir', '', 1, 0, 0),
('9', '10-2212-Gasal', 'Hadir', '', 1, 0, 0),
('9', '6-2212-Gasal', 'Hadir', '', 1, 0, 0),
('9', '7-2212-Gasal', 'Hadir', '', 1, 0, 0),
('9', '8-2212-Gasal', 'Hadir', '', 1, 0, 0),
('9', '9-2212-Gasal', 'Hadir', '', 1, 0, 0);

-- --------------------------------------------------------

--
-- Struktur dari tabel `dabsensi_siswa`
--

CREATE TABLE IF NOT EXISTS `dabsensi_siswa` (
  `ID_ASISWA` varchar(100) NOT NULL,
  `ID_SISWA` varchar(100) NOT NULL,
  `STATUS` varchar(10) DEFAULT NULL,
  `KETERANGAN` varchar(250) DEFAULT NULL,
  `HADIR` int(11) NOT NULL DEFAULT '0',
  `IZIN` int(11) NOT NULL DEFAULT '0',
  `ALFA` int(11) NOT NULL DEFAULT '0'
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data untuk tabel `dabsensi_siswa`
--

INSERT INTO `dabsensi_siswa` (`ID_ASISWA`, `ID_SISWA`, `STATUS`, `KETERANGAN`, `HADIR`, `IZIN`, `ALFA`) VALUES
('1-1-7a-2212-Gasal', '1', 'Hadir', '', 1, 0, 0),
('2-6-7a-2212-Gasal', '1', 'Hadir', '', 1, 0, 0),
('2-6-7a-2212-Gasal', '2', 'Hadir', '', 1, 0, 0),
('2-6-7a-2212-Gasal', '4', 'Hadir', '', 1, 0, 0),
('2-6-7a-2212-Gasal', '5', 'Alfa', '', 0, 0, 1),
('3-6-7a-2212-Gasal', '1', 'Hadir', '', 1, 0, 0),
('3-6-7a-2212-Gasal', '2', 'Hadir', '', 1, 0, 0),
('3-6-7a-2212-Gasal', '4', 'Hadir', '', 1, 0, 0),
('3-6-7a-2212-Gasal', '5', 'Hadir', '', 1, 0, 0),
('4-1-7a-2212-Gasal', '1', 'Hadir', '', 1, 0, 0),
('5-6-7a-2212-Gasal', '1', 'Hadir', '', 1, 0, 0),
('5-6-7a-2212-Gasal', '2', 'Hadir', '', 1, 0, 0),
('5-6-7a-2212-Gasal', '4', 'Hadir', '', 1, 0, 0),
('5-6-7a-2212-Gasal', '5', 'Hadir', '', 1, 0, 0),
('6-1-7a-2212-Gasal', '1', 'Hadir', '', 1, 0, 0),
('7-3-7a-2212-Gasal', '1', 'Hadir', '', 1, 0, 0);

-- --------------------------------------------------------

--
-- Struktur dari tabel `detail_jabatan`
--

CREATE TABLE IF NOT EXISTS `detail_jabatan` (
  `ID_MENJABAT` varchar(20) NOT NULL,
  `ID_PEGAWAI` varchar(100) NOT NULL,
  `ID_JABATAN` varchar(20) NOT NULL,
  `AWAL_BAKTI` date DEFAULT NULL,
  `AKHIR_BAKTI` date DEFAULT NULL,
  `STATUS` decimal(8,0) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data untuk tabel `detail_jabatan`
--

INSERT INTO `detail_jabatan` (`ID_MENJABAT`, `ID_PEGAWAI`, `ID_JABATAN`, `AWAL_BAKTI`, `AKHIR_BAKTI`, `STATUS`) VALUES
('1', '1', '1', '2019-04-11', '2019-05-31', '1'),
('2', '10', '2', '2019-04-11', '2019-06-09', '1'),
('3', '11', '3', '2019-04-11', '2019-06-30', '1');

-- --------------------------------------------------------

--
-- Struktur dari tabel `dkelas`
--

CREATE TABLE IF NOT EXISTS `dkelas` (
  `ID_SISWA` varchar(100) NOT NULL,
  `ID_KELAS` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data untuk tabel `dkelas`
--

INSERT INTO `dkelas` (`ID_SISWA`, `ID_KELAS`) VALUES
('1', '1-7a-2212-Gasal'),
('1', '10-7a-2019 / 2020 - Gasal'),
('2', '10-7a-2019 / 2020 - Gasal'),
('4', '10-7a-2019 / 2020 - Gasal'),
('5', '10-7a-2019 / 2020 - Gasal'),
('1', '2-7a-2019-Gasal'),
('2', '2-7a-2019-Gasal'),
('1', '3-7a-2212-Gasal'),
('1', '4-7a-2212-Gasal'),
('2', '4-7a-2212-Gasal'),
('1', '5-7a-2212-Gasal'),
('2', '5-7a-2212-Gasal'),
('1', '6-7a-2212-Gasal'),
('2', '6-7a-2212-Gasal'),
('4', '6-7a-2212-Gasal'),
('5', '6-7a-2212-Gasal'),
('2', '7-7a-2019-Gasal'),
('2', '8-8cd-2019-Gasal'),
('1', '9-7a-2212-Gasal'),
('2', '9-7a-2212-Gasal');

-- --------------------------------------------------------

--
-- Struktur dari tabel `dperizinan_pegawai`
--

CREATE TABLE IF NOT EXISTS `dperizinan_pegawai` (
  `ID` varchar(100) NOT NULL,
  `ID_PEGAWAI` varchar(100) NOT NULL,
  `ID_IZIN` varchar(100) NOT NULL,
  `JENIS_IZIN` varchar(20) DEFAULT NULL,
  `BERLAKUTGL` date NOT NULL,
  `SAMPAITGL` date NOT NULL,
  `TGL_IZIN` date DEFAULT NULL,
  `TGL_DISETUJUI` date DEFAULT NULL,
  `KETERANGAN` varchar(250) DEFAULT NULL,
  `STATUS` decimal(8,0) DEFAULT NULL,
  `DINAS` int(11) NOT NULL DEFAULT '0',
  `SAKIT` int(11) NOT NULL DEFAULT '0',
  `LAINNYA` int(11) NOT NULL DEFAULT '0',
  `DIIZINKAN` int(11) NOT NULL DEFAULT '0',
  `DITOLAK` int(11) NOT NULL DEFAULT '0',
  `PERSETUJUAN` varchar(250) NOT NULL,
  `KONFIRMASI` varchar(20) NOT NULL,
  `BACA` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data untuk tabel `dperizinan_pegawai`
--

INSERT INTO `dperizinan_pegawai` (`ID`, `ID_PEGAWAI`, `ID_IZIN`, `JENIS_IZIN`, `BERLAKUTGL`, `SAMPAITGL`, `TGL_IZIN`, `TGL_DISETUJUI`, `KETERANGAN`, `STATUS`, `DINAS`, `SAKIT`, `LAINNYA`, `DIIZINKAN`, `DITOLAK`, `PERSETUJUAN`, `KONFIRMASI`, `BACA`) VALUES
('1-2212-Gasal-1234', '1', '5-2212-Gasal', 'Dinas', '2019-04-10', '2019-04-10', '2019-04-10', '2019-04-10', '', '2', 1, 0, 0, 1, 0, '', 'Diterima', 1),
('2-2212-Gasal-1234', '1', '5-2212-Gasal', 'Sakit', '2019-04-10', '2019-04-10', '2019-04-10', '2019-04-10', '', '2', 0, 1, 0, 0, 1, '', 'Ditolak', 1),
('3-2212-Gasal-1234', '1', '5-2212-Gasal', 'Lainnya', '2019-04-10', '2019-04-10', '2019-04-10', '2019-04-10', '', '2', 0, 0, 1, 1, 0, '', 'Diterima', 1),
('4-2212-Gasal-1234', '1', '5-2212-Gasal', 'Dinas', '2019-04-10', '2019-04-10', '2019-04-10', '2019-04-10', 'kjkjdkjksjdjk', '2', 1, 0, 0, 0, 1, '', 'Ditolak', 1);

-- --------------------------------------------------------

--
-- Struktur dari tabel `habsensi_pegawai`
--

CREATE TABLE IF NOT EXISTS `habsensi_pegawai` (
  `ID_APEGAWAI` varchar(100) NOT NULL,
  `TAHUN_AJARAN` varchar(50) NOT NULL,
  `ID_PEGAWAI` varchar(100) NOT NULL,
  `TGL` date DEFAULT NULL,
  `TOTAL_HADIR` decimal(8,0) DEFAULT NULL,
  `TOTAL_IZIN` decimal(8,0) DEFAULT NULL,
  `TOTAL_ALFA` decimal(8,0) DEFAULT NULL,
  `STATUS` decimal(8,0) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data untuk tabel `habsensi_pegawai`
--

INSERT INTO `habsensi_pegawai` (`ID_APEGAWAI`, `TAHUN_AJARAN`, `ID_PEGAWAI`, `TGL`, `TOTAL_HADIR`, `TOTAL_IZIN`, `TOTAL_ALFA`, `STATUS`) VALUES
('1-2212-Gasal', '2212-Gasal', '1', '2019-03-29', '1', '0', '0', '0'),
('10-2212-Gasal', '2212-Gasal', '1', '2019-04-12', '8', '0', '0', '0'),
('2-2212-Gasal', '2212-Gasal', '1', '2019-04-05', '4', '0', '0', '0'),
('3-2212-Gasal', '2212-Gasal', '1', '2019-04-06', '1', '1', '2', '0'),
('4-2019-Gasal', '2019-Gasal', '1', '2019-04-05', '1', '0', '0', '0'),
('5-2019-Gasal', '2019-Gasal', '1', '2019-04-05', '4', '0', '0', '0'),
('6-2212-Gasal', '2212-Gasal', '1', '2019-04-09', '8', '0', '0', '0'),
('7-2212-Gasal', '2212-Gasal', '1', '2019-04-09', '8', '0', '0', '0'),
('8-2212-Gasal', '2212-Gasal', '1', '2019-04-09', '8', '0', '0', '0'),
('9-2212-Gasal', '2212-Gasal', '1', '2019-04-09', '8', '0', '0', '0');

-- --------------------------------------------------------

--
-- Struktur dari tabel `habsensi_siswa`
--

CREATE TABLE IF NOT EXISTS `habsensi_siswa` (
  `ID_ASISWA` varchar(100) NOT NULL,
  `ID_PEGAWAI` varchar(100) NOT NULL,
  `TAHUN_AJARAN` varchar(50) NOT NULL,
  `ID_KELAS` varchar(100) NOT NULL,
  `TGL` date DEFAULT NULL,
  `TOTAL_HADIR` decimal(8,0) DEFAULT NULL,
  `TOTAL_IZIN` decimal(8,0) DEFAULT NULL,
  `TOTAL_ALFA` decimal(8,0) DEFAULT NULL,
  `STATUS` decimal(8,0) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data untuk tabel `habsensi_siswa`
--

INSERT INTO `habsensi_siswa` (`ID_ASISWA`, `ID_PEGAWAI`, `TAHUN_AJARAN`, `ID_KELAS`, `TGL`, `TOTAL_HADIR`, `TOTAL_IZIN`, `TOTAL_ALFA`, `STATUS`) VALUES
('1-1-7a-2212-Gasal', '1', '2212-Gasal', '1-7a-2212-Gasal', '2019-03-29', '1', '0', '0', '0'),
('2-6-7a-2212-Gasal', '1', '2212-Gasal', '6-7a-2212-Gasal', '2019-04-05', '3', '0', '1', '0'),
('3-6-7a-2212-Gasal', '1', '2212-Gasal', '6-7a-2212-Gasal', '2019-04-07', '4', '0', '0', '0'),
('4-1-7a-2212-Gasal', '1', '2212-Gasal', '1-7a-2212-Gasal', '2019-04-05', '1', '0', '0', '0'),
('5-6-7a-2212-Gasal', '1', '2212-Gasal', '6-7a-2212-Gasal', '2019-04-05', '4', '0', '0', '0'),
('6-1-7a-2212-Gasal', '1', '2212-Gasal', '1-7a-2212-Gasal', '2019-04-09', '1', '0', '0', '0'),
('7-3-7a-2212-Gasal', '1', '2212-Gasal', '3-7a-2212-Gasal', '2019-04-09', '1', '0', '0', '0');

-- --------------------------------------------------------

--
-- Struktur dari tabel `hkelas`
--

CREATE TABLE IF NOT EXISTS `hkelas` (
  `ID_KELAS` varchar(100) NOT NULL,
  `ID_PEGAWAI` varchar(100) NOT NULL,
  `TGL` date NOT NULL,
  `ID_ROMBEL` varchar(20) NOT NULL,
  `ID_RUANG` varchar(20) NOT NULL,
  `TAHUN_AJARAN` varchar(50) NOT NULL,
  `NAMA_KELAS` varchar(100) DEFAULT NULL,
  `TOTAL_SISWA` decimal(8,0) DEFAULT NULL,
  `STATUS` decimal(8,0) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data untuk tabel `hkelas`
--

INSERT INTO `hkelas` (`ID_KELAS`, `ID_PEGAWAI`, `TGL`, `ID_ROMBEL`, `ID_RUANG`, `TAHUN_AJARAN`, `NAMA_KELAS`, `TOTAL_SISWA`, `STATUS`) VALUES
('1-7a-2212-Gasal', '1', '2019-03-02', '1', '1', '2212-Gasal', '7a-2212-Gasal', '1', '0'),
('10-7a-2019 / 2020 - Gasal', '1', '2019-04-09', '1', '1', '2019 / 2020 - Gasal', '7c', '4', '0'),
('2-7a-2019-Gasal', '1', '2019-03-29', '1', '1', '2019-Gasal', '7a-2019-Gasal', '2', '0'),
('3-7a-2212-Gasal', '1', '2019-03-29', '1', '1', '2212-Gasal', 'dsdsds', '1', '0'),
('4-7a-2212-Gasal', '1', '2019-03-29', '1', '1', '2212-Gasal', '7c', '2', '0'),
('5-7a-2212-Gasal', '1', '2019-03-29', '1', '1', '2212-Gasal', 'hsjhsjdjshdj', '2', '0'),
('6-7a-2212-Gasal', '1', '2019-04-05', '1', '2', '2212-Gasal', '6v', '4', '0'),
('7-7a-2019-Gasal', '1', '2019-04-06', '1', '1', '2019-Gasal', 'swewew', '1', '0'),
('8-8cd-2019-Gasal', '3', '2019-04-06', '2', '1', '2019-Gasal', 'swewew', '1', '0'),
('9-7a-2212-Gasal', '1', '2019-04-07', '1', '1', '2212-Gasal', 'tes', '2', '0');

-- --------------------------------------------------------

--
-- Struktur dari tabel `hperizinan_pegawai`
--

CREATE TABLE IF NOT EXISTS `hperizinan_pegawai` (
  `ID_IZIN` varchar(100) NOT NULL,
  `ID_PEGAWAI` varchar(100) NOT NULL,
  `TAHUN_AJARAN` varchar(50) NOT NULL,
  `TGL` date DEFAULT NULL,
  `PERIODEAWAL` date DEFAULT NULL,
  `PERIODEAKHIR` date DEFAULT NULL,
  `TOTAL_IZIN` decimal(8,0) DEFAULT NULL,
  `TOTAL_DISETUJUI` decimal(8,0) DEFAULT NULL,
  `KETERANGAN` varchar(250) DEFAULT NULL,
  `STATUS` decimal(8,0) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data untuk tabel `hperizinan_pegawai`
--

INSERT INTO `hperizinan_pegawai` (`ID_IZIN`, `ID_PEGAWAI`, `TAHUN_AJARAN`, `TGL`, `PERIODEAWAL`, `PERIODEAKHIR`, `TOTAL_IZIN`, `TOTAL_DISETUJUI`, `KETERANGAN`, `STATUS`) VALUES
('5-2212-Gasal', '6', '2212-Gasal', '2019-04-10', '2019-04-10', '2019-04-28', '4', '4', '', '1');

-- --------------------------------------------------------

--
-- Struktur dari tabel `jabatan`
--

CREATE TABLE IF NOT EXISTS `jabatan` (
  `ID_JABATAN` varchar(20) NOT NULL,
  `JABATAN` varchar(30) DEFAULT NULL,
  `STATUS` decimal(8,0) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data untuk tabel `jabatan`
--

INSERT INTO `jabatan` (`ID_JABATAN`, `JABATAN`, `STATUS`) VALUES
('1', 'TU', '1'),
('2', 'kepsek', '1'),
('3', 'wakasek', '1');

-- --------------------------------------------------------

--
-- Struktur dari tabel `jadwal`
--

CREATE TABLE IF NOT EXISTS `jadwal` (
  `ID_JADWAL` varchar(100) NOT NULL,
  `TAHUN_AJARAN` varchar(50) NOT NULL,
  `ID_MAPEL` varchar(20) NOT NULL,
  `ID_PEGAWAI` varchar(100) NOT NULL,
  `ID_KELAS` varchar(100) NOT NULL,
  `HARI` varchar(20) DEFAULT NULL,
  `JAM_AWALMENGAJAR` time DEFAULT NULL,
  `JAM_AKHIRMENGAJAR` time DEFAULT NULL,
  `BERLAKUTGL` date NOT NULL,
  `SAMPAITGL` date NOT NULL,
  `TGL` date NOT NULL,
  `STATUS` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data untuk tabel `jadwal`
--

INSERT INTO `jadwal` (`ID_JADWAL`, `TAHUN_AJARAN`, `ID_MAPEL`, `ID_PEGAWAI`, `ID_KELAS`, `HARI`, `JAM_AWALMENGAJAR`, `JAM_AKHIRMENGAJAR`, `BERLAKUTGL`, `SAMPAITGL`, `TGL`, `STATUS`) VALUES
('1', '2212-Gasal', '1', '1', '1-7a-2212-Gasal', 'senin', '00:00:00', '00:00:00', '2019-04-05', '2019-04-05', '2019-04-05', 2),
('10', '2212-Gasal', '1', '1', '1-7a-2212-Gasal', 'sabtu', '00:00:00', '00:00:00', '2019-04-10', '2019-04-28', '2019-04-10', 1),
('11', '2212-Gasal', '1', '1', '1-7a-2212-Gasal', 'rabu', '00:00:00', '00:00:00', '2019-03-28', '2019-03-30', '2019-04-10', 2),
('12', '2212-Gasal', '1', '1', '1-7a-2212-Gasal', 'senin', '10:00:00', '11:00:00', '2019-04-10', '2019-04-10', '2019-04-10', 1),
('13', '2212-Gasal', '1', '1', '1-7a-2212-Gasal', 'selasa', '10:00:00', '11:00:00', '2019-04-06', '2019-04-06', '2019-04-10', 2),
('2', '2212-Gasal', '1', '1', '1-7a-2212-Gasal', 'senin', '00:00:00', '00:00:00', '2019-04-05', '2019-04-05', '2019-04-05', 2),
('3', '2212-Gasal', '1', '1', '1-7a-2212-Gasal', 'senin', '00:00:00', '00:00:00', '2019-04-05', '2019-04-05', '2019-04-05', 2),
('4', '2212-Gasal', '1', '1', '1-7a-2212-Gasal', 'senin', '00:00:00', '00:00:00', '2019-04-05', '2019-04-05', '2019-04-05', 2),
('5', '2212-Gasal', '1', '1', '1-7a-2212-Gasal', 'senin', '00:00:00', '00:00:00', '2019-04-05', '2019-04-05', '2019-04-05', 2),
('6', '2212-Gasal', '1', '1', '1-7a-2212-Gasal', 'senin', '00:00:00', '00:00:00', '2019-04-05', '2019-04-05', '2019-04-05', 2),
('7', '2212-Gasal', '1', '1', '1-7a-2212-Gasal', 'senin', '00:00:00', '00:00:00', '2019-04-05', '2019-04-05', '2019-04-05', 2),
('8', '2212-Gasal', '1', '1', '1-7a-2212-Gasal', 'selasa', '00:00:00', '00:00:00', '2019-04-09', '2019-04-09', '2019-04-09', 2),
('9', '2212-Gasal', '1', '1', '1-7a-2212-Gasal', 'rabu', '00:00:00', '00:00:00', '2019-03-27', '2019-03-29', '2019-04-10', 2);

-- --------------------------------------------------------

--
-- Struktur dari tabel `mapel`
--

CREATE TABLE IF NOT EXISTS `mapel` (
  `ID_MAPEL` varchar(20) NOT NULL,
  `MAPEL` varchar(50) DEFAULT NULL,
  `STATUS` decimal(8,0) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data untuk tabel `mapel`
--

INSERT INTO `mapel` (`ID_MAPEL`, `MAPEL`, `STATUS`) VALUES
('1', 'bhs indo', '1'),
('2', 'biologi', '1'),
('3', 'fisika', '1'),
('4', 'kimia', '0'),
('5', 'kimia', '1');

-- --------------------------------------------------------

--
-- Struktur dari tabel `mutasi_siswa`
--

CREATE TABLE IF NOT EXISTS `mutasi_siswa` (
  `ID_MUTASI` varchar(20) NOT NULL,
  `ID_SISWA` varchar(100) NOT NULL,
  `NO_INDUK` decimal(8,0) DEFAULT NULL,
  `NISN` decimal(8,0) DEFAULT NULL,
  `NAMA_SISWA` varchar(100) DEFAULT NULL,
  `TEMPAT_LAHIR` varchar(30) NOT NULL,
  `TGL_LAHIR` date NOT NULL,
  `ALAMAT` varchar(250) DEFAULT NULL,
  `GENDER` varchar(20) DEFAULT NULL,
  `AGAMA` varchar(20) DEFAULT NULL,
  `TGL_MASUK` date DEFAULT NULL,
  `TGL_KELUAR` date DEFAULT NULL,
  `ASAL_SD` varchar(20) DEFAULT NULL,
  `AYAH` varchar(100) DEFAULT NULL,
  `IBU` varchar(100) DEFAULT NULL,
  `TELP` varchar(20) DEFAULT NULL,
  `STATUS` decimal(8,0) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data untuk tabel `mutasi_siswa`
--

INSERT INTO `mutasi_siswa` (`ID_MUTASI`, `ID_SISWA`, `NO_INDUK`, `NISN`, `NAMA_SISWA`, `TEMPAT_LAHIR`, `TGL_LAHIR`, `ALAMAT`, `GENDER`, `AGAMA`, `TGL_MASUK`, `TGL_KELUAR`, `ASAL_SD`, `AYAH`, `IBU`, `TELP`, `STATUS`) VALUES
('1', '1', '12121', '2121', 'dsdsd', 'awe', '2019-03-29', '232323', 'Laki-laki', 'Islam', '2019-03-29', '2019-03-29', 'sdsds', '13ewe', 'wewew2', '21121', '0'),
('2', '1', '12121', '2121', 'dsdsd', 'awe', '2019-03-29', '232323', 'Laki-laki', 'Islam', '2019-03-29', '2019-04-05', 'sdsds', '13ewe', 'wewew2', '21121', '0'),
('3', '2', '23232', '323232', 'ewewew', 'wewew-------------', '2019-03-30', 'dwdswew-------------', 'Laki-laki', 'Islam', '2019-03-30', '2019-04-19', 'wdwew----------', 'wew-------', 'ewew------------', '23232---------', '0'),
('4', '4', '23232', '323', 'dssds', 'ewew2', '2019-04-05', '23232', 'Laki-laki', 'Islam', '2019-04-05', '2019-04-07', '323232', '323', '23232', '2332', '0'),
('5', '5', '2323', '23232', '3232', '3232', '2019-04-05', '232323', 'Perempuan', 'Islam', '2019-04-05', '2019-04-09', '3323', '323', '23232', '232323', '0');

-- --------------------------------------------------------

--
-- Struktur dari tabel `pegawai`
--

CREATE TABLE IF NOT EXISTS `pegawai` (
  `ID_PEGAWAI` varchar(100) NOT NULL,
  `NO_INDUK` decimal(8,0) DEFAULT NULL,
  `NAMA` varchar(250) DEFAULT NULL,
  `GENDER` varchar(20) DEFAULT NULL,
  `TEMPAT_LAHIR` varchar(50) DEFAULT NULL,
  `TGL_LAHIR` date DEFAULT NULL,
  `AGAMA` varchar(20) DEFAULT NULL,
  `ALAMAT` varchar(250) DEFAULT NULL,
  `TELP` varchar(20) DEFAULT NULL,
  `TGL_MASUK` date DEFAULT NULL,
  `STATUS` decimal(8,0) DEFAULT NULL,
  `PASSWORD` varchar(100) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data untuk tabel `pegawai`
--

INSERT INTO `pegawai` (`ID_PEGAWAI`, `NO_INDUK`, `NAMA`, `GENDER`, `TEMPAT_LAHIR`, `TGL_LAHIR`, `AGAMA`, `ALAMAT`, `TELP`, `TGL_MASUK`, `STATUS`, `PASSWORD`) VALUES
('1', '1234', 'Danar Dono', 'Laki-laki', 'KLT', '2019-03-07', 'Islam', 'klaten JWT', '23232', '2019-03-12', '1', 'd5c4496f47e8f9714df12af4367019ac'),
('10', '12345', 'Muh Eka', 'Laki-laki', 'Surabaya', '1996-01-01', 'Islam', '', '', '2019-04-11', '1', '79ee82b17dfb837b1be94a6827fa395a'),
('11', '123456', 'Miun', 'Laki-laki', 'Surabaya', '1996-02-11', 'Islam', '', '', '2019-04-11', '1', 'd41d8cd98f00b204e9800998ecf8427e'),
('2', '3132313', 'adakkjdkadjaj', 'Laki-laki', 'KJKDAKJDK', '2019-04-05', 'Islam', 'jjdssjkds', '32223232', '2019-04-05', '0', '81dc9bdb52d04dc20036dbd8313ed055'),
('3', '2323232', '1234', 'Laki-laki', 'dsdsds', '2019-04-05', 'Islam', 'wqwqw', '2323', '2019-04-05', '0', '81dc9bdb52d04dc20036dbd8313ed055'),
('4', '323', 'dsdsds', 'Perempuan', 'sddsds', '2019-04-05', 'Islam', 'sds', '232', '2019-04-05', '0', 'c20ad4d76fe97759aa27a0c99bff6710'),
('5', '3232', '12', 'Laki-laki', '1221', '2019-04-05', 'Islam', '121212', '21212', '2019-04-05', '0', 'c20ad4d76fe97759aa27a0c99bff6710'),
('6', '1', 'kepsek', 'Laki-laki', '', '2019-04-09', 'Islam', '', '', '2019-04-09', '0', '8561863b55faf85b9ad67c52b3b851ac'),
('7', '2', 'wakasek', 'Laki-laki', '', '2019-04-09', 'Islam', '', '', '2019-04-09', '0', 'b0e01a6db48522d0672abc66c07965f6'),
('8', '3', 'pegawai', 'Laki-laki', '', '2019-04-09', 'Islam', '', '', '2019-04-09', '0', '047aeeb234644b9e2d4138ed3bc7976a'),
('9', '4', '4', 'Laki-laki', '', '2019-04-09', 'Islam', '', '', '2019-04-09', '0', 'a87ff679a2f3e71d9181a67b7542122c');

-- --------------------------------------------------------

--
-- Struktur dari tabel `rombel`
--

CREATE TABLE IF NOT EXISTS `rombel` (
  `ID_ROMBEL` varchar(20) NOT NULL,
  `ROMBEL` varchar(20) DEFAULT NULL,
  `STATUS` decimal(8,0) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data untuk tabel `rombel`
--

INSERT INTO `rombel` (`ID_ROMBEL`, `ROMBEL`, `STATUS`) VALUES
('1', '7a', '0'),
('2', '8cd', '0'),
('3', '8d', '0');

-- --------------------------------------------------------

--
-- Struktur dari tabel `ruang`
--

CREATE TABLE IF NOT EXISTS `ruang` (
  `ID_RUANG` varchar(20) NOT NULL,
  `RUANG` varchar(20) DEFAULT NULL,
  `STATUS` decimal(8,0) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data untuk tabel `ruang`
--

INSERT INTO `ruang` (`ID_RUANG`, `RUANG`, `STATUS`) VALUES
('1', '7dsds', '0'),
('2', 'd', '0'),
('3', '5cc', '0'),
('4', 'c', '0');

-- --------------------------------------------------------

--
-- Struktur dari tabel `siswa`
--

CREATE TABLE IF NOT EXISTS `siswa` (
  `ID_SISWA` varchar(100) NOT NULL,
  `NO_INDUK` decimal(8,0) DEFAULT NULL,
  `NISN` decimal(8,0) DEFAULT NULL,
  `NAMA_SISWA` varchar(100) DEFAULT NULL,
  `ALAMAT` varchar(250) DEFAULT NULL,
  `GENDER` varchar(20) DEFAULT NULL,
  `TEMPAT_LAHIR` varchar(50) DEFAULT NULL,
  `TGL_LAHIR` date DEFAULT NULL,
  `AGAMA` varchar(20) DEFAULT NULL,
  `TGL_MASUK` date DEFAULT NULL,
  `ASAL_SD` varchar(20) DEFAULT NULL,
  `AYAH` varchar(100) DEFAULT NULL,
  `IBU` varchar(100) DEFAULT NULL,
  `TELP` varchar(20) DEFAULT NULL,
  `STATUS` decimal(8,0) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data untuk tabel `siswa`
--

INSERT INTO `siswa` (`ID_SISWA`, `NO_INDUK`, `NISN`, `NAMA_SISWA`, `ALAMAT`, `GENDER`, `TEMPAT_LAHIR`, `TGL_LAHIR`, `AGAMA`, `TGL_MASUK`, `ASAL_SD`, `AYAH`, `IBU`, `TELP`, `STATUS`) VALUES
('1', '12121', '2121', 'dsdsd', '232323', 'Laki-laki', 'awe', '2019-03-29', 'Islam', '2019-03-29', 'sdsds', '13ewe', 'wewew2', '21121', '0'),
('2', '23232', '323232', 'ewewew', 'dwdswew', 'Perempuan', 'wewew', '2019-03-29', 'Islam', '2019-03-29', 'wdwew', 'wew', 'ewew', '23232', '0'),
('3', '1212121', '12121212', 'dsdsdsd----------------', 'dsdsdsdsds--------------', 'Perempuan', 'sdsdsdsdsds-----------', '2019-04-06', 'Islam', '2019-04-06', 'dsdsds----------', 'fsf--------------', 'dsdsd--------------', '1213131------------', '0'),
('4', '23232', '323', 'dssds', '23232', 'Laki-laki', 'ewew2', '2019-04-05', 'Islam', '2019-04-05', '323232', '323', '23232', '2332', '0'),
('5', '2323', '23232', '3232', '232323', 'Perempuan', '3232', '2019-04-05', 'Islam', '2019-04-05', '3323', '323', '23232', '232323', '0'),
('6', '32321', '323', '23232', 'dsdsdsd', 'Laki-laki', '23232', '2019-04-07', 'Islam', '2019-04-07', '2323', 'dsds', 'sdsdsds', '232', '0');

-- --------------------------------------------------------

--
-- Struktur dari tabel `tahun_ajaran`
--

CREATE TABLE IF NOT EXISTS `tahun_ajaran` (
  `TAHUN_AJARAN` varchar(50) NOT NULL,
  `TAHUN` varchar(20) DEFAULT NULL,
  `TAHUN2` varchar(20) NOT NULL,
  `SEMESTER` varchar(20) DEFAULT NULL,
  `STATUS` decimal(8,0) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data untuk tabel `tahun_ajaran`
--

INSERT INTO `tahun_ajaran` (`TAHUN_AJARAN`, `TAHUN`, `TAHUN2`, `SEMESTER`, `STATUS`) VALUES
('2011-Genap', '2011-', '', 'gasal', '0'),
('2012-Gasal', '2012', '', 'Gasal', '0'),
('2018 / 2019 - Gasal', '2018', '2019', 'Gasal', '0'),
('2019 / 2020 - Gasal', '2019', '2020', 'Gasal', '0'),
('2019-2019-Gasal', '2019-2019', '', 'Gasal', '0'),
('2019-Gasal', '2019', '', 'Gasal', '0'),
('2212-Gasal', '2212', '2213', 'Gasal', '0');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `dabsensi_pegawai`
--
ALTER TABLE `dabsensi_pegawai`
  ADD PRIMARY KEY (`ID_PEGAWAI`,`ID_APEGAWAI`),
  ADD KEY `FK_DABSENSI_PEGAWAI2` (`ID_APEGAWAI`);

--
-- Indexes for table `dabsensi_siswa`
--
ALTER TABLE `dabsensi_siswa`
  ADD PRIMARY KEY (`ID_ASISWA`,`ID_SISWA`),
  ADD KEY `FK_DABSENSI_SISWA2` (`ID_SISWA`);

--
-- Indexes for table `detail_jabatan`
--
ALTER TABLE `detail_jabatan`
  ADD PRIMARY KEY (`ID_MENJABAT`),
  ADD KEY `FK_MENDETAIL_JABATAN` (`ID_JABATAN`),
  ADD KEY `FK_MENJABAT` (`ID_PEGAWAI`);

--
-- Indexes for table `dkelas`
--
ALTER TABLE `dkelas`
  ADD PRIMARY KEY (`ID_SISWA`,`ID_KELAS`),
  ADD KEY `FK_MEMPUNYAI_KELAS2` (`ID_KELAS`);

--
-- Indexes for table `dperizinan_pegawai`
--
ALTER TABLE `dperizinan_pegawai`
  ADD PRIMARY KEY (`ID`),
  ADD KEY `FK_MEMOHON_IZIN` (`ID_PEGAWAI`),
  ADD KEY `FK_MENYETUJUI_IZIN` (`ID_IZIN`);

--
-- Indexes for table `habsensi_pegawai`
--
ALTER TABLE `habsensi_pegawai`
  ADD PRIMARY KEY (`ID_APEGAWAI`),
  ADD KEY `FK_MENGABSEN_PEGAWAI` (`ID_PEGAWAI`),
  ADD KEY `FK_PERIODE_ABSENSI_PEGAWAI` (`TAHUN_AJARAN`);

--
-- Indexes for table `habsensi_siswa`
--
ALTER TABLE `habsensi_siswa`
  ADD PRIMARY KEY (`ID_ASISWA`),
  ADD KEY `FK_DIABSENSI` (`ID_KELAS`),
  ADD KEY `FK_MENGABSEN_SISWA` (`ID_PEGAWAI`),
  ADD KEY `FK_TAHUN_AJARAN_ABSENSI_SISWA` (`TAHUN_AJARAN`);

--
-- Indexes for table `hkelas`
--
ALTER TABLE `hkelas`
  ADD PRIMARY KEY (`ID_KELAS`),
  ADD KEY `FK_KELOMPOK` (`ID_ROMBEL`),
  ADD KEY `FK_MEMBINA_KELAS` (`ID_PEGAWAI`),
  ADD KEY `FK_MENEMPATI` (`ID_RUANG`),
  ADD KEY `FK_PERIODE_KELAS` (`TAHUN_AJARAN`);

--
-- Indexes for table `hperizinan_pegawai`
--
ALTER TABLE `hperizinan_pegawai`
  ADD PRIMARY KEY (`ID_IZIN`),
  ADD KEY `FK_MEMBERI_IZIN` (`ID_PEGAWAI`),
  ADD KEY `FK_TAHUN_AJARAN_PERIZINAN` (`TAHUN_AJARAN`);

--
-- Indexes for table `jabatan`
--
ALTER TABLE `jabatan`
  ADD PRIMARY KEY (`ID_JABATAN`);

--
-- Indexes for table `jadwal`
--
ALTER TABLE `jadwal`
  ADD PRIMARY KEY (`ID_JADWAL`),
  ADD KEY `FK_BERADA` (`ID_KELAS`),
  ADD KEY `FK_MASA_BERLAKU` (`TAHUN_AJARAN`),
  ADD KEY `FK_MENGAJAR` (`ID_PEGAWAI`),
  ADD KEY `FK_MPY_JADWAL` (`ID_MAPEL`);

--
-- Indexes for table `mapel`
--
ALTER TABLE `mapel`
  ADD PRIMARY KEY (`ID_MAPEL`);

--
-- Indexes for table `mutasi_siswa`
--
ALTER TABLE `mutasi_siswa`
  ADD PRIMARY KEY (`ID_MUTASI`),
  ADD KEY `FK_MUTASI` (`ID_SISWA`);

--
-- Indexes for table `pegawai`
--
ALTER TABLE `pegawai`
  ADD PRIMARY KEY (`ID_PEGAWAI`);

--
-- Indexes for table `rombel`
--
ALTER TABLE `rombel`
  ADD PRIMARY KEY (`ID_ROMBEL`);

--
-- Indexes for table `ruang`
--
ALTER TABLE `ruang`
  ADD PRIMARY KEY (`ID_RUANG`);

--
-- Indexes for table `siswa`
--
ALTER TABLE `siswa`
  ADD PRIMARY KEY (`ID_SISWA`);

--
-- Indexes for table `tahun_ajaran`
--
ALTER TABLE `tahun_ajaran`
  ADD PRIMARY KEY (`TAHUN_AJARAN`);

--
-- Ketidakleluasaan untuk tabel pelimpahan (Dumped Tables)
--

--
-- Ketidakleluasaan untuk tabel `dabsensi_pegawai`
--
ALTER TABLE `dabsensi_pegawai`
  ADD CONSTRAINT `FK_DABSENSI_PEGAWAI` FOREIGN KEY (`ID_PEGAWAI`) REFERENCES `pegawai` (`ID_PEGAWAI`),
  ADD CONSTRAINT `FK_DABSENSI_PEGAWAI2` FOREIGN KEY (`ID_APEGAWAI`) REFERENCES `habsensi_pegawai` (`ID_APEGAWAI`);

--
-- Ketidakleluasaan untuk tabel `dabsensi_siswa`
--
ALTER TABLE `dabsensi_siswa`
  ADD CONSTRAINT `FK_DABSENSI_SISWA` FOREIGN KEY (`ID_ASISWA`) REFERENCES `habsensi_siswa` (`ID_ASISWA`),
  ADD CONSTRAINT `FK_DABSENSI_SISWA2` FOREIGN KEY (`ID_SISWA`) REFERENCES `siswa` (`ID_SISWA`);

--
-- Ketidakleluasaan untuk tabel `detail_jabatan`
--
ALTER TABLE `detail_jabatan`
  ADD CONSTRAINT `FK_MENDETAIL_JABATAN` FOREIGN KEY (`ID_JABATAN`) REFERENCES `jabatan` (`ID_JABATAN`),
  ADD CONSTRAINT `FK_MENJABAT` FOREIGN KEY (`ID_PEGAWAI`) REFERENCES `pegawai` (`ID_PEGAWAI`);

--
-- Ketidakleluasaan untuk tabel `dkelas`
--
ALTER TABLE `dkelas`
  ADD CONSTRAINT `FK_MEMPUNYAI_KELAS` FOREIGN KEY (`ID_SISWA`) REFERENCES `siswa` (`ID_SISWA`),
  ADD CONSTRAINT `FK_MEMPUNYAI_KELAS2` FOREIGN KEY (`ID_KELAS`) REFERENCES `hkelas` (`ID_KELAS`);

--
-- Ketidakleluasaan untuk tabel `dperizinan_pegawai`
--
ALTER TABLE `dperizinan_pegawai`
  ADD CONSTRAINT `FK_MEMOHON_IZIN` FOREIGN KEY (`ID_PEGAWAI`) REFERENCES `pegawai` (`ID_PEGAWAI`),
  ADD CONSTRAINT `FK_MENYETUJUI_IZIN` FOREIGN KEY (`ID_IZIN`) REFERENCES `hperizinan_pegawai` (`ID_IZIN`);

--
-- Ketidakleluasaan untuk tabel `habsensi_pegawai`
--
ALTER TABLE `habsensi_pegawai`
  ADD CONSTRAINT `FK_MENGABSEN_PEGAWAI` FOREIGN KEY (`ID_PEGAWAI`) REFERENCES `pegawai` (`ID_PEGAWAI`),
  ADD CONSTRAINT `FK_PERIODE_ABSENSI_PEGAWAI` FOREIGN KEY (`TAHUN_AJARAN`) REFERENCES `tahun_ajaran` (`TAHUN_AJARAN`);

--
-- Ketidakleluasaan untuk tabel `habsensi_siswa`
--
ALTER TABLE `habsensi_siswa`
  ADD CONSTRAINT `FK_DIABSENSI` FOREIGN KEY (`ID_KELAS`) REFERENCES `hkelas` (`ID_KELAS`),
  ADD CONSTRAINT `FK_MENGABSEN_SISWA` FOREIGN KEY (`ID_PEGAWAI`) REFERENCES `pegawai` (`ID_PEGAWAI`),
  ADD CONSTRAINT `FK_TAHUN_AJARAN_ABSENSI_SISWA` FOREIGN KEY (`TAHUN_AJARAN`) REFERENCES `tahun_ajaran` (`TAHUN_AJARAN`);

--
-- Ketidakleluasaan untuk tabel `hkelas`
--
ALTER TABLE `hkelas`
  ADD CONSTRAINT `FK_KELOMPOK` FOREIGN KEY (`ID_ROMBEL`) REFERENCES `rombel` (`ID_ROMBEL`),
  ADD CONSTRAINT `FK_MEMBINA_KELAS` FOREIGN KEY (`ID_PEGAWAI`) REFERENCES `pegawai` (`ID_PEGAWAI`),
  ADD CONSTRAINT `FK_MENEMPATI` FOREIGN KEY (`ID_RUANG`) REFERENCES `ruang` (`ID_RUANG`),
  ADD CONSTRAINT `FK_PERIODE_KELAS` FOREIGN KEY (`TAHUN_AJARAN`) REFERENCES `tahun_ajaran` (`TAHUN_AJARAN`);

--
-- Ketidakleluasaan untuk tabel `hperizinan_pegawai`
--
ALTER TABLE `hperizinan_pegawai`
  ADD CONSTRAINT `FK_MEMBERI_IZIN` FOREIGN KEY (`ID_PEGAWAI`) REFERENCES `pegawai` (`ID_PEGAWAI`),
  ADD CONSTRAINT `FK_TAHUN_AJARAN_PERIZINAN` FOREIGN KEY (`TAHUN_AJARAN`) REFERENCES `tahun_ajaran` (`TAHUN_AJARAN`);

--
-- Ketidakleluasaan untuk tabel `jadwal`
--
ALTER TABLE `jadwal`
  ADD CONSTRAINT `FK_BERADA` FOREIGN KEY (`ID_KELAS`) REFERENCES `hkelas` (`ID_KELAS`),
  ADD CONSTRAINT `FK_MASA_BERLAKU` FOREIGN KEY (`TAHUN_AJARAN`) REFERENCES `tahun_ajaran` (`TAHUN_AJARAN`),
  ADD CONSTRAINT `FK_MENGAJAR` FOREIGN KEY (`ID_PEGAWAI`) REFERENCES `pegawai` (`ID_PEGAWAI`),
  ADD CONSTRAINT `FK_MPY_JADWAL` FOREIGN KEY (`ID_MAPEL`) REFERENCES `mapel` (`ID_MAPEL`);

--
-- Ketidakleluasaan untuk tabel `mutasi_siswa`
--
ALTER TABLE `mutasi_siswa`
  ADD CONSTRAINT `FK_MUTASI` FOREIGN KEY (`ID_SISWA`) REFERENCES `siswa` (`ID_SISWA`);

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
