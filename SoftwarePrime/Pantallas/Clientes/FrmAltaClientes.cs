using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SoftwarePrime.Pantallas;

namespace SoftwarePrime.Pantallas.Clientes
{
    public partial class FrmAltaClientes : Form
    {
        public FrmAltaClientes()
        {
            InitializeComponent();
            EstilizarGrilla();
        }

        #region Eventos Botones

        private void BTN_Volver_Click(object sender, EventArgs e)
        {
            //this.WindowState = FormWindowState.Minimized;
            this.Close();
        }

        private void BTN_Agregar_Click(object sender, EventArgs e)
        {
            DialogResult mensaje = MessageBox.Show("¿Está seguro de que desea agregar este usuario?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (mensaje == DialogResult.Yes)
            {
                if (string.IsNullOrWhiteSpace(TEXT_Cuit.Text) || // Validar datos del formulario
                    string.IsNullOrWhiteSpace(TXT_Nombre.Text) ||
                    string.IsNullOrWhiteSpace(CMB_Entidad.Text) ||
                    string.IsNullOrWhiteSpace(TXT_Telefono.Text) ||
                    string.IsNullOrWhiteSpace(TXT_Correo.Text))
                {
                    MessageBox.Show("Por favor, complete todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (TEXT_Cuit.Text.Length != 11 || !TEXT_Cuit.Text.All(char.IsDigit)) // Validar CUIT
                {
                    MessageBox.Show("El CUIT debe tener 11 dígitos numéricos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }


                if (!TXT_Correo.Text.Contains("@") || !TXT_Correo.Text.Contains(".")) // Validar correo electrónico
                {
                    MessageBox.Show("Por favor, ingrese un correo electrónico válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (TXT_Telefono.Text.Length < 7 || TXT_Telefono.Text.Length > 15 || !TXT_Telefono.Text.All(char.IsDigit)) // Validar teléfono
                {
                    MessageBox.Show("Por favor, ingrese un número de teléfono válido (entre 7 y 15 dígitos).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (TXT_Nombre.Text.Length < 3 || TXT_Nombre.Text.Length > 100) // Validar nombre
                {
                    MessageBox.Show("El nombre debe tener entre 3 y 100 caracteres.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                

                if (CMB_Entidad.SelectedIndex == -1) // Validar selección de entidad
                {
                    MessageBox.Show("Por favor, seleccione una entidad válida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }


                try
                {

                    ModeloCliente nuevo = new ModeloCliente( // Crear nuevo cliente
                    long.Parse(TEXT_Cuit.Text), // Convertir CUIT a long
                    TXT_Nombre.Text, // Nombre
                    CMB_Entidad.Text, // Entidad
                    TXT_Telefono.Text, // Teléfono
                    TXT_Correo.Text // Correo
                );
                    ClienteDAL.AgregarCliente(nuevo); // Agregar cliente a la base de datos
                    MessageBox.Show("Cliente agregado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Refrescar grilla y combo de entidades
                    GrillaClientes.DataSource = ClienteDAL.ObtenerClientes(); // Refrescar grilla
                    CargarComboEntidades();
                    LimpiarCampos();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al agregar cliente: " + ex.Message);
                }

                return;
            }

        }

        private void BTN_Modificar_Click(object sender, EventArgs e)
        {
            DialogResult mensaje = MessageBox.Show("¿Está seguro de que desea modificar este usuario?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (mensaje == DialogResult.Yes)
            {
                 
                if (string.IsNullOrWhiteSpace(TEXT_Cuit.Text) || // Validar datos del formulario
                    string.IsNullOrWhiteSpace(TXT_Nombre.Text) ||
                    string.IsNullOrWhiteSpace(CMB_Entidad.Text) ||
                    string.IsNullOrWhiteSpace(TXT_Telefono.Text) ||
                    string.IsNullOrWhiteSpace(TXT_Correo.Text))
                {
                    MessageBox.Show("Por favor, complete todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                 
                if (GrillaClientes.CurrentRow != null) // Verificar que haya una fila seleccionada
                {
                    ModeloCliente mod = new ModeloCliente // Crear objeto cliente modificado
                    {
                        ID_Clientes = Convert.ToInt32(GrillaClientes.CurrentRow.Cells["ID_Clientes"].Value), // Obtener ID del cliente seleccionado
                        Cuit = long.Parse(TEXT_Cuit.Text), // Convertir CUIT a long
                        Nombre = TXT_Nombre.Text, // Nombre
                        Entidad = CMB_Entidad.Text, // Entidad
                        Telefono = TXT_Telefono.Text, // Teléfono
                        Mail = TXT_Correo.Text // Correo
                    };

                    try
                    {

                        ClienteDAL.ModificarCliente(mod); // Modificar cliente en la base de datos
                        MessageBox.Show("Cliente modificado correctamente.");
                        RefrescarGrilla();
                        LimpiarCampos();
                    }
                    catch (FormatException)
                    {
                        MessageBox.Show("Error al modificar el cliente: El CUIT debe ser un número válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;

                    }
                }

            }
        }
          

         private void BTN_BajaLogica_Click(object sender, EventArgs e)
        {
            DialogResult mensaje = MessageBox.Show("¿Está seguro de que desea eliminar este usuario?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (mensaje == DialogResult.Yes)
            {
                try
                {
                    if (GrillaClientes.CurrentRow != null) // Verificar que haya una fila seleccionada
                    {
                        int id = Convert.ToInt32(GrillaClientes.CurrentRow.Cells["ID_Clientes"].Value); // Obtener ID del cliente seleccionado
                        ClienteDAL.EliminarCliente(id); // Eliminar cliente de la base de datos
                        MessageBox.Show("Cliente eliminado correctamente.");
                        RefrescarGrilla();
                        LimpiarCampos();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al eliminar el cliente: " + ex.Message);
                    return;
                }
            }
             
            
         }

        private void FrmAltaClientes_Load(object sender, EventArgs e)
        {

            GrillaClientes.DataSource = ClienteDAL.ObtenerClientes(); // Cargar grilla de clientes
            CargarComboEntidades(); // Cargar combo de entidades
        }

        private void GrillaClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return; // Evitar error al hacer clic en el encabezado de la grilla
            DataGridViewRow fila = GrillaClientes.Rows[e.RowIndex]; // Obtener fila seleccionada
            // TextBox
            TEXT_Cuit.Text = fila.Cells["Cuit"].Value.ToString(); // Asignar valores a los campos de texto
            TXT_Nombre.Text = fila.Cells["Nombre"].Value.ToString();
            CMB_Entidad.Text = fila.Cells["Entidad"].Value.ToString();
            TXT_Telefono.Text = fila.Cells["Telefono"].Value.ToString();
            TXT_Correo.Text = fila.Cells["Mail"].Value.ToString();
        }



        #endregion

        #region METODOS Y FUNCIONES
        public void LimpiarCampos()
        {
            TEXT_Cuit.Clear();
            TXT_Nombre.Clear();
            CMB_Entidad.SelectedIndex = -1;
            TXT_Telefono.Clear();
            TXT_Correo.Clear();
        }

        public void RefrescarGrilla()
        {
            GrillaClientes.DataSource = ClienteDAL.ObtenerClientes();
        }

        private void CargarComboEntidades()
        {
            CMB_Entidad.DataSource = ClienteDAL.ObtenerEntidades();
            CMB_Entidad.DisplayMember = "Nombre_Entidad";
            
        }

        private void EstilizarGrilla()
        {
            GrillaClientes.BorderStyle = BorderStyle.None;
            GrillaClientes.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(240, 240, 240);
            GrillaClientes.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            GrillaClientes.DefaultCellStyle.SelectionBackColor = Color.FromArgb(0, 120, 215);
            GrillaClientes.DefaultCellStyle.SelectionForeColor = Color.White;
            GrillaClientes.BackgroundColor = Color.White;
            GrillaClientes.EnableHeadersVisualStyles = false;
            GrillaClientes.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            GrillaClientes.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(0, 120, 215);
            GrillaClientes.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            GrillaClientes.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            GrillaClientes.DefaultCellStyle.Font = new Font("Segoe UI", 9);
            GrillaClientes.RowTemplate.Height = 28;
        }




        #endregion

    }
}
