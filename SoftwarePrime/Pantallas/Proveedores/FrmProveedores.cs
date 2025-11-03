using SoftwarePrime.Pantallas.Proveedores;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace SoftwarePrime.Pantallas
{
    public partial class FrmProveedores : Form
    {
        public FrmProveedores()
        {
            InitializeComponent();
            CargarGrillaProveedores();
            EstilizarGrilla();
        }

        #region Eventos Clicks
        private void Btn_volver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BTN_Agregar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Está seguro de que desea agregar este proveedor?", "Confirmar Agregar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
             
            if (!long.TryParse(TXT_TEL.Text, out _)) // Validar que el teléfono contenga solo números
            {
                MessageBox.Show("El teléfono debe contener solo números.", "Formato Inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TXT_TEL.Focus();
            }

            if (!long.TryParse(TXT_Cuit.Text, out _)) // Validar que el CUIT contenga solo números
            {
                MessageBox.Show("El CUIT debe contener solo números.", "Formato Inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TXT_Cuit.Focus();
            }

            if (!System.Text.RegularExpressions.Regex.IsMatch(TXT_Email.Text, @"^[^@\s]+@[^@\s]+\.[^@\s]+$")) // Validar formato de email
            {
                MessageBox.Show("El email no tiene un formato válido.", "Formato Inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TXT_Email.Focus();
            }

            if (string.IsNullOrWhiteSpace(TXT_Cuit.Text) || // Validar que no haya campos vacíos
                string.IsNullOrWhiteSpace(TXT_Prov.Text) ||
                string.IsNullOrWhiteSpace(TEXT_Nom.Text) ||
                string.IsNullOrWhiteSpace(TXT_TEL.Text) ||
                string.IsNullOrWhiteSpace(TXT_Email.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            

            if (result == DialogResult.Yes)
            {
                try
                {
                    ModeloProveedores nuevo = new ModeloProveedores( // Crear nuevo objeto proveedor
                        long.Parse(TXT_Cuit.Text), // Convertir CUIT a long
                        TXT_Prov.Text, // Asignar nombre del proveedor
                        TEXT_Nom.Text, // Asignar nombre de contacto
                        TXT_TEL.Text, // Asignar teléfono
                        TXT_Email.Text // Asignar email
                    );

                    ProveedorDAL.AgregarProveedor(nuevo); // Llamar al método DAL para agregar el proveedor
                    MessageBox.Show("Proveedor agregado correctamente.", "Éxito"); 

                    CargarGrillaProveedores();
                    LimpiarCampos();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al agregar proveedor: " + ex.Message);
                }
            }
            return;
        }

        private void BTN_Modificar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Está seguro de que desea modificar este proveedor?", "Confirmar Modificación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                if (GrillaProv.CurrentRow != null) // Verificar que haya una fila seleccionada
                {
                    try
                    {
                        ModeloProveedores mod = new ModeloProveedores( // Crear objeto proveedor modificado
                            Convert.ToInt32(GrillaProv.CurrentRow.Cells["ID_Proveedor"].Value), // Obtener ID del proveedor seleccionado
                            long.Parse(TXT_Cuit.Text), // Convertir CUIT a long
                            TXT_Prov.Text, // Asignar nombre del proveedor
                            TEXT_Nom.Text, // Asignar nombre de contacto
                            TXT_TEL.Text, // Asignar teléfono
                            TXT_Email.Text // Asignar email
                        );

                        ProveedorDAL.ModificarProveedor(mod); // Llamar al método DAL para modificar el proveedor
                        MessageBox.Show("Proveedor modificado correctamente.", "Éxito");
                        CargarGrillaProveedores();
                        LimpiarCampos();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al modificar proveedor: " + ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show("Seleccione un proveedor de la lista.");
                }
                return;
            }
        }

        private void BTN_BajaLogica_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Está seguro de que desea eliminar este proveedor?", "Confirmar Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                if (GrillaProv.CurrentRow != null) // Verificar que haya una fila seleccionada
                {
                    try
                    {
                        int id = Convert.ToInt32(GrillaProv.CurrentRow.Cells["ID_Proveedor"].Value); // Obtener ID del proveedor seleccionado
                        ProveedorDAL.EliminarProveedor(id); // Llamar al método DAL para eliminar el proveedor
                        MessageBox.Show("Proveedor eliminado correctamente.", "Éxito");
                        CargarGrillaProveedores();
                        LimpiarCampos();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al eliminar proveedor: " + ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show("Seleccione un proveedor para eliminar.");
                }
                return;
            }
        }


        private void GrillaProv_CellClick(object sender, DataGridViewCellEventArgs e)
        { 
            if (e.RowIndex >= 0) // Asegurarse de que no se haga clic en los encabezados
            {
                // Obtener la fila seleccionada
                DataGridViewRow filaSeleccionada = GrillaProv.Rows[e.RowIndex]; 

                // Asignar valores a los TextBox
                TXT_Cuit.Text = filaSeleccionada.Cells["Cuit"].Value?.ToString();
                TXT_Prov.Text = filaSeleccionada.Cells["Proveedor"].Value?.ToString();
                TEXT_Nom.Text = filaSeleccionada.Cells["Nombre"].Value?.ToString();
                TXT_TEL.Text = filaSeleccionada.Cells["Telefono"].Value?.ToString();
                TXT_Email.Text = filaSeleccionada.Cells["Email"].Value?.ToString();
            }
        }
        #endregion

        #region Métodos Auxiliares

        private void EstilizarGrilla()
        {
            GrillaProv.BorderStyle = BorderStyle.None;
            GrillaProv.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(240, 240, 240);
            GrillaProv.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            GrillaProv.DefaultCellStyle.SelectionBackColor = Color.FromArgb(0, 120, 215);
            GrillaProv.DefaultCellStyle.SelectionForeColor = Color.White;
            GrillaProv.BackgroundColor = Color.White;
            GrillaProv.EnableHeadersVisualStyles = false;
            GrillaProv.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            GrillaProv.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(0, 120, 215);
            GrillaProv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            GrillaProv.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            GrillaProv.DefaultCellStyle.Font = new Font("Segoe UI", 9);
            GrillaProv.RowTemplate.Height = 28;
        }


        private void LimpiarCampos()
        {
            TXT_Cuit.Clear();
            TXT_Prov.Clear();
            TEXT_Nom.Clear();
            TXT_TEL.Clear();
            TXT_Email.Clear();
        }

        private void CargarGrillaProveedores()
        {
            try
            {
                GrillaProv.DataSource = ProveedorDAL.ObtenerProveedores();
                GrillaProv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                GrillaProv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                GrillaProv.MultiSelect = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar proveedores: " + ex.Message);
            }
        }

        #endregion


    }
}