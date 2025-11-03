using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SoftwarePrime.Pantallas.Usuario;
using Conexion_Base_de_Datos;

namespace SoftwarePrime.Pantallas.Usuario
{
    public partial class UcUsuario : UserControl
    {
        public UcUsuario()
        {
            InitializeComponent();
        }


        #region Propiedades UserControl
        // Propiedades para acceder a los controles desde fuera

        public DataGridView DGV_User
        {
            get { return GrillaUsers; }
            set { GrillaUsers = value; }
        }
        public TextBox DniTextBox
        {
            get { return TXT_DNI; }
            set { TXT_DNI = value; }
        }

        public TextBox NombreTextBox
        {
            get { return TEXT_Nom; }
            set { TEXT_Nom = value; }
        }

        public TextBox ApellidoTextBox
        {
            get { return TXT_Ape; }
            set { TXT_Ape = value; }
        }

        public TextBox TelefonoTextBox
        {
            get { return TXT_Telf; }
            set { TXT_Telf = value; }
        }

        public TextBox EmailTextBox
        {
            get { return TXT_Email; }
            set { TXT_Email = value; }
        }

        public ComboBox TipoUsuarioComboBox
        {
            get { return Combo_Rol; }
            set { Combo_Rol = value; }
        }

        public RadioButton ActivoCheckBox
        {
            get { return RB_Activo; }
            set { RB_Activo = value; }
        }

        public RadioButton InactivoRadioButton
        {
            get { return RB_Inactivo; }
            set { RB_Inactivo = value; }
        }

        public Button AgregarButton
        {
            get { return BTN_Agregar; }
            set { BTN_Agregar = value; }
        }

        public Button ModificarButton
        {
            get { return BTN_Modificar; }
            set { BTN_Modificar = value; }
        }

        public Button EliminarButton
        {
            get { return BTN_BajaLogica; }
            set { BTN_BajaLogica = value; }
        }
        #endregion

        #region Eventos

        private void UcUsuario_Load(object sender, EventArgs e)
        {
            cargargrilla(DGV_User);
            CargarRoles(Combo_Rol);
        }

        private void BTN_Agregar_Click(object sender, EventArgs e)
        {

            ModeloUsuario usuario = new ModeloUsuario(
                int.Parse(TXT_DNI.Text),
                TEXT_Nom.Text,
                TXT_Ape.Text,
                TXT_Telf.Text,
                TXT_Email.Text,
                int.Parse(Combo_Rol.SelectedValue.ToString()),
                RB_Activo.Checked
            );
            try
            {
                // Llamar al método para insertar el usuario
                ClaseSent.InsertarUsuario(usuario);
                MessageBox.Show("Usuario agregado exitosamente.");
                LimpiarCampos(this);


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar el usuario: " + ex.Message);
                return;
            }


        }

        private void BTN_Modificar_Click(object sender, EventArgs e)
        {


            ModeloUsuario usuario = new ModeloUsuario(
                int.Parse(TXT_DNI.Text),
                TEXT_Nom.Text,
                TXT_Ape.Text,
                TXT_Telf.Text,
                TXT_Email.Text,
                int.Parse(Combo_Rol.SelectedValue.ToString()),
                RB_Activo.Checked
            );
            try
            {
                // Llamar al método para modificar el usuario
                ClaseSent.ModificarUsuario(usuario);
                MessageBox.Show("Usuario modificado exitosamente.");
                LimpiarCampos(this);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar el usuario: " + ex.Message);
                return;
            }

        }

        private void BTN_BajaLogica_Click(object sender, EventArgs e)
        {
            int dni;
            if (!int.TryParse(TXT_DNI.Text, out dni))
            {
                MessageBox.Show("DNI inválido. Por favor, ingrese un número válido.");
                return;
            }
            try
            {
                // Llamar al método para eliminar lógicamente el usuario
                ClaseSent.BajaLogicaUsuario(dni);
                MessageBox.Show("Usuario eliminado lógicamente exitosamente.");
                LimpiarCampos(this);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar lógicamente el usuario: " + ex.Message);
                return;
            }

        }

        #endregion

        #region
         
        public static void CargarRoles(ComboBox comboBox)
        {
            try
            {
                using (var conexion = ConexionBD.GetConnection())
                {
                    conexion.Open();
                    var query = "SELECT ID_Tipo, Descripcion FROM Usuario_Tipo";
                    using (var comando = new System.Data.SqlClient.SqlCommand(query, conexion))
                    {
                        var adapter = new System.Data.SqlClient.SqlDataAdapter(comando);
                        var dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        comboBox.DisplayMember = "Descripcion";
                        comboBox.ValueMember = "ID_Tipo";
                        comboBox.DataSource = dataTable;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los roles: " + ex.Message);
            }
        }

        public static void LimpiarCampos(UcUsuario ucUsuario)
        {
            ucUsuario.TXT_DNI.Clear();
            ucUsuario.TEXT_Nom.Clear();
            ucUsuario.TXT_Ape.Clear();
            ucUsuario.TXT_Telf.Clear();
            ucUsuario.TXT_Email.Clear();
            if (ucUsuario.Combo_Rol.Items.Count > 0)
            {
                ucUsuario.Combo_Rol.SelectedIndex = 0; // Selecciona el primer ítem
            }
            ucUsuario.RB_Activo.Checked = true; // Marca "Activo" por defecto
        }

        public static void cargargrilla (DataGridView dataGridView)
        {
            try
            {
                using (var conexion = ConexionBD.GetConnection())
                {
                    conexion.Open();
                    var query = @"SELECT u.DNI, u.Nombre, u.Apellido, u.Telefono, u.Email, tu.Descripcion AS TipoUsuario, 
                                  CASE WHEN u.Activo = 1 THEN 'Activo' ELSE 'Inactivo' END AS Estado
                                  FROM Usuario u
                                  JOIN TipoUsuario tu ON u.ID_Tipo = tu.ID_Tipo";
                    using (var comando = new System.Data.SqlClient.SqlCommand(query, conexion))
                    {
                        var adapter = new System.Data.SqlClient.SqlDataAdapter(comando);
                        var dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        dataGridView.DataSource = dataTable;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar la grilla: " + ex.Message);
            }
        }




        #endregion Métodos Auxiliares

       
    }
}
