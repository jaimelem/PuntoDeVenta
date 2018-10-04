CREATE PROC BorrarEmpleadoPorId
@id_cliente int
AS
	DELETE FROM cliente
	WHERE id_cliente = @id_cliente