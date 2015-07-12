CREATE DATABASE  IF NOT EXISTS `medinventusdb` /*!40100 DEFAULT CHARACTER SET utf8 */;
USE `medinventusdb`;
-- MySQL dump 10.13  Distrib 5.6.17, for Win32 (x86)
--
-- Host: localhost    Database: medinventusdb
-- ------------------------------------------------------
-- Server version	5.1.72-community

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
-- Table structure for table `invoicelines`
--

DROP TABLE IF EXISTS `invoicelines`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `invoicelines` (
  `idInvoiceLines` int(11) NOT NULL AUTO_INCREMENT,
  `Invoice_idInvoice` int(11) NOT NULL,
  `Item_idItem` int(11) NOT NULL,
  PRIMARY KEY (`idInvoiceLines`),
  UNIQUE KEY `idInvoiceLines_UNIQUE` (`idInvoiceLines`),
  KEY `fk_InvoiceLines_Invoice1_idx` (`Invoice_idInvoice`),
  KEY `fk_InvoiceLines_Item1_idx` (`Item_idItem`),
  CONSTRAINT `fk_InvoiceLines_Invoice1` FOREIGN KEY (`Invoice_idInvoice`) REFERENCES `invoice` (`idInvoice`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_InvoiceLines_Item1` FOREIGN KEY (`Item_idItem`) REFERENCES `item` (`idItem`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `invoicelines`
--

LOCK TABLES `invoicelines` WRITE;
/*!40000 ALTER TABLE `invoicelines` DISABLE KEYS */;
/*!40000 ALTER TABLE `invoicelines` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2014-10-19 13:25:24
