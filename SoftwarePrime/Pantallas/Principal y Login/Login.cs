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
using SoftwarePrime.Pantallas.RecursosHumanos;
using SoftwarePrime.Pantallas.Usuario;
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
        private void btnAcceder_Click(object sender, EventArgs e)//-------
        {
            // Obtener los valores de los TextBox
            string usuario = txtUsuario.Text;
            string contrasena = txtContraseña.Text;

            // Verificar las credenciales
            if (usuario == "admin123" && contrasena == "admin123") // Cambia "admin" por la contraseña que desees
            {
                // Abrir el formulario FrmControlGestion
                FrmControlGestion frmGestion = new FrmControlGestion("ADMINISTRADOR");
                frmGestion.Show();

                // Opcional: ocultar el login en vez de cerrarlo
                this.Hide();
            }
            if (usuario == "empleado123" && contrasena == "empleado123")
            {
                FrmControlGestion frmControlGestion = new FrmControlGestion("EMPLEADO");
                frmControlGestion.Show();

                this.Hide();
            }
            
            else
            {
                // Mostrar mensaje de error si las credenciales son incorrectas
                lblError.Text = "Usuario o contraseña incorrectos.";
                lblError.ForeColor = Color.Red; // Cambia el color del texto a rojo
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
