CREATE PROC VerEmpleadoPorId
@id_cliente int
AS
	SELECT *
	FROM cliente
	WHERE id_cliente = @id_cliente