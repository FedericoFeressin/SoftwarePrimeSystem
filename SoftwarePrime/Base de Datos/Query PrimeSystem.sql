-- 1. Crear Categorias
CREATE TABLE Categorias (
    ID_Categoria INT IDENTITY PRIMARY KEY,
    Nombre_Categoria VARCHAR(100)
);

select * from Categorias

INSERT INTO Categorias (Nombre_Categoria)
VALUES ('Tecnología'); 


-- 2. Crear Proveedores
CREATE TABLE Proveedores (
    ID_Proveedor INT IDENTITY PRIMARY KEY,
    Cuit BIGINT NOT NULL,
    Proveedor VARCHAR(50) NOT NULL,
    Nombre VARCHAR(50),
    Telefono VARCHAR(50),
    Email VARCHAR(50)
);

select * from Proveedores

-- 3. Insertar datos en Categorias y Proveedores
INSERT INTO Categorias (Nombre_Categoria) VALUES ('Electrónica'), ('Hogar'), ('Oficina');
INSERT INTO Proveedores (Cuit, Proveedor, Nombre, Telefono, Email)
VALUES (20123456789, 'Samsung', 'Samsung Argentina', '011-1234-5678', 'ventas@samsung.com'),
       (20234567890, 'LG', 'LG Argentina', '011-2345-6789', 'ventas@lg.com'),
       (20345678901, 'Whirlpool', 'Whirlpool Argentina', '011-3456-7890', 'ventas@whirlpool.com');

-- 4. Crear SubCategoria
CREATE TABLE SubCategoria (
    ID_Subcategoria INT IDENTITY PRIMARY KEY,
    Nombre_SubCategoria VARCHAR(50),
    ID_Categoria INT,
    FOREIGN KEY (ID_Categoria) REFERENCES Categorias(ID_Categoria)
);
SELECT * FROM Categorias WHERE ID_Categoria = 5;

-- 5. Insertar datos en SubCategoria
INSERT INTO SubCategoria (Nombre_SubCategoria, ID_Categoria)
VALUES ('Celulares', 1), ('Televisores', 1), ('Cocina', 2), ('Muebles', 3);

insert into SubCategoria (Nombre_SubCategoria, ID_Categoria) values ('Computadoras', 4);

select * From SubCategoria






-- 6. Crear Articulos
CREATE TABLE Articulos (
    ID_Articulo INT IDENTITY PRIMARY KEY,
    Codigo VARCHAR(20),
    Descripcion VARCHAR(100),
    Cantidad INT,
    Costo DECIMAL(10,2),
    Ganancia DECIMAL(10,2),
    ID_Categoria INT,
    ID_Subcategoria INT,
    ID_Proveedor INT,
    FOREIGN KEY (ID_Categoria) REFERENCES Categorias(ID_Categoria),
    FOREIGN KEY (ID_Subcategoria) REFERENCES SubCategoria(ID_Subcategoria),
    FOREIGN KEY (ID_Proveedor) REFERENCES Proveedores(ID_Proveedor)
);

-- 7. Insertar datos en Articulos
INSERT INTO Articulos (Codigo, Descripcion, Cantidad, Costo, Ganancia, ID_Categoria, ID_Subcategoria, ID_Proveedor)
VALUES ('A001', 'Smartphone Galaxy S24', 50, 400000, 20, 1, 1, 1),
       ('A002', 'Televisor LG 55"', 25, 650000, 15, 1, 2, 2),
       ('A003', 'Heladera Whirlpool 350L', 10, 900000, 25, 2, 3, 3),
       ('A004', 'Escritorio de Madera', 30, 120000, 18, 3, 4, 1);

	   sELECT * FROM Articulos

-- 8. Crear Stock
CREATE TABLE Stock (
    ID_Stock INT IDENTITY PRIMARY KEY,
    ID_Articulo INT,
    Cantidad_Disponible INT,
    Fecha_Actualizacion DATETIME DEFAULT GETDATE(),
    FOREIGN KEY (ID_Articulo) REFERENCES Articulos(ID_Articulo)
);

-- 9. Insertar datos en Stock
INSERT INTO Stock (ID_Articulo, Cantidad_Disponible)
VALUES (1, 50), (2, 25), (3, 10), (4, 30);

SELECT 
    A.ID_Articulo,
    A.Codigo,
    A.Descripcion,
    A.Cantidad,
    A.Costo,
    A.Ganancia,
    (A.Costo + (A.Costo * A.Ganancia / 100)) AS PrecioVenta,
    C.Nombre_Categoria AS Categoria,
    S.Nombre_SubCategoria AS Subcategoria,
    P.Nombre AS Proveedor,
    ST.Cantidad_Disponible AS Stock
FROM Articulos A
INNER JOIN Categorias C ON A.ID_Categoria = C.ID_Categoria
INNER JOIN SubCategoria S ON A.ID_Subcategoria = S.ID_Subcategoria
INNER JOIN Proveedores P ON A.ID_Proveedor = P.ID_Proveedor
INNER JOIN Stock ST ON A.ID_Articulo = ST.ID_Articulo;



CREATE TABLE H_Compras_Detalle (
    ID_Det_Remito INT IDENTITY PRIMARY KEY,
    ID_Remito INT NOT NULL,
    ID_Articulo INT NOT NULL,
    Descr VARCHAR(100),
    Cantidad INT NOT NULL,
    P_Unidad DECIMAL(10,2) NOT NULL,
    P_por_Cantidad AS (Cantidad * P_Unidad) PERSISTED,
    FOREIGN KEY (ID_Remito) REFERENCES H_Compras(ID_Remito),
    FOREIGN KEY (ID_Articulo) REFERENCES Articulos(ID_Articulo)
);


INSERT INTO H_Ventas_Detalle (ID_Remito, ID_Articulo, Descr, PrecioUnidad, Cantidad)
VALUES (1, 1, 'Mouse óptico', 650.00, 1);


CREATE TABLE H_Ventas (
    ID_Remito INT IDENTITY PRIMARY KEY,
    Cod_Usuario INT NOT NULL,
    Fecha_Hora DATETIME NOT NULL,
    ID_Cliente INT NOT NULL,
    Subtotal DECIMAL(10,2) NOT NULL,
    Descuento DECIMAL(10,2) NOT NULL,
    Total DECIMAL(10,2) NOT NULL,
    FOREIGN KEY (Cod_Usuario) REFERENCES Usuario(ID_Usuario),
    FOREIGN KEY (ID_Cliente) REFERENCES Clientes(ID_Clientes)
);


EXEC sp_help H_Ventas;
SELECT TOP 1 * FROM H_Ventas;



INSERT INTO H_Ventas (Cod_Usuario, Fecha_Hora, ID_Cliente, Subtotal, Descuento, Total)
VALUES (1, GETDATE(), 1, 650.00, 50.00, 600.00);

SELECT V.ID_Remito, V.Fecha_Hora, U.Nombre AS Usuario, C.Nombre AS Cliente, A.Codigo, D.Descr, D.Cantidad, D.PrecioUnidad, D.Precio_Por_Cantidad
FROM H_Ventas V
INNER JOIN Usuario U ON V.Cod_Usuario = U.ID_Usuario
INNER JOIN Clientes C ON V.ID_Cliente = C.ID_Clientes
INNER JOIN H_Ventas_Detalle D ON V.ID_Remito = D.ID_Remito
INNER JOIN Articulos A ON D.ID_Articulo = A.ID_Articulo;


Create table Clientes (
    ID_Clientes int identity primary key,
    Cuit Bigint,
    Nombre varchar (50),
    Entidad varchar (50),
    Telefono varchar (50),
    Mail varchar (50)
)

ALTER TABLE Clientes
ADD ID_Entidad INT FOREIGN KEY REFERENCES Entidades(ID_Entidad);

CREATE TABLE Entidades (
    ID_Entidad INT IDENTITY PRIMARY KEY,
    Nombre_Entidad VARCHAR(100)
);

sp_help Entidades

drop table Clientes
select * from Clientes

INSERT INTO Clientes (Cuit, Nombre, Entidad, Telefono, Mail)
VALUES
(20345678901, 'Cliente 1', 'Distribuidora Andina S.A.', '1123456789', 'cliente1@mail.com'),
(20987654321, 'Cliente 2', 'ElectroLuz S.R.L.', '1134567890', 'cliente2@mail.com'),
(20123456789, 'Cliente 3', 'Ferretería Central', '1145678901', 'cliente3@mail.com');

INSERT INTO Entidades (Nombre_Entidad)
VALUES
('Distribuidora Andina S.A.'),
('ElectroLuz S.R.L.'),
('Ferretería Central'),
('Importadora Delta'),
('Construcciones Rivera');

select * from Entidades

CREATE TABLE H_Compras (
    ID_Remito INT IDENTITY PRIMARY KEY,
    ID_Proveedor INT NOT NULL FOREIGN KEY REFERENCES Proveedores(ID_Proveedor),
    ID_Usuario INT NOT NULL FOREIGN KEY REFERENCES Usuario(ID_Usuario),
    Fecha DATETIME NOT NULL DEFAULT GETDATE(),
    Categoria VARCHAR(50),
    SubTotal DECIMAL(10,2),
    Descuento DECIMAL(10,2),
    Total DECIMAL(10,2)
);



select * from H_Compras
drop table H_Compras

CREATE TABLE H_Compras_Detalle (
    ID_Det_Remito INT IDENTITY PRIMARY KEY,
    ID_Remito INT NOT NULL FOREIGN KEY REFERENCES H_Compras(ID_Remito),
    Cod_Art VARCHAR(50) NOT NULL FOREIGN KEY REFERENCES Articulos(Cod_Articulo),
    Descr VARCHAR(100),
    Cantidad INT NOT NULL,
    P_Unidad DECIMAL(10,2) NOT NULL,
    P_por_Cantidad AS (Cantidad * P_Unidad) PERSISTED
);



Create table H_Movimientos (
    ID_Historico int Identity primary key,
    Id_Usuario int,
    Tip_Movimiento int,
    Reg_Antes Varchar(50),
    Reg_Despues varchar(50),
    Fecha_Hora DateTime,
    FOREIGN KEY (Id_Usuario) REFERENCES Usuario(ID_Usuario),
    FOREIGN KEY (Tip_Movimiento) REFERENCES Usuario_Tipo(ID_Usuario_Tipo) -- Se asume que Tip_Movimiento se relaciona con Usuario_Tipo
)


create table In_Out_Varios (
    ID_Movimiento int identity primary key,
    Cod_Usuario int,
    Tipo varchar(50),
    Detalle varchar(50),
    Monto varchar(50),
    Fecha varchar(50),
    FOREIGN KEY (Cod_Usuario) REFERENCES Usuario(ID_Usuario)
)








-- Tabla de tipos de usuario
CREATE TABLE Usuario_Tipo (
    ID_Usuario_Tipo INT IDENTITY PRIMARY KEY,
    Tipo INT,
    Descripcion VARCHAR(50)
);

-- Carga inicial de tipos
INSERT INTO Usuario_Tipo (Tipo, Descripcion)
VALUES (1, 'Empleado'),
       (2, 'Administrador');
GO

-- Tabla de usuarios
CREATE TABLE Usuario (
    ID_Usuario INT IDENTITY PRIMARY KEY,
    DNI INT,
    Nombre VARCHAR(50),
    Apellido VARCHAR(50),
    Telefono VARCHAR(50),
    Email VARCHAR(50),
    ID_Tipo INT FOREIGN KEY REFERENCES Usuario_Tipo(ID_Usuario_Tipo),
    Activo BIT DEFAULT 1
);

INSERT INTO Usuario (DNI, Nombre, Apellido, Telefono, Email, ID_Tipo, Activo)
VALUES
(12345678, 'Federico', 'Feressin', '1122334455', 'fede@mail.com', 2, 1),
(87654321, 'Carlos', 'Gomez', '1144556677', 'carlos@mail.com', 1, 1);
GO

DROP TABLE IF EXISTS Usuario;
DROP TABLE IF EXISTS Usuario_Tipo;
GO
select * from Usuario
SELECT * FROM Usuario_Tipo;
