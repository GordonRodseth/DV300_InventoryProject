-- phpMyAdmin SQL Dump
-- version 5.0.2
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1:3306
-- Generation Time: Apr 08, 2022 at 03:32 PM
-- Server version: 5.7.31
-- PHP Version: 7.4.9

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `inventory`
--

-- --------------------------------------------------------

--
-- Table structure for table `breed`
--

DROP TABLE IF EXISTS `breed`;
CREATE TABLE IF NOT EXISTS `breed` (
  `id` int(255) NOT NULL AUTO_INCREMENT,
  `breed_name` varchar(255) NOT NULL,
  `parent1_id` int(255) NOT NULL,
  `parent2_id` int(255) NOT NULL,
  `img_url` varchar(255) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=MyISAM AUTO_INCREMENT=57 DEFAULT CHARSET=latin1;

--
-- Dumping data for table `breed`
--

INSERT INTO `breed` (`id`, `breed_name`, `parent1_id`, `parent2_id`, `img_url`) VALUES
(5, 'Cocker Spaniel', 5, 5, 'Cocker_Spaniel'),
(4, 'Chihuahua', 4, 4, 'Chihuahua'),
(3, 'Bichon Frise', 3, 3, 'bichon_frise'),
(2, 'Beagle', 2, 2, 'Beagle'),
(1, 'Australian Shepherd', 1, 1, 'Aussie_Shepherd'),
(27, 'Australian Cattle Dog', 27, 27, 'Aus_Cattle_Dog'),
(6, 'Border Collie', 6, 6, 'Collie'),
(7, 'Corgi', 7, 7, 'Corgi'),
(8, 'Daschund', 8, 8, 'Daschund'),
(9, 'English Springer Spaniel', 9, 9, 'English_Springer_Spaniel'),
(10, 'German Shepherd', 10, 10, 'german_shepherd'),
(11, 'Golden Retriever', 11, 11, 'Golden_Retriever'),
(12, 'Greyhound', 12, 12, 'Greyhound'),
(13, 'Husky', 13, 13, 'husky'),
(14, 'Jack Russel', 14, 14, 'Jack_Russel'),
(15, 'King Charles Spaniel', 15, 15, 'KC_Spaniel'),
(16, 'Labrador', 16, 16, 'Labrador'),
(17, 'Maltese Poodle', 17, 17, 'Maltese_Poodle'),
(18, 'Pekingese', 18, 18, 'pekingese'),
(19, 'Pointer', 19, 19, 'pointer'),
(20, 'Pomeranian', 20, 20, 'Pomeranian'),
(21, 'Poodle', 21, 21, 'Poodle'),
(22, 'Pug', 22, 22, 'pug'),
(23, 'Schnauzer', 23, 23, 'Schnauzer'),
(24, 'Shih Tzu', 24, 24, 'Shih_tzu'),
(25, 'West Highlands Terrier', 25, 25, 'WH_terrier'),
(26, 'Yorkshire Terrier', 26, 26, 'Yorkie'),
(28, 'Sheepdog', 28, 28, 'Sheepdog'),
(29, 'Beaglier', 15, 2, 'beaglier'),
(30, 'Cavoodle', 15, 21, 'cavoodle'),
(31, 'Chiweenie', 4, 8, 'chiweenie'),
(32, 'Chorkie', 4, 26, 'chorki'),
(33, 'Chug', 4, 22, 'chug'),
(34, 'Cockapoo', 5, 21, 'cockapoo'),
(35, 'Dorgi', 8, 4, 'dorgi'),
(36, 'Eurohound', 13, 19, 'eurohound'),
(37, 'Gerberian', 10, 13, 'gerberian'),
(38, 'Goldador', 11, 16, 'goldador'),
(39, 'Goldendoodle', 11, 21, 'goldendoodle'),
(40, 'Jackabee', 14, 2, 'jackabee'),
(41, 'Jug', 14, 22, 'jug'),
(42, 'Labradoodle', 16, 21, 'labradoodle'),
(43, 'Lurcher', 6, 12, 'lurcher'),
(44, 'Mal Shih', 17, 24, 'malshih'),
(45, 'Maltipoo', 17, 21, 'maltipoo'),
(46, 'Peekapoo', 18, 21, 'pekapoo'),
(47, 'Pomchi', 20, 4, 'pomchi'),
(48, 'Puggle', 22, 2, 'puggle'),
(49, 'Schnoodle', 23, 21, 'schnoodle'),
(50, 'Sheepadoodle', 28, 21, 'sheepadoodle'),
(51, 'Shih Poo', 24, 21, 'shihpoo'),
(52, 'Springador', 9, 16, 'springador'),
(53, 'Texas Heeler', 27, 1, 'texasheeler'),
(54, 'Westiepoo', 25, 21, 'westiepoo'),
(55, 'Yorkiepoo', 26, 21, 'yorkipoo'),
(56, 'Zuchon', 24, 3, 'zuchon');

-- --------------------------------------------------------

--
-- Table structure for table `breeders`
--

DROP TABLE IF EXISTS `breeders`;
CREATE TABLE IF NOT EXISTS `breeders` (
  `license_num` varchar(255) NOT NULL,
  `breeder_name` varchar(255) NOT NULL,
  `breeder_surname` varchar(255) NOT NULL,
  PRIMARY KEY (`license_num`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Dumping data for table `breeders`
--

INSERT INTO `breeders` (`license_num`, `breeder_name`, `breeder_surname`) VALUES
('12345', 'user', 'user'),
('7110eda4d09e062aa5e4a390b0a572ac0d2c0220', 'breeder', 'breeder');

-- --------------------------------------------------------

--
-- Table structure for table `dogs`
--

DROP TABLE IF EXISTS `dogs`;
CREATE TABLE IF NOT EXISTS `dogs` (
  `id` int(255) NOT NULL AUTO_INCREMENT,
  `name` varchar(255) NOT NULL,
  `breed_id` int(255) NOT NULL,
  `mother_id` int(255) NOT NULL,
  `father_id` int(255) NOT NULL,
  `kennel_id` int(255) NOT NULL,
  `pedigree` varchar(255) NOT NULL,
  `sex` varchar(10) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=MyISAM AUTO_INCREMENT=27 DEFAULT CHARSET=latin1;

--
-- Dumping data for table `dogs`
--

INSERT INTO `dogs` (`id`, `name`, `breed_id`, `mother_id`, `father_id`, `kennel_id`, `pedigree`, `sex`) VALUES
(12, 'Bebo', 2, 0, 0, 1, 'Purebred', 'male'),
(11, 'Labby', 16, 0, 0, 1, 'Purebred', 'male'),
(13, 'Corgo', 7, 0, 0, 2, 'Purebred', 'male'),
(16, 'Puggle', 22, 0, 0, 3, 'Purebred', 'male'),
(24, 'Bella', 4, 0, 0, 1, 'Purebred', 'female'),
(23, 'Backo', 10, 0, 0, 1, 'Purebred', 'female'),
(25, 'Winnie', 21, 0, 0, 1, 'Purebred', 'female');
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
