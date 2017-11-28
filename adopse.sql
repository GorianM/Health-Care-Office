-- MySQL dump 10.13  Distrib 5.7.17, for Win64 (x86_64)
--
-- Host: 127.0.0.1    Database: adopse
-- ------------------------------------------------------
-- Server version	5.5.5-10.1.28-MariaDB

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
-- Table structure for table `appointment`
--

DROP TABLE IF EXISTS `appointment`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `appointment` (
  `AppointmentId` int(11) NOT NULL,
  `DateTime` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
  `EstimatedDurationMinutes` int(11) DEFAULT NULL,
  `Reason` varchar(45) DEFAULT NULL,
  `Diagnosis` varchar(45) DEFAULT NULL,
  `Treatment` varchar(45) DEFAULT NULL,
  `Notes` varchar(45) DEFAULT NULL,
  `Patient_PatientId` int(11) NOT NULL,
  PRIMARY KEY (`AppointmentId`,`Patient_PatientId`),
  KEY `fk_Appointment_Patient1_idx` (`Patient_PatientId`),
  CONSTRAINT `fk_Appointment_Patient1` FOREIGN KEY (`Patient_PatientId`) REFERENCES `patient` (`PatientId`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `appointment`
--

LOCK TABLES `appointment` WRITE;
/*!40000 ALTER TABLE `appointment` DISABLE KEYS */;
/*!40000 ALTER TABLE `appointment` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `expandableproducts`
--

DROP TABLE IF EXISTS `expandableproducts`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `expandableproducts` (
  `ExpandableProductsId` int(11) NOT NULL,
  `Description` varchar(45) DEFAULT NULL,
  `MinimumThreshold` int(11) DEFAULT NULL,
  `Quantity` int(11) DEFAULT NULL,
  `Staff_StaffID` int(11) NOT NULL,
  PRIMARY KEY (`ExpandableProductsId`,`Staff_StaffID`),
  KEY `fk_ExpandableProducts_Staff_idx` (`Staff_StaffID`),
  CONSTRAINT `fk_ExpandableProducts_Staff` FOREIGN KEY (`Staff_StaffID`) REFERENCES `staff` (`StaffID`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `expandableproducts`
--

LOCK TABLES `expandableproducts` WRITE;
/*!40000 ALTER TABLE `expandableproducts` DISABLE KEYS */;
/*!40000 ALTER TABLE `expandableproducts` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `expenses`
--

DROP TABLE IF EXISTS `expenses`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `expenses` (
  `ExpensesId` int(11) NOT NULL,
  `ExpensesDesciption` varchar(45) DEFAULT NULL,
  `Amount` decimal(10,2) DEFAULT NULL,
  `Staff_StaffID` int(11) NOT NULL,
  `Staff_StaffRoles_StaffRolesID` int(11) NOT NULL,
  PRIMARY KEY (`ExpensesId`,`Staff_StaffID`,`Staff_StaffRoles_StaffRolesID`),
  KEY `fk_Expenses_Staff1_idx` (`Staff_StaffID`,`Staff_StaffRoles_StaffRolesID`),
  CONSTRAINT `fk_Expenses_Staff1` FOREIGN KEY (`Staff_StaffID`, `Staff_StaffRoles_StaffRolesID`) REFERENCES `staff` (`StaffID`, `StaffRoles_StaffRolesID`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `expenses`
--

LOCK TABLES `expenses` WRITE;
/*!40000 ALTER TABLE `expenses` DISABLE KEYS */;
/*!40000 ALTER TABLE `expenses` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `incomes`
--

DROP TABLE IF EXISTS `incomes`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `incomes` (
  `IncomesId` int(11) NOT NULL,
  `IncomeDesciption` varchar(45) DEFAULT NULL,
  `Amount` decimal(10,2) DEFAULT NULL,
  `Staff_StaffID` int(11) NOT NULL,
  `Staff_StaffRoles_StaffRolesID` int(11) NOT NULL,
  PRIMARY KEY (`IncomesId`,`Staff_StaffID`,`Staff_StaffRoles_StaffRolesID`),
  KEY `fk_Incomes_Staff1_idx` (`Staff_StaffID`,`Staff_StaffRoles_StaffRolesID`),
  CONSTRAINT `fk_Incomes_Staff1` FOREIGN KEY (`Staff_StaffID`, `Staff_StaffRoles_StaffRolesID`) REFERENCES `staff` (`StaffID`, `StaffRoles_StaffRolesID`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `incomes`
--

LOCK TABLES `incomes` WRITE;
/*!40000 ALTER TABLE `incomes` DISABLE KEYS */;
/*!40000 ALTER TABLE `incomes` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `patient`
--

DROP TABLE IF EXISTS `patient`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `patient` (
  `PatientId` int(11) NOT NULL,
  `PhoneNumber` varchar(45) DEFAULT NULL,
  `PhoneNumber2` varchar(45) DEFAULT NULL,
  `Name` varchar(45) DEFAULT NULL,
  `LastName` varchar(45) DEFAULT NULL,
  `Amka` int(11) DEFAULT NULL,
  `Sex` char(1) DEFAULT NULL,
  `BirthDate` char(1) DEFAULT NULL,
  `Adress` varchar(45) DEFAULT NULL,
  `RegistrationNumber` varchar(45) DEFAULT NULL,
  `Debt` decimal(10,2) DEFAULT NULL,
  `Insurance` varchar(45) DEFAULT NULL,
  `Notes` varchar(999) DEFAULT NULL,
  `Weight` decimal(10,2) DEFAULT NULL,
  PRIMARY KEY (`PatientId`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `patient`
--

LOCK TABLES `patient` WRITE;
/*!40000 ALTER TABLE `patient` DISABLE KEYS */;
/*!40000 ALTER TABLE `patient` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `staff`
--

DROP TABLE IF EXISTS `staff`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `staff` (
  `StaffID` int(11) NOT NULL,
  `Username` varchar(45) DEFAULT NULL,
  `Password` varchar(45) DEFAULT NULL,
  `MedicalSpecialty` varchar(45) DEFAULT NULL,
  `Name` varchar(45) DEFAULT NULL,
  `LastName` varchar(45) DEFAULT NULL,
  `PhoneNumber` varchar(45) DEFAULT NULL,
  `PhoneNumber2` varchar(45) DEFAULT NULL,
  `StaffRoles_StaffRolesID` int(11) NOT NULL,
  PRIMARY KEY (`StaffID`,`StaffRoles_StaffRolesID`),
  KEY `fk_Staff_StaffRoles1_idx` (`StaffRoles_StaffRolesID`),
  CONSTRAINT `fk_Staff_StaffRoles1` FOREIGN KEY (`StaffRoles_StaffRolesID`) REFERENCES `staffroles` (`StaffRolesID`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `staff`
--

LOCK TABLES `staff` WRITE;
/*!40000 ALTER TABLE `staff` DISABLE KEYS */;
/*!40000 ALTER TABLE `staff` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `staff_appointment`
--

DROP TABLE IF EXISTS `staff_appointment`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `staff_appointment` (
  `AppointmentId` int(11) NOT NULL,
  `DateTime` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
  `Staff_StaffID` int(11) NOT NULL,
  `Staff_StaffRoles_StaffRolesID` int(11) NOT NULL,
  `Appointment_AppointmentId` int(11) NOT NULL,
  PRIMARY KEY (`AppointmentId`,`Staff_StaffID`,`Staff_StaffRoles_StaffRolesID`,`Appointment_AppointmentId`),
  KEY `fk_Appointment_Staff1_idx` (`Staff_StaffID`,`Staff_StaffRoles_StaffRolesID`),
  KEY `fk_Staff_Appointment_Appointment1_idx` (`Appointment_AppointmentId`),
  CONSTRAINT `fk_Appointment_Staff1` FOREIGN KEY (`Staff_StaffID`, `Staff_StaffRoles_StaffRolesID`) REFERENCES `staff` (`StaffID`, `StaffRoles_StaffRolesID`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_Staff_Appointment_Appointment1` FOREIGN KEY (`Appointment_AppointmentId`) REFERENCES `appointment` (`AppointmentId`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `staff_appointment`
--

LOCK TABLES `staff_appointment` WRITE;
/*!40000 ALTER TABLE `staff_appointment` DISABLE KEYS */;
/*!40000 ALTER TABLE `staff_appointment` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `staffroles`
--

DROP TABLE IF EXISTS `staffroles`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `staffroles` (
  `StaffRolesID` int(11) NOT NULL,
  `StaffRolesDescription` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`StaffRolesID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `staffroles`
--

LOCK TABLES `staffroles` WRITE;
/*!40000 ALTER TABLE `staffroles` DISABLE KEYS */;
/*!40000 ALTER TABLE `staffroles` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2017-11-28  2:28:44
