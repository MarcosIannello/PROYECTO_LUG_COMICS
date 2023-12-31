USE [FACULTAD]
GO
/****** Object:  StoredProcedure [dbo].[INSERTAR_USUARIO]    Script Date: 28/11/2023 23:33:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

ALTER   PROCEDURE [dbo].[INSERTAR_USUARIO]
@ID int,
@NOMBRE_COMPLETO nvarchar(max),
@Edad int

AS
BEGIN
	BEGIN TRANSACTION INSERTAR_USUARIO
		BEGIN TRY
			BEGIN 
				insert into FACULTAD..USUARIOS
				VALUES(@ID, @NOMBRE_COMPLETO,@Edad)

				declare @randomNum int;
				set @randomNum = CAST(RAND()*1000000 as int)

				insert into ProyectoLUG.Permiso_Usuario
				values(@randomNum,@ID,2)

				select '1' as Respuesta
			END
		END TRY
		BEGIN CATCH	
			begin
				rollback TRAN INSERTAR_USUARIO
				select '-1' as Respuesta
			end
		end catch
	Commit TRAN INSERTAR_USUARIO

END
