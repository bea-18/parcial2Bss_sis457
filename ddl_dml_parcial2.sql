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
  urlPortada VARCHAR(500) NULL,
  idiomaOriginal VARCHAR(100) NULL,
  estado SMALLINT NOT NULL DEFAULT 1 -- -1: Eliminado, 0: Inactivo, 1: Activo
);

GO
ALTER PROC paSerieListar @parametro VARCHAR(100)
AS
  SELECT * FROM Serie
  WHERE estado<>-1 AND titulo+sinopsis+director LIKE '%'+REPLACE(@parametro,' ','%')+'%'
  ORDER BY titulo ASC;

--DML
INSERT INTO Serie (titulo, sinopsis, director, episodios, fechaEstreno, urlPortada, idiomaOriginal)
VALUES ('Breaking Bad', 'Un profesor de química se convierte en fabricante de metanfetaminas.', 'Vince Gilligan', 62, '2008-01-20', 'https://example.com/breakingbad.jpg', 'Inglés');

INSERT INTO Serie (titulo, sinopsis, director, episodios, fechaEstreno, urlPortada, idiomaOriginal)
VALUES ('Game of Thrones', 'Una serie épica de fantasía basada en las novelas de George R.R. Martin.', 'David Benioff, D.B. Weiss', 73, '2011-04-17', 'https://example.com/got.jpg', 'Inglés');

SELECT * FROM Serie;