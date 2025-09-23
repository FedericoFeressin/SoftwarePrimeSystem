Create table Articulos (
    ID_Articulos int identity primary key,
    Cod_Articulo varchar (50) UNIQUE, -- Agregado UNIQUE para poder ser referenciado
    Art_Desc varchar (50),
    Cod_Categoria int,
    Cod_Subcategoria int,
    ID_Proveedor int,
    FOREIGN KEY (Cod_Categoria) REFERENCES Categorias(ID_Categoria),
    FOREIGN KEY (Cod_Subcategoria) REFERENCES SubCategoria(ID_Subacategoria),
    FOREIGN KEY (ID_Proveedor) REFERENCES Proveedores(ID_Proveedor)
)

Create table Categorias (
    ID_Categoria int identity primary key,
    Categoria varchar (100)
)

Create table Clientes (
    ID_Clientes int identity primary key,
    Cuit int,
    Nombre varchar (50),
    Entidad varchar (50),
    Telefono varchar (50),
    Mail varchar (50)
)

create table H_Compras (
    ID_Remito int identity primary key,
    Cod_Usuario int,
    Fecha_Hora DateTime,
    ID_Proveedor int,
    SubTotal varchar(100),
    Descu varchar (100),
    Total varchar (100),
    FOREIGN KEY (Cod_Usuario) REFERENCES Usuario(ID_Usuario),
    FOREIGN KEY (ID_Proveedor) REFERENCES Proveedores(ID_Proveedor)
)

Create table H_Compras_Detalle (
    ID_Det_Remito int identity primary key,
    ID_Remito int,
    Cod_Art varchar (50),
    Descr varchar(50),
    P_Unidad varchar (50),
    P_por_Cantidad varchar(50),
    FOREIGN KEY (ID_Remito) REFERENCES H_Compras(ID_Remito),
    FOREIGN KEY (Cod_Art) REFERENCES Articulos(Cod_Articulo)
)

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

create table H_Ventas (
    ID_Remito int identity primary key,
    Cod_Usuario int,
    Fecha_Hora varchar(50),
    ID_Cliente int,
    Subtotal Varchar(50),
    descu varchar(50),
    Total varchar (50),
    FOREIGN KEY (Cod_Usuario) REFERENCES Usuario(ID_Usuario),
    FOREIGN KEY (ID_Cliente) REFERENCES Clientes(ID_Clientes)
)

Create table H_Ventas_Detalle (
    ID_Detalle_Remito int identity primary key,
    ID_Remito int,
    Cod_Art varchar(50),
    Descr varchar(50),
    P_Unidad varchar(50),
    Cantidad varchar(50),
    Precio_Por_Cantidad varchar(50),
    FOREIGN KEY (ID_Remito) REFERENCES H_Ventas(ID_Remito),
    FOREIGN KEY (Cod_Art) REFERENCES Articulos(Cod_Articulo)
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

create table Proveedores (
    ID_Proveedor int identity primary key,
    Cuit Int,
    Proveedor varchar (50),
    Nombre varchar(50),
    Telefono varchar(50),
    Email varchar(50)
)

Create table Stock (
    Cod_Articulo varchar (50),
    Cantidad int,
    Costo varchar(50),
    Ganancia int,
    FOREIGN KEY (Cod_Articulo) REFERENCES Articulos(Cod_Articulo)
)

Create table SubCategoria (
    ID_Subacategoria int identity primary key,
    SubCategoria varchar(50),
    ID_Categoria int,
    FOREIGN KEY (ID_Categoria) REFERENCES Categorias(ID_Categoria)
)

Create table Usuario (
    DNI int,
    Nombre varchar(50),
    Apellido varchar(50),
    Telefono varchar(50),
    Email varchar(50),
    ID_Tipo int, -- Cambiado de varchar(50) a int para la relacion
    Activo bit, 
	FOREIGN KEY (ID_Tipo) REFERENCES Usuario_Tipo(ID_Usuario_Tipo)
)

Create table Usuario_Tipo (
    ID_Usuario_Tipo int identity primary key,
    Tipo int,
    Descripcion varchar(50)
)

select * from Usuario
SELECT * FROM Usuario_Tipo;

insert into Usuario (DNI, Nombre, Apellido, Telefono, Email, ID_Tipo, Activo) values (43629306, 'Federico', 'Feressin', '1164599588', 'fede@gmail.com', 2, 1);
INSERT INTO Usuario_Tipo (Tipo, Descripcion) VALUES (1, 'Empleado');
INSERT INTO Usuario_Tipo (Tipo, Descripcion) VALUES (2, 'Administrador');

drop table Usuario_Tipo
