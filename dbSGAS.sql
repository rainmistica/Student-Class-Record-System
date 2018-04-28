/*
SQLyog Ultimate v12.09 (32 bit)
MySQL - 5.5.50 : Database - sgas
*********************************************************************
*/

/*!40101 SET NAMES utf8 */;

/*!40101 SET SQL_MODE=''*/;

/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;
CREATE DATABASE /*!32312 IF NOT EXISTS*/`sgas` /*!40100 DEFAULT CHARACTER SET latin1 */;

USE `sgas`;

/*Table structure for table `gradesheet` */

DROP TABLE IF EXISTS `gradesheet`;

CREATE TABLE `gradesheet` (
  `SNum` int(10) DEFAULT NULL,
  `LName` varchar(25) DEFAULT NULL,
  `FName` varchar(25) DEFAULT NULL,
  `SCode` varchar(15) DEFAULT NULL,
  `AT` double DEFAULT NULL,
  `AR` double(5,2) DEFAULT NULL,
  `AG` double(5,2) DEFAULT NULL,
  `ET` double DEFAULT NULL,
  `ER` double(5,2) DEFAULT NULL,
  `EG` double(5,2) DEFAULT NULL,
  `OT` double DEFAULT NULL,
  `ORat` double(5,2) DEFAULT NULL,
  `OG` double(5,2) DEFAULT NULL,
  `PT` double DEFAULT NULL,
  `PR` double(5,2) DEFAULT NULL,
  `PG` double(5,2) DEFAULT NULL,
  `QT` double DEFAULT NULL,
  `QR` double(5,2) DEFAULT NULL,
  `QG` double(5,2) unsigned DEFAULT NULL,
  `RT` double DEFAULT NULL,
  `RR` double(5,2) DEFAULT NULL,
  `RG` double(5,2) DEFAULT NULL,
  `ST` double DEFAULT NULL,
  `SR` double(5,2) DEFAULT NULL,
  `SG` double(5,2) DEFAULT NULL,
  `Term` varchar(5) DEFAULT NULL,
  `ATT` double DEFAULT NULL,
  `ATR` double(5,2) DEFAULT NULL,
  `ATG` double(5,2) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

/*Data for the table `gradesheet` */

/*Table structure for table `tblass` */

DROP TABLE IF EXISTS `tblass`;

CREATE TABLE `tblass` (
  `SNum` int(10) DEFAULT NULL,
  `LName` varchar(25) DEFAULT NULL,
  `FName` varchar(25) DEFAULT NULL,
  `SCode` varchar(15) DEFAULT NULL,
  `N1` double DEFAULT NULL,
  `N2` double DEFAULT NULL,
  `N3` double DEFAULT NULL,
  `N4` double DEFAULT NULL,
  `N5` double DEFAULT NULL,
  `N6` double DEFAULT NULL,
  `N7` double DEFAULT NULL,
  `N8` double DEFAULT NULL,
  `N9` double DEFAULT NULL,
  `N10` double DEFAULT NULL,
  `N11` double DEFAULT NULL,
  `N12` double DEFAULT NULL,
  `Total` double DEFAULT NULL,
  `Rat` decimal(5,2) DEFAULT NULL,
  `Grade` double(5,2) DEFAULT NULL,
  `Term` varchar(5) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

/*Data for the table `tblass` */

/*Table structure for table `tblattendance` */

DROP TABLE IF EXISTS `tblattendance`;

CREATE TABLE `tblattendance` (
  `SNum` int(10) DEFAULT NULL,
  `LName` varchar(25) DEFAULT NULL,
  `FName` varchar(25) DEFAULT NULL,
  `SCode` varchar(25) DEFAULT NULL,
  `Course` varchar(25) DEFAULT NULL,
  `Section` varchar(5) DEFAULT NULL,
  `S1` double DEFAULT NULL,
  `S2` double DEFAULT NULL,
  `S3` double DEFAULT NULL,
  `S4` double DEFAULT NULL,
  `S5` double DEFAULT NULL,
  `S6` double DEFAULT NULL,
  `S7` double DEFAULT NULL,
  `S8` double DEFAULT NULL,
  `S9` double DEFAULT NULL,
  `S10` double DEFAULT NULL,
  `S11` double DEFAULT NULL,
  `S12` double DEFAULT NULL,
  `S13` double DEFAULT NULL,
  `S14` double DEFAULT NULL,
  `S15` double DEFAULT NULL,
  `S16` double DEFAULT NULL,
  `S17` double DEFAULT NULL,
  `S18` double DEFAULT NULL,
  `S19` double DEFAULT NULL,
  `S20` double DEFAULT NULL,
  `Total` double DEFAULT NULL,
  `Rat` decimal(5,2) DEFAULT NULL,
  `Grade` double(5,2) DEFAULT NULL,
  `Term` varchar(5) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

/*Data for the table `tblattendance` */

/*Table structure for table `tblclass` */

DROP TABLE IF EXISTS `tblclass`;

CREATE TABLE `tblclass` (
  `SCode` varchar(15) DEFAULT NULL,
  `Course` varchar(15) DEFAULT NULL,
  `Section` varchar(15) DEFAULT NULL,
  `STS` varchar(15) DEFAULT NULL,
  `STE` varchar(15) DEFAULT NULL,
  `ETS` varchar(15) DEFAULT NULL,
  `ETE` varchar(15) DEFAULT NULL,
  `Day` varchar(15) DEFAULT NULL,
  `Status` varchar(15) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

/*Data for the table `tblclass` */

/*Table structure for table `tblcmp` */

DROP TABLE IF EXISTS `tblcmp`;

CREATE TABLE `tblcmp` (
  `StudNum` int(10) DEFAULT NULL,
  `LName` varchar(25) DEFAULT NULL,
  `FName` varchar(25) DEFAULT NULL,
  `SubCode` varchar(25) DEFAULT NULL,
  `CourseName` varchar(25) DEFAULT NULL,
  `SecName` varchar(25) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

/*Data for the table `tblcmp` */

/*Table structure for table `tblcomp` */

DROP TABLE IF EXISTS `tblcomp`;

CREATE TABLE `tblcomp` (
  `SCode` varchar(15) DEFAULT NULL,
  `Prelim` double DEFAULT NULL,
  `Midterm` double DEFAULT NULL,
  `Final` double DEFAULT NULL,
  `Total` double DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

/*Data for the table `tblcomp` */

/*Table structure for table `tblcourse` */

DROP TABLE IF EXISTS `tblcourse`;

CREATE TABLE `tblcourse` (
  `CCode` varchar(10) NOT NULL,
  `CName` varchar(80) DEFAULT NULL,
  `Status` varchar(10) DEFAULT NULL,
  PRIMARY KEY (`CCode`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

/*Data for the table `tblcourse` */

insert  into `tblcourse`(`CCode`,`CName`,`Status`) values ('BSED','Bachelor of Science in Education','Active'),('BSHRM','Bachelor of Science in Hospitality and Management','Active'),('CET','Civil Engineering Technology','Active'),('COET','Computer Engineering Technology','Active'),('ECET','Electronics and Communication Engineering Technology','Active'),('EET','Electrical Engineering Technology','Active');

/*Table structure for table `tblexam` */

DROP TABLE IF EXISTS `tblexam`;

CREATE TABLE `tblexam` (
  `SNum` int(10) DEFAULT NULL,
  `LName` varchar(25) DEFAULT NULL,
  `FName` varchar(25) DEFAULT NULL,
  `SCode` varchar(15) DEFAULT NULL,
  `N1` double DEFAULT NULL,
  `Rat` decimal(5,2) DEFAULT NULL,
  `Grade` double(5,2) DEFAULT NULL,
  `Term` varchar(5) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

/*Data for the table `tblexam` */

/*Table structure for table `tblgsheet` */

DROP TABLE IF EXISTS `tblgsheet`;

CREATE TABLE `tblgsheet` (
  `SNum` int(10) DEFAULT NULL,
  `LName` varchar(25) DEFAULT NULL,
  `FName` varchar(25) DEFAULT NULL,
  `PGrade` double(5,2) DEFAULT NULL,
  `MGrade` double(5,2) DEFAULT NULL,
  `FGrade` double(5,2) DEFAULT NULL,
  `SFinal` double(5,2) DEFAULT NULL,
  `FNum` double(3,2) DEFAULT NULL,
  `Remarks` varchar(10) DEFAULT NULL,
  `SCode` varchar(15) DEFAULT NULL,
  `Course` varchar(25) DEFAULT NULL,
  `Section` varchar(5) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

/*Data for the table `tblgsheet` */

/*Table structure for table `tblother` */

DROP TABLE IF EXISTS `tblother`;

CREATE TABLE `tblother` (
  `SNum` int(10) DEFAULT NULL,
  `LName` varchar(25) DEFAULT NULL,
  `FName` varchar(25) DEFAULT NULL,
  `SCode` varchar(15) DEFAULT NULL,
  `N1` double DEFAULT NULL,
  `N2` double DEFAULT NULL,
  `N3` double DEFAULT NULL,
  `N4` double DEFAULT NULL,
  `N5` double DEFAULT NULL,
  `Total` double DEFAULT NULL,
  `Rat` decimal(5,2) DEFAULT NULL,
  `Grade` double(5,2) DEFAULT NULL,
  `Term` varchar(5) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

/*Data for the table `tblother` */

/*Table structure for table `tblproj` */

DROP TABLE IF EXISTS `tblproj`;

CREATE TABLE `tblproj` (
  `SNum` int(10) DEFAULT NULL,
  `LName` varchar(25) DEFAULT NULL,
  `FName` varchar(25) DEFAULT NULL,
  `SCode` varchar(15) DEFAULT NULL,
  `N1` double DEFAULT NULL,
  `Rat` decimal(5,2) DEFAULT NULL,
  `Grade` double(5,2) DEFAULT NULL,
  `Term` varchar(5) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

/*Data for the table `tblproj` */

/*Table structure for table `tblquiz` */

DROP TABLE IF EXISTS `tblquiz`;

CREATE TABLE `tblquiz` (
  `SNum` int(10) DEFAULT NULL,
  `LName` varchar(25) DEFAULT NULL,
  `FName` varchar(25) DEFAULT NULL,
  `SCode` varchar(15) DEFAULT NULL,
  `N1` double DEFAULT NULL,
  `N2` double DEFAULT NULL,
  `N3` double DEFAULT NULL,
  `N4` double DEFAULT NULL,
  `N5` double DEFAULT NULL,
  `N6` double DEFAULT NULL,
  `N7` double DEFAULT NULL,
  `N8` double DEFAULT NULL,
  `N9` double DEFAULT NULL,
  `N10` double DEFAULT NULL,
  `N11` double DEFAULT NULL,
  `N12` double DEFAULT NULL,
  `Total` double DEFAULT NULL,
  `Rat` decimal(5,2) DEFAULT NULL,
  `Grade` double(5,2) DEFAULT NULL,
  `Term` varchar(5) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

/*Data for the table `tblquiz` */

/*Table structure for table `tblrec` */

DROP TABLE IF EXISTS `tblrec`;

CREATE TABLE `tblrec` (
  `SNum` int(10) DEFAULT NULL,
  `LName` varchar(25) DEFAULT NULL,
  `FName` varchar(25) DEFAULT NULL,
  `SCode` varchar(15) DEFAULT NULL,
  `N1` double DEFAULT NULL,
  `Rat` decimal(5,2) DEFAULT NULL,
  `Grade` double(5,2) DEFAULT NULL,
  `Term` varchar(5) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

/*Data for the table `tblrec` */

/*Table structure for table `tblseatw` */

DROP TABLE IF EXISTS `tblseatw`;

CREATE TABLE `tblseatw` (
  `SNum` int(10) NOT NULL,
  `LName` varchar(25) DEFAULT NULL,
  `FName` varchar(25) DEFAULT NULL,
  `SCode` varchar(15) DEFAULT NULL,
  `N1` double DEFAULT NULL,
  `N2` double DEFAULT NULL,
  `N3` double DEFAULT NULL,
  `N4` double DEFAULT NULL,
  `N5` double DEFAULT NULL,
  `N6` double DEFAULT NULL,
  `N7` double DEFAULT NULL,
  `N8` double DEFAULT NULL,
  `N9` double DEFAULT NULL,
  `N10` double DEFAULT NULL,
  `N11` double DEFAULT NULL,
  `N12` double DEFAULT NULL,
  `Total` double DEFAULT NULL,
  `Rat` decimal(5,2) DEFAULT NULL,
  `Grade` double(5,2) DEFAULT NULL,
  `Term` varchar(5) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

/*Data for the table `tblseatw` */

/*Table structure for table `tblsec` */

DROP TABLE IF EXISTS `tblsec`;

CREATE TABLE `tblsec` (
  `Section` varchar(10) NOT NULL,
  `Status` varchar(10) DEFAULT NULL,
  `SN` varchar(5) DEFAULT NULL,
  `SL` varchar(5) DEFAULT NULL,
  PRIMARY KEY (`Section`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

/*Data for the table `tblsec` */

insert  into `tblsec`(`Section`,`Status`,`SN`,`SL`) values ('3A','Active','3','A'),('3B','Active','3','B'),('3C','Active','3','C'),('3D','Inactive','3','D');

/*Table structure for table `tblstud` */

DROP TABLE IF EXISTS `tblstud`;

CREATE TABLE `tblstud` (
  `SNum` int(10) NOT NULL,
  `LName` varchar(30) DEFAULT NULL,
  `FName` varchar(30) DEFAULT NULL,
  `MName` varchar(30) DEFAULT NULL,
  `Course` varchar(30) DEFAULT NULL,
  `Section` varchar(20) DEFAULT NULL,
  `CNum` varchar(26) DEFAULT NULL,
  `EAdd` varchar(30) DEFAULT NULL,
  `Status` varchar(10) DEFAULT NULL,
  PRIMARY KEY (`SNum`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

/*Data for the table `tblstud` */

/*Table structure for table `tblsubj` */

DROP TABLE IF EXISTS `tblsubj`;

CREATE TABLE `tblsubj` (
  `SCode` varchar(10) NOT NULL,
  `SName` varchar(80) DEFAULT NULL,
  `Status` varchar(10) DEFAULT NULL,
  PRIMARY KEY (`SCode`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

/*Data for the table `tblsubj` */

insert  into `tblsubj`(`SCode`,`SName`,`Status`) values ('COET311','Object-Oriented Programming','Active');

/*Table structure for table `tbltass` */

DROP TABLE IF EXISTS `tbltass`;

CREATE TABLE `tbltass` (
  `SCode` varchar(15) DEFAULT NULL,
  `NT1` double DEFAULT NULL,
  `NT2` double DEFAULT NULL,
  `NT3` double DEFAULT NULL,
  `NT4` double DEFAULT NULL,
  `NT5` double DEFAULT NULL,
  `NT6` double DEFAULT NULL,
  `NT7` double DEFAULT NULL,
  `NT8` double DEFAULT NULL,
  `NT9` double DEFAULT NULL,
  `NT10` double DEFAULT NULL,
  `NT11` double DEFAULT NULL,
  `NT12` double DEFAULT NULL,
  `Tot` double DEFAULT NULL,
  `PTerm` varchar(5) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

/*Data for the table `tbltass` */

insert  into `tbltass`(`SCode`,`NT1`,`NT2`,`NT3`,`NT4`,`NT5`,`NT6`,`NT7`,`NT8`,`NT9`,`NT10`,`NT11`,`NT12`,`Tot`,`PTerm`) values ('COET311',10,10,10,10,0,0,0,0,0,0,0,0,40,'P'),('COET311',10,10,10,0,0,0,0,0,0,0,0,0,30,'M'),('COET311',10,10,10,0,0,0,0,0,0,0,0,0,30,'F');

/*Table structure for table `tbltatt` */

DROP TABLE IF EXISTS `tbltatt`;

CREATE TABLE `tbltatt` (
  `SCode` varchar(15) DEFAULT NULL,
  `Tot` double DEFAULT NULL,
  `PTerm` varchar(5) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

/*Data for the table `tbltatt` */

insert  into `tbltatt`(`SCode`,`Tot`,`PTerm`) values ('COET311',10,'P'),('COET311',13,'M'),('COET311',15,'F');

/*Table structure for table `tbltc` */

DROP TABLE IF EXISTS `tbltc`;

CREATE TABLE `tbltc` (
  `SCode` varchar(15) DEFAULT NULL,
  `SW` decimal(5,2) DEFAULT NULL,
  `Assign` decimal(5,2) DEFAULT NULL,
  `Rec` decimal(5,2) DEFAULT NULL,
  `Quiz` decimal(5,2) DEFAULT NULL,
  `Att` decimal(5,2) DEFAULT NULL,
  `Exam` decimal(5,2) DEFAULT NULL,
  `Other` decimal(5,2) DEFAULT NULL,
  `Proj` decimal(5,2) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

/*Data for the table `tbltc` */

insert  into `tbltc`(`SCode`,`SW`,`Assign`,`Rec`,`Quiz`,`Att`,`Exam`,`Other`,`Proj`) values ('COET311','0.10','0.10','0.10','0.10','0.10','0.30','0.10','0.10');

/*Table structure for table `tblterm` */

DROP TABLE IF EXISTS `tblterm`;

CREATE TABLE `tblterm` (
  `TermName` varchar(15) DEFAULT NULL,
  `TN` varchar(5) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

/*Data for the table `tblterm` */

insert  into `tblterm`(`TermName`,`TN`) values ('Prelim','P'),('Midterm','M'),('Final','F');

/*Table structure for table `tbltother` */

DROP TABLE IF EXISTS `tbltother`;

CREATE TABLE `tbltother` (
  `SCode` varchar(15) DEFAULT NULL,
  `NT1` double DEFAULT NULL,
  `NT2` double DEFAULT NULL,
  `NT3` double DEFAULT NULL,
  `NT4` double DEFAULT NULL,
  `NT5` double DEFAULT NULL,
  `Tot` double DEFAULT NULL,
  `PTerm` varchar(5) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

/*Data for the table `tbltother` */

insert  into `tbltother`(`SCode`,`NT1`,`NT2`,`NT3`,`NT4`,`NT5`,`Tot`,`PTerm`) values ('COET311',10,10,0,0,0,20,'P'),('COET311',10,0,0,0,0,10,'M'),('COET311',10,10,0,0,0,20,'F');

/*Table structure for table `tbltquiz` */

DROP TABLE IF EXISTS `tbltquiz`;

CREATE TABLE `tbltquiz` (
  `SCode` varchar(15) DEFAULT NULL,
  `NT1` double DEFAULT NULL,
  `NT2` double DEFAULT NULL,
  `NT3` double DEFAULT NULL,
  `NT4` double DEFAULT NULL,
  `NT5` double DEFAULT NULL,
  `NT6` double DEFAULT NULL,
  `NT7` double DEFAULT NULL,
  `NT8` double DEFAULT NULL,
  `NT9` double DEFAULT NULL,
  `NT10` double DEFAULT NULL,
  `NT11` double DEFAULT NULL,
  `NT12` double DEFAULT NULL,
  `Tot` double DEFAULT NULL,
  `PTerm` varchar(5) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

/*Data for the table `tbltquiz` */

insert  into `tbltquiz`(`SCode`,`NT1`,`NT2`,`NT3`,`NT4`,`NT5`,`NT6`,`NT7`,`NT8`,`NT9`,`NT10`,`NT11`,`NT12`,`Tot`,`PTerm`) values ('COET311',10,10,0,0,0,0,0,0,0,0,0,0,20,'P'),('COET311',10,10,10,0,0,0,0,0,0,0,0,0,30,'M'),('COET311',10,10,10,10,10,0,0,0,0,0,0,0,50,'F');

/*Table structure for table `tbltrpe` */

DROP TABLE IF EXISTS `tbltrpe`;

CREATE TABLE `tbltrpe` (
  `SCode` varchar(15) DEFAULT NULL,
  `TR` double DEFAULT NULL,
  `TP` double DEFAULT NULL,
  `TE` double DEFAULT NULL,
  `PTerm` varchar(5) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

/*Data for the table `tbltrpe` */

insert  into `tbltrpe`(`SCode`,`TR`,`TP`,`TE`,`PTerm`) values ('COET311',10,10,90,'P'),('COET311',100,10,100,'M'),('COET311',20,10,80,'F');

/*Table structure for table `tbltseatw` */

DROP TABLE IF EXISTS `tbltseatw`;

CREATE TABLE `tbltseatw` (
  `SCode` varchar(15) DEFAULT NULL,
  `NT1` double DEFAULT NULL,
  `NT2` double DEFAULT NULL,
  `NT3` double DEFAULT NULL,
  `NT4` double DEFAULT NULL,
  `NT5` double DEFAULT NULL,
  `NT6` double DEFAULT NULL,
  `NT7` double DEFAULT NULL,
  `NT8` double DEFAULT NULL,
  `NT9` double DEFAULT NULL,
  `NT10` double DEFAULT NULL,
  `NT11` double DEFAULT NULL,
  `NT12` double DEFAULT NULL,
  `Tot` double DEFAULT NULL,
  `PTerm` varchar(5) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

/*Data for the table `tbltseatw` */

insert  into `tbltseatw`(`SCode`,`NT1`,`NT2`,`NT3`,`NT4`,`NT5`,`NT6`,`NT7`,`NT8`,`NT9`,`NT10`,`NT11`,`NT12`,`Tot`,`PTerm`) values ('COET311',10,10,10,0,0,0,0,0,0,0,0,0,30,'P'),('COET311',10,10,10,10,0,0,0,0,0,0,0,0,40,'M'),('COET311',10,10,0,0,0,0,0,0,0,0,0,0,20,'F');

/*Table structure for table `tbluser` */

DROP TABLE IF EXISTS `tbluser`;

CREATE TABLE `tbluser` (
  `Username` varchar(10) NOT NULL,
  `Password` varchar(15) DEFAULT NULL,
  `Category` varchar(15) DEFAULT NULL,
  `UserLevel` int(11) DEFAULT NULL,
  PRIMARY KEY (`Username`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

/*Data for the table `tbluser` */

insert  into `tbluser`(`Username`,`Password`,`Category`,`UserLevel`) values ('admin','admin','Teacher',1),('user','1234','High School',2);

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;
