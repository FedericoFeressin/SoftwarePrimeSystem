using Conexion_Base_de_Datos;
using SoftwarePrime.Pantallas.Ventas;
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
        BindingList<ModeloDetalleVenta> bindingDetalle = new BindingList<ModeloDetalleVenta>();// Lista enlazada para la grilla de detalles
        private List<ModeloDetalleVenta> listaDetalles = new List<ModeloDetalleVenta>(); // Lista normal para manejar los detalles internamente
        private int codUsuarioActual = 1; // Suponiendo que el usuario con ID 1 está logueado actualmente
        public FrmVentas()
        {
            InitializeComponent();
            EstilizarGrilla(); // Aplicar estilo a la grilla de detalles
            EstilizarGrilla2(); // Aplicar estilo a la grilla de ventas
        }

        #region Eventos Clicks


        private void BTN_Agregar_Art_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TXT_Cod_Art.Text) || // Validaciones de campos
        string.IsNullOrWhiteSpace(TXT_Descripcion.Text) || // Validaciones de campos
        string.IsNullOrWhiteSpace(TXT_Precio_Unitario.Text) || // Validaciones de campos
        string.IsNullOrWhiteSpace(TXT_Cantidad.Text)) // Validaciones de campos
            {
                MessageBox.Show("Todos los campos del artículo deben estar completos.");
                return;
            }

            if (bindingDetalle.Any(d => d.ID_Articulo.ToString() == TXT_Cod_Art.Text)) // Verificar si el artículo ya fue agregado
            {
                MessageBox.Show("El artículo ya ha sido agregado.");
                return;
            }

            if (!decimal.TryParse(TXT_Precio_Unitario.Text, out decimal precioUnitario) || precioUnitario <= 0) // Validar precio unitario positivo
            {
                MessageBox.Show("El precio unitario debe ser un número positivo.");
                return;
            }



            if (!int.TryParse(TXT_Cod_Art.Text, out int idArticulo)) return; // Validar y convertir los campos
            if (!decimal.TryParse(TXT_Precio_Unitario.Text, out decimal precioUnidad)) return; // Validar y convertir los campos
            if (!int.TryParse(TXT_Cantidad.Text, out int cantidad)) return; // Validar y convertir los campos

            string descripcion = TXT_Descripcion.Text; // Obtener la descripción

            var detalle = new ModeloDetalleVenta(idArticulo, descripcion, precioUnidad, cantidad); // Crear el objeto detalle
            bindingDetalle.Add(detalle); // Se actualiza automáticamente en la grilla

            RecalcularTotales(); // Recalcular totales

            TXT_Cod_Art.Clear();
            TXT_Descripcion.Clear();
            TXT_Precio_Unitario.Clear();
            TXT_Cantidad.Clear();


        }

        private void BTN_Guardar_Venta_Click(object sender, EventArgs e)
        {
            if (CMB_Clientes.SelectedIndex == -1 || bindingDetalle.Count == 0) // Validaciones antes de guardar
            {
                MessageBox.Show("Debe seleccionar un cliente y agregar al menos un artículo.");
                return;
            }

            int idCliente = Convert.ToInt32(CMB_Clientes.SelectedValue); // Obtener datos del formulario
            DateTime fecha = DT_Fecha.Value; // Fecha de la venta
            decimal subtotal = Convert.ToDecimal(TXT_SubTotal.Text); // Subtotal calculado
            decimal descuento = Convert.ToDecimal(TXT_Descuento.Text); // Descuento aplicado
            decimal total = Convert.ToDecimal(TXT_Total.Text); // Total final

            var venta = new ModeloVentas(codUsuarioActual, idCliente, fecha, subtotal, descuento, total); // Crear el objeto venta
            var sentencias = new ClaseSentVentas(ConexionBD.GetConnection()); // Instanciar la clase de sentencias

            int idRemito = sentencias.InsertarVenta(venta); // Insertar la cabecera de la venta

            if (idRemito > 0) // Si se insertó correctamente, insertar el detalle
            {
                bool ok = sentencias.InsertarDetalleVenta(idRemito, bindingDetalle.ToList()); // Convertir BindingList a List
                if (ok) // Si se insertó correctamente
                {
                    MessageBox.Show("Venta guardada correctamente.");
                    LimpiarFormulario();
                    CargarVentas();
                }
                else
                {
                    MessageBox.Show("Error al guardar el detalle.");
                }
            }
            else
            {
                MessageBox.Show("Error al guardar la cabecera.");
            }


        }

        private void TXT_Descuento_TextChanged(object sender, EventArgs e)
        {
            RecalcularTotales(); // Recalcular totales al cambiar el descuento
        }

        private void Btn_volver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion


        #region metodos privados
        private void RecalcularTotales()
        {
            decimal subtotal = bindingDetalle.Sum(d => d.Precio_Por_Cantidad); // Sumar los totales de cada detalle
            TXT_SubTotal.Text = subtotal.ToString("0.00"); // Actualizar el subtotal

            decimal.TryParse(TXT_Descuento.Text, out decimal porcentajeDescuento); // Obtener el porcentaje de descuento
            decimal montoDescuento = subtotal * (porcentajeDescuento / 100); // Calcular el monto del descuento

            decimal total = subtotal - montoDescuento; // Calcular el total final
            TXT_Total.Text = total.ToString("0.00"); // Actualizar el total

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
        }


        #endregion

        private void LimpiarFormulario()
        {
            CMB_Clientes.SelectedIndex = -1;
            DT_Fecha.Value = DateTime.Now;
            TXT_SubTotal.Text = "0.00";
            TXT_Descuento.Text = "0.00";
            TXT_Total.Text = "0.00";
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
                       V.Fecha_Hora AS Fecha_H, 
                       U.Nombre AS Usuario, 
                       C.Nombre AS Cliente, 
                       V.Subtotal, 
                       V.Descuento, 
                       V.Total
                FROM H_Ventas V
                INNER JOIN Usuario U ON V.Cod_Usuario = U.ID_Usuario
                INNER JOIN Clientes C ON V.ID_Cliente = C.ID_Clientes
                ORDER BY V.Fecha_Hora DESC";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        DataTable tabla = new DataTable();
                        da.Fill(tabla);
                        dgv_Ventas.DataSource = tabla;

                        dgv_Ventas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                        dgv_Ventas.Columns["Subtotal"].DefaultCellStyle.Format = "C2";
                        dgv_Ventas.Columns["Descuento"].DefaultCellStyle.Format = "C2";
                        dgv_Ventas.Columns["Total"].DefaultCellStyle.Format = "C2";
                        dgv_Ventas.Columns["Fecha_H"].DefaultCellStyle.Format = "dd/MM/yyyy HH:mm";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar ventas: " + ex.Message);
            }
        }


        private void FrmVentas_Load(object sender, EventArgs e)
        {
            CargarVentas();
            CargarClientes();
            dgv_Detalle.DataSource = bindingDetalle; // Enlazar la grilla con la BindingList
            dgv_Detalle.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; // Ajustar columnas al tamaño de la grilla


        }

        private void CargarClientes()
        {
            try
            {
                using (SqlConnection conn = ConexionBD.GetConnection())
                {
                    conn.Open();

                    string query = "SELECT ID_Clientes, Nombre AS NombreCompleto FROM Clientes ORDER BY Nombre";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        DataTable tabla = new DataTable();
                        da.Fill(tabla);

                        CMB_Clientes.DataSource = tabla;
                        CMB_Clientes.DisplayMember = "NombreCompleto";
                        CMB_Clientes.ValueMember = "ID_Clientes";
                        CMB_Clientes.SelectedIndex = -1; // Para que no se seleccione ninguno al inicio
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar clientes: " + ex.Message);
            }
        }

    }
}
