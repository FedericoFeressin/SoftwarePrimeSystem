using SoftwarePrime.Pantallas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using SoftwarePrime;
using SoftwarePrime.Pantallas.Clientes;
using SoftwarePrime.Pantallas.Articulos;
using FontAwesome.Sharp;

namespace SoftwarePrime
{
    public partial class FrmControlGestion : Form
    {
        //Rol del usuario logueado
        public string Rol { get; private set; }
        public FrmControlGestion(string rol)
        {
            InitializeComponent();
            //Asigno el rol del usuario logueado a la variable global
            this.Rol = rol; 
            PersonalizarBotones();
        }
        
        #region variables globales
        //Constantes para mover el formulario
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]

        private extern static bool ReleaseCapture();
        #endregion

        #region Eventos Clicks

        private void FrmControlGestion_Load(object sender, EventArgs e)
        {
            configurarRol();
            User_Tipo.Text = "" + this.Rol;
            LBL_Hora.Text = DateTime.Now.ToString("HH:mm:ss");

        }

        private void BTN_Articulos_Click(object sender, EventArgs e)
        {
            PanelVista.Controls.Clear();
            FrmArticulos frmArticulos = new FrmArticulos();
            frmArticulos.TopLevel = false;
            frmArticulos.FormBorderStyle = FormBorderStyle.None;
            frmArticulos.Dock = DockStyle.Fill;
            PanelVista.Controls.Add(frmArticulos);
            frmArticulos.Show();
        }
        private void btn_Clientes_Click(object sender, EventArgs e)
        {
            PanelVista.Controls.Clear();
            FrmAltaClientes frmAltaClientes = new FrmAltaClientes();
            frmAltaClientes.TopLevel = false;
            frmAltaClientes.FormBorderStyle = FormBorderStyle.None;
            frmAltaClientes.Dock = DockStyle.Fill;
            PanelVista.Controls.Add(frmAltaClientes);
            frmAltaClientes.Show();
        }

        private void btn_Compras_Click(object sender, EventArgs e)
        {
            PanelVista.Controls.Clear();
            FrmCompras frmcompras = new FrmCompras();
            frmcompras.TopLevel = false;
            frmcompras.FormBorderStyle = FormBorderStyle.None;
            frmcompras.Dock = DockStyle.Fill;
            PanelVista.Controls.Add(frmcompras);
            frmcompras.Show();
        }

        private void btn_Ventas_Click(object sender, EventArgs e)
        {
            PanelVista.Controls.Clear();
            FrmVentas frmVentas = new FrmVentas();
            frmVentas.TopLevel = false;
            frmVentas.FormBorderStyle = FormBorderStyle.None;
            frmVentas.Dock = DockStyle.Fill;
            PanelVista.Controls.Add(frmVentas);
            frmVentas.Show();
        }

        private void btn_RRHH_Click(object sender, EventArgs e)
        {
            PanelVista.Controls.Clear();
            FrmRecursosHumanos frmRecursosHumanos = new FrmRecursosHumanos();
            frmRecursosHumanos.TopLevel = false;
            frmRecursosHumanos.FormBorderStyle = FormBorderStyle.None;
            frmRecursosHumanos.Dock = DockStyle.Fill;
            PanelVista.Controls.Add(frmRecursosHumanos);
            frmRecursosHumanos.Show();
        }

        private void btn_Proveedores_Click(object sender, EventArgs e)
        {
            PanelVista.Controls.Clear();
            FrmProveedores frmProveedores = new FrmProveedores();
            frmProveedores.TopLevel = false;
            frmProveedores.FormBorderStyle = FormBorderStyle.None;
            frmProveedores.Dock = DockStyle.Fill;
            PanelVista.Controls.Add(frmProveedores);
            frmProveedores.Show();

        }

        

        private void btn_Usuario_Click(object sender, EventArgs e)
        {
            PanelVista.Controls.Clear();
            FrmUsuarios frmUsuarios = new FrmUsuarios();
            frmUsuarios.TopLevel = false;
            frmUsuarios.FormBorderStyle = FormBorderStyle.None;
            frmUsuarios.Dock = DockStyle.Fill;
            PanelVista.Controls.Add(frmUsuarios);
            frmUsuarios.Show();
        }

        private void BTN_Cerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BTN_Minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        //Código para mover el formulario

        private void panelTopBar_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (e.Clicks == 1 && e.Y <= this.Height && e.Y >= 0)
                {
                    ReleaseCapture();
                    SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
                }
            }
        }

        private void Btn_Desconectar_Click(object sender, EventArgs e)
        {
            this.Close();
            Login frmLogin = new Login();
            frmLogin.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            LBL_Hora.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void BTN_Inicio_Click(object sender, EventArgs e)
        {
            MostrarBienvenida();
        }

        #endregion

        #region METODOS

        private void PersonalizarBotones()
        {
            // Btn_Minimizar
            Btn_Minimizar.Text = "▬";
            Btn_Minimizar.Font = new Font("Segoe UI", 8, FontStyle.Bold);
            Btn_Minimizar.BackColor = Color.LightSkyBlue;
            Btn_Minimizar.FlatStyle = FlatStyle.Flat;
            Btn_Minimizar.FlatAppearance.BorderSize = 0;
            Btn_Minimizar.ForeColor = Color.Black;
            Btn_Minimizar.Cursor = Cursors.Hand;
            Btn_Minimizar.MouseEnter += (s, e) => Btn_Minimizar.BackColor = Color.DeepSkyBlue;
            Btn_Minimizar.MouseLeave += (s, e) => Btn_Minimizar.BackColor = Color.LightSkyBlue;
            Btn_Minimizar.Click += (s, e) => this.WindowState = FormWindowState.Minimized;

            // Btn_Cerrar
            Btn_Cerrar.Text = "✖";
            Btn_Cerrar.Font = new Font("Segoe UI", 8, FontStyle.Bold);
            Btn_Cerrar.BackColor = Color.Red;
            Btn_Cerrar.FlatStyle = FlatStyle.Flat;
            Btn_Cerrar.FlatAppearance.BorderSize = 0;
            Btn_Cerrar.ForeColor = Color.White;
            Btn_Cerrar.Cursor = Cursors.Hand;
            Btn_Cerrar.MouseEnter += (s, e) => Btn_Cerrar.BackColor = Color.DarkRed;
            Btn_Cerrar.MouseLeave += (s, e) => Btn_Cerrar.BackColor = Color.Red;
            Btn_Cerrar.Click += (s, e) => this.Close();
        } 

        public void AbrirFormularioEnPanel(Form formHijo)
        {
            // Limpia el panel antes de cargar otro formulario
            if (PanelVista.Controls.Count > 0)
                PanelVista.Controls.RemoveAt(0);

            formHijo.TopLevel = false;
            formHijo.Dock = DockStyle.Fill;
            PanelVista.Controls.Add(formHijo);
            PanelVista.Tag = formHijo;
            formHijo.Show();
        }
        public void MostrarBienvenida()
        {
            // Quita cualquier formulario hijo cargado dinámicamente
            PanelVista.Controls.Clear();

            // Vuelve a agregar los controles originales de bienvenida
            PanelVista.Controls.Add(LBL_Hora);
            PanelVista.Controls.Add(panel1);
            PanelVista.Controls.Add(label2);
            PanelVista.Controls.Add(label1);
            PanelVista.Controls.Add(pictureBox1);

            // Opcional: ajusta el orden de los controles si es necesario
            LBL_Hora.BringToFront();
            panel1.BringToFront();
            label2.BringToFront();
            label1.BringToFront();
            pictureBox1.BringToFront();
        }
        public  void configurarRol()
        {
            btn_Clientes.Visible = false;
            btn_Compras.Visible = false;
            btn_Proveedores.Visible = false;
            btn_RRHH.Visible = false;
            btn_Usuarios.Visible = false;
            btn_Ventas.Visible = false;

            if (Rol == "ADMINISTRADOR")
            {
                btn_Clientes.Visible = true;
                btn_Compras.Visible = true;
                btn_Proveedores.Visible = true;
                btn_RRHH.Visible = true;
                btn_Usuarios.Visible = true;
                btn_Ventas.Visible = true;

            }
            else if (Rol == "EMPLEADO")
            {
                btn_Clientes.Visible = true;
                btn_Compras.Visible = true;
                btn_Proveedores.Visible = true;
                btn_Ventas.Visible = true;
            }
            
        }


        #endregion

       
    }
}
