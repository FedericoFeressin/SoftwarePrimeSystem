using Conexion_Base_de_Datos;
using SoftwarePrime.Pantallas.Login;
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

namespace SoftwarePrime.Pantallas.RecursosHumanos
{
    public partial class FrmGestionLogin : Form
    {
        public FrmGestionLogin()
        {
            InitializeComponent();
            EstilizarGrilla(Grilla_Sin_Cuentas);
        }

        private void FrmGestionLogin_Load(object sender, EventArgs e)
        {
            CargarUsuariosSinLogin();
            CargarUsuariosConLogin();
            ConfigurarColumnasSinLogin();
            ConfigurarColumnasConLogin();
        }

        // 🔹 OBTENER USUARIOS CON CUENTA DE LOGIN (para cambiar contraseña)
        public static DataTable ObtenerUsuariosConLogin()
        {
            try
            {
                using (SqlConnection conn = ConexionBD.GetConnection())
                {
                    conn.Open();
                    string query = @"SELECT U.ID_Usuario, U.DNI, U.Nombre, U.Apellido, 
                                    L.NombreUsuario, T.Descripcion AS TipoUsuario
                             FROM Usuario U
                             INNER JOIN Usuario_Tipo T ON U.ID_Tipo = T.ID_Usuario_Tipo
                             INNER JOIN Login L ON L.ID_Usuario = U.ID_Usuario
                             WHERE U.Activo = 1 AND L.Activo = 1
                             ORDER BY U.Apellido, U.Nombre";

                    using (SqlDataAdapter da = new SqlDataAdapter(query, conn))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        return dt;
                    }
                }
            }
            catch (SqlException ex)
            {
                throw new Exception($"Error al obtener usuarios con login: {ex.Message}", ex);
            }
        }

        private void CargarUsuariosSinLogin()
        {
            try
            {
                DataTable dt = LoginDAL.ObtenerUsuariosSinLogin();
                Grilla_Sin_Cuentas.DataSource = dt;

                // Mostrar mensaje si no hay usuarios
                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("No hay usuarios disponibles para crear cuentas de login.\n\n" +
                                    "Posibles causas:\n" +
                                    "1. No existen usuarios activos en el sistema\n" +
                                    "2. Todos los usuarios ya tienen cuenta de login creada\n" +
                                    "3. Los usuarios fueron creados como 'Inactivos'\n\n" +
                                    "Verifique en el módulo 'Gestión de Usuarios' que:\n" +
                                    "- Los usuarios estén marcados como 'Activos' (estado con tilde verde)\n" +
                                    "- No tengan cuenta de login ya asignada",
                                    "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar usuarios:\n{ex.Message}\n\nDetalle:\n{ex.StackTrace}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarUsuariosConLogin()
        {
            try
            {
                DataTable dt = LoginDAL.ObtenerUsuariosConLogin();
                Grilla_Users_Con_Contraseña.DataSource = dt;
                EstilizarGrilla(Grilla_Users_Con_Contraseña); // Reutilizamos el método que ya tenés
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar usuarios:\n{ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCrearCuenta_Click(object sender, EventArgs e)
        {
            // Validar que haya un usuario seleccionado
            if (Grilla_Sin_Cuentas.CurrentRow == null)
            {
                MessageBox.Show("Seleccione un usuario de la lista.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validar campos
            if (string.IsNullOrWhiteSpace(txtNombreUsuario.Text))
            {
                MessageBox.Show("Ingrese un nombre de usuario.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtContrasena.Text))
            {
                MessageBox.Show("Ingrese una contraseña.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (txtContrasena.Text.Length < 6)
            {
                MessageBox.Show("La contraseña debe tener al menos 6 caracteres.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (txtContrasena.Text != txtConfirmarContrasena.Text)
            {
                MessageBox.Show("Las contraseñas no coinciden.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Obtener ID del usuario seleccionado
            int idUsuario = Convert.ToInt32(Grilla_Sin_Cuentas.CurrentRow.Cells["ID_Usuario"].Value);
            string nombreUsuario = txtNombreUsuario.Text.Trim();
            string contrasena = txtContrasena.Text;

            // Crear cuenta
            if (LoginDAL.CrearCuentaLogin(idUsuario, nombreUsuario, contrasena))
            {
                MessageBox.Show("Cuenta de login creada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarCampos();
                CargarUsuariosSinLogin();
                CargarUsuariosConLogin();
            }
            else
            {
                MessageBox.Show("Error al crear la cuenta. El nombre de usuario ya existe.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void LimpiarCampos()
        {
            txtNombreUsuario.Clear();
            txtContrasena.Clear();
            txtConfirmarContrasena.Clear();
            Grilla_Sin_Cuentas.ClearSelection();
        }

        private void limpiarcamposcontraseña()
        {
            TXT_User_Con_Cuenta.Text = "Usuario: (ninguno seleccionado)";
            TXT_Nueva_Contraseña.Clear();
            TXT_Confirmar_Contraseña.Clear();
            Grilla_Users_Con_Contraseña.ClearSelection();
        }

        public void EstilizarGrilla(DataGridView grilla)
        {
            grilla.BorderStyle = BorderStyle.None;
            grilla.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(240, 240, 240);
            grilla.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            grilla.DefaultCellStyle.SelectionBackColor = Color.FromArgb(0, 120, 215);
            grilla.DefaultCellStyle.SelectionForeColor = Color.White;
            grilla.BackgroundColor = Color.White;
            grilla.EnableHeadersVisualStyles = false;
            grilla.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            grilla.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(0, 120, 215);
            grilla.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            grilla.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            grilla.DefaultCellStyle.Font = new Font("Segoe UI", 9);
            grilla.RowTemplate.Height = 28;
        }

        private void dgvUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return; // Evitar clics en encabezados

            try
            {
                DataGridViewRow row = Grilla_Sin_Cuentas.Rows[e.RowIndex];

                // Obtener datos del usuario seleccionado
                string nombre = row.Cells["Nombre"].Value?.ToString() ?? "";
                string apellido = row.Cells["Apellido"].Value?.ToString() ?? "";
                string dni = row.Cells["DNI"].Value?.ToString() ?? "";
                string tipoUsuario = row.Cells["TipoUsuario"].Value?.ToString() ?? "";

                // Autocompletar nombre de usuario sugerido (nombre.apellido)
                if (!string.IsNullOrEmpty(nombre) && !string.IsNullOrEmpty(apellido))
                {
                    txtNombreUsuario.Text = $"{nombre.ToLower()}.{apellido.ToLower()}";
                }

                // Limpiar campos de contraseña para nueva cuenta
                txtContrasena.Clear();
                txtConfirmarContrasena.Clear();

                // Enfocar el campo de contraseña para facilitar ingreso
                txtContrasena.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al seleccionar usuario:\n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Btn_volver_Click(object sender, EventArgs e)
        {
            FrmControlGestion principal = (FrmControlGestion)this.ParentForm;
            principal.MostrarBienvenida();
            this.Close();
        }

        private void Grilla_Users_Con_Contraseña_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            try
            {
                DataGridViewRow row = Grilla_Users_Con_Contraseña.Rows[e.RowIndex];

                string nombreUsuario = row.Cells[3].Value?.ToString() ?? "";

                // Mostrar nombre completo Y usuario
                TXT_User_Con_Cuenta.Text = $"{nombreUsuario}";

                TXT_Nueva_Contraseña.Clear();
                TXT_Confirmar_Contraseña.Clear();
                TXT_Nueva_Contraseña.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al seleccionar usuario:\n{ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BTN_Modi_Contraseña_Click(object sender, EventArgs e)
        {
            if (Grilla_Users_Con_Contraseña.CurrentRow == null)
            {
                MessageBox.Show("Seleccione un usuario de la lista.", "Advertencia",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(TXT_Nueva_Contraseña.Text))
            {
                MessageBox.Show("Ingrese la nueva contraseña.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (TXT_Nueva_Contraseña.Text.Length < 6)
            {
                MessageBox.Show("La contraseña debe tener al menos 6 caracteres.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (TXT_Nueva_Contraseña.Text != TXT_Confirmar_Contraseña.Text)
            {
                MessageBox.Show("Las contraseñas no coinciden.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validar que el nombre de usuario no esté vacío
            if (string.IsNullOrWhiteSpace(TXT_User_Con_Cuenta.Text))
            {
                MessageBox.Show("El nombre de usuario no puede estar vacío.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int idUsuario = Convert.ToInt32(Grilla_Users_Con_Contraseña.CurrentRow.Cells[0].Value);
            string nombreMostrado = TXT_User_Con_Cuenta.Text;
            string nuevoNombreUsuario = TXT_User_Con_Cuenta.Text.Trim();

            DialogResult confirm = MessageBox.Show(
                $"¿Está seguro de que desea modificar los datos de:\n{nombreMostrado}?",
                "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirm != DialogResult.Yes) return;

            // Modificar nombre de usuario
            bool nombreActualizado = LoginDAL.ModificarNombreUsuario(idUsuario, nuevoNombreUsuario);
            if (!nombreActualizado)
            {
                MessageBox.Show("El nombre de usuario ya existe, elija otro.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Modificar contraseña
            bool contraseñaActualizada = LoginDAL.ModificarContrasena(idUsuario, TXT_Nueva_Contraseña.Text);
            if (!contraseñaActualizada)
            {
                MessageBox.Show("Error al modificar la contraseña.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Si ambos fueron exitosos
            MessageBox.Show("Usuario modificado correctamente.", "Éxito",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            limpiarcamposcontraseña();
            CargarUsuariosConLogin(); // ✅ Refresca la grilla
        }

        private void BTN_Limpiar_Modi_Click(object sender, EventArgs e)
        {
            limpiarcamposcontraseña();
        }

        private void ConfigurarColumnasSinLogin()
        {
            Grilla_Sin_Cuentas.AutoGenerateColumns = false;
            Grilla_Sin_Cuentas.Columns.Clear();

            Grilla_Sin_Cuentas.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "ID_Usuario",
                HeaderText = "ID",
                Width = 50,
                Visible = false // Lo ocultamos, solo lo necesitamos para el código
            });
            Grilla_Sin_Cuentas.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "DNI",
                HeaderText = "DNI",
                Width = 90
            });
            Grilla_Sin_Cuentas.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "Nombre",
                HeaderText = "Nombre",
                Width = 130
            });
            Grilla_Sin_Cuentas.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "Apellido",
                HeaderText = "Apellido",
                Width = 130
            });
            Grilla_Sin_Cuentas.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "TipoUsuario",
                HeaderText = "Rol",
                Width = 120
            });
        }

        private void ConfigurarColumnasConLogin()
        {
            Grilla_Users_Con_Contraseña.AutoGenerateColumns = false;
            Grilla_Users_Con_Contraseña.Columns.Clear();

            Grilla_Users_Con_Contraseña.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "ID_Usuario",
                HeaderText = "ID",
                Visible = false // Oculto, solo para el código
            });
            Grilla_Users_Con_Contraseña.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "Nombre",
                HeaderText = "Nombre",
                Width = 130
            });
            Grilla_Users_Con_Contraseña.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "Apellido",
                HeaderText = "Apellido",
                Width = 130
            });
            Grilla_Users_Con_Contraseña.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "NombreUsuario",
                HeaderText = "Usuario",
                Width = 150
            });
            Grilla_Users_Con_Contraseña.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "TipoUsuario",
                HeaderText = "Rol",
                Width = 120
            });
        }
    }
}