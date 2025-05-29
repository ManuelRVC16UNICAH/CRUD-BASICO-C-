CREATE DATABASE PerrosDB;
GO

USE PerrosDB;
GO

CREATE TABLE Perros (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    Nombre NVARCHAR(100),
    Raza NVARCHAR(50),
    Edad INT,
    Vacunas NVARCHAR(255)
);

-- Agregar
CREATE PROCEDURE sp_AgregarPerro
    @Nombre NVARCHAR(100),
    @Raza NVARCHAR(50),
    @Edad INT,
    @Vacunas NVARCHAR(255)
AS
BEGIN
    INSERT INTO Perros (Nombre, Raza, Edad, Vacunas)
    VALUES (@Nombre, @Raza, @Edad, @Vacunas);
END

-- Editar
CREATE PROCEDURE sp_EditarPerro
    @Id INT,
    @Nombre NVARCHAR(100),
    @Raza NVARCHAR(50),
    @Edad INT,
    @Vacunas NVARCHAR(255)
AS
BEGIN
    UPDATE Perros
    SET Nombre = @Nombre, Raza = @Raza, Edad = @Edad, Vacunas = @Vacunas
    WHERE Id = @Id;
END

-- Eliminar
CREATE PROCEDURE sp_EliminarPerro
    @Id INT
AS
BEGIN
    DELETE FROM Perros WHERE Id = @Id;
END

-- Buscar por nombre
CREATE PROCEDURE sp_BuscarPerro
    @Nombre NVARCHAR(100)
AS
BEGIN
    SELECT * FROM Perros WHERE Nombre LIKE '%' + @Nombre + '%';
END

-- Listar todos
CREATE PROCEDURE sp_ListarPerros
AS
BEGIN
    SELECT * FROM Perros;
END


select *from Perros;