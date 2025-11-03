using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwarePrime.Pantallas.Ventas
{
    public class ModeloDetalleVenta
    {
        public int ID_Detalle_Remito { get; set; }
        public int ID_Articulo { get; set; }
        public string Descr { get; set; }
        public int Cantidad { get; set; }
        public decimal PrecioUnidad { get; set; }
        public decimal Precio_Por_Cantidad { get; set; }

        public ModeloDetalleVenta() { }

        public ModeloDetalleVenta(int idArticulo, string descr, decimal precioUnidad, int cantidad)
        {
            ID_Articulo = idArticulo;
            Descr = descr;
            Cantidad = cantidad;
            PrecioUnidad = precioUnidad;
            Precio_Por_Cantidad = precioUnidad * cantidad;
        }


    }
}
