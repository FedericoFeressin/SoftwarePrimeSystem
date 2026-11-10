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
        public static bool AgregarCliente(ModeloCliente cliente)
        {
            try
            {
                using (SqlConnection conn = ConexionBD.GetConnection())
                {
                    conn.Open();
                    string query = @"INSERT INTO Cliente (CUIT, Nombre, Apellido, ID_Entidad, Telefono, Email, Direccion, Activo, FechaCreacion) 
                                    VALUES (@Cuit, @Nombre, @Apellido, @ID_Entidad, @Telefono, @Email, @Direccion, @Activo, @FechaCreacion)";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Cuit", (object)cliente.CUIT ?? DBNull.Value);
                        cmd.Parameters.AddWithValue("@Nombre", (object)cliente.Nombre ?? DBNull.Value);
                        cmd.Parameters.AddWithValue("@Apellido", (object)cliente.Apellido ?? DBNull.Value);
                        cmd.Parameters.AddWithValue("@ID_Entidad", (object)cliente.ID_Entidad ?? DBNull.Value);
                        cmd.Parameters.AddWithValue("@Telefono", (object)cliente.Telefono ?? DBNull.Value);
                        cmd.Parameters.AddWithValue("@Email", (object)cliente.Email ?? DBNull.Value);
                        cmd.Parameters.AddWithValue("@Direccion", (object)cliente.Direccion ?? DBNull.Value);
                        cmd.Parameters.AddWithValue("@Activo", 1);
                        cmd.Parameters.AddWithValue("@FechaCreacion", DateTime.Now);
                        cmd.ExecuteNonQuery();
                    }
                }
                return true;
            }
            catch (SqlException ex)
            {
                System.Windows.Forms.MessageBox.Show("Error al agregar cliente: " + ex.Message);
                return false;
            }
        }

        // 🔹 MODIFICAR CLIENTE
        public static bool ModificarCliente(ModeloCliente cliente)
        {
            try
            {
                using (SqlConnection conn = ConexionBD.GetConnection())
                {
                    conn.Open();
                    string query = @"UPDATE Cliente 
                                    SET CUIT=@Cuit, Nombre=@Nombre, Apellido=@Apellido, 
                                        ID_Entidad=@ID_Entidad, Telefono=@Telefono, Email=@Email, 
                                        Direccion=@Direccion, FechaModificacion=@FechaModificacion
                                    WHERE ID_Cliente=@ID_Cliente";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@ID_Cliente", cliente.ID_Cliente);
                        cmd.Parameters.AddWithValue("@Cuit", (object)cliente.CUIT ?? DBNull.Value);
                        cmd.Parameters.AddWithValue("@Nombre", (object)cliente.Nombre ?? DBNull.Value);
                        cmd.Parameters.AddWithValue("@Apellido", (object)cliente.Apellido ?? DBNull.Value);
                        cmd.Parameters.AddWithValue("@ID_Entidad", (object)cliente.ID_Entidad ?? DBNull.Value);
                        cmd.Parameters.AddWithValue("@Telefono", (object)cliente.Telefono ?? DBNull.Value);
                        cmd.Parameters.AddWithValue("@Email", (object)cliente.Email ?? DBNull.Value);
                        cmd.Parameters.AddWithValue("@Direccion", (object)cliente.Direccion ?? DBNull.Value);
                        cmd.Parameters.AddWithValue("@FechaModificacion", DateTime.Now);
                        cmd.ExecuteNonQuery();
                    }
                }
                return true;
            }
            catch (SqlException ex)
            {
                System.Windows.Forms.MessageBox.Show("Error al modificar cliente: " + ex.Message);
                return false;
            }
        }

        // 🔹 ELIMINAR CLIENTE (Soft Delete)
        public static bool EliminarCliente(int idCliente)
        {
            try
            {
                using (SqlConnection conn = ConexionBD.GetConnection())
                {
                    conn.Open();
                    string query = @"UPDATE Cliente 
                                    SET Activo = 0, FechaModificacion = @FechaModificacion 
                                    WHERE ID_Cliente=@ID_Cliente";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@ID_Cliente", idCliente);
                        cmd.Parameters.AddWithValue("@FechaModificacion", DateTime.Now);
                        cmd.ExecuteNonQuery();
                    }
                }
                return true;
            }
            catch (SqlException ex)
            {
                System.Windows.Forms.MessageBox.Show("Error al eliminar cliente: " + ex.Message);
                return false;
            }
        }

        public static DataTable ObtenerClientes()
        {
            using (SqlConnection conn = ConexionBD.GetConnection())
            {
                conn.Open();
                string query = @"SELECT 
                                    C.ID_Cliente, 
                                    C.CUIT, 
                                    C.Nombre, 
                                    C.Apellido, 
                                    C.ID_Entidad,
                                    E.Nombre AS NombreEntidad,
                                    C.Telefono, 
                                    C.Email, 
                                    C.Direccion,
                                    C.Activo 
                                FROM Cliente C
                                LEFT JOIN Entidad E ON C.ID_Entidad = E.ID_Entidad
                                WHERE C.Activo = 1 
                                ORDER BY C.Nombre";
                using (SqlDataAdapter da = new SqlDataAdapter(query, conn))
                {
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    return dt;
                }
            }
        }

        public static DataTable ObtenerEntidades()
        {
            using (SqlConnection conn = ConexionBD.GetConnection())
            {
                conn.Open();
                string query = @"SELECT ID_Entidad, Nombre 
                                FROM Entidad 
                                WHERE Activo = 1 
                                ORDER BY Nombre";
                using (SqlDataAdapter da = new SqlDataAdapter(query, conn))
                {
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    return dt;
                }
            }
        }

    }
}
