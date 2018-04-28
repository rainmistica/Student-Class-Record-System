/*
SQLyog Ultimate v12.09 (32 bit)
MySQL - 5.5.50 : Database - dbclassrec
*********************************************************************
*/

/*!40101 SET NAMES utf8 */;

/*!40101 SET SQL_MODE=''*/;

/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;
CREATE DATABASE /*!32312 IF NOT EXISTS*/`dbclassrec` /*!40100 DEFAULT CHARACTER SET latin1 */;

USE `dbclassrec`;

/*Table structure for table `tbl_course` */

DROP TABLE IF EXISTS `tbl_course`;

CREATE TABLE `tbl_course` (
  `course_id` bigint(20) NOT NULL AUTO_INCREMENT,
  `course_name` varchar(150) NOT NULL,
  `short` varchar(50) NOT NULL,
  `rank` bigint(20) NOT NULL,
  `status` varchar(20) NOT NULL,
  `dept_no` bigint(20) DEFAULT NULL,
  PRIMARY KEY (`course_id`)
) ENGINE=InnoDB AUTO_INCREMENT=10 DEFAULT CHARSET=latin1;

/*Data for the table `tbl_course` */

insert  into `tbl_course`(`course_id`,`course_name`,`short`,`rank`,`status`,`dept_no`) values (1,'Bachelor of Science in Hospitality Management','BSHM',1,'Active',1),(2,'Bachelor of Secondary Education (Major In English)','BSE Eng',2,'Active',2),(3,'Electronics And Communication Engineering Technology','ECET',4,'Active',3),(4,'Electrical Engineering Technology','EET',5,'Active',3),(5,'Civil Engineering Technology','CET',6,'Active',3),(6,'Computer Engineering Technology','COET',7,'Active',3),(7,'Bachelor of Secondary Education (Major In Math)','BSE Math',3,'Active',2),(8,'Teacher Certificate Program','TCP',8,'Active',2),(9,'General Engineering','Gen Eng',9,'Active',3);

/*Table structure for table `tbl_cur` */

DROP TABLE IF EXISTS `tbl_cur`;

CREATE TABLE `tbl_cur` (
  `cur_id` bigint(20) NOT NULL AUTO_INCREMENT,
  `course_id` varchar(150) NOT NULL,
  `cur_name` varchar(150) NOT NULL,
  `status` varchar(150) NOT NULL,
  `tot_year` int(11) NOT NULL,
  PRIMARY KEY (`cur_id`)
) ENGINE=InnoDB AUTO_INCREMENT=20 DEFAULT CHARSET=latin1;

/*Data for the table `tbl_cur` */

insert  into `tbl_cur`(`cur_id`,`course_id`,`cur_name`,`status`,`tot_year`) values (1,'1','BSHRM_2011-2012','Active',4),(2,'2','BSE_ENG_2011-2012','Active',4),(3,'3','ECET_2015-2016','Active',3),(4,'4','EET_2015-2016','Active',3),(5,'5','CET_2015-2016','Active',3),(6,'6','COET_2015-2016','Active',3),(7,'2','BSE_ENG_2015-2016','Active',4),(8,'7','BSE_Math_2015-2016','Active',4),(9,'1','BSHM_2015-2016','Active',4),(19,'9','Gen_Eng_2015-2016','Active',3);

/*Table structure for table `tbl_dept` */

DROP TABLE IF EXISTS `tbl_dept`;

CREATE TABLE `tbl_dept` (
  `dept_no` bigint(20) NOT NULL,
  `dept_name` varchar(20) DEFAULT NULL,
  PRIMARY KEY (`dept_no`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

/*Data for the table `tbl_dept` */

insert  into `tbl_dept`(`dept_no`,`dept_name`) values (1,'HMP'),(2,'TEP'),(3,'ETP');

/*Table structure for table `tbl_subject` */

DROP TABLE IF EXISTS `tbl_subject`;

CREATE TABLE `tbl_subject` (
  `sub_id` bigint(20) NOT NULL AUTO_INCREMENT,
  `course_id` varchar(150) NOT NULL,
  `cur_id` varchar(150) NOT NULL,
  `sub_code` varchar(150) NOT NULL,
  `des_title` varchar(300) NOT NULL,
  `year` varchar(150) NOT NULL,
  `sem` varchar(150) NOT NULL,
  `units` varchar(150) NOT NULL,
  `pre_req` varchar(255) NOT NULL,
  PRIMARY KEY (`sub_id`)
) ENGINE=InnoDB AUTO_INCREMENT=524 DEFAULT CHARSET=latin1;

/*Data for the table `tbl_subject` */

insert  into `tbl_subject`(`sub_id`,`course_id`,`cur_id`,`sub_code`,`des_title`,`year`,`sem`,`units`,`pre_req`) values (1,'1','1','Eng 111','Communication Arts 1','1','1st','3','None'),(2,'1','1','Math 111','Business Math','1','1st','3','None'),(3,'1','1','Hum 111','Art Appreciation','1','1st','3','None'),(4,'1','1','Fil 111','Komunikasyon sa Akademikong Filipino','1','1st','3','None'),(5,'1','1','Nat. Sci. 111','Principles of Safety, Hygiene and Sanitation','1','1st','3','None'),(6,'1','1','Nat. Sci. 112','Environmental Science','1','1st','3','None'),(7,'1','1','Lit 111','Literature','1','1st','3','None'),(8,'1','1','Tour 111','Principles of Tourism 1','1','1st','3','None'),(9,'1','1','P.E. 111','Physical Fitness and Gymnastics','1','1st','2','None'),(10,'1','1','N.S.T.P. 111','National Service Training Program','1','1st','3','None'),(11,'1','1','Eng 122','Communication Arts 2','1','2nd','3','Eng 111'),(12,'1','1','Fil 122','Pagbasa at Pagsulat Tungo sa Pananaliksik','1','2nd','3','Fil 111'),(13,'1','1','RIZAL 121','Life and Works of Rizal','1','2nd','3','None'),(14,'1','1','PDPR 111','Personality Development and Public Relations','1','2nd','3','None'),(15,'1','1','SS 121','Cultural Anthropology with Indigenous People','1','2nd','3','SS 111'),(16,'1','1','ICT 121','Basic Computer','1','2nd','3','None'),(17,'1','1','HRM 121','Front Office Procedures','1','2nd','3','None'),(18,'1','1','Tour 122','Principles of Tourism 2','1','2nd','3','Tour 111'),(19,'1','1','P.E. 122','Rhythmic Activities','1','2nd','2','PE 111'),(20,'1','1','N.S.T.P. 122','National Service Training Program 2','1','2nd','3','NSTP 111'),(21,'1','1','Hum 122','Logic','2','1st','3','None'),(22,'1','1','SS 212','Gen. Psychology w/ HIV, Population Education, SARS & Drug Education','2','1st','3','None'),(23,'1','1','SS 213','Philippine History, Government and Constitution','2','1st','3','None'),(24,'1','1','BED 211','Principles of Management','2','1st','3','None'),(25,'1','1','BED 212','Human Behavior in Organization','2','1st','3','None'),(26,'1','1','Tour 213','Culinary Arts and Sciences','2','1st','3','Nat Sci 111'),(27,'1','1','HRM 212','Housekeeping Procedures','2','1st','3','Nat Sci 111'),(28,'1','1','P.E. 213','Individual Sports and Games','2','1st','2','PE 122'),(29,'1','1','SS 224','Basic Economics, Taxation and Agrarian Reform','2','2nd','3','SS 213'),(30,'1','1','BED 223','Principles of Marketing','2','2nd','3','BED 212'),(31,'1','1','BED 224','Accounting','2','2nd','3','BED 223'),(32,'1','1','BED 225','Business Communication','2','2nd','3','Eng 122'),(33,'1','1','HRM 223','Food and Beverage Service Procedures','2','2nd','3','Nat Sci 111'),(34,'1','1','HRM 224','Banquet Function and Catering Services Procedures','2','2nd','3','HRM 223'),(35,'1','1','Lang 221','Foreign Language 1','2','2nd','3','None'),(36,'1','1','P.E. 224','Team Sports and Games','2','2nd','2','PE 213'),(37,'1','1','Tour 314','Total Quality Management','3','1st','3','Tour 213'),(38,'1','1','Tour 315','Tourism Planning and Development','3','1st','3','Tour 122'),(39,'1','1','Math 322','Basic Statistics','3','1st','3','Math 111'),(40,'1','1','HRM 315','Food and Beverage Control System','3','1st','3','HRM 223'),(41,'1','1','HRM 316','Rooms Division Management and Control System','3','1st','3','HRM 121/HRM 212'),(42,'1','1','HRM 317','Bakery Science and Cake Decor','3','1st','3','Tour 213'),(44,'1','1','Lang 322','Foreign Language 2','3','2nd','3','Lang 221'),(45,'1','1','BED 326','Basic Finance','3','2nd','3','BED 315'),(46,'1','1','BED 327','Management Information System','3','2nd','3','ICT 121'),(47,'1','1','HRM 328','Asian Cuisine','3','2nd','3','HRM 317'),(48,'1','1','RES 321','Methods of Research in Hospitality Industry','3','2nd','3','All Business Core Subjects'),(49,'1','1','HRM 419','International Cuisine','4','1st','3','HRM 328'),(50,'1','1','Tour 416','Entrepreneurship and Business Planning','4','1st','3','Res 321'),(51,'1','1','Tour 417','Events and Conventions Management','4','1st','4','Tour 417???'),(52,'1','1','HRM 420','On the Job Training - Hotel (300 hrs), Restaurant (200 hrs)','4','2nd','7','All Subjects'),(53,'2','2','GEEng 1','English & Thinking Skills','1','1st','3','None'),(54,'2','2','GEMath 1','College Algebra','1','1st','3','None'),(55,'2','2','GEHum 1','Introduction to Humanities & Arts','1','1st','3','None'),(56,'2','2','GESS 1','General Psychology (w/ Drug Education, HIV, SARS)','1','1st','3','None'),(57,'2','2','ICT 1','Computer Fundamentals','1','1st','3','None'),(58,'2','2','GEFil 1','Komunikasyon sa Akademikong Filipino','1','1st','3','None'),(59,'2','2','GENSCI 1','Biological Science','1','1st','3','None'),(60,'2','2','MS 1','Philippine History (w/ Geography & National Resources in the Philippines)','1','1st','3','None'),(61,'2','2','P.E. 1','Gymnastics','1','1st','2','None'),(62,'2','2','N.S.T.P. 1','National Service Training Program 1 w/ Environmental Science','1','1st','3','None'),(63,'2','2','GEEng 2','Reading & Writing in the Discipline','1','2nd','3','GEENg 1'),(64,'2','2','GEMath 2','Plane & Spherical Trigonometry','1','2nd','3','GEMath 1'),(65,'2','2','GEHum 2','Social Philosophy','1','2nd','3','None'),(66,'2','2','GESS 2','Society and Culture (w/ Family Planning, Peace Education, Anti Smoking)','1','2nd','3','None'),(67,'2','2','ICT 2','Computer Application','1','2nd','3','ICT 1'),(68,'2','2','GEFil 2','Pagbasa at Pagsulat Tungo sa Pananaliksik','1','2nd','3','GEFil 1'),(69,'2','2','GENSCI 2','Physical Science','1','2nd','3','GENSCI 1'),(70,'2','2','MS 2','Rizal Life Works & Writings','1','2nd','3','None'),(71,'2','2','GELit 1','Philippine Literature','1','2nd','3','None'),(72,'2','2','P.E. 2','Rhythmic Activities','1','2nd','2','PE 1'),(73,'2','2','N.S.T.P. 2','National Service Training Program 2 w/ Peace Education','1','2nd','3','NSTP 1'),(74,'2','2','GEEng 3','Speech & Oral Communication','2','1st','3','GEEng 2'),(75,'2','2','GESS 3','Basic Economics w/ Taxation & Land Reform','2','1st','3','None'),(76,'2','2','GEFil 3','Masining na Pagpapahayag','2','1st','3','GEFil 2'),(77,'2','2','ENGM 1','Structure of English 1','2','1st','3','None'),(78,'2','2','MSC1a','Principles of Teaching 1','2','1st','3','None'),(79,'2','2','TCC 1','Child & Adolescent Development','2','1st','3','None'),(80,'2','2','TCC 2','Facilitating Learning','2','1st','3','None'),(81,'2','2','TCC 3','Social Dimensions of Learning','2','1st','3','None'),(82,'2','2','FSC 1','The Learners Development & Environment','2','1st','1','None'),(83,'2','2','P.E. 3','Dual Sports','2','1st','2','PE 2'),(84,'2','2','GELit 2','World Literature','2','2nd','3','None'),(85,'2','2','GESS 4','Politics & Governance w/ Philippines Constitution','2','2nd','3','None'),(86,'2','2','GENSCI 3','Earth Science','2','2nd','3','None'),(87,'2','2','ENGM 2','The Teaching of Speaking','2','2nd','3','None'),(88,'2','2','ENGM 3','Teaching Literature','2','2nd','3','None'),(89,'2','2','MSC1b','Principles of Teaching II','2','2nd','3','MSC 1a'),(90,'2','2','MSC3a','Education Technology 1','2','2nd','3','None'),(91,'2','2','MSC4','Developmental Reading','2','2nd','3','None'),(92,'2','2','FSC 2','Experiencing the Teaching Learning Process','2','2nd','1','FSC 1'),(93,'2','2','STC 1','Problem-Based Teaching','2','2nd','1','None'),(94,'2','2','P.E. 4','Team Sports','2','2nd','2','PE 3'),(95,'2','2','ENGM 4','Teaching of Listening & Reading','3','1st','3','None'),(96,'2','2','ENGM 5','Afro-Asian Literature','3','1st','3','None'),(97,'2','2','ENGM 6','Teaching English as a Second Language','3','1st','3','None'),(98,'2','2','ENGM 7','Language & Literature Assessment','3','1st','3','None'),(99,'2','2','ENGM 8','Introduction to Linguistics','3','1st','3','None'),(100,'2','2','MSC3b','Education Technology II','3','1st','3','MSC 3a'),(101,'2','2','MSC2a','Assessment of Student Learning I','3','1st','3','None'),(102,'2','2','FSC 3','Technology in the Learning Environment','3','1st','1','FSC1/FSC 2'),(103,'2','2','STC 2','Teaching Multi-Grade Classes','3','1st','1','STC 1'),(104,'2','2','ENGM 9','Mythology & Folklore','3','2nd','3','None'),(105,'2','2','ENGM 10','Campus Journalism','3','2nd','3','None'),(106,'2','2','ENGM 11','Language Research','3','2nd','3','None'),(107,'2','2','ENGM 12','Creative Writing','3','2nd','3','None'),(108,'2','2','ENGM 13','English & American Literature','3','2nd','3','None'),(109,'2','2','ENGM 14','Language Curriculum for Secondary School','3','2nd','3','None'),(110,'2','2','FSC 4','Exploring the Curriculum','3','2nd','1','FSC 1/FSC 3'),(111,'2','2','MSC 5','Curriculum Development','3','2nd','3','None'),(112,'2','2','STC 3','Addressing Learning Gaps','3','2nd','1','STC 2'),(113,'2','2','ENGM 15','English for Special Purposes','4','1st','3','None'),(114,'2','2','ENGM 16','Speech & Stage Arts','4','1st','3','None'),(115,'2','2','ENGM 17','Introduction to Stylistics','4','1st','3','None'),(116,'2','2','ENGM 18','Remedial Instruction in English','4','1st','3','None'),(117,'2','2','ENGM 19','Literary Criticism','4','1st','3','None'),(118,'2','2','ENGM 20','Translation & Editing Text','4','1st','3','None'),(119,'2','2','MSC2b','Assessment of Student Learning II','4','1st','3','MSC 2a'),(120,'2','2','FSC 5','Learning Assessment & Strategies','4','1st','1','FSC 1/FSC 4'),(121,'2','2','FSC 6','On Becoming a Teacher','4','1st','1','FSC 1/FSC 5'),(122,'2','2','TCC 4','Teaching Profession','4','1st','3','MSC 1/MSC 1b'),(123,'2','2','EngSem','Seminar on English Proficiency','4','1st','0','None'),(124,'2','2','PTC','Practice Teaching','4','2nd','6','Prof. Subjects'),(125,'3','3','ET 111','Basic Electricity (Lec)','1','1st','3','None'),(126,'3','3','EL 111','Basic Electricity (Lab)','1','1st','3','None'),(127,'3','3','Math 111','College Algebra','1','1st','3','None'),(128,'3','3','Math 112','Plane & Spherical Trigonometry','1','1st','3','None'),(129,'3','3','Chem 111','General Chemistry','1','1st','4','None'),(130,'3','3','Draw 111','Basic Engineering Drawing','1','1st','1','None'),(131,'3','3','Fil 111','Komunikasyon sa Akademikong Filipino','1','1st','3','None'),(132,'3','3','Eng 111','Communication & Thinking Skills','1','1st','3','None'),(133,'3','3','P.E. 111','Physical Fitness and Gymnastics','1','1st','2','None'),(134,'3','3','N.S.T.P. 111','Civic Welfare Training Service','1','1st','3','None'),(135,'3','3','ET 121','Basic Electronics','1','2nd','3','ET 111'),(136,'3','3','EL 121','Electrical Technology 1','1','2nd','3','EL 111'),(137,'3','3','Math 121','Advanced College Algebra','1','2nd','2','Math 111'),(138,'3','3','Math 122','Analytic Geometry','1','2nd','2','Math 112'),(139,'3','3','Math 123','Solid Mensuration','1','2nd','2','Math 112'),(140,'3','3','Comp 121','Computer Fundamentals and Programming','1','2nd','2','None'),(141,'3','3','SS 121','General Sociology w/ Family Planning','1','2nd','3','None'),(142,'3','3','Fil 121','Pagbasa at Pagsulat Tungo sa Pananaliksik','1','2nd','3','Fil 111'),(143,'3','3','Eng 121','Technical Report Writing','1','2nd','3','Eng 111'),(144,'3','3','P.E. 121','Rhythmic Activities','1','2nd','2','PE 111'),(145,'3','3','N.S.T.P. 121','Civic Welfare Training Service','1','2nd','3','NSTP 111'),(146,'3','3','ECET 211','Electronics Device & CIrcuits w/ Application','2','1st','4','ET 121'),(147,'3','3','ECET 212','Digital Electronics & Techniques','2','1st','4','ECET 211'),(148,'3','3','ECET 213','Radio Laws and Regulations','2','1st','3','None'),(149,'3','3','Math 211','Differential Calculus','2','1st','4','Math 121/Math 122'),(150,'3','3','Phys 211','Mechanics and Fluids','2','1st','4','Math 111/Math112'),(151,'3','3','Eng 211','Technical Communication','2','1st','3','Eng 121'),(152,'3','3','SS 211','Economics w/ Land Reform & Taxation','2','1st','3','None'),(153,'3','3','SS 212','General Psychology w/ Intro to Ind. Psychology','2','1st','3','None'),(154,'3','3','P.E. 211','Individual & Dual Sports','2','1st','2','PE 121'),(155,'3','3','ECET 221','Telecommunications','2','2nd','3','ECET 211'),(156,'3','3','ECET 221L','Wired and Wireless Communication','2','2nd','2','ECET 221'),(157,'3','3','ECET 222','Transmission Lines & Antenna','2','2nd','3','ECET 211'),(158,'3','3','CAD 221','Computer Aided Drafting','2','2nd','1','Draw 1111'),(159,'3','3','Math 221','Integral Calculus','2','2nd','4','Math 211'),(160,'3','3','Phys 211','Thermodynamics and Electromagnetism','2','2nd','4','Phys 211'),(161,'3','3','SS 221','Philippine History, Government & Constitution','2','2nd','3','None'),(162,'3','3','Math 222','Probability and Statistics','2','2nd','3','Math 111'),(163,'3','3','P.E. 221','Team Sports','2','2nd','2','PE 211'),(164,'3','3','IOP','Industrial Orientation Program','2','2nd','0','None'),(165,'3','3','SIT 1','Supervised Industrial Training 1','2','2nd','4','2nd Year Status'),(166,'3','3','ECET 311','Microprocessor','3','1st','2','ECET 212'),(167,'3','3','ECET 311L','Microprocessor Interfacing Techniques','3','1st','1','Comp 221/ECET 311'),(168,'3','3','ECET 312','Broadcast Engineering & Acoustics','3','1st','2','ECET 211'),(169,'3','3','ECET 313','Microwave System','3','1st','3','ECET 222'),(170,'3','3','ECET 314','Data Communication','3','1st','2','ECET 222/ECET 212'),(171,'3','3','RPD 1','Research and Thesis Writing','3','1st','3','ECET 311/ECET 211'),(172,'3','3','RPD 2','Project Development (Consumer Electronics)','3','1st','2','RPD 1'),(173,'3','3','Comp 311','AutoCAD 2','3','1st','2','Comp 221'),(174,'3','3','Math 311','Mathematics of Investment','3','1st','3','Math 111'),(175,'3','3','Rizal 311','Rizals Life, Works and Writing','3','1st','3','None'),(176,'3','3','SIT 2','Supervised Industrial Training 2','3','2nd','8','3rd Year Status'),(177,'4','4','ET 111','Basic Electricity (Lec)','1','1st','3','None'),(178,'4','4','EL 111','Basic Electricity (Lab)','1','1st','3','None'),(179,'4','4','Math 111','College Algebra','1','1st','3','None'),(180,'4','4','Math 112','Plane and Spherical Trigonometry','1','1st','3','None'),(181,'4','4','Chem 111','General Chemistry','1','1st','4','None'),(182,'4','4','Draw 111','Basic Engineering Drawing','1','1st','1','None'),(183,'4','4','Fil 111','Komunikasyon sa Akademikong Filipino','1','1st','3','None'),(184,'4','4','Eng 111','Communication & Thinking Skills','1','1st','3','None'),(185,'4','4','P.E. 111','Physical Fitness and Gymnastics','1','1st','2','None'),(186,'4','4','N.S.T.P. 111','Civic Welfare Training Service','1','1st','3','None'),(187,'4','4','ET 121','Basic Electronics','1','2nd','3','ET 111'),(188,'4','4','EL 121','Electrical Technology 1','1','2nd','3','EL 111'),(189,'4','4','Math 121','Advanced College Algebra','1','2nd','2','Math 1111'),(190,'4','4','Math 122','Analytic Geometry','1','2nd','2','Math 112'),(191,'4','4','Math 123','Solid Mensuration','1','2nd','2','Math 112'),(192,'4','4','Comp 121','Computer Fundamentals and Programming','1','2nd','2','None'),(193,'4','4','SS 121','General Sociology w/ Family Planning','1','2nd','3','None'),(194,'4','4','Fil 121','Pagbasa at Pagsulat Tungo sa Pananaliksik','1','2nd','3','Fil 111'),(195,'4','4','Eng 121','Technical Report Writing','1','2nd','3','Eng 111'),(196,'4','4','P.E. 121','Rhythmic Activities','1','2nd','2','PE 111'),(197,'4','4','N.S.T.P. 121','Civic Welfare Training Service','1','2nd','3','NSTP 111'),(198,'4','4','EET 211','Electrical System Technology 1','2','1st','3','ET 121'),(199,'4','4','EET 211L','DC Electrical Machines Technology','2','1st','3','ET 121'),(200,'4','4','PEC 211','PEC and Building Code','2','1st','3','None'),(201,'4','4','Math 211','Differential Calculus','2','1st','4','Math 121/Math 122'),(202,'4','4','Phys 211','Mechanics and Fluids','2','1st','4','Math 111/Math 112'),(203,'4','4','Eng 211','Technical Communication','2','1st','3','Eng 121'),(204,'4','4','SS 211','Economics w/ Land Reform & Taxation','2','1st','3','None'),(205,'4','4','SS 212','General Psychology w/ Intro to Ind. Psychology','2','1st','3','None'),(206,'4','4','P.E. 211','Individual & Dual Sports','2','1st','2','PE 121'),(207,'4','4','EET 221','Electrical System Technology II','2','2nd','3','EET 211'),(208,'4','4','EET 221L','AC Electrical Machines Technology','2','2nd','3','EET 211L'),(209,'4','4','CAD 221','Computer Aided Drafting','2','2nd','1','Draw 111'),(210,'4','4','Math 221','Integral Calculus','2','2nd','4','Math 211'),(211,'4','4','Phys 211','Thermodynamics and Electromagnetism','2','2nd','4','Phys 211'),(212,'4','4','Elec 221','Digital Electronics','2','2nd','3','ET 121'),(213,'4','4','SS 221','Philippine History, Government & Constitution','2','2nd','3','None'),(214,'4','4','Math 222','Probability and Statistics','2','2nd','3','None'),(215,'4','4','P.E. 221','Team Sports','2','2nd','2','PE 211'),(216,'4','4','IOP','Industrial Orientation Program','2','2nd','0','None'),(217,'4','4','SIT 1','Supervised Industrial Training 1','2','2nd','4','2nd Year Status'),(218,'4','4','EET 311','Advanced Electrical System Technology (Lec)','3','1st','3','EET 221'),(219,'4','4','EET 311L','Advanced Electrical System Technology (Lab)','3','1st','2','EET 311'),(220,'4','4','EET 312','Electrical Power System and Devices','3','1st','2','EET 211'),(221,'4','4','EET 313','Industrial Power Electronics (Lec)','3','1st','2','EET 211'),(222,'4','4','EET 313L','Industrial Power Electronics (Lab)','3','1st','1','ELEC 221'),(223,'4','4','RPD 1','Research and Thesis Writing','3','1st','3','EET 311/EET 313'),(224,'4','4','RPD 2','Project Development (Electrical Installation Maintenance)','3','1st','2','RPD 1'),(225,'4','4','Comp 311','AutoCAD 2','3','1st','2','CAD 121'),(226,'4','4','Math 311','Mathematics of Investment','3','1st','3','Math 111'),(227,'4','4','Rizal 311','Rizals Life, Works and Writing','3','1st','3','None'),(228,'4','4','SIT 2','Supervised Industrial Training 2','3','2nd','8','3rd Year Status'),(229,'5','5','CET 111','Building Materials & Construction Methods','1','1st','3','None'),(230,'5','5','ISD 111','Arc Welding','1','1st','2','None'),(231,'5','5','Math 111','College Algebra','1','1st','3','None'),(232,'5','5','Math 112','Plane and Spherical Trigonometry','1','1st','3','None'),(233,'5','5','Chem 111','General Chemistry','1','1st','4','None'),(234,'5','5','CET 112','Architectural Drawing','1','1st','1','None'),(235,'5','5','Fil 111','Komunikasyon sa Akademikong Filipino','1','1st','3','None'),(236,'5','5','Eng 111','Communication & Thinking Skills','1','1st','3','None'),(237,'5','5','P.E. 111','Physical Fitness and Gymnastics','1','1st','2','None'),(238,'5','5','N.S.T.P. 111','Civic Welfare Training Service 1','1','1st','3','None'),(239,'5','5','CET 121','Soil Mechanics','1','2nd','3','CET 111'),(240,'5','5','Math 121','Advance College Algebra','1','2nd','2','Math 111'),(241,'5','5','Math 122','Analytic Geometry','1','2nd','2','Math 112'),(242,'5','5','Math 123','Solid Mensuration','1','2nd','2','Math 112'),(243,'5','5','CAD 121','Computer Aided Drafting','1','2nd','1','CET 112'),(244,'5','5','SS 121','General Sociology w/ Family Planning','1','2nd','3','None'),(245,'5','5','Fil 121','Pagbasa at Pagsulat Tungo sa Pananaliksik','1','2nd','3','Fil 111'),(246,'5','5','Eng 121','Technical Report Writing','1','2nd','3','Eng 111'),(247,'5','5','P.E. 121','Rhythmic Activities','1','2nd','2','PE 111'),(248,'5','5','N.S.T.P. 121','Civic Welfare Training Service 2','1','2nd','3','NSTP 111'),(249,'5','5','CET 211','Surveying 1','2','1st','3','Math 111'),(250,'5','5','CET 212','Structural Theory 1','2','1st','3','Math 111/Math 112'),(251,'5','5','CET 213','Concerete & Asphalt Testing','2','1st','3','Math 111'),(252,'5','5','Math 211','Differential Calculus','2','1st','4','Math 121/Math 122'),(253,'5','5','Phys 211','Mechanics and Fluids','2','1st','4','Math 121/Math 122'),(254,'5','5','Eng 211','Technical Communication','2','1st','3','Eng 121'),(255,'5','5','SS 211','Economics w/ Land Reform & Taxation','2','1st','3','None'),(256,'5','5','SS 212','General Psychology w/ Intro to Ind. Psychology','2','1st','3','None'),(257,'5','5','P.E. 211','Individual & Dual Sports','2','1st','2','PE 211'),(258,'5','5','CET 221','Land Planning','2','2nd','3','CET 112'),(259,'5','5','CET 222','Estimating','2','2nd','3','None'),(260,'5','5','CET 223','Structural Theory 2','2','2nd','3','CET 212'),(261,'5','5','CET 224','Site and Building Service System','2','2nd','3','None'),(262,'5','5','Math 221','Integral Calculus','2','2nd','4','Math 211'),(263,'5','5','Phys 221','Static & Strengths of Materials','2','2nd','4','Phys 211'),(264,'5','5','SS 221','Philippine History, Government & Constitution','2','2nd','3','None'),(265,'5','5','ISD 221','Woodworking Principles & Techniques','2','2nd','2','CET 112'),(266,'5','5','P.E. 221','Team Sports','2','2nd','2','PE 211'),(267,'5','5','IOP','Industrial Orientation Program','2','2nd','0','None'),(268,'5','5','SIT 1','Supervised Industrial Training 1','2','2nd','4','2nd Year Status'),(269,'5','5','CET 311','Surveying 2','3','1st','3','CET 211'),(270,'5','5','CET 312','Ethics','3','1st','3','None'),(271,'5','5','CET 313','Highways and Maps','3','1st','2','Math 111'),(272,'5','5','ISD 311','Masonry Principles & Techniques','3','1st','3','ISD 221'),(273,'5','5','ISD 312','Wiring Methods for Buildings','3','1st','2','None'),(274,'5','5','Comp 311','AutoCAD 2','3','1st','2','CAD 121'),(275,'5','5','RPD 1','Research and Thesis Writing','3','1st','3','CET 311/ISD 311'),(276,'5','5','RPD 2','Project Development (Carpentry)','3','1st','2','RPD 1'),(277,'5','5','Rizal 311','Rizals Life, Works and Writing','3','1st','3','None'),(278,'5','5','SIT 2','Supervised Industrial Training 2','3','2nd','8','3rd Year Status'),(279,'6','6','ET 111','Basic Electricity (Lec)','1','1st','3','None'),(280,'6','6','EL 111','Basic Electricity (Lab)','1','1st','3','None'),(281,'6','6','Math 111','College Algebra','1','1st','3','None'),(282,'6','6','Math 112','Plane and Spherical Trigonometry','1','1st','3','None'),(283,'6','6','Chem 111','General Chemistry','1','1st','4','None'),(284,'6','6','Draw 111','Basic Engineering Drawing','1','1st','1','None'),(285,'6','6','Fil 111','Komunikasyon sa Akademikong Filipino','1','1st','3','None'),(286,'6','6','Eng 111','Communication & Thinking Skills','1','1st','3','None'),(287,'6','6','Comp 111','Computer Fundamentals','1','1st','1','None'),(288,'6','6','P.E. 111','Physical Fitness and Gymnastics','1','1st','2','None'),(289,'6','6','N.S.T.P. 111','Civic Welfare Training Service','1','1st','3','None'),(290,'6','6','ET 121','Basic Electronics','1','2nd','3','ET 111'),(291,'6','6','EL 121','Electrical Technology 1','1','2nd','3','EL 111'),(292,'6','6','Math 121','Advanced College Algebra','1','2nd','2','Math 111'),(293,'6','6','Math 122','Analytic Geometry','1','2nd','2','Math 112'),(294,'6','6','Math 123','Solid Mensuration','1','2nd','2','Math 112'),(295,'6','6','CAD 121','Computer Aided Drafting','1','2nd','1','Draw 111'),(296,'6','6','SS 121','General Sociology w/ Family Planning','1','2nd','3','None'),(297,'6','6','Fil 121','Pagbasa at Pagsulat Tungo sa Pananaliksik','1','2nd','3','Fil 111'),(298,'6','6','Eng 121','Technical Report Writing','1','2nd','3','Eng 111'),(299,'6','6','Comp 121','Computer Programming 1','1','2nd','1','Comp 111'),(300,'6','6','P.E. 121','Rhythmic Activities','1','2nd','2','PE 111'),(301,'6','6','N.S.T.P. 121','Civic Welfare Training Service','1','2nd','3','NSTP 111'),(302,'6','6','COET 211','Electronics Devices & Circuits w/ Application','2','1st','4','ET 121'),(303,'6','6','COET 212','Digital Electronics & Techniques','2','1st','2','EL 121'),(304,'6','6','Comp 211','Computer Programming 2','2','1st','3','Comp 121'),(305,'6','6','Math 211','Differential Calculus','2','1st','4','Math 121/Math 122'),(306,'6','6','Phys 211','Mechanics and Fluids','2','1st','4','Math 121/Math 122'),(307,'6','6','Eng 211','Technical Communication','2','1st','3','Eng 121'),(308,'6','6','SS 211','Economics w/ Land Reform & Taxation','2','1st','3','None'),(309,'6','6','SS 212','General Psychology w/ Intro to Ind. Psychology','2','1st','3','None'),(310,'6','6','P.E. 211','Individual & Dual Sports','2','1st','2','PE 121'),(311,'6','6','COET 221','Computer System Organization w/ Assembly Language','2','2nd','4','Comp 211'),(312,'6','6','COET 222','Data Base Management','2','2nd','3','Comp 211'),(313,'6','6','COET 223','Data Structure','2','2nd','3','Comp 211'),(314,'6','6','Math 221','Integral Calculus','2','2nd','4','Math 211'),(315,'6','6','Phys 221','Thermodynamics and Electromagnetism','2','2nd','4','Phys 211'),(316,'6','6','SS 221','Philippine History, Government & Constitution','2','2nd','3','None'),(317,'6','6','Math 222','Probability and Statistics','2','2nd','3','Math 111'),(318,'6','6','P.E. 221','Team Sports','2','2nd','2','PE 211'),(319,'6','6','IOP','Industrial Orientation Program','2','2nd','0','None'),(320,'6','6','SIT 1','Supervised Industrial Training 1','2','2nd','4','2nd Year Status'),(321,'6','6','COET 311','Object Oriented Programming','3','1st','4','COET 221'),(322,'6','6','COET 312','Software Engineering','3','1st','4','COET 221'),(323,'6','6','COET 313','Operating System','3','1st','3','COET 223'),(324,'6','6','COET 314','System Analysis and Deisgn','3','1st','3','COET 221'),(325,'6','6','MIT 311','Microprocessor & Interfacing Techniques','3','1st','5','COET 211/COET 212'),(326,'6','6','Comp 311','AutoCAD 2','3','1st','2','CAD 121'),(327,'6','6','RPD 1','Research and Thesis Writing','3','1st','3','COET 311/COET 312'),(328,'6','6','RPD 2','Project Development (Computer Hardware Servicing)','3','1st','2','RPD 1'),(329,'6','6','Rizal 311','Rizals Life, Works and Writing','3','1st','3','None'),(330,'6','6','SIT 2','Supervised Industrial Training 2','3','2nd','8','3rd Year Status'),(331,'2','7','Eng 1','Study and Thinking Skills in English','1','1st','3','None'),(332,'2','7','Fil 1','Komunikasyon sa Akademikong Filipino','1','1st','3','None'),(333,'2','7','Math 1','Basic Mathematics','1','1st','3','None'),(334,'2','7','Soc Sci 1','Society & Culture (w/ Family Planning)','1','1st','3','None'),(335,'2','7','Psych 1','General Psychology (w/ Drug Prevention, HIV & SARS)','1','1st','3','None'),(336,'2','7','Hist 1','Philippine History (w/ Environmental Education)','1','1st','3','None'),(337,'2','7','ICT 1','Computer Fundamentals and Concepts','1','1st','3','None'),(338,'2','7','NS 1','Earth Science','1','1st','3','None'),(339,'2','7','P.E. 1','Physical Fitness and Gymnastics','1','1st','2','None'),(340,'2','7','N.S.T.P. 1','National Service Training Program 1','1','1st','3','None'),(341,'2','7','Eng 2','Writing in the Discipline','1','2nd','3','Eng 1'),(342,'2','7','Fil 2','Pagbasa at Pagsulat Tungo sa Pananaliksik','1','2nd','3','Fil 1'),(343,'2','7','Math 2','College Algebra','1','2nd','3','Math 1'),(344,'2','7','NS 2','Biological Science','1','2nd','3','NS 1'),(345,'2','7','ICT 2','Computer Applications','1','2nd','3','ICT 1'),(346,'2','7','Philo 1','Introduction to Philosophy and Logic','1','2nd','3','None'),(347,'2','7','Psych 2','Child & Adolescent Development','1','2nd','3','Psych 1'),(348,'2','7','FS 1','Learners Development and Environment','1','2nd','1','None'),(349,'2','7','P.E. 2','Fundamentals of Rhythmic Activities','1','2nd','2','PE 1'),(350,'2','7','N.S.T.P. 2','National Service Training Program 2','1','2nd','3','NSTP 1'),(351,'2','7','Eng 3','Speech & Oral Communication','2','1st','3','Eng 2'),(352,'2','7','Rizal','Rizals Life, Works and Writing','2','1st','3','None'),(353,'2','7','Lit 1','Philippine Literature','2','1st','3','None'),(354,'2','7','Fil 3','Masining na Pagpapahayag','2','1st','3','Fil 2'),(355,'2','7','NS 3','Ecology','2','1st','3','None'),(356,'2','7','Pol Sci 1','Politics, Governance & Philippine Constitution (w/ Peace Education)','2','1st','3','None'),(357,'2','7','Educ 1','Principles of Teaching 1','2','1st','3','Psych 2, FS 1'),(358,'2','7','FS 2','Experiencing the Teaching-Learning Process','2','1st','1','FS 1'),(359,'2','7','English 101','Campus Journalism','2','1st','3','None'),(360,'2','7','P.E. 3','Individual and Dual Sports and Games','2','1st','2','PE 2'),(361,'2','7','Lit 2','World Literature','2','2nd','3','Lit 1'),(362,'2','7','Educ 2','Principles of Teaching 2','2','2nd','3','Educ 1,FS 2'),(363,'2','7','Educ 3','Facilitating Learning 1','2','2nd','3','Educ 1'),(364,'2','7','Educ 4','Assessment of Student Learning 1','2','2nd','3','Educ 1'),(365,'2','7','EdTech 1','Education Technology 1','2','2nd','3','Educ 1'),(366,'2','7','FS 3','Technology in the Learning Environment','2','2nd','1','FS 2'),(367,'2','7','ST 1','Cooperative Learning Techniques','2','2nd','1','Educ 1'),(368,'2','7','English 102','Structure of English','2','2nd','3','None'),(369,'2','7','English 103','Afro-Asian Literature','2','2nd','3','Lit 1'),(370,'2','7','English 104','Introduction to Linguistics','2','2nd','3','None'),(371,'2','7','P.E. 4','Team Sports','2','2nd','2','PE 3'),(372,'2','7','Hum 1','Introduction to Humanities','3','1st','3','None'),(373,'2','7','Educ 5','Developmental Reading','3','1st','3','Eng 1'),(374,'2','7','Educ 6','Curriculum Development','3','1st','3','None'),(375,'2','7','FS 4','Understanding Curriculum Development','3','1st','1','FS 3'),(376,'2','7','EdTech 2','Education Technology 2','3','1st','3','Ed Tech 1'),(377,'2','7','ST 2','Issues Affecting Education','3','1st','1','None'),(378,'2','7','English 105','Language Curricuclum for Secondary Schools','3','1st','3','None'),(379,'2','7','English 106','The Teaching of Speaking','3','1st','3','None'),(380,'2','7','English 107','Speech and Stage Arts','3','1st','3','None'),(381,'2','7','English 108','English and American Literature','3','1st','3','None'),(382,'2','7','English 109','Preparation and Evaluation of Intructional Materials','3','1st','3','None'),(383,'2','7','Eco 1','Basic Economics with Taxation and Land Reform','3','2nd','3','None'),(384,'2','7','Res 1','Educational Research 1-A','3','2nd','3','Eng 2'),(385,'2','7','Educ 7','Social Dimensions of Education','3','2nd','3','Soc Sci 1'),(386,'2','7','Educ 8','Assessment of Student Learning 2','3','2nd','3','Educ 4'),(387,'2','7','FS 5','Learning Assessment Strategies','3','2nd','1','FS 4'),(388,'2','7','ST 3','Addressing Learning Gaps','3','2nd','1','None'),(389,'2','7','English 110','The Teaching of Speaking and Listening','3','2nd','3','None'),(390,'2','7','English 111','Creative Writing','3','2nd','3','None'),(391,'2','7','English 112','Mythology and Folklore','3','2nd','3','None'),(392,'2','7','English 113','Remedial Instruction in English','3','2nd','3','None'),(393,'2','7','English 114','English for Specific Purposes','3','2nd','3','None'),(394,'2','7','Res 2','Educational Research 1-B','4','1st','3','Res 1'),(395,'2','7','Educ 9','The Teaching Profession','4','1st','3','None'),(396,'2','7','FS 6','On Becoming a Teacher','4','1st','1','FS 5'),(397,'2','7','English 115','Language and Literature Assessment','4','1st','3','Educ 4, Educ 8'),(398,'2','7','English 116','Translating and Editing Text','4','1st','3','None'),(399,'2','7','English 117','Introduction to Stylistics','4','1st','3','None'),(400,'2','7','English 118','The Teaching of Literature','4','1st','3','None'),(401,'2','7','English 119','Teaching English as a Second Language','4','1st','3','None'),(402,'2','7','English 120','Literary Criticism','4','1st','3','None'),(403,'2','7','Educ 11','Practice Teaching','4','2nd','6',''),(404,'7','8','Eng 1','Study and Thinking Skills in English','1','1st','3','None'),(405,'7','8','Fil 1','Komunikasyon sa Akademikong Filipino','1','1st','3','None'),(406,'7','8','Math 1','Basic Mathematics','1','1st','3','None'),(407,'7','8','Soc Sci 1','Society and Culture (w/ Family Planning)','1','1st','3','None'),(408,'7','8','Psych 1','General Psychology (w/ Drug Prevention, HIV & SARS)','1','1st','3','None'),(409,'7','8','Hist 1','Philippine History (w/ Environmental Education)','1','1st','3','None'),(410,'7','8','ICT 1','Computer Fundamentals','1','1st','3','None'),(411,'7','8','NS 1','Earth Science','1','1st','3','None'),(412,'7','8','PE 1','Physical Fitness and Gymnastics','1','1st','2','None'),(413,'7','8','NSTP 1','National Service Training Program','1','1st','3','None'),(414,'7','8','Eng 2','Writing in the Discipline','1','2nd','3','Eng 1'),(415,'7','8','Fil 2','Pagbasa at Pagsulat Tungo sa Pananaliksik','1','2nd','3','Fil 1'),(416,'7','8','Math 2','College Algebra','1','2nd','3','Math 1'),(417,'7','8','NS 2','Biological Science','1','2nd','3','NS 1'),(418,'7','8','ICT 2','Computer Applications','1','2nd','3','ICT 1'),(419,'7','8','Philo 1','Introduction to Philosophy and Logic','1','2nd','3','None'),(420,'7','8','Psych 2','Child and Adolescent Development','1','2nd','3','Psych 1'),(421,'7','8','FS 1','Learners Development and Environment','1','2nd','1','None'),(422,'7','8','PE 2','Fundamentals of Rhythmic Activities','1','2nd','2','PE 1'),(423,'7','8','NSTP 2','National Service Training Program 2','1','2nd','3','NSTP 1'),(424,'7','8','Eng 3','Speech & Oral Communication','2','1st','3','Eng 1'),(425,'7','8','Rizal','Rizals Life, Works, and Writing','2','1st','3','None'),(426,'7','8','Lit 1','Philippine Literature','2','1st','3','Eng 1'),(427,'7','8','Fil 3','Masining na Pagpapahayag','2','1st','3','Fil 2'),(428,'7','8','NS 3','Ecology','2','1st','3','None'),(429,'7','8','Pol. Sci. 1','Politics, Governance & Philippine Constitution (w/ Peace Education)','2','1st','3','None'),(430,'7','8','Educ 1','Principles of Teaching 1','2','1st','3','Psych 2, FS 2'),(431,'7','8','FS 2','Experiencing the Teaching Learning Process','2','1st','1','FS 1'),(432,'7','8','Math 101','Advanced Algebra','2','1st','3','None'),(433,'7','8','Math 102','Plane Geometry','2','1st','3','Math 2'),(434,'7','8','PE 3','Individual and Dual Sports and Games','2','1st','2','PE 2'),(435,'7','8','Lit 2','World Literature','2','2nd','3','Lit 2'),(436,'7','8','Educ 2','Principles of Teaching 2','2','2nd','3','Educ 1, FS 2'),(437,'7','8','Educ 3','Facilitating Learning 1','2','2nd','3','Educ 1'),(438,'7','8','Educ 4','Developmental Reading 1','2','2nd','3','Eng 1'),(439,'7','8','EdTech 1','Educational Technology 1','2','2nd','3','Educ 1'),(440,'7','8','FS 3','Technology in the Learning Environment','2','2nd','1','FS 2'),(441,'7','8','ST 1','Cooperative Learning Techniques','2','2nd','1','Educ 1'),(442,'7','8','Math 103','Trigonometry','2','2nd','3','None'),(443,'7','8','Math 104','Statistical Analysis 1','2','2nd','3','None'),(444,'7','8','Math 105','Mathematical Analysis 1','2','2nd','5','None'),(445,'7','8','PE 4','Team Sports and Games','2','2nd','2','PE 3'),(446,'7','8','Hum 1','Introduction to Humanities and Arts','3','1st','3','None'),(447,'7','8','Educ 5','Assessment of Student Learning','3','1st','3','Educ 2'),(448,'7','8','Educ 6','Curriculum Development','3','1st','3','None'),(449,'7','8','FS 4','Understanding Curriculum Development','3','1st','1','FS 3'),(450,'7','8','EdTech 2','Educational Technology 2','3','1st','3','Ed Tech 1'),(451,'7','8','ST 2','Issues Affecting Education','3','1st','1','None'),(452,'7','8','Math 106','Solid Geometry','3','1st','3','None'),(453,'7','8','Math 107','Statistical Analysis 2','3','1st','3','None'),(454,'7','8','Math 108','Mathematical Analysis 2','3','1st','5','None'),(455,'7','8','Eco 1','Basic Economics with Taxation and Land Reform','3','2nd','3','None'),(456,'7','8','Res 1','Educational Research 1-A','3','2nd','3','Eng 2'),(457,'7','8','Educ 7','Social Dimension of Education','3','2nd','3','Soc Sci 1'),(458,'7','8','Educ 8','Assessment of Student Learning 2','3','2nd','3','Educ 4'),(459,'7','8','FS 5','Learning Assessment Strategies','3','2nd','1','FS 4'),(460,'7','8','ST 3','Addressing Learning Gaps','3','2nd','1','None'),(461,'7','8','Math 109','Number Theory','3','2nd','3','None'),(462,'7','8','Math 110','Seminar on Technology in Mathematics','3','2nd','3','None'),(463,'7','8','Math 111','Abstract Algebra','3','2nd','3','None'),(464,'7','8','Math 112','Mathematical Analysis 3','3','2nd','5','None'),(465,'7','8','Res 2','Educational Research 1-B','4','1st','3','Res 1'),(466,'7','8','Educ 9','The Teaching Profession','4','1st','3','None'),(467,'7','8','FS 6','On Becoming a Teacher','4','1st','1','FS 5'),(468,'7','8','Math 113','Set Theory and Logic','4','1st','3','None'),(469,'7','8','Math 114','Trends and Issues in Science and Math Education','4','1st','3','None'),(470,'7','8','Math 115','Linear Algebra','4','1st','3','None'),(471,'7','8','Math 116','Mathematical Investigation and Modeling','4','1st','3','None'),(472,'7','8','Math 117','Differential Equation','4','1st','3','None'),(473,'7','8','Math 118','Seminar in Problem Solving Mathematics','4','1st','3','None'),(474,'7','8','Educ 10','Practice Teaching','4','2nd','6',''),(475,'1','9','Hum 1','Introduction to Humanities and Arts','1','2nd','3','None'),(476,'1','9','Eng 2','Communication Arts 2','1','2nd','3','Eng 1'),(477,'1','9','Fil 2','Pagbasa at Pagsulat sa Ibat-ibang Disiplina','1','2nd','3','Fil 1'),(478,'1','9','PDPR 1','Personality Development and Public Relations','1','2nd','3','None'),(479,'1','9','SS 1','Cultural Anthropology with Indigenous People','1','2nd','3','None'),(481,'1','9','Comp 1','Computer Fundamentals and Concepts','1','2nd','3','None'),(485,'1','9','Tour 2','Principles of Tourism 2','1','2nd','3','Tour 1'),(486,'1','9','P.E. 2','Rhythmic Activities','1','2nd','2','PE 1'),(487,'1','9','N.S.T.P. 2','National Service Training Program 2','1','2nd','3','NSTP 1'),(498,'1','9','Eng 1','Communication Arts','1','1st','3','None'),(499,'1','9','Math 1','Business Math','1','1st','3','None'),(500,'1','9','Fil 1','Komunikasyon sa Akademikong Filipino','1','1st','3','None'),(501,'1','9','Lit 1','Literature','1','1st','3','None'),(502,'1','9','NS 1','Environmental Science','1','1st','3','None'),(503,'1','9','NS 2','Principles of Safety, Hygiene and Sanitation','1','1st','3','None'),(504,'1','9','Tour 1','Principles of Tourism 1','1','1st','3','None'),(505,'1','9','P.E. 1','Physical Fitness and Gymnastics','1','1st','2','None'),(506,'1','9','N.S.T.P. 1','National Service Training Program 1','1','1st','3','None'),(507,'1','9','Rizal','Life and Works of Rizal','2','1st','3','None'),(508,'1','9','Psych 1','Gen. Psychology w/ HIV, Pop. Education, SARS, Drug Educ. Gender & Development.','2','1st','3','None'),(509,'1','9','Pol Sci 1','Philippine History Government and Constitution','2','1st','3','None'),(510,'1','9','BED 1','Principles of Management','2','1st','3','None'),(511,'1','9','BED 2','Human Behavior in Organization','2','1st','3','None'),(512,'1','9','HRM 1','Front Office Procedure','2','1st','3','Comp 1'),(513,'1','9','Tour 203','Culinary Arts and Sciences','2','1st','3','None'),(514,'1','9','P.E. 3','Individual Sports and Games','2','1st','2','PE 2'),(515,'1','9','Hum 2','Logic','2','2nd','3','None'),(516,'1','9','Eco 1','Basic Economics, Taxation and Agrarian Reform','2','2nd','3','None'),(517,'1','9','BED 3','Principles of Marketing','2','2nd','3','BED 2'),(518,'1','9','BED 4','Basic Accounting','2','2nd','3','BED 3'),(519,'1','9','HRM 2','Housekeeping Procedures','2','2nd','3','NS 1'),(520,'1','9','HRM 3','Food and Beverage Service Procedures','2','2nd','3','NS 1'),(521,'1','9','HRM 4','Banquet Function and Catering Services','2','2nd','3','HRM 3'),(522,'1','9','P.E. 4','Team Sports and Games','2','2nd','2','PE 3'),(523,'1','9','Tour 4','Total Quality Management','3','1st','3','None');

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
  `Term` varchar(5) DEFAULT NULL,
  `SYear` varchar(50) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

/*Data for the table `tblass` */

insert  into `tblass`(`SNum`,`LName`,`FName`,`SCode`,`N1`,`N2`,`N3`,`N4`,`N5`,`N6`,`N7`,`N8`,`N9`,`N10`,`N11`,`N12`,`Total`,`Rat`,`Grade`,`Term`,`SYear`) values (140341,'Mistica','Reinald Reinder','Draw 111',0,0,0,0,0,0,0,0,0,0,0,0,0,'0.00',0.00,'P','2016-2017'),(140341,'Mistica','Reinald Reinder','Draw 111',0,0,0,0,0,0,0,0,0,0,0,0,0,'0.00',0.00,'M','2016-2017'),(140341,'Mistica','Reinald Reinder','Draw 111',0,0,0,0,0,0,0,0,0,0,0,0,0,'0.00',0.00,'F','2016-2017');

/*Table structure for table `tblclass` */

DROP TABLE IF EXISTS `tblclass`;

CREATE TABLE `tblclass` (
  `SCode` varchar(15) DEFAULT NULL,
  `Course` varchar(15) DEFAULT NULL,
  `Section` varchar(15) DEFAULT NULL,
  `Day` varchar(15) DEFAULT NULL,
  `Status` varchar(15) DEFAULT NULL,
  `SYear` varchar(25) DEFAULT NULL,
  `STime` varchar(30) DEFAULT NULL,
  `ETime` varchar(30) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

/*Data for the table `tblclass` */

insert  into `tblclass`(`SCode`,`Course`,`Section`,`Day`,`Status`,`SYear`,`STime`,`ETime`) values ('Draw 111','COET','3A','TTH',NULL,'2016-2017','11:06:25 AM','11:06:25 AM');

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

insert  into `tblcmp`(`StudNum`,`LName`,`FName`,`SubCode`,`CourseName`,`SecName`) values (140341,'Mistica','Reinald Reinder','Draw 111','COET','3A');

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
  `Term` varchar(5) DEFAULT NULL,
  `SYear` varchar(50) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

/*Data for the table `tblexam` */

insert  into `tblexam`(`SNum`,`LName`,`FName`,`SCode`,`N1`,`Rat`,`Grade`,`Term`,`SYear`) values (140341,'Mistica','Reinald Reinder','Draw 111',45,'95.00',47.50,'P','2016-2017'),(140341,'Mistica','Reinald Reinder','Draw 111',32,'82.00',41.00,'M','2016-2017'),(140341,'Mistica','Reinald Reinder','Draw 111',25,'75.00',37.50,'F','2016-2017');

/*Table structure for table `tblgradesheet` */

DROP TABLE IF EXISTS `tblgradesheet`;

CREATE TABLE `tblgradesheet` (
  `SNum` int(10) DEFAULT NULL,
  `LName` varchar(25) DEFAULT NULL,
  `FName` varchar(25) DEFAULT NULL,
  `SCode` varchar(15) DEFAULT NULL,
  `AssT` double DEFAULT NULL,
  `AssR` double(5,2) DEFAULT NULL,
  `AssG` double(5,2) DEFAULT NULL,
  `ExT` double DEFAULT NULL,
  `ExR` double(5,2) DEFAULT NULL,
  `ExG` double(5,2) DEFAULT NULL,
  `OthT` double DEFAULT NULL,
  `OthR` double(5,2) DEFAULT NULL,
  `OthG` double(5,2) DEFAULT NULL,
  `ProT` double DEFAULT NULL,
  `ProR` double(5,2) DEFAULT NULL,
  `ProG` double(5,2) DEFAULT NULL,
  `QuiT` double DEFAULT NULL,
  `QuiR` double(5,2) DEFAULT NULL,
  `QuiG` double(5,2) DEFAULT NULL,
  `RecT` double DEFAULT NULL,
  `RecR` double(5,2) DEFAULT NULL,
  `RecG` double(5,2) DEFAULT NULL,
  `SeatT` double DEFAULT NULL,
  `SeatR` double(5,2) DEFAULT NULL,
  `SeatG` double(5,2) DEFAULT NULL,
  `TotalGrade` double(5,2) DEFAULT NULL,
  `Term` varchar(5) DEFAULT NULL,
  `SYear` varchar(50) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

/*Data for the table `tblgradesheet` */

insert  into `tblgradesheet`(`SNum`,`LName`,`FName`,`SCode`,`AssT`,`AssR`,`AssG`,`ExT`,`ExR`,`ExG`,`OthT`,`OthR`,`OthG`,`ProT`,`ProR`,`ProG`,`QuiT`,`QuiR`,`QuiG`,`RecT`,`RecR`,`RecG`,`SeatT`,`SeatR`,`SeatG`,`TotalGrade`,`Term`,`SYear`) values (140341,'Mistica','Reinald Reinder','Draw 111',0,0.00,0.00,45,95.00,47.50,0,0.00,0.00,0,0.00,0.00,0,0.00,0.00,0,0.00,0.00,3,80.00,40.00,87.50,'P','2016-2017'),(140341,'Mistica','Reinald Reinder','Draw 111',0,0.00,0.00,32,82.00,41.00,0,0.00,0.00,0,0.00,0.00,0,0.00,0.00,0,0.00,0.00,2,70.00,35.00,76.00,'M','2016-2017'),(140341,'Mistica','Reinald Reinder','Draw 111',0,0.00,0.00,25,75.00,37.50,0,0.00,0.00,0,0.00,0.00,0,0.00,0.00,0,0.00,0.00,5,100.00,50.00,87.50,'F','2016-2017');

/*Table structure for table `tblgsheet` */

DROP TABLE IF EXISTS `tblgsheet`;

CREATE TABLE `tblgsheet` (
  `SNum` int(10) DEFAULT NULL,
  `LName` varchar(25) DEFAULT NULL,
  `FName` varchar(25) DEFAULT NULL,
  `PGrade` double(5,2) DEFAULT NULL,
  `MGrade` double(5,2) DEFAULT NULL,
  `FGrade` double(5,2) DEFAULT NULL,
  `SFinal` varchar(15) DEFAULT NULL,
  `FNum` double(3,2) DEFAULT NULL,
  `Remarks` varchar(10) DEFAULT NULL,
  `SCode` varchar(15) DEFAULT NULL,
  `Course` varchar(25) DEFAULT NULL,
  `Section` varchar(5) DEFAULT NULL,
  `SYear` varchar(50) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

/*Data for the table `tblgsheet` */

insert  into `tblgsheet`(`SNum`,`LName`,`FName`,`PGrade`,`MGrade`,`FGrade`,`SFinal`,`FNum`,`Remarks`,`SCode`,`Course`,`Section`,`SYear`) values (140341,'Mistica','Reinald Reinder',87.50,76.00,87.50,'84.05',2.25,'PASSED','Draw 111','COET','3A','2016-2017');

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
  `Term` varchar(5) DEFAULT NULL,
  `SYear` varchar(50) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

/*Data for the table `tblother` */

insert  into `tblother`(`SNum`,`LName`,`FName`,`SCode`,`N1`,`N2`,`N3`,`N4`,`N5`,`Total`,`Rat`,`Grade`,`Term`,`SYear`) values (140341,'Mistica','Reinald Reinder','Draw 111',0,0,0,0,0,0,'0.00',0.00,'P','2016-2017'),(140341,'Mistica','Reinald Reinder','Draw 111',0,0,0,0,0,0,'0.00',0.00,'M','2016-2017'),(140341,'Mistica','Reinald Reinder','Draw 111',0,0,0,0,0,0,'0.00',0.00,'F','2016-2017');

/*Table structure for table `tblproj` */

DROP TABLE IF EXISTS `tblproj`;

CREATE TABLE `tblproj` (
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
  `Term` varchar(5) DEFAULT NULL,
  `SYear` varchar(50) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

/*Data for the table `tblproj` */

insert  into `tblproj`(`SNum`,`LName`,`FName`,`SCode`,`N1`,`N2`,`N3`,`N4`,`N5`,`Total`,`Rat`,`Grade`,`Term`,`SYear`) values (140341,'Mistica','Reinald Reinder','Draw 111',0,0,0,0,0,0,'0.00',0.00,'P','2016-2017'),(140341,'Mistica','Reinald Reinder','Draw 111',0,0,0,0,0,0,'0.00',0.00,'M','2016-2017'),(140341,'Mistica','Reinald Reinder','Draw 111',0,0,0,0,0,0,'0.00',0.00,'F','2016-2017');

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
  `Term` varchar(5) DEFAULT NULL,
  `SYear` varchar(50) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

/*Data for the table `tblquiz` */

insert  into `tblquiz`(`SNum`,`LName`,`FName`,`SCode`,`N1`,`N2`,`N3`,`N4`,`N5`,`N6`,`N7`,`N8`,`N9`,`N10`,`N11`,`N12`,`Total`,`Rat`,`Grade`,`Term`,`SYear`) values (140341,'Mistica','Reinald Reinder','Draw 111',0,0,0,0,0,0,0,0,0,0,0,0,0,'0.00',0.00,'P','2016-2017'),(140341,'Mistica','Reinald Reinder','Draw 111',0,0,0,0,0,0,0,0,0,0,0,0,0,'0.00',0.00,'M','2016-2017'),(140341,'Mistica','Reinald Reinder','Draw 111',0,0,0,0,0,0,0,0,0,0,0,0,0,'0.00',0.00,'F','2016-2017');

/*Table structure for table `tblrec` */

DROP TABLE IF EXISTS `tblrec`;

CREATE TABLE `tblrec` (
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
  `Term` varchar(5) DEFAULT NULL,
  `SYear` varchar(50) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

/*Data for the table `tblrec` */

insert  into `tblrec`(`SNum`,`LName`,`FName`,`SCode`,`N1`,`N2`,`N3`,`N4`,`N5`,`Total`,`Rat`,`Grade`,`Term`,`SYear`) values (140341,'Mistica','Reinald Reinder','Draw 111',0,0,0,0,0,0,'0.00',0.00,'P','2016-2017'),(140341,'Mistica','Reinald Reinder','Draw 111',0,0,0,0,0,0,'0.00',0.00,'M','2016-2017'),(140341,'Mistica','Reinald Reinder','Draw 111',0,0,0,0,0,0,'0.00',0.00,'F','2016-2017');

/*Table structure for table `tblschoolyear` */

DROP TABLE IF EXISTS `tblschoolyear`;

CREATE TABLE `tblschoolyear` (
  `SchYear` varchar(25) DEFAULT NULL,
  `Semester` varchar(25) DEFAULT NULL,
  `SubCode` varchar(25) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

/*Data for the table `tblschoolyear` */

/*Table structure for table `tblseatwork` */

DROP TABLE IF EXISTS `tblseatwork`;

CREATE TABLE `tblseatwork` (
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
  `Term` varchar(5) DEFAULT NULL,
  `SYear` varchar(50) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

/*Data for the table `tblseatwork` */

insert  into `tblseatwork`(`SNum`,`LName`,`FName`,`SCode`,`N1`,`N2`,`N3`,`N4`,`N5`,`N6`,`N7`,`N8`,`N9`,`N10`,`N11`,`N12`,`Total`,`Rat`,`Grade`,`Term`,`SYear`) values (140341,'Mistica','Reinald Reinder','Draw 111',3,0,0,0,0,0,0,0,0,0,0,0,3,'80.00',40.00,'P','2016-2017'),(140341,'Mistica','Reinald Reinder','Draw 111',2,0,0,0,0,0,0,0,0,0,0,0,2,'70.00',35.00,'M','2016-2017'),(140341,'Mistica','Reinald Reinder','Draw 111',5,0,0,0,0,0,0,0,0,0,0,0,5,'100.00',50.00,'F','2016-2017');

/*Table structure for table `tblstat` */

DROP TABLE IF EXISTS `tblstat`;

CREATE TABLE `tblstat` (
  `StudentNumber` int(11) NOT NULL,
  `Status` varbinary(15) DEFAULT NULL,
  PRIMARY KEY (`StudentNumber`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

/*Data for the table `tblstat` */

insert  into `tblstat`(`StudentNumber`,`Status`) values (140341,'ENROLL');

/*Table structure for table `tblstudlist` */

DROP TABLE IF EXISTS `tblstudlist`;

CREATE TABLE `tblstudlist` (
  `StudNum` int(10) NOT NULL,
  `Lname` varchar(25) DEFAULT NULL,
  `FName` varchar(25) DEFAULT NULL,
  `MName` varchar(25) DEFAULT NULL,
  `Course` varchar(10) DEFAULT NULL,
  `Section` varchar(5) DEFAULT NULL,
  `CNum` varchar(15) DEFAULT NULL,
  `EmailAdd` varchar(40) DEFAULT NULL,
  `Gender` varchar(10) DEFAULT NULL,
  `Status` varchar(10) DEFAULT NULL,
  PRIMARY KEY (`StudNum`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

/*Data for the table `tblstudlist` */

insert  into `tblstudlist`(`StudNum`,`Lname`,`FName`,`MName`,`Course`,`Section`,`CNum`,`EmailAdd`,`Gender`,`Status`) values (140341,'Mistica','Reinald Reinder','','COET','3A','','','Male','ENROLL');

/*Table structure for table `tblsubj` */

DROP TABLE IF EXISTS `tblsubj`;

CREATE TABLE `tblsubj` (
  `SCode` varchar(10) DEFAULT NULL,
  `SName` varchar(800) DEFAULT NULL,
  `SYear` varchar(20) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

/*Data for the table `tblsubj` */

insert  into `tblsubj`(`SCode`,`SName`,`SYear`) values ('Draw 111','Basic Engineering Drawing','2016-2017');

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
  `PTerm` varchar(5) DEFAULT NULL,
  `NumTot` varchar(3) DEFAULT NULL,
  `SYear` varchar(50) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

/*Data for the table `tbltass` */

insert  into `tbltass`(`SCode`,`NT1`,`NT2`,`NT3`,`NT4`,`NT5`,`NT6`,`NT7`,`NT8`,`NT9`,`NT10`,`NT11`,`NT12`,`Tot`,`PTerm`,`NumTot`,`SYear`) values ('Draw 111',0,0,0,0,0,0,0,0,0,0,0,0,0,'P','0','2016-2017'),('Draw 111',0,0,0,0,0,0,0,0,0,0,0,0,0,'M','0','2016-2017'),('Draw 111',0,0,0,0,0,0,0,0,0,0,0,0,0,'F','0','2016-2017');

/*Table structure for table `tbltc` */

DROP TABLE IF EXISTS `tbltc`;

CREATE TABLE `tbltc` (
  `SCode` varchar(15) DEFAULT NULL,
  `SW` decimal(5,2) DEFAULT NULL,
  `Assign` decimal(5,2) DEFAULT NULL,
  `Rec` decimal(5,2) DEFAULT NULL,
  `Quiz` decimal(5,2) DEFAULT NULL,
  `Exam` decimal(5,2) DEFAULT NULL,
  `Other` decimal(5,2) DEFAULT NULL,
  `Proj` decimal(5,2) DEFAULT NULL,
  `SYear` varchar(50) DEFAULT NULL,
  `Att` decimal(5,2) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

/*Data for the table `tbltc` */

insert  into `tbltc`(`SCode`,`SW`,`Assign`,`Rec`,`Quiz`,`Exam`,`Other`,`Proj`,`SYear`,`Att`) values ('Draw 111','0.50','0.00','0.00','0.00','0.50','0.00','0.00','2016-2017','0.00');

/*Table structure for table `tbltexam` */

DROP TABLE IF EXISTS `tbltexam`;

CREATE TABLE `tbltexam` (
  `SCode` varchar(15) DEFAULT NULL,
  `TE` double DEFAULT NULL,
  `PTerm` varchar(5) DEFAULT NULL,
  `SYear` varchar(50) DEFAULT NULL,
  `NumTot` varchar(5) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

/*Data for the table `tbltexam` */

insert  into `tbltexam`(`SCode`,`TE`,`PTerm`,`SYear`,`NumTot`) values ('Draw 111',50,'P','2016-2017','1'),('Draw 111',50,'M','2016-2017','1'),('Draw 111',50,'F','2016-2017','1');

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
  `PTerm` varchar(5) DEFAULT NULL,
  `NumTot` varchar(3) DEFAULT NULL,
  `SYear` varchar(50) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

/*Data for the table `tbltother` */

insert  into `tbltother`(`SCode`,`NT1`,`NT2`,`NT3`,`NT4`,`NT5`,`Tot`,`PTerm`,`NumTot`,`SYear`) values ('Draw 111',0,0,0,0,0,0,'P','0','2016-2017'),('Draw 111',0,0,0,0,0,0,'M','0','2016-2017'),('Draw 111',0,0,0,0,0,0,'F','0','2016-2017');

/*Table structure for table `tbltproj` */

DROP TABLE IF EXISTS `tbltproj`;

CREATE TABLE `tbltproj` (
  `SCode` varchar(15) DEFAULT NULL,
  `NT1` double DEFAULT NULL,
  `NT2` double DEFAULT NULL,
  `NT3` double DEFAULT NULL,
  `NT4` double DEFAULT NULL,
  `NT5` double DEFAULT NULL,
  `Tot` double DEFAULT NULL,
  `PTerm` varchar(5) DEFAULT NULL,
  `NumTot` varchar(3) DEFAULT NULL,
  `SYear` varchar(50) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

/*Data for the table `tbltproj` */

insert  into `tbltproj`(`SCode`,`NT1`,`NT2`,`NT3`,`NT4`,`NT5`,`Tot`,`PTerm`,`NumTot`,`SYear`) values ('Draw 111',0,0,0,0,0,0,'P','0','2016-2017'),('Draw 111',0,0,0,0,0,0,'M','0','2016-2017'),('Draw 111',0,0,0,0,0,0,'F','0','2016-2017');

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
  `PTerm` varchar(5) DEFAULT NULL,
  `NumTot` varchar(3) DEFAULT NULL,
  `SYear` varchar(50) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

/*Data for the table `tbltquiz` */

insert  into `tbltquiz`(`SCode`,`NT1`,`NT2`,`NT3`,`NT4`,`NT5`,`NT6`,`NT7`,`NT8`,`NT9`,`NT10`,`NT11`,`NT12`,`Tot`,`PTerm`,`NumTot`,`SYear`) values ('Draw 111',0,0,0,0,0,0,0,0,0,0,0,0,0,'P','0','2016-2017'),('Draw 111',0,0,0,0,0,0,0,0,0,0,0,0,0,'M','0','2016-2017'),('Draw 111',0,0,0,0,0,0,0,0,0,0,0,0,0,'F','0','2016-2017');

/*Table structure for table `tbltrec` */

DROP TABLE IF EXISTS `tbltrec`;

CREATE TABLE `tbltrec` (
  `SCode` varchar(15) DEFAULT NULL,
  `NT1` double DEFAULT NULL,
  `NT2` double DEFAULT NULL,
  `NT3` double DEFAULT NULL,
  `NT4` double DEFAULT NULL,
  `NT5` double DEFAULT NULL,
  `Tot` double DEFAULT NULL,
  `PTerm` varchar(5) DEFAULT NULL,
  `NumTot` varchar(3) DEFAULT NULL,
  `SYear` varchar(50) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

/*Data for the table `tbltrec` */

insert  into `tbltrec`(`SCode`,`NT1`,`NT2`,`NT3`,`NT4`,`NT5`,`Tot`,`PTerm`,`NumTot`,`SYear`) values ('Draw 111',0,0,0,0,0,0,'P','0','2016-2017'),('Draw 111',0,0,0,0,0,0,'M','0','2016-2017'),('Draw 111',0,0,0,0,0,0,'F','0','2016-2017');

/*Table structure for table `tbltseatwork` */

DROP TABLE IF EXISTS `tbltseatwork`;

CREATE TABLE `tbltseatwork` (
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
  `PTerm` varchar(5) DEFAULT NULL,
  `NumTot` varchar(3) DEFAULT NULL,
  `SYear` varchar(50) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

/*Data for the table `tbltseatwork` */

insert  into `tbltseatwork`(`SCode`,`NT1`,`NT2`,`NT3`,`NT4`,`NT5`,`NT6`,`NT7`,`NT8`,`NT9`,`NT10`,`NT11`,`NT12`,`Tot`,`PTerm`,`NumTot`,`SYear`) values ('Draw 111',5,0,0,0,0,0,0,0,0,0,0,0,5,'P','1','2016-2017'),('Draw 111',5,0,0,0,0,0,0,0,0,0,0,0,5,'M','1','2016-2017'),('Draw 111',5,0,0,0,0,0,0,0,0,0,0,0,5,'F','1','2016-2017');

/*Table structure for table `tbluseracc` */

DROP TABLE IF EXISTS `tbluseracc`;

CREATE TABLE `tbluseracc` (
  `User` varchar(15) NOT NULL,
  `Pass` varchar(15) DEFAULT NULL,
  `Level` int(11) DEFAULT NULL,
  `FullName` varchar(100) DEFAULT NULL,
  PRIMARY KEY (`User`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

/*Data for the table `tbluseracc` */

insert  into `tbluseracc`(`User`,`Pass`,`Level`,`FullName`) values ('admin','admin',3,'Administrator'),('Pogi','paparapap',2,'Juan Dela Cruz'),('rain','pogi123',1,'Reinald Reinder Austria Mistica');

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;
