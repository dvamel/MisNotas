create database MisNotas;
go
use  MisNotas;
go

create TABLE Categoria (Id INT identity(1,1) Primary key,Nombre VARCHAR(200), IncluirEnListados bit   )

GO


create TABLE TiposPersona (Id INT identity(1,1) Primary key,Nombre VARCHAR(200), Codigo VARCHAR(50), Visible bit, CategoriaId int null  ,constraint fk_Categoria_TiposPersona foreign key (CategoriaId) references Categoria (Id))

GO

create TABLE Estados (Id INT identity(1,1) Primary key,Nombre VARCHAR(200), Codigo VARCHAR(50) ,Visible bit, CategoriaId int null,constraint fk_Categoria_Estados foreign key (CategoriaId) references Categoria (Id)  )

GO

create TABLE TiposDeAdjuntos (Id INT identity(1,1) Primary key,Nombre VARCHAR(200), Codigo VARCHAR(50),Visible bit, CategoriaId int null,constraint fk_Categoria_TiposDeAdjuntos foreign key (CategoriaId) references Categoria (Id)   )

GO

create TABLE TiposDeQuerys (Id INT identity(1,1) Primary key,Nombre VARCHAR(200), Codigo VARCHAR(50),Visible bit, CategoriaId int null,constraint fk_Categoria_TiposDeQuerys foreign key (CategoriaId) references Categoria (Id)   )

GO

create TABLE TiposDePendientes (Id INT identity(1,1) Primary key,Nombre VARCHAR(200), Codigo VARCHAR(50),Visible bit, CategoriaId int null ,constraint fk_Categoria_TiposDePendientes foreign key (CategoriaId) references Categoria (Id)  )

GO


CREATE TABLE Personas (
Id INT identity(1,1) Primary key,
TipoId INT NOT NULL ,
EstadoId INT NOT NULL,
Nombre VARCHAR(50)  NOT Null,
Observaciones VARCHAR(1000) NULL,
NombreUsuario VARCHAR(20) NULL,
Password VARCHAR(max) null,
Activo bit NULL,
Correo VARCHAR(200) NULL,
constraint fk_Tipo_Personas foreign key (TipoId) references TiposPersona (Id),
constraint fk_Estado_Personas foreign key (EstadoId) references Estados (Id)
)

GO 


CREATE TABLE Clientes (PersonaId INT primary key,
DetalleTecnico VARCHAR(max) null,
Aplicaciones  VARCHAR(max) null,
Contactos  VARCHAR(max) null
)



go 

CREATE TABLE Pendientes(Id INT identity(1,1) Primary key, 
Nombre VARCHAR(100)  NOT null,
EstadoId INT NOT NULL, 
Fecha DATE NOT null,
HoraDeEntrega time null,
FechaEntrega DATE NOT null,
Observaciones VARCHAR(max) NOT null,
TipoDePendienteId int NOT null,
constraint fk_Estado_Pendientes foreign key (EstadoId) references Estados (Id),
constraint fk_Tipos_Pendientes foreign key (TipoDePendienteId) references TiposDePendientes (Id)
)

go 

CREATE TABLE Adjuntos (Id INT identity(1,1) Primary key,
Nombre VARCHAR(100) NOT null, 
Ruta VARCHAR(max) NOT null, 
Fecha DATE NOT null,
Observaciones VARCHAR(1000),
TipoDeAjuntoId int,
Documento varbinary(max),
constraint fk_Tipos_Adjuntos foreign key (TipoDeAjuntoId) references TiposDeAdjuntos (Id),
)

GO

CREATE TABLE AdjuntosRelacionados (Id INT identity(1,1) Primary key,
AdjuntoId int,
RelacionId INT ,
constraint fk_Adjuntos_AdjuntosRelacionados foreign key (AdjuntoId) references Adjuntos (Id)
)

GO

CREATE TABLE Querys (
Id INT identity(1,1) Primary key,
Nombre VARCHAR(100) NOT null, 
Observaciones VARCHAR(MAX) NOT NULL ,
PersonaCreadoraId INT NOT null,
EstadoId INT NOT null,
DetalleTecnico VARCHAR (1000) null,
Aplicaciones  VARCHAR(1000) null,
TipoDeQueryId int,
constraint fk_Estado_Querys foreign key (EstadoId) references Estados (Id),
constraint fk_Persona_Querys foreign key (PersonaCreadoraId) references Personas (Id),
constraint fk_Tipos_Querys foreign key (TipoDeQueryId) references TiposDeQuerys (Id)
)

go

CREATE TABLE QuerysRelacionados (Id INT identity(1,1) Primary key,
QueryId int,
RelacionId INT ,
constraint fk_Querys_QuerysRelacionados foreign key (QueryId) references Querys (Id)
)

GO


create index idx_personas ON Personas (Nombre desc, Observaciones desc)
create index idx_pendientes ON Pendientes (Nombre desc)
create index idx_adjuntos ON Adjuntos (Nombre desc)
create index idx_querys ON Adjuntos (Nombre desc)


