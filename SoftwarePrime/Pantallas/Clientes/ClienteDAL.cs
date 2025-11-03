using Conexion_Base_de_Datos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwarePrime.Pantallas.Clientes
{
    public class ClienteDAL
    {
        // 🔹 AGREGAR CLIENTE
        public static void AgregarCliente(ModeloCliente cliente)
        {
            using (SqlConnection conn = ConexionBD.GetConnection())
            {
                conn.Open();
                string query = "INSERT INTO Clientes (Cuit, Nombre, Entidad, Telefono, Mail) " +
                               "VALUES (@Cuit, @Nombre, @Entidad, @Telefono, @Mail)";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Cuit", cliente.Cuit);
                    cmd.Parameters.AddWithValue("@Nombre", cliente.Nombre);
                    cmd.Parameters.AddWithValue("@Entidad", cliente.Entidad);
                    cmd.Parameters.AddWithValue("@Telefono", cliente.Telefono);
                    cmd.Parameters.AddWithValue("@Mail", cliente.Mail);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        // 🔹 MODIFICAR CLIENTE
        public static void ModificarCliente(ModeloCliente cliente)
        {
            using (SqlConnection conn = ConexionBD.GetConnection())
            {
                conn.Open();
                string query = "UPDATE Clientes SET Cuit=@Cuit, Nombre=@Nombre, Entidad=@Entidad, Telefono=@Telefono, Mail=@Mail " +
                               "WHERE ID_Clientes=@ID_Clientes";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@ID_Clientes", cliente.ID_Clientes);
                    cmd.Parameters.AddWithValue("@Cuit", cliente.Cuit);
                    cmd.Parameters.AddWithValue("@Nombre", cliente.Nombre);
                    cmd.Parameters.AddWithValue("@Entidad", cliente.Entidad);
                    cmd.Parameters.AddWithValue("@Telefono", cliente.Telefono);
                    cmd.Parameters.AddWithValue("@Mail", cliente.Mail);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        // 🔹 ELIMINAR CLIENTE
        public static void EliminarCliente(int idCliente)
        {
            using (SqlConnection conn = ConexionBD.GetConnection())
            {
                conn.Open();
                string query = "DELETE FROM Clientes WHERE ID_Clientes=@ID_Clientes";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@ID_Clientes", idCliente);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public static DataTable ObtenerClientes()
        {
            using (SqlConnection conn = ConexionBD.GetConnection())
            {
                conn.Open();
                string query = "SELECT * FROM Clientes";
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        public static DataTable ObtenerEntidades()
        {
            using (SqlConnection conn = ConexionBD.GetConnection())
            {
                conn.Open();
                string query = "SELECT * FROM Entidades ORDER BY Nombre_Entidad;";
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

    }
}
