-- MySQL dump 10.10
--
-- Host: localhost    Database: dbenrollment
-- ------------------------------------------------------
-- Server version	5.0.21-community-nt

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `coursetbl`
--

DROP TABLE IF EXISTS `coursetbl`;
CREATE TABLE `coursetbl` (
  `courseid` varchar(50) NOT NULL,
  `coursename` varchar(50) default NULL,
  PRIMARY KEY  (`courseid`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `coursetbl`
--


/*!40000 ALTER TABLE `coursetbl` DISABLE KEYS */;
LOCK TABLES `coursetbl` WRITE;
INSERT INTO `coursetbl` VALUES ('0001','BSIT'),('0002','BSCS'),('0003','HRM');
UNLOCK TABLES;
/*!40000 ALTER TABLE `coursetbl` ENABLE KEYS */;

--
-- Table structure for table `discounttbl`
--

DROP TABLE IF EXISTS `discounttbl`;
CREATE TABLE `discounttbl` (
  `discountid` varchar(50) NOT NULL,
  `discountname` varchar(50) default NULL,
  `discountpercentage` varchar(50) default NULL,
  PRIMARY KEY  (`discountid`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `discounttbl`
--


/*!40000 ALTER TABLE `discounttbl` DISABLE KEYS */;
LOCK TABLES `discounttbl` WRITE;
INSERT INTO `discounttbl` VALUES ('0001','Scholar1','15'),('0002','Scholar2','20');
UNLOCK TABLES;
/*!40000 ALTER TABLE `discounttbl` ENABLE KEYS */;

--
-- Table structure for table `sectiontbl`
--

DROP TABLE IF EXISTS `sectiontbl`;
CREATE TABLE `sectiontbl` (
  `sectionid` varchar(50) NOT NULL,
  `sectionname` varchar(50) default NULL,
  PRIMARY KEY  (`sectionid`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `sectiontbl`
--


/*!40000 ALTER TABLE `sectiontbl` DISABLE KEYS */;
LOCK TABLES `sectiontbl` WRITE;
INSERT INTO `sectiontbl` VALUES ('0001','A305'),('0002','A307');
UNLOCK TABLES;
/*!40000 ALTER TABLE `sectiontbl` ENABLE KEYS */;

--
-- Table structure for table `studenttbl`
--

DROP TABLE IF EXISTS `studenttbl`;
CREATE TABLE `studenttbl` (
  `studentid` varchar(50) NOT NULL,
  `studentfname` varchar(50) default NULL,
  `studentmname` varchar(50) default NULL,
  `studentlname` varchar(50) default NULL,
  `studentage` varchar(50) default NULL,
  `studentbay` varchar(50) default NULL,
  `studentreligion` varchar(50) default NULL,
  `studentgender` varchar(50) default NULL,
  `studentcitizenship` varchar(50) default NULL,
  `studentsection` varchar(50) default NULL,
  `studentyrlevel` varchar(50) default NULL,
  `studentcourse` varchar(50) default NULL,
  `studentmothername` varchar(50) default NULL,
  `studentmothercontact` varchar(50) default NULL,
  `studentfathername` varchar(50) default NULL,
  `studentfathercontact` varchar(50) default NULL,
  `studentcontactnumber` varchar(50) default NULL,
  `studentaddress` varchar(50) default NULL,
  `studentpaymentstatus` varchar(50) default NULL,
  PRIMARY KEY  (`studentid`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `studenttbl`
--


/*!40000 ALTER TABLE `studenttbl` DISABLE KEYS */;
LOCK TABLES `studenttbl` WRITE;
INSERT INTO `studenttbl` VALUES ('0000000001','Mark Andyson','S','Paguyo','18','November161997','Roman Catholic','Male','Filipino','A307','4th Year','BSCS','Annaliza S. Paguyo','0909090980909','Paguyo','','09368375058','Pasig City','FULLY PAID'),('0000000002','Mark','test','test','12','March 4,1985','test','Male','test','A305','1st Year','BSIT','testtest','09090','testtesttest','090909','','testtesttesttest','FULLY PAID'),('0000000003','MAMA','MAMAMAMA','MAMAMAMA','MAMAMAMA','April 5,1985','MAMAMAMAMAMA','Female','MAMAMAMAMAMA','NOT YET ASSESSED','NOT YET ASSESSED','NOT YET ASSESSED','MAMAMAMA','MAMAMAMA','MAMAMAMA','MAMAMAMAMAMA','','MAMAMAMAMAMA','REMAINING BALANCE:10000'),('0000000004','aaaaa','aaaa','aaaaaa','aaaaa','March 28,2006','aaaaaaa','Male','aaaaaa','NOT YET ASSESSED','NOT YET ASSESSED','NOT YET ASSESSED','aaaaaaaaaaaaaa','000000000','aaaaaaaaaa','00000000','689078','aaaaaaaaaaaaaa','FULLY PAID');
UNLOCK TABLES;
/*!40000 ALTER TABLE `studenttbl` ENABLE KEYS */;

--
-- Table structure for table `tuitiontbl`
--

DROP TABLE IF EXISTS `tuitiontbl`;
CREATE TABLE `tuitiontbl` (
  `tuitionprice` varchar(50) default NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tuitiontbl`
--


/*!40000 ALTER TABLE `tuitiontbl` DISABLE KEYS */;
LOCK TABLES `tuitiontbl` WRITE;
INSERT INTO `tuitiontbl` VALUES ('20000');
UNLOCK TABLES;
/*!40000 ALTER TABLE `tuitiontbl` ENABLE KEYS */;

--
-- Table structure for table `usertbl`
--

DROP TABLE IF EXISTS `usertbl`;
CREATE TABLE `usertbl` (
  `userid` varchar(10) NOT NULL,
  `username` varchar(50) default NULL,
  `userpass` varchar(50) default NULL,
  `userfirstname` varchar(50) default NULL,
  `usermiddlname` varchar(50) default NULL,
  `userlastname` varchar(50) default NULL,
  `userlevel` varchar(50) default NULL,
  `usercontactnum` varchar(50) default NULL,
  `useraddress` varchar(50) default NULL,
  PRIMARY KEY  (`userid`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `usertbl`
--


/*!40000 ALTER TABLE `usertbl` DISABLE KEYS */;
LOCK TABLES `usertbl` WRITE;
INSERT INTO `usertbl` VALUES ('0001','paguyo0001','paguyo0001','Mark Andyson','S.','Paguyo','Admin','09368375058','Pasig City'),('0002','mama0002','mama0002','mark','mama','mama','Registrar','0987898767','mama'),('0003','Jaen0003','qwertyuiop','Kyle','Cuenca','Jaen','Registrar','09126236634','Valley Golf, Cainta'),('0004','dedios0004','222','anthonyi','canonn','dedios','Cashier','0999999','Rizal');
UNLOCK TABLES;
/*!40000 ALTER TABLE `usertbl` ENABLE KEYS */;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

