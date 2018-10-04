INSERT INTO Proveedores(nombre,apellidos,sexo,empresa,fechaEntrega) 
VALUES('Mario','Aburto','M','PEPSICO','2018-10-03') 

INSERT INTO Productos (nombre,unidad,precio,codigo,idProveedor) 
VALUES('Fanta','600ML','13.00',7896542,1) 

SELECT * FROM Proveedores

SELECT * FROM Productos

ALTER TABLE Productos
ADD
CONSTRAINT FK_Marca FOREIGN KEY (idProveedor) REFERENCES Proveedores (idProveedor)

SELECT Productos.nombre, Proveedores.empresa
FROM Productos INNER JOIN Proveedores ON Productos.idProducto = Proveedores.idProveedor

DELETE FROM Productos WHERE idProducto = 6