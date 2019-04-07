select * from Usuario;
insert into Usuario(NombreUsuario,Password,Rol,Nombre,Apellidos,Email)values ('lexsalg','lexsalg',3,'Alexis','Salgado Tacuri','xel.salg@gmail.com');

select * from Docente;
insert into Docente(Nombre,Apellidos,Email)values ('Alexis','Salgado Tacuri','xel.salg@gmail.com');

select * from Portafolio
INSERT INTO Portafolio(IdDocente,Semestre,NombreDocumento,TipoDocumento,Documento) VALUES(1,'2019-I','Prueba Nombre Documento','CV',
 (SELECT * FROM OPENROWSET(BULK N'C:\Users\alexis\Documents\alexis-cv.pdf', SINGLE_BLOB) as Pdf))
