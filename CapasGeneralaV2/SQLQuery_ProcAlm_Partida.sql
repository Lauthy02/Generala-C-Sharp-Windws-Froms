create proc PARTIDA_INSERTAR
@idganador int , @puntos int
as
BEGIN
	insert into Table_Partida values (@idganador,@puntos)
END
go

create proc PARTIDA_BORRAR
@id int
as
BEGIN
	delete from Table_Partida where ID = @id
END
go

create proc PARTIDA_LISTAR
as
BEGIN
	select * from Table_Partida
END
go