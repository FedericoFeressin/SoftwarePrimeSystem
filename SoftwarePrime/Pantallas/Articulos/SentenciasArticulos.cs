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

            using (SqlConnection con = ConexionBD.GetConnection())
            {

                // OBTENER ARTÍCULOS
                string query = "SELECT ID_Articulo, Codigo, Descripcion, Cantidad, Costo, Ganancia, ID_Categoria, ID_Subcategoria, ID_Proveedor FROM Articulos";
                SqlCommand cmd = new SqlCommand(query, con);
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    ModeloArticulo art = new ModeloArticulo();
                    art.ID_Articulo = Convert.ToInt32(reader["ID_Articulo"]);
                    art.Codigo = reader["Codigo"].ToString();
                    art.Descripcion = reader["Descripcion"].ToString();
                    art.Cantidad = Convert.ToInt32(reader["Cantidad"]);
                    art.Costo = Convert.ToDecimal(reader["Costo"]);
                    art.Ganancia = Convert.ToDecimal(reader["Ganancia"]);

                    // Calcular PrecioVenta
                    art.PrecioVenta = art.Costo + (art.Costo * (art.Ganancia / 100));

                    art.ID_Categoria = Convert.ToInt32(reader["ID_Categoria"]);
                    art.ID_Subcategoria = Convert.ToInt32(reader["ID_Subcategoria"]);
                    art.ID_Proveedor = Convert.ToInt32(reader["ID_Proveedor"]);

                    lista.Add(art);
                }
            }

            return lista;
        }

        public DataTable ObtenerCategorias()
        {
            // OBTENER CATEGORÍAS
            using (SqlConnection con = ConexionBD.GetConnection())
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT ID_Categoria, Nombre_Categoria FROM Categorias ORDER BY Nombre_Categoria", con);
                DataTable dt = new DataTable(); da.Fill(dt); return dt;
            }
        }

        public DataTable ObtenerSubcategoriasPorCategoria(int idCategoria)
        {
            // OBTENER SUBCATEGORÍAS SEGÚN CATEGORÍA
            using (SqlConnection con = ConexionBD.GetConnection())
            {
                SqlCommand cmd = new SqlCommand("SELECT ID_Subcategoria, Nombre_Subcategoria FROM SubCategoria WHERE ID_Categoria=@id ORDER BY Nombre_SubCategoria", con);
                cmd.Parameters.AddWithValue("@id", idCategoria);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable(); da.Fill(dt); return dt;
            }
        }

        public DataTable ObtenerProveedores()
        {
            // OBTENER PROVEEDORES
            using (SqlConnection con = ConexionBD.GetConnection())
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT ID_Proveedor, Nombre FROM Proveedores ORDER BY Nombre", con);
                DataTable dt = new DataTable(); da.Fill(dt); return dt;
            }
        }


        public bool AgregarArticulo(ModeloArticulo art)
        {
            // AGREGAR ARTÍCULO
            using (SqlConnection con = ConexionBD.GetConnection())
            {
                string query = @"INSERT INTO Articulos 
        (Codigo, Descripcion, Cantidad, Costo, Ganancia, ID_Categoria, ID_Subcategoria, ID_Proveedor)
        VALUES (@Codigo, @Descripcion, @Cantidad, @Costo, @Ganancia, @Categoria, @Subcategoria, @Proveedor)";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Codigo", art.Codigo);
                cmd.Parameters.AddWithValue("@Descripcion", art.Descripcion);
                cmd.Parameters.AddWithValue("@Cantidad", art.Cantidad);
                cmd.Parameters.AddWithValue("@Costo", art.Costo);
                cmd.Parameters.AddWithValue("@Ganancia", art.Ganancia);
                cmd.Parameters.AddWithValue("@Categoria", art.ID_Categoria);
                cmd.Parameters.AddWithValue("@Subcategoria", art.ID_Subcategoria);
                cmd.Parameters.AddWithValue("@Proveedor", art.ID_Proveedor);

                con.Open();
                int filas = cmd.ExecuteNonQuery();
                return filas > 0; 
            }
        }

        public bool ModificarArticulo(ModeloArticulo art)
        {
            // MODIFICAR ARTÍCULO
            using (SqlConnection con = ConexionBD.GetConnection())
            {
                string query = @"UPDATE Articulos 
        SET Codigo = @Codigo,
            Descripcion = @Descripcion,
            Cantidad = @Cantidad,
            Costo = @Costo,
            Ganancia = @Ganancia,
            ID_Categoria = @Categoria,
            ID_Subcategoria = @Subcategoria,
            ID_Proveedor = @Proveedor
        WHERE ID_Articulo = @ID";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Codigo", art.Codigo);
                cmd.Parameters.AddWithValue("@Descripcion", art.Descripcion);
                cmd.Parameters.AddWithValue("@Cantidad", art.Cantidad);
                cmd.Parameters.AddWithValue("@Costo", art.Costo);
                cmd.Parameters.AddWithValue("@Ganancia", art.Ganancia);
                cmd.Parameters.AddWithValue("@Categoria", art.ID_Categoria);
                cmd.Parameters.AddWithValue("@Subcategoria", art.ID_Subcategoria);
                cmd.Parameters.AddWithValue("@Proveedor", art.ID_Proveedor);
                cmd.Parameters.AddWithValue("@ID", art.ID_Articulo);

                con.Open();
                int filas = cmd.ExecuteNonQuery();
                return filas > 0; 
            }
        }

        public bool EliminarArticulo(int id)
        {
            // ELIMINAR ARTÍCULO
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



    }
}
