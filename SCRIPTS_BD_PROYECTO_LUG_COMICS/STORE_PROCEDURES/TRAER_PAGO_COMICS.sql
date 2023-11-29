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
CREATE or alter PROCEDURE TRAER_PAGOS_COMICS
@idUsuario int = null

AS
BEGIN
	
	if @idUsuario is null
	begin 
		select * from ProyectoLUG.PagoComic
	end
	else
	begin
		select * from ProyectoLUG.PagoComic where idUsuario = @idUsuario
	end

END
GO

--select * from ProyectoLUG.Usuarios where idUsuario = 144463912

