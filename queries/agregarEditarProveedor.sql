CREATE PROC AddEditProv
@idProveedor int,
@nombre nchar(15),
@apellidos nchar(15),
@sexo char(1),
@empresa nchar(15),
@fechaEntrega date
AS

IF @idProveedor = 0
	INSERT INTO Proveedores(nombre,apellidos,sexo,empresa,fechaEntrega)
	VALUES (@nombre,@apellidos,@sexo,@empresa,@fechaEntrega)
ELSE
	UPDATE Proveedores
	SET
	nombre = @nombre,
	apellidos = @apellidos,
	sexo = @sexo,
	empresa = @empresa,
	fechaEntrega = @fechaEntrega
WHERE idProveedor = @idProveedor