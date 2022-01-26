-- phpMyAdmin SQL Dump
-- version 4.6.4
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Jan 26, 2022 at 10:12 AM
-- Server version: 5.7.14
-- PHP Version: 5.6.25

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `academic_system`
--

-- --------------------------------------------------------

--
-- Table structure for table `admin`
--

CREATE TABLE `admin` (
  `id` int(11) NOT NULL,
  `name` varchar(30) NOT NULL,
  `password` varchar(30) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `admin`
--

INSERT INTO `admin` (`id`, `name`, `password`) VALUES
(1, 'admin', 'admin');

-- --------------------------------------------------------

--
-- Table structure for table `lecturer`
--

CREATE TABLE `lecturer` (
  `id` int(11) NOT NULL,
  `lecturer_login` varchar(30) NOT NULL,
  `lecturer_pass` varchar(30) NOT NULL,
  `lecturer_name` varchar(30) NOT NULL,
  `lecturer_last_name` varchar(30) NOT NULL,
  `subject_id` int(11) DEFAULT NULL,
  `subject_name` varchar(30) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `lecturer`
--

INSERT INTO `lecturer` (`id`, `lecturer_login`, `lecturer_pass`, `lecturer_name`, `lecturer_last_name`, `subject_id`, `subject_name`) VALUES
(1, 'test', 'test', 'test', 'test', NULL, NULL),
(2, 'Jonas', 'Jonikis', 'jonas', 'jonikis', NULL, NULL),
(4, 'Does', 'No', 'does', 'no', NULL, NULL),
(6, 'simas', 'simauskas', 'Simas', 'Simauskas', 2, 'ForScience!'),
(7, 'linas', 'pukas', 'Linas', 'Pukas', 3, 'Chemistry'),
(8, 'loki', 'floki', 'Loki', 'Floki', 5, 'Literature'),
(9, 'mark', 'smith', 'Mark', 'Smith', 6, 'English');

-- --------------------------------------------------------

--
-- Table structure for table `student`
--

CREATE TABLE `student` (
  `id` int(11) NOT NULL,
  `student_login` varchar(30) NOT NULL,
  `student_pass` varchar(30) NOT NULL,
  `student_name` varchar(30) NOT NULL,
  `student_last_name` varchar(30) NOT NULL,
  `group_id` int(11) DEFAULT NULL,
  `group_name` varchar(30) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `student`
--

INSERT INTO `student` (`id`, `student_login`, `student_pass`, `student_name`, `student_last_name`, `group_id`, `group_name`) VALUES
(1, 'test', 'test', 'test', 'test', NULL, NULL),
(2, 'Lukas', 'Likas', 'lukas', 'likas', NULL, NULL),
(4, 'Linas', 'Linaunas', 'linas', 'linaunas', NULL, NULL),
(5, 'Petras', 'Petrauskas', 'petras', 'petrauskas', NULL, NULL),
(8, 'traversy', 'media', 'Traversy', 'Media', 3, 'PI17'),
(9, 'ragnar', 'rag', 'Ragnar', 'Rag', 3, 'PI17'),
(10, 'john', 'smith', 'John', 'Smith', 3, 'PI17');

-- --------------------------------------------------------

--
-- Table structure for table `student_grades`
--

CREATE TABLE `student_grades` (
  `id` int(11) NOT NULL,
  `student_id` int(11) DEFAULT NULL,
  `student_name` varchar(30) DEFAULT NULL,
  `subject_id` int(11) DEFAULT NULL,
  `subject_name` varchar(30) DEFAULT NULL,
  `grade` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `student_grades`
--

INSERT INTO `student_grades` (`id`, `student_id`, `student_name`, `subject_id`, `subject_name`, `grade`) VALUES
(1, 8, 'Traversy', 3, 'Chemistry', 9),
(3, 1, 'test', 3, 'Chemistry', 8),
(4, 10, 'John', 3, 'Chemistry', 8);

-- --------------------------------------------------------

--
-- Table structure for table `student_groups`
--

CREATE TABLE `student_groups` (
  `id` int(11) NOT NULL,
  `group_name` varchar(30) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `student_groups`
--

INSERT INTO `student_groups` (`id`, `group_name`) VALUES
(3, 'PI17'),
(4, 'PI10');

-- --------------------------------------------------------

--
-- Table structure for table `student_group_subjects`
--

CREATE TABLE `student_group_subjects` (
  `id` int(11) NOT NULL,
  `group_id` int(11) NOT NULL,
  `group_name` varchar(30) NOT NULL,
  `subject_id` int(11) DEFAULT NULL,
  `subject_name` varchar(30) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `student_group_subjects`
--

INSERT INTO `student_group_subjects` (`id`, `group_id`, `group_name`, `subject_id`, `subject_name`) VALUES
(1, 3, 'PI17', 3, 'Chemistry');

-- --------------------------------------------------------

--
-- Table structure for table `subject`
--

CREATE TABLE `subject` (
  `id` int(11) NOT NULL,
  `subject_name` varchar(30) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `subject`
--

INSERT INTO `subject` (`id`, `subject_name`) VALUES
(2, 'ForScience!'),
(3, 'Chemistry'),
(5, 'Literature'),
(6, 'English'),
(7, 'Math');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `admin`
--
ALTER TABLE `admin`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `lecturer`
--
ALTER TABLE `lecturer`
  ADD PRIMARY KEY (`id`),
  ADD KEY `subject_id` (`subject_id`);

--
-- Indexes for table `student`
--
ALTER TABLE `student`
  ADD PRIMARY KEY (`id`),
  ADD KEY `group_id` (`group_id`);

--
-- Indexes for table `student_grades`
--
ALTER TABLE `student_grades`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `student_groups`
--
ALTER TABLE `student_groups`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `student_group_subjects`
--
ALTER TABLE `student_group_subjects`
  ADD PRIMARY KEY (`id`),
  ADD KEY `group_id` (`group_id`),
  ADD KEY `subject_id` (`subject_id`);

--
-- Indexes for table `subject`
--
ALTER TABLE `subject`
  ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `admin`
--
ALTER TABLE `admin`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;
--
-- AUTO_INCREMENT for table `lecturer`
--
ALTER TABLE `lecturer`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=10;
--
-- AUTO_INCREMENT for table `student`
--
ALTER TABLE `student`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;
--
-- AUTO_INCREMENT for table `student_grades`
--
ALTER TABLE `student_grades`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;
--
-- AUTO_INCREMENT for table `student_groups`
--
ALTER TABLE `student_groups`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;
--
-- AUTO_INCREMENT for table `student_group_subjects`
--
ALTER TABLE `student_group_subjects`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;
--
-- AUTO_INCREMENT for table `subject`
--
ALTER TABLE `subject`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=8;
--
-- Constraints for dumped tables
--

--
-- Constraints for table `lecturer`
--
ALTER TABLE `lecturer`
  ADD CONSTRAINT `lecturer_ibfk_1` FOREIGN KEY (`subject_id`) REFERENCES `subject` (`id`);

--
-- Constraints for table `student`
--
ALTER TABLE `student`
  ADD CONSTRAINT `student_ibfk_1` FOREIGN KEY (`group_id`) REFERENCES `student_groups` (`id`);

--
-- Constraints for table `student_group_subjects`
--
ALTER TABLE `student_group_subjects`
  ADD CONSTRAINT `student_group_subjects_ibfk_1` FOREIGN KEY (`group_id`) REFERENCES `student_groups` (`id`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `student_group_subjects_ibfk_2` FOREIGN KEY (`subject_id`) REFERENCES `subject` (`id`) ON DELETE CASCADE ON UPDATE CASCADE;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
