CREATE DATABASE `escuela` /*!40100 DEFAULT CHARACTER SET utf8 */;
CREATE TABLE `alumnos` (
  `NumControl` varchar(4) DEFAULT NULL,
  `Nombre` varchar(30) DEFAULT NULL,
  `Naci` date DEFAULT NULL,
  `Ciudad` varchar(30) DEFAULT NULL,
  `Especialidad` varchar(30) DEFAULT NULL,
  `Semestre` int(11) DEFAULT NULL,
  KEY `Índice 1` (`NumControl`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

