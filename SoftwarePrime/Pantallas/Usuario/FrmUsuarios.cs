using Conexion_Base_de_Datos;
using SoftwarePrime.Pantallas.Usuario;
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
    public partial class FrmUsuarios : Form
    {
        private ClaseSent usuariodato = new ClaseSent();

        public FrmUsuarios()
        {
            InitializeComponent();
            CargarUsuarios();
            GrillaUsers.CellClick += GrillaUsers_CellClick;

        }


        #region Eventos Clicks

        private void BTN_Agregar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Está seguro de que desea agregar este usuario?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                if (!ValidarFormulario())
                    return;

                int dni;
                if (!int.TryParse(TXT_DNI.Text, out dni))
                {
                    MessageBox.Show("Ingrese un DNI válido.");
                    return;
                }

                int idTipo = Combo_Rol.SelectedIndex == 0 ? 1 : 2;
                bool activo = RB_Activo.Checked;

                ModeloUsuario usuario = new ModeloUsuario(
                    dni,
                    TEXT_Nom.Text.Trim(),
                    TXT_Ape.Text.Trim(),
                    TXT_Telf.Text.Trim(),
                    TXT_Email.Text.Trim(),
                    idTipo,
                    activo
                );

                try
                {
                    ClaseSent.InsertarUsuario(usuario);
                    MessageBox.Show("Usuario guardado correctamente.");
                    CargarUsuarios();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al guardar: " + ex.Message);
                }

                LimpiarFormulario();
            }

        }

        private void BTN_Modificar_Click(object sender, EventArgs e)
        {
            DialogResult mensaje = MessageBox.Show("¿Está seguro de que desea modificar este usuario?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (mensaje == DialogResult.Yes)
            {
                int dni;
                if (!int.TryParse(TXT_DNI.Text, out dni))
                {
                    MessageBox.Show("Ingrese un DNI válido.");
                    return;
                }

                int idTipo = Combo_Rol.SelectedIndex == 0 ? 1 : 2;
                bool activo = RB_Activo.Checked;

                ModeloUsuario usuario = new ModeloUsuario(dni, TEXT_Nom.Text.Trim(), TXT_Ape.Text.Trim(),
                                                          TXT_Telf.Text.Trim(), TXT_Email.Text.Trim(), idTipo, activo);

                try
                {
                    ClaseSent.ModificarUsuario(usuario);
                    MessageBox.Show("Usuario modificado correctamente.");
                    CargarUsuarios();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al modificar: " + ex.Message);
                }
                LimpiarFormulario();
            }

        }

        private void BTN_BajaLogica_Click(object sender, EventArgs e)
        {

            DialogResult mensaje = MessageBox.Show("¿Está seguro de que desea dar de baja este usuario?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (mensaje == DialogResult.Yes)
            {
                int dni;
                if (!int.TryParse(TXT_DNI.Text, out dni))
                {
                    MessageBox.Show("Ingrese un DNI válido.");
                    return;
                }

                try
                {
                    BajaLogicaUsuario(dni);
                    MessageBox.Show("Usuario dado de baja correctamente.");
                    CargarUsuarios();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error en la baja: " + ex.Message);
                }
                LimpiarFormulario();

            }

        }

        private void Btn_volver_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void FrmUsuarios_Load(object sender, EventArgs e)
        {
            // Llenar ComboBox con opciones
            Combo_Rol.Items.Add(new { Text = "Empleado", Value = 1 });
            Combo_Rol.Items.Add(new { Text = "Administrador", Value = 2 });
            Combo_Rol.DisplayMember = "Text";
            Combo_Rol.ValueMember = "Value";
            Combo_Rol.SelectedIndex = 0; // Seleccionar por defecto
        }

        private void GrillaUsers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            DataGridViewRow fila = GrillaUsers.Rows[e.RowIndex];

            // TextBox
            TXT_DNI.Text = fila.Cells[0].Value.ToString();
            TEXT_Nom.Text = fila.Cells[1].Value.ToString();
            TXT_Ape.Text = fila.Cells[2].Value.ToString();
            TXT_Telf.Text = fila.Cells[3].Value.ToString();
            TXT_Email.Text = fila.Cells[4].Value.ToString();

            // ComboBox: Tipo de usuario según el texto de la columna "Rol"
            string rol = fila.Cells[5].Value.ToString();
            Combo_Rol.SelectedIndex = (rol == "Empleado") ? 0 : 1; // 0=Empleado, 1=Administrador

            // RadioButton: Activo/Inactivo según la columna "Estado"
            string estado = fila.Cells[6].Value.ToString();
            RB_Activo.Checked = (estado == "Activo");
            RB_Inactivo.Checked = (estado == "Inactivo");
        }

        private void GrillaUsers_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        { //hacer un metodo para cambiar el color de la fila segun el estado
            //TODO: luego llamarlo en el load del formulario

            // Evitar cabeceras y clicks fuera de fila
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;

            DataGridViewColumn col = GrillaUsers.Columns[e.ColumnIndex];

            // Obtener identificador de columna de forma segura
            string colName = (col.Name ?? col.DataPropertyName ?? col.HeaderText ?? string.Empty).Trim();

            // Si la columna relacionada con estado es "Estado" (por header) o "Activo" (por DataPropertyName)
            if (!string.IsNullOrEmpty(colName) &&
                (colName.Equals("Estado", StringComparison.OrdinalIgnoreCase) ||
                 colName.Equals("Activo", StringComparison.OrdinalIgnoreCase) ||
                 col.HeaderText.Equals("Estado", StringComparison.OrdinalIgnoreCase)))
            {
                // Si el valor es nulo, no intentar convertir
                if (e.Value == null || e.Value == DBNull.Value) return;

                // 1) Si la celda contiene el texto "Activo"/"Inactivo"
                string texto = e.Value.ToString().Trim();
                if (texto.Equals("Activo", StringComparison.OrdinalIgnoreCase))
                {
                    GrillaUsers.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.White;
                    GrillaUsers.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.Black;
                    return;
                }
                if (texto.Equals("Inactivo", StringComparison.OrdinalIgnoreCase))
                {
                    GrillaUsers.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Gray;
                    GrillaUsers.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.White;
                    return;
                }

                // 2) Si la celda viene como booleano (true/false)
                if (e.Value is bool)
                {
                    bool activo = (bool)e.Value;
                    if (activo)
                    {
                        GrillaUsers.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.White;
                        GrillaUsers.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.Black;
                    }
                    else
                    {
                        GrillaUsers.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.LightCoral;
                        GrillaUsers.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.White;
                    }
                    return;
                }

                // 3) Intentar parsear por si la columna contiene "1"/"0"
                if (int.TryParse(texto, out int num))
                {
                    if (num == 1)
                    {
                        GrillaUsers.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.White;
                        GrillaUsers.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.Black;
                    }
                    else
                    {
                        GrillaUsers.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Gray;
                        GrillaUsers.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.White;
                    }
                }
            }
        }

        #endregion

        #region Métodos y Funciones

        private void LimpiarFormulario()
        {
            TXT_DNI.Clear();
            TEXT_Nom.Clear();
            TXT_Ape.Clear();
            TXT_Telf.Clear();
            TXT_Email.Clear();
            Combo_Rol.SelectedIndex = -1;
            RB_Activo.Checked = false;
            RB_Inactivo.Checked = false;
        }

        private void CargarUsuarios()
        {
            using (SqlConnection con = ConexionBD.GetConnection())
            {
                string query = @"
            SELECT u.DNI, u.Nombre, u.Apellido, u.Telefono, u.Email, 
                   t.Descripcion AS Rol, 
                   CASE WHEN u.Activo = 1 THEN 'Activo' ELSE 'Inactivo' END AS Estado
            FROM Usuario u
            INNER JOIN Usuario_Tipo t ON u.ID_Tipo = t.ID_Usuario_Tipo";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    GrillaUsers.DataSource = dt;
                }
            }
        }

        private void CargarRoles()
        {
            using (SqlConnection con = ConexionBD.GetConnection())
            {
                string query = "SELECT ID_Usuario_Tipo, Descripcion FROM Usuario_Tipo";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    Combo_Rol.DataSource = dt;
                    Combo_Rol.DisplayMember = "Descripcion"; // lo que ve el usuario
                    Combo_Rol.ValueMember = "ID_Usuario_Tipo"; // lo que se guarda en la BD
                }
            }
        }

        public static void BajaLogicaUsuario(int dni)
        {
            using (SqlConnection con = ConexionBD.GetConnection())
            {
                con.Open(); // Abrir la conexión

                string query = @"UPDATE Usuario
                         SET Activo = 0
                         WHERE DNI = @DNI";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@DNI", dni);

                    int filasAfectadas = cmd.ExecuteNonQuery();
                    if (filasAfectadas == 0)
                    {
                        throw new Exception("No se encontró el usuario con ese DNI.");
                    }
                }
            }
        }

        private bool ValidarFormulario()
        {
            int dni;
            if (!int.TryParse(TXT_DNI.Text, out dni))
            {
                MessageBox.Show("Ingrese un DNI válido (solo números).");
                TXT_DNI.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(TEXT_Nom.Text))
            {
                MessageBox.Show("Ingrese el nombre del usuario.");
                TEXT_Nom.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(TXT_Ape.Text))
            {
                MessageBox.Show("Ingrese el apellido del usuario.");
                TXT_Ape.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(TXT_Telf.Text) || !System.Text.RegularExpressions.Regex.IsMatch(TXT_Telf.Text, @"^\d{8,15}$"))
            {
                MessageBox.Show("Ingrese un teléfono válido (8 a 15 dígitos).");
                TXT_Telf.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(TXT_Email.Text) || !System.Text.RegularExpressions.Regex.IsMatch(TXT_Email.Text, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                MessageBox.Show("Ingrese un email válido.");
                TXT_Email.Focus();
                return false;
            }

            if (Combo_Rol.SelectedIndex < 0)
            {
                MessageBox.Show("Seleccione un rol para el usuario.");
                Combo_Rol.Focus();
                return false;
            }

            if (!RB_Activo.Checked && !RB_Inactivo.Checked)
            {
                MessageBox.Show("Seleccione el estado del usuario.");
                return false;
            }

            return true; // Todo correcto
        }




        #endregion

        
    }
}
