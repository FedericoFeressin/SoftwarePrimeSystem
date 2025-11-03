using Conexion_Base_de_Datos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwarePrime.Pantallas.Compras
{
    public class RepositorioCompra
    {
        public int GuardarCompra(Compra compra)
        {
            int idRemito;

            using (var conexion = ConexionBD.GetConnection())
            {
                string sqlCompra = @"
                INSERT INTO H_Compras (ID_Proveedor, ID_Usuario, Fecha, SubTotal, Descuento, Total)
                OUTPUT INSERTED.ID_Remito
                VALUES (@Proveedor, @Usuario, @Fecha, @Subtotal, @Descuento, @Total)";

                using (var comando = new SqlCommand(sqlCompra, conexion))
                {
                    comando.Parameters.AddWithValue("@Proveedor", compra.IdProveedor);
                    comando.Parameters.AddWithValue("@Usuario", compra.IdUsuario);
                    comando.Parameters.AddWithValue("@Fecha", compra.Fecha);
                    comando.Parameters.AddWithValue("@Subtotal", compra.Subtotal);
                    comando.Parameters.AddWithValue("@Descuento", compra.Descuento);
                    comando.Parameters.AddWithValue("@Total", compra.Total);

                    conexion.Open();
                    idRemito = (int)comando.ExecuteScalar();
                    conexion.Close();
                }
            }

            foreach (var detalle in compra.Detalles)
            {
                GuardarDetalle(idRemito, detalle);
            }

            return idRemito;
        }

        private void GuardarDetalle(int idRemito, DetalleCompra detalle)
        {
            using (var conexion = ConexionBD.GetConnection())
            {
                string sqlDetalle = @"
                INSERT INTO H_Compras_Detalle (ID_Remito, ID_Articulo, Descr, Cantidad, P_Unidad)
                VALUES (@Remito, @Articulo, @Descripcion, @Cantidad, @PrecioUnidad)";

                using (var comando = new SqlCommand(sqlDetalle, conexion))
                {
                    comando.Parameters.AddWithValue("@Remito", idRemito);
                    comando.Parameters.AddWithValue("@Articulo", detalle.IdArticulo);
                    comando.Parameters.AddWithValue("@Descripcion", detalle.Descripcion);
                    comando.Parameters.AddWithValue("@Cantidad", detalle.Cantidad);
                    comando.Parameters.AddWithValue("@PrecioUnidad", detalle.PrecioUnidad);

                    conexion.Open();
                    comando.ExecuteNonQuery();
                    conexion.Close();
                }
            }
        }
    }
}
