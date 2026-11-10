

IF EXISTS (SELECT * FROM sys.databases WHERE name = 'PrimeSystem')
BEGIN
    ALTER DATABASE PrimeSystem SET SINGLE_USER WITH ROLLBACK IMMEDIATE;
    DROP DATABASE PrimeSystem;

END
GO

CREATE DATABASE PrimeSystem;
GO

GO

USE PrimeSystem;
GO

SET ANSI_NULLS ON;
SET QUOTED_IDENTIFIER ON;
GO

-- ============================================
-- SECCIÓN 1: TABLAS DE USUARIOS Y AUTENTICACIÓN
-- ============================================



-- Tabla de tipos de usuario (Roles)
CREATE TABLE Usuario_Tipo (
    ID_Usuario_Tipo INT PRIMARY KEY IDENTITY(1,1),
    Tipo INT NOT NULL,
    Descripcion VARCHAR(50) NOT NULL
);


-- Tabla de usuarios (Empleados del sistema)
CREATE TABLE Usuario (
    ID_Usuario INT PRIMARY KEY IDENTITY(1,1),
    DNI INT NOT NULL UNIQUE,
    Nombre VARCHAR(50) NOT NULL,
    Apellido VARCHAR(50) NOT NULL,
    Telefono VARCHAR(50) NULL,
    Email VARCHAR(100) NULL,
    ID_Tipo INT NOT NULL,
    Activo BIT DEFAULT 1,
    FechaCreacion DATETIME DEFAULT GETDATE(),
    FechaModificacion DATETIME NULL,
    CONSTRAINT FK_Usuario_Tipo FOREIGN KEY (ID_Tipo) REFERENCES Usuario_Tipo(ID_Usuario_Tipo)
);

-- Tabla de login (Credenciales)
CREATE TABLE Login (
    ID_Login INT PRIMARY KEY IDENTITY(1,1),
    ID_Usuario INT NOT NULL,
    NombreUsuario VARCHAR(50) NOT NULL UNIQUE,
    Contrasena VARCHAR(255) NOT NULL, -- SHA256 hash
    Activo BIT DEFAULT 1,
    FechaCreacion DATETIME DEFAULT GETDATE(),
    UltimoAcceso DATETIME NULL,
    CONSTRAINT FK_Login_Usuario FOREIGN KEY (ID_Usuario) REFERENCES Usuario(ID_Usuario)
);

-- ============================================
-- SECCIÓN 2: TABLAS DE ENTIDADES Y CLIENTES
-- ============================================


-- Tabla de entidades (Empresas)
CREATE TABLE Entidad (
    ID_Entidad INT PRIMARY KEY IDENTITY(1,1),
    Nombre VARCHAR(150) NOT NULL,
    CUIT BIGINT NULL,
    Activo BIT DEFAULT 1,
    FechaCreacion DATETIME DEFAULT GETDATE(),
    FechaModificacion DATETIME NULL
);

-- Tabla de clientes
CREATE TABLE Cliente (
    ID_Cliente INT PRIMARY KEY IDENTITY(1,1),
    CUIT BIGINT NULL,
    DNI INT NULL,
    Nombre VARCHAR(100) NOT NULL,
    Apellido VARCHAR(100) NULL,
    ID_Entidad INT NULL,
    Telefono VARCHAR(50) NULL,
    Email VARCHAR(100) NULL,
    Direccion VARCHAR(200) NULL,
    Activo BIT DEFAULT 1,
    FechaCreacion DATETIME DEFAULT GETDATE(),
    ID_Usuario_Creacion INT NULL,
    FechaModificacion DATETIME NULL,
    ID_Usuario_Modificacion INT NULL,
    CONSTRAINT FK_Cliente_Entidad FOREIGN KEY (ID_Entidad) REFERENCES Entidad(ID_Entidad),
    CONSTRAINT FK_Cliente_UsuarioCreacion FOREIGN KEY (ID_Usuario_Creacion) REFERENCES Usuario(ID_Usuario),
    CONSTRAINT FK_Cliente_UsuarioModificacion FOREIGN KEY (ID_Usuario_Modificacion) REFERENCES Usuario(ID_Usuario)
);






-- ============================================
-- SECCIÓN 3: TABLAS DE PROVEEDORES
-- ============================================


-- Tabla de proveedores
CREATE TABLE Proveedor (
    ID_Proveedor INT PRIMARY KEY IDENTITY(1,1),
    CUIT BIGINT NOT NULL UNIQUE,
    Nombre VARCHAR(150) NOT NULL,
    RazonSocial VARCHAR(200) NULL,
    Telefono VARCHAR(50) NULL,
    Email VARCHAR(100) NULL,
    Direccion VARCHAR(200) NULL,
    Activo BIT DEFAULT 1,
    FechaCreacion DATETIME DEFAULT GETDATE(),
    ID_Usuario_Creacion INT NULL,
    FechaModificacion DATETIME NULL,
    ID_Usuario_Modificacion INT NULL,
    CONSTRAINT FK_Proveedor_UsuarioCreacion FOREIGN KEY (ID_Usuario_Creacion) REFERENCES Usuario(ID_Usuario),
    CONSTRAINT FK_Proveedor_UsuarioModificacion FOREIGN KEY (ID_Usuario_Modificacion) REFERENCES Usuario(ID_Usuario)
);

select * from Proveedor;

-- ============================================
-- SECCIÓN 4: TABLAS DE CATEGORÍAS Y ARTÍCULOS
-- ============================================

PRINT '4. Creando tablas de categorías y artículos...';

-- Tabla de categorías
CREATE TABLE Categorias (
    ID_Categoria INT PRIMARY KEY IDENTITY(1,1),
    Nombre_Categoria VARCHAR(100) NOT NULL,
    Descripcion VARCHAR(255) NULL,
    Activo BIT DEFAULT 1,
    FechaCreacion DATETIME DEFAULT GETDATE(),
    FechaModificacion DATETIME NULL
);

-- Tabla de subcategorías
CREATE TABLE SubCategoria (
    ID_Subcategoria INT PRIMARY KEY IDENTITY(1,1),
    Nombre_SubCategoria VARCHAR(100) NOT NULL,
    ID_Categoria INT NOT NULL,
    Descripcion VARCHAR(255) NULL,
    Activo BIT DEFAULT 1,
    FechaCreacion DATETIME DEFAULT GETDATE(),
    FechaModificacion DATETIME NULL,
    CONSTRAINT FK_SubCategoria_Categoria FOREIGN KEY (ID_Categoria) REFERENCES Categorias(ID_Categoria)
);

-- Tabla de artículos
CREATE TABLE Articulos (
    ID_Articulo INT PRIMARY KEY IDENTITY(1,1),
    Codigo VARCHAR(20) NOT NULL UNIQUE,
    Descripcion VARCHAR(200) NOT NULL,
    Costo DECIMAL(18,2) NOT NULL DEFAULT 0,
    PorcentajeGanancia DECIMAL(5,2) NOT NULL DEFAULT 0,
    PrecioVenta AS (Costo + (Costo * PorcentajeGanancia / 100)) PERSISTED,
    StockMinimo INT DEFAULT 0,
    StockActual INT DEFAULT 0,
    ID_Categoria INT NOT NULL,
    ID_Subcategoria INT NULL,
    ID_Proveedor INT NULL,
    Activo BIT DEFAULT 1,
    FechaCreacion DATETIME DEFAULT GETDATE(),
    FechaModificacion DATETIME NULL,
    CONSTRAINT FK_Articulos_Categoria FOREIGN KEY (ID_Categoria) REFERENCES Categorias(ID_Categoria),
    CONSTRAINT FK_Articulos_Subcategoria FOREIGN KEY (ID_Subcategoria) REFERENCES SubCategoria(ID_Subcategoria),
    CONSTRAINT FK_Articulos_Proveedor FOREIGN KEY (ID_Proveedor) REFERENCES Proveedor(ID_Proveedor)
);

-- ============================================
-- SECCIÓN 5: TABLAS DE CATEGORÍAS DE COMPRAS/VENTAS
-- ============================================


-- Tabla de categorías de compra
CREATE TABLE Categoria_Compra (
    ID_Categoria INT PRIMARY KEY IDENTITY(1,1),
    Codigo VARCHAR(10) NOT NULL UNIQUE,
    Nombre VARCHAR(100) NOT NULL,
    Descripcion VARCHAR(255) NULL,
    Activo BIT DEFAULT 1
);

-- Tabla de categorías de venta
CREATE TABLE Categoria_Venta (
    ID_Categoria INT PRIMARY KEY IDENTITY(1,1),
    Codigo VARCHAR(10) NOT NULL UNIQUE,
    Nombre VARCHAR(100) NOT NULL,
    Descripcion VARCHAR(255) NULL,
    Activo BIT DEFAULT 1
);

-- ============================================
-- SECCIÓN 6: TABLAS DE COMPRAS (HISTORIAL)
-- ============================================


-- Tabla de historial de compras (encabezado)
CREATE TABLE H_Compras (
    ID_Remito INT PRIMARY KEY IDENTITY(1,1),
    ID_Proveedor INT NOT NULL,
    ID_Usuario INT NOT NULL,
    ID_Categoria INT NULL,
    Fecha DATETIME DEFAULT GETDATE(),
    TipoComprobante VARCHAR(50) NULL,
    NumeroComprobante VARCHAR(50) NULL,
    SubTotal DECIMAL(18,2) DEFAULT 0,
    Descuento DECIMAL(18,2) DEFAULT 0,
    Total DECIMAL(18,2) DEFAULT 0,
    Observaciones VARCHAR(500) NULL,
    CONSTRAINT FK_HCompras_Proveedor FOREIGN KEY (ID_Proveedor) REFERENCES Proveedor(ID_Proveedor),
    CONSTRAINT FK_HCompras_Usuario FOREIGN KEY (ID_Usuario) REFERENCES Usuario(ID_Usuario),
    CONSTRAINT FK_HCompras_Categoria FOREIGN KEY (ID_Categoria) REFERENCES Categoria_Compra(ID_Categoria)
);

-- Tabla de detalle de compras
CREATE TABLE H_Compras_Detalle (
    ID_Detalle INT PRIMARY KEY IDENTITY(1,1),
    ID_Remito INT NOT NULL,
    ID_Articulo INT NOT NULL,
    Descr VARCHAR(200) NULL,
    Cantidad INT NOT NULL,
    P_Unidad DECIMAL(18,2) NOT NULL,
    CONSTRAINT FK_HComprasDetalle_Remito FOREIGN KEY (ID_Remito) REFERENCES H_Compras(ID_Remito),
    CONSTRAINT FK_HComprasDetalle_Articulo FOREIGN KEY (ID_Articulo) REFERENCES Articulos(ID_Articulo)
);

-- ============================================
-- SECCIÓN 7: TABLAS DE VENTAS (HISTORIAL)
-- ============================================


-- Tabla de historial de ventas (encabezado)
CREATE TABLE H_Ventas (
    ID_Remito INT PRIMARY KEY IDENTITY(1,1),
    ID_Cliente INT NOT NULL,
    ID_Usuario INT NOT NULL,
    ID_Categoria INT NULL,
    Fecha DATETIME DEFAULT GETDATE(),
    TipoComprobante VARCHAR(50) NULL,
    NumeroComprobante VARCHAR(50) NULL,
    SubTotal DECIMAL(18,2) DEFAULT 0,
    Descuento DECIMAL(18,2) DEFAULT 0,
    Total DECIMAL(18,2) DEFAULT 0,
    Observaciones VARCHAR(500) NULL,
    CONSTRAINT FK_HVentas_Cliente FOREIGN KEY (ID_Cliente) REFERENCES Cliente(ID_Cliente),
    CONSTRAINT FK_HVentas_Usuario FOREIGN KEY (ID_Usuario) REFERENCES Usuario(ID_Usuario),
    CONSTRAINT FK_HVentas_Categoria FOREIGN KEY (ID_Categoria) REFERENCES Categoria_Venta(ID_Categoria)
);

-- Tabla de detalle de ventas
CREATE TABLE H_Ventas_Detalle (
    ID_Detalle INT PRIMARY KEY IDENTITY(1,1),
    ID_Remito INT NOT NULL,
    ID_Articulo INT NOT NULL,
    Descr VARCHAR(200) NULL,
    Cantidad INT NOT NULL,
    PrecioUnidad DECIMAL(18,2) NOT NULL,
    CONSTRAINT FK_HVentasDetalle_Remito FOREIGN KEY (ID_Remito) REFERENCES H_Ventas(ID_Remito),
    CONSTRAINT FK_HVentasDetalle_Articulo FOREIGN KEY (ID_Articulo) REFERENCES Articulos(ID_Articulo)
);







GO

-- ============================================
-- SECCIÓN 8: VISTAS
-- ============================================

-- Vista de compras completa (usada por el historial de compras)
CREATE VIEW V_Compras_Completas AS
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

-- ============================================
-- SECCIÓN 9: DATOS DE EJEMPLO
-- ============================================


-- Tipos de usuario (deben coincidir con las constantes de PermisosUsuario.cs)
INSERT INTO Usuario_Tipo (Tipo, Descripcion) VALUES (1, 'Administrador');
INSERT INTO Usuario_Tipo (Tipo, Descripcion) VALUES (2, 'Gerente');
INSERT INTO Usuario_Tipo (Tipo, Descripcion) VALUES (3, 'Vendedor');
INSERT INTO Usuario_Tipo (Tipo, Descripcion) VALUES (4, 'Comprador');
INSERT INTO Usuario_Tipo (Tipo, Descripcion) VALUES (5, 'Contador');
INSERT INTO Usuario_Tipo (Tipo, Descripcion) VALUES (6, 'Recursos Humanos');

-- Usuarios
INSERT INTO Usuario (DNI, Nombre, Apellido, Telefono, Email, ID_Tipo, Activo)
VALUES (12345678, 'Juan', 'Pérez', '1234567890', 'juan.perez@primesystem.com', 1, 1);

INSERT INTO Usuario (DNI, Nombre, Apellido, Telefono, Email, ID_Tipo, Activo)
VALUES (23456789, 'María', 'González', '2345678901', 'maria.gonzalez@primesystem.com', 2, 1);

INSERT INTO Usuario (DNI, Nombre, Apellido, Telefono, Email, ID_Tipo, Activo)
VALUES (34567890, 'Carlos', 'Rodríguez', '3456789012', 'carlos.rodriguez@primesystem.com', 3, 1);

INSERT INTO Usuario (DNI, Nombre, Apellido, Telefono, Email, ID_Tipo, Activo)
VALUES (45678901, 'Ana', 'Martínez', '4567890123', 'ana.martinez@primesystem.com', 4, 1);

INSERT INTO Usuario (DNI, Nombre, Apellido, Telefono, Email, ID_Tipo, Activo)
VALUES (56789012, 'Lucía', 'Fernández', '5678901234', 'lucia.fernandez@primesystem.com', 5, 1);

INSERT INTO Usuario (DNI, Nombre, Apellido, Telefono, Email, ID_Tipo, Activo)
VALUES (67890123, 'Diego', 'Sosa', '6789012345', 'diego.sosa@primesystem.com', 6, 1);

-- Login (Contraseña: admin123 en SHA256)
INSERT INTO Login (ID_Usuario, NombreUsuario, Contrasena, Activo)
VALUES (1, 'admin', '240be518fabd2724ddb6f04eeb1da5967448d7e831c08c8fa822809f74c720a9', 1);

INSERT INTO Login (ID_Usuario, NombreUsuario, Contrasena, Activo)
VALUES (2, 'gerente', '240be518fabd2724ddb6f04eeb1da5967448d7e831c08c8fa822809f74c720a9', 1);

INSERT INTO Login (ID_Usuario, NombreUsuario, Contrasena, Activo)
VALUES (3, 'vendedor', '240be518fabd2724ddb6f04eeb1da5967448d7e831c08c8fa822809f74c720a9', 1);

INSERT INTO Login (ID_Usuario, NombreUsuario, Contrasena, Activo)
VALUES (4, 'comprador', '240be518fabd2724ddb6f04eeb1da5967448d7e831c08c8fa822809f74c720a9', 1);

INSERT INTO Login (ID_Usuario, NombreUsuario, Contrasena, Activo)
VALUES (5, 'contador', '240be518fabd2724ddb6f04eeb1da5967448d7e831c08c8fa822809f74c720a9', 1);

INSERT INTO Login (ID_Usuario, NombreUsuario, Contrasena, Activo)
VALUES (6, 'rrhh', '240be518fabd2724ddb6f04eeb1da5967448d7e831c08c8fa822809f74c720a9', 1);


-- Entidades
INSERT INTO Entidad (Nombre, CUIT, Activo) VALUES ('Empresa ABC S.A.', 30123456789, 1);
INSERT INTO Entidad (Nombre, CUIT, Activo) VALUES ('Comercial XYZ S.R.L.', 30234567890, 1);
INSERT INTO Entidad (Nombre, CUIT, Activo) VALUES ('Industrias DEF S.A.', 30345678901, 1);
INSERT INTO Entidad (Nombre, CUIT, Activo) VALUES ('Servicios GHI', 30456789012, 1);
INSERT INTO Entidad (Nombre, CUIT, Activo) VALUES ('Distribuidora JKL', 30567890123, 1);

-- Clientes
INSERT INTO Cliente (CUIT, DNI, Nombre, Apellido, ID_Entidad, Telefono, Email, Direccion, Activo, ID_Usuario_Creacion)
VALUES (NULL, 20123456, 'Roberto', 'Sánchez', NULL, '1122334455', 'roberto.sanchez@email.com', 'Calle Falsa 123', 1, 1);

INSERT INTO Cliente (CUIT, DNI, Nombre, Apellido, ID_Entidad, Telefono, Email, Direccion, Activo, ID_Usuario_Creacion)
VALUES (NULL, 30234567, 'Laura', 'Fernández', NULL, '2233445566', 'laura.fernandez@email.com', 'Av. Siempre Viva 456', 1, 1);

INSERT INTO Cliente (CUIT, DNI, Nombre, Apellido, ID_Entidad, Telefono, Email, Direccion, Activo, ID_Usuario_Creacion)
VALUES (20345678901234, NULL, 'Pedro', 'López', 1, '3344556677', 'pedro.lopez@empresaabc.com', 'Calle Principal 789', 1, 1);

INSERT INTO Cliente (CUIT, DNI, Nombre, Apellido, ID_Entidad, Telefono, Email, Direccion, Activo, ID_Usuario_Creacion)
VALUES (20456789012345, NULL, 'Sofía', 'García', 2, '4455667788', 'sofia.garcia@comercialxyz.com', 'Av. Central 321', 1, 1);


-- Proveedores
INSERT INTO Proveedor (CUIT, Nombre, RazonSocial, Telefono, Email, Direccion, Activo, ID_Usuario_Creacion)
VALUES (20111222333, 'TechnoSupply', 'TechnoSupply S.A.', '1111222233', 'ventas@technosupply.com', 'Parque Industrial 100', 1, 1);

INSERT INTO Proveedor (CUIT, Nombre, RazonSocial, Telefono, Email, Direccion, Activo, ID_Usuario_Creacion)
VALUES (20222333444, 'ElectroMax', 'ElectroMax S.R.L.', '2222333344', 'info@electromax.com', 'Zona Comercial 200', 1, 1);

INSERT INTO Proveedor (CUIT, Nombre, RazonSocial, Telefono, Email, Direccion, Activo, ID_Usuario_Creacion)
VALUES (20333444555, 'DistribuTech', 'DistribuTech Internacional', '3333444455', 'contacto@distributech.com', 'Centro Logístico 300', 1, 1);


-- Categorías de artículos
INSERT INTO Categorias (Nombre_Categoria, Descripcion, Activo) VALUES ('Electrónica', 'Productos electrónicos', 1);
INSERT INTO Categorias (Nombre_Categoria, Descripcion, Activo) VALUES ('Hogar', 'Artículos para el hogar', 1);
INSERT INTO Categorias (Nombre_Categoria, Descripcion, Activo) VALUES ('Tecnología', 'Productos tecnológicos', 1);
INSERT INTO Categorias (Nombre_Categoria, Descripcion, Activo) VALUES ('Oficina', 'Artículos de oficina', 1);

-- Subcategorías
INSERT INTO SubCategoria (Nombre_SubCategoria, ID_Categoria, Descripcion, Activo)
VALUES ('Celulares', 1, 'Teléfonos móviles', 1);

INSERT INTO SubCategoria (Nombre_SubCategoria, ID_Categoria, Descripcion, Activo)
VALUES ('Televisores', 1, 'Televisores y pantallas', 1);

INSERT INTO SubCategoria (Nombre_SubCategoria, ID_Categoria, Descripcion, Activo)
VALUES ('Electrodomésticos', 2, 'Electrodomésticos varios', 1);

INSERT INTO SubCategoria (Nombre_SubCategoria, ID_Categoria, Descripcion, Activo)
VALUES ('Computadoras', 3, 'Computadoras y laptops', 1);

INSERT INTO SubCategoria (Nombre_SubCategoria, ID_Categoria, Descripcion, Activo)
VALUES ('Accesorios', 3, 'Accesorios tecnológicos', 1);


-- Artículos
INSERT INTO Articulos (Codigo, Descripcion, Costo, PorcentajeGanancia, StockMinimo, StockActual, ID_Categoria, ID_Subcategoria, ID_Proveedor, Activo)
VALUES ('CEL001', 'Samsung Galaxy A54 128GB', 250000.00, 35.00, 5, 15, 1, 1, 1, 1);

INSERT INTO Articulos (Codigo, Descripcion, Costo, PorcentajeGanancia, StockMinimo, StockActual, ID_Categoria, ID_Subcategoria, ID_Proveedor, Activo)
VALUES ('CEL002', 'iPhone 14 256GB', 800000.00, 30.00, 3, 8, 1, 1, 1, 1);

INSERT INTO Articulos (Codigo, Descripcion, Costo, PorcentajeGanancia, StockMinimo, StockActual, ID_Categoria, ID_Subcategoria, ID_Proveedor, Activo)
VALUES ('TV001', 'Smart TV Samsung 55 pulgadas 4K', 450000.00, 25.00, 5, 12, 1, 2, 2, 1);

INSERT INTO Articulos (Codigo, Descripcion, Costo, PorcentajeGanancia, StockMinimo, StockActual, ID_Categoria, ID_Subcategoria, ID_Proveedor, Activo)
VALUES ('TV002', 'Smart TV LG 65 pulgadas OLED', 900000.00, 20.00, 2, 5, 1, 2, 2, 1);

INSERT INTO Articulos (Codigo, Descripcion, Costo, PorcentajeGanancia, StockMinimo, StockActual, ID_Categoria, ID_Subcategoria, ID_Proveedor, Activo)
VALUES ('LAV001', 'Lavarropas Automático 8kg', 350000.00, 30.00, 3, 10, 2, 3, 2, 1);

INSERT INTO Articulos (Codigo, Descripcion, Costo, PorcentajeGanancia, StockMinimo, StockActual, ID_Categoria, ID_Subcategoria, ID_Proveedor, Activo)
VALUES ('HEL001', 'Heladera No Frost 350L', 550000.00, 28.00, 2, 7, 2, 3, 2, 1);

INSERT INTO Articulos (Codigo, Descripcion, Costo, PorcentajeGanancia, StockMinimo, StockActual, ID_Categoria, ID_Subcategoria, ID_Proveedor, Activo)
VALUES ('PC001', 'Notebook Dell Inspiron 15 i5 16GB', 650000.00, 22.00, 4, 10, 3, 4, 3, 1);

INSERT INTO Articulos (Codigo, Descripcion, Costo, PorcentajeGanancia, StockMinimo, StockActual, ID_Categoria, ID_Subcategoria, ID_Proveedor, Activo)
VALUES ('PC002', 'PC Escritorio Ryzen 5 16GB 512GB SSD', 480000.00, 28.00, 5, 8, 3, 4, 3, 1);

INSERT INTO Articulos (Codigo, Descripcion, Costo, PorcentajeGanancia, StockMinimo, StockActual, ID_Categoria, ID_Subcategoria, ID_Proveedor, Activo)
VALUES ('ACC001', 'Mouse Logitech Inalámbrico', 12000.00, 40.00, 20, 50, 3, 5, 3, 1);

INSERT INTO Articulos (Codigo, Descripcion, Costo, PorcentajeGanancia, StockMinimo, StockActual, ID_Categoria, ID_Subcategoria, ID_Proveedor, Activo)
VALUES ('ACC002', 'Teclado Mecánico RGB', 35000.00, 45.00, 10, 25, 3, 5, 3, 1);


-- Categorías de compra (la categoría 1 se usa como "Insumos para venta" en EstadoContableDAL)
INSERT INTO Categoria_Compra (Codigo, Nombre, Descripcion, Activo)
VALUES ('CC001', 'Insumos para venta', 'Mercadería destinada a la venta', 1);

INSERT INTO Categoria_Compra (Codigo, Nombre, Descripcion, Activo)
VALUES ('CC002', 'Gastos operativos', 'Compras necesarias para la operación', 1);

INSERT INTO Categoria_Compra (Codigo, Nombre, Descripcion, Activo)
VALUES ('CC003', 'Equipamiento', 'Bienes de uso y equipamiento', 1);


-- Categorías de venta
INSERT INTO Categoria_Venta (Codigo, Nombre, Descripcion, Activo)
VALUES ('CV001', 'Venta Minorista', 'Venta al consumidor final', 1);

INSERT INTO Categoria_Venta (Codigo, Nombre, Descripcion, Activo)
VALUES ('CV002', 'Venta Mayorista', 'Venta al por mayor', 1);

INSERT INTO Categoria_Venta (Codigo, Nombre, Descripcion, Activo)
VALUES ('CV003', 'Venta Corporativa', 'Venta a empresas', 1);


-- Compras de ejemplo
INSERT INTO H_Compras (ID_Proveedor, ID_Usuario, ID_Categoria, Fecha, TipoComprobante, NumeroComprobante, SubTotal, Descuento, Total, Observaciones)
VALUES (1, 3, 1, '2024-01-15', 'Factura A', '0001-00000123', 3000000.00, 50000.00, 2950000.00, 'Compra inicial de smartphones');

DECLARE @ID_Compra1 INT = SCOPE_IDENTITY();

INSERT INTO H_Compras_Detalle (ID_Remito, ID_Articulo, Descr, Cantidad, P_Unidad)
VALUES (@ID_Compra1, 1, 'Samsung Galaxy A54 128GB', 10, 250000.00);

INSERT INTO H_Compras_Detalle (ID_Remito, ID_Articulo, Descr, Cantidad, P_Unidad)
VALUES (@ID_Compra1, 2, 'iPhone 14 256GB', 3, 800000.00);

INSERT INTO H_Compras (ID_Proveedor, ID_Usuario, ID_Categoria, Fecha, TipoComprobante, NumeroComprobante, SubTotal, Descuento, Total, Observaciones)
VALUES (2, 3, 1, '2024-01-20', 'Factura A', '0002-00000456', 5400000.00, 100000.00, 5300000.00, 'Compra de electrodomésticos');

DECLARE @ID_Compra2 INT = SCOPE_IDENTITY();

INSERT INTO H_Compras_Detalle (ID_Remito, ID_Articulo, Descr, Cantidad, P_Unidad)
VALUES (@ID_Compra2, 3, 'Smart TV Samsung 55 pulgadas 4K', 8, 450000.00);

INSERT INTO H_Compras_Detalle (ID_Remito, ID_Articulo, Descr, Cantidad, P_Unidad)
VALUES (@ID_Compra2, 5, 'Lavarropas Automático 8kg', 6, 350000.00);


-- Ventas de ejemplo
INSERT INTO H_Ventas (ID_Cliente, ID_Usuario, ID_Categoria, Fecha, TipoComprobante, NumeroComprobante, SubTotal, Descuento, Total, Observaciones)
VALUES (1, 2, 1, '2024-01-16', 'Factura B', '0001-00000001', 337500.00, 0.00, 337500.00, 'Venta de smartphone');

DECLARE @ID_Venta1 INT = SCOPE_IDENTITY();

INSERT INTO H_Ventas_Detalle (ID_Remito, ID_Articulo, Descr, Cantidad, PrecioUnidad)
VALUES (@ID_Venta1, 1, 'Samsung Galaxy A54 128GB', 1, 337500.00);

INSERT INTO H_Ventas (ID_Cliente, ID_Usuario, ID_Categoria, Fecha, TipoComprobante, NumeroComprobante, SubTotal, Descuento, Total, Observaciones)
VALUES (2, 2, 1, '2024-01-18', 'Factura B', '0001-00000002', 562500.00, 10000.00, 552500.00, 'Venta de Smart TV');

DECLARE @ID_Venta2 INT = SCOPE_IDENTITY();

INSERT INTO H_Ventas_Detalle (ID_Remito, ID_Articulo, Descr, Cantidad, PrecioUnidad)
VALUES (@ID_Venta2, 3, 'Smart TV Samsung 55 pulgadas 4K', 1, 562500.00);

INSERT INTO H_Ventas (ID_Cliente, ID_Usuario, ID_Categoria, Fecha, TipoComprobante, NumeroComprobante, SubTotal, Descuento, Total, Observaciones)
VALUES (3, 2, 3, '2024-01-22', 'Factura A', '0001-00000003', 1586400.00, 50000.00, 1536400.00, 'Venta corporativa de equipos');

DECLARE @ID_Venta3 INT = SCOPE_IDENTITY();

INSERT INTO H_Ventas_Detalle (ID_Remito, ID_Articulo, Descr, Cantidad, PrecioUnidad)
VALUES (@ID_Venta3, 7, 'Notebook Dell Inspiron 15 i5 16GB', 2, 793200.00);


-- ============================================
-- SECCIÓN 10: VERIFICACIÓN
-- ============================================

SELECT 'Tipos de Usuario' AS Tabla, COUNT(*) AS Registros FROM Usuario_Tipo
UNION ALL
SELECT 'Usuarios', COUNT(*) FROM Usuario
UNION ALL
SELECT 'Login', COUNT(*) FROM Login
UNION ALL
SELECT 'Entidades', COUNT(*) FROM Entidad
UNION ALL
SELECT 'Clientes', COUNT(*) FROM Cliente
UNION ALL
SELECT 'Proveedores', COUNT(*) FROM Proveedor
UNION ALL
SELECT 'Categorías', COUNT(*) FROM Categorias
UNION ALL
SELECT 'Subcategorías', COUNT(*) FROM SubCategoria
UNION ALL
SELECT 'Artículos', COUNT(*) FROM Articulos
UNION ALL
SELECT 'Categorías Compra', COUNT(*) FROM Categoria_Compra
UNION ALL
SELECT 'Categorías Venta', COUNT(*) FROM Categoria_Venta
UNION ALL
SELECT 'Compras', COUNT(*) FROM H_Compras
UNION ALL
SELECT 'Detalle Compras', COUNT(*) FROM H_Compras_Detalle
UNION ALL
SELECT 'Ventas', COUNT(*) FROM H_Ventas
UNION ALL
SELECT 'Detalle Ventas', COUNT(*) FROM H_Ventas_Detalle;

SELECT COLUMN_NAME, DATA_TYPE, IS_NULLABLE, COLUMN_DEFAULT
FROM INFORMATION_SCHEMA.COLUMNS
WHERE TABLE_NAME = 'H_Compras'
ORDER BY ORDINAL_POSITION;

-- 1. VERIFICAR TABLA H_COMPRAS
SELECT COLUMN_NAME, DATA_TYPE, IS_NULLABLE, COLUMN_DEFAULT
FROM INFORMATION_SCHEMA.COLUMNS
WHERE TABLE_NAME = 'H_Compras'
ORDER BY ORDINAL_POSITION;
PRINT '';

-- 2. VERIFICAR SI EXISTE ID_Categoria
IF EXISTS (
    SELECT 1 FROM INFORMATION_SCHEMA.COLUMNS
    WHERE TABLE_NAME = 'H_Compras'
    AND COLUMN_NAME = 'ID_Categoria'
)
BEGIN
    PRINT '✓ El campo ID_Categoria YA EXISTE en H_Compras';
    PRINT '  NO es necesario ejecutar ALTER TABLE';
END
ELSE
BEGIN
    PRINT '✗ El campo ID_Categoria NO EXISTE en H_Compras';
    PRINT '  EJECUTE EL SIGUIENTE COMANDO:';
    PRINT '  ALTER TABLE H_Compras ADD ID_Categoria INT NULL;';
END
PRINT '';

-- 3. VERIFICAR TABLA CATEGORIA_COMPRA
IF EXISTS (SELECT 1 FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'Categoria_Compra')
BEGIN
    PRINT '✓ La tabla Categoria_Compra existe';
    PRINT '  Registros actuales:';
    SELECT * FROM Categoria_Compra;
END
ELSE
BEGIN
    PRINT '✗ La tabla Categoria_Compra NO EXISTE';
    PRINT '  Debe crear la tabla primero';
END
PRINT '';

-- 4. VERIFICAR OTRAS TABLAS NECESARIAS

IF EXISTS (SELECT 1 FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'H_Ventas')
    PRINT '✓ Tabla H_Ventas existe';
ELSE
    PRINT '✗ Tabla H_Ventas NO existe';

IF EXISTS (SELECT 1 FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'Usuario')
    PRINT '✓ Tabla Usuario existe';
ELSE
    PRINT '✗ Tabla Usuario NO existe';

IF EXISTS (SELECT 1 FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'Cliente')
    PRINT '✓ Tabla Cliente existe';
ELSE
    PRINT '✗ Tabla Cliente NO existe';

IF EXISTS (SELECT 1 FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'Proveedor')
    PRINT '✓ Tabla Proveedor existe';
ELSE
    PRINT '✗ Tabla Proveedor NO existe';

IF EXISTS (SELECT 1 FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'Articulos')
    PRINT '✓ Tabla Articulos existe';
ELSE
    PRINT '✗ Tabla Articulos NO existe';



-- Ver ventas creadas con validación
SELECT
    v.ID_Remito,
    v.Fecha,
    c.Nombre + ' ' + c.Apellido AS Cliente,
    v.Subtotal,
    v.Descuento,
    v.Total,
    SUM(vd.PrecioUnidad * vd.Cantidad) AS Subtotal_Calculado,
    (v.Subtotal - v.Descuento) AS Total_Calculado,
    CASE
        WHEN v.Total = (v.Subtotal - v.Descuento)
             AND v.Subtotal = SUM(vd.PrecioUnidad * vd.Cantidad)
        THEN '✅ CORRECTO'
        ELSE '❌ ERROR'
    END AS Estado
FROM H_Ventas v
INNER JOIN Cliente c ON v.ID_Cliente = c.ID_Cliente
INNER JOIN H_Ventas_Detalle vd ON v.ID_Remito = vd.ID_Remito
GROUP BY v.ID_Remito, v.Fecha, c.Nombre, c.Apellido, v.Subtotal, v.Descuento, v.Total
ORDER BY v.ID_Remito DESC;


PRINT 'Usuarios de prueba:';
PRINT '  - admin / admin123 (Administrador)';
PRINT '  - gerente / admin123 (Gerente)';
PRINT '  - vendedor / admin123 (Vendedor)';
PRINT '  - comprador / admin123 (Comprador)';
PRINT '  - contador / admin123 (Contador)';
PRINT '  - rrhh / admin123 (Recursos Humanos)';
PRINT '========================================';


select * from Usuario;