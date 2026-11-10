using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwarePrime.Pantallas.Compras
{
    public class Compra
    {
        public int IdRemito { get; set; }
        public int IdProveedor { get; set; }
        public int IdUsuario { get; set; }
        public int? IdCategoria { get; set; }
        public DateTime Fecha { get; set; }
        public string TipoComprobante { get; set; }
        public string NumeroComprobante { get; set; }
        public decimal Subtotal { get; private set; }
        public decimal Descuento { get; set; }
        public decimal Total => Subtotal - Descuento; // Propiedad calculada para el total
        public string Observaciones { get; set; }
        public DateTime FechaRegistro { get; set; }

        public List<DetalleCompra> Detalles { get; private set; } // Lista de detalles de la compra

        public Compra(int idProveedor, int idUsuario, int? idCategoria = null, decimal descuento = 0) // Constructor
        {
            IdProveedor = idProveedor;
            IdUsuario = idUsuario;
            IdCategoria = idCategoria;
            Fecha = DateTime.Now;
            FechaRegistro = DateTime.Now;
            Descuento = descuento;
            TipoComprobante = "Factura";
            Detalles = new List<DetalleCompra>(); // Inicializar la lista de detalles
            Subtotal = 0;
        }

        public void AgregarDetalle(DetalleCompra detalle) // Método para agregar un detalle a la compra
        { 
            Detalles.Add(detalle); // Agregar el detalle a la lista
            Subtotal += detalle.PrecioTotal; // Actualizar el subtotal
        }

        public void QuitarDetalle(DetalleCompra detalle) // Método para quitar un detalle de la compra
        {
            if (Detalles.Remove(detalle)) // Intentar quitar el detalle de la lista
            {
                Subtotal -= detalle.PrecioTotal; // Actualizar el subtotal si se quitó el detalle
            }
        }
    }

}
