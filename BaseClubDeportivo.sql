drop database if exists ClubDeportivo;
create database ClubDeportivo;
use ClubDeportivo;


create table usuarios(
id int auto_increment,
Usuario varchar (20),
Password varchar (20),
constraint pk_usuario primary key (id)
);

insert into usuarios(Usuario,Password) values
('Gonzalo','123456');
insert into usuarios(Usuario,Password) values
('Marcelo','123456');



CREATE TABLE clientes (
	id int auto_increment NOT NULL,
	nombre varchar(50) NOT NULL,
	apellido varchar(50) NOT NULL,
	tipodoc varchar(20) NOT NULL,
	documento varchar(11) NOT NULL,
	tipocliente tinyint NOT NULL,
	aptofisico bool DEFAULT false NOT NULL,
	CONSTRAINT clientes_pk PRIMARY KEY (id)
);



DROP PROCEDURE IF EXISTS login; 
DELIMITER //
CREATE PROCEDURE login(
    IN usuario VARCHAR(20),
    IN password VARCHAR(20)
)
BEGIN
    SELECT id AS existe FROM usuarios u WHERE u.Usuario = usuario AND u.Password = password;
END //

DELIMITER ;

DROP PROCEDURE IF EXISTS registrarSocio; 
DELIMITER //
CREATE PROCEDURE registrarSocio (
    IN nombre VARCHAR(50),
    IN apellido VARCHAR(50),
    IN tipodoc VARCHAR(20),
    IN documento VARCHAR(11),
    IN aptofisico BOOL 
)
BEGIN
    INSERT INTO clientes (nombre, apellido, tipodoc, documento, tipocliente, aptofisico)
    VALUES (nombre, apellido, tipodoc, documento, 1, aptofisico);
END //
DELIMITER ;

DROP PROCEDURE IF EXISTS registrarNoSocio; 
DELIMITER //
CREATE PROCEDURE registrarNoSocio (
    IN nombre VARCHAR(50),
    IN apellido VARCHAR(50),
    IN tipodoc VARCHAR(20),
    IN documento VARCHAR(11),
    IN aptofisico BOOL 
)
BEGIN
    INSERT INTO clientes (nombre, apellido, tipodoc, documento, tipocliente, aptofisico)
    VALUES (nombre, apellido, tipodoc, documento, 0, aptofisico);
END //
DELIMITER ;


