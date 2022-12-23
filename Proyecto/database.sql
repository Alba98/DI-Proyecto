DROP DATABASE IF EXISTS db1;
CREATE DATABASE IF NOT EXISTS db1;
USE db1;

CREATE TABLE PUESTO (
  id_puesto int NOT NULL AUTO_INCREMENT,
  nombre varchar(20) CHARACTER SET utf8mb4 COLLATE utf8mb4_spanish_ci NOT NULL,
  PRIMARY KEY (id_puesto)
);

CREATE TABLE EMPLEADOS (
    codigo int NOT NULL AUTO_INCREMENT,
    nombre VARCHAR(50) NOT NULL,
    apellido1 VARCHAR(50) NOT NULL,
    apellido2 VARCHAR(50) NOT NULL,
    email VARCHAR(100) NOT NULL,
    fecha_nacimiento DATE NOT NULL,
    telefono int(9) NOT NULL,
    puesto int NOT NULL,
    clave VARCHAR(50) NOT NULL,
    PRIMARY KEY (codigo),
    FOREIGN KEY (puesto) REFERENCES PUESTO(id_puesto)
);
