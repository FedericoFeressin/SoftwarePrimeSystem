using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwarePrime.Pantallas.Ventas
{
    public class ModeloVentas
    {
        // Datos de la venta
        public int ID_Remito { get; set; }
        public int Cod_Usuario { get; set; }
        public string Fecha_Hora { get; set; }
        public int ID_Cliente { get; set; }
        public string Subtotal { get; set; }
        public string Descu { get; set; }
        public string Total { get; set; }

        // Datos del cliente (para mostrar en la UI si es necesario)
        public string Nombre_Cliente { get; set; }
        public string Telefono_Cliente { get; set; }
        public string Mail_Cliente { get; set; }


        // Constructor para insertar una nueva venta
        public ModeloVentas(int codUsuario, int idCliente, string subtotal, string descu, string total)
        {
            Cod_Usuario = codUsuario;
            ID_Cliente = idCliente;
            Subtotal = subtotal;
            Descu = descu;
            Total = total;
        }


        // Constructor para listar ventas (con datos del cliente)
        public ModeloVentas(int idRemito, int codUsuario, string fechaHora, int idCliente, string subtotal, string descu, string total, string nombreCliente, string telefonoCliente, string mailCliente)
        {
            ID_Remito = idRemito;
            Cod_Usuario = codUsuario;
            Fecha_Hora = fechaHora;
            ID_Cliente = idCliente;
            Subtotal = subtotal;
            Descu = descu;
            Total = total;
            Nombre_Cliente = nombreCliente;
            Telefono_Cliente = telefonoCliente;
            Mail_Cliente = mailCliente;
        }

    }
}
