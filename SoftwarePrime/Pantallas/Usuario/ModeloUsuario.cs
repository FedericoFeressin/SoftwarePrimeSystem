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
       
        public int DNI { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }
        public int ID_TipoUsuario { get; set; }
        public bool Activo { get; set; } = true;


        public ModeloUsuario(int dni, string nombre, string apellido, string telefono, string email, int id_tipo, bool activo)
        {
            DNI = dni;
            Nombre = nombre;
            Apellido = apellido;
            Telefono = telefono;
            Email = email;
            ID_TipoUsuario = id_tipo;
            Activo = activo;
        }


    }
}
