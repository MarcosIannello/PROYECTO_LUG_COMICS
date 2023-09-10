CREATE SCHEMA ProyectoLUG
GO

CREATE TABLE ProyectoLUG.Usuarios (
  idUsuario int PRIMARY KEY not null,
  nombreUsuario nvarchar(50) not null,
  [password] nvarchar(50) not null
)
GO

CREATE TABLE ProyectoLUG.Permiso_Usuario (
  idPermisoUsuario int PRIMARY KEY not null,
  idUsuario int not null,
  idPermiso int not null
)
GO

CREATE TABLE [ProyectoLUG].[Permisos] (
  [idPermiso] int PRIMARY KEY not null,
  [nombrePermiso] nvarchar(50) not null
)
GO

CREATE TABLE [ProyectoLug].[Comic] (
  [idComic] int PRIMARY KEY not null,
  [nombreComic] nvarchar(50) not null,
  [genero] nvarchar(50) not null,
  [empresa] nvarchar(50) not null,
  [descripcion] nvarchar(300) not null
)
GO
