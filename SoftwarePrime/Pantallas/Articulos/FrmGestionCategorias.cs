using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace SoftwarePrime.Pantallas.Articulos
{
    public partial class FrmGestionCategorias : Form
    {
        private SentenciasArticulos sentencias = new SentenciasArticulos();
        private bool modoCategoria = true; // true = Categorías, false = Subcategorías
        private int idSeleccionado = 0;

        public FrmGestionCategorias()
        {
            InitializeComponent();
        }

        private void FrmGestionCategorias_Load(object sender, EventArgs e)
        {
            EstilizarGrillas();
            MostrarCategorias();
            CargarCategoriasEnCombo();
        }

        #region Métodos de Carga

        private void MostrarCategorias()
        {
            try
            {
                dgvCategorias.DataSource = sentencias.ObtenerTodasCategorias();
                dgvCategorias.Columns["ID_Categoria"].Visible = false;
                dgvCategorias.Columns["Nombre_Categoria"].HeaderText = "Nombre";
                dgvCategorias.Columns["Descripcion"].HeaderText = "Descripción";
                dgvCategorias.Columns["Activo"].HeaderText = "Activo";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar categorías:\n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void MostrarSubcategorias()
        {
            try
            {
                dgvSubcategorias.DataSource = sentencias.ObtenerTodasSubcategorias();
                dgvSubcategorias.Columns["ID_Subcategoria"].Visible = false;
                dgvSubcategorias.Columns["ID_Categoria"].Visible = false;
                dgvSubcategorias.Columns["Nombre_SubCategoria"].HeaderText = "Nombre";
                dgvSubcategorias.Columns["Nombre_Categoria"].HeaderText = "Categoría";
                dgvSubcategorias.Columns["Descripcion"].HeaderText = "Descripción";
                dgvSubcategorias.Columns["Activo"].HeaderText = "Activo";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar subcategorías:\n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarCategoriasEnCombo()
        {
            try
            {
                DataTable dt = sentencias.ObtenerCategorias();
                CMB_Categoria.DataSource = dt;
                CMB_Categoria.DisplayMember = "Nombre_Categoria";
                CMB_Categoria.ValueMember = "ID_Categoria";
                CMB_Categoria.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar combo de categorías:\n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void EstilizarGrillas()
        {
            // Estilizar dgvCategorias
            dgvCategorias.BorderStyle = BorderStyle.None;
            dgvCategorias.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(240, 240, 240);
            dgvCategorias.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvCategorias.DefaultCellStyle.SelectionBackColor = Color.FromArgb(0, 120, 215);
            dgvCategorias.DefaultCellStyle.SelectionForeColor = Color.White;
            dgvCategorias.BackgroundColor = Color.White;
            dgvCategorias.EnableHeadersVisualStyles = false;
            dgvCategorias.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvCategorias.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(0, 120, 215);
            dgvCategorias.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvCategorias.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            dgvCategorias.DefaultCellStyle.Font = new Font("Segoe UI", 9);
            dgvCategorias.RowTemplate.Height = 28;

            // Estilizar dgvSubcategorias (igual)
            dgvSubcategorias.BorderStyle = BorderStyle.None;
            dgvSubcategorias.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(240, 240, 240);
            dgvSubcategorias.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvSubcategorias.DefaultCellStyle.SelectionBackColor = Color.FromArgb(0, 120, 215);
            dgvSubcategorias.DefaultCellStyle.SelectionForeColor = Color.White;
            dgvSubcategorias.BackgroundColor = Color.White;
            dgvSubcategorias.EnableHeadersVisualStyles = false;
            dgvSubcategorias.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvSubcategorias.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(0, 120, 215);
            dgvSubcategorias.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvSubcategorias.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            dgvSubcategorias.DefaultCellStyle.Font = new Font("Segoe UI", 9);
            dgvSubcategorias.RowTemplate.Height = 28;
        }

        #endregion

        #region Eventos de Botones - Categorías

        private void BTN_AgregarCategoria_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TXT_NombreCategoria.Text))
            {
                MessageBox.Show("Ingrese el nombre de la categoría.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TXT_NombreCategoria.Focus();
                return;
            }

            try
            {
                ModeloCategoria cat = new ModeloCategoria
                {
                    Nombre_Categoria = TXT_NombreCategoria.Text.Trim(),
                    Descripcion = TXT_DescripcionCategoria.Text.Trim(),
                    Activo = CHK_ActivoCategoria.Checked
                };

                if (sentencias.AgregarCategoria(cat))
                {
                    MessageBox.Show("Categoría agregada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarCamposCategoria();
                    MostrarCategorias();
                    CargarCategoriasEnCombo();
                }
                else
                {
                    MessageBox.Show("Error al agregar la categoría.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error:\n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BTN_ModificarCategoria_Click(object sender, EventArgs e)
        {
            if (idSeleccionado == 0 || !modoCategoria)
            {
                MessageBox.Show("Seleccione una categoría de la lista.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(TXT_NombreCategoria.Text))
            {
                MessageBox.Show("Ingrese el nombre de la categoría.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TXT_NombreCategoria.Focus();
                return;
            }

            try
            {
                ModeloCategoria cat = new ModeloCategoria
                {
                    ID_Categoria = idSeleccionado,
                    Nombre_Categoria = TXT_NombreCategoria.Text.Trim(),
                    Descripcion = TXT_DescripcionCategoria.Text.Trim(),
                    Activo = CHK_ActivoCategoria.Checked
                };

                if (sentencias.ModificarCategoria(cat))
                {
                    MessageBox.Show("Categoría modificada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarCamposCategoria();
                    MostrarCategorias();
                    CargarCategoriasEnCombo();
                    idSeleccionado = 0;
                }
                else
                {
                    MessageBox.Show("Error al modificar la categoría.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error:\n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BTN_EliminarCategoria_Click(object sender, EventArgs e)
        {
            if (idSeleccionado == 0 || !modoCategoria)
            {
                MessageBox.Show("Seleccione una categoría de la lista.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult resultado = MessageBox.Show(
                "¿Está seguro que desea eliminar esta categoría?\nEsto también eliminará todas sus subcategorías.",
                "Confirmar Eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                try
                {
                    if (sentencias.EliminarCategoria(idSeleccionado))
                    {
                        MessageBox.Show("Categoría eliminada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LimpiarCamposCategoria();
                        MostrarCategorias();
                        MostrarSubcategorias();
                        CargarCategoriasEnCombo();
                        idSeleccionado = 0;
                    }
                    else
                    {
                        MessageBox.Show("Error al eliminar la categoría.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error:\n{ex.Message}\n\nLa categoría puede tener artículos asociados.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        #endregion

        #region Eventos de Botones - Subcategorías

        private void BTN_AgregarSubcategoria_Click(object sender, EventArgs e)
        {
            if (CMB_Categoria.SelectedValue == null)
            {
                MessageBox.Show("Seleccione una categoría.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                CMB_Categoria.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(TXT_NombreSubcategoria.Text))
            {
                MessageBox.Show("Ingrese el nombre de la subcategoría.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TXT_NombreSubcategoria.Focus();
                return;
            }

            try
            {
                ModeloSubCategoria subcat = new ModeloSubCategoria
                {
                    Nombre_SubCategoria = TXT_NombreSubcategoria.Text.Trim(),
                    ID_Categoria = Convert.ToInt32(CMB_Categoria.SelectedValue),
                    Descripcion = TXT_DescripcionSubcategoria.Text.Trim(),
                    Activo = CHK_ActivoSubcategoria.Checked
                };

                if (sentencias.AgregarSubcategoria(subcat))
                {
                    MessageBox.Show("Subcategoría agregada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarCamposSubcategoria();
                    MostrarSubcategorias();
                }
                else
                {
                    MessageBox.Show("Error al agregar la subcategoría.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error:\n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BTN_ModificarSubcategoria_Click(object sender, EventArgs e)
        {
            if (idSeleccionado == 0 || modoCategoria)
            {
                MessageBox.Show("Seleccione una subcategoría de la lista.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (CMB_Categoria.SelectedValue == null)
            {
                MessageBox.Show("Seleccione una categoría.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                CMB_Categoria.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(TXT_NombreSubcategoria.Text))
            {
                MessageBox.Show("Ingrese el nombre de la subcategoría.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TXT_NombreSubcategoria.Focus();
                return;
            }

            try
            {
                ModeloSubCategoria subcat = new ModeloSubCategoria
                {
                    ID_Subcategoria = idSeleccionado,
                    Nombre_SubCategoria = TXT_NombreSubcategoria.Text.Trim(),
                    ID_Categoria = Convert.ToInt32(CMB_Categoria.SelectedValue),
                    Descripcion = TXT_DescripcionSubcategoria.Text.Trim(),
                    Activo = CHK_ActivoSubcategoria.Checked
                };

                if (sentencias.ModificarSubcategoria(subcat))
                {
                    MessageBox.Show("Subcategoría modificada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarCamposSubcategoria();
                    MostrarSubcategorias();
                    idSeleccionado = 0;
                }
                else
                {
                    MessageBox.Show("Error al modificar la subcategoría.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error:\n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BTN_EliminarSubcategoria_Click(object sender, EventArgs e)
        {
            if (idSeleccionado == 0 || modoCategoria)
            {
                MessageBox.Show("Seleccione una subcategoría de la lista.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult resultado = MessageBox.Show(
                "¿Está seguro que desea eliminar esta subcategoría?",
                "Confirmar Eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                try
                {
                    if (sentencias.EliminarSubcategoria(idSeleccionado))
                    {
                        MessageBox.Show("Subcategoría eliminada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LimpiarCamposSubcategoria();
                        MostrarSubcategorias();
                        idSeleccionado = 0;
                    }
                    else
                    {
                        MessageBox.Show("Error al eliminar la subcategoría.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error:\n{ex.Message}\n\nLa subcategoría puede tener artículos asociados.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        #endregion

        #region Eventos de Grillas

        private void dgvCategorias_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            try
            {
                DataGridViewRow row = dgvCategorias.Rows[e.RowIndex];
                idSeleccionado = Convert.ToInt32(row.Cells["ID_Categoria"].Value);
                modoCategoria = true;

                TXT_NombreCategoria.Text = row.Cells["Nombre_Categoria"].Value.ToString();
                TXT_DescripcionCategoria.Text = row.Cells["Descripcion"].Value?.ToString() ?? "";
                CHK_ActivoCategoria.Checked = Convert.ToBoolean(row.Cells["Activo"].Value);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al seleccionar categoría:\n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvSubcategorias_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            try
            {
                DataGridViewRow row = dgvSubcategorias.Rows[e.RowIndex];
                idSeleccionado = Convert.ToInt32(row.Cells["ID_Subcategoria"].Value);
                modoCategoria = false;

                TXT_NombreSubcategoria.Text = row.Cells["Nombre_SubCategoria"].Value.ToString();
                CMB_Categoria.SelectedValue = Convert.ToInt32(row.Cells["ID_Categoria"].Value);
                TXT_DescripcionSubcategoria.Text = row.Cells["Descripcion"].Value?.ToString() ?? "";
                CHK_ActivoSubcategoria.Checked = Convert.ToBoolean(row.Cells["Activo"].Value);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al seleccionar subcategoría:\n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region Métodos de Limpieza

        private void LimpiarCamposCategoria()
        {
            TXT_NombreCategoria.Clear();
            TXT_DescripcionCategoria.Clear();
            CHK_ActivoCategoria.Checked = true;
            dgvCategorias.ClearSelection();
        }

        private void LimpiarCamposSubcategoria()
        {
            TXT_NombreSubcategoria.Clear();
            CMB_Categoria.SelectedIndex = -1;
            TXT_DescripcionSubcategoria.Clear();
            CHK_ActivoSubcategoria.Checked = true;
            dgvSubcategorias.ClearSelection();
        }

        #endregion

        #region Pestañas

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 0)
            {
                MostrarCategorias();
            }
            else
            {
                MostrarSubcategorias();
                CargarCategoriasEnCombo();
            }
            idSeleccionado = 0;
        }

        #endregion

        private void BTN_LimpiarCategoria_Click(object sender, EventArgs e)
        {
            LimpiarCamposCategoria();
            idSeleccionado = 0;
        }

        private void BTN_LimpiarSubcategoria_Click(object sender, EventArgs e)
        {
            LimpiarCamposSubcategoria();
            idSeleccionado = 0;
        }
    }
}
