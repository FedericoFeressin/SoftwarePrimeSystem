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

namespace SoftwarePrime
{
    public partial class FrmControlGestion : Form
    {
        public FrmControlGestion()
        {
            InitializeComponent();
        }


        #region Eventos Clicks
        

        private void btn_Clientes_Click(object sender, EventArgs e)
        {
            PanelVista.Controls.Clear(); // Limpia el panel
            FrmAltaClientes frmClientes = new FrmAltaClientes();
            frmClientes.TopLevel = false; // Permite incrustar el formulario
            frmClientes.FormBorderStyle = FormBorderStyle.None; // Sin bordes
            frmClientes.Dock = DockStyle.Fill; // Ocupa todo el panel
            PanelVista.Controls.Add(frmClientes); // Agrega al panel
            frmClientes.Show(); // Muestra el formulario incrustado
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



        #endregion

        private void BTN_Cerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BTN_Minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
