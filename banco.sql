CREATE DATABASE Banco;

USE Banco;

CREATE TABLE Usuario
(
  UserId INT IDENTITY(1,1) NOT NULL,
  UserName VARCHAR(50),
  UserEmail VARCHAR(50),
  UserPassword VARCHAR(50),
  CONSTRAINT pk_UsuarioId PRIMARY KEY (UserId)
);

INSERT INTO Usuario (UserName, UserEmail, UserPassword) VALUES ('Anthony Santos', 'anthonygabriel@gmail.com', 'algoestranho');
INSERT INTO Usuario (UserName, UserEmail, UserPassword) VALUES ('Isadora Freitas', 'isadorafreitas@gmail.com', 'algoestranho');

SELECT * FROM Usuario;