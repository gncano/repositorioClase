-- MySQL dump 10.13  Distrib 8.0.36, for Win64 (x86_64)
--
-- Host: localhost    Database: gestion_inventario
-- ------------------------------------------------------
-- Server version	8.0.37

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
-- Table structure for table `categoria`
--

DROP TABLE IF EXISTS `categoria`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `categoria` (
  `id` bigint NOT NULL AUTO_INCREMENT,
  `descripcion` varchar(255) DEFAULT NULL,
  `fecha_creacion` date DEFAULT NULL,
  `nombre` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `categoria`
--

LOCK TABLES `categoria` WRITE;
/*!40000 ALTER TABLE `categoria` DISABLE KEYS */;
INSERT INTO `categoria` VALUES (1,'Teclados, ratones y otros periféricos',NULL,'Periféricos'),(2,'Monitores y dispositivos de audio',NULL,'Monitores y Audio'),(3,'Dispositivos de almacenamiento USB, discos, etc',NULL,'Almacenamiento');
/*!40000 ALTER TABLE `categoria` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `producto`
--

DROP TABLE IF EXISTS `producto`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `producto` (
  `id` bigint NOT NULL AUTO_INCREMENT,
  `descripcion` varchar(255) DEFAULT NULL,
  `nombre` varchar(255) DEFAULT NULL,
  `precio` double DEFAULT NULL,
  `stock_actual` int DEFAULT NULL,
  `stock_minimo` int DEFAULT NULL,
  `categoria_id` bigint DEFAULT NULL,
  PRIMARY KEY (`id`),
  KEY `fk_producto_categoria` (`categoria_id`),
  CONSTRAINT `fk_producto_categoria` FOREIGN KEY (`categoria_id`) REFERENCES `categoria` (`id`) ON DELETE RESTRICT ON UPDATE CASCADE,
  CONSTRAINT `FKodqr7965ok9rwquj1utiamt0m` FOREIGN KEY (`categoria_id`) REFERENCES `categoria` (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=33 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `producto`
--

LOCK TABLES `producto` WRITE;
/*!40000 ALTER TABLE `producto` DISABLE KEYS */;
INSERT INTO `producto` VALUES (1,'Teclado mecánico USB','Teclado',43,25,10,1),(2,'Ratón óptico inalámbrico','Ratón',29.5,40,10,1),(3,'Monitor 24 pulgadas Full HD','Monitor',150,2,3,2),(4,'Pendrive 64GB USB 3.0','Memoria USB',19.99,50,8,3),(5,'Auriculares con micrófono','Auriculares',35,1,4,2),(6,'Auriculares sin micrófono','Auriculares 2',35,3,5,2),(7,'Teclado inalámbrico compacto','Teclado Slim',39.99,12,5,1),(8,'Ratón ergonómico con cable','Ratón Ergonómico',24.5,5,2,1),(9,'Monitor 27 pulgadas 2K','Monitor 2K',210,8,4,1),(10,'Teclado gamer retroiluminado','Teclado RGB',59.9,6,3,1),(11,'Ratón vertical inalámbrico','Ratón Vertical',34.99,10,5,1),(12,'Monitor 32 pulgadas 4K','Monitor 4K',320,4,2,1),(13,'Teclado numérico USB','Teclado Numérico',14.99,20,5,1),(14,'Auriculares Bluetooth con cancelación de ruido','Auriculares Pro',89,15,5,2),(15,'Altavoz Bluetooth portátil','Altavoz Portátil',39.9,12,4,2),(16,'Micrófono USB para streaming','Micrófono USB',55,6,2,2),(17,'Monitor 29 pulgadas ultrawide','Monitor Ultrawide',240,7,3,2),(18,'Barra de sonido compacta','Soundbar Mini',79.99,9,3,2),(19,'Auriculares gaming con RGB','Auriculares Gaming',49.99,11,4,2),(21,'Pendrive 128GB USB-C','Memoria USB-C',29.99,25,10,3),(22,'Disco duro externo 1TB','HDD 1TB',75,20,5,3),(23,'Tarjeta SD 64GB clase 10','SD 64GB',18.5,30,8,3),(24,'SSD 512GB NVMe','SSD 512GB',89.99,10,4,3),(25,'Disco duro interno 2TB','HDD 2TB',95,6,2,3);
/*!40000 ALTER TABLE `producto` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `producto_proveedor`
--

DROP TABLE IF EXISTS `producto_proveedor`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `producto_proveedor` (
  `producto_id` bigint NOT NULL,
  `proveedor_id` bigint NOT NULL,
  PRIMARY KEY (`producto_id`,`proveedor_id`),
  KEY `FKghg3oq7cjlax3u2hr36oicao1` (`proveedor_id`),
  CONSTRAINT `FK9aa883o9f6pal6n3w15kk5yyy` FOREIGN KEY (`producto_id`) REFERENCES `producto` (`id`),
  CONSTRAINT `FKghg3oq7cjlax3u2hr36oicao1` FOREIGN KEY (`proveedor_id`) REFERENCES `proveedor` (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `producto_proveedor`
--

LOCK TABLES `producto_proveedor` WRITE;
/*!40000 ALTER TABLE `producto_proveedor` DISABLE KEYS */;
INSERT INTO `producto_proveedor` VALUES (1,1),(2,1),(6,1),(7,1),(9,1),(11,1),(14,1),(16,1),(18,1),(21,1),(23,1),(25,1),(1,2),(2,2),(8,2),(11,2),(12,2),(15,2),(18,2),(19,2),(22,2),(25,2),(3,3),(8,3),(10,3),(13,3),(14,3),(17,3),(21,3),(24,3),(4,4),(5,5);
/*!40000 ALTER TABLE `producto_proveedor` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `proveedor`
--

DROP TABLE IF EXISTS `proveedor`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `proveedor` (
  `id` bigint NOT NULL AUTO_INCREMENT,
  `email` varchar(255) DEFAULT NULL,
  `nombre` varchar(255) DEFAULT NULL,
  `telefono` int NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `proveedor`
--

LOCK TABLES `proveedor` WRITE;
/*!40000 ALTER TABLE `proveedor` DISABLE KEYS */;
INSERT INTO `proveedor` VALUES (1,'contacto@tecnoprove.com','TecnoProve S.A.',912345678),(2,'ventas@dispositivoselectro.com','Dispositivos Electro',913216547),(3,'info@almacenmax.com','AlmacenMax',914785236),(4,'soporte@audioandco.com','Audio&Co',915987654),(5,'ventas@perifericosplus.com','Periféricos Plus',916234589);
/*!40000 ALTER TABLE `proveedor` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2026-01-29 10:51:33
