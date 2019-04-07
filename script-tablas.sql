--CREAR TABLAS 
USE portafolio

CREATE TABLE Usuario (
  IdUsuario INT NOT NULL IDENTITY PRIMARY KEY,
  NombreUsuario VARCHAR(20) NOT NULL,
  Password VARCHAR(8) NOT NULL,
  Rol INT NOT NULL,
  Nombre varchar(50),
  Apellidos varchar(50),
  Email varchar(30)
)
GO

CREATE TABLE  Docente(
IdDocente INT NOT NULL IDENTITY PRIMARY KEY,
Nombre varchar(50),
Apellidos varchar(50),
Email varchar(30)
)
GO

CREATE TABLE  Portafolio(
IdPortafolio INT NOT NULL IDENTITY PRIMARY KEY,
IdDocente INT NOT NULL,
Semestre varchar(50),
NombreDocumento varchar(50),
TipoDocumento varchar(50),
Documento VARBINARY(max) NULL,
FOREIGN KEY (IdDocente) REFERENCES Docente(IdDocente)
)
GO



--insert into Usuario(CodUsuario,NickName,Contrase�a,CodPerfil,NombreUsuario,Apellido,Email) values ('211111111','Hernan','1234','1111111111','Hernan','Chirinos','HernanChi@gmail.com');
--insert into Usuario(CodUsuario,NickName,Contrase�a,CodPerfil,NombreUsuario,Apellido,Email) values ('211111112','Cesar','4321','1111111112','Cesar','Alzamora','CesarAl@gmail.com');
--insert into Usuario(CodUsuario,NickName,Contrase�a,CodPerfil,NombreUsuario,Apellido,Email) values ('211111113','Arturo','1111','1111111113','Arturo','Rozas','ArutoroRo@gmail.com');

