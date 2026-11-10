namespace SoftwarePrime.Pantallas.Articulos
{
    partial class FrmArticulos
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
            this.Grilla_Articulos = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.TXT_Costo = new System.Windows.Forms.TextBox();
            this.TXT_Descripcion = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TXT_Codigo = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label10 = new System.Windows.Forms.Label();
            this.TXT_Ganancia = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.CMB_Sub_Categoria = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Numeric_Cantidad = new System.Windows.Forms.NumericUpDown();
            this.CMB_Categoria = new System.Windows.Forms.ComboBox();
            this.TXT_Precio_Venta = new System.Windows.Forms.TextBox();
            this.CMB_Prov = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.LBL_PrecioVenta = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.BTN_Eliminar = new FontAwesome.Sharp.IconButton();
            this.BTN_Modificar = new FontAwesome.Sharp.IconButton();
            this.BTN_Agregar = new FontAwesome.Sharp.IconButton();
            this.BTN_GestionarCategorias = new FontAwesome.Sharp.IconButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.topbar = new System.Windows.Forms.Panel();
            this.Btn_volver = new FontAwesome.Sharp.IconButton();
            this.PanelPrincipal = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.Grilla_Articulos)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Numeric_Cantidad)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.topbar.SuspendLayout();
            this.PanelPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // Grilla_Articulos
            // 
            this.Grilla_Articulos.BackgroundColor = System.Drawing.Color.White;
            this.Grilla_Articulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grilla_Articulos.Location = new System.Drawing.Point(4, 359);
            this.Grilla_Articulos.Name = "Grilla_Articulos";
            this.Grilla_Articulos.ReadOnly = true;
            this.Grilla_Articulos.RowHeadersWidth = 51;
            this.Grilla_Articulos.Size = new System.Drawing.Size(911, 199);
            this.Grilla_Articulos.TabIndex = 2;
            this.Grilla_Articulos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GrillaArticulos);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 251);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(240, 37);
            this.label5.TabIndex = 8;
            this.label5.Text = "Precio de Venta:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TXT_Costo
            // 
            this.TXT_Costo.Dock = System.Windows.Forms.DockStyle.Top;
            this.TXT_Costo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXT_Costo.Location = new System.Drawing.Point(249, 96);
            this.TXT_Costo.Name = "TXT_Costo";
            this.TXT_Costo.Size = new System.Drawing.Size(241, 31);
            this.TXT_Costo.TabIndex = 7;
            this.TXT_Costo.TextChanged += new System.EventHandler(this.TXT_Costo_TextChanged);
            // 
            // TXT_Descripcion
            // 
            this.TXT_Descripcion.Dock = System.Windows.Forms.DockStyle.Top;
            this.TXT_Descripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXT_Descripcion.Location = new System.Drawing.Point(249, 34);
            this.TXT_Descripcion.Name = "TXT_Descripcion";
            this.TXT_Descripcion.Size = new System.Drawing.Size(241, 31);
            this.TXT_Descripcion.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(240, 31);
            this.label4.TabIndex = 6;
            this.label4.Text = "Costo:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(240, 31);
            this.label2.TabIndex = 2;
            this.label2.Text = "Descripción:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(240, 31);
            this.label3.TabIndex = 4;
            this.label3.Text = "Cantidad:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(240, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TXT_Codigo
            // 
            this.TXT_Codigo.Dock = System.Windows.Forms.DockStyle.Top;
            this.TXT_Codigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXT_Codigo.Location = new System.Drawing.Point(249, 3);
            this.TXT_Codigo.Name = "TXT_Codigo";
            this.TXT_Codigo.Size = new System.Drawing.Size(241, 31);
            this.TXT_Codigo.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.label10, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.TXT_Ganancia, 1, 7);
            this.tableLayoutPanel2.Controls.Add(this.label9, 0, 7);
            this.tableLayoutPanel2.Controls.Add(this.CMB_Sub_Categoria, 1, 6);
            this.tableLayoutPanel2.Controls.Add(this.label8, 0, 6);
            this.tableLayoutPanel2.Controls.Add(this.label7, 0, 5);
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.TXT_Codigo, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.TXT_Costo, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.TXT_Descripcion, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.Numeric_Cantidad, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.CMB_Categoria, 1, 5);
            this.tableLayoutPanel2.Controls.Add(this.label5, 0, 8);
            this.tableLayoutPanel2.Controls.Add(this.TXT_Precio_Venta, 1, 8);
            this.tableLayoutPanel2.Controls.Add(this.CMB_Prov, 1, 4);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(21, 26);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 9;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11024F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11024F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11024F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11024F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11024F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11284F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11284F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11283F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11028F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(493, 288);
            this.tableLayoutPanel2.TabIndex = 13;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label10.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(3, 124);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(240, 31);
            this.label10.TabIndex = 25;
            this.label10.Text = "Proveedor:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TXT_Ganancia
            // 
            this.TXT_Ganancia.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXT_Ganancia.Location = new System.Drawing.Point(249, 222);
            this.TXT_Ganancia.Name = "TXT_Ganancia";
            this.TXT_Ganancia.Size = new System.Drawing.Size(241, 31);
            this.TXT_Ganancia.TabIndex = 18;
            this.TXT_Ganancia.TextChanged += new System.EventHandler(this.TXT_Ganancia_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(3, 219);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(240, 32);
            this.label9.TabIndex = 17;
            this.label9.Text = "Ganancia:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CMB_Sub_Categoria
            // 
            this.CMB_Sub_Categoria.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CMB_Sub_Categoria.FormattingEnabled = true;
            this.CMB_Sub_Categoria.Location = new System.Drawing.Point(249, 190);
            this.CMB_Sub_Categoria.Name = "CMB_Sub_Categoria";
            this.CMB_Sub_Categoria.Size = new System.Drawing.Size(241, 27);
            this.CMB_Sub_Categoria.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(3, 187);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(240, 32);
            this.label8.TabIndex = 15;
            this.label8.Text = "Sub Categoria:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(3, 155);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(240, 32);
            this.label7.TabIndex = 12;
            this.label7.Text = "Categoria:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Numeric_Cantidad
            // 
            this.Numeric_Cantidad.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Numeric_Cantidad.Location = new System.Drawing.Point(249, 65);
            this.Numeric_Cantidad.Name = "Numeric_Cantidad";
            this.Numeric_Cantidad.Size = new System.Drawing.Size(241, 27);
            this.Numeric_Cantidad.TabIndex = 10;
            // 
            // CMB_Categoria
            // 
            this.CMB_Categoria.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CMB_Categoria.FormattingEnabled = true;
            this.CMB_Categoria.Location = new System.Drawing.Point(249, 158);
            this.CMB_Categoria.Name = "CMB_Categoria";
            this.CMB_Categoria.Size = new System.Drawing.Size(241, 27);
            this.CMB_Categoria.TabIndex = 14;
            // 
            // TXT_Precio_Venta
            // 
            this.TXT_Precio_Venta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TXT_Precio_Venta.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXT_Precio_Venta.Location = new System.Drawing.Point(249, 254);
            this.TXT_Precio_Venta.Name = "TXT_Precio_Venta";
            this.TXT_Precio_Venta.ReadOnly = true;
            this.TXT_Precio_Venta.Size = new System.Drawing.Size(241, 31);
            this.TXT_Precio_Venta.TabIndex = 13;
            // 
            // CMB_Prov
            // 
            this.CMB_Prov.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CMB_Prov.FormattingEnabled = true;
            this.CMB_Prov.Location = new System.Drawing.Point(249, 127);
            this.CMB_Prov.Name = "CMB_Prov";
            this.CMB_Prov.Size = new System.Drawing.Size(241, 27);
            this.CMB_Prov.TabIndex = 24;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.LBL_PrecioVenta);
            this.groupBox2.Controls.Add(this.tableLayoutPanel1);
            this.groupBox2.Controls.Add(this.tableLayoutPanel2);
            this.groupBox2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(9, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(906, 340);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos del Articulo:";
            // 
            // LBL_PrecioVenta
            // 
            this.LBL_PrecioVenta.AutoSize = true;
            this.LBL_PrecioVenta.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_PrecioVenta.Location = new System.Drawing.Point(616, 194);
            this.LBL_PrecioVenta.Name = "LBL_PrecioVenta";
            this.LBL_PrecioVenta.Size = new System.Drawing.Size(0, 25);
            this.LBL_PrecioVenta.TabIndex = 15;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.BTN_Eliminar, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.BTN_Modificar, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.BTN_Agregar, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.BTN_GestionarCategorias, 0, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(617, 29);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(243, 188);
            this.tableLayoutPanel1.TabIndex = 14;
            // 
            // BTN_Eliminar
            // 
            this.BTN_Eliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(139)))), ((int)(((byte)(245)))));
            this.BTN_Eliminar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BTN_Eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BTN_Eliminar.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Eliminar.ForeColor = System.Drawing.Color.White;
            this.BTN_Eliminar.IconChar = FontAwesome.Sharp.IconChar.Eraser;
            this.BTN_Eliminar.IconColor = System.Drawing.Color.White;
            this.BTN_Eliminar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BTN_Eliminar.IconSize = 34;
            this.BTN_Eliminar.Location = new System.Drawing.Point(3, 97);
            this.BTN_Eliminar.Name = "BTN_Eliminar";
            this.BTN_Eliminar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.BTN_Eliminar.Size = new System.Drawing.Size(237, 41);
            this.BTN_Eliminar.TabIndex = 2;
            this.BTN_Eliminar.Text = "Eliminar";
            this.BTN_Eliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BTN_Eliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BTN_Eliminar.UseVisualStyleBackColor = false;
            this.BTN_Eliminar.Click += new System.EventHandler(this.BTN_Eliminar_Click);
            // 
            // BTN_Modificar
            // 
            this.BTN_Modificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(139)))), ((int)(((byte)(245)))));
            this.BTN_Modificar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BTN_Modificar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BTN_Modificar.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Modificar.ForeColor = System.Drawing.Color.White;
            this.BTN_Modificar.IconChar = FontAwesome.Sharp.IconChar.Edit;
            this.BTN_Modificar.IconColor = System.Drawing.Color.White;
            this.BTN_Modificar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BTN_Modificar.IconSize = 34;
            this.BTN_Modificar.Location = new System.Drawing.Point(3, 50);
            this.BTN_Modificar.Name = "BTN_Modificar";
            this.BTN_Modificar.Size = new System.Drawing.Size(237, 41);
            this.BTN_Modificar.TabIndex = 1;
            this.BTN_Modificar.Text = "Modificar";
            this.BTN_Modificar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BTN_Modificar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BTN_Modificar.UseVisualStyleBackColor = false;
            this.BTN_Modificar.Click += new System.EventHandler(this.BTN_Modificar_Click);
            // 
            // BTN_Agregar
            // 
            this.BTN_Agregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(139)))), ((int)(((byte)(245)))));
            this.BTN_Agregar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BTN_Agregar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BTN_Agregar.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Agregar.ForeColor = System.Drawing.Color.White;
            this.BTN_Agregar.IconChar = FontAwesome.Sharp.IconChar.PersonCirclePlus;
            this.BTN_Agregar.IconColor = System.Drawing.Color.White;
            this.BTN_Agregar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BTN_Agregar.IconSize = 34;
            this.BTN_Agregar.Location = new System.Drawing.Point(3, 3);
            this.BTN_Agregar.Name = "BTN_Agregar";
            this.BTN_Agregar.Size = new System.Drawing.Size(237, 41);
            this.BTN_Agregar.TabIndex = 0;
            this.BTN_Agregar.Text = "Agregar";
            this.BTN_Agregar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BTN_Agregar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BTN_Agregar.UseVisualStyleBackColor = false;
            this.BTN_Agregar.Click += new System.EventHandler(this.BTN_Agregar_Click);
            // 
            // BTN_GestionarCategorias
            // 
            this.BTN_GestionarCategorias.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.BTN_GestionarCategorias.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BTN_GestionarCategorias.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BTN_GestionarCategorias.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_GestionarCategorias.ForeColor = System.Drawing.Color.White;
            this.BTN_GestionarCategorias.IconChar = FontAwesome.Sharp.IconChar.Tags;
            this.BTN_GestionarCategorias.IconColor = System.Drawing.Color.White;
            this.BTN_GestionarCategorias.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BTN_GestionarCategorias.IconSize = 30;
            this.BTN_GestionarCategorias.Location = new System.Drawing.Point(3, 144);
            this.BTN_GestionarCategorias.Name = "BTN_GestionarCategorias";
            this.BTN_GestionarCategorias.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.BTN_GestionarCategorias.Size = new System.Drawing.Size(237, 41);
            this.BTN_GestionarCategorias.TabIndex = 3;
            this.BTN_GestionarCategorias.Text = "Categorías";
            this.BTN_GestionarCategorias.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BTN_GestionarCategorias.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BTN_GestionarCategorias.UseVisualStyleBackColor = false;
            this.BTN_GestionarCategorias.Click += new System.EventHandler(this.BTN_GestionarCategorias_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.groupBox2);
            this.panel3.Controls.Add(this.Grilla_Articulos);
            this.panel3.Location = new System.Drawing.Point(0, 47);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(919, 561);
            this.panel3.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(322, 7);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(226, 29);
            this.label6.TabIndex = 15;
            this.label6.Text = "Módulo de Articulos";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.topbar);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Location = new System.Drawing.Point(-1, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(919, 610);
            this.panel1.TabIndex = 0;
            // 
            // topbar
            // 
            this.topbar.BackColor = System.Drawing.Color.DodgerBlue;
            this.topbar.Controls.Add(this.Btn_volver);
            this.topbar.Controls.Add(this.label6);
            this.topbar.Dock = System.Windows.Forms.DockStyle.Top;
            this.topbar.Location = new System.Drawing.Point(0, 0);
            this.topbar.Name = "topbar";
            this.topbar.Size = new System.Drawing.Size(919, 47);
            this.topbar.TabIndex = 20;
            // 
            // Btn_volver
            // 
            this.Btn_volver.FlatAppearance.BorderSize = 0;
            this.Btn_volver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_volver.Flip = FontAwesome.Sharp.FlipOrientation.Horizontal;
            this.Btn_volver.IconChar = FontAwesome.Sharp.IconChar.Share;
            this.Btn_volver.IconColor = System.Drawing.Color.Black;
            this.Btn_volver.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.Btn_volver.IconSize = 32;
            this.Btn_volver.Location = new System.Drawing.Point(3, 3);
            this.Btn_volver.Name = "Btn_volver";
            this.Btn_volver.Size = new System.Drawing.Size(45, 39);
            this.Btn_volver.TabIndex = 19;
            this.Btn_volver.UseVisualStyleBackColor = true;
            // 
            // PanelPrincipal
            // 
            this.PanelPrincipal.BackColor = System.Drawing.Color.White;
            this.PanelPrincipal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanelPrincipal.Controls.Add(this.panel1);
            this.PanelPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelPrincipal.Location = new System.Drawing.Point(0, 0);
            this.PanelPrincipal.Margin = new System.Windows.Forms.Padding(2);
            this.PanelPrincipal.Name = "PanelPrincipal";
            this.PanelPrincipal.Size = new System.Drawing.Size(919, 610);
            this.PanelPrincipal.TabIndex = 7;
            // 
            // FrmArticulos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(919, 610);
            this.Controls.Add(this.PanelPrincipal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmArticulos";
            this.Text = "FormArticulos";
            ((System.ComponentModel.ISupportInitialize)(this.Grilla_Articulos)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Numeric_Cantidad)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.topbar.ResumeLayout(false);
            this.topbar.PerformLayout();
            this.PanelPrincipal.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView Grilla_Articulos;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TXT_Costo;
        private System.Windows.Forms.TextBox TXT_Descripcion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TXT_Codigo;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel panel3;
        private FontAwesome.Sharp.IconButton Btn_volver;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel topbar;
        private System.Windows.Forms.Panel PanelPrincipal;
        private System.Windows.Forms.NumericUpDown Numeric_Cantidad;
        private System.Windows.Forms.TextBox TXT_Precio_Venta;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TXT_Ganancia;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox CMB_Sub_Categoria;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox CMB_Categoria;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private FontAwesome.Sharp.IconButton BTN_Eliminar;
        private FontAwesome.Sharp.IconButton BTN_Modificar;
        private FontAwesome.Sharp.IconButton BTN_Agregar;
        private FontAwesome.Sharp.IconButton BTN_GestionarCategorias;
        private System.Windows.Forms.Label LBL_PrecioVenta;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox CMB_Prov;
    }
}