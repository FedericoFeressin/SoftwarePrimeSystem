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
        public int ID_Clientes { get; set; }
        public long Cuit { get; set; }
        public string Nombre { get; set; }
        public string Entidad { get; set; }
        public string Telefono { get; set; }
        public string Mail { get; set; }

        // Constructor vacío
        public ModeloCliente() { }

        // Constructor con parámetros
        public ModeloCliente(long cuit, string nombre, string entidad, string telefono, string mail)
        {
            Cuit = cuit;
            Nombre = nombre;
            Entidad = entidad;
            Telefono = telefono;
            Mail = mail;
        }
    }
}
