using Conexion_Base_de_Datos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace SoftwarePrime.Pantallas.EstadoContable
{
    public class EstadoContableDAL
    {
        public ModeloEstadoContable ObtenerEstadoContable(DateTime fechaDesde, DateTime fechaHasta, int? idUsuario = null)
        {
            var estado = new ModeloEstadoContable();

            try
            {
                using (SqlConnection con = ConexionBD.GetConnection())
                {
                    con.Open();

                    // Total ingresos por ventas
                    string queryIngresos = @"
                        SELECT ISNULL(SUM(Total), 0) as TotalIngresos, COUNT(*) as CantidadVentas
                        FROM H_Ventas 
                        WHERE Fecha BETWEEN @FechaDesde AND @FechaHasta";

                    if (idUsuario.HasValue)
                        queryIngresos += " AND ID_Usuario = @IDUsuario";

                    using (SqlCommand cmd = new SqlCommand(queryIngresos, con))
                    {
                        cmd.Parameters.AddWithValue("@FechaDesde", fechaDesde);
                        cmd.Parameters.AddWithValue("@FechaHasta", fechaHasta);
                        if (idUsuario.HasValue)
                            cmd.Parameters.AddWithValue("@IDUsuario", idUsuario.Value);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                estado.TotalIngresosPorVentas = reader.GetDecimal(0);
                                estado.CantidadVentasInsumos = reader.GetInt32(1);
                            }
                        }
                    }

                    // Total egresos por compras de insumos (para venta)
                    string queryCompras = @"
                        SELECT ISNULL(SUM(Total), 0) as TotalEgresos, COUNT(*) as CantidadCompras
                        FROM H_Compras 
                        WHERE Fecha BETWEEN @FechaDesde AND @FechaHasta
                        AND ID_Categoria = 1"; // 1 = Insumos para venta

                    if (idUsuario.HasValue)
                        queryCompras += " AND ID_Usuario = @IDUsuario";

                    using (SqlCommand cmd = new SqlCommand(queryCompras, con))
                    {
                        cmd.Parameters.AddWithValue("@FechaDesde", fechaDesde);
                        cmd.Parameters.AddWithValue("@FechaHasta", fechaHasta);
                        if (idUsuario.HasValue)
                            cmd.Parameters.AddWithValue("@IDUsuario", idUsuario.Value);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                estado.TotalEgresosPorCompras = reader.GetDecimal(0);
                                estado.CantidadComprasInsumos = reader.GetInt32(1);
                            }
                        }
                    }

                    // Total egresos por compras varias (no para venta)
                    string queryComprasVarias = @"
                        SELECT ISNULL(SUM(Total), 0) as TotalEgresosVarios, COUNT(*) as CantidadComprasVarias
                        FROM H_Compras 
                        WHERE Fecha BETWEEN @FechaDesde AND @FechaHasta
                        AND ID_Categoria IS NOT NULL
                        AND ID_Categoria != 1"; // Diferente de Insumos para venta

                    if (idUsuario.HasValue)
                        queryComprasVarias += " AND ID_Usuario = @IDUsuario";

                    using (SqlCommand cmd = new SqlCommand(queryComprasVarias, con))
                    {
                        cmd.Parameters.AddWithValue("@FechaDesde", fechaDesde);
                        cmd.Parameters.AddWithValue("@FechaHasta", fechaHasta);
                        if (idUsuario.HasValue)
                            cmd.Parameters.AddWithValue("@IDUsuario", idUsuario.Value);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                estado.TotalEgresosPorComprasVarias = reader.GetDecimal(0);
                                estado.CantidadComprasVarias = reader.GetInt32(1);
                            }
                        }
                    }

                    // Total valor de insumos en stock
                    string queryStock = @"
                        SELECT ISNULL(SUM(StockActual * Costo), 0) as ValorStock
                        FROM Articulos 
                        WHERE Activo = 1";

                    using (SqlCommand cmd = new SqlCommand(queryStock, con))
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                estado.TotalInsumosEnStock = reader.GetDecimal(0);
                            }
                        }
                    }

                    // Calcular saldo total
                    estado.SaldoTotal = estado.TotalIngresosPorVentas - 
                                       (estado.TotalEgresosPorCompras + estado.TotalEgresosPorComprasVarias);
                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Error al obtener estado contable: " + ex.Message, 
                    "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }

            return estado;
        }

        public List<ModeloMovimiento> ObtenerBitacoraMovimientos(DateTime fechaDesde, DateTime fechaHasta, int? idUsuario = null)
        {
            var movimientos = new List<ModeloMovimiento>();

            try
            {
                using (SqlConnection con = ConexionBD.GetConnection())
                {
                    con.Open();

                    // Obtener ventas
                    string queryVentas = @"
                        SELECT 
                            v.ID_Remito as ID,
                            v.Fecha,
                            'Venta' as Tipo,
                            CONCAT(u.Apellido, ', ', u.Nombre) as Usuario,
                            CONCAT('Venta a Cliente: ', c.Apellido, ', ', c.Nombre) as Descripcion,
                            v.Total as Ingreso,
                            0 as Egreso,
                            v.ID_Remito as Referencia
                        FROM H_Ventas v
                        INNER JOIN Usuario u ON v.ID_Usuario = u.ID_Usuario
                        INNER JOIN Cliente c ON v.ID_Cliente = c.ID_Cliente
                        WHERE v.Fecha BETWEEN @FechaDesde AND @FechaHasta";

                    if (idUsuario.HasValue)
                        queryVentas += " AND v.ID_Usuario = @IDUsuario";

                    using (SqlCommand cmd = new SqlCommand(queryVentas, con))
                    {
                        cmd.Parameters.AddWithValue("@FechaDesde", fechaDesde);
                        cmd.Parameters.AddWithValue("@FechaHasta", fechaHasta);
                        if (idUsuario.HasValue)
                            cmd.Parameters.AddWithValue("@IDUsuario", idUsuario.Value);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                movimientos.Add(new ModeloMovimiento
                                {
                                    ID_Movimiento = movimientos.Count + 1,
                                    Fecha = reader["Fecha"] != DBNull.Value ? Convert.ToDateTime(reader["Fecha"]) : DateTime.Now,
                                    TipoMovimiento = reader["Tipo"] != DBNull.Value ? reader["Tipo"].ToString() : "Venta",
                                    Usuario = reader["Usuario"] != DBNull.Value ? reader["Usuario"].ToString() : "Sin usuario",
                                    Descripcion = reader["Descripcion"] != DBNull.Value ? reader["Descripcion"].ToString() : "Sin descripción",
                                    Ingreso = reader["Ingreso"] != DBNull.Value ? Convert.ToDecimal(reader["Ingreso"]) : 0,
                                    Egreso = reader["Egreso"] != DBNull.Value ? Convert.ToDecimal(reader["Egreso"]) : 0,
                                    Referencia = "V-" + (reader["Referencia"] != DBNull.Value ? reader["Referencia"].ToString() : "0")
                                });
                            }
                        }
                    }

                    // Obtener compras de insumos
                    string queryCompras = @"
                        SELECT 
                            c.ID_Remito as ID,
                            c.Fecha,
                            CASE 
                                WHEN cat.Nombre = 'Insumos para venta' THEN 'Compra Insumo'
                                ELSE 'Compra Varia'
                            END as Tipo,
                            CONCAT(u.Apellido, ', ', u.Nombre) as Usuario,
                            CONCAT('Compra a Proveedor: ', p.Nombre, ' - Cat: ', ISNULL(cat.Nombre, 'Sin categoría')) as Descripcion,
                            0 as Ingreso,
                            c.Total as Egreso,
                            c.ID_Remito as Referencia
                        FROM H_Compras c
                        INNER JOIN Usuario u ON c.ID_Usuario = u.ID_Usuario
                        INNER JOIN Proveedor p ON c.ID_Proveedor = p.ID_Proveedor
                        LEFT JOIN Categoria_Compra cat ON c.ID_Categoria = cat.ID_Categoria
                        WHERE c.Fecha BETWEEN @FechaDesde AND @FechaHasta";

                    if (idUsuario.HasValue)
                        queryCompras += " AND c.ID_Usuario = @IDUsuario";

                    queryCompras += " ORDER BY c.Fecha DESC";

                    using (SqlCommand cmd = new SqlCommand(queryCompras, con))
                    {
                        cmd.Parameters.AddWithValue("@FechaDesde", fechaDesde);
                        cmd.Parameters.AddWithValue("@FechaHasta", fechaHasta);
                        if (idUsuario.HasValue)
                            cmd.Parameters.AddWithValue("@IDUsuario", idUsuario.Value);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                movimientos.Add(new ModeloMovimiento
                                {
                                    ID_Movimiento = movimientos.Count + 1,
                                    Fecha = reader["Fecha"] != DBNull.Value ? Convert.ToDateTime(reader["Fecha"]) : DateTime.Now,
                                    TipoMovimiento = reader["Tipo"] != DBNull.Value ? reader["Tipo"].ToString() : "Compra",
                                    Usuario = reader["Usuario"] != DBNull.Value ? reader["Usuario"].ToString() : "Sin usuario",
                                    Descripcion = reader["Descripcion"] != DBNull.Value ? reader["Descripcion"].ToString() : "Sin descripción",
                                    Ingreso = reader["Ingreso"] != DBNull.Value ? Convert.ToDecimal(reader["Ingreso"]) : 0,
                                    Egreso = reader["Egreso"] != DBNull.Value ? Convert.ToDecimal(reader["Egreso"]) : 0,
                                    Referencia = "C-" + (reader["Referencia"] != DBNull.Value ? reader["Referencia"].ToString() : "0")
                                });
                            }
                        }
                    }
                }

                // Ordenar por fecha descendente
                movimientos.Sort((a, b) => b.Fecha.CompareTo(a.Fecha));
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Error al obtener bitácora: " + ex.Message,
                    "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }

            return movimientos;
        }

        public DataTable ObtenerUsuarios()
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection con = ConexionBD.GetConnection())
                {
                    string query = "SELECT ID_Usuario, CONCAT(Apellido, ', ', Nombre) AS NombreCompleto FROM Usuario WHERE Activo = 1 ORDER BY Apellido, Nombre";
                    using (SqlDataAdapter da = new SqlDataAdapter(query, con))
                    {
                        da.Fill(dt);
                    }
                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Error al obtener usuarios: " + ex.Message,
                    "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }
            return dt;
        }
    }
}
