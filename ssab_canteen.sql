-- phpMyAdmin SQL Dump
-- version 5.2.0
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Jun 28, 2025 at 04:24 AM
-- Server version: 10.4.27-MariaDB
-- PHP Version: 8.1.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `ssab_canteen`
--

-- --------------------------------------------------------

--
-- Table structure for table `accounts`
--

CREATE TABLE `accounts` (
  `employee_id` int(11) NOT NULL,
  `firstname` varchar(25) DEFAULT NULL,
  `lastname` varchar(25) DEFAULT NULL,
  `username` varchar(25) DEFAULT NULL,
  `password` varchar(25) DEFAULT NULL,
  `role` varchar(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `accounts`
--

INSERT INTO `accounts` (`employee_id`, `firstname`, `lastname`, `username`, `password`, `role`) VALUES
(5, 'Ben', 'Piñon', 'test', '123', 'admin'),
(6, 'Jade', 'Kristhel', 'test1', '123', 'cashier'),
(8, 'John', 'Wick', NULL, NULL, ''),
(9, 'Quas', 'Suo', 'test2', '123', 'admin');

-- --------------------------------------------------------

--
-- Table structure for table `credit_items`
--

CREATE TABLE `credit_items` (
  `id` int(11) NOT NULL,
  `credit_id` int(11) NOT NULL,
  `item_id` int(11) NOT NULL,
  `qty` int(11) NOT NULL,
  `cost_price` decimal(10,2) NOT NULL,
  `total_price` decimal(10,2) GENERATED ALWAYS AS (`qty` * `cost_price`) STORED
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `credit_items`
--

INSERT INTO `credit_items` (`id`, `credit_id`, `item_id`, `qty`, `cost_price`) VALUES
(4, 4, 16, 3, '20.00'),
(5, 5, 17, 2, '12.50'),
(6, 5, 21, 2, '28.00'),
(7, 5, 22, 1, '10.00'),
(8, 6, 16, 1, '20.00');

-- --------------------------------------------------------

--
-- Table structure for table `credit_transactions`
--

CREATE TABLE `credit_transactions` (
  `credit_id` int(11) NOT NULL,
  `employee_id` int(11) NOT NULL,
  `total_price` decimal(10,2) DEFAULT 0.00,
  `amount_paid` decimal(10,2) DEFAULT 0.00,
  `status` varchar(20) DEFAULT 'unpaid',
  `date_created` datetime DEFAULT current_timestamp()
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `credit_transactions`
--

INSERT INTO `credit_transactions` (`credit_id`, `employee_id`, `total_price`, `amount_paid`, `status`, `date_created`) VALUES
(4, 8, '60.00', '0.00', 'unpaid', '2025-06-26 00:17:06'),
(5, 8, '91.00', '0.00', 'unpaid', '2025-06-26 00:18:11'),
(6, 8, '20.00', '0.00', 'unpaid', '2025-06-26 20:09:50');

-- --------------------------------------------------------

--
-- Table structure for table `items`
--

CREATE TABLE `items` (
  `item_id` int(11) NOT NULL,
  `barcode` varchar(50) DEFAULT NULL,
  `name` varchar(50) DEFAULT NULL,
  `quantity` int(11) DEFAULT NULL,
  `cost_price` decimal(10,2) NOT NULL,
  `price` decimal(10,2) NOT NULL,
  `date_added` datetime DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `items`
--

INSERT INTO `items` (`item_id`, `barcode`, `name`, `quantity`, `cost_price`, `price`, `date_added`) VALUES
(16, '4800011122212', 'test', 2, '20.00', '20.00', '2025-06-14 11:39:18'),
(17, '7358291745623', 'Choco Crunch Bar', 42, '12.50', '20.00', '2025-06-23 00:00:00'),
(18, '2846173950281', 'Sparkle Water 500ml', 95, '8.00', '15.00', '2025-06-23 00:00:00'),
(19, '9841736250937', 'Instant Noodles - Chicken', 197, '5.25', '10.00', '2025-06-23 00:00:00'),
(20, '1265938471032', 'Toothpaste Mint 100g', 75, '18.00', '30.00', '2025-06-23 00:00:00'),
(21, '7362948502714', 'Shampoo Herbal 250ml', 58, '28.00', '45.00', '2025-06-23 00:00:00'),
(22, '4839201765248', 'Notebook - A5', 114, '10.00', '18.00', '2025-06-23 00:00:00'),
(23, '7593840217593', 'Ballpen Blue Ink', 300, '3.50', '7.00', '2025-06-23 00:00:00'),
(24, '5918374620192', 'Sardines in Oil 155g', 150, '13.00', '22.00', '2025-06-23 00:00:00'),
(25, '8473926150824', 'Laundry Bar Soap', 90, '9.75', '17.00', '2025-06-23 00:00:00'),
(26, '1093847265813', 'Pack of Tissues', 130, '6.25', '12.00', '2025-06-23 00:00:00');

-- --------------------------------------------------------

--
-- Table structure for table `sales`
--

CREATE TABLE `sales` (
  `sale_id` int(11) NOT NULL,
  `item_id` int(11) NOT NULL,
  `employee_id` int(11) NOT NULL,
  `qty` int(11) NOT NULL,
  `price` decimal(10,2) NOT NULL,
  `total_price` decimal(10,2) NOT NULL,
  `date_created` datetime NOT NULL DEFAULT current_timestamp()
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `sales`
--

INSERT INTO `sales` (`sale_id`, `item_id`, `employee_id`, `qty`, `price`, `total_price`, `date_created`) VALUES
(1, 17, 6, 2, '20.00', '40.00', '2025-06-27 09:00:00'),
(2, 19, 6, 3, '10.00', '30.00', '2025-06-27 09:00:00'),
(3, 20, 6, 1, '30.00', '30.00', '2025-06-27 11:00:00'),
(4, 21, 6, 1, '45.00', '45.00', '2025-06-27 11:00:00'),
(5, 18, 6, 2, '15.00', '30.00', '2025-06-27 13:00:00'),
(6, 22, 6, 2, '18.00', '36.00', '2025-06-27 13:00:00'),
(7, 23, 6, 3, '7.00', '21.00', '2025-06-27 15:00:00'),
(8, 24, 6, 1, '22.00', '22.00', '2025-06-27 15:00:00'),
(9, 25, 6, 2, '17.00', '34.00', '2025-06-27 17:00:00'),
(10, 26, 6, 2, '12.00', '24.00', '2025-06-27 17:00:00'),
(11, 16, 6, 1, '20.00', '20.00', '2025-06-27 19:39:23'),
(12, 16, 6, 1, '20.00', '20.00', '2025-06-27 19:40:56'),
(13, 16, 6, 1, '20.00', '20.00', '2025-06-27 19:40:56'),
(14, 16, 6, 1, '20.00', '20.00', '2025-06-27 19:40:56');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `accounts`
--
ALTER TABLE `accounts`
  ADD PRIMARY KEY (`employee_id`);

--
-- Indexes for table `credit_items`
--
ALTER TABLE `credit_items`
  ADD PRIMARY KEY (`id`),
  ADD KEY `credit_id` (`credit_id`),
  ADD KEY `item_id` (`item_id`);

--
-- Indexes for table `credit_transactions`
--
ALTER TABLE `credit_transactions`
  ADD PRIMARY KEY (`credit_id`),
  ADD KEY `employee_id` (`employee_id`);

--
-- Indexes for table `items`
--
ALTER TABLE `items`
  ADD PRIMARY KEY (`item_id`);

--
-- Indexes for table `sales`
--
ALTER TABLE `sales`
  ADD PRIMARY KEY (`sale_id`),
  ADD KEY `item_id` (`item_id`),
  ADD KEY `employee_id` (`employee_id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `accounts`
--
ALTER TABLE `accounts`
  MODIFY `employee_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=10;

--
-- AUTO_INCREMENT for table `credit_items`
--
ALTER TABLE `credit_items`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=9;

--
-- AUTO_INCREMENT for table `credit_transactions`
--
ALTER TABLE `credit_transactions`
  MODIFY `credit_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;

--
-- AUTO_INCREMENT for table `items`
--
ALTER TABLE `items`
  MODIFY `item_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=27;

--
-- AUTO_INCREMENT for table `sales`
--
ALTER TABLE `sales`
  MODIFY `sale_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=15;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `credit_items`
--
ALTER TABLE `credit_items`
  ADD CONSTRAINT `credit_items_ibfk_1` FOREIGN KEY (`credit_id`) REFERENCES `credit_transactions` (`credit_id`) ON DELETE CASCADE,
  ADD CONSTRAINT `credit_items_ibfk_2` FOREIGN KEY (`item_id`) REFERENCES `items` (`item_id`) ON DELETE CASCADE;

--
-- Constraints for table `credit_transactions`
--
ALTER TABLE `credit_transactions`
  ADD CONSTRAINT `credit_transactions_ibfk_1` FOREIGN KEY (`employee_id`) REFERENCES `accounts` (`employee_id`) ON DELETE CASCADE;

--
-- Constraints for table `sales`
--
ALTER TABLE `sales`
  ADD CONSTRAINT `sales_ibfk_1` FOREIGN KEY (`item_id`) REFERENCES `items` (`item_id`),
  ADD CONSTRAINT `sales_ibfk_2` FOREIGN KEY (`employee_id`) REFERENCES `accounts` (`employee_id`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
