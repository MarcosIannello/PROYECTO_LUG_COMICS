USE FACULTAD

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE or alter  PROCEDURE CREAR_PAGO_COMIC
@idPago int,
@domicilio int,
@tipoTarjeta varchar(max),
@numTarjeta varchar(max),
@importe int

AS
BEGIN

	BEGIN TRY 
		BEGIN TRAN INSERTAR_PAGO_COMIC
			
			DECLARE @fecha nvarchar(max) = CONVERT(nvarchar(max), GETDATE(), 121);

			insert into ProyectoLUG.PagoComic
			VALUES(@idPago,@domicilio,@tipoTarjeta,@numTarjeta,@importe,@fecha)


		COMMIT TRAN INSERTAR_PAGO_COMIC
	END TRY

	BEGIN CATCH 
		ROLLBACK TRAN INSERTAR_PAGO_COMIC
		SELECT 'ERROR AL INSERTAR PAGO'
	END CATCH
END
GO
