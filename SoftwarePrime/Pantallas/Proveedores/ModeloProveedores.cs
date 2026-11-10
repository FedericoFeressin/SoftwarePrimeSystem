using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwarePrime.Pantallas.Proveedores
{
    public class ModeloProveedores
    {
        public int ID_Proveedor { get; set; }
        public long CUIT { get; set; }
        public string Nombre { get; set; }
        public string RazonSocial { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }
        public string Direccion { get; set; }
        public bool Activo { get; set; }
        public DateTime FechaCreacion { get; set; }
        public int? ID_Usuario_Creacion { get; set; }
        public DateTime? FechaModificacion { get; set; }
        public int? ID_Usuario_Modificacion { get; set; }

        public ModeloProveedores()
        {
            Activo = true;
            FechaCreacion = DateTime.Now;
        }

        public ModeloProveedores(int id_proveedor, long cuit, string nombre, string razonSocial, string telefono, string email, string direccion, bool activo)
        {
            ID_Proveedor = id_proveedor;
            CUIT = cuit;
            Nombre = nombre;
            RazonSocial = razonSocial;
            Telefono = telefono;
            Email = email;
            Direccion = direccion;
            Activo = activo;
            FechaCreacion = DateTime.Now;
        }
    }
}
