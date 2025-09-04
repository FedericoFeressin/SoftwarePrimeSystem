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

namespace SoftwarePrime
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            lblError.Text = "";
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);


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

        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "USUARIO")
            {
                txtUsuario.Text = "";
                txtUsuario.ForeColor = Color.Silver;
            }
        }
        private void txtUsuario_Enter(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "USUARIO")
            {
                txtUsuario.Text = "";
                txtUsuario.ForeColor = Color.Black;
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
                FrmControlGestion frmGestion = new FrmControlGestion();
                frmGestion.Show();

                // Opcional: ocultar el login en vez de cerrarlo
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
        #endregion

    }
}
