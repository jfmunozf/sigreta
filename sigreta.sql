CREATE DATABASE sigreta;
USE sigreta;
CREATE TABLE `usuarios` (
  `email` varchar(255) NOT NULL,
  `nombres` varchar(255) NOT NULL,
  `apellidos` varchar(255) NOT NULL,
  `perfil` enum('admin','user') NOT NULL,
  `contrasena` varchar(100) NOT NULL,
  PRIMARY KEY (`email`)
) ENGINE=InnoDB;
