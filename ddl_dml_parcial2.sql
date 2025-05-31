CREATE DATABASE Parcial2Bss;
GO
USE [master]
GO
CREATE LOGIN [usrparcial2] WITH PASSWORD = N'12345678',
	DEFAULT_DATABASE = [Parcial2Bss],
	CHECK_EXPIRATION = OFF,
	CHECK_POLICY = ON
GO
USE [Parcial2Bss]
GO
CREATE USER [usrparcial2] FOR LOGIN [usrparcial2]
GO
ALTER ROLE [db_owner] ADD MEMBER [usrparcial2]
GO

DROP TABLE Serie;

CREATE TABLE Serie (
  id INT NOT NULL PRIMARY KEY IDENTITY(1,1),
  titulo VARCHAR(250) NOT NULL,
  sinopsis VARCHAR(5000) NOT NULL,
  director VARCHAR(100) NOT NULL,
  episodios BIGINT NOT NULL,
  fechaEstreno DATETIME NOT NULL DEFAULT GETDATE(),
  estado SMALLINT NOT NULL DEFAULT 1 -- -1: Eliminado, 0: Inactivo, 1: Activo
);

GO
CREATE PROC paSerieListar @parametro VARCHAR(100)
AS
  SELECT * FROM Serie
  WHERE estado<>-1 AND titulo+sinopsis+director LIKE '%'+REPLACE(@parametro,' ','%')+'%'
  ORDER BY titulo ASC;

--DML
INSERT INTO Serie (titulo, sinopsis, director, episodios, fechaEstreno)
VALUES ('Game of Thrones', 'Nobles luchan por el control del Trono de Hierro.', 'David Benioff, D.B. Weiss', 73, '2011-04-17');

SELECT * FROM Serie;