using Conexion_Base_de_Datos;
using SoftwarePrime.Pantallas.Compras;
using SoftwarePrime;
using SoftwarePrime.Pantallas.Login;
using SoftwarePrime.Pantallas.Proveedores;
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
            CargarCategorias();
            CargarArticulos();
            ConfigurarGrilla();
            EstilizarGrilla();
            EstablecerUsuarioActual();
            DT_Fecha.Value = DateTime.Now;

            // Conectar eventos
            CMB_Nombre_Prod.SelectedIndexChanged += CMB_Nombre_Prod_SelectedIndexChanged;
            NUP_Cantidad.ValueChanged += NUP_Cantidad_ValueChanged;

            // Hacer que los campos de precio sean de solo lectura
            TXT_Precio_Unidad.ReadOnly = true;
            TXT_Precio_x_Cantidad.ReadOnly = true;
            TXT_Descripcion.ReadOnly = true;
        }
        private void BTN_Volver_Click(object sender, EventArgs e)
        {
            FrmControlGestion principal = (FrmControlGestion)this.ParentForm;
            principal.MostrarBienvenida();
            this.Close();
        }

        private void BTN_Agregar_Click(object sender, EventArgs e)
        {
            if (CMB_PROV.SelectedValue == null || CMB_Nombre_Prod.SelectedValue == null) // Validar selección
            { 
                MessageBox.Show("Debe seleccionar proveedor y artículo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (compraActual == null) // Crear nueva compra si no existe
            { 
                int idProveedor = Convert.ToInt32(CMB_PROV.SelectedValue);
                int idUsuario = SesionActual.ID_Usuario; // Usuario de la sesión actual
                //int? idCategoria = CMB_Categoria.SelectedValue != null ? (int?)Convert.ToInt32(CMB_Categoria.SelectedValue) : null;
                int? idCategoria = null; // TODO: Descomentar cuando CMB_Categoria esté agregado
                decimal descuento = decimal.TryParse(txt_Descuento.Text, out var d) ? d : 0;

                compraActual = new Compra(idProveedor, idUsuario, idCategoria, descuento);
            }

            var row = (DataRowView)CMB_Nombre_Prod.SelectedItem; // Obtener fila seleccionada del ComboBox de artículos
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
            if (compraActual == null || compraActual.Detalles.Count == 0)
            {
                MessageBox.Show("Debe agregar al menos un artículo.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validaciones adicionales
            if (CMB_PROV.SelectedValue == null)
            {
                MessageBox.Show("Debe seleccionar un proveedor.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var repositorio = new RepositorioCompra();
            try
            {
                // Asignar datos adicionales antes de guardar
                compraActual.TipoComprobante = "Factura"; // TODO: Usar CMB_TipoComprobante cuando esté agregado
                compraActual.NumeroComprobante = ""; // TODO: Usar TXT_NumeroComprobante cuando esté agregado
                compraActual.Observaciones = ""; // TODO: Usar TXT_Observaciones cuando esté agregado
                compraActual.Fecha = DT_Fecha.Value;

                if (compraActual.IdCategoria == null)
                    compraActual.IdCategoria = 1;

                // Usar el usuario seleccionado en el combobox si hay uno, sino usar el de la sesión
                int idUsuario = CMB_Usuarios.SelectedValue != null 
                    ? Convert.ToInt32(CMB_Usuarios.SelectedValue) 
                    : SesionActual.ID_Usuario;
                compraActual.IdUsuario = idUsuario;

                // Obtener el nombre del proveedor y usuario desde los ComboBox
                string nombreProveedor = CMB_PROV.Text;
                string nombreUsuario = CMB_Usuarios.SelectedValue != null 
                    ? CMB_Usuarios.Text 
                    : SesionActual.NombreCompleto;

                int idRemito = repositorio.GuardarCompra(compraActual);
                MessageBox.Show($"Compra registrada con éxito.\n\nNº de Remito: {idRemito}\nFecha: {compraActual.Fecha:dd/MM/yyyy HH:mm}\nProveedor: {nombreProveedor}\nUsuario: {nombreUsuario}\nTotal: ${compraActual.Total:N2}", 
                    "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarFormulario();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar la compra:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    comprasForm.txt_Descuento.Text = "0";
                    comprasForm.CMB_PROV.SelectedIndex = -1;
                    //comprasForm.CMB_Categoria.SelectedIndex = -1; // TODO: Descomentar cuando esté agregado
                    comprasForm.CMB_Nombre_Prod.SelectedIndex = -1;
                    //comprasForm.CMB_TipoComprobante.SelectedIndex = 0; // TODO: Descomentar cuando esté agregado
                    //comprasForm.TXT_NumeroComprobante.Clear(); // TODO: Descomentar cuando esté agregado
                    //comprasForm.TXT_Observaciones.Clear(); // TODO: Descomentar cuando esté agregado
                    comprasForm.NUP_Cantidad.Value = 1;
                    comprasForm.DT_Fecha.Value = DateTime.Now;
                    break;
                }
            }
        }

        #endregion

        #region Eventos de ComboBox y NumericUpDown

        private void CMB_Nombre_Prod_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CMB_Nombre_Prod.SelectedValue != null && CMB_Nombre_Prod.SelectedIndex >= 0)
            {
                try
                {
                    var row = (DataRowView)CMB_Nombre_Prod.SelectedItem;
                    decimal costo = Convert.ToDecimal(row["Costo"]);
                    string descripcion = row["Descripcion"].ToString();

                    TXT_Precio_Unidad.Text = costo.ToString("N2");
                    TXT_Descripcion.Text = descripcion;

                    CalcularPrecioTotal();
                }
                catch
                {
                    // Ignorar errores durante la inicialización del ComboBox
                }
            }
        }

        private void NUP_Cantidad_ValueChanged(object sender, EventArgs e)
        {
            CalcularPrecioTotal();
        }

        private void CalcularPrecioTotal()
        {
            if (!string.IsNullOrWhiteSpace(TXT_Precio_Unidad.Text) && NUP_Cantidad.Value > 0)
            {
                try
                {
                    decimal precioUnidad = decimal.Parse(TXT_Precio_Unidad.Text);
                    int cantidad = (int)NUP_Cantidad.Value;
                    decimal precioTotal = precioUnidad * cantidad;

                    TXT_Precio_x_Cantidad.Text = precioTotal.ToString("N2");
                }
                catch
                {
                    TXT_Precio_x_Cantidad.Text = "0.00";
                }
            }
            else
            {
                TXT_Precio_x_Cantidad.Text = "0.00";
            }
        }

        #endregion

        #region Metodos de carga

        private void CargarProveedores()
        {
            try
            {
                DataSet ds = new DataSet();
                using (var da = new SqlDataAdapter("SELECT ID_Proveedor, Nombre FROM Proveedor WHERE Activo = 1 ORDER BY Nombre", conexion))
                {
                    da.Fill(ds);
                }

                CMB_PROV.DataSource = ds.Tables[0];
                CMB_PROV.DisplayMember = "Nombre";
                CMB_PROV.ValueMember = "ID_Proveedor";
                CMB_PROV.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar proveedores: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarUsuarios()
        {
            try
            {
                DataSet ds = new DataSet();
                using (var da = new SqlDataAdapter("SELECT ID_Usuario, (Nombre + ' ' + Apellido) AS NombreCompleto FROM Usuario WHERE Activo = 1 ORDER BY Nombre, Apellido", conexion))
                {
                    da.Fill(ds);
                }

                CMB_Usuarios.DataSource = ds.Tables[0];
                CMB_Usuarios.DisplayMember = "NombreCompleto";
                CMB_Usuarios.ValueMember = "ID_Usuario";
                CMB_Usuarios.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar usuarios: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarCategorias()
        {
            try
            {
                var repositorio = new RepositorioCompra();
                DataTable dt = repositorio.ObtenerCategorias();

                // TODO: Descomentar cuando CMB_Categoria esté agregado en el Designer
                //CMB_Categoria.DataSource = dt;
                //CMB_Categoria.DisplayMember = "Nombre";
                //CMB_Categoria.ValueMember = "ID_Categoria";
                //CMB_Categoria.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar categorías: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        // Método para establecer usuario actual
        private void EstablecerUsuarioActual()
        {
            if (SesionActual.ID_Usuario > 0)
            {
                // TODO: Descomentar cuando LBL_UsuarioActual esté agregado en el Designer
                //LBL_UsuarioActual.Text = $"Usuario: {SesionActual.NombreCompleto}";
            }
            else
            {
                //LBL_UsuarioActual.Text = "Usuario: No autenticado";
                MessageBox.Show("No hay una sesión activa. Por favor inicie sesión.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void CargarArticulos()
        {
            DataSet ds = new DataSet();
            using (var da = new SqlDataAdapter("SELECT ID_Articulo, Codigo, Descripcion, Costo, (Codigo + ' - ' + Descripcion) AS ProductoCompleto FROM Articulos WHERE Activo = 1 ORDER BY Codigo", conexion))
            {
                da.Fill(ds);
            }

            CMB_Nombre_Prod.DataSource = ds.Tables[0];
            CMB_Nombre_Prod.DisplayMember = "ProductoCompleto";
            CMB_Nombre_Prod.ValueMember = "ID_Articulo";
        }


        private void ConfigurarGrilla()
        {
            dgv_Detalle_Compra.Columns.Clear();
            dgv_Detalle_Compra.Columns.Add("IdArticulo", "ID Artículo");
            dgv_Detalle_Compra.Columns.Add("Codigo", "Código");
            dgv_Detalle_Compra.Columns.Add("Descripcion", "Descripción");
            dgv_Detalle_Compra.Columns.Add("Cantidad", "Cantidad");
            dgv_Detalle_Compra.Columns.Add("PrecioUnidad", "Precio Unidad");
            dgv_Detalle_Compra.Columns.Add("PrecioTotal", "Precio Total");

            // Configurar como solo lectura
            dgv_Detalle_Compra.ReadOnly = true;
            dgv_Detalle_Compra.AllowUserToAddRows = false;
            dgv_Detalle_Compra.AllowUserToDeleteRows = false;

            // Ocultar columna de ID (se mantiene para la funcionalidad de eliminar)
            dgv_Detalle_Compra.Columns["IdArticulo"].Visible = false;

            // Configuración de la columna Código
            dgv_Detalle_Compra.Columns["Codigo"].Width = 100;
            dgv_Detalle_Compra.Columns["Codigo"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            // Configuración de la columna Descripción (ocupa el espacio restante)
            dgv_Detalle_Compra.Columns["Descripcion"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgv_Detalle_Compra.Columns["Descripcion"].MinimumWidth = 200;
            dgv_Detalle_Compra.Columns["Descripcion"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            // Configuración de la columna Cantidad
            dgv_Detalle_Compra.Columns["Cantidad"].Width = 80;
            dgv_Detalle_Compra.Columns["Cantidad"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            // Configuración de la columna Precio Unidad
            dgv_Detalle_Compra.Columns["PrecioUnidad"].Width = 120;
            dgv_Detalle_Compra.Columns["PrecioUnidad"].DefaultCellStyle.Format = "C2";
            dgv_Detalle_Compra.Columns["PrecioUnidad"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            // Configuración de la columna Precio Total
            dgv_Detalle_Compra.Columns["PrecioTotal"].Width = 120;
            dgv_Detalle_Compra.Columns["PrecioTotal"].DefaultCellStyle.Format = "C2";
            dgv_Detalle_Compra.Columns["PrecioTotal"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            // Establecer el orden de las columnas para mejor visualización
            dgv_Detalle_Compra.Columns["Codigo"].DisplayIndex = 0;
            dgv_Detalle_Compra.Columns["Descripcion"].DisplayIndex = 1;
            dgv_Detalle_Compra.Columns["Cantidad"].DisplayIndex = 2;
            dgv_Detalle_Compra.Columns["PrecioUnidad"].DisplayIndex = 3;
            dgv_Detalle_Compra.Columns["PrecioTotal"].DisplayIndex = 4;
        }

        #endregion


    }
}
