using Conexion_Base_de_Datos;
using SoftwarePrime.Pantallas.Usuario;
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
    public partial class FrmUsuarios : Form
    {
        private SentenciasUsuario usuariodato = new SentenciasUsuario(); // Instancia de la clase SentenciasUsuario para operaciones de usuario

        public FrmUsuarios()
        {
            InitializeComponent();
            MostrarUsuarios();
            GrillaUsers.CellClick += GrillaUsers_CellClick; 
            EstilizarGrilla();

            // Establecer "Activo" como estado por defecto para nuevos usuarios
            RB_Activo.Checked = true;
        }

        #region Eventos Clicks

        private void BTN_Agregar_Click(object sender, EventArgs e)
        {
            if (!ValidarFormulario()) return; // Validar datos del formulario

            DialogResult resultado = MessageBox.Show("¿Desea agregar este usuario?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado != DialogResult.Yes) return;

            try
            {
                ModeloUsuario usuario = new ModeloUsuario // Crear instancia de ModeloUsuario
                {
                    DNI = int.Parse(TXT_DNI.Text), // Convertir texto a entero
                    Nombre = TEXT_Nom.Text, // Asignar nombre
                    Apellido = TXT_Ape.Text, // Asignar apellido
                    Telefono = TXT_Telf.Text, // Asignar teléfono
                    Email = TXT_Email.Text, // Asignar email
                    ID_Tipo = Convert.ToInt32(Combo_Rol.SelectedValue), // Obtener ID del tipo de usuario
                    Activo = RB_Activo.Checked // Asignar estado activo/inactivo
                };

                new SentenciasUsuario().InsertarUsuario(usuario); // Llamar al método para insertar usuario
                MessageBox.Show("Usuario agregado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MostrarUsuarios(); // Actualizar grilla de usuarios
                LimpiarFormulario();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al agregar usuario:\n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void BTN_Modificar_Click(object sender, EventArgs e)
        {
            if (!ValidarFormulario()) return; // Validar datos del formulario

            DialogResult resultado = MessageBox.Show("¿Desea modificar los datos del usuario?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado != DialogResult.Yes) return;

            try
            {
                ModeloUsuario usuario = new ModeloUsuario // Crear instancia de ModeloUsuario
                {
                    ID_Usuario = idUsuarioSeleccionado, // Usar ID del usuario seleccionado
                    DNI = int.Parse(TXT_DNI.Text),  // Convertir texto a entero
                    Nombre = TEXT_Nom.Text, // Asignar nombre
                    Apellido = TXT_Ape.Text, // Asignar apellido
                    Telefono = TXT_Telf.Text, // Asignar teléfono
                    Email = TXT_Email.Text, // Asignar email
                    ID_Tipo = Convert.ToInt32(Combo_Rol.SelectedValue), // Obtener ID del tipo de usuario
                    Activo = RB_Activo.Checked // Asignar estado activo/inactivo
                };

                new SentenciasUsuario().ModificarUsuario(usuario); // Llamar al método para modificar usuario
                MessageBox.Show("Usuario modificado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information); 
                MostrarUsuarios(); // Actualizar grilla de usuarios
                LimpiarFormulario();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al modificar usuario:\n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void BTN_BajaLogica_Click(object sender, EventArgs e)
        {
            // Validar que haya una fila seleccionada
            if (GrillaUsers.CurrentRow == null) 
            {
                MessageBox.Show("Seleccione un usuario para dar de baja.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Confirmación
            DialogResult resultado = MessageBox.Show("¿Está seguro de que desea dar de baja este usuario?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado != DialogResult.Yes) return;

            try
            {
                int id = Convert.ToInt32(GrillaUsers.CurrentRow.Cells["ID_Usuario"].Value); // Obtener ID del usuario seleccionado
                new SentenciasUsuario().EliminarUsuario(id); // O BajaLogicaUsuario(id)
                MostrarUsuarios();
                LimpiarFormulario();
                MessageBox.Show("Usuario dado de baja correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al dar de baja el usuario:\n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void Btn_volver_Click(object sender, EventArgs e)
        {
            FrmControlGestion principal = (FrmControlGestion)this.ParentForm;
            principal.MostrarBienvenida();
            this.Close();
        }

        private void FrmUsuarios_Load(object sender, EventArgs e)
        {
            CargarTiposUsuario();
            MostrarUsuarios();
        }


        private int idUsuarioSeleccionado;

        private void GrillaUsers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return; // Evitar errores al hacer clic en encabezados

            DataGridViewRow fila = GrillaUsers.Rows[e.RowIndex]; // Obtener fila seleccionada

            // Capturar ID_Usuario por nombre de columna
            idUsuarioSeleccionado = Convert.ToInt32(fila.Cells["ID_Usuario"].Value);

            TXT_DNI.Text = fila.Cells["DNI"].Value?.ToString() ?? ""; // Usar DNI de columna
            TEXT_Nom.Text = fila.Cells["Nombre"].Value?.ToString() ?? ""; // Usar nombre de columna
            TXT_Ape.Text = fila.Cells["Apellido"].Value?.ToString() ?? ""; // Usar apellido de columna
            TXT_Email.Text = fila.Cells["Email"].Value?.ToString() ?? ""; // Usar email de columna
            TXT_Telf.Text = fila.Cells["Telefono"].Value?.ToString() ?? ""; // Usar teléfono de columna
            Combo_Rol.Text = fila.Cells["TipoUsuario"].Value?.ToString() ?? ""; // Usar tipo de usuario de columna
                RB_Activo.Checked = Convert.ToBoolean(fila.Cells["Activo"].Value); // Usar estado activo de columna


            Combo_Rol.SelectedIndex = (Combo_Rol.Text == "Empleado") ? 0 : 1; // Ajustar según los valores reales

            bool activo = Convert.ToBoolean(fila.Cells["Activo"].Value); // Obtener estado activo desde la columna
            RB_Activo.Checked = activo; // Establecer radio button activo
            RB_Inactivo.Checked = !activo; // Establecer radio button inactivo

        }



        #endregion Eventos Clicks

        #region Métodos y Funciones

        private void LimpiarFormulario()
        {
            TXT_DNI.Clear();
            TEXT_Nom.Clear();
            TXT_Ape.Clear();
            TXT_Telf.Clear();
            TXT_Email.Clear();
            Combo_Rol.SelectedIndex = -1;

            // Establecer "Activo" por defecto al limpiar el formulario
            RB_Activo.Checked = true;
            RB_Inactivo.Checked = false;
        }

        private void MostrarUsuarios()
        {
            SentenciasUsuario sentencias = new SentenciasUsuario();
            GrillaUsers.DataSource = sentencias.MostrarTodosUsuarios();
        }

        private void CargarTiposUsuario()
        {
            using (SqlConnection con = ConexionBD.GetConnection())
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT ID_Usuario_Tipo, Descripcion FROM Usuario_Tipo", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                Combo_Rol.DataSource = dt;
                Combo_Rol.DisplayMember = "Descripcion";
                Combo_Rol.ValueMember = "ID_Usuario_Tipo";
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

            // La validación del estado ya no es necesaria porque RB_Activo está marcado por defecto
            // Pero la mantenemos por seguridad
            if (!RB_Activo.Checked && !RB_Inactivo.Checked)
            {
                MessageBox.Show("Seleccione el estado del usuario (Activo/Inactivo).");
                RB_Activo.Checked = true; // Marcar activo por defecto
            }

            return true; // Todo correcto
        }


        private void EstilizarGrilla()
        {
            GrillaUsers.BorderStyle = BorderStyle.None;
            GrillaUsers.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(240, 240, 240);
            GrillaUsers.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            GrillaUsers.DefaultCellStyle.SelectionBackColor = Color.FromArgb(0, 120, 215);
            GrillaUsers.DefaultCellStyle.SelectionForeColor = Color.White;
            GrillaUsers.BackgroundColor = Color.White;
            GrillaUsers.EnableHeadersVisualStyles = false;
            GrillaUsers.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            GrillaUsers.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(0, 120, 215);
            GrillaUsers.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            GrillaUsers.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            GrillaUsers.DefaultCellStyle.Font = new Font("Segoe UI", 9);
            GrillaUsers.RowTemplate.Height = 28;
        }


        #endregion Métodos y Funciones
    }
}