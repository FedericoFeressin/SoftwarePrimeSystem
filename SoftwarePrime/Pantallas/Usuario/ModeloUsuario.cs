using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.RightsManagement;
using System.Text;
using System.Threading.Tasks;

namespace SoftwarePrime.Pantallas.Usuario
{
    public class ModeloUsuario
    {

        public int ID_Usuario { get; set; }
        public int DNI { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }
        public int ID_Tipo { get; set; }
        public bool Activo { get; set; }

        // Constructor vacío
        public ModeloUsuario() { }

        // Constructor con parámetros
        public ModeloUsuario(int idUsuario, int dni, string nombre, string apellido, string telefono, string email, int idTipo, bool activo)
        {
            ID_Usuario = idUsuario;
            DNI = dni;
            Nombre = nombre;
            Apellido = apellido;
            Telefono = telefono;
            Email = email;
            ID_Tipo = idTipo;
            Activo = activo;
        }


    }
}
