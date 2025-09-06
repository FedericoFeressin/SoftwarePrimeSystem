using SoftwarePrime.Pantallas;
using SoftwarePrime.Pantallas.Clientes;
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

namespace SoftwarePrime
{
    public partial class FrmControlGestion : Form
    {
        public FrmControlGestion()
        {
            InitializeComponent();
        }

        //Constantes para mover el formulario
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]


        private extern static bool ReleaseCapture();
        

        #region Eventos Clicks


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

        private void btn_Estado_Contable_Click(object sender, EventArgs e)
        {
            PanelVista.Controls.Clear();
            FrmEstadoContable frmEstadoContable = new FrmEstadoContable();
            frmEstadoContable.TopLevel = false;
            frmEstadoContable.FormBorderStyle = FormBorderStyle.None;
            frmEstadoContable.Dock = DockStyle.Fill;
            PanelVista.Controls.Add(frmEstadoContable);
            frmEstadoContable.Show();
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


        #endregion

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
    }
}
