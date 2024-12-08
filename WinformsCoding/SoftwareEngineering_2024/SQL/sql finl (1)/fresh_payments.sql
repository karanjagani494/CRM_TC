-- MySQL dump 10.13  Distrib 8.0.38, for Win64 (x86_64)
--
-- Host: 127.0.0.1    Database: fresh
-- ------------------------------------------------------
-- Server version	8.0.39

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!50503 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `payments`
--

DROP TABLE IF EXISTS `payments`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `payments` (
  `payment_id` int NOT NULL AUTO_INCREMENT,
  `cardHolder_name` varchar(255) COLLATE utf8mb4_general_ci NOT NULL,
  `card_no` varchar(20) COLLATE utf8mb4_general_ci NOT NULL,
  `cvv` char(3) COLLATE utf8mb4_general_ci NOT NULL,
  `house_no` varchar(50) COLLATE utf8mb4_general_ci NOT NULL,
  `city` varchar(100) COLLATE utf8mb4_general_ci NOT NULL,
  `state` varchar(100) COLLATE utf8mb4_general_ci NOT NULL,
  `country` varchar(100) COLLATE utf8mb4_general_ci NOT NULL,
  `street` varchar(255) COLLATE utf8mb4_general_ci NOT NULL,
  `citycode` varchar(10) COLLATE utf8mb4_general_ci NOT NULL,
  `exp_date` date NOT NULL,
  `member_id` int DEFAULT NULL,
  PRIMARY KEY (`payment_id`)
) ENGINE=InnoDB AUTO_INCREMENT=38 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `payments`
--

LOCK TABLES `payments` WRITE;
/*!40000 ALTER TABLE `payments` DISABLE KEYS */;
INSERT INTO `payments` VALUES (12,'ASD','1234','123','asdfg','asdfg','asdfg','asdfgasdfg','asdfg','asdfg','2020-02-02',89),(13,'SDVF','12345','123','sdvf','sdvf','sdvf','sdvf','sdvf','sdvf','2029-02-08',90),(14,'John Doe','1234567812345678','123','123A','New York','New York','USA','123 Broadway','10001','2025-12-31',88),(26,'John Doe','1234567812345678','123','123A','New York','New York','USA','123 Broadway','10001','2025-12-31',88),(27,'Jane Smith','2345678923456789','234','456B','Los Angeles','California','USA','456 Sunset Blvd','90001','2026-03-15',89),(28,'Alice Johnson','3456789034567890','345','789C','Chicago','Illinois','USA','789 Michigan Ave','60601','2027-06-30',90),(29,'David Lee','4567890145678901','456','101D','Miami','Florida','USA','101 Ocean Drive','33101','2024-09-15',88),(30,'Maria Garcia','5678901256789012','567','202E','Houston','Texas','USA','202 Main St','77001','2025-10-05',89),(31,'Carlos Martinez','6789012367890123','678','303F','Dallas','Texas','USA','303 Elm St','75201','2026-02-20',90),(32,'Sophia Brown','7890123478901234','789','404G','San Francisco','California','USA','404 Market St','94102','2027-01-25',88),(33,'Oliver Wilson','8901234589012345','890','505H','Atlanta','Georgia','USA','505 Peachtree St','30301','2024-07-12',89),(34,'Emma Taylor','9012345690123456','901','606I','Seattle','Washington','USA','606 Pine St','98101','2025-08-01',90),(35,'Liam Davis','0123456701234567','012','707J','Denver','Colorado','USA','707 Broadway St','80202','2026-11-30',88),(36,'Isabella Moore','1234567812345670','234','808K','Phoenix','Arizona','USA','808 Arizona Blvd','85001','2027-04-10',89),(37,'James Jackson','2345678923456781','345','909L','Boston','Massachusetts','USA','909 Newbury St','02115','2024-12-05',90);
/*!40000 ALTER TABLE `payments` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2024-12-08  6:50:10
