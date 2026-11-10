using Conexion_Base_de_Datos;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace SoftwarePrime.Pantallas.Ventas
{
    public class ClaseSentVentas
    {
        public int RegistrarVenta(ModeloVentas venta, List<ModeloDetalleVenta> listaDetalle)
        {
            using (SqlConnection conexion = ConexionBD.GetConnection())
            {
                conexion.Open();

                using (SqlTransaction transaccion = conexion.BeginTransaction())
                {
                    try
                    {
                        int idRemito = InsertarVenta(conexion, transaccion, venta);

                        foreach (ModeloDetalleVenta item in listaDetalle)
                        {
                            DescontarStock(conexion, transaccion, item);
                            InsertarDetalleVenta(conexion, transaccion, idRemito, item);
                        }

                        transaccion.Commit();
                        return idRemito;
                    }
                    catch
                    {
                        transaccion.Rollback();
                        throw;
                    }
                }
            }
        }

        private int InsertarVenta(SqlConnection conexion, SqlTransaction transaccion, ModeloVentas venta)
        {
            string query = @"INSERT INTO H_Ventas (ID_Usuario, Fecha, ID_Cliente, Subtotal, Descuento, Total)
                             VALUES (@ID_Usuario, @Fecha, @ID_Cliente, @Subtotal, @Descuento, @Total);
                             SELECT SCOPE_IDENTITY();";

            using (SqlCommand cmd = new SqlCommand(query, conexion, transaccion))
            {
                cmd.Parameters.AddWithValue("@ID_Usuario", venta.Cod_Usuario);
                cmd.Parameters.AddWithValue("@Fecha", venta.Fecha_Hora);
                cmd.Parameters.AddWithValue("@ID_Cliente", venta.ID_Cliente);
                cmd.Parameters.AddWithValue("@Subtotal", venta.Subtotal);
                cmd.Parameters.AddWithValue("@Descuento", venta.Descuento);
                cmd.Parameters.AddWithValue("@Total", venta.Total);

                return Convert.ToInt32(cmd.ExecuteScalar());
            }
        }

        private void InsertarDetalleVenta(SqlConnection conexion, SqlTransaction transaccion, int idRemito, ModeloDetalleVenta item)
        {
            string query = @"INSERT INTO H_Ventas_Detalle (ID_Remito, ID_Articulo, Descr, PrecioUnidad, Cantidad)
                             VALUES (@ID_Remito, @ID_Articulo, @Descr, @PrecioUnidad, @Cantidad)";

            using (SqlCommand cmd = new SqlCommand(query, conexion, transaccion))
            {
                cmd.Parameters.AddWithValue("@ID_Remito", idRemito);
                cmd.Parameters.AddWithValue("@ID_Articulo", item.ID_Articulo);
                cmd.Parameters.AddWithValue("@Descr", item.Descr);
                cmd.Parameters.AddWithValue("@PrecioUnidad", item.PrecioUnidad);
                cmd.Parameters.AddWithValue("@Cantidad", item.Cantidad);

                if (cmd.ExecuteNonQuery() <= 0)
                {
                    throw new InvalidOperationException(
                        $"No se pudo guardar el detalle de la venta del artículo '{item.Descr}'.");
                }
            }
        }

        private void DescontarStock(SqlConnection conexion, SqlTransaction transaccion, ModeloDetalleVenta item)
        {
            string query = @"UPDATE Articulos
                             SET StockActual = StockActual - @Cantidad,
                                 FechaModificacion = GETDATE()
                             WHERE ID_Articulo = @ID_Articulo
                               AND Activo = 1
                               AND StockActual >= @Cantidad";

            using (SqlCommand cmd = new SqlCommand(query, conexion, transaccion))
            {
                cmd.Parameters.AddWithValue("@ID_Articulo", item.ID_Articulo);
                cmd.Parameters.AddWithValue("@Cantidad", item.Cantidad);

                if (cmd.ExecuteNonQuery() <= 0)
                {
                    throw new InvalidOperationException(
                        $"Stock insuficiente para el artículo '{item.Descr}'. " +
                        "Verifique la cantidad disponible antes de guardar la venta.");
                }
            }
        }
    }
}
