using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SoftwarePrime.Pantallas.Articulos;
using SoftwarePrime;

namespace SoftwarePrime.Pantallas.Articulos
{
    public partial class FrmArticulos : Form
    {
        private SentenciasArticulos dao = new SentenciasArticulos(); // Instancia del DAO para operaciones de artículos
        public FrmArticulos()
        {
            InitializeComponent();

            // Solo cargar datos si no estamos en modo diseño
            if (!DesignMode && System.ComponentModel.LicenseManager.UsageMode != System.ComponentModel.LicenseUsageMode.Designtime)
            {
                CargarCombos();
                CargarGrilla();
                EstilizarGrilla();
                if (TXT_Precio_Venta != null)
                {
                    TXT_Precio_Venta.ReadOnly = true;
                }
            }
        }


        #region Metodos Privados

        private void EstilizarGrilla()
        {
            Grilla_Articulos.BorderStyle = BorderStyle.None;
            Grilla_Articulos.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(240, 240, 240);
            Grilla_Articulos.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            Grilla_Articulos.DefaultCellStyle.SelectionBackColor = Color.FromArgb(0, 120, 215);
            Grilla_Articulos.DefaultCellStyle.SelectionForeColor = Color.White;
            Grilla_Articulos.BackgroundColor = Color.White;
            Grilla_Articulos.EnableHeadersVisualStyles = false;
            Grilla_Articulos.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            Grilla_Articulos.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(0, 120, 215);
            Grilla_Articulos.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            Grilla_Articulos.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            Grilla_Articulos.DefaultCellStyle.Font = new Font("Segoe UI", 9);
            Grilla_Articulos.RowTemplate.Height = 28;
        }
        private void CargarCombos()
        {
            CMB_Categoria.DataSource = dao.ObtenerCategorias();
            CMB_Categoria.DisplayMember = "Nombre_Categoria";
            CMB_Categoria.ValueMember = "ID_Categoria";
            CMB_Categoria.SelectedIndex = -1;

            CMB_Prov.DataSource = dao.ObtenerProveedores();
            CMB_Prov.DisplayMember = "Nombre";
            CMB_Prov.ValueMember = "ID_Proveedor";
            CMB_Prov.SelectedIndex = -1;

            CMB_Categoria.SelectedIndexChanged += CmbCategoria_SelectedIndexChanged;
        }

        private void CargarGrilla()
        {
            try
            {
                var articulos = dao.ObtenerArticulos();

                if (articulos == null)
                {
                    MessageBox.Show("Error al obtener los artículos de la base de datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Grilla_Articulos.DataSource = null;
                    return;
                }

                Grilla_Articulos.DataSource = null;
                Grilla_Articulos.DataSource = articulos;
                Grilla_Articulos.AutoGenerateColumns = true;
                Grilla_Articulos.Refresh();

                Grilla_Articulos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                Grilla_Articulos.MultiSelect = false;
                Grilla_Articulos.ReadOnly = true;
                Grilla_Articulos.AllowUserToAddRows = false;
                Grilla_Articulos.AllowUserToDeleteRows = false;

                // Configurar visibilidad y orden de columnas
                if (Grilla_Articulos.Columns.Count > 0)
                {
                    // Ocultar columnas que no son necesarias para el usuario
                    OcultarColumna("ID_Articulo");
                    OcultarColumna("ID_Categoria");
                    OcultarColumna("ID_Subcategoria");
                    OcultarColumna("ID_Proveedor");
                    OcultarColumna("Activo");
                    OcultarColumna("FechaCreacion");
                    OcultarColumna("FechaModificacion");
                    OcultarColumna("Cantidad");

                    // Configurar encabezados de columnas
                    configurartamaño("Descripcion", 150);
                    ConfigurarColumna("Codigo", "Código", 150, 0);
                    ConfigurarColumnaNumerica("Costo", "Costo", 150, "C2", DataGridViewContentAlignment.MiddleRight, 2);
                    ConfigurarColumnaNumerica("PorcentajeGanancia", "% Ganancia", 90, "N2", DataGridViewContentAlignment.MiddleRight, 3);
                    ConfigurarColumnaNumerica("PrecioVenta", "Precio Venta", 110, "C2", DataGridViewContentAlignment.MiddleRight, 4);
                    ConfigurarColumna("StockMinimo", "Stock Mín.", 90, 5, DataGridViewContentAlignment.MiddleCenter);
                    ConfigurarColumna("StockActual", "Stock Actual", 100, 6, DataGridViewContentAlignment.MiddleCenter);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los artículos: " + ex.Message + "\n\nStack Trace: " + ex.StackTrace, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void OcultarColumna(string nombreColumna)
        {
            try
            {
                if (Grilla_Articulos.Columns.Contains(nombreColumna))
                {
                    var columna = Grilla_Articulos.Columns[nombreColumna];
                    if (columna != null)
                    {
                        columna.Visible = false;
                    }
                }
            }
            catch { }
        }

        private void configurartamaño (string nombre, int width)
        {
            try
            {
                if (Grilla_Articulos.Columns.Contains(nombre))
                {
                    var columna = Grilla_Articulos.Columns[nombre];
                    if (columna != null)
                    {
                        columna.Width = width;
                    }
                }
            }
            catch { }
        }



        private void ConfigurarColumna(string nombre, string headerText, int width, int displayIndex, DataGridViewContentAlignment? alignment = null)
        {
            try
            {
                if (Grilla_Articulos.Columns.Contains(nombre))
                {
                    var columna = Grilla_Articulos.Columns[nombre];
                    if (columna != null)
                    {
                        columna.HeaderText = headerText;
                        columna.Width = width;
                        columna.DisplayIndex = displayIndex;
                        if (alignment.HasValue)
                        {
                            columna.DefaultCellStyle.Alignment = alignment.Value;
                        }
                    }
                }
            }
            catch { }
        }

        

        private void ConfigurarColumnaNumerica(string nombre, string headerText, int width, string formato, DataGridViewContentAlignment alignment, int displayIndex)
        {
            try
            {
                if (Grilla_Articulos.Columns.Contains(nombre))
                {
                    var columna = Grilla_Articulos.Columns[nombre];
                    if (columna != null)
                    {
                        columna.HeaderText = headerText;
                        columna.Width = width;
                        columna.DefaultCellStyle.Format = formato;
                        columna.DefaultCellStyle.Alignment = alignment;
                        columna.DisplayIndex = displayIndex;
                    }
                }
            }
            catch { }
        }


        private void CalcularPrecioVenta() // Calcula el precio de venta basado en costo y ganancia
        {
            if (decimal.TryParse(TXT_Costo.Text, out decimal costo) && // Verifica si se pueden convertir costo y ganancia a decimal
                decimal.TryParse(TXT_Ganancia.Text, out decimal ganancia)) // Si la conversión es exitosa
            {
                decimal precioVenta = costo + (costo * (ganancia / 100)); // Calcula el precio de venta
                TXT_Precio_Venta.Text = precioVenta.ToString("0.00"); // Muestra el precio de venta con dos decimales
            }
            else
            {
                TXT_Precio_Venta.Text = ""; // Si la conversión falla, limpia el campo de precio de venta
            }
        }


        private void CargarCamposDesdeId(int id)
        {
            // Obtener la lista de artículos
            var articulos = dao.ObtenerArticulos(); // Suponiendo que este método devuelve una lista de artículos

            foreach (var art in articulos) // Buscar el artículo con el ID correspondiente
            {
                if (art.ID_Articulo == id) // Si encuentra el artículo
                {
                    CMB_Categoria.SelectedValue = art.ID_Categoria; // selecciona la categoría
                    CmbCategoria_SelectedIndexChanged(null, null); // carga subcategorías
                    CMB_Sub_Categoria.SelectedValue = art.ID_Subcategoria; // selecciona la subcategoría
                    CMB_Prov.SelectedValue = art.ID_Proveedor; // selecciona el proveedor
                    break; // Sale del bucle una vez encontrado
                }
            }
        }

        private void limpiarCampos()
        {
            TXT_Codigo.Clear();
            TXT_Descripcion.Clear();
            Numeric_Cantidad.Value = 0;
            TXT_Costo.Clear();
            TXT_Ganancia.Clear();
            TXT_Precio_Venta.Clear();
            CMB_Categoria.SelectedIndex = -1;
            CMB_Sub_Categoria.DataSource = null;
            CMB_Prov.SelectedIndex = -1;
        }

        #endregion

        #region Eventos clicks

        private void BTN_Agregar_Click(object sender, EventArgs e)
        {
            // Validaciones básicas
            if (string.IsNullOrWhiteSpace(TXT_Descripcion.Text)) // Verifica que la descripción no esté vacía
            {
                MessageBox.Show("Debe ingresar una descripción.");
                return;
            }

            string costoTexto = TXT_Costo.Text.Trim().Replace(',', '.').Replace("$", ""); // Reemplaza comas y signos de dólar
            if (!decimal.TryParse(costoTexto, System.Globalization.NumberStyles.Any, // Intenta convertir el texto a decimal
                System.Globalization.CultureInfo.InvariantCulture, out decimal costo)) // Usando cultura invariante para evitar problemas de formato
            {
                MessageBox.Show("Costo inválido. Ingrese un número válido (ej: 100.50)"); 
                return;
            }

            string gananciaTexto = TXT_Ganancia.Text.Trim().Replace(',', '.'); // Reemplaza comas
            if (!decimal.TryParse(gananciaTexto, System.Globalization.NumberStyles.Any, // Intenta convertir el texto a decimal
                System.Globalization.CultureInfo.InvariantCulture, out decimal ganancia)) // Usando cultura invariante para evitar problemas de formato
            {
                ganancia = 0; // Si no se puede convertir, asigna 0 como ganancia
            }

            // Crear el objeto artículo
            var art = new ModeloArticulo 
            {
                Codigo = TXT_Codigo.Text.Trim(), // Asigna el código del artículo
                Descripcion = TXT_Descripcion.Text.Trim(), // Asigna la descripción del artículo
                Cantidad = (int)Numeric_Cantidad.Value, // Asigna la cantidad del artículo
                Costo = costo, // Asigna el costo del artículo
                PorcentajeGanancia = ganancia, // Asigna el porcentaje de ganancia
                ID_Categoria = (CMB_Categoria.SelectedValue as int?) ?? 0, // Asigna la categoría seleccionada o 0 si no hay selección
                ID_Subcategoria = (CMB_Sub_Categoria.SelectedValue as int?) ?? 0, // Asigna la subcategoría seleccionada o 0 si no hay selección
                ID_Proveedor = (CMB_Prov.SelectedValue as int?) ?? 0 // Asigna el proveedor seleccionado o 0 si no hay selección
            };

            // Insertar en la base
            if (dao.AgregarArticulo(art)) // Llama al método de agregar artículo
            {
                MessageBox.Show("Artículo agregado correctamente.");
                CargarGrilla();
                limpiarCampos();
            }
            else
            {
                MessageBox.Show("Error al agregar artículo.");
            }


        }

        private void BTN_Modificar_Click(object sender, EventArgs e)
        {
            if (Grilla_Articulos.CurrentRow == null) // Verifica si hay una fila seleccionada
            {
                MessageBox.Show("Seleccione un artículo para modificar");
                return;
            }

            // Obtener el ID del artículo seleccionado
            int id = Convert.ToInt32(Grilla_Articulos.CurrentRow.Cells["ID_Articulo"].Value); 

            // Validar y convertir costo
            string costoTexto = TXT_Costo.Text.Trim().Replace(',', '.').Replace("$", "");
            if (!decimal.TryParse(costoTexto, System.Globalization.NumberStyles.Any,
                System.Globalization.CultureInfo.InvariantCulture, out decimal costo))
            {
                MessageBox.Show("Costo inválido. Ingrese un número válido (ej: 100.50)");
                return;
            }

            // Validar y convertir ganancia
            string gananciaTexto = TXT_Ganancia.Text.Trim().Replace(',', '.');
            if (!decimal.TryParse(gananciaTexto, System.Globalization.NumberStyles.Any,
                System.Globalization.CultureInfo.InvariantCulture, out decimal porc))
            {
                porc = 0;
            }

            // Crear el objeto con el ID correcto
            var art = new ModeloArticulo
            {
                ID_Articulo = id, // Asigna el ID del artículo a modificar
                Codigo = TXT_Codigo.Text.Trim(), // Asigna el código del artículo
                Descripcion = TXT_Descripcion.Text.Trim(), // Asigna la descripción del artículo
                Cantidad = (int)Numeric_Cantidad.Value, // Asigna la cantidad del artículo
                Costo = costo, // Asigna el costo del artículo
                PorcentajeGanancia = porc, // Asigna el porcentaje de ganancia  
                ID_Categoria = (CMB_Categoria.SelectedValue as int?) ?? 0, // Asigna la categoría seleccionada o 0 si no hay selección
                ID_Subcategoria = (CMB_Sub_Categoria.SelectedValue as int?) ?? 0, // Asigna la subcategoría seleccionada o 0 si no hay selección
                ID_Proveedor = (CMB_Prov.SelectedValue as int?) ?? 0 // Asigna el proveedor seleccionado o 0 si no hay selección
            };

            // Llamar al método de modificación
            if (dao.ModificarArticulo(art))
            {
                MessageBox.Show("Artículo modificado correctamente.");
                CargarGrilla();
                limpiarCampos();
            }
            else
            {
                MessageBox.Show("Error al modificar artículo.");
            }
        }

        private void BTN_Eliminar_Click(object sender, EventArgs e)
        {
            if (Grilla_Articulos.CurrentRow == null) // Verifica si hay una fila seleccionada
            {
                MessageBox.Show("Seleccione un artículo para eliminar.");
                return;
            }

            int id = Convert.ToInt32(Grilla_Articulos.CurrentRow.Cells["ID_Articulo"].Value); // Obtiene el ID del artículo seleccionado

            DialogResult confirmacion = MessageBox.Show( // Muestra un cuadro de confirmación
                "¿Está seguro de que desea eliminar este artículo?",
                "Confirmar eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (confirmacion == DialogResult.Yes)
            {
                if (dao.EliminarArticulo(id)) // Llama al método de eliminación
                {
                    MessageBox.Show("Artículo eliminado correctamente.");
                    CargarGrilla();
                    limpiarCampos();
                }
                else
                {
                    MessageBox.Show("No se pudo eliminar el artículo. Verifique si está en uso en otra tabla.");
                }
            }
        }

        private void TXT_Costo_TextChanged(object sender, EventArgs e)
        { 
            CalcularPrecioVenta(); // Recalcula el precio de venta cuando cambia el costo
        }

        private void TXT_Ganancia_TextChanged(object sender, EventArgs e)
        {
            CalcularPrecioVenta(); // Recalcula el precio de venta cuando cambia la ganancia
        }

        // Evento para cargar subcategorías al cambiar la categoría seleccionada
        private void CmbCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CMB_Categoria.SelectedValue is int idCat) // Verifica si el valor seleccionado es un entero
                CMB_Sub_Categoria.DataSource = dao.ObtenerSubcategoriasPorCategoria(idCat); // Carga las subcategorías correspondientes
            else
                CMB_Sub_Categoria.DataSource = null; // Si no es un entero, limpia el combo de subcategorías

            if (CMB_Sub_Categoria.DataSource != null) // Si hay subcategorías cargadas
            {
                CMB_Sub_Categoria.DisplayMember = "Nombre_Subcategoria"; // Establece el miembro para mostrar
                CMB_Sub_Categoria.ValueMember = "ID_Subcategoria"; // Establece el miembro de valor
                CMB_Sub_Categoria.SelectedIndex = -1; // Limpia la selección
            }
        }

        private void GrillaArticulos(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return; // Ignora si no es una fila válida
            var r = Grilla_Articulos.Rows[e.RowIndex]; // Obtiene la fila seleccionada
            TXT_Codigo.Text = r.Cells["Codigo"].Value?.ToString(); // Carga los datos en los campos correspondientes
            TXT_Descripcion.Text = r.Cells["Descripcion"].Value?.ToString(); // Carga la descripción

            // Cargar cantidad desde StockActual
            if (Grilla_Articulos.Columns.Contains("StockActual") && r.Cells["StockActual"].Value != null && r.Cells["StockActual"].Value != DBNull.Value)
                Numeric_Cantidad.Value = Convert.ToDecimal(r.Cells["StockActual"].Value);
            else
                Numeric_Cantidad.Value = 0;

            TXT_Costo.Text = (r.Cells["Costo"].Value ?? 0).ToString(); // Carga el costo
            TXT_Ganancia.Text = (r.Cells["PorcentajeGanancia"].Value ?? 0).ToString(); // Carga el porcentaje de ganancia
            TXT_Precio_Venta.Text = (r.Cells["PrecioVenta"].Value ?? 0).ToString(); // Carga el precio de venta
            int id = Convert.ToInt32(r.Cells["ID_Articulo"].Value); // Obtiene el ID del artículo
            CargarCamposDesdeId(id); // Carga los combos basados en el ID
        }

        private void Btn_volver_Click(object sender, EventArgs e)
        {
            FrmControlGestion principal = (FrmControlGestion)this.ParentForm;
            principal.MostrarBienvenida();
            this.Close();
        }

        private void BTN_GestionarCategorias_Click(object sender, EventArgs e)
        {
            // Abrir el formulario de gestión de categorías como diálogo modal
            using (FrmGestionCategorias frmCategorias = new FrmGestionCategorias())
            {
                frmCategorias.ShowDialog(); // Muestra el formulario como modal
            }

            // Recargar los combos de categorías después de cerrar el formulario
            CargarCombos();
        }

        #endregion



    }
}
