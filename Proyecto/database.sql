DROP DATABASE IF EXISTS db1;
CREATE DATABASE IF NOT EXISTS db1;
USE db1;

CREATE TABLE usuarios (
    id INT NOT NULL AUTO_INCREMENT,
    usuario VARCHAR(20) NOT NULL,
    nombre VARCHAR(100) NOT NULL,
    apellidos VARCHAR(100) NOT NULL,
    email VARCHAR(100) NOT NULL,
    contrasena VARCHAR(100) NOT NULL,
    PRIMARY KEY (id)
);

CREATE TABLE empleados (
    codigo varchar(10) NOT NULL AUTO_INCREMENT,
    nombres varchar(50) NOT NULL,
    lugar_nacimiento varchar(30) NOT NULL,
    fecha_nacimiento varchar(30) NOT NULL,
    direccion varchar(50) NOT NULL,
    telefono varchar(10) NOT NULL,
    puesto varchar(15) NOT NULL,
    estado int(11) NOT NULL,
    PRIMARY KEY (codigo)
);

INSERT INTO usuarios (usuario, nombre, apellidos, email, contrasena) VALUES ('jvadillo', 'Jon', 'Vadillo Romero', 'jvadillo@egibide.org', '1234');
INSERT INTO usuarios (usuario, nombre, apellidos, email, contrasena) VALUES ('jmalvido', 'Jaime', 'Malvido Durango', 'jvadillo@egibide.org', '4321');

INSERT INTO empleados (`codigo`, `nombres`, `lugar_nacimiento`, `fecha_nacimiento`, `direccion`, `telefono`, `puesto`, `estado`) VALUES
('1250', 'Juan Campos', 'Santa Ana, El Salvador', '15-06-1991', '', '70252525', 'Gerente', 2),
('12509', 'Andres Perez', 'SM', '06-06-1980', 'SM', '12345789', 'Gerente', 3),
('15200', 'Marcos Amaya', 'Santa Salvador', '06-06-2017', 'San Salvador', '12345678', 'Vendedor', 1);
 