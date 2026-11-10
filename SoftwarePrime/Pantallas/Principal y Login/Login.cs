using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SoftwarePrime.Pantallas.Usuario;
using SoftwarePrime.Pantallas.Login;
using SoftwarePrime;

namespace SoftwarePrime
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            lblError.Text = "";
        }

        

        #region variables
        //
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private static extern int SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        #endregion


        #region Eventos Clicks

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void txtUsuario_Enter(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "USUARIO")
            {
                txtUsuario.Text = "";
                txtUsuario.ForeColor = Color.Black;
            }
        }

        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "")
            {
                txtUsuario.Text = "USUARIO";
                txtUsuario.ForeColor = Color.Silver;
            }
        }
        

        private void txtContraceña_Leave(object sender, EventArgs e)//-------
        {
            if (string.IsNullOrWhiteSpace(txtContraseña.Text))
            {
                txtContraseña.Text = "CONTRASEÑA";
                txtContraseña.ForeColor = Color.Silver;
                txtContraseña.UseSystemPasswordChar = false;
            }

        }

        private void txtContraceña_Enter(object sender, EventArgs e)//-------
        {
            if (txtContraseña.Text == "CONTRASEÑA")
            {
                txtContraseña.Text = "";
                txtContraseña.ForeColor = Color.Black;
                txtContraseña.UseSystemPasswordChar = true;
            }
        }


        private void btnAcceder_Click(object sender, EventArgs e)
        {
            // Validar que los campos no estén vacíos
            if (string.IsNullOrWhiteSpace(txtUsuario.Text) || txtUsuario.Text == "USUARIO")
            {
                lblError.Text = "Por favor, ingrese su usuario.";
                lblError.ForeColor = Color.Red;
                return;
            }

            if (string.IsNullOrWhiteSpace(txtContraseña.Text) || txtContraseña.Text == "CONTRASEÑA")
            {
                lblError.Text = "Por favor, ingrese su contraseña.";
                lblError.ForeColor = Color.Red;
                return;
            }

            try
            {
                // Obtener los valores de los TextBox
                string usuario = txtUsuario.Text.Trim();
                string contrasena = txtContraseña.Text;

                // Validar credenciales en la base de datos
                DataTable resultado = LoginDAL.ValidarLogin(usuario, contrasena);

                if (resultado != null && resultado.Rows.Count > 0)
                {
                    // Login exitoso - Guardar datos de sesión
                    DataRow row = resultado.Rows[0];
                    SesionActual.ID_Usuario = Convert.ToInt32(row["ID_Usuario"]);
                    SesionActual.NombreUsuario = row["NombreUsuario"].ToString();
                    SesionActual.NombreCompleto = $"{row["Nombre"]} {row["Apellido"]}";
                    SesionActual.ID_Tipo = Convert.ToInt32(row["ID_Tipo"]);
                    SesionActual.TipoUsuario = row["TipoUsuario"].ToString();

                    // Abrir el formulario principal
                    FrmControlGestion frmGestion = new FrmControlGestion(SesionActual.TipoUsuario);
                    frmGestion.Show();

                    // Limpiar y ocultar el login
                    lblError.Text = "";
                    txtUsuario.Text = "USUARIO";
                    txtContraseña.Text = "CONTRASEÑA";
                    txtContraseña.UseSystemPasswordChar = false;
                    this.Hide();
                }
                else
                {
                    // Mostrar mensaje de error si las credenciales son incorrectas
                    lblError.Text = "Usuario o contraseña incorrectos.";
                    lblError.ForeColor = Color.Red;
                    txtContraseña.Clear();
                    txtContraseña.Focus();
                }
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                // Error de base de datos
                if (ex.Message.Contains("Invalid object name 'Login'") || 
                    ex.Message.Contains("Invalid object name 'Usuario_Tipo'"))
                {
                    MessageBox.Show(
                        "⚠️ ERROR: Las tablas de base de datos no existen.\n\n" +
                        "SOLUCIÓN:\n" +
                        "1. Abre SQL Server Management Studio\n" +
                        "2. Verifica la cadena de conexión 'PrimeSystem' en App.config\n" +
                        "3. Selecciona la base de datos: PrimeSystem\n" +
                        "4. Ejecuta el script: PrimeSystem_DB_Completo.sql\n\n" +
                        "El script está en la carpeta 'Base de Datos' del proyecto.\n\n" +
                        "Después de ejecutarlo, usa:\n" +
                        "Usuario: admin\n" +
                        "Contraseña: admin123",
                        "Error de Base de Datos",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                }
                else
                {
                    MessageBox.Show(
                        $"⚠️ ERROR DE CONEXIÓN A LA BASE DE DATOS:\n\n{ex.Message}\n\n" +
                        "Verifica que:\n" +
                        "1. SQL Server esté ejecutándose\n" +
                        "2. La cadena de conexión 'PrimeSystem' de App.config sea correcta\n" +
                        "3. La base de datos PrimeSystem exista\n" +
                        "4. Las tablas Login y Usuario_Tipo estén creadas",
                        "Error de Conexión",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                }
                lblError.Text = "Error de conexión a la base de datos.";
                lblError.ForeColor = Color.Red;
            }
            catch (Exception ex)
            {
                // Error genérico
                MessageBox.Show(
                    $"⚠️ ERROR INESPERADO:\n\n{ex.Message}",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                lblError.Text = "Error al procesar el login.";
                lblError.ForeColor = Color.Red;
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Login_Load(object sender, EventArgs e)
        {
            System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();
            int radius = 30; // Radio de las esquinas redondeadas

            path.AddArc(0, 0, radius, radius, 180, 90);
            path.AddArc(this.Width - radius, 0, radius, radius, 270, 90);
            path.AddArc(this.Width - radius, this.Height - radius, radius, radius, 0, 90);
            path.AddArc(0, this.Height - radius, radius, radius, 90, 90);

            this.Region = new Region(path);
        }




        //Código para mover el formulario

        //Constantes para mover el formulario
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        private void topbar_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (e.Clicks == 1 && e.Y <= this.Height && e.Y >= 0)
                {
                    ReleaseCapture();
                    SendMessage(this.Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
                }
            }
        }

        #endregion


    }
}
