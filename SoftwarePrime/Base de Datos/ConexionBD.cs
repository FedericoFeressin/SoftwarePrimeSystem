using System;
using System.Configuration;
using System.Data.SqlClient;

namespace Conexion_Base_de_Datos
{
    public static class ConexionBD
    {

        #region ConexionesBD

        private const string ConnectionStringName = "PrimeSystem";

        // Método para obtener una NUEVA conexión
        public static SqlConnection GetConnection()
        {
            ConnectionStringSettings config =
                ConfigurationManager.ConnectionStrings[ConnectionStringName];

            if (config == null || string.IsNullOrWhiteSpace(config.ConnectionString))
            {
                throw new InvalidOperationException(
                    $"No se encontró la cadena de conexión '{ConnectionStringName}' en App.config.");
            }

            return new SqlConnection(config.ConnectionString); //NO abrirla aquí
        }

        #endregion

    }
}
