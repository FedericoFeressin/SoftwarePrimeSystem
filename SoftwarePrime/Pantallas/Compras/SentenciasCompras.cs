using Conexion_Base_de_Datos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwarePrime.Pantallas.Compras
{
    public class RepositorioCompra
    {
        public int GuardarCompra(Compra compra)
        {
            using (var conexion = ConexionBD.GetConnection())
            {
                conexion.Open();

                using (var transaccion = conexion.BeginTransaction())
                {
                    try
                    {
                        int idRemito;

                        string sqlCompra = @"
                        INSERT INTO H_Compras (ID_Proveedor, ID_Usuario, ID_Categoria, Fecha, TipoComprobante, NumeroComprobante, SubTotal, Descuento, Total, Observaciones)
                        OUTPUT INSERTED.ID_Remito
                        VALUES (@Proveedor, @Usuario, @Categoria, @Fecha, @TipoComprobante, @NumeroComprobante, @Subtotal, @Descuento, @Total, @Observaciones)";

                        using (var comando = new SqlCommand(sqlCompra, conexion, transaccion))
                        {
                            comando.Parameters.AddWithValue("@Proveedor", compra.IdProveedor);
                            comando.Parameters.AddWithValue("@Usuario", compra.IdUsuario);
                            comando.Parameters.AddWithValue("@Categoria", (object)compra.IdCategoria ?? DBNull.Value);
                            comando.Parameters.AddWithValue("@Fecha", compra.Fecha);
                            comando.Parameters.AddWithValue("@TipoComprobante", compra.TipoComprobante ?? "Factura");
                            comando.Parameters.AddWithValue("@NumeroComprobante", (object)compra.NumeroComprobante ?? DBNull.Value);
                            comando.Parameters.AddWithValue("@Subtotal", compra.Subtotal);
                            comando.Parameters.AddWithValue("@Descuento", compra.Descuento);
                            comando.Parameters.AddWithValue("@Total", compra.Total);
                            comando.Parameters.AddWithValue("@Observaciones", (object)compra.Observaciones ?? DBNull.Value);

                            idRemito = (int)comando.ExecuteScalar();
                        }

                        foreach (var detalle in compra.Detalles)
                        {
                            GuardarDetalle(conexion, transaccion, idRemito, detalle);
                            AumentarStock(conexion, transaccion, detalle);
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

        private void GuardarDetalle(SqlConnection conexion, SqlTransaction transaccion, int idRemito, DetalleCompra detalle)
        {
            string sqlDetalle = @"
            INSERT INTO H_Compras_Detalle (ID_Remito, ID_Articulo, Descr, Cantidad, P_Unidad)
            VALUES (@Remito, @Articulo, @Descripcion, @Cantidad, @PrecioUnidad)";

            using (var comando = new SqlCommand(sqlDetalle, conexion, transaccion))
            {
                comando.Parameters.AddWithValue("@Remito", idRemito);
                comando.Parameters.AddWithValue("@Articulo", detalle.IdArticulo);
                comando.Parameters.AddWithValue("@Descripcion", detalle.Descripcion);
                comando.Parameters.AddWithValue("@Cantidad", detalle.Cantidad);
                comando.Parameters.AddWithValue("@PrecioUnidad", detalle.PrecioUnidad);

                if (comando.ExecuteNonQuery() <= 0)
                {
                    throw new InvalidOperationException("No se pudo guardar el detalle de la compra.");
                }
            }
        }

        private void AumentarStock(SqlConnection conexion, SqlTransaction transaccion, DetalleCompra detalle)
        {
            string sqlStock = @"
            UPDATE Articulos
            SET StockActual = ISNULL(StockActual, 0) + @Cantidad,
                FechaModificacion = GETDATE()
            WHERE ID_Articulo = @Articulo AND Activo = 1";

            using (var comando = new SqlCommand(sqlStock, conexion, transaccion))
            {
                comando.Parameters.AddWithValue("@Articulo", detalle.IdArticulo);
                comando.Parameters.AddWithValue("@Cantidad", detalle.Cantidad);

                if (comando.ExecuteNonQuery() <= 0)
                {
                    throw new InvalidOperationException(
                        $"No se pudo actualizar el stock del artículo '{detalle.Descripcion}'.");
                }
            }
        }

        // Obtener categorías activas
        public DataTable ObtenerCategorias()
        {
            using (var conexion = ConexionBD.GetConnection())
            {
                string query = @"SELECT ID_Categoria, Codigo, Nombre, Descripcion 
                               FROM Categoria_Compra 
                               WHERE Activo = 1 
                               ORDER BY Nombre";

                using (var adapter = new SqlDataAdapter(query, conexion))
                {
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    return dt;
                }
            }
        }

        // Obtener historial de compras
        public DataTable ObtenerHistorialCompras(DateTime? fechaDesde = null, DateTime? fechaHasta = null, int? idCategoria = null)
        {
            using (var conexion = ConexionBD.GetConnection())
            {
                string query = @"SELECT * FROM V_Compras_Completas WHERE 1=1";

                if (fechaDesde.HasValue)
                    query += " AND Fecha >= @FechaDesde";

                if (fechaHasta.HasValue)
                    query += " AND Fecha <= @FechaHasta";

                if (idCategoria.HasValue && idCategoria.Value > 0)
                    query += " AND Categoria = (SELECT Nombre FROM Categoria_Compra WHERE ID_Categoria = @IdCategoria)";

                query += " ORDER BY Fecha DESC, ID_Remito DESC";

                using (var comando = new SqlCommand(query, conexion))
                {
                    if (fechaDesde.HasValue)
                        comando.Parameters.AddWithValue("@FechaDesde", fechaDesde.Value);

                    if (fechaHasta.HasValue)
                        comando.Parameters.AddWithValue("@FechaHasta", fechaHasta.Value);

                    if (idCategoria.HasValue && idCategoria.Value > 0)
                        comando.Parameters.AddWithValue("@IdCategoria", idCategoria.Value);

                    using (var adapter = new SqlDataAdapter(comando))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        return dt;
                    }
                }
            }
        }

        // Obtener detalles de una compra específica
        public DataTable ObtenerDetalleCompra(int idRemito)
        {
            using (var conexion = ConexionBD.GetConnection())
            {
                string query = @"
                    SELECT 
                        D.ID_Detalle,
                        D.ID_Articulo,
                        A.Codigo,
                        D.Descr AS Descripcion,
                        D.Cantidad,
                        D.P_Unidad AS PrecioUnidad,
                        (D.Cantidad * D.P_Unidad) AS PrecioTotal
                    FROM H_Compras_Detalle D
                    INNER JOIN Articulos A ON D.ID_Articulo = A.ID_Articulo
                    WHERE D.ID_Remito = @IdRemito
                    ORDER BY D.ID_Detalle";

                using (var comando = new SqlCommand(query, conexion))
                {
                    comando.Parameters.AddWithValue("@IdRemito", idRemito);

                    using (var adapter = new SqlDataAdapter(comando))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        return dt;
                    }
                }
            }
        }
    }
}
