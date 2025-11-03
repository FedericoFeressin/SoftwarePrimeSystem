using Conexion_Base_de_Datos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwarePrime.Pantallas.Ventas
{
    public class ClaseSentVentas
    {
        private readonly SqlConnection conexion;

        public ClaseSentVentas(SqlConnection conn)
        {
            conexion = conn;
        }

        public int InsertarVenta(ModeloVentas venta)
        {
            int idRemito = 0;

            conexion.Open();

            string query = @"INSERT INTO H_Ventas (Cod_Usuario, Fecha_Hora, ID_Cliente, Subtotal, Descuento, Total)
                         VALUES (@Cod_Usuario, @Fecha_Hora, @ID_Cliente, @Subtotal, @Descuento, @Total);
                         SELECT SCOPE_IDENTITY();";

            using (SqlCommand cmd = new SqlCommand(query, conexion))
            {
                cmd.Parameters.AddWithValue("@Cod_Usuario", venta.Cod_Usuario);
                cmd.Parameters.AddWithValue("@Fecha_Hora", venta.Fecha_Hora);
                cmd.Parameters.AddWithValue("@ID_Cliente", venta.ID_Cliente);
                cmd.Parameters.AddWithValue("@Subtotal", venta.Subtotal);
                cmd.Parameters.AddWithValue("@Descuento", venta.Descuento);
                cmd.Parameters.AddWithValue("@Total", venta.Total);

                idRemito = Convert.ToInt32(cmd.ExecuteScalar());
            }

            conexion.Close();
            return idRemito;
        }

        public bool InsertarDetalleVenta(int idRemito, List<ModeloDetalleVenta> listaDetalle)
        {
            bool exito = true;

            conexion.Open();

            foreach (var item in listaDetalle)
            {
                string query = @"INSERT INTO H_Ventas_Detalle (ID_Remito, ID_Articulo, Descr, PrecioUnidad, Cantidad)
                             VALUES (@ID_Remito, @ID_Articulo, @Descr, @PrecioUnidad, @Cantidad)";

                using (SqlCommand cmd = new SqlCommand(query, conexion))
                {
                    cmd.Parameters.AddWithValue("@ID_Remito", idRemito);
                    cmd.Parameters.AddWithValue("@ID_Articulo", item.ID_Articulo);
                    cmd.Parameters.AddWithValue("@Descr", item.Descr);
                    cmd.Parameters.AddWithValue("@PrecioUnidad", item.PrecioUnidad);
                    cmd.Parameters.AddWithValue("@Cantidad", item.Cantidad);

                    int filas = cmd.ExecuteNonQuery();
                    if (filas <= 0)
                    {
                        exito = false;
                        break;
                    }
                }
            }

            conexion.Close();
            return exito;
        }

    }
}
