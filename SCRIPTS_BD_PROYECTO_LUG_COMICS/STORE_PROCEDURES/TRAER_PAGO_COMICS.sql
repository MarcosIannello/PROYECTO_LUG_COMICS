use facultad 

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE TRAER_PAGOS_COMICS
@idUsuario int = null

AS
BEGIN
	
	if(@idUsuario is null)
		select * from ProyectoLUG.PagoComic
	else
		select * from ProyectoLUG.PagoComic where idUsuario = @idUsuario
END
GO
