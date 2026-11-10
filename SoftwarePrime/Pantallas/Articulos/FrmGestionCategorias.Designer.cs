namespace SoftwarePrime.Pantallas.Articulos
{
    partial class FrmGestionCategorias
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageCategorias = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BTN_AgregarCategoria = new System.Windows.Forms.Button();
            this.BTN_ModificarCategoria = new System.Windows.Forms.Button();
            this.BTN_EliminarCategoria = new System.Windows.Forms.Button();
            this.BTN_LimpiarCategoria = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.TXT_NombreCategoria = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TXT_DescripcionCategoria = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvCategorias = new System.Windows.Forms.DataGridView();
            this.CHK_ActivoCategoria = new System.Windows.Forms.CheckBox();
            this.tabPageSubcategorias = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.BTN_AgregarSubcategoria = new System.Windows.Forms.Button();
            this.BTN_ModificarSubcategoria = new System.Windows.Forms.Button();
            this.BTN_EliminarSubcategoria = new System.Windows.Forms.Button();
            this.BTN_LimpiarSubcategoria = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.TXT_NombreSubcategoria = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.CMB_Categoria = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TXT_DescripcionSubcategoria = new System.Windows.Forms.TextBox();
            this.CHK_ActivoSubcategoria = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgvSubcategorias = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.tabControl1.SuspendLayout();
            this.tabPageCategorias.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategorias)).BeginInit();
            this.tabPageSubcategorias.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSubcategorias)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageCategorias);
            this.tabControl1.Controls.Add(this.tabPageSubcategorias);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(10, 10);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(899, 590);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPageCategorias
            // 
            this.tabPageCategorias.Controls.Add(this.groupBox2);
            this.tabPageCategorias.Controls.Add(this.groupBox1);
            this.tabPageCategorias.Location = new System.Drawing.Point(4, 26);
            this.tabPageCategorias.Name = "tabPageCategorias";
            this.tabPageCategorias.Padding = new System.Windows.Forms.Padding(10);
            this.tabPageCategorias.Size = new System.Drawing.Size(891, 560);
            this.tabPageCategorias.TabIndex = 0;
            this.tabPageCategorias.Text = "Categorías";
            this.tabPageCategorias.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tableLayoutPanel3);
            this.groupBox2.Controls.Add(this.CHK_ActivoCategoria);
            this.groupBox2.Controls.Add(this.tableLayoutPanel1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.groupBox2.Location = new System.Drawing.Point(10, 264);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(10);
            this.groupBox2.Size = new System.Drawing.Size(871, 286);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos de Categoría";
            // 
            // BTN_AgregarCategoria
            // 
            this.BTN_AgregarCategoria.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(139)))), ((int)(((byte)(245)))));
            this.BTN_AgregarCategoria.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BTN_AgregarCategoria.FlatAppearance.BorderSize = 0;
            this.BTN_AgregarCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_AgregarCategoria.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_AgregarCategoria.ForeColor = System.Drawing.Color.White;
            this.BTN_AgregarCategoria.Location = new System.Drawing.Point(5, 5);
            this.BTN_AgregarCategoria.Margin = new System.Windows.Forms.Padding(5);
            this.BTN_AgregarCategoria.Name = "BTN_AgregarCategoria";
            this.BTN_AgregarCategoria.Size = new System.Drawing.Size(176, 47);
            this.BTN_AgregarCategoria.TabIndex = 0;
            this.BTN_AgregarCategoria.Text = "Agregar";
            this.BTN_AgregarCategoria.UseVisualStyleBackColor = false;
            this.BTN_AgregarCategoria.Click += new System.EventHandler(this.BTN_AgregarCategoria_Click);
            // 
            // BTN_ModificarCategoria
            // 
            this.BTN_ModificarCategoria.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(139)))), ((int)(((byte)(245)))));
            this.BTN_ModificarCategoria.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BTN_ModificarCategoria.FlatAppearance.BorderSize = 0;
            this.BTN_ModificarCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_ModificarCategoria.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_ModificarCategoria.ForeColor = System.Drawing.Color.White;
            this.BTN_ModificarCategoria.Location = new System.Drawing.Point(191, 5);
            this.BTN_ModificarCategoria.Margin = new System.Windows.Forms.Padding(5);
            this.BTN_ModificarCategoria.Name = "BTN_ModificarCategoria";
            this.BTN_ModificarCategoria.Size = new System.Drawing.Size(176, 47);
            this.BTN_ModificarCategoria.TabIndex = 1;
            this.BTN_ModificarCategoria.Text = "Modificar";
            this.BTN_ModificarCategoria.UseVisualStyleBackColor = false;
            this.BTN_ModificarCategoria.Click += new System.EventHandler(this.BTN_ModificarCategoria_Click);
            // 
            // BTN_EliminarCategoria
            // 
            this.BTN_EliminarCategoria.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.BTN_EliminarCategoria.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BTN_EliminarCategoria.FlatAppearance.BorderSize = 0;
            this.BTN_EliminarCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_EliminarCategoria.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_EliminarCategoria.ForeColor = System.Drawing.Color.White;
            this.BTN_EliminarCategoria.Location = new System.Drawing.Point(377, 5);
            this.BTN_EliminarCategoria.Margin = new System.Windows.Forms.Padding(5);
            this.BTN_EliminarCategoria.Name = "BTN_EliminarCategoria";
            this.BTN_EliminarCategoria.Size = new System.Drawing.Size(176, 47);
            this.BTN_EliminarCategoria.TabIndex = 2;
            this.BTN_EliminarCategoria.Text = "Eliminar";
            this.BTN_EliminarCategoria.UseVisualStyleBackColor = false;
            this.BTN_EliminarCategoria.Click += new System.EventHandler(this.BTN_EliminarCategoria_Click);
            // 
            // BTN_LimpiarCategoria
            // 
            this.BTN_LimpiarCategoria.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.BTN_LimpiarCategoria.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BTN_LimpiarCategoria.FlatAppearance.BorderSize = 0;
            this.BTN_LimpiarCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_LimpiarCategoria.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_LimpiarCategoria.ForeColor = System.Drawing.Color.White;
            this.BTN_LimpiarCategoria.Location = new System.Drawing.Point(563, 5);
            this.BTN_LimpiarCategoria.Margin = new System.Windows.Forms.Padding(5);
            this.BTN_LimpiarCategoria.Name = "BTN_LimpiarCategoria";
            this.BTN_LimpiarCategoria.Size = new System.Drawing.Size(179, 47);
            this.BTN_LimpiarCategoria.TabIndex = 3;
            this.BTN_LimpiarCategoria.Text = "Limpiar";
            this.BTN_LimpiarCategoria.UseVisualStyleBackColor = false;
            this.BTN_LimpiarCategoria.Click += new System.EventHandler(this.BTN_LimpiarCategoria_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.TXT_NombreCategoria, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.TXT_DescripcionCategoria, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(10, 31);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(832, 116);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(410, 58);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre de Categoría:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TXT_NombreCategoria
            // 
            this.TXT_NombreCategoria.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TXT_NombreCategoria.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXT_NombreCategoria.Location = new System.Drawing.Point(419, 14);
            this.TXT_NombreCategoria.MaxLength = 100;
            this.TXT_NombreCategoria.Name = "TXT_NombreCategoria";
            this.TXT_NombreCategoria.Size = new System.Drawing.Size(410, 29);
            this.TXT_NombreCategoria.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(410, 58);
            this.label2.TabIndex = 2;
            this.label2.Text = "Descripción:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TXT_DescripcionCategoria
            // 
            this.TXT_DescripcionCategoria.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TXT_DescripcionCategoria.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXT_DescripcionCategoria.Location = new System.Drawing.Point(419, 72);
            this.TXT_DescripcionCategoria.MaxLength = 255;
            this.TXT_DescripcionCategoria.Name = "TXT_DescripcionCategoria";
            this.TXT_DescripcionCategoria.Size = new System.Drawing.Size(410, 29);
            this.TXT_DescripcionCategoria.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvCategorias);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(10, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(10);
            this.groupBox1.Size = new System.Drawing.Size(871, 540);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lista de Categorías";
            // 
            // dgvCategorias
            // 
            this.dgvCategorias.AllowUserToAddRows = false;
            this.dgvCategorias.AllowUserToDeleteRows = false;
            this.dgvCategorias.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCategorias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCategorias.Location = new System.Drawing.Point(10, 31);
            this.dgvCategorias.MultiSelect = false;
            this.dgvCategorias.Name = "dgvCategorias";
            this.dgvCategorias.ReadOnly = true;
            this.dgvCategorias.RowHeadersVisible = false;
            this.dgvCategorias.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCategorias.Size = new System.Drawing.Size(851, 217);
            this.dgvCategorias.TabIndex = 0;
            this.dgvCategorias.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCategorias_CellClick);
            // 
            // CHK_ActivoCategoria
            // 
            this.CHK_ActivoCategoria.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.CHK_ActivoCategoria.AutoSize = true;
            this.CHK_ActivoCategoria.Checked = true;
            this.CHK_ActivoCategoria.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CHK_ActivoCategoria.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.CHK_ActivoCategoria.Location = new System.Drawing.Point(796, 165);
            this.CHK_ActivoCategoria.Name = "CHK_ActivoCategoria";
            this.CHK_ActivoCategoria.Size = new System.Drawing.Size(62, 21);
            this.CHK_ActivoCategoria.TabIndex = 4;
            this.CHK_ActivoCategoria.Text = "Activo";
            this.CHK_ActivoCategoria.UseVisualStyleBackColor = true;
            // 
            // tabPageSubcategorias
            // 
            this.tabPageSubcategorias.Controls.Add(this.groupBox4);
            this.tabPageSubcategorias.Controls.Add(this.groupBox3);
            this.tabPageSubcategorias.Location = new System.Drawing.Point(4, 26);
            this.tabPageSubcategorias.Name = "tabPageSubcategorias";
            this.tabPageSubcategorias.Padding = new System.Windows.Forms.Padding(10);
            this.tabPageSubcategorias.Size = new System.Drawing.Size(891, 560);
            this.tabPageSubcategorias.TabIndex = 1;
            this.tabPageSubcategorias.Text = "Subcategorías";
            this.tabPageSubcategorias.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.tableLayoutPanel4);
            this.groupBox4.Controls.Add(this.CHK_ActivoSubcategoria);
            this.groupBox4.Controls.Add(this.tableLayoutPanel2);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.groupBox4.Location = new System.Drawing.Point(10, 280);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(10);
            this.groupBox4.Size = new System.Drawing.Size(871, 270);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Datos de Subcategoría";
            // 
            // BTN_AgregarSubcategoria
            // 
            this.BTN_AgregarSubcategoria.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(139)))), ((int)(((byte)(245)))));
            this.BTN_AgregarSubcategoria.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BTN_AgregarSubcategoria.FlatAppearance.BorderSize = 0;
            this.BTN_AgregarSubcategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_AgregarSubcategoria.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_AgregarSubcategoria.ForeColor = System.Drawing.Color.White;
            this.BTN_AgregarSubcategoria.Location = new System.Drawing.Point(5, 5);
            this.BTN_AgregarSubcategoria.Margin = new System.Windows.Forms.Padding(5);
            this.BTN_AgregarSubcategoria.Name = "BTN_AgregarSubcategoria";
            this.BTN_AgregarSubcategoria.Size = new System.Drawing.Size(176, 47);
            this.BTN_AgregarSubcategoria.TabIndex = 0;
            this.BTN_AgregarSubcategoria.Text = "Agregar";
            this.BTN_AgregarSubcategoria.UseVisualStyleBackColor = false;
            this.BTN_AgregarSubcategoria.Click += new System.EventHandler(this.BTN_AgregarSubcategoria_Click);
            // 
            // BTN_ModificarSubcategoria
            // 
            this.BTN_ModificarSubcategoria.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(139)))), ((int)(((byte)(245)))));
            this.BTN_ModificarSubcategoria.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BTN_ModificarSubcategoria.FlatAppearance.BorderSize = 0;
            this.BTN_ModificarSubcategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_ModificarSubcategoria.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_ModificarSubcategoria.ForeColor = System.Drawing.Color.White;
            this.BTN_ModificarSubcategoria.Location = new System.Drawing.Point(191, 5);
            this.BTN_ModificarSubcategoria.Margin = new System.Windows.Forms.Padding(5);
            this.BTN_ModificarSubcategoria.Name = "BTN_ModificarSubcategoria";
            this.BTN_ModificarSubcategoria.Size = new System.Drawing.Size(176, 47);
            this.BTN_ModificarSubcategoria.TabIndex = 1;
            this.BTN_ModificarSubcategoria.Text = "Modificar";
            this.BTN_ModificarSubcategoria.UseVisualStyleBackColor = false;
            this.BTN_ModificarSubcategoria.Click += new System.EventHandler(this.BTN_ModificarSubcategoria_Click);
            // 
            // BTN_EliminarSubcategoria
            // 
            this.BTN_EliminarSubcategoria.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.BTN_EliminarSubcategoria.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BTN_EliminarSubcategoria.FlatAppearance.BorderSize = 0;
            this.BTN_EliminarSubcategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_EliminarSubcategoria.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_EliminarSubcategoria.ForeColor = System.Drawing.Color.White;
            this.BTN_EliminarSubcategoria.Location = new System.Drawing.Point(377, 5);
            this.BTN_EliminarSubcategoria.Margin = new System.Windows.Forms.Padding(5);
            this.BTN_EliminarSubcategoria.Name = "BTN_EliminarSubcategoria";
            this.BTN_EliminarSubcategoria.Size = new System.Drawing.Size(176, 47);
            this.BTN_EliminarSubcategoria.TabIndex = 2;
            this.BTN_EliminarSubcategoria.Text = "Eliminar";
            this.BTN_EliminarSubcategoria.UseVisualStyleBackColor = false;
            this.BTN_EliminarSubcategoria.Click += new System.EventHandler(this.BTN_EliminarSubcategoria_Click);
            // 
            // BTN_LimpiarSubcategoria
            // 
            this.BTN_LimpiarSubcategoria.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.BTN_LimpiarSubcategoria.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BTN_LimpiarSubcategoria.FlatAppearance.BorderSize = 0;
            this.BTN_LimpiarSubcategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_LimpiarSubcategoria.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_LimpiarSubcategoria.ForeColor = System.Drawing.Color.White;
            this.BTN_LimpiarSubcategoria.Location = new System.Drawing.Point(563, 5);
            this.BTN_LimpiarSubcategoria.Margin = new System.Windows.Forms.Padding(5);
            this.BTN_LimpiarSubcategoria.Name = "BTN_LimpiarSubcategoria";
            this.BTN_LimpiarSubcategoria.Size = new System.Drawing.Size(179, 47);
            this.BTN_LimpiarSubcategoria.TabIndex = 3;
            this.BTN_LimpiarSubcategoria.Text = "Limpiar";
            this.BTN_LimpiarSubcategoria.UseVisualStyleBackColor = false;
            this.BTN_LimpiarSubcategoria.Click += new System.EventHandler(this.BTN_LimpiarSubcategoria_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.TXT_NombreSubcategoria, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.label4, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.CMB_Categoria, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.label5, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.TXT_DescripcionSubcategoria, 1, 2);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(13, 31);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(832, 128);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(410, 42);
            this.label3.TabIndex = 0;
            this.label3.Text = "Nombre de Subcategoría:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TXT_NombreSubcategoria
            // 
            this.TXT_NombreSubcategoria.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TXT_NombreSubcategoria.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXT_NombreSubcategoria.Location = new System.Drawing.Point(419, 6);
            this.TXT_NombreSubcategoria.MaxLength = 100;
            this.TXT_NombreSubcategoria.Name = "TXT_NombreSubcategoria";
            this.TXT_NombreSubcategoria.Size = new System.Drawing.Size(410, 29);
            this.TXT_NombreSubcategoria.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(410, 42);
            this.label4.TabIndex = 2;
            this.label4.Text = "Categoría:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CMB_Categoria
            // 
            this.CMB_Categoria.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.CMB_Categoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CMB_Categoria.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CMB_Categoria.FormattingEnabled = true;
            this.CMB_Categoria.Location = new System.Drawing.Point(419, 50);
            this.CMB_Categoria.Name = "CMB_Categoria";
            this.CMB_Categoria.Size = new System.Drawing.Size(410, 29);
            this.CMB_Categoria.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(410, 44);
            this.label5.TabIndex = 4;
            this.label5.Text = "Descripción:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TXT_DescripcionSubcategoria
            // 
            this.TXT_DescripcionSubcategoria.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TXT_DescripcionSubcategoria.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXT_DescripcionSubcategoria.Location = new System.Drawing.Point(419, 91);
            this.TXT_DescripcionSubcategoria.MaxLength = 255;
            this.TXT_DescripcionSubcategoria.Name = "TXT_DescripcionSubcategoria";
            this.TXT_DescripcionSubcategoria.Size = new System.Drawing.Size(410, 29);
            this.TXT_DescripcionSubcategoria.TabIndex = 5;
            // 
            // CHK_ActivoSubcategoria
            // 
            this.CHK_ActivoSubcategoria.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.CHK_ActivoSubcategoria.AutoSize = true;
            this.CHK_ActivoSubcategoria.Checked = true;
            this.CHK_ActivoSubcategoria.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CHK_ActivoSubcategoria.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.CHK_ActivoSubcategoria.Location = new System.Drawing.Point(796, 174);
            this.CHK_ActivoSubcategoria.Name = "CHK_ActivoSubcategoria";
            this.CHK_ActivoSubcategoria.Size = new System.Drawing.Size(62, 21);
            this.CHK_ActivoSubcategoria.TabIndex = 6;
            this.CHK_ActivoSubcategoria.Text = "Activo";
            this.CHK_ActivoSubcategoria.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgvSubcategorias);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.groupBox3.Location = new System.Drawing.Point(10, 10);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(10);
            this.groupBox3.Size = new System.Drawing.Size(871, 540);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Lista de Subcategorías";
            // 
            // dgvSubcategorias
            // 
            this.dgvSubcategorias.AllowUserToAddRows = false;
            this.dgvSubcategorias.AllowUserToDeleteRows = false;
            this.dgvSubcategorias.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSubcategorias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSubcategorias.Location = new System.Drawing.Point(20, 22);
            this.dgvSubcategorias.MultiSelect = false;
            this.dgvSubcategorias.Name = "dgvSubcategorias";
            this.dgvSubcategorias.ReadOnly = true;
            this.dgvSubcategorias.RowHeadersVisible = false;
            this.dgvSubcategorias.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSubcategorias.Size = new System.Drawing.Size(832, 242);
            this.dgvSubcategorias.TabIndex = 0;
            this.dgvSubcategorias.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSubcategorias_CellClick);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 4;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.Controls.Add(this.BTN_LimpiarCategoria, 3, 0);
            this.tableLayoutPanel3.Controls.Add(this.BTN_EliminarCategoria, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.BTN_ModificarCategoria, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.BTN_AgregarCategoria, 0, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(61, 201);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(747, 57);
            this.tableLayoutPanel3.TabIndex = 2;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 4;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel4.Controls.Add(this.BTN_LimpiarSubcategoria, 3, 0);
            this.tableLayoutPanel4.Controls.Add(this.BTN_EliminarSubcategoria, 2, 0);
            this.tableLayoutPanel4.Controls.Add(this.BTN_ModificarSubcategoria, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.BTN_AgregarSubcategoria, 0, 0);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(61, 201);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(747, 57);
            this.tableLayoutPanel4.TabIndex = 2;
            // 
            // FrmGestionCategorias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(919, 610);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmGestionCategorias";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Gestión de Categorías y Subcategorías";
            this.tabControl1.ResumeLayout(false);
            this.tabPageCategorias.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategorias)).EndInit();
            this.tabPageSubcategorias.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSubcategorias)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageCategorias;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button BTN_AgregarCategoria;
        private System.Windows.Forms.Button BTN_ModificarCategoria;
        private System.Windows.Forms.Button BTN_EliminarCategoria;
        private System.Windows.Forms.Button BTN_LimpiarCategoria;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TXT_NombreCategoria;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TXT_DescripcionCategoria;
        private System.Windows.Forms.CheckBox CHK_ActivoCategoria;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvCategorias;
        private System.Windows.Forms.TabPage tabPageSubcategorias;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button BTN_AgregarSubcategoria;
        private System.Windows.Forms.Button BTN_ModificarSubcategoria;
        private System.Windows.Forms.Button BTN_EliminarSubcategoria;
        private System.Windows.Forms.Button BTN_LimpiarSubcategoria;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TXT_NombreSubcategoria;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox CMB_Categoria;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TXT_DescripcionSubcategoria;
        private System.Windows.Forms.CheckBox CHK_ActivoSubcategoria;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgvSubcategorias;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
    }
}
