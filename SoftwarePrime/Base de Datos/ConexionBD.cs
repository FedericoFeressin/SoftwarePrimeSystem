using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;

namespace Conexion_Base_de_Datos
{
    public static class ConexionBD
    {

        #region ConexionesBD
        
        private static string datasource = "DESKTOP-D2AKA1A\\SQLEXPRESS";
        private static string database = "Prime System";

        // Método para obtener una NUEVA conexión
        public static SqlConnection GetConnection()
        {
            string connectionString = $"Data Source={datasource};Initial Catalog={database};Trusted_Connection=True;";
            return new SqlConnection(connectionString); // NO abrirla aquí
        }
        #endregion

        
    }
}
