/*
    Migración no destructiva para PrimeSystem.

    Requiere que la base haya sido creada con el esquema actual de
    PrimeSystem_DB_Completo.sql (tablas H_Compras, Categoria_Compra,
    Usuario_Tipo, Usuario, Login, etc.).

    No elimina la base ni las tablas. Actualiza roles, remapea usuarios
    según el rol que tenían, agrega los roles faltantes, normaliza las
    categorías de compra, asigna una categoría por defecto a las compras
    sin categoría y recrea la vista V_Compras_Completas.

    Es idempotente: puede ejecutarse más de una vez.
*/

USE PrimeSystem;
GO

SET ANSI_NULLS ON;
SET QUOTED_IDENTIFIER ON;
SET NOCOUNT ON;
SET XACT_ABORT ON;

BEGIN TRY
    BEGIN TRANSACTION;

    -- 1. Asegurar que existan las filas de roles canónicos (IDs 1 a 6).
    --    No se modifican las descripciones todavía para poder remapear
    --    primero a los usuarios según su rol anterior.
    SET IDENTITY_INSERT Usuario_Tipo ON;

    IF NOT EXISTS (SELECT 1 FROM Usuario_Tipo WHERE ID_Usuario_Tipo = 1)
        INSERT INTO Usuario_Tipo (ID_Usuario_Tipo, Tipo, Descripcion)
        VALUES (1, 1, 'Administrador');

    IF NOT EXISTS (SELECT 1 FROM Usuario_Tipo WHERE ID_Usuario_Tipo = 2)
        INSERT INTO Usuario_Tipo (ID_Usuario_Tipo, Tipo, Descripcion)
        VALUES (2, 2, 'Gerente');

    IF NOT EXISTS (SELECT 1 FROM Usuario_Tipo WHERE ID_Usuario_Tipo = 3)
        INSERT INTO Usuario_Tipo (ID_Usuario_Tipo, Tipo, Descripcion)
        VALUES (3, 3, 'Vendedor');

    IF NOT EXISTS (SELECT 1 FROM Usuario_Tipo WHERE ID_Usuario_Tipo = 4)
        INSERT INTO Usuario_Tipo (ID_Usuario_Tipo, Tipo, Descripcion)
        VALUES (4, 4, 'Comprador');

    IF NOT EXISTS (SELECT 1 FROM Usuario_Tipo WHERE ID_Usuario_Tipo = 5)
        INSERT INTO Usuario_Tipo (ID_Usuario_Tipo, Tipo, Descripcion)
        VALUES (5, 5, 'Contador');

    IF NOT EXISTS (SELECT 1 FROM Usuario_Tipo WHERE ID_Usuario_Tipo = 6)
        INSERT INTO Usuario_Tipo (ID_Usuario_Tipo, Tipo, Descripcion)
        VALUES (6, 6, 'Recursos Humanos');

    SET IDENTITY_INSERT Usuario_Tipo OFF;

    -- 2. Remapear usuarios según la descripción de su rol actual.
    --    Esto conserva el permiso que tenían antes de renombrar los roles.
    UPDATE U
    SET ID_Tipo = CASE
        WHEN T.Descripcion LIKE 'Administrador%' THEN 1
        WHEN T.Descripcion LIKE 'Gerente%' OR T.Descripcion LIKE 'Supervisor%' THEN 2
        WHEN T.Descripcion LIKE 'Vendedor%' OR T.Descripcion LIKE 'Empleado%' THEN 3
        WHEN T.Descripcion LIKE 'Comprador%' THEN 4
        WHEN T.Descripcion LIKE 'Contador%' THEN 5
        WHEN T.Descripcion LIKE 'Recursos Humanos%' OR T.Descripcion LIKE 'RRHH%' THEN 6
        ELSE U.ID_Tipo
    END
    FROM Usuario U
    INNER JOIN Usuario_Tipo T ON U.ID_Tipo = T.ID_Usuario_Tipo;

    -- 3. Normalizar los roles canónicos.
    UPDATE Usuario_Tipo SET Tipo = 1, Descripcion = 'Administrador' WHERE ID_Usuario_Tipo = 1;
    UPDATE Usuario_Tipo SET Tipo = 2, Descripcion = 'Gerente' WHERE ID_Usuario_Tipo = 2;
    UPDATE Usuario_Tipo SET Tipo = 3, Descripcion = 'Vendedor' WHERE ID_Usuario_Tipo = 3;
    UPDATE Usuario_Tipo SET Tipo = 4, Descripcion = 'Comprador' WHERE ID_Usuario_Tipo = 4;
    UPDATE Usuario_Tipo SET Tipo = 5, Descripcion = 'Contador' WHERE ID_Usuario_Tipo = 5;
    UPDATE Usuario_Tipo SET Tipo = 6, Descripcion = 'Recursos Humanos' WHERE ID_Usuario_Tipo = 6;

    -- 4. Normalizar las categorías de compra usadas por EstadoContableDAL.
    IF EXISTS (SELECT 1 FROM Categoria_Compra WHERE ID_Categoria = 1)
        UPDATE Categoria_Compra
        SET Nombre = 'Insumos para venta',
            Descripcion = 'Mercadería destinada a la venta',
            Activo = 1
        WHERE ID_Categoria = 1;
    ELSE IF NOT EXISTS (SELECT 1 FROM Categoria_Compra WHERE Codigo = 'CC001')
        INSERT INTO Categoria_Compra (Codigo, Nombre, Descripcion, Activo)
        VALUES ('CC001', 'Insumos para venta', 'Mercadería destinada a la venta', 1);

    IF EXISTS (SELECT 1 FROM Categoria_Compra WHERE ID_Categoria = 2)
        UPDATE Categoria_Compra
        SET Nombre = 'Gastos operativos',
            Descripcion = 'Compras necesarias para la operación',
            Activo = 1
        WHERE ID_Categoria = 2;
    ELSE IF NOT EXISTS (SELECT 1 FROM Categoria_Compra WHERE Codigo = 'CC002')
        INSERT INTO Categoria_Compra (Codigo, Nombre, Descripcion, Activo)
        VALUES ('CC002', 'Gastos operativos', 'Compras necesarias para la operación', 1);

    IF EXISTS (SELECT 1 FROM Categoria_Compra WHERE ID_Categoria = 3)
        UPDATE Categoria_Compra
        SET Nombre = 'Equipamiento',
            Descripcion = 'Bienes de uso y equipamiento',
            Activo = 1
        WHERE ID_Categoria = 3;
    ELSE IF NOT EXISTS (SELECT 1 FROM Categoria_Compra WHERE Codigo = 'CC003')
        INSERT INTO Categoria_Compra (Codigo, Nombre, Descripcion, Activo)
        VALUES ('CC003', 'Equipamiento', 'Bienes de uso y equipamiento', 1);

    -- 5. Las compras registradas por la aplicación son de mercadería.
    --    Se asigna la categoría 1 a las que hayan quedado sin categoría.
    UPDATE H_Compras
    SET ID_Categoria = 1
    WHERE ID_Categoria IS NULL;

    -- 6. Agregar los usuarios demo nuevos si no existen.
    DECLARE @idLucia INT = (SELECT ID_Usuario FROM Usuario WHERE DNI = 56789012);
    IF @idLucia IS NULL
    BEGIN
        INSERT INTO Usuario (DNI, Nombre, Apellido, Telefono, Email, ID_Tipo, Activo)
        VALUES (56789012, 'Lucía', 'Fernández', '5678901234', 'lucia.fernandez@primesystem.com', 5, 1);
        SET @idLucia = SCOPE_IDENTITY();
    END
    ELSE
    BEGIN
        UPDATE Usuario
        SET Nombre = 'Lucía',
            Apellido = 'Fernández',
            Email = 'lucia.fernandez@primesystem.com'
        WHERE ID_Usuario = @idLucia;
    END

    IF NOT EXISTS (SELECT 1 FROM Login WHERE NombreUsuario = 'contador')
        INSERT INTO Login (ID_Usuario, NombreUsuario, Contrasena, Activo)
        VALUES (@idLucia, 'contador', '240be518fabd2724ddb6f04eeb1da5967448d7e831c08c8fa822809f74c720a9', 1);

    DECLARE @idDiego INT = (SELECT ID_Usuario FROM Usuario WHERE DNI = 67890123);
    IF @idDiego IS NULL
    BEGIN
        INSERT INTO Usuario (DNI, Nombre, Apellido, Telefono, Email, ID_Tipo, Activo)
        VALUES (67890123, 'Diego', 'Sosa', '6789012345', 'diego.sosa@primesystem.com', 6, 1);
        SET @idDiego = SCOPE_IDENTITY();
    END
    ELSE
    BEGIN
        UPDATE Usuario
        SET Nombre = 'Diego',
            Apellido = 'Sosa',
            Email = 'diego.sosa@primesystem.com'
        WHERE ID_Usuario = @idDiego;
    END

    IF NOT EXISTS (SELECT 1 FROM Login WHERE NombreUsuario = 'rrhh')
        INSERT INTO Login (ID_Usuario, NombreUsuario, Contrasena, Activo)
        VALUES (@idDiego, 'rrhh', '240be518fabd2724ddb6f04eeb1da5967448d7e831c08c8fa822809f74c720a9', 1);

    -- 7. Alinear los logins demo con el rol que indica su nombre.
    --    El login "comprador" debe pertenecer a un usuario con rol Comprador.
    DECLARE @idComprador INT = (SELECT ID_Usuario FROM Login WHERE NombreUsuario = 'comprador');
    IF @idComprador IS NOT NULL
    BEGIN
        UPDATE Usuario SET ID_Tipo = 4 WHERE ID_Usuario = @idComprador;
    END
    ELSE
    BEGIN
        SET @idComprador = (SELECT TOP 1 ID_Usuario FROM Usuario WHERE ID_Tipo = 4 ORDER BY ID_Usuario);
        IF @idComprador IS NOT NULL
            INSERT INTO Login (ID_Usuario, NombreUsuario, Contrasena, Activo)
            VALUES (@idComprador, 'comprador', '240be518fabd2724ddb6f04eeb1da5967448d7e831c08c8fa822809f74c720a9', 1);
    END

    --    Agregar el login "gerente" si hay un usuario con ese rol y todavía no existe.
    DECLARE @idGerente INT = (SELECT TOP 1 ID_Usuario FROM Usuario WHERE ID_Tipo = 2 ORDER BY ID_Usuario);
    IF @idGerente IS NOT NULL AND NOT EXISTS (SELECT 1 FROM Login WHERE NombreUsuario = 'gerente')
        INSERT INTO Login (ID_Usuario, NombreUsuario, Contrasena, Activo)
        VALUES (@idGerente, 'gerente', '240be518fabd2724ddb6f04eeb1da5967448d7e831c08c8fa822809f74c720a9', 1);

    COMMIT TRANSACTION;
END TRY
BEGIN CATCH
    IF XACT_STATE() <> 0
        ROLLBACK TRANSACTION;

    THROW;
END CATCH;
GO

-- 7. Recrear la vista usada por el historial de compras.
IF OBJECT_ID('dbo.V_Compras_Completas', 'V') IS NOT NULL
    DROP VIEW dbo.V_Compras_Completas;
GO

CREATE VIEW dbo.V_Compras_Completas AS
SELECT
    C.ID_Remito,
    C.Fecha,
    P.Nombre AS Proveedor,
    U.Nombre + ' ' + U.Apellido AS Usuario,
    ISNULL(CAT.Nombre, 'Sin categoría') AS Categoria,
    C.TipoComprobante,
    C.NumeroComprobante,
    C.SubTotal,
    C.Descuento,
    C.Total,
    C.Observaciones,
    ISNULL(SUM(D.Cantidad), 0) AS CantidadItems
FROM H_Compras C
INNER JOIN Proveedor P ON C.ID_Proveedor = P.ID_Proveedor
INNER JOIN Usuario U ON C.ID_Usuario = U.ID_Usuario
LEFT JOIN Categoria_Compra CAT ON C.ID_Categoria = CAT.ID_Categoria
LEFT JOIN H_Compras_Detalle D ON C.ID_Remito = D.ID_Remito
GROUP BY
    C.ID_Remito,
    C.Fecha,
    P.Nombre,
    U.Nombre,
    U.Apellido,
    CAT.Nombre,
    C.TipoComprobante,
    C.NumeroComprobante,
    C.SubTotal,
    C.Descuento,
    C.Total,
    C.Observaciones;
GO

PRINT 'Migración completada. Roles, usuarios, categorías y vista V_Compras_Completas actualizados.';
GO
