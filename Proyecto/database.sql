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
    email VARCHAR(100) NOT NULL UNIQUE,
    fecha_nacimiento DATE NOT NULL,
    telefono int(9) NOT NULL,
    puesto int NOT NULL,
    clave VARCHAR(50) NOT NULL,
    PRIMARY KEY (codigo),
    FOREIGN KEY (puesto) REFERENCES PUESTO(id_puesto)
);

INSERT INTO `PUESTO` (`id_puesto`, `nombre`) VALUES
(1, 'Programador'),
(2, 'Contable'),
(3, 'Marketing'),
(4, 'Desing');

INSERT INTO `EMPLEADOS` (`codigo`, `nombre`, `apellido1`, `apellido2`, `email`, `fecha_nacimiento`, `telefono`, `puesto`, `clave`) VALUES
(1, 'Alba', 'Alonso', 'Marmany', 'alba@gmail.com', '1998-05-03', 657616330, 1, '12345'),
(2, 'Andrea', 'Chasco', 'Rodriguez', 'andrea@gmail.com', '1999-11-22', 945172930, 2, '12345'),
(3, 'Ruth', 'Alonso', 'Marmany', 'ruth@gmail.com', '1999-10-02', 633820169, 3, '12345'),
(4, 'Victoria', 'Barriobero', 'Almagro', 'vicknot@gmail.com', '2000-11-04', 945173029, 1, '12345');
