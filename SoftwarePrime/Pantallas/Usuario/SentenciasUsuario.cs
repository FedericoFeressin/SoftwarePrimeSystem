using Conexion_Base_de_Datos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwarePrime.Pantallas.Usuario
{
    public class SentenciasUsuario
    {

        public DataTable MostrarUsuarios()
        {
            using (SqlConnection conexion = ConexionBD.GetConnection())
            {
                DataTable tabla = new DataTable();
                string query = @"SELECT U.ID_Usuario, U.DNI, U.Nombre, U.Apellido, 
                                        U.Telefono, U.Email, 
                                        T.Descripcion AS TipoUsuario, 
                                        U.Activo
                                 FROM Usuario U
                                 INNER JOIN Usuario_Tipo T ON U.ID_Tipo = T.ID_Usuario_Tipo";
                using (SqlCommand cmd = new SqlCommand(query, conexion))
                {
                    conexion.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    tabla.Load(reader);
                }
                return tabla;
            }
        }

        // Insertar usuario
        public void InsertarUsuario(ModeloUsuario usuario)
        {
            using (SqlConnection conexion = ConexionBD.GetConnection())
            {
                string query = @"INSERT INTO Usuario (DNI, Nombre, Apellido, Telefono, Email, ID_Tipo, Activo)
                                 VALUES (@DNI, @Nombre, @Apellido, @Telefono, @Email, @ID_Tipo, @Activo)";
                using (SqlCommand cmd = new SqlCommand(query, conexion))
                {
                    cmd.Parameters.AddWithValue("@DNI", usuario.DNI);
                    cmd.Parameters.AddWithValue("@Nombre", usuario.Nombre);
                    cmd.Parameters.AddWithValue("@Apellido", usuario.Apellido);
                    cmd.Parameters.AddWithValue("@Telefono", usuario.Telefono);
                    cmd.Parameters.AddWithValue("@Email", usuario.Email);
                    cmd.Parameters.AddWithValue("@ID_Tipo", usuario.ID_Tipo);
                    cmd.Parameters.AddWithValue("@Activo", usuario.Activo);

                    conexion.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void ModificarUsuario(ModeloUsuario usuario)
        {
            using (SqlConnection conexion = ConexionBD.GetConnection())
            {
                string query = @"UPDATE Usuario 
                                 SET DNI=@DNI, Nombre=@Nombre, Apellido=@Apellido, 
                                     Telefono=@Telefono, Email=@Email, 
                                     ID_Tipo=@ID_Tipo, Activo=@Activo
                                 WHERE ID_Usuario=@ID_Usuario";
                using (SqlCommand cmd = new SqlCommand(query, conexion))
                {
                    cmd.Parameters.AddWithValue("@ID_Usuario", usuario.ID_Usuario);
                    cmd.Parameters.AddWithValue("@DNI", usuario.DNI);
                    cmd.Parameters.AddWithValue("@Nombre", usuario.Nombre);
                    cmd.Parameters.AddWithValue("@Apellido", usuario.Apellido);
                    cmd.Parameters.AddWithValue("@Telefono", usuario.Telefono);
                    cmd.Parameters.AddWithValue("@Email", usuario.Email);
                    cmd.Parameters.AddWithValue("@ID_Tipo", usuario.ID_Tipo);
                    cmd.Parameters.AddWithValue("@Activo", usuario.Activo);

                    conexion.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        // Eliminar usuario
        public void EliminarUsuario(int idUsuario)
        {
            using (SqlConnection conexion = ConexionBD.GetConnection())
            {
                string query = "DELETE FROM Usuario WHERE ID_Usuario=@ID";
                using (SqlCommand cmd = new SqlCommand(query, conexion))
                {
                    cmd.Parameters.AddWithValue("@ID", idUsuario);
                    conexion.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }

}

