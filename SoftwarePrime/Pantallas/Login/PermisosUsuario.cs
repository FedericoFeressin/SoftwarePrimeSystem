using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwarePrime.Pantallas.Login
{
    // Clase estática para gestionar permisos según el rol del usuario
    public static class PermisosUsuario
    {
        // Tipos de usuario (debe coincidir con la tabla Usuario_Tipo)
        public const int ADMINISTRADOR = 1;
        public const int GERENTE = 2;
        public const int VENDEDOR = 3;
        public const int COMPRADOR = 4;
        public const int CONTADOR = 5;
        public const int RECURSOS_HUMANOS = 6;

        // 🔹 PERMISOS MÓDULO CLIENTES
        public static bool PuedeVerClientes()
        {
            return SesionActual.ID_Tipo == ADMINISTRADOR ||
                   SesionActual.ID_Tipo == GERENTE ||
                   SesionActual.ID_Tipo == VENDEDOR ||
                   SesionActual.ID_Tipo == CONTADOR;
        }

        public static bool PuedeModificarClientes()
        {
            return SesionActual.ID_Tipo == ADMINISTRADOR ||
                   SesionActual.ID_Tipo == GERENTE ||
                   SesionActual.ID_Tipo == VENDEDOR;
        }

        // 🔹 PERMISOS MÓDULO PROVEEDORES
        public static bool PuedeVerProveedores()
        {
            return SesionActual.ID_Tipo == ADMINISTRADOR ||
                   SesionActual.ID_Tipo == GERENTE ||
                   SesionActual.ID_Tipo == COMPRADOR ||
                   SesionActual.ID_Tipo == CONTADOR;
        }

        public static bool PuedeModificarProveedores()
        {
            return SesionActual.ID_Tipo == ADMINISTRADOR ||
                   SesionActual.ID_Tipo == GERENTE ||
                   SesionActual.ID_Tipo == COMPRADOR;
        }

        // 🔹 PERMISOS MÓDULO ARTÍCULOS
        public static bool PuedeVerArticulos()
        {
            return SesionActual.ID_Tipo == ADMINISTRADOR ||
                   SesionActual.ID_Tipo == GERENTE ||
                   SesionActual.ID_Tipo == VENDEDOR ||
                   SesionActual.ID_Tipo == COMPRADOR ||
                   SesionActual.ID_Tipo == CONTADOR;
        }

        public static bool PuedeModificarArticulos()
        {
            return SesionActual.ID_Tipo == ADMINISTRADOR ||
                   SesionActual.ID_Tipo == GERENTE;
        }

        // 🔹 PERMISOS MÓDULO VENTAS
        public static bool PuedeVerVentas()
        {
            return SesionActual.ID_Tipo == ADMINISTRADOR ||
                   SesionActual.ID_Tipo == GERENTE ||
                   SesionActual.ID_Tipo == VENDEDOR ||
                   SesionActual.ID_Tipo == CONTADOR;
        }

        public static bool PuedeRealizarVentas()
        {
            return SesionActual.ID_Tipo == ADMINISTRADOR ||
                   SesionActual.ID_Tipo == GERENTE ||
                   SesionActual.ID_Tipo == VENDEDOR;
        }

        // 🔹 PERMISOS MÓDULO COMPRAS
        public static bool PuedeVerCompras()
        {
            return SesionActual.ID_Tipo == ADMINISTRADOR ||
                   SesionActual.ID_Tipo == GERENTE ||
                   SesionActual.ID_Tipo == COMPRADOR ||
                   SesionActual.ID_Tipo == CONTADOR;
        }

        public static bool PuedeRealizarCompras()
        {
            return SesionActual.ID_Tipo == ADMINISTRADOR ||
                   SesionActual.ID_Tipo == GERENTE ||
                   SesionActual.ID_Tipo == COMPRADOR;
        }

        // 🔹 PERMISOS MÓDULO USUARIOS
        public static bool PuedeVerUsuarios()
        {
            return SesionActual.ID_Tipo == ADMINISTRADOR ||
                   SesionActual.ID_Tipo == RECURSOS_HUMANOS;
        }

        public static bool PuedeModificarUsuarios()
        {
            return SesionActual.ID_Tipo == ADMINISTRADOR ||
                   SesionActual.ID_Tipo == RECURSOS_HUMANOS;
        }

        // 🔹 PERMISOS MÓDULO RECURSOS HUMANOS
        public static bool PuedeGestionarRoles()
        {
            return SesionActual.ID_Tipo == ADMINISTRADOR ||
                   SesionActual.ID_Tipo == RECURSOS_HUMANOS;
        }

        // 🔹 PERMISOS PARA CREAR CUENTAS DE LOGIN
        public static bool PuedeCrearCuentasLogin()
        {
            return SesionActual.ID_Tipo == ADMINISTRADOR ||
                   SesionActual.ID_Tipo == RECURSOS_HUMANOS;
        }

        // 🔹 PERMISOS MÓDULO ESTADO CONTABLE
        public static bool PuedeVerReportes()
        {
            return SesionActual.ID_Tipo == ADMINISTRADOR ||
                   SesionActual.ID_Tipo == GERENTE ||
                   SesionActual.ID_Tipo == CONTADOR;
        }

        // 🔹 MENSAJE DE ACCESO DENEGADO
        public static string MensajeAccesoDenegado()
        {
            return $"Acceso denegado.\nSu rol '{SesionActual.TipoUsuario}' no tiene permisos para esta función.";
        }
    }
}
