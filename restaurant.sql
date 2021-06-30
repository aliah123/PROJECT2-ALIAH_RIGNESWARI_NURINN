-- phpMyAdmin SQL Dump
-- version 5.0.4
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Jun 30, 2021 at 11:26 AM
-- Server version: 10.4.17-MariaDB
-- PHP Version: 7.4.15

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `restaurant`
--

-- --------------------------------------------------------

--
-- Table structure for table `chef`
--

CREATE TABLE `chef` (
  `idchef` int(11) NOT NULL,
  `namechef` varchar(100) NOT NULL,
  `positionChef` varchar(50) NOT NULL,
  `phoneNumChef` varchar(12) NOT NULL,
  `genderChef` varchar(6) NOT NULL,
  `dateInChargeChef` varchar(30) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `chef`
--

INSERT INTO `chef` (`idchef`, `namechef`, `positionChef`, `phoneNumChef`, `genderChef`, `dateInChargeChef`) VALUES
(4, 'Ibrahim', 'Western food', '01245674322', 'male', 'night-7pm');

-- --------------------------------------------------------

--
-- Table structure for table `customer`
--

CREATE TABLE `customer` (
  `idcustomer` int(4) NOT NULL,
  `nameCus` varchar(11) NOT NULL,
  `ageCus` int(11) NOT NULL,
  `addressCus` varchar(30) NOT NULL,
  `phoneNumCus` int(11) NOT NULL,
  `genderCus` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `customer`
--

INSERT INTO `customer` (`idcustomer`, `nameCus`, `ageCus`, `addressCus`, `phoneNumCus`, `genderCus`) VALUES
(8, 'Darwish', 23, 'taman kempas', 1247856933, 'male'),
(9, 'farah', 20, 'kulim', 193847875, 'female');

-- --------------------------------------------------------

--
-- Table structure for table `food`
--

CREATE TABLE `food` (
  `idfood` int(11) NOT NULL,
  `itemCode` varchar(20) NOT NULL,
  `nameFood` varchar(250) NOT NULL,
  `quantity` int(3) NOT NULL,
  `type` varchar(30) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `food`
--

INSERT INTO `food` (`idfood`, `itemCode`, `nameFood`, `quantity`, `type`) VALUES
(4, 'IC001', 'maggi goreng', 2, 'spicy'),
(5, 'IC123', 'nasi goreng', 1, 'no spicy');

-- --------------------------------------------------------

--
-- Table structure for table `staff`
--

CREATE TABLE `staff` (
  `idstaff` int(4) NOT NULL,
  `nameStaff` varchar(100) NOT NULL,
  `positionStaff` varchar(50) NOT NULL,
  `phoneNumStaff` varchar(12) NOT NULL,
  `genderStaff` varchar(6) NOT NULL,
  `dateInChargeStaff` varchar(30) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `staff`
--

INSERT INTO `staff` (`idstaff`, `nameStaff`, `positionStaff`, `phoneNumStaff`, `genderStaff`, `dateInChargeStaff`) VALUES
(2, 'Habsah', 'waiter', '01547902468', 'female', 'morning-6am');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `chef`
--
ALTER TABLE `chef`
  ADD PRIMARY KEY (`idchef`);

--
-- Indexes for table `customer`
--
ALTER TABLE `customer`
  ADD PRIMARY KEY (`idcustomer`);

--
-- Indexes for table `food`
--
ALTER TABLE `food`
  ADD PRIMARY KEY (`idfood`);

--
-- Indexes for table `staff`
--
ALTER TABLE `staff`
  ADD PRIMARY KEY (`idstaff`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `chef`
--
ALTER TABLE `chef`
  MODIFY `idchef` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT for table `customer`
--
ALTER TABLE `customer`
  MODIFY `idcustomer` int(4) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=10;

--
-- AUTO_INCREMENT for table `food`
--
ALTER TABLE `food`
  MODIFY `idfood` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- AUTO_INCREMENT for table `staff`
--
ALTER TABLE `staff`
  MODIFY `idstaff` int(4) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
