-- Creación de la base de datos
CREATE DATABASE Tienda;
USE Tienda;
GO

-- Uso de la base de datos
USE Tienda;
GO

-- Creación de la tabla Productos
CREATE TABLE Productos (
    IdProducto INT IDENTITY(1,1) PRIMARY KEY, -- Identificador único del producto
    Nombre NVARCHAR(100) NOT NULL,           -- Nombre del producto
    Precio DECIMAL(10,2) NOT NULL,           -- Precio del producto
    Stock INT NOT NULL,                      -- Cantidad en stock
    FechaCreacion DATETIME DEFAULT GETDATE() -- Fecha de creación del producto
);
GO

-- Validar la estructura de la tabla
SELECT * FROM Productos;

CREATE PROCEDURE USP_BuscarProductoxID
@idprod INT
AS
BEGIN
	SELECT *
    FROM Productos
    WHERE IdProducto = @idprod;
END;

alter PROCEDURE USP_InsertarProducto
@nombre NVARCHAR(100),
@precio DECIMAL(10,2),
@stock INT
AS
BEGIN
	INSERT INTO Productos (Nombre, Precio, Stock)
    VALUES (@nombre, @precio, @stock);
END;

CREATE PROCEDURE USP_EliminarProductoxID
@idprod INT
AS
BEGIN
	DELETE FROM Productos
    WHERE IdProducto = @idprod;
END;

CREATE PROCEDURE USP_ActualizarProductoxID
	@idprod INT,
    @nombre NVARCHAR(100),
    @precio DECIMAL(10,2),
    @stock INT,
    @fecha DATETIME
AS
BEGIN
	UPDATE Productos
    SET 
        Nombre = @nombre,
        Precio = @precio,
        Stock = @stock,
        FechaCreacion = @fecha
    WHERE IdProducto = @idprod;
END;