using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwarePrime.Pantallas.Articulos
{
    public class ModeloArticulo
    {
        public int ID_Articulo { get; set; }
        public string Codigo { get; set; }
        public string Descripcion { get; set; }
        public int Cantidad { get; set; }
        public decimal Costo { get; set; }
        public decimal PorcentajeGanancia { get; set; } // ej. 25 -> 25%
        public decimal PrecioVenta { get; set; }
        public int ID_Categoria { get; set; }
        public int ID_Subcategoria { get; set; }
        public int ID_Proveedor { get; set; }
        public decimal Ganancia { get;set; }

        public ModeloArticulo() { }

        // Para insert
        public ModeloArticulo(string codigo, string descripcion, int cantidad, decimal costo, decimal porcentajeGanancia, int idCategoria, int idSubcategoria, int idProveedor)
        {
            Codigo = codigo;
            Descripcion = descripcion;
            Cantidad = cantidad;
            Costo = costo;
            PorcentajeGanancia = porcentajeGanancia;
            PrecioVenta = CalcularPrecioVenta(costo, porcentajeGanancia); // Calcula el precio de venta
            ID_Categoria = idCategoria;
            ID_Subcategoria = idSubcategoria;
            ID_Proveedor = idProveedor;
            
        }

        // Metodo para calcular el precio de venta
        public static decimal CalcularPrecioVenta(decimal costo, decimal porcentaje) // Considera porcentaje como 25 para 25% 
        {
            return Math.Round(costo + (costo * porcentaje / 100m), 2); // Redondea a 2 decimales
        }

    }
}
