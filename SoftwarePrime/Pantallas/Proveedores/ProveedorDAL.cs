using Conexion_Base_de_Datos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwarePrime.Pantallas.Proveedores
{
    public class ProveedorDAL
    {
        // 🔹 Listar todos los proveedores activos
        public static DataTable ObtenerProveedores()
        {
            using (SqlConnection conn = ConexionBD.GetConnection())
            {
                string query = @"SELECT ID_Proveedor, CUIT, Nombre, RazonSocial, Telefono, Email, Direccion, Activo 
                                FROM Proveedor 
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

        // 🔹 Agregar proveedor
        public static bool AgregarProveedor(ModeloProveedores p, int idUsuario)
        {
            try
            {
                using (SqlConnection conn = ConexionBD.GetConnection())
                {
                    string query = @"INSERT INTO Proveedor (CUIT, Nombre, RazonSocial, Telefono, Email, Direccion, Activo, FechaCreacion, ID_Usuario_Creacion) 
                                   VALUES (@CUIT, @Nombre, @RazonSocial, @Telefono, @Email, @Direccion, @Activo, @FechaCreacion, @ID_Usuario_Creacion)";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@CUIT", p.CUIT);
                        cmd.Parameters.AddWithValue("@Nombre", p.Nombre);
                        cmd.Parameters.AddWithValue("@RazonSocial", (object)p.RazonSocial ?? DBNull.Value);
                        cmd.Parameters.AddWithValue("@Telefono", (object)p.Telefono ?? DBNull.Value);
                        cmd.Parameters.AddWithValue("@Email", (object)p.Email ?? DBNull.Value);
                        cmd.Parameters.AddWithValue("@Direccion", (object)p.Direccion ?? DBNull.Value);
                        cmd.Parameters.AddWithValue("@Activo", p.Activo);
                        cmd.Parameters.AddWithValue("@FechaCreacion", p.FechaCreacion);
                        cmd.Parameters.AddWithValue("@ID_Usuario_Creacion", idUsuario);

                        conn.Open();
                        cmd.ExecuteNonQuery();
                    }
                }
                return true;
            }
            catch (SqlException)
            {
                return false;
            }
        }

        // 🔹 Modificar proveedor
        public static bool ModificarProveedor(ModeloProveedores p, int idUsuario)
        {
            try
            {
                using (SqlConnection conn = ConexionBD.GetConnection())
                {
                    string query = @"UPDATE Proveedor 
                                   SET CUIT = @CUIT, 
                                       Nombre = @Nombre, 
                                       RazonSocial = @RazonSocial, 
                                       Telefono = @Telefono, 
                                       Email = @Email, 
                                       Direccion = @Direccion, 
                                       Activo = @Activo,
                                       FechaModificacion = @FechaModificacion,
                                       ID_Usuario_Modificacion = @ID_Usuario_Modificacion
                                   WHERE ID_Proveedor = @ID_Proveedor";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@ID_Proveedor", p.ID_Proveedor);
                        cmd.Parameters.AddWithValue("@CUIT", p.CUIT);
                        cmd.Parameters.AddWithValue("@Nombre", p.Nombre);
                        cmd.Parameters.AddWithValue("@RazonSocial", (object)p.RazonSocial ?? DBNull.Value);
                        cmd.Parameters.AddWithValue("@Telefono", (object)p.Telefono ?? DBNull.Value);
                        cmd.Parameters.AddWithValue("@Email", (object)p.Email ?? DBNull.Value);
                        cmd.Parameters.AddWithValue("@Direccion", (object)p.Direccion ?? DBNull.Value);
                        cmd.Parameters.AddWithValue("@Activo", p.Activo);
                        cmd.Parameters.AddWithValue("@FechaModificacion", DateTime.Now);
                        cmd.Parameters.AddWithValue("@ID_Usuario_Modificacion", idUsuario);

                        conn.Open();
                        cmd.ExecuteNonQuery();
                    }
                }
                return true;
            }
            catch (SqlException)
            {
                return false;
            }
        }

        // 🔹 Eliminar proveedor (marca como inactivo)
        public static bool EliminarProveedor(int idProveedor, int idUsuario)
        {
            try
            {
                using (SqlConnection conn = ConexionBD.GetConnection())
                {
                    string query = @"UPDATE Proveedor 
                                   SET Activo = 0,
                                       FechaModificacion = @FechaModificacion,
                                       ID_Usuario_Modificacion = @ID_Usuario_Modificacion
                                   WHERE ID_Proveedor = @ID_Proveedor";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@ID_Proveedor", idProveedor);
                        cmd.Parameters.AddWithValue("@FechaModificacion", DateTime.Now);
                        cmd.Parameters.AddWithValue("@ID_Usuario_Modificacion", idUsuario);

                        conn.Open();
                        cmd.ExecuteNonQuery();
                    }
                }
                return true;
            }
            catch (SqlException)
            {
                return false;
            }
        }

        // 🔹 Eliminar proveedor físicamente (usar con precaución)
        public static bool EliminarProveedorFisico(int idProveedor)
        {
            try
            {
                using (SqlConnection conn = ConexionBD.GetConnection())
                {
                    string query = "DELETE FROM Proveedor WHERE ID_Proveedor = @ID_Proveedor";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@ID_Proveedor", idProveedor);

                        conn.Open();
                        cmd.ExecuteNonQuery();
                    }
                }
                return true;
            }
            catch (SqlException)
            {
                // Puede fallar si hay artículos o compras asociadas
                return false;
            }
        }
    }
}
