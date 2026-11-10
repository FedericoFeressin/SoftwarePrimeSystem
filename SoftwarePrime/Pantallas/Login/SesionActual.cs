using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwarePrime.Pantallas.Login
{
    // Clase para almacenar la sesión del usuario actual
    public static class SesionActual
    {
        public static int ID_Usuario { get; set; }
        public static string NombreCompleto { get; set; }
        public static string NombreUsuario { get; set; }
        public static int ID_Tipo { get; set; }
        public static string TipoUsuario { get; set; }
        public static bool EsAdministrador => ID_Tipo == 1;

        public static void LimpiarSesion()
        {
            ID_Usuario = 0;
            NombreCompleto = string.Empty;
            NombreUsuario = string.Empty;
            ID_Tipo = 0;
            TipoUsuario = string.Empty;
        }

        public static bool SesionActiva()
        {
            return ID_Usuario > 0;
        }
    }
}
