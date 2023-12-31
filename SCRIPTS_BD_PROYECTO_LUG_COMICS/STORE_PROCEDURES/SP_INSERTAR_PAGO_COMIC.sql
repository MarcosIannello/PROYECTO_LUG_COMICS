USE [FACULTAD]
GO
/****** Object:  StoredProcedure [dbo].[CREAR_PAGO_COMIC]    Script Date: 29/11/2023 0:04:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
ALTER PROCEDURE [dbo].[CREAR_PAGO_COMIC]
@idPago int,
@domicilio nvarchar(max),
@tipoTarjeta varchar(max),
@numTarjeta varchar(max),
@importe int,
@id_usuario int

AS
BEGIN

	BEGIN TRY 
		BEGIN TRAN INSERTAR_PAGO_COMIC
			
			DECLARE @fecha nvarchar(max) = CONVERT(nvarchar(max), GETDATE(), 121);

			insert into ProyectoLUG.PagoComic(idPago,domicilio,tipoTarjeta,numTarjeta,importe,Fecha,idUsuario)
			VALUES(@idPago,@domicilio,@tipoTarjeta,@numTarjeta,@importe,@fecha, @id_usuario)


		COMMIT TRAN INSERTAR_PAGO_COMIC
	END TRY

	BEGIN CATCH 
		ROLLBACK TRAN INSERTAR_PAGO_COMIC
		SELECT 'ERROR AL INSERTAR PAGO'
	END CATCH
END


select * from ProyectoLUG.Usuarios

select * from ProyectoLUG.Permiso_Usuario