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
        public DateTime Fecha { get; set; }
        public decimal Subtotal { get; private set; }
        public decimal Descuento { get; set; }
        public decimal Total => Subtotal - Descuento; // Propiedad calculada para el total

        public List<DetalleCompra> Detalles { get; private set; } // Lista de detalles de la compra

        public Compra(int idProveedor, int idUsuario, decimal descuento = 0) // Constructor
        {
            IdProveedor = idProveedor;
            IdUsuario = idUsuario;
            Fecha = DateTime.Now;
            Descuento = descuento;
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
