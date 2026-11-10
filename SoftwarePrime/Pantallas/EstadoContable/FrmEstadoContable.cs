using System;
using System.Drawing;
using System.Windows.Forms;

namespace SoftwarePrime.Pantallas.EstadoContable
{
    public partial class FrmEstadoContable : Form
    {
        private EstadoContableDAL dal;

        public FrmEstadoContable()
        {
            InitializeComponent();
            dal = new EstadoContableDAL();
            InicializarFormulario();
        }

        private void InicializarFormulario()
        {
            // Configurar fechas por defecto (último mes)
            DT_FechaHasta.Value = DateTime.Now;
            DT_FechaDesde.Value = DateTime.Now.AddMonths(-1);

            // Cargar usuarios
            CargarUsuarios();

            // Estilizar grilla
            EstilizarGrilla();

            // Realizar consulta inicial
            RealizarConsulta();
        }

        private void CargarUsuarios()
        {
            try
            {
                CMB_Usuario.DataSource = dal.ObtenerUsuarios();
                CMB_Usuario.DisplayMember = "NombreCompleto";
                CMB_Usuario.ValueMember = "ID_Usuario";
                CMB_Usuario.SelectedIndex = -1;
                CMB_Usuario.Enabled = !CHK_TodosUsuarios.Checked;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar usuarios: " + ex.Message, "Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void EstilizarGrilla()
        {
            Grilla_Bitacora.BorderStyle = BorderStyle.None;
            Grilla_Bitacora.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(240, 240, 240);
            Grilla_Bitacora.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            Grilla_Bitacora.DefaultCellStyle.SelectionBackColor = Color.FromArgb(0, 120, 215);
            Grilla_Bitacora.DefaultCellStyle.SelectionForeColor = Color.White;
            Grilla_Bitacora.BackgroundColor = Color.White;
            Grilla_Bitacora.EnableHeadersVisualStyles = false;
            Grilla_Bitacora.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            Grilla_Bitacora.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(0, 120, 215);
            Grilla_Bitacora.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            Grilla_Bitacora.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            Grilla_Bitacora.DefaultCellStyle.Font = new Font("Segoe UI", 9);
            Grilla_Bitacora.RowTemplate.Height = 28;
            Grilla_Bitacora.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            Grilla_Bitacora.MultiSelect = false;
            Grilla_Bitacora.ReadOnly = true;
            Grilla_Bitacora.AllowUserToAddRows = false;
            Grilla_Bitacora.AllowUserToDeleteRows = false;
            Grilla_Bitacora.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void RealizarConsulta()
        {
            try
            {
                DateTime fechaDesde = DT_FechaDesde.Value.Date;
                DateTime fechaHasta = DT_FechaHasta.Value.Date.AddHours(23).AddMinutes(59).AddSeconds(59);

                int? idUsuario = null;
                if (!CHK_TodosUsuarios.Checked && CMB_Usuario.SelectedValue != null)
                {
                    idUsuario = Convert.ToInt32(CMB_Usuario.SelectedValue);
                }

                // Obtener estado contable
                var estado = dal.ObtenerEstadoContable(fechaDesde, fechaHasta, idUsuario);

                // Actualizar labels
                ActualizarResumen(estado);

                // Obtener bitácora de movimientos
                var movimientos = dal.ObtenerBitacoraMovimientos(fechaDesde, fechaHasta, idUsuario);

                // SIMPLIFICADO: Solo asignar y listo
                Grilla_Bitacora.DataSource = movimientos;

                // Ocultar solo las columnas que no queremos ver
                if (Grilla_Bitacora.Columns.Count > 0)
                {
                    if (Grilla_Bitacora.Columns.Contains("ID_Movimiento"))
                        Grilla_Bitacora.Columns["ID_Movimiento"].Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ActualizarResumen(ModeloEstadoContable estado)
        {
            LBL_Ingresos.Text = estado.TotalIngresosPorVentas.ToString("C2");
            LBL_Egresos.Text = estado.TotalEgresosPorCompras.ToString("C2");
            LBL_EgresosVarios.Text = estado.TotalEgresosPorComprasVarias.ToString("C2");
            LBL_ValorStock.Text = estado.TotalInsumosEnStock.ToString("C2");
            LBL_CantCompras.Text = estado.CantidadComprasInsumos.ToString();
            LBL_CantVentas.Text = estado.CantidadVentasInsumos.ToString();
            LBL_CantComprasVarias.Text = estado.CantidadComprasVarias.ToString();
            LBL_Saldo.Text = estado.SaldoTotal.ToString("C2");

            // Cambiar color del saldo según sea positivo o negativo
            if (estado.SaldoTotal >= 0)
            {
                LBL_Saldo.ForeColor = Color.Green;
            }
            else
            {
                LBL_Saldo.ForeColor = Color.Red;
            }
        }

        private void BTN_Consultar_Click(object sender, EventArgs e)
        {
            if (DT_FechaDesde.Value > DT_FechaHasta.Value)
            {
                MessageBox.Show("La fecha 'Desde' no puede ser mayor que la fecha 'Hasta'.", 
                    "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            RealizarConsulta();
        }

        private void CHK_TodosUsuarios_CheckedChanged(object sender, EventArgs e)
        {
            CMB_Usuario.Enabled = !CHK_TodosUsuarios.Checked;
            if (CHK_TodosUsuarios.Checked)
            {
                CMB_Usuario.SelectedIndex = -1;
            }
        }

        private void BTN_ExportarPDF_Click(object sender, EventArgs e)
        {
            try
            {
                // Aquí podrías implementar la exportación a PDF
                // Por ahora, mostramos un mensaje
                MessageBox.Show("Funcionalidad de exportación a PDF pendiente de implementación.\n\n" +
                    "Puede implementarse usando bibliotecas como iTextSharp o PdfSharp.", 
                    "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al exportar: " + ex.Message, "Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
