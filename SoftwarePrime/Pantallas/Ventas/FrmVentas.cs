using Conexion_Base_de_Datos;
using SoftwarePrime.Pantallas.Login;
using SoftwarePrime.Pantallas.Ventas;
using SoftwarePrime;
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
    public partial class FrmVentas : Form
    {
        // variables de la clase
        BindingList<ModeloDetalleVenta> bindingDetalle = new BindingList<ModeloDetalleVenta>();

        public FrmVentas()
        {
            InitializeComponent();
            EstilizarGrilla();
            EstilizarGrilla2();
        }

        #region Eventos Load
        private void FrmVentas_Load(object sender, EventArgs e)
        {
            CargarVentas();
            CargarClientes();
            CargarArticulos(); // ✅ NUEVO: Cargar artículos en ComboBox
            dgv_Detalle.DataSource = bindingDetalle;
            dgv_Detalle.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Configurar fecha actual
            DT_Fecha.Value = DateTime.Now;
            TXT_Descuento.Text = "0";
        }
        #endregion

        #region Eventos Clicks
        private void BTN_Agregar_Art_Click(object sender, EventArgs e)
        {
            // ✅ VALIDACIONES MEJORADAS
            if (string.IsNullOrWhiteSpace(TXT_Cod_Art.Text))
            {
                MessageBox.Show("Debe ingresar o seleccionar un artículo.", "Validación", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(TXT_Cod_Art.Text, out int idArticulo) || idArticulo <= 0)
            {
                MessageBox.Show("El código del artículo no es válido.", "Validación", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(TXT_Cantidad.Text, out int cantidad) || cantidad <= 0)
            {
                MessageBox.Show("La cantidad debe ser un número mayor a cero.", "Validación", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int stockDisponible = ObtenerStockActual(idArticulo);
            if (stockDisponible <= 0)
            {
                MessageBox.Show("El artículo seleccionado no tiene stock disponible.", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cantidad > stockDisponible)
            {
                MessageBox.Show($"La cantidad solicitada supera el stock disponible ({stockDisponible}).", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // ✅ Verificar si ya existe en el detalle
            if (bindingDetalle.Any(d => d.ID_Articulo == idArticulo))
            {
                MessageBox.Show("El artículo ya ha sido agregado. Use eliminar para quitarlo.", "Validación", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // ✅ Validar precio unitario
            if (!decimal.TryParse(TXT_Precio_Unitario.Text, out decimal precioUnidad) || precioUnidad <= 0)
            {
                MessageBox.Show("El precio unitario debe ser un número mayor a cero.", "Validación", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string descripcion = TXT_Descripcion.Text;

            // ✅ Crear el detalle
            var detalle = new ModeloDetalleVenta(idArticulo, descripcion, precioUnidad, cantidad);
            bindingDetalle.Add(detalle);

            RecalcularTotales();
            LimpiarCamposArticulo();
        }

        private void BTN_Guardar_Venta_Click(object sender, EventArgs e)
        {
            // ✅ VALIDACIONES COMPLETAS
            if (CMB_Clientes.SelectedValue == null)
            {
                MessageBox.Show("Debe seleccionar un cliente.", "Validación", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (bindingDetalle.Count == 0)
            {
                MessageBox.Show("Debe agregar al menos un artículo a la venta.", "Validación", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                int idCliente = Convert.ToInt32(CMB_Clientes.SelectedValue);
                DateTime fecha = DT_Fecha.Value;
                decimal subtotal = Convert.ToDecimal(TXT_SubTotal.Text);

                // ✅ CORREGIDO: Calcular el monto del descuento, no el porcentaje
                decimal.TryParse(TXT_Descuento.Text, out decimal porcentajeDescuento);
                decimal montoDescuento = subtotal * (porcentajeDescuento / 100);

                var venta = new ModeloVentas(SesionActual.ID_Usuario, idCliente, fecha, subtotal, montoDescuento);
                var sentencias = new ClaseSentVentas();

                int idRemito = sentencias.RegistrarVenta(venta, bindingDetalle.ToList());

                if (idRemito > 0)
                {
                    MessageBox.Show("Venta guardada correctamente con Remito N° " + idRemito, "Éxito", 
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarFormulario();
                    CargarVentas();
                    CargarArticulos();
                }
                else
                {
                    MessageBox.Show("Error al guardar la venta.", "Error", 
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar la venta: " + ex.Message, "Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BTN_Eliminar_Venta_Click(object sender, EventArgs e)
        {
            // ✅ CORREGIDO: Ahora elimina la fila seleccionada del detalle
            if (dgv_Detalle.SelectedRows.Count > 0)
            {
                int index = dgv_Detalle.SelectedRows[0].Index;
                bindingDetalle.RemoveAt(index);
                RecalcularTotales();
            }
            else
            {
                MessageBox.Show("Seleccione un artículo del detalle para eliminar.", "Información", 
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void TXT_Descuento_TextChanged(object sender, EventArgs e)
        {
            RecalcularTotales();
        }

        private void Btn_volver_Click(object sender, EventArgs e)
        {
            FrmControlGestion principal = (FrmControlGestion)this.ParentForm;
            principal.MostrarBienvenida();
            this.Close();
        }

        // ✅ NUEVO: Evento cuando cambia la selección del artículo
        private void CMB_Articulos_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Evitar que se ejecute durante la carga inicial
            if (CMB_Articulos.SelectedValue == null)
                return;

            // Verificar que el valor sea convertible a int (no DataRowView)
            if (CMB_Articulos.SelectedValue is DataRowView)
                return;

            // Intentar convertir de forma segura
            if (int.TryParse(CMB_Articulos.SelectedValue.ToString(), out int idArticulo) && idArticulo > 0)
            {
                CargarDatosArticulo(idArticulo);
            }
        }
        #endregion

        #region Métodos Privados
        private void RecalcularTotales()
        {
            // ✅ CORREGIDO: Cálculo correcto del total
            decimal subtotal = bindingDetalle.Sum(d => d.Precio_Por_Cantidad);
            TXT_SubTotal.Text = subtotal.ToString("F2");

            decimal.TryParse(TXT_Descuento.Text, out decimal porcentajeDescuento);
            decimal montoDescuento = subtotal * (porcentajeDescuento / 100);

            // ✅ FÓRMULA CORRECTA: Total = Subtotal - Descuento
            decimal total = subtotal - montoDescuento;
            TXT_Total.Text = total.ToString("F2");
        }

        private void EstilizarGrilla()
        {
            dgv_Detalle.BorderStyle = BorderStyle.None;
            dgv_Detalle.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(240, 240, 240);
            dgv_Detalle.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgv_Detalle.DefaultCellStyle.SelectionBackColor = Color.FromArgb(0, 120, 215);
            dgv_Detalle.DefaultCellStyle.SelectionForeColor = Color.White;
            dgv_Detalle.BackgroundColor = Color.White;
            dgv_Detalle.EnableHeadersVisualStyles = false;
            dgv_Detalle.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgv_Detalle.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(0, 120, 215);
            dgv_Detalle.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgv_Detalle.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            dgv_Detalle.DefaultCellStyle.Font = new Font("Segoe UI", 9);
            dgv_Detalle.RowTemplate.Height = 28;
            dgv_Detalle.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void EstilizarGrilla2()
        {
            dgv_Ventas.BorderStyle = BorderStyle.None;
            dgv_Ventas.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(240, 240, 240);
            dgv_Ventas.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgv_Ventas.DefaultCellStyle.SelectionBackColor = Color.FromArgb(0, 120, 215);
            dgv_Ventas.DefaultCellStyle.SelectionForeColor = Color.White;
            dgv_Ventas.BackgroundColor = Color.White;
            dgv_Ventas.EnableHeadersVisualStyles = false;
            dgv_Ventas.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgv_Ventas.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(0, 120, 215);
            dgv_Ventas.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgv_Ventas.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            dgv_Ventas.DefaultCellStyle.Font = new Font("Segoe UI", 9);
            dgv_Ventas.RowTemplate.Height = 28;
            dgv_Ventas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void LimpiarFormulario()
        {
            CMB_Clientes.SelectedIndex = -1;
            DT_Fecha.Value = DateTime.Now;
            TXT_SubTotal.Text = "0.00";
            TXT_Descuento.Text = "0";
            TXT_Total.Text = "0.00";
            bindingDetalle.Clear(); // ✅ NUEVO: Limpiar la lista de detalles
            LimpiarCamposArticulo();
        }

        // ✅ NUEVO: Limpiar solo los campos del artículo
        private void LimpiarCamposArticulo()
        {
            TXT_Cod_Art.Clear();
            TXT_Descripcion.Clear();
            TXT_Precio_Unitario.Clear();
            TXT_Cantidad.Clear();
            CMB_Articulos.SelectedIndex = -1;
        }

        private void CargarVentas()
        {
            try
            {
                using (SqlConnection conn = ConexionBD.GetConnection())
                {
                    conn.Open();

                    string query = @"
                        SELECT V.ID_Remito, 
                               V.Fecha AS Fecha_H, 
                               U.Nombre + ' ' + U.Apellido AS Usuario, 
                               C.Nombre + ' ' + ISNULL(C.Apellido, '') AS Cliente, 
                               V.SubTotal, 
                               V.Descuento, 
                               V.Total
                        FROM H_Ventas V
                        INNER JOIN Usuario U ON V.ID_Usuario = U.ID_Usuario
                        INNER JOIN Cliente C ON V.ID_Cliente = C.ID_Cliente
                        ORDER BY V.Fecha DESC";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        DataTable tabla = new DataTable();
                        da.Fill(tabla);
                        dgv_Ventas.DataSource = tabla;

                        if (dgv_Ventas.Columns.Count > 0)
                        {
                            dgv_Ventas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                            if (dgv_Ventas.Columns.Contains("SubTotal"))
                                dgv_Ventas.Columns["SubTotal"].DefaultCellStyle.Format = "C2";

                            if (dgv_Ventas.Columns.Contains("Descuento"))
                                dgv_Ventas.Columns["Descuento"].DefaultCellStyle.Format = "C2";

                            if (dgv_Ventas.Columns.Contains("Total"))
                                dgv_Ventas.Columns["Total"].DefaultCellStyle.Format = "C2";

                            if (dgv_Ventas.Columns.Contains("Fecha_H"))
                                dgv_Ventas.Columns["Fecha_H"].DefaultCellStyle.Format = "dd/MM/yyyy HH:mm";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar ventas: " + ex.Message, "Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarClientes()
        {
            try
            {
                using (SqlConnection conn = ConexionBD.GetConnection())
                {
                    conn.Open();

                    string query = @"SELECT ID_Cliente, 
                                           Nombre + ' ' + ISNULL(Apellido, '') AS NombreCompleto 
                                    FROM Cliente 
                                    WHERE Activo = 1
                                    ORDER BY Nombre";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        DataTable tabla = new DataTable();
                        da.Fill(tabla);

                        CMB_Clientes.DataSource = tabla;
                        CMB_Clientes.DisplayMember = "NombreCompleto";
                        CMB_Clientes.ValueMember = "ID_Cliente";
                        CMB_Clientes.SelectedIndex = -1;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar clientes: " + ex.Message, "Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ✅ NUEVO: Cargar artículos en ComboBox
        private void CargarArticulos()
        {
            try
            {
                using (SqlConnection conn = ConexionBD.GetConnection())
                {
                    conn.Open();

                    string query = @"SELECT ID_Articulo, 
                                           Codigo + ' - ' + Descripcion AS Descripcion,
                                           PrecioVenta,
                                           StockActual
                                    FROM Articulos 
                                    WHERE Activo = 1 AND StockActual > 0
                                    ORDER BY Descripcion";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        DataTable tabla = new DataTable();
                        da.Fill(tabla);

                        CMB_Articulos.DataSource = tabla;
                        CMB_Articulos.DisplayMember = "Descripcion";
                        CMB_Articulos.ValueMember = "ID_Articulo";
                        CMB_Articulos.SelectedIndex = -1;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar artículos: " + ex.Message, "Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ✅ NUEVO: Cargar datos del artículo seleccionado
        private void CargarDatosArticulo(int idArticulo)
        {
            try
            {
                using (SqlConnection conn = ConexionBD.GetConnection())
                {
                    conn.Open();

                    string query = @"SELECT ID_Articulo, Codigo, Descripcion, PrecioVenta, StockActual
                                    FROM Articulos 
                                    WHERE ID_Articulo = @ID AND Activo = 1";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@ID", idArticulo);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                TXT_Cod_Art.Text = reader["ID_Articulo"].ToString();
                                TXT_Descripcion.Text = reader["Descripcion"].ToString();
                                TXT_Precio_Unitario.Text = reader["PrecioVenta"].ToString();
                                TXT_Cantidad.Text = "1"; // Cantidad por defecto
                                TXT_Cantidad.Focus();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar datos del artículo: " + ex.Message, "Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private int ObtenerStockActual(int idArticulo)
        {
            try
            {
                using (SqlConnection conn = ConexionBD.GetConnection())
                {
                    conn.Open();

                    string query = "SELECT ISNULL(StockActual, 0) FROM Articulos WHERE ID_Articulo = @ID AND Activo = 1";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@ID", idArticulo);
                        object resultado = cmd.ExecuteScalar();
                        return resultado != null && resultado != DBNull.Value ? Convert.ToInt32(resultado) : 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener el stock del artículo: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
        }
        #endregion
    }
}
