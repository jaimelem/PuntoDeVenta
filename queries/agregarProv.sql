USE [puntoVentaTony]
GO
/****** Object:  StoredProcedure [dbo].[AddEditProv]    Script Date: 04/10/2018 04:05:03 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROC [dbo].[AddEditProv]
@nombre nchar(15),
@apellidos nchar(15),
@empresa nchar(15),
@fechaEntrega date
AS

/*IF @idProveedor = 0*/
BEGIN
	INSERT INTO Proveedores(nombre,apellidos,empresa,fechaEntrega)
	VALUES (@nombre,@apellidos,@empresa,@fechaEntrega)
END