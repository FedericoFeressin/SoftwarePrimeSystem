using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwarePrime.Pantallas.Ventas
{
    public class ModeloVentas
    {
        public int ID_Remito { get; set; }
        public int Cod_Usuario { get; set; }
        public int ID_Cliente { get; set; }
        public DateTime Fecha_Hora { get; set; }
        public decimal Subtotal { get; set; }
        public decimal Descuento { get; set; }
        public decimal Total { get; set; }

        public ModeloVentas(int codUsuario, int idCliente, DateTime fecha, decimal subtotal, decimal descuento, decimal total)
        {
            Cod_Usuario = codUsuario;
            ID_Cliente = idCliente;
            Fecha_Hora = fecha;
            Subtotal = subtotal;
            Descuento = descuento;
            Total = total;
        }


    }
}
