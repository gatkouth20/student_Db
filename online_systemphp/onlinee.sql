-- phpMyAdmin SQL Dump
-- version 2.10.1
-- http://www.phpmyadmin.net
-- 
-- Host: localhost
-- Generation Time: Oct 26, 2015 at 04:40 PM
-- Server version: 5.0.41
-- PHP Version: 5.2.3

SET SQL_MODE="NO_AUTO_VALUE_ON_ZERO";

-- 
-- Database: `onlinee`
-- 

-- --------------------------------------------------------

-- 
-- Table structure for table `admin`
-- 

CREATE TABLE `admin` (
  `ID` int(4) NOT NULL auto_increment,
  `username` varchar(8) NOT NULL,
  `password` varchar(8) NOT NULL,
  PRIMARY KEY  (`ID`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1 AUTO_INCREMENT=2 ;

-- 
-- Dumping data for table `admin`
-- 

INSERT INTO `admin` (`ID`, `username`, `password`) VALUES 
(1, 'Nyuel', 'Nyuel');

-- --------------------------------------------------------

-- 
-- Table structure for table `post`
-- 

CREATE TABLE `post` (
  `ID` int(4) NOT NULL auto_increment,
  `firstname` varchar(10) NOT NULL,
  `Lastname` varchar(10) NOT NULL,
  `M_name` varchar(10) NOT NULL,
  `Country` varchar(19) NOT NULL,
  `City` varchar(10) NOT NULL,
  `State` varchar(10) NOT NULL,
  `Zip_code` varchar(4) NOT NULL,
  `Day` int(8) NOT NULL,
  `month` varchar(8) NOT NULL,
  `Year` int(8) NOT NULL,
  `Place_birth` varchar(100) NOT NULL,
  `Age` int(20) NOT NULL,
  PRIMARY KEY  (`ID`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1 AUTO_INCREMENT=124 ;

-- 
-- Dumping data for table `post`
-- 

INSERT INTO `post` (`ID`, `firstname`, `Lastname`, `M_name`, `Country`, `City`, `State`, `Zip_code`, `Day`, `month`, `Year`, `Place_birth`, `Age`) VALUES 
(77, 'Gatkouth', 'Nyuel', 'Paah', '', 'juba', 'unity stat', '+211', 9, 'FEB', 1989, '', 0),
(121, 'Gatkouth', 'Nyuel', 'john', 'select your country', 'juba', 'nimule', '+211', 15, 'Match', 2013, '', 0),
(122, 'Gatkouth', 'Nyuel', 'john', 'select your country', 'juba', 'nimule', '+211', 15, 'Match', 2013, '', 0),
(123, '', '', '', 'Somalia', '', '', '', 1, 'month', 0, '', 0);

-- --------------------------------------------------------

-- 
-- Table structure for table `post2`
-- 

CREATE TABLE `post2` (
  `ID` int(8) NOT NULL auto_increment,
  `status` varchar(8) NOT NULL,
  `Gender` varchar(4) NOT NULL,
  `Email_address` varchar(10) NOT NULL,
  `P_phone` int(15) NOT NULL,
  `home_phone` int(15) NOT NULL,
  `best_choice` varchar(10) NOT NULL,
  `programs` varchar(10) NOT NULL,
  `start` varchar(10) NOT NULL,
  `Education` varchar(10) NOT NULL,
  `comment` varchar(10) NOT NULL,
  PRIMARY KEY  (`ID`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1 AUTO_INCREMENT=64 ;

-- 
-- Dumping data for table `post2`
-- 

INSERT INTO `post2` (`ID`, `status`, `Gender`, `Email_address`, `P_phone`, `home_phone`, `best_choice`, `programs`, `start`, `Education`, `comment`) VALUES 
(31, 'Married', '', 'Dina20@gma', 0, 98765432, 'Bachelor o', 'Faculty of', '', 'master''s d', 'guys come '),
(52, 'single', 'Male', '', 0, 0, '12-13', '12-13', '11-12', '11-12', ''),
(53, 'single', 'Fema', '', 0, 0, '12-13', '12-13', '11-12', '11-12', ''),
(54, 'single', 'Fema', '', 0, 0, '12-13', '12-13', '11-12', '11-12', ''),
(55, 'single', '10-1', 'Gatkouth20', 787365352, 984727, '12-13', 'Faculty of', 'jan intake', '11-12', ''),
(56, 'single', '10-1', 'Gatkouth20', 787365352, 984727, '12-13', 'Faculty of', 'jan intake', 'master''s d', ''),
(57, 'single', 'Male', 'Gatkouth20', 787365352, 984727, '12-13', 'Faculty of', 'jan intake', 'master''s d', ''),
(58, '', '', '', 0, 0, '', '', '', '', ''),
(59, '', '', '', 0, 0, '', '', '', '', ''),
(60, '', '', '', 0, 0, '', '', '', '', ''),
(61, '', '', '', 0, 0, '', '', '', '', ''),
(62, '', '', '', 0, 0, '', '', '', '', ''),
(63, 'select y', 'Fema', '', 0, 0, 'select you', 'select you', 'jan intake', 'High level', '');
