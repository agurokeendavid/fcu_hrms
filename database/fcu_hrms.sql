-- phpMyAdmin SQL Dump
-- version 5.0.4
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Jan 22, 2021 at 12:39 PM
-- Server version: 10.4.17-MariaDB
-- PHP Version: 8.0.0

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `fcu_hrms`
--

-- --------------------------------------------------------

--
-- Table structure for table `employees`
--

CREATE TABLE `employees` (
  `Id` int(11) NOT NULL,
  `EmployeeNo` varchar(255) NOT NULL,
  `FirstName` varchar(255) NOT NULL,
  `MiddleName` varchar(255) NOT NULL,
  `LastName` varchar(255) NOT NULL,
  `Address` varchar(255) NOT NULL,
  `Gender` varchar(255) NOT NULL,
  `Dob` date NOT NULL,
  `PlaceOfBirth` varchar(255) NOT NULL,
  `ContactNo` varchar(255) NOT NULL,
  `EmailAddress` varchar(255) NOT NULL,
  `CivilStatus` varchar(255) NOT NULL,
  `EmployeeTypeId` int(11) NOT NULL,
  `OfficeId` int(11) NOT NULL,
  `PositionId` int(11) NOT NULL,
  `WorkStatusId` int(11) NOT NULL,
  `HighestDegree` varchar(255) NOT NULL,
  `AcquiredDegree` text NOT NULL,
  `WorkExperience` text NOT NULL,
  `ResumePath` text NOT NULL,
  `DateCreated` datetime NOT NULL DEFAULT current_timestamp()
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `employees`
--

INSERT INTO `employees` (`Id`, `EmployeeNo`, `FirstName`, `MiddleName`, `LastName`, `Address`, `Gender`, `Dob`, `PlaceOfBirth`, `ContactNo`, `EmailAddress`, `CivilStatus`, `EmployeeTypeId`, `OfficeId`, `PositionId`, `WorkStatusId`, `HighestDegree`, `AcquiredDegree`, `WorkExperience`, `ResumePath`, `DateCreated`) VALUES
(7, '0601', 'MARIA CZARINA', 'LOYOLA', 'AGURO', 'BRGY. BOLO', 'FEMALE', '1999-06-01', 'ROXAS CITY', '09451324412', 'mariaczarinaaguro@gmail.com', 'SINGLE', 1, 1, 1, 2, 'COLLEGE DEGREE', 'BSCS - FCU - 2020', 'FCU - TEACHER - 1 YEAR', 'D:\\Keen\\Documents\\Files\\Resume\\0601-Resume0121202112434161.docx', '2021-01-21 12:43:42'),
(8, '0920', 'JEREMAE', 'LOYOLA', 'AGURO', 'BRGY. TIZA', 'FEMALE', '2005-09-20', 'ROXAS CITY', '09093623689', 'jeremaeaguro@gmal.com', 'SINGLE', 2, 2, 3, 1, 'COLLEGE DEGREE', 'CTE - FCU - 2021', 'FCU - SECRETARY - 5 MONTHS', 'D:\\Keen\\Documents\\Files\\Resume\\0920-Resume0121202112474874.docx', '2021-01-21 12:47:50');

-- --------------------------------------------------------

--
-- Table structure for table `employee_types`
--

CREATE TABLE `employee_types` (
  `Id` int(11) NOT NULL,
  `EmployeeTypeName` varchar(255) NOT NULL,
  `DateCreated` datetime NOT NULL DEFAULT current_timestamp()
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `employee_types`
--

INSERT INTO `employee_types` (`Id`, `EmployeeTypeName`, `DateCreated`) VALUES
(1, 'FACULTY', '2021-01-11 22:09:06'),
(2, 'STAFF', '2021-01-11 22:09:06');

-- --------------------------------------------------------

--
-- Table structure for table `leaves`
--

CREATE TABLE `leaves` (
  `Id` int(11) NOT NULL,
  `EmployeeId` int(11) NOT NULL,
  `LeaveTypeId` int(11) NOT NULL,
  `LeaveFrom` date NOT NULL,
  `LeaveTo` date NOT NULL,
  `Reason` varchar(255) NOT NULL,
  `LeaveCredits` double(6,2) NOT NULL,
  `DateCreated` datetime NOT NULL DEFAULT current_timestamp()
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `leaves`
--

INSERT INTO `leaves` (`Id`, `EmployeeId`, `LeaveTypeId`, `LeaveFrom`, `LeaveTo`, `Reason`, `LeaveCredits`, `DateCreated`) VALUES
(29, 7, 3, '2021-01-12', '2021-01-13', 'IMPORTANT', 2.00, '2021-01-21 14:58:31');

-- --------------------------------------------------------

--
-- Table structure for table `leave_types`
--

CREATE TABLE `leave_types` (
  `Id` int(11) NOT NULL,
  `LeaveType` varchar(255) NOT NULL,
  `LeaveCredits` double(6,2) NOT NULL,
  `DateCreated` datetime NOT NULL DEFAULT current_timestamp()
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `leave_types`
--

INSERT INTO `leave_types` (`Id`, `LeaveType`, `LeaveCredits`, `DateCreated`) VALUES
(1, 'SICK LEAVE', 15.00, '2021-01-20 00:00:00'),
(2, 'VACATION LEAVE', 15.00, '2021-01-20 00:00:00'),
(3, 'EMERGENCY LEAVE', 3.00, '2021-01-20 00:00:00');

-- --------------------------------------------------------

--
-- Table structure for table `offices`
--

CREATE TABLE `offices` (
  `Id` int(11) NOT NULL,
  `OfficeName` varchar(255) NOT NULL,
  `DateCreated` datetime NOT NULL DEFAULT current_timestamp()
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `offices`
--

INSERT INTO `offices` (`Id`, `OfficeName`, `DateCreated`) VALUES
(1, 'COLLEGE OF COMPUTER STUDIES', '2021-01-11 22:09:53'),
(2, 'COLLEGE OF BUSINESS AND ACCOUNTANCY', '2021-01-11 22:09:53'),
(3, 'COLLEGE OF HOSPITALITY AND TOURISM MANAGEMENT', '2021-01-21 12:49:19'),
(4, 'COLLEGE OF ARTS AND SCIENCES', '2021-01-21 12:49:37'),
(5, 'COLLEGE OF CRIMINAL JUSTICE EDUCATION', '2021-01-21 12:49:58'),
(6, 'COLLEGE OF ENGINEERING', '2021-01-21 12:50:13'),
(7, 'COLLEGE OF NURSING', '2021-01-21 12:50:30'),
(8, 'COLLEGE OF TECHERS EDUCATION', '2021-01-21 12:50:48'),
(9, 'PRESIDENT\'S OFFICE', '2021-01-21 12:51:22'),
(10, 'N/A', '2021-01-21 12:54:27');

-- --------------------------------------------------------

--
-- Table structure for table `positions`
--

CREATE TABLE `positions` (
  `Id` int(11) NOT NULL,
  `PositionName` varchar(255) NOT NULL,
  `DateCreated` datetime NOT NULL DEFAULT current_timestamp()
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `positions`
--

INSERT INTO `positions` (`Id`, `PositionName`, `DateCreated`) VALUES
(1, 'TEACHER', '2021-01-11 22:10:33'),
(3, 'SECRETARY', '2021-01-21 12:51:54'),
(4, 'DEAN', '2021-01-21 12:51:58'),
(5, 'JANITOR', '2021-01-21 12:52:15'),
(6, 'N/A', '2021-01-21 12:54:07');

-- --------------------------------------------------------

--
-- Table structure for table `seminars`
--

CREATE TABLE `seminars` (
  `Id` int(11) NOT NULL,
  `EmployeeId` int(11) NOT NULL,
  `SeminarName` varchar(255) NOT NULL,
  `SeminarLevelId` int(11) NOT NULL,
  `CertificatePath` text NOT NULL,
  `DateCreated` datetime NOT NULL DEFAULT current_timestamp()
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `seminars`
--

INSERT INTO `seminars` (`Id`, `EmployeeId`, `SeminarName`, `SeminarLevelId`, `CertificatePath`, `DateCreated`) VALUES
(4, 6, 'PROGRAMMING', 2, 'D:\\Keen\\Documents\\Files\\Certificates\\123-Certificate0121202110290142.pdf', '2021-01-21 10:29:02'),
(5, 7, 'PROGRAMMINH', 4, 'D:\\Keen\\Documents\\Files\\Certificates\\0601-Certificate0121202103182324.doc', '2021-01-21 15:18:24');

-- --------------------------------------------------------

--
-- Table structure for table `seminar_level`
--

CREATE TABLE `seminar_level` (
  `Id` int(11) NOT NULL,
  `SeminarLevelName` varchar(255) NOT NULL,
  `Points` int(4) NOT NULL,
  `DateCreated` datetime NOT NULL DEFAULT current_timestamp()
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `seminar_level`
--

INSERT INTO `seminar_level` (`Id`, `SeminarLevelName`, `Points`, `DateCreated`) VALUES
(1, 'LOCAL', 1, '2021-01-12 01:30:41'),
(2, 'REGIONAL', 2, '2021-01-12 01:30:41'),
(3, 'NATIONAL', 3, '2021-01-12 08:15:09'),
(4, 'INTERNATIONAL', 4, '2021-01-12 08:15:09');

-- --------------------------------------------------------

--
-- Table structure for table `users`
--

CREATE TABLE `users` (
  `Id` int(11) NOT NULL,
  `Username` varchar(255) NOT NULL,
  `Password` varchar(255) NOT NULL,
  `FirstName` varchar(255) NOT NULL,
  `MiddleName` varchar(255) NOT NULL,
  `LastName` varchar(255) NOT NULL,
  `DateCreated` datetime NOT NULL DEFAULT current_timestamp()
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `users`
--

INSERT INTO `users` (`Id`, `Username`, `Password`, `FirstName`, `MiddleName`, `LastName`, `DateCreated`) VALUES
(1, 'admin', 'd033e22ae348aeb5660fc2140aec35850c4da997', 'MARIA CZARINA', 'LOYOLA', 'AGURO', '2021-01-11 14:15:11');

-- --------------------------------------------------------

--
-- Table structure for table `work_status`
--

CREATE TABLE `work_status` (
  `Id` int(11) NOT NULL,
  `WorkStatusName` varchar(255) NOT NULL,
  `DateCreated` datetime NOT NULL DEFAULT current_timestamp()
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `work_status`
--

INSERT INTO `work_status` (`Id`, `WorkStatusName`, `DateCreated`) VALUES
(1, 'REGULAR', '2021-01-11 22:10:48'),
(2, 'JOB ORDER', '2021-01-11 22:10:48');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `employees`
--
ALTER TABLE `employees`
  ADD PRIMARY KEY (`Id`);

--
-- Indexes for table `employee_types`
--
ALTER TABLE `employee_types`
  ADD PRIMARY KEY (`Id`);

--
-- Indexes for table `leaves`
--
ALTER TABLE `leaves`
  ADD PRIMARY KEY (`Id`);

--
-- Indexes for table `leave_types`
--
ALTER TABLE `leave_types`
  ADD PRIMARY KEY (`Id`);

--
-- Indexes for table `offices`
--
ALTER TABLE `offices`
  ADD PRIMARY KEY (`Id`);

--
-- Indexes for table `positions`
--
ALTER TABLE `positions`
  ADD PRIMARY KEY (`Id`);

--
-- Indexes for table `seminars`
--
ALTER TABLE `seminars`
  ADD PRIMARY KEY (`Id`);

--
-- Indexes for table `seminar_level`
--
ALTER TABLE `seminar_level`
  ADD PRIMARY KEY (`Id`);

--
-- Indexes for table `users`
--
ALTER TABLE `users`
  ADD PRIMARY KEY (`Id`);

--
-- Indexes for table `work_status`
--
ALTER TABLE `work_status`
  ADD PRIMARY KEY (`Id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `employees`
--
ALTER TABLE `employees`
  MODIFY `Id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=9;

--
-- AUTO_INCREMENT for table `employee_types`
--
ALTER TABLE `employee_types`
  MODIFY `Id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT for table `leaves`
--
ALTER TABLE `leaves`
  MODIFY `Id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=30;

--
-- AUTO_INCREMENT for table `leave_types`
--
ALTER TABLE `leave_types`
  MODIFY `Id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT for table `offices`
--
ALTER TABLE `offices`
  MODIFY `Id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;

--
-- AUTO_INCREMENT for table `positions`
--
ALTER TABLE `positions`
  MODIFY `Id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;

--
-- AUTO_INCREMENT for table `seminars`
--
ALTER TABLE `seminars`
  MODIFY `Id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- AUTO_INCREMENT for table `seminar_level`
--
ALTER TABLE `seminar_level`
  MODIFY `Id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT for table `users`
--
ALTER TABLE `users`
  MODIFY `Id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT for table `work_status`
--
ALTER TABLE `work_status`
  MODIFY `Id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
