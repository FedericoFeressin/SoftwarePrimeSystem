using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwarePrime.Pantallas.Clientes
{
    public class ModeloCliente
    {
        // Atributos
        public int ID_Cliente { get; set; }
        public long? CUIT { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int? ID_Entidad { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }
        public string Direccion { get; set; }
        public bool Activo { get; set; }
        public DateTime FechaCreacion { get; set; }
        public int? ID_Usuario_Creacion { get; set; }
        public DateTime? FechaModificacion { get; set; }
        public int? ID_Usuario_Modificacion { get; set; }

        // Campos adicionales para mostrar en grilla (no en BD)
        public string NombreEntidad { get; set; }

        // Constructor vacío
        public ModeloCliente() 
        { 
            Activo = true;
            FechaCreacion = DateTime.Now;
        }

        // Constructor con parámetros básicos
        public ModeloCliente(long? cuit, string nombre, string apellido, int? idEntidad, string telefono, string email, string direccion)
        {
            CUIT = cuit;
            Nombre = nombre;
            Apellido = apellido;
            ID_Entidad = idEntidad;
            Telefono = telefono;
            Email = email;
            Direccion = direccion;
            Activo = true;
            FechaCreacion = DateTime.Now;
        }
    }
}
