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
        public long Cuit { get; set; }
        public string Proveedor { get; set; }
        public string Nombre { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }

        public ModeloProveedores() { }

        public ModeloProveedores(int id_proveedor, long cuit, string proveedor, string nombre, string telefono, string email)
        {
            ID_Proveedor = id_proveedor;
            Cuit = cuit;
            Proveedor = proveedor;
            Nombre = nombre;
            Telefono = telefono;
            Email = email;
        }

        // Constructor sin ID (para inserts)
        public ModeloProveedores(long cuit, string proveedor, string nombre, string telefono, string email)
        {
            Cuit = cuit;
            Proveedor = proveedor;
            Nombre = nombre;
            Telefono = telefono;
            Email = email;
        }
    }
}
