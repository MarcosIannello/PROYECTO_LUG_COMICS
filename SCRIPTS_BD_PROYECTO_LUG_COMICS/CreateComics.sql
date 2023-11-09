use FACULTAD
CREATE TABLE [ProyectoLUG].Comics (
    ID int PRIMARY KEY NOT NULL,
    Titulo nvarchar(50) NOT NULL,
    Categoria nvarchar(50) NOT NULL,
    Editorial nvarchar(50) NOT NULL,
    Descripcion nvarchar(50),
    Precio float NOT NULL,
    Portada nvarchar(MAX) NULL,
    Stock int
)

