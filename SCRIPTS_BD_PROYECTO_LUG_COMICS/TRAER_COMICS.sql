USE [FACULTAD]
GO
/****** Object:  StoredProcedure [dbo].[TRAER_COMICS]    Script Date: 31/10/2023 01:10:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[TRAER_COMICS]
@ID INT = NULL
AS
BEGIN
	IF @ID IS NULL
		select * from ProyectoLUG.Comics
	END

