Use Pixelia
CREATE TABLE Genero (
  id_genero            INT NOT NULL ,
  nombre_genero        VARCHAR(20) NOT NULL,
  CONSTRAINT PK_GENERO PRIMARY KEY(id_genero)
) 

CREATE TABLE Editor (
  id_Editor            INT NOT NULL,
  nombre_Editor        VARCHAR(50) NOT NULL,
  CONSTRAINT PK_Editor PRIMARY KEY(id_Editor)
) 

CREATE TABLE Idioma (
  id_idioma             INT  NOT NULL,
  nombre_idioma         VARCHAR(30) NOT NULL,
  subtitulo      VARCHAR(30),
  CONSTRAINT PK_IDIOMA PRIMARY KEY(id_idioma)
) 

CREATE TABLE Desarolladora (
  id_desarrollador INT NOT NULL,
  nombre_desarrollador VARCHAR(50) NOT NULL,
  CONSTRAINT PK_DESARROLLADOR PRIMARY KEY(id_desarrollador)
) 

CREATE TABLE Videojuego
(
  id_videojuego        INT NOT NULL ,
  nombre               VARCHAR(50) NOT NULL ,
  precio               decimal(6,2) NULL ,
  fecha_lanzamiento    DATE NOT NULL ,
  id_desarrollador     INT NOT NULL ,
  id_Editor            INT NOT NULL ,
  trailer              VARCHAR(30) NULL ,
  sinopsis             VARCHAR(150) NOT NULL ,
  clasificacion        VARCHAR(4) NULL,
  id_idioma            INT NOT NULL,
  CONSTRAINT PK_VIDEOJUEGO PRIMARY KEY(id_videojuego),
  CONSTRAINT FK_VIDEOJUEGO_DESARROLLADOR FOREIGN KEY (id_desarrollador) 
    REFERENCES Desarolladora(id_desarrollador),
  CONSTRAINT FK_VIDEOJUEGO_Editor FOREIGN KEY (id_Editor) 
    REFERENCES Editor(id_Editor),
  CONSTRAINT FK_VIDEOJUEGO_IDIOMA FOREIGN KEY (id_idioma)
    REFERENCES Idioma(id_idioma)
) 

CREATE TABLE Videojuego_genero
(
  id_videojuego        INT NOT NULL ,
  id_genero            INT NOT NULL,
  CONSTRAINT PK_VIDEOJUEGO_GENERO PRIMARY KEY (id_videojuego,id_genero),
  CONSTRAINT FK_VIDEOGENERO_VIDEOJUEGO FOREIGN KEY (id_videojuego) 
    REFERENCES Videojuego(id_videojuego),
  CONSTRAINT FK_VIDEOGENERO_GENERO FOREIGN KEY (id_genero) 
    REFERENCES Genero(id_genero)
) 

CREATE TABLE Facturas(
	num_factura int NOT NULL PRIMARY KEY,
	total decimal(9, 2) NOT NULL,
	iva decimal(9, 2) NOT NULL,
	fecha_fact date NOT NULL,
	id_cliente int NOT NULL,
);
CREATE TABLE departamento
(
id_departamento int primary key   not null,
Departamento nvarchar(30)
)
CREATE TABLE tienda
(
id_tienda			int	 	primary key   not null,
Nombre_tienda		nvarchar(25),
Direccion			nvarchar(25),
Telefono			varchar(8),
Capacidad			nvarchar(10),
id_departamento		int

foreign key  (id_departamento)
references   departamento     (id_departamento)
)

CREATE TABLE empleado
(
id_empleado		int			primary key  not null,
Nombres			varchar(35),
Apellidos		varchar(35),
Fecha_alta		date,
Salario_base	FLOAT,
id_tienda		int,
id_departamento      int, 


foreign key (id_tienda)
references   tienda   (id_tienda),
foreign key (id_departamento)
references   departamento   (id_departamento)
)

CREATE TABLE usuarios (
  Nombre_user VARCHAR(35) PRIMARY KEY NOT NULL,
  passcode VARCHAR(35) NOT NULL
);
CREATE TABLE Clientes (
  id_cliente INT PRIMARY KEY,
  nombre_cli VARCHAR(25) NOT NULL,
  dir_cli VARCHAR(22) NOT NULL,
  tel_cli VARCHAR(10) NULL,
  fecha_nac DATE NULL,
  Nombre_user VARCHAR(35), -- Esta columna se utilizará como clave externa para relacionar usuarios y clientes
  FOREIGN KEY (Nombre_user) REFERENCES usuarios(Nombre_user)
);


INSERT INTO departamento (id_departamento, departamento)
VALUES (1, 'Administracion');

INSERT INTO departamento (id_departamento, departamento)
VALUES (2, 'Ventas');

INSERT INTO departamento (id_departamento, departamento)
VALUES (3, 'Marketing');

INSERT INTO departamento (id_departamento, departamento)
VALUES (4, 'Ingenieria');


INSERT INTO tienda (id_tienda, Nombre_tienda, Direccion, Telefono, Capacidad, id_departamento)
VALUES (1, 'Matriz', 'Quito', '23457887', '10', 1);


INSERT INTO empleado (id_empleado, Nombres, Apellidos, Fecha_alta, Salario_base, id_tienda, id_departamento)
VALUES (1, 'Damian', 'Paige', '2023-08-30', 900.00, 1, 1);

INSERT INTO empleado (id_empleado, Nombres, Apellidos, Fecha_alta, Salario_base, id_tienda, id_departamento)
VALUES (2, 'Pepe', 'Alvares', '2023-08-30', 400.00, 1, 2);

INSERT INTO empleado (id_empleado, Nombres, Apellidos, Fecha_alta, Salario_base, id_tienda, id_departamento)
VALUES (3, 'Jose', 'Ritz', '2023-08-30', 900.00, 1, 3);

INSERT INTO empleado (id_empleado, Nombres, Apellidos, Fecha_alta, Salario_base, id_tienda, id_departamento)
VALUES (4, 'Alvaro', 'Alvares', '2023-08-30', 500.00, 1, 4);





INSERT INTO Desarolladora VALUES(001,'Rockstar North');
INSERT INTO Desarolladora VALUES(002,'FromSoftware Inc');
INSERT INTO Desarolladora VALUES(003,'SEGA');
INSERT INTO Desarolladora VALUES(004,'DICE');
INSERT INTO Desarolladora VALUES(005,'Tango Gameworks');
INSERT INTO Desarolladora VALUES(006,'Team Cherry');
INSERT INTO Desarolladora VALUES(007,'Riot Games');

INSERT INTO Genero VALUES(001,'Mundo Abierto');
INSERT INTO Genero VALUES(002,'Acción');
INSERT INTO Genero VALUES(003,'Multijugador');
INSERT INTO Genero VALUES(004,'Arcade');
INSERT INTO Genero VALUES(005,'Aventura');
INSERT INTO Genero VALUES(006,'Sobrenatural');

INSERT INTO Editor VALUES(001,'Bandai Namco');
INSERT INTO Editor VALUES(002,'Rockstar Games');
INSERT INTO Editor VALUES(003,'Activision');
INSERT INTO Editor VALUES(004,'SEGA');
INSERT INTO Editor VALUES(005,'Electronic Arts');
INSERT INTO Editor VALUES(006,'Bethesda Softworks');
INSERT INTO Editor VALUES(007,'Team Cherry');
INSERT INTO Editor VALUES(008,'Riot Games');

INSERT INTO Idioma VALUES(01,'Ingles','Esp,Fr');
INSERT INTO Idioma VALUES(02,'Español','all');
INSERT INTO Idioma VALUES(03,'Japones','all');
INSERT INTO Idioma VALUES(04,'Chino','all');
INSERT INTO Idioma VALUES(05,'Coreano','none');
INSERT INTO Idioma VALUES(06,'Frances','Esp,eng');
INSERT INTO Idioma VALUES(07,'Italiano','all');

INSERT INTO Videojuego VALUES(1,'Grand Theft Auto V',445.69,CAST('2015-04-14' AS Date),001,002,'GTA5.jpg','Grand Theft Auto V para PC ofrece a los jugadores la opción de explorar el galardonado mundo de Los Santos y el condado de Blaine','M17',01);
INSERT INTO Videojuego VALUES(2,'Elden Ring',1200.00,CAST('2024-02-22' AS Date),002,001,'eldenring.mp4','EL NUEVO JUEGO DE ROL Y ACCIÓN DE AMBIENTACIÓN FANTÁSTICA','M17',02);
INSERT INTO Videojuego VALUES(3,'Sekiro: ShadowsDie Twice',1200.00,CAST('2019-03-21' AS Date),002,003,'sekiro.mp4','Véngate. Restituye tu honor. Mata con ingenio.','M17',03);
INSERT INTO Videojuego VALUES(4,'Hatsune Miku: Project DIVA Mega Mix+',499.00,CAST('2022-05-22' AS Date),004,003,'miku.mp4','Disfruta de la gira definitiva de Hatsune Miku.','M17',03);
INSERT INTO Videojuego VALUES(5,'STAR WARS Battlefront',439.00,CAST('2015-11-16' AS Date),004,005,'swbattle.jpg','La Ed. Ultimate de STAR WARS Battlefront incluye la Ed. Deluxe de STAR WARS Battlefront además del pase de temporada de STAR WARS Battlefront','T',06);
INSERT INTO Videojuego VALUES(6,'Ghostwire: Tokyo',1079.00,CAST('2022-02-24' AS Date),005,006,'ghost.jpg','La población de Tokio ha desaparecido y unas mortíferas fuerzas sobrenaturales merodean por las calles. ','M17',04);
INSERT INTO Videojuego VALUES(7,'League OF Legends',10.00,CAST('2010-10-09' AS Date),007,008,'lol.jpg','Grieta del invocador','M10',01);


INSERT INTO Videojuego_genero VALUES(1,001);
INSERT INTO Videojuego_genero VALUES(1,002);
INSERT INTO Videojuego_genero VALUES(2,001);
INSERT INTO Videojuego_genero VALUES(2,002);
INSERT INTO Videojuego_genero VALUES(3,001);
INSERT INTO Videojuego_genero VALUES(3,002);
INSERT INTO Videojuego_genero VALUES(4,004);
INSERT INTO Videojuego_genero VALUES(5,002);
INSERT INTO Videojuego_genero VALUES(5,003);
INSERT INTO Videojuego_genero VALUES(6,005);
INSERT INTO Videojuego_genero VALUES(6,006);
INSERT INTO Videojuego_genero VALUES(7,002);

INSERT INTO usuarios (Nombre_user, passcode) VALUES ('admin1', 'admin1');
INSERT INTO usuarios (Nombre_user, passcode) VALUES ('vero', 'vero');
INSERT INTO usuarios (Nombre_user, passcode) VALUES ('fabri', 'fabri');
INSERT INTO usuarios (Nombre_user, passcode) VALUES ('silva', 'silva');
INSERT INTO usuarios (Nombre_user, passcode) VALUES ('cesar', 'cesar');
INSERT INTO usuarios (Nombre_user, passcode) VALUES ('pablo', 'pablo');
INSERT INTO usuarios (Nombre_user, passcode) VALUES ('kath', 'kath');
INSERT INTO usuarios (Nombre_user, passcode) VALUES ('jess', 'jess');
INSERT INTO usuarios (Nombre_user, passcode) VALUES ('jesy', 'jesy');
INSERT INTO usuarios (Nombre_user, passcode) VALUES ('lucy', 'lucy');
INSERT INTO usuarios (Nombre_user, passcode) VALUES ('nancy', 'nancy');


INSERT INTO Clientes ([id_cliente], [nombre_cli], [dir_cli], [tel_cli], [fecha_nac],[Nombre_user]) VALUES (1, N'Verònica Còrdova', N'18 de noviembre', N'0996558715', CAST(N'1989-07-15' AS Date),'vero');
INSERT INTO Clientes ([id_cliente], [nombre_cli], [dir_cli], [tel_cli], [fecha_nac],[Nombre_user]) VALUES (2, N'Fabricio Pèrez', N'Shyris ', N'0975823558', CAST(N'1994-02-15' AS Date),'fabri');
INSERT INTO Clientes ([id_cliente], [nombre_cli], [dir_cli], [tel_cli], [fecha_nac],[Nombre_user]) VALUES (3, N'Silvana Jimènez', N'Maximiliano Rodrìguez', N'0995763221', CAST(N'1997-11-18' AS Date),'silva');
INSERT INTO Clientes ([id_cliente], [nombre_cli], [dir_cli], [tel_cli], [fecha_nac],[Nombre_user]) VALUES (4, N'Cèsar Catillo', N'Colòn', N'0992351478', CAST(N'1992-03-10' AS Date),'cesar');
INSERT INTO Clientes ([id_cliente], [nombre_cli], [dir_cli], [tel_cli], [fecha_nac],[Nombre_user]) VALUES (5, N'Pablo Aguilar', N'Acacias', N'0951396578', CAST(N'1970-12-23' AS Date),'pablo');
INSERT INTO Clientes ([id_cliente], [nombre_cli], [dir_cli], [tel_cli], [fecha_nac],[Nombre_user]) VALUES (6, N'Katherine Àvila', N'Rìo Bobonaza', N'0965147896', CAST(N'1969-05-19' AS Date),'kath');
INSERT INTO Clientes ([id_cliente], [nombre_cli], [dir_cli], [tel_cli], [fecha_nac],[Nombre_user]) VALUES (7, N'Jesika Tamayo', N'Eloy Alfaro', N'0985632148', CAST(N'1991-11-03' AS Date),'jess');
INSERT INTO Clientes ([id_cliente], [nombre_cli], [dir_cli], [tel_cli], [fecha_nac],[Nombre_user]) VALUES (8, N'jesika gonzalez', N'San Pedro', N'0978512369', CAST(N'1993-12-07' AS Date),'jesy');
INSERT INTO Clientes ([id_cliente], [nombre_cli], [dir_cli], [tel_cli], [fecha_nac],[Nombre_user]) VALUES (9, N'Lucrecia Calvas', N'Solanda', N'0997512369', CAST(N'1958-04-28' AS Date),'lucy');
INSERT INTO Clientes ([id_cliente], [nombre_cli], [dir_cli], [tel_cli], [fecha_nac],[Nombre_user]) VALUES (10, N'Nancy Erazo', N'Ciudadela Zamora', N'0995478962', CAST(N'1986-07-21' AS Date),'nancy');


INSERT INTO Facturas ([num_factura], [total], [iva], [fecha_fact], [id_cliente]) VALUES (1, CAST(20.00 AS Decimal(9, 2)), CAST(2.40 AS Decimal(9, 2)), CAST(N'2021-02-16' AS Date), 1);
INSERT INTO Facturas ([num_factura], [total], [iva], [fecha_fact], [id_cliente]) VALUES (2, CAST(55.00 AS Decimal(9, 2)), CAST(6.60 AS Decimal(9, 2)), CAST(N'2020-07-18' AS Date), 1);
INSERT INTO Facturas ([num_factura], [total], [iva], [fecha_fact], [id_cliente]) VALUES (3, CAST(80.00 AS Decimal(9, 2)), CAST(9.60 AS Decimal(9, 2)), CAST(N'2021-01-10' AS Date), 1);
INSERT INTO Facturas ([num_factura], [total], [iva], [fecha_fact], [id_cliente]) VALUES (4, CAST(10.00 AS Decimal(9, 2)), CAST(1.20 AS Decimal(9, 2)), CAST(N'2020-04-09' AS Date), 2);
INSERT INTO Facturas ([num_factura], [total], [iva], [fecha_fact], [id_cliente]) VALUES (5, CAST(450.00 AS Decimal(9, 2)), CAST(54.00 AS Decimal(9, 2)), CAST(N'2020-09-01' AS Date), 2);
INSERT INTO Facturas ([num_factura], [total], [iva], [fecha_fact], [id_cliente]) VALUES (6, CAST(1000.00 AS Decimal(9, 2)), CAST(120.00 AS Decimal(9, 2)), CAST(N'2021-03-08' AS Date), 3);
INSERT INTO Facturas ([num_factura], [total], [iva], [fecha_fact], [id_cliente]) VALUES (7, CAST(335.00 AS Decimal(9, 2)), CAST(40.20 AS Decimal(9, 2)), CAST(N'2020-01-02' AS Date), 4);
INSERT INTO Facturas ([num_factura], [total], [iva], [fecha_fact], [id_cliente]) VALUES (9, CAST(98.00 AS Decimal(9, 2)), CAST(11.76 AS Decimal(9, 2)), CAST(N'2021-03-19' AS Date), 6);
INSERT INTO Facturas ([num_factura], [total], [iva], [fecha_fact], [id_cliente]) VALUES (10, CAST(80.00 AS Decimal(9, 2)), CAST(9.60 AS Decimal(9, 2)), CAST(N'2020-12-23' AS Date), 7);
INSERT INTO Facturas ([num_factura], [total], [iva], [fecha_fact], [id_cliente]) VALUES (11, CAST(400.00 AS Decimal(9, 2)), CAST(48.00 AS Decimal(9, 2)), CAST(N'2021-01-11' AS Date), 8);
INSERT INTO Facturas ([num_factura], [total], [iva], [fecha_fact], [id_cliente]) VALUES (12, CAST(189.00 AS Decimal(9, 2)), CAST(22.68 AS Decimal(9, 2)), CAST(N'2020-12-30' AS Date), 9);
INSERT INTO Facturas ([num_factura], [total], [iva], [fecha_fact], [id_cliente]) VALUES (13, CAST(75.00 AS Decimal(9, 2)), CAST(9.00 AS Decimal(9, 2)), CAST(N'2020-07-18' AS Date), 10);


CREATE TABLE Archivo(

  id_videojuego int,
  id2 UNIQUEIDENTIFIER ROWGUIDCOL not NULL UNIQUE,
  Nombre VARCHAR(255),
  Contenido varbinary(max) FILESTREAM,
  extension char(4),
  
  FOREIGN KEY (id_videojuego) REFERENCES Videojuego(id_videojuego)

)


INSERT INTO Archivo(id_videojuego,id2,Nombre,Contenido,extension)
select 1, NEWID(),'gtav',BULKCOLUMN,'jpeg'
from OPENROWSET(BULK N'c:\Users\Alech\Downloads\gtav.jpeg',single_blob) AS img

exec sp_configure filestream_access_level, 2
reconfigure
