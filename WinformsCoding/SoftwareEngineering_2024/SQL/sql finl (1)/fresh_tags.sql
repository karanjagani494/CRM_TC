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
-- Table structure for table `tags`
--

DROP TABLE IF EXISTS `tags`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tags` (
  `tag_id` int NOT NULL AUTO_INCREMENT,
  `tag_1` varchar(50) COLLATE utf8mb4_general_ci DEFAULT NULL,
  `tag_2` varchar(50) COLLATE utf8mb4_general_ci DEFAULT NULL,
  `tag_3` varchar(50) COLLATE utf8mb4_general_ci DEFAULT NULL,
  `tag_4` varchar(50) COLLATE utf8mb4_general_ci DEFAULT NULL,
  `tag_5` varchar(50) COLLATE utf8mb4_general_ci DEFAULT NULL,
  `tag_6` varchar(50) COLLATE utf8mb4_general_ci DEFAULT NULL,
  `tag_7` varchar(50) COLLATE utf8mb4_general_ci DEFAULT NULL,
  `tag_8` varchar(50) COLLATE utf8mb4_general_ci DEFAULT NULL,
  `tag_9` varchar(50) COLLATE utf8mb4_general_ci DEFAULT NULL,
  `tag_10` varchar(50) COLLATE utf8mb4_general_ci DEFAULT NULL,
  `tag_11` varchar(50) COLLATE utf8mb4_general_ci DEFAULT NULL,
  `tag_12` varchar(50) COLLATE utf8mb4_general_ci DEFAULT NULL,
  `member_id` int DEFAULT NULL,
  PRIMARY KEY (`tag_id`),
  UNIQUE KEY `member_id` (`member_id`),
  CONSTRAINT `FK_member_id` FOREIGN KEY (`member_id`) REFERENCES `members` (`member_id`)
) ENGINE=InnoDB AUTO_INCREMENT=35 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tags`
--

LOCK TABLES `tags` WRITE;
/*!40000 ALTER TABLE `tags` DISABLE KEYS */;
INSERT INTO `tags` VALUES (32,'HEALTHCARE','GAMING','EDUCATION',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,88),(33,'TEC','BUSINESS',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,89),(34,'HEALTHCARE','BUSINESS',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,90);
/*!40000 ALTER TABLE `tags` ENABLE KEYS */;
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
