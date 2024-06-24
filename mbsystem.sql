-- phpMyAdmin SQL Dump
-- version 4.1.12
-- http://www.phpmyadmin.net
--
-- Host: 127.0.0.1
-- Generation Time: Feb 21, 2016 at 02:01 AM
-- Server version: 5.6.16
-- PHP Version: 5.5.11

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

--
-- Database: `mbsystem`
--

-- --------------------------------------------------------

--
-- Table structure for table `1stsemster`
--

CREATE TABLE IF NOT EXISTS `1stsemster` (
  `firstsem_id` int(10) NOT NULL AUTO_INCREMENT,
  `stud_id` varchar(25) NOT NULL,
  `CCode` varchar(25) NOT NULL,
  `YearLevelONE` varchar(25) NOT NULL,
  `SchoolYearOne` varchar(255) NOT NULL,
  `Payment` varchar(25) NOT NULL,
  `STATUS` varchar(25) NOT NULL,
  `expiredDate` varchar(30) NOT NULL,
  PRIMARY KEY (`firstsem_id`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=8 ;

--
-- Dumping data for table `1stsemster`
--

INSERT INTO `1stsemster` (`firstsem_id`, `stud_id`, `CCode`, `YearLevelONE`, `SchoolYearOne`, `Payment`, `STATUS`, `expiredDate`) VALUES
(6, '43-53464-3', 'ICT', '3rd Year', '2015-2016', '50', 'EXPIRED', '2/19/2016'),
(7, '32-43343-4', 'ICT', '3rd Year', '2015-2016', '99', 'EXPIRED', '2/19/2016');

-- --------------------------------------------------------

--
-- Table structure for table `2ndsemester`
--

CREATE TABLE IF NOT EXISTS `2ndsemester` (
  `SecondSem_id` int(10) NOT NULL AUTO_INCREMENT,
  `stud_id` varchar(25) NOT NULL,
  `course` varchar(25) NOT NULL,
  `YearLevelTwo` varchar(25) NOT NULL,
  `SchoolYearTwo` varchar(25) NOT NULL,
  `SecondPayment` varchar(25) NOT NULL,
  `SecondSTATUS` varchar(25) NOT NULL,
  `expiredDate` varchar(30) NOT NULL,
  PRIMARY KEY (`SecondSem_id`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=2 ;

--
-- Dumping data for table `2ndsemester`
--

INSERT INTO `2ndsemester` (`SecondSem_id`, `stud_id`, `course`, `YearLevelTwo`, `SchoolYearTwo`, `SecondPayment`, `SecondSTATUS`, `expiredDate`) VALUES
(1, '2123', '3213', '3123', '3213', 'fdsf', 'fddsf', 'fsdf');

-- --------------------------------------------------------

--
-- Table structure for table `cntact_tbl`
--

CREATE TABLE IF NOT EXISTS `cntact_tbl` (
  `c_id` int(10) NOT NULL AUTO_INCREMENT,
  `Stud_id` varchar(255) NOT NULL,
  `ConAddress` varchar(255) NOT NULL,
  `ConPerson` varchar(255) NOT NULL,
  `ConNumber` varchar(255) NOT NULL,
  `Address` varchar(255) NOT NULL,
  `PhoneNumber` varchar(255) NOT NULL,
  PRIMARY KEY (`c_id`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=4 ;

--
-- Dumping data for table `cntact_tbl`
--

INSERT INTO `cntact_tbl` (`c_id`, `Stud_id`, `ConAddress`, `ConPerson`, `ConNumber`, `Address`, `PhoneNumber`) VALUES
(1, '43-24324-2', 'GFDG', 'FGF', '09674564364', 'TRETGRT', '09976865745'),
(2, '43-53464-3', 'FGGFDG', 'GFDGGFD', '09769678658', 'FRGGG', '09678657566'),
(3, '32-43343-4', 'GULOD NAIC CAVITE', 'IRENE ORTIZ', '09331668549', 'GULOD NAIC CAVITE', '09155154026');

-- --------------------------------------------------------

--
-- Table structure for table `course`
--

CREATE TABLE IF NOT EXISTS `course` (
  `c_id` int(11) NOT NULL AUTO_INCREMENT,
  `Cname` varchar(255) NOT NULL,
  `Ccode` varchar(255) NOT NULL,
  PRIMARY KEY (`c_id`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=2 ;

--
-- Dumping data for table `course`
--

INSERT INTO `course` (`c_id`, `Cname`, `Ccode`) VALUES
(1, 'Information Communication Technology', 'ICT');

-- --------------------------------------------------------

--
-- Table structure for table `expiration`
--

CREATE TABLE IF NOT EXISTS `expiration` (
  `e_id` int(10) NOT NULL AUTO_INCREMENT,
  `semester` varchar(255) NOT NULL,
  `schoolYear` varchar(255) NOT NULL,
  `expiredDate` varchar(255) NOT NULL,
  PRIMARY KEY (`e_id`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=3 ;

--
-- Dumping data for table `expiration`
--

INSERT INTO `expiration` (`e_id`, `semester`, `schoolYear`, `expiredDate`) VALUES
(1, '1st Semester', '2015-2016', '1/15/2017'),
(2, '2nd Semester', '2015-2016', '2/19/2016');

-- --------------------------------------------------------

--
-- Table structure for table `info`
--

CREATE TABLE IF NOT EXISTS `info` (
  `s_id` int(10) NOT NULL AUTO_INCREMENT,
  `Lastname` varchar(255) NOT NULL,
  `Firstname` varchar(255) NOT NULL,
  `Middlename` varchar(255) NOT NULL,
  `Birthdate` varchar(255) NOT NULL,
  `YL` varchar(255) NOT NULL,
  `Section` varchar(255) NOT NULL,
  `Age` varchar(10) NOT NULL,
  `Gender` varchar(10) NOT NULL,
  `email` varchar(255) NOT NULL,
  `Course` varchar(255) NOT NULL,
  `SY` varchar(255) NOT NULL,
  `StudentNo` varchar(255) NOT NULL,
  PRIMARY KEY (`s_id`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=4 ;

--
-- Dumping data for table `info`
--

INSERT INTO `info` (`s_id`, `Lastname`, `Firstname`, `Middlename`, `Birthdate`, `YL`, `Section`, `Age`, `Gender`, `email`, `Course`, `SY`, `StudentNo`) VALUES
(2, 'DSFDSF', 'FDSDF', 'FDSF', 'Monday, December 26, 1988', '3rd Year', 'A', ' 27', 'FEMALE', 'aff@.com', 'ICT', '2015-2016', '43-53464-3'),
(3, 'ORTIZ', 'AIRAMAE', 'PANGILINAN', 'Tuesday, June 10, 1997', '3rd Year', 'NONE', ' 18', 'FEMALE', 'airamae2218@gmail.com', 'ICT', '2015-2016', '32-43343-4');

-- --------------------------------------------------------

--
-- Table structure for table `logrecord`
--

CREATE TABLE IF NOT EXISTS `logrecord` (
  `l_id` int(10) NOT NULL AUTO_INCREMENT,
  `Name` varchar(255) NOT NULL,
  `DateLog` varchar(255) NOT NULL,
  `TimeLog` varchar(255) NOT NULL,
  `Status` varchar(255) NOT NULL,
  PRIMARY KEY (`l_id`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=624 ;

--
-- Dumping data for table `logrecord`
--

INSERT INTO `logrecord` (`l_id`, `Name`, `DateLog`, `TimeLog`, `Status`) VALUES
(1, 'AIRAMAE', 'Sunday, February 14, 2016', '1:03 PM', 'LOGIN'),
(2, 'AIRAMAE', 'Sunday, February 14, 2016', '1:05 PM', 'LOGIN'),
(3, 'AIRAMAE', 'Sunday, February 14, 2016', '1:07 PM', 'LOGIN'),
(4, 'AIRAMAE', 'Sunday, February 14, 2016', '1:13 PM', 'LOGIN'),
(5, 'AIRAMAE', 'Sunday, February 14, 2016', '1:13 PM', 'LOGOUT'),
(6, 'AIRAMAE', 'Sunday, February 14, 2016', '1:21 PM', 'LOGIN'),
(7, 'AIRAMAE', 'Sunday, February 14, 2016', '1:21 PM', 'LOGOUT'),
(8, 'AIRAMAE', 'Sunday, February 14, 2016', '1:21 PM', 'LOGIN'),
(9, 'AIRAMAE', 'Sunday, February 14, 2016', '1:34 PM', 'LOGIN'),
(10, 'AIRAMAE', 'Sunday, February 14, 2016', '1:35 PM', 'LOGOUT'),
(11, 'AIRAMAE', 'Sunday, February 14, 2016', '1:41 PM', 'LOGIN'),
(12, 'AIRAMAE', 'Sunday, February 14, 2016', '1:49 PM', 'LOGIN'),
(13, 'AIRAMAE', 'Sunday, February 14, 2016', '1:51 PM', 'LOGIN'),
(14, 'AIRAMAE', 'Sunday, February 14, 2016', '1:53 PM', 'LOGIN'),
(15, 'AIRAMAE', 'Sunday, February 14, 2016', '1:54 PM', 'LOGIN'),
(16, 'AIRAMAE', 'Sunday, February 14, 2016', '1:55 PM', 'LOGIN'),
(17, 'AIRAMAE', 'Sunday, February 14, 2016', '1:55 PM', 'LOGIN'),
(18, 'AIRAMAE', 'Sunday, February 14, 2016', '1:59 PM', 'LOGIN'),
(19, 'AIRAMAE', 'Sunday, February 14, 2016', '1:59 PM', 'LOGOUT'),
(20, 'AIRAMAE', 'Sunday, February 14, 2016', '1:59 PM', 'LOGIN'),
(21, 'AIRAMAE', 'Sunday, February 14, 2016', '2:00 PM', 'LOGOUT'),
(22, 'AIRAMAE', 'Sunday, February 14, 2016', '2:04 PM', 'LOGIN'),
(23, 'AIRAMAE', 'Sunday, February 14, 2016', '2:04 PM', 'LOGOUT'),
(24, 'AIRAMAE', 'Sunday, February 14, 2016', '2:04 PM', 'LOGIN'),
(25, 'AIRAMAE', 'Sunday, February 14, 2016', '2:05 PM', 'LOGOUT'),
(26, 'AIRAMAE', 'Sunday, February 14, 2016', '2:08 PM', 'LOGIN'),
(27, 'AIRAMAE', 'Sunday, February 14, 2016', '2:09 PM', 'LOGOUT'),
(28, 'AIRAMAE', 'Sunday, February 14, 2016', '2:09 PM', 'LOGIN'),
(29, 'AIRAMAE', 'Sunday, February 14, 2016', '2:09 PM', 'LOGOUT'),
(30, 'AIRAMAE', 'Sunday, February 14, 2016', '2:12 PM', 'LOGIN'),
(31, 'AIRAMAE', 'Sunday, February 14, 2016', '2:13 PM', 'LOGIN'),
(32, 'AIRAMAE', 'Sunday, February 14, 2016', '2:13 PM', 'LOGOUT'),
(33, 'AIRAMAE', 'Sunday, February 14, 2016', '2:22 PM', 'LOGIN'),
(34, 'AIRAMAE', 'Sunday, February 14, 2016', '2:23 PM', 'LOGIN'),
(35, 'AIRAMAE', 'Sunday, February 14, 2016', '2:42 PM', 'LOGIN'),
(36, 'AIRAMAE', 'Sunday, February 14, 2016', '2:42 PM', 'LOGOUT'),
(37, 'AIRAMAE', 'Sunday, February 14, 2016', '2:45 PM', 'LOGIN'),
(38, 'AIRAMAE', 'Sunday, February 14, 2016', '2:47 PM', 'LOGIN'),
(39, 'AIRAMAE', 'Sunday, February 14, 2016', '2:47 PM', 'LOGOUT'),
(40, 'AIRAMAE', 'Sunday, February 14, 2016', '2:48 PM', 'LOGIN'),
(41, 'AIRAMAE', 'Sunday, February 14, 2016', '2:49 PM', 'LOGOUT'),
(42, 'AIRAMAE', 'Sunday, February 14, 2016', '8:54 PM', 'LOGIN'),
(43, 'AIRAMAE', 'Sunday, February 14, 2016', '8:55 PM', 'LOGOUT'),
(44, 'AIRAMAE', 'Sunday, February 14, 2016', '9:05 PM', 'LOGIN'),
(45, 'AIRAMAE', 'Sunday, February 14, 2016', '9:10 PM', 'LOGIN'),
(46, 'AIRAMAE', 'Sunday, February 14, 2016', '9:12 PM', 'LOGIN'),
(47, 'AIRAMAE', 'Sunday, February 14, 2016', '9:14 PM', 'LOGOUT'),
(48, 'AIRAMAE', 'Sunday, February 14, 2016', '9:17 PM', 'LOGIN'),
(49, 'AIRAMAE', 'Sunday, February 14, 2016', '9:19 PM', 'LOGOUT'),
(50, 'AIRAMAE', 'Sunday, February 14, 2016', '9:20 PM', 'LOGIN'),
(51, 'AIRAMAE', 'Sunday, February 14, 2016', '9:20 PM', 'LOGOUT'),
(52, 'AIRAMAE', 'Sunday, February 14, 2016', '9:32 PM', 'LOGIN'),
(53, 'AIRAMAE', 'Sunday, February 14, 2016', '9:37 PM', 'LOGOUT'),
(54, 'AIRAMAE', 'Monday, February 15, 2016', '5:31 PM', 'LOGIN'),
(55, 'AIRAMAE', 'Monday, February 15, 2016', '5:32 PM', 'LOGIN'),
(56, 'AIRAMAE', 'Monday, February 15, 2016', '5:38 PM', 'LOGOUT'),
(57, 'JEFF', 'Monday, February 15, 2016', '5:38 PM', 'LOGIN'),
(58, 'JEFF', 'Monday, February 15, 2016', '5:39 PM', 'LOGOUT'),
(59, 'AIRAMAE', 'Monday, February 15, 2016', '5:39 PM', 'LOGIN'),
(60, 'AIRAMAE', 'Monday, February 15, 2016', '6:02 PM', 'LOGOUT'),
(61, 'AIRAMAE', 'Monday, February 15, 2016', '10:07 PM', 'LOGIN'),
(62, 'AIRAMAE', 'Monday, February 15, 2016', '10:11 PM', 'LOGIN'),
(63, 'AIRAMAE', 'Monday, February 15, 2016', '10:14 PM', 'LOGIN'),
(64, 'AIRAMAE', 'Monday, February 15, 2016', '10:14 PM', 'LOGOUT'),
(65, 'AIRAMAE', 'Monday, February 15, 2016', '10:19 PM', 'LOGIN'),
(66, 'AIRAMAE', 'Monday, February 15, 2016', '10:19 PM', 'LOGOUT'),
(67, 'AIRAMAE', 'Monday, February 15, 2016', '10:21 PM', 'LOGIN'),
(68, 'AIRAMAE', 'Monday, February 15, 2016', '10:21 PM', 'LOGOUT'),
(69, 'AIRAMAE', 'Monday, February 15, 2016', '10:24 PM', 'LOGIN'),
(70, 'AIRAMAE', 'Monday, February 15, 2016', '10:25 PM', 'LOGIN'),
(71, 'AIRAMAE', 'Monday, February 15, 2016', '10:25 PM', 'LOGIN'),
(72, 'AIRAMAE', 'Monday, February 15, 2016', '10:25 PM', 'LOGOUT'),
(73, 'AIRAMAE', 'Monday, February 15, 2016', '10:26 PM', 'LOGIN'),
(74, 'AIRAMAE', 'Monday, February 15, 2016', '10:26 PM', 'LOGOUT'),
(75, 'AIRAMAE', 'Monday, February 15, 2016', '10:45 PM', 'LOGIN'),
(76, 'AIRAMAE', 'Monday, February 15, 2016', '10:45 PM', 'LOGOUT'),
(77, 'AIRAMAE', 'Monday, February 15, 2016', '10:46 PM', 'LOGIN'),
(78, 'AIRAMAE', 'Monday, February 15, 2016', '10:47 PM', 'LOGIN'),
(79, 'AIRAMAE', 'Monday, February 15, 2016', '10:47 PM', 'LOGOUT'),
(80, 'AIRAMAE', 'Monday, February 15, 2016', '10:48 PM', 'LOGIN'),
(81, 'AIRAMAE', 'Monday, February 15, 2016', '10:49 PM', 'LOGIN'),
(82, 'AIRAMAE', 'Monday, February 15, 2016', '10:50 PM', 'LOGIN'),
(83, 'AIRAMAE', 'Monday, February 15, 2016', '10:51 PM', 'LOGIN'),
(84, 'AIRAMAE', 'Monday, February 15, 2016', '10:51 PM', 'LOGOUT'),
(85, 'AIRAMAE', 'Wednesday, February 17, 2016', '8:26 AM', 'LOGIN'),
(86, 'AIRAMAE', 'Wednesday, February 17, 2016', '8:26 AM', 'LOGOUT'),
(87, 'AIRAMAE', 'Wednesday, February 17, 2016', '8:27 AM', 'LOGIN'),
(88, 'AIRAMAE', 'Wednesday, February 17, 2016', '8:27 AM', 'LOGOUT'),
(89, 'AIRAMAE', 'Wednesday, February 17, 2016', '8:28 AM', 'LOGIN'),
(90, 'AIRAMAE', 'Wednesday, February 17, 2016', '8:28 AM', 'LOGOUT'),
(91, 'AIRAMAE', 'Wednesday, February 17, 2016', '8:29 AM', 'LOGIN'),
(92, 'AIRAMAE', 'Wednesday, February 17, 2016', '8:29 AM', 'LOGOUT'),
(93, 'AIRAMAE', 'Wednesday, February 17, 2016', '8:32 AM', 'LOGIN'),
(94, 'AIRAMAE', 'Wednesday, February 17, 2016', '8:32 AM', 'LOGOUT'),
(95, 'AIRAMAE', 'Wednesday, February 17, 2016', '8:33 AM', 'LOGIN'),
(96, 'AIRAMAE', 'Wednesday, February 17, 2016', '8:34 AM', 'LOGOUT'),
(97, 'AIRAMAE', 'Wednesday, February 17, 2016', '8:35 AM', 'LOGIN'),
(98, 'AIRAMAE', 'Wednesday, February 17, 2016', '8:35 AM', 'LOGOUT'),
(99, 'AIRAMAE', 'Wednesday, February 17, 2016', '8:54 AM', 'LOGIN'),
(100, 'AIRAMAE', 'Wednesday, February 17, 2016', '8:55 AM', 'LOGOUT'),
(101, 'AIRAMAE', 'Wednesday, February 17, 2016', '8:55 AM', 'LOGIN'),
(102, 'AIRAMAE', 'Wednesday, February 17, 2016', '8:55 AM', 'LOGOUT'),
(103, 'AIRAMAE', 'Wednesday, February 17, 2016', '8:56 AM', 'LOGIN'),
(104, 'AIRAMAE', 'Wednesday, February 17, 2016', '8:57 AM', 'LOGOUT'),
(105, 'AIRAMAE', 'Wednesday, February 17, 2016', '8:58 AM', 'LOGIN'),
(106, 'AIRAMAE', 'Wednesday, February 17, 2016', '8:58 AM', 'LOGOUT'),
(107, 'AIRAMAE', 'Wednesday, February 17, 2016', '9:03 AM', 'LOGIN'),
(108, 'AIRAMAE', 'Wednesday, February 17, 2016', '9:03 AM', 'LOGOUT'),
(109, 'AIRAMAE', 'Wednesday, February 17, 2016', '9:04 AM', 'LOGIN'),
(110, 'AIRAMAE', 'Wednesday, February 17, 2016', '9:04 AM', 'LOGOUT'),
(111, 'AIRAMAE', 'Wednesday, February 17, 2016', '9:06 AM', 'LOGIN'),
(112, 'AIRAMAE', 'Wednesday, February 17, 2016', '9:06 AM', 'LOGOUT'),
(113, 'AIRAMAE', 'Wednesday, February 17, 2016', '9:07 AM', 'LOGIN'),
(114, 'AIRAMAE', 'Wednesday, February 17, 2016', '9:07 AM', 'LOGOUT'),
(115, 'AIRAMAE', 'Wednesday, February 17, 2016', '9:08 AM', 'LOGIN'),
(116, 'AIRAMAE', 'Wednesday, February 17, 2016', '9:08 AM', 'LOGOUT'),
(117, 'AIRAMAE', 'Wednesday, February 17, 2016', '9:09 AM', 'LOGIN'),
(118, 'AIRAMAE', 'Wednesday, February 17, 2016', '9:09 AM', 'LOGOUT'),
(119, 'AIRAMAE', 'Wednesday, February 17, 2016', '9:23 AM', 'LOGIN'),
(120, 'AIRAMAE', 'Wednesday, February 17, 2016', '9:24 AM', 'LOGOUT'),
(121, 'AIRAMAE', 'Wednesday, February 17, 2016', '9:26 AM', 'LOGIN'),
(122, 'AIRAMAE', 'Wednesday, February 17, 2016', '9:26 AM', 'LOGOUT'),
(123, 'AIRAMAE', 'Wednesday, February 17, 2016', '9:53 AM', 'LOGIN'),
(124, 'AIRAMAE', 'Wednesday, February 17, 2016', '9:55 AM', 'LOGIN'),
(125, 'AIRAMAE', 'Wednesday, February 17, 2016', '9:56 AM', 'LOGOUT'),
(126, 'AIRAMAE', 'Wednesday, February 17, 2016', '9:57 AM', 'LOGIN'),
(127, 'AIRAMAE', 'Wednesday, February 17, 2016', '9:59 AM', 'LOGIN'),
(128, 'AIRAMAE', 'Wednesday, February 17, 2016', '10:00 AM', 'LOGIN'),
(129, 'AIRAMAE', 'Wednesday, February 17, 2016', '10:01 AM', 'LOGIN'),
(130, 'AIRAMAE', 'Wednesday, February 17, 2016', '10:01 AM', 'LOGIN'),
(131, 'AIRAMAE', 'Wednesday, February 17, 2016', '10:03 AM', 'LOGIN'),
(132, 'AIRAMAE', 'Wednesday, February 17, 2016', '10:05 AM', 'LOGIN'),
(133, 'AIRAMAE', 'Wednesday, February 17, 2016', '10:05 AM', 'LOGIN'),
(134, 'AIRAMAE', 'Wednesday, February 17, 2016', '10:07 AM', 'LOGIN'),
(135, 'AIRAMAE', 'Wednesday, February 17, 2016', '10:08 AM', 'LOGIN'),
(136, 'AIRAMAE', 'Wednesday, February 17, 2016', '10:09 AM', 'LOGIN'),
(137, 'AIRAMAE', 'Wednesday, February 17, 2016', '10:11 AM', 'LOGIN'),
(138, 'AIRAMAE', 'Wednesday, February 17, 2016', '10:12 AM', 'LOGIN'),
(139, 'AIRAMAE', 'Wednesday, February 17, 2016', '10:13 AM', 'LOGIN'),
(140, 'AIRAMAE', 'Wednesday, February 17, 2016', '10:14 AM', 'LOGIN'),
(141, 'AIRAMAE', 'Wednesday, February 17, 2016', '10:17 AM', 'LOGIN'),
(142, 'AIRAMAE', 'Wednesday, February 17, 2016', '10:17 AM', 'LOGIN'),
(143, 'AIRAMAE', 'Wednesday, February 17, 2016', '10:21 AM', 'LOGIN'),
(144, 'AIRAMAE', 'Wednesday, February 17, 2016', '10:22 AM', 'LOGIN'),
(145, 'AIRAMAE', 'Wednesday, February 17, 2016', '10:23 AM', 'LOGIN'),
(146, 'AIRAMAE', 'Wednesday, February 17, 2016', '10:24 AM', 'LOGIN'),
(147, 'AIRAMAE', 'Wednesday, February 17, 2016', '10:27 AM', 'LOGIN'),
(148, 'AIRAMAE', 'Wednesday, February 17, 2016', '10:30 AM', 'LOGIN'),
(149, 'AIRAMAE', 'Wednesday, February 17, 2016', '10:33 AM', 'LOGIN'),
(150, 'AIRAMAE', 'Wednesday, February 17, 2016', '10:39 AM', 'LOGIN'),
(151, 'AIRAMAE', 'Wednesday, February 17, 2016', '10:39 AM', 'LOGIN'),
(152, 'AIRAMAE', 'Wednesday, February 17, 2016', '10:42 AM', 'LOGIN'),
(153, 'AIRAMAE', 'Wednesday, February 17, 2016', '10:42 AM', 'LOGIN'),
(154, 'AIRAMAE', 'Wednesday, February 17, 2016', '10:46 AM', 'LOGIN'),
(155, 'AIRAMAE', 'Wednesday, February 17, 2016', '10:47 AM', 'LOGIN'),
(156, 'AIRAMAE', 'Wednesday, February 17, 2016', '10:47 AM', 'LOGIN'),
(157, 'AIRAMAE', 'Wednesday, February 17, 2016', '10:48 AM', 'LOGIN'),
(158, 'AIRAMAE', 'Wednesday, February 17, 2016', '7:13 PM', 'LOGIN'),
(159, 'AIRAMAE', 'Wednesday, February 17, 2016', '7:13 PM', 'LOGOUT'),
(160, 'AIRAMAE', 'Wednesday, February 17, 2016', '7:26 PM', 'LOGIN'),
(161, 'AIRAMAE', 'Wednesday, February 17, 2016', '7:40 PM', 'LOGIN'),
(162, 'AIRAMAE', 'Wednesday, February 17, 2016', '7:41 PM', 'LOGOUT'),
(163, 'AIRAMAE', 'Wednesday, February 17, 2016', '7:44 PM', 'LOGIN'),
(164, 'AIRAMAE', 'Wednesday, February 17, 2016', '7:45 PM', 'LOGOUT'),
(165, 'AIRAMAE', 'Wednesday, February 17, 2016', '7:45 PM', 'LOGIN'),
(166, 'AIRAMAE', 'Wednesday, February 17, 2016', '7:45 PM', 'LOGOUT'),
(167, 'AIRAMAE', 'Wednesday, February 17, 2016', '7:46 PM', 'LOGIN'),
(168, 'AIRAMAE', 'Wednesday, February 17, 2016', '7:46 PM', 'LOGOUT'),
(169, 'AIRAMAE', 'Wednesday, February 17, 2016', '7:46 PM', 'LOGIN'),
(170, 'AIRAMAE', 'Wednesday, February 17, 2016', '7:46 PM', 'LOGOUT'),
(171, 'AIRAMAE', 'Wednesday, February 17, 2016', '7:47 PM', 'LOGIN'),
(172, 'AIRAMAE', 'Wednesday, February 17, 2016', '7:47 PM', 'LOGOUT'),
(173, 'AIRAMAE', 'Wednesday, February 17, 2016', '7:56 PM', 'LOGIN'),
(174, 'AIRAMAE', 'Wednesday, February 17, 2016', '7:56 PM', 'LOGOUT'),
(175, 'AIRAMAE', 'Wednesday, February 17, 2016', '7:57 PM', 'LOGIN'),
(176, 'AIRAMAE', 'Wednesday, February 17, 2016', '7:59 PM', 'LOGOUT'),
(177, 'AIRAMAE', 'Wednesday, February 17, 2016', '8:18 PM', 'LOGIN'),
(178, 'AIRAMAE', 'Wednesday, February 17, 2016', '8:20 PM', 'LOGIN'),
(179, 'AIRAMAE', 'Wednesday, February 17, 2016', '8:29 PM', 'LOGIN'),
(180, 'AIRAMAE', 'Wednesday, February 17, 2016', '8:30 PM', 'LOGIN'),
(181, 'AIRAMAE', 'Wednesday, February 17, 2016', '8:31 PM', 'LOGOUT'),
(182, 'AIRAMAE', 'Wednesday, February 17, 2016', '8:33 PM', 'LOGIN'),
(183, 'AIRAMAE', 'Wednesday, February 17, 2016', '8:33 PM', 'LOGOUT'),
(184, 'AIRAMAE', 'Wednesday, February 17, 2016', '8:34 PM', 'LOGIN'),
(185, 'AIRAMAE', 'Wednesday, February 17, 2016', '8:34 PM', 'LOGOUT'),
(186, 'AIRAMAE', 'Wednesday, February 17, 2016', '8:35 PM', 'LOGIN'),
(187, 'AIRAMAE', 'Wednesday, February 17, 2016', '8:35 PM', 'LOGOUT'),
(188, 'AIRAMAE', 'Wednesday, February 17, 2016', '8:40 PM', 'LOGIN'),
(189, 'AIRAMAE', 'Wednesday, February 17, 2016', '8:41 PM', 'LOGIN'),
(190, 'AIRAMAE', 'Wednesday, February 17, 2016', '8:42 PM', 'LOGIN'),
(191, 'AIRAMAE', 'Wednesday, February 17, 2016', '8:43 PM', 'LOGIN'),
(192, 'AIRAMAE', 'Wednesday, February 17, 2016', '8:45 PM', 'LOGOUT'),
(193, 'AIRAMAE', 'Wednesday, February 17, 2016', '8:45 PM', 'LOGIN'),
(194, 'AIRAMAE', 'Wednesday, February 17, 2016', '8:46 PM', 'LOGOUT'),
(195, 'AIRAMAE', 'Wednesday, February 17, 2016', '8:47 PM', 'LOGIN'),
(196, 'AIRAMAE', 'Wednesday, February 17, 2016', '8:52 PM', 'LOGIN'),
(197, 'AIRAMAE', 'Wednesday, February 17, 2016', '8:53 PM', 'LOGOUT'),
(198, 'AIRAMAE', 'Wednesday, February 17, 2016', '9:17 PM', 'LOGIN'),
(199, 'AIRAMAE', 'Wednesday, February 17, 2016', '9:18 PM', 'LOGIN'),
(200, 'AIRAMAE', 'Wednesday, February 17, 2016', '9:18 PM', 'LOGOUT'),
(201, 'AIRAMAE', 'Wednesday, February 17, 2016', '9:18 PM', 'LOGIN'),
(202, 'AIRAMAE', 'Wednesday, February 17, 2016', '9:19 PM', 'LOGOUT'),
(203, 'AIRAMAE', 'Wednesday, February 17, 2016', '9:19 PM', 'LOGIN'),
(204, 'AIRAMAE', 'Wednesday, February 17, 2016', '9:19 PM', 'LOGOUT'),
(205, 'AIRAMAE', 'Wednesday, February 17, 2016', '9:21 PM', 'LOGIN'),
(206, 'AIRAMAE', 'Wednesday, February 17, 2016', '9:25 PM', 'LOGIN'),
(207, 'AIRAMAE', 'Wednesday, February 17, 2016', '9:29 PM', 'LOGIN'),
(208, 'AIRAMAE', 'Wednesday, February 17, 2016', '9:31 PM', 'LOGIN'),
(209, 'AIRAMAE', 'Wednesday, February 17, 2016', '9:33 PM', 'LOGIN'),
(210, 'AIRAMAE', 'Wednesday, February 17, 2016', '9:35 PM', 'LOGOUT'),
(211, 'AIRAMAE', 'Wednesday, February 17, 2016', '9:36 PM', 'LOGIN'),
(212, 'AIRAMAE', 'Wednesday, February 17, 2016', '9:37 PM', 'LOGIN'),
(213, 'AIRAMAE', 'Wednesday, February 17, 2016', '9:40 PM', 'LOGOUT'),
(214, 'AIRAMAE', 'Wednesday, February 17, 2016', '9:43 PM', 'LOGIN'),
(215, 'AIRAMAE', 'Wednesday, February 17, 2016', '9:43 PM', 'LOGOUT'),
(216, 'AIRAMAE', 'Wednesday, February 17, 2016', '9:44 PM', 'LOGIN'),
(217, 'AIRAMAE', 'Wednesday, February 17, 2016', '9:45 PM', 'LOGOUT'),
(218, 'AIRAMAE', 'Wednesday, February 17, 2016', '9:47 PM', 'LOGIN'),
(219, 'AIRAMAE', 'Wednesday, February 17, 2016', '9:47 PM', 'LOGOUT'),
(220, 'AIRAMAE', 'Wednesday, February 17, 2016', '9:51 PM', 'LOGIN'),
(221, 'AIRAMAE', 'Wednesday, February 17, 2016', '10:01 PM', 'LOGIN'),
(222, 'AIRAMAE', 'Wednesday, February 17, 2016', '10:02 PM', 'LOGIN'),
(223, 'AIRAMAE', 'Wednesday, February 17, 2016', '10:02 PM', 'LOGOUT'),
(224, 'AIRAMAE', 'Wednesday, February 17, 2016', '10:03 PM', 'LOGIN'),
(225, 'AIRAMAE', 'Wednesday, February 17, 2016', '10:03 PM', 'LOGOUT'),
(226, 'AIRAMAE', 'Wednesday, February 17, 2016', '10:03 PM', 'LOGIN'),
(227, 'AIRAMAE', 'Wednesday, February 17, 2016', '10:06 PM', 'LOGIN'),
(228, 'AIRAMAE', 'Wednesday, February 17, 2016', '10:25 PM', 'LOGIN'),
(229, 'AIRAMAE', 'Wednesday, February 17, 2016', '10:27 PM', 'LOGOUT'),
(230, 'AIRAMAE', 'Wednesday, February 17, 2016', '10:29 PM', 'LOGIN'),
(231, 'AIRAMAE', 'Wednesday, February 17, 2016', '10:30 PM', 'LOGIN'),
(232, 'AIRAMAE', 'Wednesday, February 17, 2016', '10:32 PM', 'LOGOUT'),
(233, 'AIRAMAE', 'Wednesday, February 17, 2016', '10:32 PM', 'LOGIN'),
(234, 'AIRAMAE', 'Wednesday, February 17, 2016', '10:33 PM', 'LOGOUT'),
(235, 'AIRAMAE', 'Wednesday, February 17, 2016', '10:35 PM', 'LOGIN'),
(236, 'AIRAMAE', 'Wednesday, February 17, 2016', '10:35 PM', 'LOGIN'),
(237, 'AIRAMAE', 'Wednesday, February 17, 2016', '10:39 PM', 'LOGIN'),
(238, 'AIRAMAE', 'Wednesday, February 17, 2016', '10:40 PM', 'LOGIN'),
(239, 'AIRAMAE', 'Wednesday, February 17, 2016', '10:41 PM', 'LOGIN'),
(240, 'AIRAMAE', 'Wednesday, February 17, 2016', '10:41 PM', 'LOGIN'),
(241, 'AIRAMAE', 'Wednesday, February 17, 2016', '10:42 PM', 'LOGIN'),
(242, 'AIRAMAE', 'Wednesday, February 17, 2016', '10:42 PM', 'LOGOUT'),
(243, 'AIRAMAE', 'Wednesday, February 17, 2016', '10:42 PM', 'LOGIN'),
(244, 'AIRAMAE', 'Wednesday, February 17, 2016', '10:43 PM', 'LOGIN'),
(245, 'AIRAMAE', 'Wednesday, February 17, 2016', '10:44 PM', 'LOGIN'),
(246, 'AIRAMAE', 'Wednesday, February 17, 2016', '10:44 PM', 'LOGOUT'),
(247, 'AIRAMAE', 'Wednesday, February 17, 2016', '10:45 PM', 'LOGIN'),
(248, 'AIRAMAE', 'Wednesday, February 17, 2016', '10:46 PM', 'LOGOUT'),
(249, 'AIRAMAE', 'Wednesday, February 17, 2016', '10:48 PM', 'LOGIN'),
(250, 'AIRAMAE', 'Wednesday, February 17, 2016', '10:49 PM', 'LOGIN'),
(251, 'AIRAMAE', 'Wednesday, February 17, 2016', '10:50 PM', 'LOGOUT'),
(252, 'AIRAMAE', 'Wednesday, February 17, 2016', '10:50 PM', 'LOGIN'),
(253, 'AIRAMAE', 'Wednesday, February 17, 2016', '10:51 PM', 'LOGIN'),
(254, 'AIRAMAE', 'Wednesday, February 17, 2016', '10:52 PM', 'LOGOUT'),
(255, 'AIRAMAE', 'Wednesday, February 17, 2016', '10:52 PM', 'LOGIN'),
(256, 'AIRAMAE', 'Wednesday, February 17, 2016', '10:53 PM', 'LOGOUT'),
(257, 'AIRAMAE', 'Wednesday, February 17, 2016', '10:57 PM', 'LOGIN'),
(258, 'AIRAMAE', 'Wednesday, February 17, 2016', '10:58 PM', 'LOGIN'),
(259, 'AIRAMAE', 'Wednesday, February 17, 2016', '10:59 PM', 'LOGIN'),
(260, 'AIRAMAE', 'Wednesday, February 17, 2016', '11:00 PM', 'LOGOUT'),
(261, 'AIRAMAE', 'Wednesday, February 17, 2016', '11:03 PM', 'LOGIN'),
(262, 'AIRAMAE', 'Wednesday, February 17, 2016', '11:08 PM', 'LOGIN'),
(263, 'AIRAMAE', 'Wednesday, February 17, 2016', '11:08 PM', 'LOGOUT'),
(264, 'AIRAMAE', 'Wednesday, February 17, 2016', '11:29 PM', 'LOGIN'),
(265, 'AIRAMAE', 'Thursday, February 18, 2016', '12:35 AM', 'LOGIN'),
(266, 'AIRAMAE', 'Thursday, February 18, 2016', '12:36 AM', 'LOGIN'),
(267, 'AIRAMAE', 'Thursday, February 18, 2016', '12:50 AM', 'LOGIN'),
(268, 'AIRAMAE', 'Thursday, February 18, 2016', '12:50 AM', 'LOGOUT'),
(269, 'AIRAMAE', 'Thursday, February 18, 2016', '12:54 AM', 'LOGIN'),
(270, 'AIRAMAE', 'Thursday, February 18, 2016', '12:54 AM', 'LOGOUT'),
(271, 'AIRAMAE', 'Thursday, February 18, 2016', '12:55 AM', 'LOGIN'),
(272, 'AIRAMAE', 'Thursday, February 18, 2016', '12:55 AM', 'LOGOUT'),
(273, 'AIRAMAE', 'Thursday, February 18, 2016', '12:56 AM', 'LOGIN'),
(274, 'AIRAMAE', 'Thursday, February 18, 2016', '12:56 AM', 'LOGOUT'),
(275, 'AIRAMAE', 'Thursday, February 18, 2016', '12:56 AM', 'LOGIN'),
(276, 'AIRAMAE', 'Thursday, February 18, 2016', '12:57 AM', 'LOGOUT'),
(277, 'AIRAMAE', 'Thursday, February 18, 2016', '6:42 AM', 'LOGIN'),
(278, 'AIRAMAE', 'Thursday, February 18, 2016', '6:43 AM', 'LOGOUT'),
(279, 'AIRAMAE', 'Thursday, February 18, 2016', '6:45 AM', 'LOGIN'),
(280, 'AIRAMAE', 'Thursday, February 18, 2016', '6:46 AM', 'LOGOUT'),
(281, 'AIRAMAE', 'Thursday, February 18, 2016', '6:46 AM', 'LOGIN'),
(282, 'AIRAMAE', 'Thursday, February 18, 2016', '6:46 AM', 'LOGOUT'),
(283, 'AIRAMAE', 'Thursday, February 18, 2016', '6:47 AM', 'LOGIN'),
(284, 'AIRAMAE', 'Thursday, February 18, 2016', '6:47 AM', 'LOGOUT'),
(285, 'AIRAMAE', 'Thursday, February 18, 2016', '6:51 AM', 'LOGIN'),
(286, 'AIRAMAE', 'Thursday, February 18, 2016', '6:51 AM', 'LOGOUT'),
(287, 'AIRAMAE', 'Thursday, February 18, 2016', '6:51 AM', 'LOGIN'),
(288, 'AIRAMAE', 'Thursday, February 18, 2016', '6:52 AM', 'LOGOUT'),
(289, 'AIRAMAE', 'Thursday, February 18, 2016', '7:03 AM', 'LOGIN'),
(290, 'AIRAMAE', 'Thursday, February 18, 2016', '7:04 AM', 'LOGIN'),
(291, 'AIRAMAE', 'Thursday, February 18, 2016', '7:05 AM', 'LOGOUT'),
(292, 'AIRAMAE', 'Thursday, February 18, 2016', '7:15 AM', 'LOGIN'),
(293, 'AIRAMAE', 'Thursday, February 18, 2016', '7:19 AM', 'LOGIN'),
(294, 'AIRAMAE', 'Thursday, February 18, 2016', '7:19 AM', 'LOGOUT'),
(295, 'AIRAMAE', 'Thursday, February 18, 2016', '7:20 AM', 'LOGIN'),
(296, 'AIRAMAE', 'Thursday, February 18, 2016', '7:25 AM', 'LOGIN'),
(297, 'AIRAMAE', 'Thursday, February 18, 2016', '7:27 AM', 'LOGIN'),
(298, 'AIRAMAE', 'Thursday, February 18, 2016', '7:29 AM', 'LOGIN'),
(299, 'AIRAMAE', 'Thursday, February 18, 2016', '7:29 AM', 'LOGOUT'),
(300, 'AIRAMAE', 'Thursday, February 18, 2016', '7:30 AM', 'LOGIN'),
(301, 'AIRAMAE', 'Thursday, February 18, 2016', '7:30 AM', 'LOGIN'),
(302, 'AIRAMAE', 'Thursday, February 18, 2016', '7:31 AM', 'LOGOUT'),
(303, 'AIRAMAE', 'Thursday, February 18, 2016', '7:35 AM', 'LOGIN'),
(304, 'AIRAMAE', 'Thursday, February 18, 2016', '7:35 AM', 'LOGOUT'),
(305, 'AIRAMAE', 'Thursday, February 18, 2016', '8:09 AM', 'LOGIN'),
(306, 'AIRAMAE', 'Thursday, February 18, 2016', '8:10 AM', 'LOGIN'),
(307, 'AIRAMAE', 'Thursday, February 18, 2016', '8:11 AM', 'LOGOUT'),
(308, 'AIRAMAE', 'Thursday, February 18, 2016', '8:11 AM', 'LOGIN'),
(309, 'AIRAMAE', 'Thursday, February 18, 2016', '8:11 AM', 'LOGOUT'),
(310, 'AIRAMAE', 'Thursday, February 18, 2016', '8:12 AM', 'LOGIN'),
(311, 'AIRAMAE', 'Thursday, February 18, 2016', '8:13 AM', 'LOGOUT'),
(312, 'AIRAMAE', 'Thursday, February 18, 2016', '8:18 AM', 'LOGIN'),
(313, 'AIRAMAE', 'Thursday, February 18, 2016', '9:10 AM', 'LOGIN'),
(314, 'AIRAMAE', 'Thursday, February 18, 2016', '9:20 AM', 'LOGIN'),
(315, 'AIRAMAE', 'Thursday, February 18, 2016', '9:21 AM', 'LOGIN'),
(316, 'AIRAMAE', 'Thursday, February 18, 2016', '9:22 AM', 'LOGOUT'),
(317, 'AIRAMAE', 'Thursday, February 18, 2016', '9:23 AM', 'LOGIN'),
(318, 'AIRAMAE', 'Thursday, February 18, 2016', '9:25 AM', 'LOGIN'),
(319, 'AIRAMAE', 'Thursday, February 18, 2016', '9:25 AM', 'LOGOUT'),
(320, 'AIRAMAE', 'Thursday, February 18, 2016', '9:25 AM', 'LOGIN'),
(321, 'AIRAMAE', 'Thursday, February 18, 2016', '9:26 AM', 'LOGOUT'),
(322, 'AIRAMAE', 'Thursday, February 18, 2016', '9:26 AM', 'LOGIN'),
(323, 'AIRAMAE', 'Thursday, February 18, 2016', '9:27 AM', 'LOGOUT'),
(324, 'AIRAMAE', 'Thursday, February 18, 2016', '9:28 AM', 'LOGIN'),
(325, 'AIRAMAE', 'Thursday, February 18, 2016', '9:28 AM', 'LOGOUT'),
(326, 'ADMIN', 'Thursday, February 18, 2016', '9:28 AM', 'LOGIN'),
(327, 'ADMIN', 'Thursday, February 18, 2016', '9:29 AM', 'LOGIN'),
(328, 'ADMIN', 'Thursday, February 18, 2016', '9:32 AM', 'LOGIN'),
(329, 'ADMIN', 'Thursday, February 18, 2016', '9:33 AM', 'LOGIN'),
(330, 'ADMIN', 'Thursday, February 18, 2016', '9:34 AM', 'LOGIN'),
(331, 'ADMIN', 'Thursday, February 18, 2016', '9:35 AM', 'LOGIN'),
(332, 'AIRAMAE', 'Thursday, February 18, 2016', '9:36 AM', 'LOGIN'),
(333, 'AIRAMAE', 'Thursday, February 18, 2016', '9:36 AM', 'LOGOUT'),
(334, 'AIRAMAE', 'Thursday, February 18, 2016', '9:37 AM', 'LOGIN'),
(335, 'AIRAMAE', 'Thursday, February 18, 2016', '9:38 AM', 'LOGIN'),
(336, 'AIRAMAE', 'Thursday, February 18, 2016', '9:39 AM', 'LOGOUT'),
(337, 'AIRAMAE', 'Thursday, February 18, 2016', '9:39 AM', 'LOGIN'),
(338, 'AIRAMAE', 'Thursday, February 18, 2016', '9:39 AM', 'LOGOUT'),
(339, 'AIRAMAE', 'Thursday, February 18, 2016', '9:39 AM', 'LOGIN'),
(340, 'AIRAMAE', 'Thursday, February 18, 2016', '9:40 AM', 'LOGOUT'),
(341, 'AIRAMAE', 'Thursday, February 18, 2016', '9:50 AM', 'LOGIN'),
(342, 'AIRAMAE', 'Thursday, February 18, 2016', '9:50 AM', 'LOGOUT'),
(343, 'AIRAMAE', 'Thursday, February 18, 2016', '9:50 AM', 'LOGIN'),
(344, 'AIRAMAE', 'Thursday, February 18, 2016', '9:52 AM', 'LOGIN'),
(345, 'AIRAMAE', 'Thursday, February 18, 2016', '9:52 AM', 'LOGOUT'),
(346, 'AIRAMAE', 'Thursday, February 18, 2016', '10:22 AM', 'LOGIN'),
(347, 'AIRAMAE', 'Thursday, February 18, 2016', '10:25 AM', 'LOGIN'),
(348, 'AIRAMAE', 'Thursday, February 18, 2016', '10:27 AM', 'LOGIN'),
(349, 'AIRAMAE', 'Thursday, February 18, 2016', '10:27 AM', 'LOGIN'),
(350, 'AIRAMAE', 'Thursday, February 18, 2016', '10:28 AM', 'LOGIN'),
(351, 'AIRAMAE', 'Thursday, February 18, 2016', '10:29 AM', 'LOGIN'),
(352, 'AIRAMAE', 'Thursday, February 18, 2016', '10:30 AM', 'LOGIN'),
(353, 'AIRAMAE', 'Thursday, February 18, 2016', '10:31 AM', 'LOGIN'),
(354, 'ADMIN', 'Thursday, February 18, 2016', '10:48 AM', 'LOGIN'),
(355, 'ADMIN', 'Thursday, February 18, 2016', '10:52 AM', 'LOGIN'),
(356, 'ADMIN', 'Thursday, February 18, 2016', '10:55 AM', 'LOGIN'),
(357, 'AIRAMAE', 'Thursday, February 18, 2016', '10:59 AM', 'LOGIN'),
(358, 'AIRAMAE', 'Thursday, February 18, 2016', '10:59 AM', 'LOGOUT'),
(359, 'ADMIN', 'Thursday, February 18, 2016', '10:59 AM', 'LOGIN'),
(360, 'ADMIN', 'Thursday, February 18, 2016', '11:08 AM', 'LOGIN'),
(361, 'ADMIN', 'Thursday, February 18, 2016', '11:16 AM', 'LOGIN'),
(362, 'ADMIN', 'Thursday, February 18, 2016', '11:17 AM', 'LOGIN'),
(363, 'ADMIN', 'Thursday, February 18, 2016', '11:19 AM', 'LOGIN'),
(364, 'ADMIN', 'Thursday, February 18, 2016', '11:22 AM', 'LOGIN'),
(365, 'ADMIN', 'Thursday, February 18, 2016', '11:22 AM', 'LOGIN'),
(366, 'ADMIN', 'Thursday, February 18, 2016', '11:23 AM', 'LOGIN'),
(367, 'ADMIN', 'Thursday, February 18, 2016', '11:25 AM', 'LOGIN'),
(368, 'ADMIN', 'Thursday, February 18, 2016', '11:27 AM', 'LOGIN'),
(369, 'ADMIN', 'Thursday, February 18, 2016', '11:29 AM', 'LOGIN'),
(370, 'ADMIN', 'Thursday, February 18, 2016', '11:29 AM', 'LOGOUT'),
(371, 'ADMIN', 'Thursday, February 18, 2016', '11:30 AM', 'LOGIN'),
(372, 'ADMIN', 'Thursday, February 18, 2016', '11:32 AM', 'LOGIN'),
(373, 'ADMIN', 'Thursday, February 18, 2016', '11:33 AM', 'LOGIN'),
(374, 'ADMIN', 'Thursday, February 18, 2016', '11:35 AM', 'LOGIN'),
(375, 'ADMIN', 'Thursday, February 18, 2016', '11:37 AM', 'LOGIN'),
(376, 'ADMIN', 'Thursday, February 18, 2016', '11:38 AM', 'LOGOUT'),
(377, 'ADMIN', 'Thursday, February 18, 2016', '11:42 AM', 'LOGIN'),
(378, 'ADMIN', 'Thursday, February 18, 2016', '11:43 AM', 'LOGIN'),
(379, 'ADMIN', 'Thursday, February 18, 2016', '11:43 AM', 'LOGIN'),
(380, 'ADMIN', 'Thursday, February 18, 2016', '11:45 AM', 'LOGIN'),
(381, 'ADMIN', 'Thursday, February 18, 2016', '11:46 AM', 'LOGIN'),
(382, 'ADMIN', 'Thursday, February 18, 2016', '11:46 AM', 'LOGIN'),
(383, 'ADMIN', 'Thursday, February 18, 2016', '11:47 AM', 'LOGOUT'),
(384, 'ADMIN', 'Thursday, February 18, 2016', '11:48 AM', 'LOGIN'),
(385, 'ADMIN', 'Thursday, February 18, 2016', '11:50 AM', 'LOGIN'),
(386, 'ADMIN', 'Thursday, February 18, 2016', '11:51 AM', 'LOGOUT'),
(387, 'ADMIN', 'Thursday, February 18, 2016', '11:52 AM', 'LOGIN'),
(388, 'ADMIN', 'Thursday, February 18, 2016', '11:52 AM', 'LOGOUT'),
(389, 'ADMIN', 'Thursday, February 18, 2016', '11:54 AM', 'LOGIN'),
(390, 'ADMIN', 'Thursday, February 18, 2016', '11:58 AM', 'LOGIN'),
(391, 'ADMIN', 'Thursday, February 18, 2016', '12:01 PM', 'LOGIN'),
(392, 'ADMIN', 'Thursday, February 18, 2016', '12:03 PM', 'LOGIN'),
(393, 'ADMIN', 'Thursday, February 18, 2016', '12:05 PM', 'LOGIN'),
(394, 'ADMIN', 'Thursday, February 18, 2016', '12:06 PM', 'LOGIN'),
(395, 'AIRAMAE', 'Thursday, February 18, 2016', '1:32 PM', 'LOGIN'),
(396, 'AIRAMAE', 'Thursday, February 18, 2016', '1:32 PM', 'LOGOUT'),
(397, 'AIRAMAE', 'Thursday, February 18, 2016', '1:34 PM', 'LOGIN'),
(398, 'ADMIN', 'Thursday, February 18, 2016', '1:37 PM', 'LOGIN'),
(399, 'ADMIN', 'Thursday, February 18, 2016', '1:37 PM', 'LOGOUT'),
(400, 'ADMIN', 'Thursday, February 18, 2016', '1:38 PM', 'LOGIN'),
(401, 'ADMIN', 'Thursday, February 18, 2016', '1:38 PM', 'LOGOUT'),
(402, 'ADMIN', 'Thursday, February 18, 2016', '1:39 PM', 'LOGIN'),
(403, 'ADMIN', 'Thursday, February 18, 2016', '1:40 PM', 'LOGOUT'),
(404, 'ADMIN', 'Thursday, February 18, 2016', '1:42 PM', 'LOGIN'),
(405, 'ADMIN', 'Thursday, February 18, 2016', '1:42 PM', 'LOGOUT'),
(406, 'ADMIN', 'Thursday, February 18, 2016', '1:43 PM', 'LOGIN'),
(407, 'ADMIN', 'Thursday, February 18, 2016', '1:43 PM', 'LOGOUT'),
(408, 'AIRAMAE', 'Thursday, February 18, 2016', '1:43 PM', 'LOGIN'),
(409, 'AIRAMAE', 'Thursday, February 18, 2016', '1:45 PM', 'LOGIN'),
(410, 'AIRAMAE', 'Thursday, February 18, 2016', '1:46 PM', 'LOGIN'),
(411, 'ADMIN', 'Thursday, February 18, 2016', '2:01 PM', 'LOGIN'),
(412, 'ADMIN', 'Thursday, February 18, 2016', '2:02 PM', 'LOGIN'),
(413, 'ADMIN', 'Thursday, February 18, 2016', '2:03 PM', 'LOGIN'),
(414, 'ADMIN', 'Thursday, February 18, 2016', '2:04 PM', 'LOGOUT'),
(415, 'ADMIN', 'Thursday, February 18, 2016', '2:11 PM', 'LOGIN'),
(416, 'ADMIN', 'Thursday, February 18, 2016', '2:11 PM', 'LOGOUT'),
(417, 'AIRAMAE', 'Thursday, February 18, 2016', '2:11 PM', 'LOGIN'),
(418, 'AIRAMAE', 'Thursday, February 18, 2016', '2:12 PM', 'LOGIN'),
(419, 'AIRAMAE', 'Thursday, February 18, 2016', '2:13 PM', 'LOGOUT'),
(420, 'AIRAMAE', 'Thursday, February 18, 2016', '2:14 PM', 'LOGIN'),
(421, 'AIRAMAE', 'Thursday, February 18, 2016', '2:16 PM', 'LOGIN'),
(422, 'AIRAMAE', 'Thursday, February 18, 2016', '2:17 PM', 'LOGIN'),
(423, 'AIRAMAE', 'Thursday, February 18, 2016', '2:18 PM', 'LOGIN'),
(424, 'AIRAMAE', 'Thursday, February 18, 2016', '2:22 PM', 'LOGIN'),
(425, 'AIRAMAE', 'Thursday, February 18, 2016', '2:24 PM', 'LOGIN'),
(426, 'AIRAMAE', 'Thursday, February 18, 2016', '2:25 PM', 'LOGIN'),
(427, 'AIRAMAE', 'Thursday, February 18, 2016', '2:34 PM', 'LOGIN'),
(428, 'AIRAMAE', 'Thursday, February 18, 2016', '7:34 PM', 'LOGIN'),
(429, 'AIRAMAE', 'Thursday, February 18, 2016', '8:16 PM', 'LOGIN'),
(430, 'AIRAMAE', 'Thursday, February 18, 2016', '8:18 PM', 'LOGIN'),
(431, 'AIRAMAE', 'Thursday, February 18, 2016', '8:19 PM', 'LOGIN'),
(432, 'AIRAMAE', 'Thursday, February 18, 2016', '8:21 PM', 'LOGIN'),
(433, 'AIRAMAE', 'Thursday, February 18, 2016', '8:25 PM', 'LOGIN'),
(434, 'AIRAMAE', 'Thursday, February 18, 2016', '8:26 PM', 'LOGOUT'),
(435, 'AIRAMAE', 'Thursday, February 18, 2016', '9:48 PM', 'LOGIN'),
(436, 'AIRAMAE', 'Thursday, February 18, 2016', '9:51 PM', 'LOGIN'),
(437, 'AIRAMAE', 'Thursday, February 18, 2016', '9:52 PM', 'LOGIN'),
(438, 'AIRAMAE', 'Thursday, February 18, 2016', '9:53 PM', 'LOGIN'),
(439, 'AIRAMAE', 'Thursday, February 18, 2016', '10:03 PM', 'LOGIN'),
(440, 'AIRAMAE', 'Thursday, February 18, 2016', '10:04 PM', 'LOGIN'),
(441, 'AIRAMAE', 'Thursday, February 18, 2016', '10:09 PM', 'LOGIN'),
(442, 'AIRAMAE', 'Thursday, February 18, 2016', '10:09 PM', 'LOGOUT'),
(443, 'AIRAMAE', 'Thursday, February 18, 2016', '10:15 PM', 'LOGIN'),
(444, 'AIRAMAE', 'Thursday, February 18, 2016', '10:16 PM', 'LOGIN'),
(445, 'AIRAMAE', 'Thursday, February 18, 2016', '10:17 PM', 'LOGIN'),
(446, 'AIRAMAE', 'Thursday, February 18, 2016', '10:17 PM', 'LOGIN'),
(447, 'AIRAMAE', 'Thursday, February 18, 2016', '10:18 PM', 'LOGIN'),
(448, 'AIRAMAE', 'Thursday, February 18, 2016', '10:19 PM', 'LOGIN'),
(449, 'AIRAMAE', 'Thursday, February 18, 2016', '10:20 PM', 'LOGIN'),
(450, 'AIRAMAE', 'Thursday, February 18, 2016', '10:20 PM', 'LOGIN'),
(451, 'AIRAMAE', 'Thursday, February 18, 2016', '10:27 PM', 'LOGIN'),
(452, 'AIRAMAE', 'Thursday, February 18, 2016', '10:28 PM', 'LOGIN'),
(453, 'AIRAMAE', 'Thursday, February 18, 2016', '10:29 PM', 'LOGIN'),
(454, 'AIRAMAE', 'Thursday, February 18, 2016', '10:30 PM', 'LOGIN'),
(455, 'AIRAMAE', 'Thursday, February 18, 2016', '10:31 PM', 'LOGIN'),
(456, 'AIRAMAE', 'Thursday, February 18, 2016', '10:33 PM', 'LOGIN'),
(457, 'AIRAMAE', 'Thursday, February 18, 2016', '10:38 PM', 'LOGIN'),
(458, 'AIRAMAE', 'Thursday, February 18, 2016', '10:40 PM', 'LOGIN'),
(459, 'AIRAMAE', 'Thursday, February 18, 2016', '10:40 PM', 'LOGIN'),
(460, 'AIRAMAE', 'Thursday, February 18, 2016', '10:43 PM', 'LOGIN'),
(461, 'AIRAMAE', 'Thursday, February 18, 2016', '10:45 PM', 'LOGIN'),
(462, 'AIRAMAE', 'Thursday, February 18, 2016', '10:46 PM', 'LOGIN'),
(463, 'AIRAMAE', 'Thursday, February 18, 2016', '10:47 PM', 'LOGIN'),
(464, 'AIRAMAE', 'Thursday, February 18, 2016', '10:49 PM', 'LOGIN'),
(465, 'AIRAMAE', 'Thursday, February 18, 2016', '10:50 PM', 'LOGIN'),
(466, 'AIRAMAE', 'Thursday, February 18, 2016', '10:51 PM', 'LOGIN'),
(467, 'AIRAMAE', 'Thursday, February 18, 2016', '11:05 PM', 'LOGIN'),
(468, 'AIRAMAE', 'Thursday, February 18, 2016', '11:08 PM', 'LOGIN'),
(469, 'AIRAMAE', 'Thursday, February 18, 2016', '11:16 PM', 'LOGIN'),
(470, 'AIRAMAE', 'Thursday, February 18, 2016', '11:16 PM', 'LOGOUT'),
(471, 'AIRAMAE', 'Thursday, February 18, 2016', '11:18 PM', 'LOGIN'),
(472, 'AIRAMAE', 'Thursday, February 18, 2016', '11:20 PM', 'LOGIN'),
(473, 'AIRAMAE', 'Thursday, February 18, 2016', '11:22 PM', 'LOGIN'),
(474, 'AIRAMAE', 'Friday, February 19, 2016', '12:28 AM', 'LOGIN'),
(475, 'ADMIN', 'Friday, February 19, 2016', '12:30 AM', 'LOGIN'),
(476, 'AIRAMAE', 'Friday, February 19, 2016', '12:35 AM', 'LOGIN'),
(477, 'AIRAMAE', 'Friday, February 19, 2016', '12:36 AM', 'LOGIN'),
(478, 'AIRAMAE', 'Friday, February 19, 2016', '12:37 AM', 'LOGOUT'),
(479, 'AIRAMAE', 'Friday, February 19, 2016', '12:39 AM', 'LOGIN'),
(480, 'AIRAMAE', 'Friday, February 19, 2016', '12:40 AM', 'LOGOUT'),
(481, 'AIRAMAE', 'Friday, February 19, 2016', '12:41 AM', 'LOGIN'),
(482, 'AIRAMAE', 'Friday, February 19, 2016', '12:44 AM', 'LOGIN'),
(483, 'AIRAMAE', 'Friday, February 19, 2016', '12:46 AM', 'LOGOUT'),
(484, 'ADMIN', 'Friday, February 19, 2016', '12:46 AM', 'LOGIN'),
(485, 'AIRAMAE', 'Friday, February 19, 2016', '12:47 AM', 'LOGIN'),
(486, 'AIRAMAE', 'Friday, February 19, 2016', '12:47 AM', 'LOGIN'),
(487, 'AIRAMAE', 'Friday, February 19, 2016', '12:48 AM', 'LOGOUT'),
(488, 'AIRAMAE', 'Friday, February 19, 2016', '12:49 AM', 'LOGIN'),
(489, 'AIRAMAE', 'Friday, February 19, 2016', '12:49 AM', 'LOGOUT'),
(490, 'AIRAMAE', 'Friday, February 19, 2016', '12:52 AM', 'LOGIN'),
(491, 'ADMIN', 'Friday, February 19, 2016', '12:53 AM', 'LOGIN'),
(492, 'ADMIN', 'Friday, February 19, 2016', '12:53 AM', 'LOGOUT'),
(493, 'AIRAMAE', 'Friday, February 19, 2016', '12:53 AM', 'LOGIN'),
(494, 'AIRAMAE', 'Friday, February 19, 2016', '12:56 AM', 'LOGIN'),
(495, 'AIRAMAE', 'Friday, February 19, 2016', '12:57 AM', 'LOGIN'),
(496, 'AIRAMAE', 'Friday, February 19, 2016', '12:59 AM', 'LOGIN'),
(497, 'AIRAMAE', 'Friday, February 19, 2016', '1:01 AM', 'LOGIN'),
(498, 'AIRAMAE', 'Friday, February 19, 2016', '1:02 AM', 'LOGIN'),
(499, 'AIRAMAE', 'Friday, February 19, 2016', '1:04 AM', 'LOGIN'),
(500, 'AIRAMAE', 'Friday, February 19, 2016', '1:16 AM', 'LOGIN'),
(501, 'AIRAMAE', 'Friday, February 19, 2016', '1:18 AM', 'LOGOUT'),
(502, 'AIRAMAE', 'Friday, February 19, 2016', '1:19 AM', 'LOGIN'),
(503, 'AIRAMAE', 'Friday, February 19, 2016', '1:19 AM', 'LOGOUT'),
(504, 'AIRAMAE', 'Friday, February 19, 2016', '1:20 AM', 'LOGIN'),
(505, 'AIRAMAE', 'Friday, February 19, 2016', '1:20 AM', 'LOGOUT'),
(506, 'AIRAMAE', 'Friday, February 19, 2016', '6:07 AM', 'LOGIN'),
(507, 'AIRAMAE', 'Friday, February 19, 2016', '6:12 AM', 'LOGIN'),
(508, 'AIRAMAE', 'Friday, February 19, 2016', '6:13 AM', 'LOGOUT'),
(509, 'AIRAMAE', 'Friday, February 19, 2016', '6:13 AM', 'LOGIN'),
(510, 'AIRAMAE', 'Friday, February 19, 2016', '6:14 AM', 'LOGOUT'),
(511, 'AIRAMAE', 'Friday, February 19, 2016', '6:15 AM', 'LOGIN'),
(512, 'AIRAMAE', 'Friday, February 19, 2016', '6:16 AM', 'LOGIN'),
(513, 'AIRAMAE', 'Friday, February 19, 2016', '6:17 AM', 'LOGIN'),
(514, 'AIRAMAE', 'Friday, February 19, 2016', '6:18 AM', 'LOGOUT'),
(515, 'AIRAMAE', 'Friday, February 19, 2016', '6:18 AM', 'LOGIN'),
(516, 'AIRAMAE', 'Friday, February 19, 2016', '6:18 AM', 'LOGOUT'),
(517, 'AIRAMAE', 'Friday, February 19, 2016', '6:19 AM', 'LOGIN'),
(518, 'AIRAMAE', 'Friday, February 19, 2016', '6:19 AM', 'LOGOUT'),
(519, 'AIRAMAE', 'Friday, February 19, 2016', '6:20 AM', 'LOGIN'),
(520, 'AIRAMAE', 'Friday, February 19, 2016', '6:20 AM', 'LOGOUT'),
(521, 'AIRAMAE', 'Friday, February 19, 2016', '6:21 AM', 'LOGIN'),
(522, 'AIRAMAE', 'Friday, February 19, 2016', '6:21 AM', 'LOGOUT'),
(523, 'AIRAMAE', 'Friday, February 19, 2016', '6:21 AM', 'LOGIN'),
(524, 'AIRAMAE', 'Friday, February 19, 2016', '6:22 AM', 'LOGOUT'),
(525, 'AIRAMAE', 'Friday, February 19, 2016', '6:22 AM', 'LOGIN'),
(526, 'AIRAMAE', 'Friday, February 19, 2016', '6:22 AM', 'LOGOUT'),
(527, 'AIRAMAE', 'Friday, February 19, 2016', '6:23 AM', 'LOGIN'),
(528, 'AIRAMAE', 'Friday, February 19, 2016', '6:23 AM', 'LOGOUT'),
(529, 'AIRAMAE', 'Friday, February 19, 2016', '6:24 AM', 'LOGIN'),
(530, 'AIRAMAE', 'Friday, February 19, 2016', '6:24 AM', 'LOGOUT'),
(531, 'AIRAMAE', 'Friday, February 19, 2016', '3:45 PM', 'LOGIN'),
(532, 'AIRAMAE', 'Friday, February 19, 2016', '3:46 PM', 'LOGOUT'),
(533, 'AIRAMAE', 'Friday, February 19, 2016', '4:03 PM', 'LOGIN'),
(534, 'AIRAMAE', 'Friday, February 19, 2016', '4:15 PM', 'LOGIN'),
(535, 'AIRAMAE', 'Friday, February 19, 2016', '4:16 PM', 'LOGOUT'),
(536, 'AIRAMAE', 'Friday, February 19, 2016', '4:17 PM', 'LOGIN'),
(537, 'AIRAMAE', 'Friday, February 19, 2016', '4:17 PM', 'LOGOUT'),
(538, 'AIRAMAE', 'Friday, February 19, 2016', '4:17 PM', 'LOGIN'),
(539, 'AIRAMAE', 'Friday, February 19, 2016', '4:17 PM', 'LOGOUT'),
(540, 'AIRAMAE', 'Friday, February 19, 2016', '4:18 PM', 'LOGIN'),
(541, 'AIRAMAE', 'Friday, February 19, 2016', '4:18 PM', 'LOGOUT'),
(542, 'AIRAMAE', 'Friday, February 19, 2016', '4:19 PM', 'LOGIN'),
(543, 'AIRAMAE', 'Friday, February 19, 2016', '4:20 PM', 'LOGOUT'),
(544, 'AIRAMAE', 'Friday, February 19, 2016', '4:29 PM', 'LOGIN'),
(545, 'AIRAMAE', 'Friday, February 19, 2016', '4:30 PM', 'LOGIN'),
(546, 'AIRAMAE', 'Friday, February 19, 2016', '4:36 PM', 'LOGIN'),
(547, 'AIRAMAE', 'Friday, February 19, 2016', '4:38 PM', 'LOGIN'),
(548, 'AIRAMAE', 'Friday, February 19, 2016', '4:39 PM', 'LOGIN'),
(549, 'AIRAMAE', 'Friday, February 19, 2016', '4:40 PM', 'LOGIN'),
(550, 'AIRAMAE', 'Friday, February 19, 2016', '4:41 PM', 'LOGIN'),
(551, 'AIRAMAE', 'Friday, February 19, 2016', '4:42 PM', 'LOGIN'),
(552, 'AIRAMAE', 'Friday, February 19, 2016', '4:46 PM', 'LOGIN'),
(553, 'AIRAMAE', 'Friday, February 19, 2016', '4:46 PM', 'LOGOUT'),
(554, 'AIRAMAE', 'Friday, February 19, 2016', '5:14 PM', 'LOGIN'),
(555, 'AIRAMAE', 'Friday, February 19, 2016', '5:15 PM', 'LOGOUT'),
(556, 'AIRAMAE', 'Friday, February 19, 2016', '5:59 PM', 'LOGIN'),
(557, 'AIRAMAE', 'Friday, February 19, 2016', '6:01 PM', 'LOGIN'),
(558, 'AIRAMAE', 'Friday, February 19, 2016', '6:06 PM', 'LOGIN'),
(559, 'AIRAMAE', 'Friday, February 19, 2016', '6:07 PM', 'LOGIN'),
(560, 'AIRAMAE', 'Friday, February 19, 2016', '6:08 PM', 'LOGIN'),
(561, 'AIRAMAE', 'Friday, February 19, 2016', '6:12 PM', 'LOGIN'),
(562, 'AIRAMAE', 'Friday, February 19, 2016', '6:34 PM', 'LOGIN'),
(563, 'AIRAMAE', 'Friday, February 19, 2016', '6:35 PM', 'LOGOUT'),
(564, 'KARL', 'Friday, February 19, 2016', '6:35 PM', 'LOGIN'),
(565, 'KARL', 'Friday, February 19, 2016', '6:38 PM', 'LOGIN'),
(566, 'KARL', 'Friday, February 19, 2016', '6:38 PM', 'LOGOUT'),
(567, 'AIRAMAE', 'Friday, February 19, 2016', '6:38 PM', 'LOGIN'),
(568, 'AIRAMAE', 'Friday, February 19, 2016', '6:42 PM', 'LOGOUT'),
(569, 'AIRAMAE', 'Friday, February 19, 2016', '6:43 PM', 'LOGIN'),
(570, 'AIRAMAE', 'Friday, February 19, 2016', '6:50 PM', 'LOGIN'),
(571, 'AIRAMAE', 'Friday, February 19, 2016', '6:50 PM', 'LOGOUT'),
(572, 'AIRAMAE', 'Friday, February 19, 2016', '7:02 PM', 'LOGIN'),
(573, 'AIRAMAE', 'Friday, February 19, 2016', '7:17 PM', 'LOGIN'),
(574, 'KARL', 'Friday, February 19, 2016', '7:22 PM', 'LOGIN'),
(575, 'AIRAMAE', 'Friday, February 19, 2016', '7:39 PM', 'LOGIN'),
(576, 'AIRAMAE', 'Friday, February 19, 2016', '7:39 PM', 'LOGOUT'),
(577, 'AIRAMAE', 'Friday, February 19, 2016', '7:40 PM', 'LOGIN'),
(578, 'AIRAMAE', 'Friday, February 19, 2016', '7:41 PM', 'LOGOUT'),
(579, 'AIRAMAE', 'Friday, February 19, 2016', '11:43 PM', 'LOGIN'),
(580, 'AIRAMAE', 'Friday, February 19, 2016', '11:47 PM', 'LOGIN'),
(581, 'AIRAMAE', 'Friday, February 19, 2016', '11:48 PM', 'LOGIN'),
(582, 'AIRAMAE', 'Friday, February 19, 2016', '11:49 PM', 'LOGIN'),
(583, 'AIRAMAE', 'Friday, February 19, 2016', '11:50 PM', 'LOGIN'),
(584, 'AIRAMAE', 'Friday, February 19, 2016', '11:50 PM', 'LOGIN'),
(585, 'AIRAMAE', 'Friday, February 19, 2016', '11:55 PM', 'LOGIN'),
(586, 'AIRAMAE', 'Friday, February 19, 2016', '11:56 PM', 'LOGIN'),
(587, 'AIRAMAE', 'Friday, February 19, 2016', '11:56 PM', 'LOGOUT'),
(588, 'AIRAMAE', 'Friday, February 19, 2016', '11:57 PM', 'LOGIN'),
(589, 'AIRAMAE', 'Friday, February 19, 2016', '11:58 PM', 'LOGIN'),
(590, 'AIRAMAE', 'Friday, February 19, 2016', '11:59 PM', 'LOGIN'),
(591, 'AIRAMAE', 'Saturday, February 20, 2016', '12:00 AM', 'LOGIN'),
(592, 'AIRAMAE', 'Saturday, February 20, 2016', '12:04 AM', 'LOGIN'),
(593, 'AIRAMAE', 'Saturday, February 20, 2016', '12:06 AM', 'LOGIN'),
(594, 'AIRAMAE', 'Saturday, February 20, 2016', '12:07 AM', 'LOGIN'),
(595, 'AIRAMAE', 'Saturday, February 20, 2016', '12:11 AM', 'LOGIN'),
(596, 'AIRAMAE', 'Saturday, February 20, 2016', '12:11 AM', 'LOGIN'),
(597, 'AIRAMAE', 'Saturday, February 20, 2016', '12:12 AM', 'LOGIN'),
(598, 'AIRAMAE', 'Saturday, February 20, 2016', '12:13 AM', 'LOGIN'),
(599, 'AIRAMAE', 'Saturday, February 20, 2016', '12:14 AM', 'LOGIN'),
(600, 'AIRAMAE', 'Saturday, February 20, 2016', '12:15 AM', 'LOGIN'),
(601, 'AIRAMAE', 'Saturday, February 20, 2016', '12:17 AM', 'LOGIN'),
(602, 'AIRAMAE', 'Saturday, February 20, 2016', '12:18 AM', 'LOGIN'),
(603, 'AIRAMAE', 'Saturday, February 20, 2016', '12:19 AM', 'LOGIN'),
(604, 'AIRAMAE', 'Saturday, February 20, 2016', '12:21 AM', 'LOGIN'),
(605, 'AIRAMAE', 'Saturday, February 20, 2016', '12:22 AM', 'LOGIN'),
(606, 'AIRAMAE', 'Saturday, February 20, 2016', '12:22 AM', 'LOGOUT'),
(607, 'AIRAMAE', 'Saturday, February 20, 2016', '3:07 PM', 'LOGIN'),
(608, 'AIRAMAE', 'Saturday, February 20, 2016', '3:07 PM', 'LOGOUT'),
(609, 'AIRAMAE', 'Saturday, February 20, 2016', '3:08 PM', 'LOGIN'),
(610, 'AIRAMAE', 'Saturday, February 20, 2016', '3:10 PM', 'LOGIN'),
(611, 'AIRAMAE', 'Saturday, February 20, 2016', '3:10 PM', 'LOGOUT'),
(612, 'AIRAMAE', 'Saturday, February 20, 2016', '3:11 PM', 'LOGIN'),
(613, 'AIRAMAE', 'Saturday, February 20, 2016', '3:11 PM', 'LOGOUT'),
(614, 'AIRAMAE', 'Saturday, February 20, 2016', '4:02 PM', 'LOGIN'),
(615, 'AIRAMAE', 'Saturday, February 20, 2016', '10:01 PM', 'LOGIN'),
(616, 'AIRAMAE', 'Saturday, February 20, 2016', '10:35 PM', 'LOGIN'),
(617, 'AIRAMAE', 'Saturday, February 20, 2016', '10:36 PM', 'LOGIN'),
(618, 'AIRAMAE', 'Saturday, February 20, 2016', '10:40 PM', 'LOGIN'),
(619, 'AIRAMAE', 'Saturday, February 20, 2016', '10:44 PM', 'LOGIN'),
(620, 'AIRAMAE', 'Saturday, February 20, 2016', '10:45 PM', 'LOGIN'),
(621, 'AIRAMAE', 'Saturday, February 20, 2016', '10:46 PM', 'LOGIN'),
(622, 'AIRAMAE', 'Saturday, February 20, 2016', '10:48 PM', 'LOGIN'),
(623, 'AIRAMAE', 'Saturday, February 20, 2016', '10:51 PM', 'LOGOUT');

-- --------------------------------------------------------

--
-- Table structure for table `mem_fee`
--

CREATE TABLE IF NOT EXISTS `mem_fee` (
  `m_id` int(1) NOT NULL AUTO_INCREMENT,
  `payment` varchar(10) NOT NULL,
  PRIMARY KEY (`m_id`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=2 ;

--
-- Dumping data for table `mem_fee`
--

INSERT INTO `mem_fee` (`m_id`, `payment`) VALUES
(1, '100');

-- --------------------------------------------------------

--
-- Table structure for table `tbl_account`
--

CREATE TABLE IF NOT EXISTS `tbl_account` (
  `Account_ID` int(10) NOT NULL AUTO_INCREMENT,
  `Name` varchar(255) NOT NULL,
  `Username` varchar(255) NOT NULL,
  `Password` varchar(255) NOT NULL,
  `Authority` varchar(255) NOT NULL,
  PRIMARY KEY (`Account_ID`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=3 ;

--
-- Dumping data for table `tbl_account`
--

INSERT INTO `tbl_account` (`Account_ID`, `Name`, `Username`, `Password`, `Authority`) VALUES
(1, 'Karl Dimaisip', 'karl', 'karl', 'Officer'),
(2, 'AIRA MAE ORTIZ', 'airamae', 'airamae', 'Admin');

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
