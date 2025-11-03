using Conexion_Base_de_Datos;
using SoftwarePrime.Pantallas.Compras;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoftwarePrime.Pantallas
{
    public partial class FrmCompras : Form
    {
        private Compra compraActual; // Mantiene el estado de la compra actual
        private SqlConnection conexion = ConexionBD.GetConnection(); // Conexión a la base de datos     

        public FrmCompras()
        {
            InitializeComponent();
            dgv_Detalle_Compra.SelectionMode = DataGridViewSelectionMode.FullRowSelect; // Selección de fila completa
            dgv_Detalle_Compra.MultiSelect = false; // Deshabilitar selección múltiple
            dgv_Detalle_Compra.AllowUserToAddRows = false; // Deshabilitar la adición de filas por el usuario
            dgv_Detalle_Compra.AllowUserToResizeRows = false; // Deshabilitar el redimensionamiento de filas por el usuario

        }



        #region Eventos Clicks

        private void FrmCompras_Load(object sender, EventArgs e)
        {
            CargarProveedores();
            CargarUsuarios();
            CargarArticulos();
            ConfigurarGrilla();
            EstilizarGrilla();
        }
        private void BTN_Volver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BTN_Agregar_Click(object sender, EventArgs e)
        {
            if (CMB_PROV.SelectedValue == null || CMB_Usuarios.SelectedValue == null || CMB_Cod_Art.SelectedValue == null) // Validar selección
            { 
                MessageBox.Show("Debe seleccionar proveedor, usuario y artículo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (compraActual == null) // Crear nueva compra si no existe
            { 
                int idProveedor = Convert.ToInt32(CMB_PROV.SelectedValue); // Obtener ID del proveedor seleccionado
                int idUsuario = Convert.ToInt32(CMB_Usuarios.SelectedValue); // Obtener ID del usuario seleccionado
                decimal descuento = decimal.TryParse(TXT_Descripcion.Text, out var d) ? d : 0; // Obtener descuento

                compraActual = new Compra(idProveedor, idUsuario, descuento); // Crear nueva instancia de compra
            }

            var row = (DataRowView)CMB_Cod_Art.SelectedItem; // Obtener fila seleccionada del ComboBox de artículos
            int idArticulo = Convert.ToInt32(row["ID_Articulo"]); // Obtener ID del artículo
            string codigo = row["Codigo"].ToString(); // Obtener código del artículo
            string descripcion = row["Descripcion"].ToString(); // Obtener descripción del artículo
            decimal precioUnidad = Convert.ToDecimal(row["Costo"]); // Obtener precio unitario del artículo
            int cantidad = Convert.ToInt32(NUP_Cantidad.Value); // Obtener cantidad del artículo

            var detalle = new DetalleCompra(idArticulo, codigo, descripcion, cantidad, precioUnidad); // Crear nuevo detalle de compra
            compraActual.AgregarDetalle(detalle); // Agregar detalle a la compra actual

            dgv_Detalle_Compra.Rows.Add(idArticulo, codigo, descripcion, cantidad, precioUnidad, detalle.PrecioTotal); // Agregar fila a la grilla de detalles
            TXT_SubTotal.Text = compraActual.Subtotal.ToString("N2"); // Actualizar subtotal
            decimal.TryParse(txt_Descuento.Text, out decimal porcentajeDescuento); // Obtener porcentaje de descuento
            decimal totalConDescuento = AplicarDescuentoPorcentual(compraActual.Subtotal, porcentajeDescuento); // Calcular total con descuento
            TXT_TOTAL.Text = compraActual.Total.ToString("N2"); // Actualizar total


        }

        private void BTN_Guardar_Compra_Click(object sender, EventArgs e)
        {
            if (compraActual == null || compraActual.Detalles.Count == 0) // Validar que haya detalles en la compra
            {
                MessageBox.Show("Debe agregar al menos un artículo.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var repositorio = new RepositorioCompra(); // Crear instancia del repositorio de compras
            try
            {
                int idRemito = repositorio.GuardarCompra(compraActual); // Guardar la compra y obtener el ID del remito
                MessageBox.Show($"Compra registrada con éxito. Nº de Remito: {idRemito}", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarFormulario();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error al guardar la compra:\n" + ex.Message, "Error SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void BTN_Eliminar_Click(object sender, EventArgs e)
        {
            if (dgv_Detalle_Compra.SelectedRows.Count > 0) // Verificar si hay una fila seleccionada
            {
                int index = dgv_Detalle_Compra.SelectedRows[0].Index; // Obtener el índice de la fila seleccionada
                var fila = dgv_Detalle_Compra.Rows[index]; // Obtener la fila seleccionada

                int idArticulo = Convert.ToInt32(fila.Cells["IdArticulo"].Value); // Obtener el ID del artículo de la fila seleccionada
                var detalle = compraActual.Detalles.FirstOrDefault(d => d.IdArticulo == idArticulo); // Buscar el detalle correspondiente en la compra actual

                if (detalle != null) // Verificar si se encontró el detalle
                {
                    compraActual.QuitarDetalle(detalle); // Quitar el detalle de la compra actual
                    dgv_Detalle_Compra.Rows.RemoveAt(index); // Eliminar la fila de la grilla
                    TXT_SubTotal.Text = compraActual.Subtotal.ToString("N2"); // Actualizar subtotal
                    TXT_TOTAL.Text = compraActual.Total.ToString("N2"); // Actualizar total
                }
            }
            else
            {
                MessageBox.Show("Seleccione una fila para eliminar.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


        }

        private void BTN_Cancelar_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
        }

        #endregion

        #region Metodos


        private decimal AplicarDescuentoPorcentual(decimal subtotal, decimal porcentaje) // Método para aplicar descuento porcentual
        {
            if (porcentaje < 0 || porcentaje > 100) // Validar porcentaje
            {
                MessageBox.Show("El descuento debe estar entre 0 y 100%.", "Descuento inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return subtotal; // Retornar subtotal sin descuento
            }

            decimal montoDescuento = subtotal * (porcentaje / 100); // Calcular monto del descuento
            return subtotal - montoDescuento; // Retornar subtotal menos el descuento
        }




        private void EstilizarGrilla()
        {
            dgv_Detalle_Compra.BorderStyle = BorderStyle.None;
            dgv_Detalle_Compra.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(240, 240, 240);
            dgv_Detalle_Compra.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgv_Detalle_Compra.DefaultCellStyle.SelectionBackColor = Color.FromArgb(0, 120, 215);
            dgv_Detalle_Compra.DefaultCellStyle.SelectionForeColor = Color.White;
            dgv_Detalle_Compra.BackgroundColor = Color.White;
            dgv_Detalle_Compra.EnableHeadersVisualStyles = false;
            dgv_Detalle_Compra.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgv_Detalle_Compra.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(0, 120, 215);
            dgv_Detalle_Compra.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgv_Detalle_Compra.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            dgv_Detalle_Compra.DefaultCellStyle.Font = new Font("Segoe UI", 9);
            dgv_Detalle_Compra.RowTemplate.Height = 28;
        }

        public static void LimpiarFormulario()
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form is FrmCompras comprasForm)
                {
                    comprasForm.compraActual = null;
                    comprasForm.dgv_Detalle_Compra.Rows.Clear();
                    comprasForm.TXT_SubTotal.Text = "0.00";
                    comprasForm.TXT_TOTAL.Text = "0.00";
                    comprasForm.txt_Descuento.Text = "0.00";
                    comprasForm.CMB_PROV.SelectedIndex = -1;
                    comprasForm.CMB_Usuarios.SelectedIndex = -1;
                    comprasForm.CMB_Cod_Art.SelectedIndex = -1;
                    comprasForm.NUP_Cantidad.Value = 1;
                    break;
                }
            }
        }

        private void CargarProveedores()
        {
            DataSet ds = new DataSet();
            using (var da = new SqlDataAdapter("SELECT ID_Proveedor, Nombre FROM Proveedores", conexion))
            {
                da.Fill(ds);
            }

            CMB_PROV.DataSource = ds.Tables[0];
            CMB_PROV.DisplayMember = "Nombre";
            CMB_PROV.ValueMember = "ID_Proveedor";
        }


        private void CargarUsuarios()
        {
            DataSet ds = new DataSet();
            using (var da = new SqlDataAdapter("SELECT ID_Usuario, Nombre FROM Usuario", conexion))
            {
                da.Fill(ds);
            }

            CMB_Usuarios.DataSource = ds.Tables[0];
            CMB_Usuarios.DisplayMember = "Nombre";
            CMB_Usuarios.ValueMember = "ID_Usuario";
        }

        private void CargarArticulos()
        {
            DataSet ds = new DataSet();
            using (var da = new SqlDataAdapter("SELECT ID_Articulo, Codigo, Descripcion, Costo FROM Articulos", conexion))
            {
                da.Fill(ds);
            }

            CMB_Cod_Art.DataSource = ds.Tables[0];
            CMB_Cod_Art.DisplayMember = "Codigo";
            CMB_Cod_Art.ValueMember = "ID_Articulo";
        }


        private void ConfigurarGrilla()
        {
            dgv_Detalle_Compra.Columns.Clear();
            dgv_Detalle_Compra.Columns.Add("IdArticulo", "ID Artículo");
            dgv_Detalle_Compra.Columns.Add("Codigo", "Código");
            dgv_Detalle_Compra.Columns.Add("Descripcion", "Descripción");
            dgv_Detalle_Compra.Columns.Add("Cantidad", "Cantidad");
            dgv_Detalle_Compra.Columns.Add("PrecioUnidad", "Precio Unidad");
            dgv_Detalle_Compra.Columns.Add("PrecioTotal", "Precio por Cantidad");

            // 👉 Ajuste de ancho de columnas
            dgv_Detalle_Compra.Columns["IdArticulo"].Width = 80;
            dgv_Detalle_Compra.Columns["Codigo"].Width = 100;
            dgv_Detalle_Compra.Columns["Descripcion"].Width = 200;
            dgv_Detalle_Compra.Columns["Cantidad"].Width = 80;
            dgv_Detalle_Compra.Columns["PrecioUnidad"].Width = 100;
            dgv_Detalle_Compra.Columns["PrecioTotal"].Width = 120;

            // 👉 Formato de moneda
            dgv_Detalle_Compra.Columns["PrecioUnidad"].DefaultCellStyle.Format = "C2";
            dgv_Detalle_Compra.Columns["PrecioTotal"].DefaultCellStyle.Format = "C2";

        }

        #endregion


    }
}
