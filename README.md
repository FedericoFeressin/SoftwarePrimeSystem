# SoftwarePrime

<p align="center">
  <img src="SoftwarePrime/Resources/Logo_Prime.png" alt="Logo SoftwarePrime" width="220">
</p>

Sistema de gestión comercial de escritorio desarrollado en **C# con Windows Forms** sobre **.NET Framework 4.8** y **SQL Server**. Integra administración de usuarios y roles, clientes, proveedores, artículos, compras, ventas y un estado contable con bitácora de movimientos.

Proyecto académico de la materia **Programación Orientada a Objetos**.

---

## Tabla de contenidos

- [Características](#características)
- [Módulos](#módulos)
- [Roles y permisos](#roles-y-permisos)
- [Tecnologías](#tecnologías)
- [Arquitectura](#arquitectura)
- [Estructura del proyecto](#estructura-del-proyecto)
- [Requisitos](#requisitos)
- [Instalación y configuración](#instalación-y-configuración)
- [Credenciales de prueba](#credenciales-de-prueba)
- [Base de datos](#base-de-datos)
- [Uso](#uso)
- [Notas y limitaciones conocidas](#notas-y-limitaciones-conocidas)

---

## Características

- Inicio de sesión con contraseñas almacenadas mediante hash **SHA-256**.
- Control de acceso por rol: los botones del menú y las acciones se habilitan u ocultan según los permisos del usuario.
- Gestión completa (alta, modificación y baja lógica) de usuarios, clientes, proveedores, artículos y categorías.
- Registro de compras y ventas con detalle de artículos, subtotal, descuento y total.
- Historial de compras y ventas.
- Estado contable con filtros por fecha y usuario, resumen de ingresos/egresos y bitácora de movimientos.
- Gestión de cuentas de login desde Recursos Humanos (crear cuenta, cambiar contraseña, desactivar).
- Interfaz personalizada: formulario sin bordes, arrastre de ventana, esquinas redondeadas, íconos y estilos de grilla.

## Módulos

| Módulo | Descripción | Formularios principales |
|---|---|---|
| Login | Autenticación contra la tabla `Login` y carga de la sesión actual | `Login` |
| Panel principal | Menú lateral con acceso a los módulos según permisos, reloj y cierre de sesión | `FrmControlGestion` |
| Artículos | ABM de artículos, categorías y subcategorías, control de stock y precios | `FrmArticulos`, `FrmGestionCategorias` |
| Clientes | ABM de clientes y asociación con entidades | `FrmAltaClientes` |
| Proveedores | ABM de proveedores | `FrmProveedores` |
| Compras | Registro de compras con detalle, descuento y total | `FrmCompras` |
| Ventas | Registro de ventas con detalle, descuento y total | `FrmVentas` |
| Usuarios | ABM de empleados/usuarios y asignación de rol | `FrmUsuarios` |
| Recursos Humanos | Accesos a usuarios, clientes, proveedores y gestión de login | `FrmRecursosHumanos`, `FrmGestionLogin` |
| Estado contable | Resumen contable y bitácora de ventas/compras por rango de fechas y usuario | `FrmEstadoContable` |

## Roles y permisos

Los permisos se definen en `SoftwarePrime/Pantallas/Login/PermisosUsuario.cs`. La matriz de acceso es:

| Funcionalidad | Administrador | Gerente | Vendedor | Comprador | Contador | RR. HH. |
|---|:---:|:---:|:---:|:---:|:---:|:---:|
| Ver clientes | Sí | Sí | Sí | No | Sí | No |
| Modificar clientes | Sí | Sí | Sí | No | No | No |
| Ver proveedores | Sí | Sí | No | Sí | Sí | No |
| Modificar proveedores | Sí | Sí | No | Sí | No | No |
| Ver artículos | Sí | Sí | Sí | Sí | Sí | No |
| Modificar artículos | Sí | Sí | No | No | No | No |
| Ver ventas | Sí | Sí | Sí | No | Sí | No |
| Registrar ventas | Sí | Sí | Sí | No | No | No |
| Ver compras | Sí | Sí | No | Sí | Sí | No |
| Registrar compras | Sí | Sí | No | Sí | No | No |
| Ver/modificar usuarios | Sí | No | No | No | No | Sí |
| Gestionar roles y logins | Sí | No | No | No | No | Sí |
| Ver estado contable | Sí | Sí | No | No | Sí | No |

> Los identificadores de rol del script SQL coinciden con las constantes de `PermisosUsuario`: `1 = Administrador`, `2 = Gerente`, `3 = Vendedor`, `4 = Comprador`, `5 = Contador` y `6 = Recursos Humanos`.

## Tecnologías

- **Lenguaje:** C#
- **Framework:** .NET Framework 4.8
- **Interfaz:** Windows Forms (WinForms)
- **Base de datos:** Microsoft SQL Server
- **Acceso a datos:** ADO.NET (`System.Data.SqlClient`)
- **Librería de íconos:** [FontAwesome.Sharp 6.6.0](https://www.nuget.org/packages/FontAwesome.Sharp)
- **IDE recomendado:** Visual Studio 2022

## Arquitectura

La aplicación sigue una separación por capas inspirada en el patrón **DAO/DAL**:

- **Formularios (`Frm*`, `Uc*`)**: presentación, validación de entrada e interacción con el usuario.
- **Modelos (`Modelo*`, `Compra`, `DetalleCompra`, etc.)**: entidades del dominio.
- **Capa de acceso a datos (`*DAL`, `Sentencias*`, `Repositorio*`)**: consultas e inserción/actualización en SQL Server.
- **Conexión (`ConexionBD`)**: clase estática que entrega conexiones `SqlConnection`.
- **Sesión y permisos (`SesionActual`, `PermisosUsuario`)**: estado global del usuario autenticado y reglas de autorización.

Los formularios hijos se cargan dentro del panel central de `FrmControlGestion` (`PanelVista`), sin abrir ventanas independientes.

## Estructura del proyecto

```
SoftwarePrime/
├── SoftwarePrime.sln
├── packages/                          # Paquetes NuGet restaurados
└── SoftwarePrime/
    ├── Program.cs                     # Punto de entrada (abre Login)
    ├── App.config
    ├── SoftwarePrime.csproj
    ├── packages.config
    ├── Base de Datos/
    │   ├── ConexionBD.cs                  # Cadena de conexión
    │   ├── PrimeSystem_DB_Completo.sql    # Script completo desde cero
    │   └── Migracion_PrimeSystem.sql      # Migración no destructiva
    ├── Pantallas/
    │   ├── Principal y Login/         # Login, panel principal y rol
    │   ├── Login/                     # Sesión, permisos, modelo y DAL de login
    │   ├── Articulos/                 # Artículos, categorías y subcategorías
    │   ├── Clientes/
    │   ├── Proveedores/
    │   ├── Compras/
    │   ├── Ventas/
    │   ├── Usuario/
    │   ├── RecursosHumanos/
    │   └── EstadoContable/
    ├── Properties/
    └── Resources/                     # Imágenes, logo, íconos y GIFs
```

## Requisitos

- Windows 10/11
- Visual Studio 2019 o superior (con la carga de trabajo **Desarrollo de escritorio de .NET**)
- .NET Framework 4.8
- Microsoft SQL Server (Express o superior) con autenticación de Windows habilitada
- SQL Server Management Studio (recomendado para ejecutar el script)

## Instalación y configuración

1. **Clonar o descargar el repositorio.**

   ```bash
   git clone <URL-del-repositorio>
   ```

2. **Restaurar los paquetes NuGet.**

   Abrir `SoftwarePrime.sln` en Visual Studio; la restauración se realiza automáticamente. También se puede ejecutar:

   ```powershell
   nuget restore SoftwarePrime.sln
   ```

3. **Crear la base de datos.**

   Abrir `SoftwarePrime/Base de Datos/PrimeSystem_DB_Completo.sql` en SQL Server Management Studio y ejecutarlo. El script:
   - Elimina la base `PrimeSystem` si ya existe.
   - Crea la base y todas las tablas.
   - Carga roles, usuarios, clientes, proveedores, artículos, compras y ventas de ejemplo.

4. **Configurar la cadena de conexión.**

   Editar `SoftwarePrime/App.config` y ajustar la instancia de SQL Server en `connectionStrings`:

   ```xml
   <connectionStrings>
       <add name="PrimeSystem"
            connectionString="Data Source=DESKTOP-D2AKA1A\SQLNET;Initial Catalog=PrimeSystem;Trusted_Connection=True;"
            providerName="System.Data.SqlClient" />
   </connectionStrings>
   ```

   Reemplazar `DESKTOP-D2AKA1A\SQLNET` por el nombre de la instancia local, por ejemplo `localhost\SQLEXPRESS` o `.\SQLEXPRESS`.

   La conexión utiliza autenticación de Windows:

   ```
   Data Source=<instancia>;Initial Catalog=PrimeSystem;Trusted_Connection=True;
   ```

   Si ya existía una base `PrimeSystem` con datos, no hace falta recrearla: ejecutar `SoftwarePrime/Base de Datos/Migracion_PrimeSystem.sql` para actualizar roles, remapear usuarios, normalizar categorías y crear la vista `V_Compras_Completas` sin eliminar datos. El script completo solo debe usarse para crear la base desde cero.

5. **Compilar y ejecutar.**

   Desde Visual Studio, presionar `F5` o usar MSBuild:

   ```powershell
   msbuild SoftwarePrime.sln /p:Configuration=Debug
   ```

   El ejecutable se genera en `SoftwarePrime/bin/Debug/SoftwarePrime.exe`.

## Credenciales de prueba

Cargadas por el script SQL (contraseña para todas: `admin123`):

| Usuario | Contraseña | Rol |
|---|---|---|
| `admin` | `admin123` | Administrador |
| `gerente` | `admin123` | Gerente |
| `vendedor` | `admin123` | Vendedor |
| `comprador` | `admin123` | Comprador |
| `contador` | `admin123` | Contador |
| `rrhh` | `admin123` | Recursos Humanos |

> Las contraseñas se almacenan como hash SHA-256, no en texto plano.

## Base de datos

Base: `PrimeSystem`.

| Tabla | Descripción |
|---|---|
| `Usuario_Tipo` | Tipos/roles de usuario |
| `Usuario` | Empleados y datos personales |
| `Login` | Credenciales de acceso (hash SHA-256) |
| `Entidad` | Empresas asociadas a clientes |
| `Cliente` | Clientes |
| `Proveedor` | Proveedores |
| `Categorias` | Categorías de artículos |
| `SubCategoria` | Subcategorías asociadas a categorías |
| `Articulos` | Artículos, costos, precios y stock |
| `Categoria_Compra` | Categorías de compras |
| `Categoria_Venta` | Categorías de ventas |
| `H_Compras` | Cabecera del historial de compras |
| `H_Compras_Detalle` | Detalle de compras |
| `H_Ventas` | Cabecera del historial de ventas |
| `H_Ventas_Detalle` | Detalle de ventas |
| `V_Compras_Completas` | Vista con el historial de compras y su detalle agregado |

El precio de venta de los artículos se calcula de forma persistida en SQL Server:

```sql
PrecioVenta AS (Costo + (Costo * PorcentajeGanancia / 100)) PERSISTED
```

## Uso

1. Iniciar la aplicación: se abre el formulario de login.
2. Ingresar con una de las cuentas de prueba.
3. En el panel principal, seleccionar un módulo desde el menú lateral.
4. Los módulos no permitidos para el rol no se muestran o muestran un mensaje de acceso denegado.
5. Usar `Inicio` para volver a la pantalla de bienvenida y `Desconectar` para cerrar sesión.

Flujo típico de trabajo:

- Dar de alta categorías y subcategorías.
- Cargar proveedores.
- Cargar artículos asociados a categoría, subcategoría y proveedor.
- Registrar compras para incorporar stock.
- Dar de alta clientes.
- Registrar ventas.
- Consultar el estado contable por rango de fechas.

## Notas y limitaciones conocidas

- El hash de contraseña es SHA-256 sin sal; para un entorno productivo se recomienda un algoritmo con salting (por ejemplo, PBKDF2, bcrypt o Argon2).
- El script SQL contiene sentencias `SELECT` de verificación y datos de ejemplo al final; conviene revisarlo antes de ejecutarlo en un entorno real.
- Algunas clases `UserControl` (`UcVentas`, `UcCompras`, `UcUsuario`, `UcProveedores`, `UcRecursosHumanos`) están vacías o sin uso; forman parte de iteraciones previas del proyecto.
- El código mezcla espacios de nombres (`SoftwarePrime.Pantallas`, `SoftwarePrime.Pantallas.Principal_y_Login`) y estilos de nombres (PascalCase, snake_case y mayúsculas); se recomienda unificar convenciones en una futura refactorización.
- Las compras y ventas actualizan el stock dentro de una transacción; si no hay stock suficiente, la venta se cancela por completo.
- El formulario de compras asigna la categoría `Insumos para venta` por defecto porque el selector de categoría todavía no está agregado al diseñador.

---

**SoftwarePrime** — Sistema de gestión comercial para la materia Programación Orientada a Objetos.
