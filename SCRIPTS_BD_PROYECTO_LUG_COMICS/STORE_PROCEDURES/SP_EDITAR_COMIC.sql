
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE OR ALTER PROCEDURE EDITAR_COMIC
@ID int,
@Titulo nvarchar(50),
@Categoria nvarchar(50),
@Editorial nvarchar(50),
@Descripcion nvarchar(50),
@Precio float,
@Portada nvarchar(max),
@Stock int


AS
BEGIN TRY
	BEGIN TRAN TRAN_EDITAR_COMIC
		UPDATE ProyectoLUG.Comics
        SET
            Titulo = @Titulo,
            Categoria = @Categoria,
            Editorial = @Editorial,
            Descripcion = @Descripcion,
            Precio = @Precio,
            Portada = @Portada,
            Stock = @Stock
        WHERE ID = @ID;
		COMMIT TRAN TRAN_EDITAR_COMIC
	END TRY
	BEGIN CATCH
		ROLLBACK TRAN TRAN_EDITAR_COMIC
	END CATCH

