CREATE PROC AgregarEditarCliente
@id_cliente int,
@nombres varchar(25),
@apellidos varchar(25),
@fecha_registro date,
@sexo varchar(1),
@region varchar(25)
AS

IF @id_cliente = 0
	INSERT INTO cliente(nombres,apellidos,fecha_registro,sexo,region)
	VALUES (@nombres,@apellidos,@fecha_registro,@sexo,@region)
ELSE
	UPDATE cliente
	SET
	nombres = @nombres,
	apellidos = @apellidos,
	fecha_registro = @fecha_registro,
	region = @region
WHERE id_cliente = @id_cliente