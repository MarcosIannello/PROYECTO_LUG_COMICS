use facultad
-- ================================================
-- template generated from template explorer using:
-- create procedure (new menu).sql
--
-- use the specify values for template parameters 
-- command (ctrl-shift-m) to fill in the parameter 
-- values below.
--
-- this block of comments will not be included in
-- the definition of the procedure.
-- ================================================
set ansi_nulls on
go
set quoted_identifier on
go
-- =============================================
-- author:		<author,,name>
-- create date: <create date,,>
-- description:	<description,,>
-- =============================================
create or alter procedure editar_stock
@id int,
@stock int

as
begin
	
	begin try 
		begin tran tran_editar_stock

			update proyectolug.comics
			set stock = @stock
			where id = @id

		commit tran tran_editar_stock
	
	end try
	begin catch
		
		rollback tran tran_editar_stock
		select 'error al editar stock'
		
	end catch

end
go
