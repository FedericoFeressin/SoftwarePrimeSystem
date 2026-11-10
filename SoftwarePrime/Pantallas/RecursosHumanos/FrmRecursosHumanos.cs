using SoftwarePrime.Pantallas;
using SoftwarePrime.Pantallas.Clientes;
using SoftwarePrime.Pantallas.RecursosHumanos;
using SoftwarePrime;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoftwarePrime.Pantallas
{
    public partial class FrmRecursosHumanos : Form
    {
        public FrmRecursosHumanos()
        {
            InitializeComponent();
        }

        #region Eventos de Formulario

        private void FrmRecursosHumanos_Load(object sender, EventArgs e)
        {
            Panel_Centro.Left = (this.ClientSize.Width - Panel_Centro.Width) / 2; // Centrar horizontalmente
            Panel_Centro.Top = (this.ClientSize.Height - Panel_Centro.Height) / 2; // Centrar verticalmente
        }

        private void BTN_Form_Users_Click(object sender, EventArgs e)
        {
            FrmUsuarios frm = new FrmUsuarios(); // Crear instancia del formulario de usuarios

            // Obtener referencia al formulario principal
            FrmControlGestion principalRRHH = (FrmControlGestion)this.ParentForm; // Obtener referencia al formulario principal
            principalRRHH.AbrirFormularioEnPanel(frm); // Llamar al método para abrir el formulario en el panel
        }

        private void BTN_Form_Cliente_Click(object sender, EventArgs e)
        {
            FrmAltaClientes frm = new FrmAltaClientes(); // Crear instancia del formulario de clientes
            FrmControlGestion principalClientes = (FrmControlGestion)this.ParentForm; // Obtener referencia al formulario principal
            principalClientes.AbrirFormularioEnPanel(frm); // Llamar al método para abrir el formulario en el panel
        }

        private void BTN_Form_Prov_Click(object sender, EventArgs e)
        {
            FrmProveedores frm = new FrmProveedores(); // Crear instancia del formulario de proveedores
            FrmControlGestion principalPROV = (FrmControlGestion)this.ParentForm; // Obtener referencia al formulario principal
            principalPROV.AbrirFormularioEnPanel(frm); // Llamar al método para abrir el formulario en el panel
        }

        private void BTN_Form_Login_Click(object sender, EventArgs e)
        {
            FrmGestionLogin frm = new FrmGestionLogin();
            FrmControlGestion principalLogin = (FrmControlGestion)this.ParentForm;
            principalLogin.AbrirFormularioEnPanel(frm);
        }

        private void Btn_volver_Click(object sender, EventArgs e)
        {
            FrmControlGestion principal = (FrmControlGestion)this.ParentForm;
            principal.MostrarBienvenida();
            this.Close();
        }
        #endregion


    }
}
