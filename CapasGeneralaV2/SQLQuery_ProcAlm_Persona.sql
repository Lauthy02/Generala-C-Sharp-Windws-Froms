create proc PERSONA_INSERTAR
@nombre varchar(50), @password varchar(50)
as 
BEGIN
	insert into Table_Persona values (@nombre @password)
END
go

create proc PERSONA_BORRAR
@id int
as 
BEGIN
	delete from Table_Persona where ID = @id
END
go

create proc PERSONA_EDITAR
@nombre varchar(50), @id int
as 
BEGIN
	update Table_Persona set NOMBRE = @nombre where ID = @id
END
go

create proc PERSONA_LISTAR
as 
BEGIN
	select * from Table_Persona
END
go

create proc PERSONA_BUSCAR
@nombre varchar(50), @password varchar(50)
as
BEGIN
	select * from Table_Persona where NOMBRE = @nombre and PASSWORD = @password
END
go