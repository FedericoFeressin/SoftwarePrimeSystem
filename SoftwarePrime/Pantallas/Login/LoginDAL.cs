using Conexion_Base_de_Datos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace SoftwarePrime.Pantallas.Login
{
    public class LoginDAL
    {
        // 🔹 VALIDAR LOGIN
        public static DataTable ValidarLogin(string nombreUsuario, string contrasena)
        {
            // No uso SqlException aquí para que el formulario pueda manejar el error
            using (SqlConnection conn = ConexionBD.GetConnection())
            {
                conn.Open();
                string query = @"SELECT L.ID_Login, L.ID_Usuario, L.NombreUsuario, 
                                        U.Nombre, U.Apellido, U.ID_Tipo, T.Descripcion AS TipoUsuario, U.Activo
                                 FROM Login L
                                 INNER JOIN Usuario U ON L.ID_Usuario = U.ID_Usuario
                                 INNER JOIN Usuario_Tipo T ON U.ID_Tipo = T.ID_Usuario_Tipo
                                 WHERE L.NombreUsuario = @Usuario 
                                 AND L.Contrasena = @Contrasena 
                                 AND L.Activo = 1 
                                 AND U.Activo = 1";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Usuario", nombreUsuario);
                    cmd.Parameters.AddWithValue("@Contrasena", HashPassword(contrasena)); // Hash de contraseña

                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        return dt;
                    }
                }
            }
        }

        // 🔹 CREAR CUENTA DE LOGIN
        public static bool CrearCuentaLogin(int idUsuario, string nombreUsuario, string contrasena)
        {
            try
            {
                using (SqlConnection conn = ConexionBD.GetConnection())
                {
                    conn.Open();

                    // Verificar si ya existe el nombre de usuario
                    string queryVerificar = "SELECT COUNT(*) FROM Login WHERE NombreUsuario = @Usuario";
                    using (SqlCommand cmdVerificar = new SqlCommand(queryVerificar, conn))
                    {
                        cmdVerificar.Parameters.AddWithValue("@Usuario", nombreUsuario);
                        int existe = (int)cmdVerificar.ExecuteScalar();
                        if (existe > 0)
                        {
                            return false; // Ya existe el usuario
                        }
                    }

                    // Insertar nueva cuenta
                    string query = @"INSERT INTO Login (ID_Usuario, NombreUsuario, Contrasena, FechaCreacion, Activo)
                                     VALUES (@ID_Usuario, @NombreUsuario, @Contrasena, @FechaCreacion, @Activo)";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@ID_Usuario", idUsuario);
                        cmd.Parameters.AddWithValue("@NombreUsuario", nombreUsuario);
                        cmd.Parameters.AddWithValue("@Contrasena", HashPassword(contrasena));
                        cmd.Parameters.AddWithValue("@FechaCreacion", DateTime.Now);
                        cmd.Parameters.AddWithValue("@Activo", true);
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

        // 🔹 MODIFICAR CONTRASEÑA
        public static bool ModificarContrasena(int idUsuario, string nuevaContrasena)
        {
            try
            {
                using (SqlConnection conn = ConexionBD.GetConnection())
                {
                    conn.Open();
                    string query = "UPDATE Login SET Contrasena = @Contrasena WHERE ID_Usuario = @ID_Usuario";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@ID_Usuario", idUsuario);
                        cmd.Parameters.AddWithValue("@Contrasena", HashPassword(nuevaContrasena));
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

        // 🔹 DESACTIVAR CUENTA
        public static bool DesactivarCuenta(int idUsuario)
        {
            try
            {
                using (SqlConnection conn = ConexionBD.GetConnection())
                {
                    conn.Open();
                    string query = "UPDATE Login SET Activo = 0 WHERE ID_Usuario = @ID_Usuario";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@ID_Usuario", idUsuario);
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

        // 🔹 OBTENER USUARIOS SIN CUENTA DE LOGIN
        public static DataTable ObtenerUsuariosSinLogin()
        {
            try
            {
                using (SqlConnection conn = ConexionBD.GetConnection())
                {
                    conn.Open();
                    string query = @"SELECT U.ID_Usuario, U.DNI, U.Nombre, U.Apellido, T.Descripcion AS TipoUsuario
                                     FROM Usuario U
                                     INNER JOIN Usuario_Tipo T ON U.ID_Tipo = T.ID_Usuario_Tipo
                                     LEFT JOIN Login L ON L.ID_Usuario = U.ID_Usuario AND L.Activo = 1
                                     WHERE U.Activo = 1 
                                     AND L.ID_Login IS NULL
                                     ORDER BY U.Apellido, U.Nombre";

                    using (SqlDataAdapter da = new SqlDataAdapter(query, conn))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        return dt;
                    }
                }
            }
            catch (SqlException ex)
            {
                throw new Exception($"Error al obtener usuarios sin login: {ex.Message}", ex);
            }
        }

        // 🔹 OBTENER USUARIOS CON CUENTA DE LOGIN
        public static DataTable ObtenerUsuariosConLogin()
        {
            try
            {
                using (SqlConnection conn = ConexionBD.GetConnection())
                {
                    conn.Open();
                    string query = @"SELECT U.ID_Usuario, L.NombreUsuario, U.Nombre, U.Apellido, T.Descripcion AS TipoUsuario
                             FROM Login L
                             INNER JOIN Usuario U ON L.ID_Usuario = U.ID_Usuario
                             INNER JOIN Usuario_Tipo T ON U.ID_Tipo = T.ID_Usuario_Tipo
                             WHERE L.Activo = 1 
                             AND U.Activo = 1
                             ORDER BY U.Apellido, U.Nombre";
                    using (SqlDataAdapter da = new SqlDataAdapter(query, conn))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        return dt;
                    }
                }
            }
            catch (SqlException ex)
            {
                throw new Exception($"Error al obtener usuarios con login: {ex.Message}", ex);
            }
        }

        public static bool ModificarNombreUsuario(int idUsuario, string nuevoNombreUsuario)
        {
            try
            {
                using (SqlConnection conn = ConexionBD.GetConnection())
                {
                    conn.Open();

                    // Verificar si el nuevo nombre ya existe
                    string queryVerificar = "SELECT COUNT(*) FROM Login WHERE NombreUsuario = @Usuario AND ID_Usuario != @ID";
                    using (SqlCommand cmdVerificar = new SqlCommand(queryVerificar, conn))
                    {
                        cmdVerificar.Parameters.AddWithValue("@Usuario", nuevoNombreUsuario);
                        cmdVerificar.Parameters.AddWithValue("@ID", idUsuario);
                        int existe = (int)cmdVerificar.ExecuteScalar();
                        if (existe > 0) return false; // Ya existe ese nombre de usuario
                    }

                    string query = "UPDATE Login SET NombreUsuario = @NombreUsuario WHERE ID_Usuario = @ID_Usuario";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@NombreUsuario", nuevoNombreUsuario);
                        cmd.Parameters.AddWithValue("@ID_Usuario", idUsuario);
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

        // 🔹 HASH DE CONTRASEÑA (SHA256)
        private static string HashPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                StringBuilder builder = new StringBuilder();
                foreach (byte b in bytes)
                {
                    builder.Append(b.ToString("x2"));
                }
                return builder.ToString();
            }
        }
    }
}
