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
        public decimal Costo { get; set; }
        public decimal PorcentajeGanancia { get; set; }
        public decimal PrecioVenta { get; set; }
        public int? StockMinimo { get; set; }
        public int? StockActual { get; set; }
        public int ID_Categoria { get; set; }
        public int? ID_Subcategoria { get; set; }
        public int? ID_Proveedor { get; set; }
        public bool Activo { get; set; }
        public DateTime? FechaCreacion { get; set; }
        public DateTime? FechaModificacion { get; set; }

        public int Cantidad { get; set; }

        public ModeloArticulo() 
        {
            Activo = true;
        }

        public ModeloArticulo(string codigo, string descripcion, int cantidad, decimal costo, decimal porcentajeGanancia, int idCategoria, int? idSubcategoria, int? idProveedor)
        {
            Codigo = codigo;
            Descripcion = descripcion;
            Cantidad = cantidad;
            StockMinimo = cantidad;
            StockActual = cantidad;
            Costo = costo;
            PorcentajeGanancia = porcentajeGanancia;
            ID_Categoria = idCategoria;
            ID_Subcategoria = idSubcategoria;
            ID_Proveedor = idProveedor;
            Activo = true;
        }

    }
}
