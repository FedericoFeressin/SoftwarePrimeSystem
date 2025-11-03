namespace SoftwarePrime.Pantallas
{
    partial class FrmVentas
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
            this.PanelPrincipal = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.topbar = new System.Windows.Forms.Panel();
            this.Btn_volver = new FontAwesome.Sharp.IconButton();
            this.label6 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgv_Ventas = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.BTN_Eliminar_Venta = new System.Windows.Forms.Button();
            this.BTN_Guardar_Venta = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.TXT_Cantidad = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.TXT_Precio_Unitario = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.TXT_Descripcion = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TXT_Cod_Art = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dgv_Detalle = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.TXT_Total = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TXT_Descuento = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TXT_SubTotal = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CMB_Clientes = new System.Windows.Forms.ComboBox();
            this.DT_Fecha = new System.Windows.Forms.DateTimePicker();
            this.BTN_Agregar_Art = new System.Windows.Forms.Button();
            this.PanelPrincipal.SuspendLayout();
            this.panel1.SuspendLayout();
            this.topbar.SuspendLayout();
            this.panel3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Ventas)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Detalle)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelPrincipal
            // 
            this.PanelPrincipal.BackColor = System.Drawing.Color.White;
            this.PanelPrincipal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanelPrincipal.Controls.Add(this.panel1);
            this.PanelPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelPrincipal.Location = new System.Drawing.Point(0, 0);
            this.PanelPrincipal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PanelPrincipal.Name = "PanelPrincipal";
            this.PanelPrincipal.Size = new System.Drawing.Size(1225, 751);
            this.PanelPrincipal.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.topbar);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Location = new System.Drawing.Point(-1, -1);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1225, 751);
            this.panel1.TabIndex = 0;
            // 
            // topbar
            // 
            this.topbar.BackColor = System.Drawing.Color.DodgerBlue;
            this.topbar.Controls.Add(this.Btn_volver);
            this.topbar.Controls.Add(this.label6);
            this.topbar.Dock = System.Windows.Forms.DockStyle.Top;
            this.topbar.Location = new System.Drawing.Point(0, 0);
            this.topbar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.topbar.Name = "topbar";
            this.topbar.Size = new System.Drawing.Size(1225, 58);
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
            this.Btn_volver.Location = new System.Drawing.Point(4, 4);
            this.Btn_volver.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Btn_volver.Name = "Btn_volver";
            this.Btn_volver.Size = new System.Drawing.Size(60, 48);
            this.Btn_volver.TabIndex = 19;
            this.Btn_volver.UseVisualStyleBackColor = true;
            this.Btn_volver.Click += new System.EventHandler(this.Btn_volver_Click);
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(459, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(260, 36);
            this.label6.TabIndex = 15;
            this.label6.Text = "Gestión de Ventas";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Controls.Add(this.groupBox2);
            this.panel3.Location = new System.Drawing.Point(0, 58);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1225, 693);
            this.panel3.TabIndex = 3;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgv_Ventas);
            this.groupBox2.Controls.Add(this.tableLayoutPanel3);
            this.groupBox2.Controls.Add(this.groupBox1);
            this.groupBox2.Controls.Add(this.dgv_Detalle);
            this.groupBox2.Controls.Add(this.tableLayoutPanel2);
            this.groupBox2.Controls.Add(this.BTN_Agregar_Art);
            this.groupBox2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(13, 7);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(1199, 672);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos de la venta:";
            // 
            // dgv_Ventas
            // 
            this.dgv_Ventas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Ventas.Location = new System.Drawing.Point(8, 441);
            this.dgv_Ventas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv_Ventas.Name = "dgv_Ventas";
            this.dgv_Ventas.RowHeadersWidth = 51;
            this.dgv_Ventas.RowTemplate.Height = 24;
            this.dgv_Ventas.Size = new System.Drawing.Size(1184, 126);
            this.dgv_Ventas.TabIndex = 21;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.BTN_Eliminar_Venta, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.BTN_Guardar_Venta, 0, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(727, 591);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(464, 66);
            this.tableLayoutPanel3.TabIndex = 20;
            // 
            // BTN_Eliminar_Venta
            // 
            this.BTN_Eliminar_Venta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(139)))), ((int)(((byte)(245)))));
            this.BTN_Eliminar_Venta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BTN_Eliminar_Venta.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Eliminar_Venta.ForeColor = System.Drawing.Color.White;
            this.BTN_Eliminar_Venta.Location = new System.Drawing.Point(235, 2);
            this.BTN_Eliminar_Venta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BTN_Eliminar_Venta.Name = "BTN_Eliminar_Venta";
            this.BTN_Eliminar_Venta.Size = new System.Drawing.Size(226, 62);
            this.BTN_Eliminar_Venta.TabIndex = 7;
            this.BTN_Eliminar_Venta.Text = "Cancelar Venta";
            this.BTN_Eliminar_Venta.UseVisualStyleBackColor = false;
            // 
            // BTN_Guardar_Venta
            // 
            this.BTN_Guardar_Venta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(139)))), ((int)(((byte)(245)))));
            this.BTN_Guardar_Venta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BTN_Guardar_Venta.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Guardar_Venta.ForeColor = System.Drawing.Color.White;
            this.BTN_Guardar_Venta.Location = new System.Drawing.Point(3, 2);
            this.BTN_Guardar_Venta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BTN_Guardar_Venta.Name = "BTN_Guardar_Venta";
            this.BTN_Guardar_Venta.Size = new System.Drawing.Size(226, 62);
            this.BTN_Guardar_Venta.TabIndex = 6;
            this.BTN_Guardar_Venta.Text = "Guardar Venta";
            this.BTN_Guardar_Venta.UseVisualStyleBackColor = false;
            this.BTN_Guardar_Venta.Click += new System.EventHandler(this.BTN_Guardar_Venta_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tableLayoutPanel1);
            this.groupBox1.Location = new System.Drawing.Point(493, 21);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(476, 268);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Detalle del articulo:";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.TXT_Cantidad, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label10, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.TXT_Precio_Unitario, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label8, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.TXT_Descripcion, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label7, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.TXT_Cod_Art, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(5, 26);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(464, 236);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // TXT_Cantidad
            // 
            this.TXT_Cantidad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TXT_Cantidad.BackColor = System.Drawing.SystemColors.Menu;
            this.TXT_Cantidad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TXT_Cantidad.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXT_Cantidad.Location = new System.Drawing.Point(235, 189);
            this.TXT_Cantidad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TXT_Cantidad.Name = "TXT_Cantidad";
            this.TXT_Cantidad.Size = new System.Drawing.Size(226, 34);
            this.TXT_Cantidad.TabIndex = 12;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label10.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(3, 177);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(226, 59);
            this.label10.TabIndex = 11;
            this.label10.Text = "Cantidad:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TXT_Precio_Unitario
            // 
            this.TXT_Precio_Unitario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TXT_Precio_Unitario.BackColor = System.Drawing.SystemColors.Menu;
            this.TXT_Precio_Unitario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TXT_Precio_Unitario.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXT_Precio_Unitario.Location = new System.Drawing.Point(235, 130);
            this.TXT_Precio_Unitario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TXT_Precio_Unitario.Name = "TXT_Precio_Unitario";
            this.TXT_Precio_Unitario.Size = new System.Drawing.Size(226, 34);
            this.TXT_Precio_Unitario.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(3, 118);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(226, 59);
            this.label8.TabIndex = 9;
            this.label8.Text = "Precio Unitario:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TXT_Descripcion
            // 
            this.TXT_Descripcion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TXT_Descripcion.BackColor = System.Drawing.SystemColors.Menu;
            this.TXT_Descripcion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TXT_Descripcion.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXT_Descripcion.Location = new System.Drawing.Point(235, 71);
            this.TXT_Descripcion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TXT_Descripcion.Name = "TXT_Descripcion";
            this.TXT_Descripcion.Size = new System.Drawing.Size(226, 34);
            this.TXT_Descripcion.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(3, 59);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(226, 59);
            this.label7.TabIndex = 7;
            this.label7.Text = "Descripción:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TXT_Cod_Art
            // 
            this.TXT_Cod_Art.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TXT_Cod_Art.BackColor = System.Drawing.SystemColors.Menu;
            this.TXT_Cod_Art.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TXT_Cod_Art.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXT_Cod_Art.Location = new System.Drawing.Point(235, 12);
            this.TXT_Cod_Art.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TXT_Cod_Art.Name = "TXT_Cod_Art";
            this.TXT_Cod_Art.Size = new System.Drawing.Size(226, 34);
            this.TXT_Cod_Art.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(226, 59);
            this.label5.TabIndex = 1;
            this.label5.Text = "Código Articulo:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dgv_Detalle
            // 
            this.dgv_Detalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Detalle.Location = new System.Drawing.Point(7, 295);
            this.dgv_Detalle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv_Detalle.Name = "dgv_Detalle";
            this.dgv_Detalle.RowHeadersWidth = 51;
            this.dgv_Detalle.RowTemplate.Height = 24;
            this.dgv_Detalle.Size = new System.Drawing.Size(1184, 126);
            this.dgv_Detalle.TabIndex = 18;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37.49941F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 62.50059F));
            this.tableLayoutPanel2.Controls.Add(this.TXT_Total, 1, 4);
            this.tableLayoutPanel2.Controls.Add(this.label4, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.TXT_Descuento, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.label3, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.TXT_SubTotal, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.label9, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.CMB_Clientes, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.DT_Fecha, 1, 1);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(8, 33);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 5;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0008F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0008F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0008F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.9988F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.9988F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(479, 256);
            this.tableLayoutPanel2.TabIndex = 13;
            // 
            // TXT_Total
            // 
            this.TXT_Total.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TXT_Total.BackColor = System.Drawing.SystemColors.Menu;
            this.TXT_Total.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TXT_Total.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXT_Total.Location = new System.Drawing.Point(182, 213);
            this.TXT_Total.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TXT_Total.Name = "TXT_Total";
            this.TXT_Total.ReadOnly = true;
            this.TXT_Total.Size = new System.Drawing.Size(294, 34);
            this.TXT_Total.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 204);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(173, 52);
            this.label4.TabIndex = 8;
            this.label4.Text = "Total:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TXT_Descuento
            // 
            this.TXT_Descuento.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TXT_Descuento.BackColor = System.Drawing.SystemColors.Menu;
            this.TXT_Descuento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TXT_Descuento.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXT_Descuento.Location = new System.Drawing.Point(182, 161);
            this.TXT_Descuento.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TXT_Descuento.Name = "TXT_Descuento";
            this.TXT_Descuento.Size = new System.Drawing.Size(294, 34);
            this.TXT_Descuento.TabIndex = 7;
            this.TXT_Descuento.TextChanged += new System.EventHandler(this.TXT_Descuento_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(173, 51);
            this.label3.TabIndex = 6;
            this.label3.Text = "Descuento:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TXT_SubTotal
            // 
            this.TXT_SubTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TXT_SubTotal.BackColor = System.Drawing.SystemColors.Menu;
            this.TXT_SubTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TXT_SubTotal.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXT_SubTotal.Location = new System.Drawing.Point(182, 110);
            this.TXT_SubTotal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TXT_SubTotal.Name = "TXT_SubTotal";
            this.TXT_SubTotal.ReadOnly = true;
            this.TXT_SubTotal.Size = new System.Drawing.Size(294, 34);
            this.TXT_SubTotal.TabIndex = 5;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(3, 102);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(173, 51);
            this.label9.TabIndex = 4;
            this.label9.Text = "SubTotal:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(173, 51);
            this.label2.TabIndex = 2;
            this.label2.Text = "Fecha:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 51);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cliente:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // CMB_Clientes
            // 
            this.CMB_Clientes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.CMB_Clientes.BackColor = System.Drawing.SystemColors.Menu;
            this.CMB_Clientes.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CMB_Clientes.FormattingEnabled = true;
            this.CMB_Clientes.Location = new System.Drawing.Point(182, 7);
            this.CMB_Clientes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CMB_Clientes.Name = "CMB_Clientes";
            this.CMB_Clientes.Size = new System.Drawing.Size(294, 36);
            this.CMB_Clientes.TabIndex = 1;
            // 
            // DT_Fecha
            // 
            this.DT_Fecha.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DT_Fecha.Location = new System.Drawing.Point(182, 53);
            this.DT_Fecha.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DT_Fecha.Name = "DT_Fecha";
            this.DT_Fecha.Size = new System.Drawing.Size(294, 32);
            this.DT_Fecha.TabIndex = 3;
            // 
            // BTN_Agregar_Art
            // 
            this.BTN_Agregar_Art.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(139)))), ((int)(((byte)(245)))));
            this.BTN_Agregar_Art.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Agregar_Art.ForeColor = System.Drawing.Color.White;
            this.BTN_Agregar_Art.Location = new System.Drawing.Point(976, 47);
            this.BTN_Agregar_Art.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BTN_Agregar_Art.Name = "BTN_Agregar_Art";
            this.BTN_Agregar_Art.Size = new System.Drawing.Size(204, 69);
            this.BTN_Agregar_Art.TabIndex = 5;
            this.BTN_Agregar_Art.Text = "Agregar Articulo";
            this.BTN_Agregar_Art.UseVisualStyleBackColor = false;
            this.BTN_Agregar_Art.Click += new System.EventHandler(this.BTN_Agregar_Art_Click);
            // 
            // FrmVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1225, 751);
            this.Controls.Add(this.PanelPrincipal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmVentas";
            this.Text = "FrmVentas";
            this.Load += new System.EventHandler(this.FrmVentas_Load);
            this.PanelPrincipal.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.topbar.ResumeLayout(false);
            this.topbar.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Ventas)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Detalle)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelPrincipal;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel topbar;
        private FontAwesome.Sharp.IconButton Btn_volver;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CMB_Clientes;
        private System.Windows.Forms.DateTimePicker DT_Fecha;
        private System.Windows.Forms.Button BTN_Agregar_Art;
        private System.Windows.Forms.DataGridView dgv_Detalle;
        private System.Windows.Forms.TextBox TXT_SubTotal;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox TXT_Total;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TXT_Descuento;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TXT_Cod_Art;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button BTN_Eliminar_Venta;
        private System.Windows.Forms.Button BTN_Guardar_Venta;
        private System.Windows.Forms.TextBox TXT_Cantidad;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox TXT_Precio_Unitario;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TXT_Descripcion;
        private System.Windows.Forms.DataGridView dgv_Ventas;
    }
}