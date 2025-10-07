using Conexion_Base_de_Datos;
using SoftwarePrime.Pantallas.Usuario;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;


namespace SoftwarePrime.Pantallas.Usuario
{
    public class ClaseSent
    {


        #region Sentencias SQL para Modulo Usuario

        public static void InsertarUsuario(ModeloUsuario usuario)
        {
            using (SqlConnection con = ConexionBD.GetConnection())
            {
                con.Open(); // Abrir la conexión dentro del using

                string query = @"INSERT INTO Usuario 
                         (DNI, Nombre, Apellido, Telefono, Email, ID_Tipo, Activo)
                         VALUES 
                         (@DNI, @Nombre, @Apellido, @Telefono, @Email, @ID_Tipo, @Activo)";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@DNI", usuario.DNI);
                    cmd.Parameters.AddWithValue("@Nombre", usuario.Nombre);
                    cmd.Parameters.AddWithValue("@Apellido", usuario.Apellido);
                    cmd.Parameters.AddWithValue("@Telefono", usuario.Telefono);
                    cmd.Parameters.AddWithValue("@Email", usuario.Email);
                    cmd.Parameters.AddWithValue("@ID_Tipo", usuario.ID_TipoUsuario);
                    cmd.Parameters.AddWithValue("@Activo", usuario.Activo);

                    cmd.ExecuteNonQuery();
                }
            }
        }


        public static void ModificarUsuario(ModeloUsuario usuario)
        {
            using (SqlConnection con = ConexionBD.GetConnection())
            {
                con.Open();

                string query = @"UPDATE Usuario
                         SET Nombre = @Nombre,
                             Apellido = @Apellido,
                             Telefono = @Telefono,
                             Email = @Email,
                             ID_Tipo = @ID_Tipo,
                             Activo = @Activo
                         WHERE DNI = @DNI";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@DNI", usuario.DNI);
                    cmd.Parameters.AddWithValue("@Nombre", usuario.Nombre);
                    cmd.Parameters.AddWithValue("@Apellido", usuario.Apellido);
                    cmd.Parameters.AddWithValue("@Telefono", usuario.Telefono);
                    cmd.Parameters.AddWithValue("@Email", usuario.Email);
                    cmd.Parameters.AddWithValue("@ID_Tipo", usuario.ID_TipoUsuario);
                    cmd.Parameters.AddWithValue("@Activo", usuario.Activo);

                    int filasAfectadas = cmd.ExecuteNonQuery();
                    if (filasAfectadas == 0)
                        throw new Exception("No se encontró el usuario con ese DNI.");
                }
            }
        }


        public static void BajaLogicaUsuario(int dni)
        {
            using (SqlConnection con = ConexionBD.GetConnection()) // cada llamada crea su propia conexión
            {
                con.Open(); // abrir la conexión aquí
                string query = @"UPDATE Usuario SET Activo = 0 WHERE DNI = @DNI";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@DNI", dni);
                    int filasAfectadas = cmd.ExecuteNonQuery();
                    if (filasAfectadas == 0)
                        throw new Exception("No se encontró el usuario con ese DNI.");
                } // se cierra SqlCommand
                MessageBox.Show("Usuario dado de baja correctamente.");
            } // se cierra SqlConnection automáticamente

            
        }




        #endregion

        

        






    }
}
