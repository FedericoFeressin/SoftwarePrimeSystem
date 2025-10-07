using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwarePrime.Pantallas.Ventas
{
    public class ClaseSentVentas
    {
        private static string connectionString = "Server=DESKTOP-MJATTDP\\SQLEXPRESS;Database=Prime System;Trusted_Connection=True;";

        // Insertar una nueva venta
        public static void InsertarVenta(ModeloVentas venta)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();
                    string query = "INSERT INTO H_Ventas (Cod_Usuario, ID_Cliente, Subtotal, descu, Total) VALUES (@codUsuario, @idCliente, @subtotal, @descu, @total)";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@codUsuario", venta.Cod_Usuario);
                        cmd.Parameters.AddWithValue("@idCliente", venta.ID_Cliente);
                        cmd.Parameters.AddWithValue("@subtotal", venta.Subtotal);
                        cmd.Parameters.AddWithValue("@descu", venta.Descu);
                        cmd.Parameters.AddWithValue("@total", venta.Total);
                        cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error al insertar venta: " + ex.Message);
                    throw;
                }
            }
        }

        // Modificar una venta existente
        public static void ModificarVenta(ModeloVentas venta)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();
                    string query = "UPDATE H_Ventas SET Cod_Usuario = @codUsuario, ID_Cliente = @idCliente, Subtotal = @subtotal, descu = @descu, Total = @total WHERE ID_Remito = @idRemito";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@codUsuario", venta.Cod_Usuario);
                        cmd.Parameters.AddWithValue("@idCliente", venta.ID_Cliente);
                        cmd.Parameters.AddWithValue("@subtotal", venta.Subtotal);
                        cmd.Parameters.AddWithValue("@descu", venta.Descu);
                        cmd.Parameters.AddWithValue("@total", venta.Total);
                        cmd.Parameters.AddWithValue("@idRemito", venta.ID_Remito);
                        cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error al modificar venta: " + ex.Message);
                    throw;
                }
            }
        }

        // Baja lógica (si tu tabla de ventas tuviera una columna 'Activo')
        // El esquema que proporcionaste no la tiene, así que este método es solo un ejemplo conceptual.
        public static void BajaLogicaVenta(int idRemito)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();
                    string query = "UPDATE H_Ventas SET Activo = 0 WHERE ID_Remito = @idRemito";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@idRemito", idRemito);
                        cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error al dar de baja la venta: " + ex.Message);
                    throw;
                }
            }
        }

        // Listar todas las ventas (se incluye un JOIN a Clientes para obtener el nombre)
        public static List<ModeloVentas> ListarVentas()
        {
            List<ModeloVentas> lista = new List<ModeloVentas>();
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();
                    string query = @"SELECT hv.ID_Remito, hv.Cod_Usuario, hv.Fecha_Hora, hv.ID_Cliente, hv.Subtotal, hv.descu, hv.Total,
                                 c.Nombre as Nombre_Cliente, c.Telefono as Telefono_Cliente, c.Mail as Mail_Cliente
                                 FROM H_Ventas hv
                                 INNER JOIN Clientes c ON hv.ID_Cliente = c.ID_Clientes";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        using (SqlDataReader dr = cmd.ExecuteReader())
                        {
                            while (dr.Read())
                            {
                                lista.Add(new ModeloVentas(
                                    (int)dr["ID_Remito"],
                                    (int)dr["Cod_Usuario"],
                                    dr["Fecha_Hora"].ToString(),
                                    (int)dr["ID_Cliente"],
                                    dr["Subtotal"].ToString(),
                                    dr["descu"].ToString(),
                                    dr["Total"].ToString(),
                                    dr["Nombre_Cliente"].ToString(),
                                    dr["Telefono_Cliente"].ToString(),
                                    dr["Mail_Cliente"].ToString()
                                ));
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error al listar ventas: " + ex.Message);
                    throw;
                }
            }
            return lista;
        }

    }
}
