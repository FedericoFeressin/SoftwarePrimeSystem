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
        // 🔹 Listar todos los proveedores
        public static DataTable ObtenerProveedores()
        {
            using (SqlConnection conn = ConexionBD.GetConnection())
            {
                conn.Open();
                string query = "SELECT * FROM Proveedores";
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        // 🔹 Agregar proveedor
        public static void AgregarProveedor(ModeloProveedores p)
        {
            using (SqlConnection conn = ConexionBD.GetConnection())
            {
                conn.Open();
                string query = "INSERT INTO Proveedores (Cuit, Proveedor, Nombre, Telefono, Email) " +
                               "VALUES (@Cuit, @Proveedor, @Nombre, @Telefono, @Email)";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Cuit", p.Cuit);
                    cmd.Parameters.AddWithValue("@Proveedor", p.Proveedor);
                    cmd.Parameters.AddWithValue("@Nombre", p.Nombre);
                    cmd.Parameters.AddWithValue("@Telefono", p.Telefono);
                    cmd.Parameters.AddWithValue("@Email", p.Email);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        // 🔹 Modificar proveedor
        public static void ModificarProveedor(ModeloProveedores p)
        {
            using (SqlConnection conn = ConexionBD.GetConnection())
            {
                conn.Open();
                string query = "UPDATE Proveedores SET Cuit=@Cuit, Proveedor=@Proveedor, Nombre=@Nombre, " +
                               "Telefono=@Telefono, Email=@Email WHERE ID_Proveedor=@ID_Proveedor";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@ID_Proveedor", p.ID_Proveedor);
                    cmd.Parameters.AddWithValue("@Cuit", p.Cuit);
                    cmd.Parameters.AddWithValue("@Proveedor", p.Proveedor);
                    cmd.Parameters.AddWithValue("@Nombre", p.Nombre);
                    cmd.Parameters.AddWithValue("@Telefono", p.Telefono);
                    cmd.Parameters.AddWithValue("@Email", p.Email);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        // 🔹 Eliminar proveedor
        public static void EliminarProveedor(int idProveedor)
        {
            using (SqlConnection conn = ConexionBD.GetConnection())
            {
                conn.Open();
                string query = "DELETE FROM Proveedores WHERE ID_Proveedor=@ID_Proveedor";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@ID_Proveedor", idProveedor);
                    cmd.ExecuteNonQuery();
                }
            }
        }

    }
}
