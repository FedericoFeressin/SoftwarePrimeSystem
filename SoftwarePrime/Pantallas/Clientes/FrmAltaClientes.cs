using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SoftwarePrime.Pantallas;

namespace SoftwarePrime.Pantallas.Clientes
{
    public partial class FrmAltaClientes : Form
    {
        public FrmAltaClientes()
        {
            InitializeComponent();
        }

        private void BTN_Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void BTN_Volver_Click(object sender, EventArgs e)
        {
            //this.WindowState = FormWindowState.Minimized;
            this.Close();
        }
    }
}
