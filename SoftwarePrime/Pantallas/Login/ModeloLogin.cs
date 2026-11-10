using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwarePrime.Pantallas.Login
{
    public class ModeloLogin
    {
        public int ID_Login { get; set; }
        public int ID_Usuario { get; set; }
        public string NombreUsuario { get; set; }
        public string Contrasena { get; set; }
        public DateTime FechaCreacion { get; set; }
        public bool Activo { get; set; }

        public ModeloLogin() { }

        public ModeloLogin(int idUsuario, string nombreUsuario, string contrasena)
        {
            ID_Usuario = idUsuario;
            NombreUsuario = nombreUsuario;
            Contrasena = contrasena;
            FechaCreacion = DateTime.Now;
            Activo = true;
        }
    }
}
