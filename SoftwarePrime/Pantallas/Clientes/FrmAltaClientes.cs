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
using SoftwarePrime;

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
            FrmControlGestion principal = (FrmControlGestion)this.ParentForm;
            principal.MostrarBienvenida();
            this.Close();
        }

        private void BTN_Agregar_Click(object sender, EventArgs e)
        {
            DialogResult mensaje = MessageBox.Show("¿Está seguro de que desea agregar este cliente?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (mensaje == DialogResult.Yes)
            {
                if (string.IsNullOrWhiteSpace(TXT_Nombre.Text) ||
                    string.IsNullOrWhiteSpace(TXT_Telefono.Text) ||
                    string.IsNullOrWhiteSpace(TXT_Correo.Text))
                {
                    MessageBox.Show("Por favor, complete los campos obligatorios (Nombre, Teléfono, Email).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!string.IsNullOrWhiteSpace(TEXT_Cuit.Text))
                {
                    if (TEXT_Cuit.Text.Length != 11 || !TEXT_Cuit.Text.All(char.IsDigit))
                    {
                        MessageBox.Show("El CUIT debe tener 11 dígitos numéricos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

                if (!TXT_Correo.Text.Contains("@") || !TXT_Correo.Text.Contains("."))
                {
                    MessageBox.Show("Por favor, ingrese un correo electrónico válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (TXT_Telefono.Text.Length < 7 || TXT_Telefono.Text.Length > 15 || !TXT_Telefono.Text.All(char.IsDigit))
                {
                    MessageBox.Show("Por favor, ingrese un número de teléfono válido (entre 7 y 15 dígitos).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (TXT_Nombre.Text.Length < 3 || TXT_Nombre.Text.Length > 100)
                {
                    MessageBox.Show("El nombre debe tener entre 3 y 100 caracteres.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                try
                {
                    ModeloCliente nuevo = new ModeloCliente
                    {
                        CUIT = string.IsNullOrWhiteSpace(TEXT_Cuit.Text) ? (long?)null : long.Parse(TEXT_Cuit.Text),
                        Nombre = TXT_Nombre.Text,
                        ID_Entidad = CMB_Entidad.SelectedValue != null ? (int?)Convert.ToInt32(CMB_Entidad.SelectedValue) : null,
                        Telefono = TXT_Telefono.Text,
                        Email = TXT_Correo.Text
                    };

                    if (ClienteDAL.AgregarCliente(nuevo))
                    {
                        MessageBox.Show("Cliente agregado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        RefrescarGrilla();
                        CargarComboEntidades();
                        LimpiarCampos();
                    }
                    else
                    {
                        MessageBox.Show("Error al agregar el cliente a la base de datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
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
            DialogResult mensaje = MessageBox.Show("¿Está seguro de que desea modificar este cliente?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (mensaje == DialogResult.Yes)
            {

                if (string.IsNullOrWhiteSpace(TXT_Nombre.Text) ||
                    string.IsNullOrWhiteSpace(TXT_Telefono.Text) ||
                    string.IsNullOrWhiteSpace(TXT_Correo.Text))
                {
                    MessageBox.Show("Por favor, complete los campos obligatorios.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (GrillaClientes.CurrentRow != null)
                {
                    ModeloCliente mod = new ModeloCliente
                    {
                        ID_Cliente = Convert.ToInt32(GrillaClientes.CurrentRow.Cells["ID_Cliente"].Value),
                        CUIT = string.IsNullOrWhiteSpace(TEXT_Cuit.Text) ? (long?)null : long.Parse(TEXT_Cuit.Text),
                        Nombre = TXT_Nombre.Text,
                        ID_Entidad = CMB_Entidad.SelectedValue != null ? (int?)Convert.ToInt32(CMB_Entidad.SelectedValue) : null,
                        Telefono = TXT_Telefono.Text,
                        Email = TXT_Correo.Text
                    };

                    try
                    {

                        if (ClienteDAL.ModificarCliente(mod))
                        {
                            MessageBox.Show("Cliente modificado correctamente.");
                            RefrescarGrilla();
                            LimpiarCampos();
                        }
                        else
                        {
                            MessageBox.Show("Error al modificar el cliente en la base de datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
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
            DialogResult mensaje = MessageBox.Show("¿Está seguro de que desea eliminar este cliente?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (mensaje == DialogResult.Yes)
            {
                try
                {
                    if (GrillaClientes.CurrentRow != null)
                    {
                        int id = Convert.ToInt32(GrillaClientes.CurrentRow.Cells["ID_Cliente"].Value);
                        if (ClienteDAL.EliminarCliente(id))
                        {
                            MessageBox.Show("Cliente eliminado correctamente.");
                            RefrescarGrilla();
                            LimpiarCampos();
                        }
                        else
                        {
                            MessageBox.Show("Error al eliminar el cliente de la base de datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
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
            if (e.RowIndex < 0) return;
            DataGridViewRow fila = GrillaClientes.Rows[e.RowIndex];

            TEXT_Cuit.Text = fila.Cells["CUIT"].Value != DBNull.Value ? fila.Cells["CUIT"].Value.ToString() : "";
            TXT_Nombre.Text = fila.Cells["Nombre"].Value.ToString();
            TXT_Telefono.Text = fila.Cells["Telefono"].Value.ToString();
            TXT_Correo.Text = fila.Cells["Email"].Value.ToString();

            if (fila.Cells["ID_Entidad"].Value != DBNull.Value)
            {
                CMB_Entidad.SelectedValue = Convert.ToInt32(fila.Cells["ID_Entidad"].Value);
            }
            else
            {
                CMB_Entidad.SelectedIndex = -1;
            }
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
            CMB_Entidad.DisplayMember = "Nombre";
            CMB_Entidad.ValueMember = "ID_Entidad";
            CMB_Entidad.SelectedIndex = -1;
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
