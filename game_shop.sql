-- phpMyAdmin SQL Dump
-- version 5.2.0
-- https://www.phpmyadmin.net/
--
-- Host: localhost
-- Generation Time: May 30, 2023 at 10:06 AM
-- Server version: 10.4.27-MariaDB
-- PHP Version: 8.2.0

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `game_shop`
--
CREATE DATABASE IF NOT EXISTS `game_shop` DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci;
USE `game_shop`;

-- --------------------------------------------------------

--
-- Table structure for table `admin`
--
-- Creation: May 30, 2023 at 08:05 AM
--

CREATE TABLE IF NOT EXISTS `admin` (
  `admin_id` int(11) NOT NULL AUTO_INCREMENT,
  `admin_username` varchar(35) NOT NULL,
  `admin_password` varchar(35) NOT NULL,
  PRIMARY KEY (`admin_id`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `admin`
--

INSERT INTO `admin` (`admin_id`, `admin_username`, `admin_password`) VALUES
(1, 'admin', 'admin');

-- --------------------------------------------------------

--
-- Table structure for table `games`
--
-- Creation: May 30, 2023 at 08:05 AM
--

CREATE TABLE IF NOT EXISTS `games` (
  `game_id` int(11) NOT NULL AUTO_INCREMENT,
  `game_name` varchar(30) NOT NULL,
  `game_category` varchar(35) NOT NULL,
  `game_picture` varchar(50) NOT NULL,
  `game_price` float NOT NULL,
  PRIMARY KEY (`game_id`)
) ENGINE=InnoDB AUTO_INCREMENT=11 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `games`
--

INSERT INTO `games` (`game_id`, `game_name`, `game_category`, `game_picture`, `game_price`) VALUES
(1, 'Grand Theft Auto: San Andreas', 'action-adventure', 'gta_san_andreas.jpg', 20),
(2, 'Call of Duty 2', 'first-person shooter video game', 'cod2.jpg', 10),
(3, 'Minecraft', 'sandbox survival', 'minecraft.jpg', 30),
(4, 'Counter-Strike 1.6', 'tactical first-person shooter game', 'cs16.jpg', 10),
(5, 'FIFA 22', 'sports', 'fifa22.jpg', 60),
(6, 'NBA 2K22', 'sports', 'nba2k22.jpg', 50),
(7, 'Rocket League', 'sports', 'rocket_league.png', 20),
(8, 'Assassin\'s Creed III', 'action-adventure, stealth', 'assassin.jpg', 15),
(9, 'Euro Truck Simulator 2', 'vehicle simulation', 'euro_truck2.jpg', 25),
(10, 'The Sims 4', 'Social simulation', 'sims4.jpg', 30);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
