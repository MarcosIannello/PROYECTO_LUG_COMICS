use FACULTAD
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE INSERTAR_USUARIO_LOGUEADO
@ID INT,
@NOMBRE NVARCHAR (50),
@IDPERMISO INT
AS
BEGIN
	INSERT INTO ProyectoLUG.Usuario_Logueado
	VALUES (@ID, @NOMBRE, @IDPERMISO)
END
GO
