USE [FACULTAD]

GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE or alter PROCEDURE INSERTAR_COMIC
@ID int,
@Titulo nvarchar(50),
@Categoria nvarchar(50),
@Editorial nvarchar(50),
@Descripcion nvarchar(50),
@Precio float,
@Portada nvarchar(MAX) = null,
@Stock int

AS BEGIN
	 BEGIN TRAN TRAN_INSERTAR_COMIC
		BEGIN TRY
			INSERT INTO ProyectoLUG.Comics (ID, Titulo, Categoria, Editorial, Descripcion, Precio, Portada, Stock )
			Values (@ID,@Titulo, @Categoria, @Editorial, @Descripcion, @Precio, @Portada, @Stock)
			COMMIT TRAN TRAN_INSERTAR_COMIC
		END TRY
		BEGIN CATCH
			ROLLBACK TRAN TRAN_INSERTAR_COMIC
		END CATCH
END
