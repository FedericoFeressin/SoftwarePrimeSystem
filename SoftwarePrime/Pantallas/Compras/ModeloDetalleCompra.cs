using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwarePrime.Pantallas.Compras
{
    public class DetalleCompra
    {
        public int IdDetalle { get; set; }
        public int IdArticulo { get; set; }
        public string Codigo { get; set; }
        public string Descripcion { get; set; }
        public int Cantidad { get; set; }
        public decimal PrecioUnidad { get; set; }
        public decimal PrecioTotal => Cantidad * PrecioUnidad; // Propiedad calculada

        public DetalleCompra(int idArticulo, string codigo, string descripcion, int cantidad, decimal precioUnidad) // Constructor sin IdDetalle
        {
            IdArticulo = idArticulo;
            Codigo = codigo;
            Descripcion = descripcion;
            Cantidad = cantidad;
            PrecioUnidad = precioUnidad;
        }
    }

}
