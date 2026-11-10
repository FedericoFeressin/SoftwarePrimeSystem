using Conexion_Base_de_Datos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwarePrime.Pantallas.Articulos
{
    public class SentenciasArticulos
    {
        public List<ModeloArticulo> ObtenerArticulos()
        {
            // LISTA DE ARTÍCULOS
            List<ModeloArticulo> lista = new List<ModeloArticulo>();

            try
            {
                using (SqlConnection con = ConexionBD.GetConnection())
                {
                    // OBTENER ARTÍCULOS
                    string query = "SELECT ID_Articulo, Codigo, Descripcion, Costo, PorcentajeGanancia, PrecioVenta, StockMinimo, StockActual, ID_Categoria, ID_Subcategoria, ID_Proveedor, Activo FROM Articulos WHERE Activo = 1 ORDER BY Descripcion";
                    SqlCommand cmd = new SqlCommand(query, con);
                    con.Open();
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        ModeloArticulo art = new ModeloArticulo();
                        art.ID_Articulo = Convert.ToInt32(reader["ID_Articulo"]);
                        art.Codigo = reader["Codigo"].ToString();
                        art.Descripcion = reader["Descripcion"].ToString();
                        art.Costo = Convert.ToDecimal(reader["Costo"]);
                        art.PorcentajeGanancia = Convert.ToDecimal(reader["PorcentajeGanancia"]);
                        art.PrecioVenta = reader["PrecioVenta"] != DBNull.Value ? Convert.ToDecimal(reader["PrecioVenta"]) : 0;
                        art.StockMinimo = reader["StockMinimo"] != DBNull.Value ? (int?)Convert.ToInt32(reader["StockMinimo"]) : null;
                        art.StockActual = reader["StockActual"] != DBNull.Value ? (int?)Convert.ToInt32(reader["StockActual"]) : null;
                        art.ID_Categoria = Convert.ToInt32(reader["ID_Categoria"]);
                        art.ID_Subcategoria = reader["ID_Subcategoria"] != DBNull.Value ? (int?)Convert.ToInt32(reader["ID_Subcategoria"]) : null;
                        art.ID_Proveedor = reader["ID_Proveedor"] != DBNull.Value ? (int?)Convert.ToInt32(reader["ID_Proveedor"]) : null;
                        art.Activo = reader["Activo"] != DBNull.Value && Convert.ToBoolean(reader["Activo"]);

                        lista.Add(art);
                    }
                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Error al obtener artículos: " + ex.Message, "Error de Base de Datos", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
                return null;
            }

            return lista;
        }

        public DataTable ObtenerCategorias()
        {
            // OBTENER CATEGORÍAS ACTIVAS
            using (SqlConnection con = ConexionBD.GetConnection())
            {
                using (SqlDataAdapter da = new SqlDataAdapter("SELECT ID_Categoria, Nombre_Categoria FROM Categorias WHERE Activo = 1 ORDER BY Nombre_Categoria", con))
                {
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    return dt;
                }
            }
        }

        public DataTable ObtenerSubcategoriasPorCategoria(int idCategoria)
        {
            // OBTENER SUBCATEGORÍAS ACTIVAS SEGÚN CATEGORÍA
            using (SqlConnection con = ConexionBD.GetConnection())
            {
                SqlCommand cmd = new SqlCommand("SELECT ID_Subcategoria, Nombre_SubCategoria FROM SubCategoria WHERE ID_Categoria=@id AND Activo = 1 ORDER BY Nombre_SubCategoria", con);
                cmd.Parameters.AddWithValue("@id", idCategoria);
                using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                {
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    return dt;
                }
            }
        }

        public DataTable ObtenerProveedores()
        {
            // OBTENER PROVEEDORES ACTIVOS
            using (SqlConnection con = ConexionBD.GetConnection())
            {
                using (SqlDataAdapter da = new SqlDataAdapter("SELECT ID_Proveedor, Nombre FROM Proveedor WHERE Activo = 1 ORDER BY Nombre", con))
                {
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    return dt;
                }
            }
        }


        public bool AgregarArticulo(ModeloArticulo art)
        {
            // AGREGAR ARTÍCULO
            try
            {
                using (SqlConnection con = ConexionBD.GetConnection())
                {
                    string query = @"INSERT INTO Articulos 
        (Codigo, Descripcion, Costo, PorcentajeGanancia, StockMinimo, StockActual, ID_Categoria, ID_Subcategoria, ID_Proveedor, Activo, FechaCreacion)
        VALUES (@Codigo, @Descripcion, @Costo, @PorcentajeGanancia, @StockMinimo, @StockActual, @Categoria, @Subcategoria, @Proveedor, @Activo, @FechaCreacion)";

                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@Codigo", art.Codigo);
                    cmd.Parameters.AddWithValue("@Descripcion", art.Descripcion);
                    cmd.Parameters.AddWithValue("@Costo", art.Costo);
                    cmd.Parameters.AddWithValue("@PorcentajeGanancia", art.PorcentajeGanancia);
                    cmd.Parameters.AddWithValue("@StockMinimo", (object)art.Cantidad ?? 0);
                    cmd.Parameters.AddWithValue("@StockActual", (object)art.Cantidad ?? 0);
                    cmd.Parameters.AddWithValue("@Categoria", art.ID_Categoria);
                    cmd.Parameters.AddWithValue("@Subcategoria", (object)art.ID_Subcategoria ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@Proveedor", (object)art.ID_Proveedor ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@Activo", 1);
                    cmd.Parameters.AddWithValue("@FechaCreacion", DateTime.Now);

                    con.Open();
                    int filas = cmd.ExecuteNonQuery();
                    return filas > 0;
                }
            }
            catch (SqlException)
            {
                return false;
            }
        }

        public bool ModificarArticulo(ModeloArticulo art)
        {
            // MODIFICAR ARTÍCULO
            try
            {
                using (SqlConnection con = ConexionBD.GetConnection())
                {
                    string query = @"UPDATE Articulos 
        SET Codigo = @Codigo,
            Descripcion = @Descripcion,
            Costo = @Costo,
            PorcentajeGanancia = @PorcentajeGanancia,
            StockMinimo = @StockMinimo,
            StockActual = @StockActual,
            ID_Categoria = @Categoria,
            ID_Subcategoria = @Subcategoria,
            ID_Proveedor = @Proveedor,
            FechaModificacion = @FechaModificacion
        WHERE ID_Articulo = @ID";

                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@Codigo", art.Codigo);
                    cmd.Parameters.AddWithValue("@Descripcion", art.Descripcion);
                    cmd.Parameters.AddWithValue("@Costo", art.Costo);
                    cmd.Parameters.AddWithValue("@PorcentajeGanancia", art.PorcentajeGanancia);
                    cmd.Parameters.AddWithValue("@StockMinimo", (object)art.Cantidad ?? 0);
                    cmd.Parameters.AddWithValue("@StockActual", (object)art.Cantidad ?? 0);
                    cmd.Parameters.AddWithValue("@Categoria", art.ID_Categoria);
                    cmd.Parameters.AddWithValue("@Subcategoria", (object)art.ID_Subcategoria ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@Proveedor", (object)art.ID_Proveedor ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@FechaModificacion", DateTime.Now);
                    cmd.Parameters.AddWithValue("@ID", art.ID_Articulo);

                    con.Open();
                    int filas = cmd.ExecuteNonQuery();
                    return filas > 0;
                }
            }
            catch (SqlException)
            {
                return false;
            }
        }

        public bool EliminarArticulo(int id)
        {
            // ELIMINAR ARTÍCULO (SOFT DELETE)
            try
            {
                using (SqlConnection con = ConexionBD.GetConnection())
                {
                    string query = "UPDATE Articulos SET Activo = 0, FechaModificacion = @FechaModificacion WHERE ID_Articulo = @ID";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@ID", id);
                    cmd.Parameters.AddWithValue("@FechaModificacion", DateTime.Now);

                    con.Open();
                    int filas = cmd.ExecuteNonQuery();
                    return filas > 0;
                }
            }
            catch (SqlException)
            {
                return false;
            }
        }

        // Método adicional para eliminar físicamente si es necesario (admin)
        public bool EliminarArticuloFisico(int id)
        {
            try
            {
                using (SqlConnection con = ConexionBD.GetConnection())
                {
                    string query = "DELETE FROM Articulos WHERE ID_Articulo = @ID";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@ID", id);

                    con.Open();
                    int filas = cmd.ExecuteNonQuery();
                    return filas > 0;
                }
            }
            catch (SqlException)
            {
                return false;
            }
        }

        // ============================================
        // MÉTODOS PARA GESTIÓN DE CATEGORÍAS
        // ============================================

        public DataTable ObtenerTodasCategorias()
        {
            using (SqlConnection con = ConexionBD.GetConnection())
            {
                string query = @"SELECT ID_Categoria, Nombre_Categoria, Descripcion, Activo 
                               FROM Categorias 
                               ORDER BY Nombre_Categoria";
                using (SqlDataAdapter da = new SqlDataAdapter(query, con))
                {
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    return dt;
                }
            }
        }

        public bool AgregarCategoria(ModeloCategoria cat)
        {
            try
            {
                using (SqlConnection con = ConexionBD.GetConnection())
                {
                    string query = @"INSERT INTO Categorias (Nombre_Categoria, Descripcion, Activo, FechaCreacion)
                               VALUES (@Nombre, @Descripcion, @Activo, @Fecha)";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@Nombre", cat.Nombre_Categoria);
                    cmd.Parameters.AddWithValue("@Descripcion", (object)cat.Descripcion ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@Activo", cat.Activo);
                    cmd.Parameters.AddWithValue("@Fecha", cat.FechaCreacion);

                    con.Open();
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
            catch (SqlException)
            {
                return false;
            }
        }

        public bool ModificarCategoria(ModeloCategoria cat)
        {
            try
            {
                using (SqlConnection con = ConexionBD.GetConnection())
                {
                    string query = @"UPDATE Categorias 
                               SET Nombre_Categoria = @Nombre,
                                   Descripcion = @Descripcion,
                                   Activo = @Activo
                               WHERE ID_Categoria = @ID";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@Nombre", cat.Nombre_Categoria);
                    cmd.Parameters.AddWithValue("@Descripcion", (object)cat.Descripcion ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@Activo", cat.Activo);
                    cmd.Parameters.AddWithValue("@ID", cat.ID_Categoria);

                    con.Open();
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
            catch (SqlException)
            {
                return false;
            }
        }

        public bool EliminarCategoria(int id)
        {
            try
            {
                using (SqlConnection con = ConexionBD.GetConnection())
                {
                    string query = "UPDATE Categorias SET Activo = 0 WHERE ID_Categoria = @ID";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@ID", id);

                    con.Open();
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
            catch (SqlException)
            {
                return false;
            }
        }

        // Método para eliminar físicamente categoría (solo admin)
        public bool EliminarCategoriaFisico(int id)
        {
            try
            {
                using (SqlConnection con = ConexionBD.GetConnection())
                {
                    string query = "DELETE FROM Categorias WHERE ID_Categoria = @ID";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@ID", id);

                    con.Open();
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
            catch (SqlException)
            {
                // Puede fallar si hay subcategorías o artículos asociados
                return false;
            }
        }

        // ============================================
        // MÉTODOS PARA GESTIÓN DE SUBCATEGORÍAS
        // ============================================

        public DataTable ObtenerTodasSubcategorias()
        {
            using (SqlConnection con = ConexionBD.GetConnection())
            {
                string query = @"SELECT 
                                   S.ID_Subcategoria, 
                                   S.Nombre_SubCategoria, 
                                   S.ID_Categoria,
                                   C.Nombre_Categoria,
                                   S.Descripcion,
                                   S.Activo
                               FROM SubCategoria S
                               INNER JOIN Categorias C ON S.ID_Categoria = C.ID_Categoria
                               ORDER BY C.Nombre_Categoria, S.Nombre_SubCategoria";
                using (SqlDataAdapter da = new SqlDataAdapter(query, con))
                {
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    return dt;
                }
            }
        }

        public bool AgregarSubcategoria(ModeloSubCategoria subcat)
        {
            try
            {
                using (SqlConnection con = ConexionBD.GetConnection())
                {
                    string query = @"INSERT INTO SubCategoria (Nombre_SubCategoria, ID_Categoria, Descripcion, Activo, FechaCreacion)
                               VALUES (@Nombre, @IDCategoria, @Descripcion, @Activo, @Fecha)";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@Nombre", subcat.Nombre_SubCategoria);
                    cmd.Parameters.AddWithValue("@IDCategoria", subcat.ID_Categoria);
                    cmd.Parameters.AddWithValue("@Descripcion", (object)subcat.Descripcion ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@Activo", subcat.Activo);
                    cmd.Parameters.AddWithValue("@Fecha", subcat.FechaCreacion);

                    con.Open();
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
            catch (SqlException)
            {
                return false;
            }
        }

        public bool ModificarSubcategoria(ModeloSubCategoria subcat)
        {
            try
            {
                using (SqlConnection con = ConexionBD.GetConnection())
                {
                    string query = @"UPDATE SubCategoria 
                               SET Nombre_SubCategoria = @Nombre,
                                   ID_Categoria = @IDCategoria,
                                   Descripcion = @Descripcion,
                                   Activo = @Activo
                               WHERE ID_Subcategoria = @ID";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@Nombre", subcat.Nombre_SubCategoria);
                    cmd.Parameters.AddWithValue("@IDCategoria", subcat.ID_Categoria);
                    cmd.Parameters.AddWithValue("@Descripcion", (object)subcat.Descripcion ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@Activo", subcat.Activo);
                    cmd.Parameters.AddWithValue("@ID", subcat.ID_Subcategoria);

                    con.Open();
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
            catch (SqlException)
            {
                return false;
            }
        }

        public bool EliminarSubcategoria(int id)
        {
            try
            {
                using (SqlConnection con = ConexionBD.GetConnection())
                {
                    string query = "UPDATE SubCategoria SET Activo = 0 WHERE ID_Subcategoria = @ID";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@ID", id);

                    con.Open();
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
            catch (SqlException)
            {
                return false;
            }
        }

        // Método para eliminar físicamente subcategoría (solo admin)
        public bool EliminarSubcategoriaFisico(int id)
        {
            try
            {
                using (SqlConnection con = ConexionBD.GetConnection())
                {
                    string query = "DELETE FROM SubCategoria WHERE ID_Subcategoria = @ID";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@ID", id);

                    con.Open();
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
            catch (SqlException)
            {
                // Puede fallar si hay artículos asociados
                return false;
            }
        }
    }
}
