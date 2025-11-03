namespace SoftwarePrime.Pantallas.Compras
{
    partial class UcCompras
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_Proveedores = new FontAwesome.Sharp.IconButton();
            this.Btn_volver = new FontAwesome.Sharp.IconButton();
            this.label6 = new System.Windows.Forms.Label();
            this.TXT_ID_Remito = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.TXT_total = new System.Windows.Forms.TextBox();
            this.cmb_Usuarios = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TXT_descuento = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TXT_subtotal = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmb_Proveedores = new System.Windows.Forms.ComboBox();
            this.dtm_Fechayhora = new System.Windows.Forms.DateTimePicker();
            this.BTN_Modificar = new System.Windows.Forms.Button();
            this.BTN_Agregar = new System.Windows.Forms.Button();
            this.dgv_compras = new System.Windows.Forms.DataGridView();
            this.PanelPrincipal = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.topbar = new System.Windows.Forms.Panel();
            this.panel_vista_compra = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.BTN_Calcular_Total = new System.Windows.Forms.Button();
            this.BTN_BajaLogica = new System.Windows.Forms.Button();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_compras)).BeginInit();
            this.PanelPrincipal.SuspendLayout();
            this.panel1.SuspendLayout();
            this.topbar.SuspendLayout();
            this.panel_vista_compra.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Proveedores
            // 
            this.btn_Proveedores.FlatAppearance.BorderSize = 0;
            this.btn_Proveedores.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btn_Proveedores.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Proveedores.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Proveedores.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_Proveedores.IconChar = FontAwesome.Sharp.IconChar.TruckFront;
            this.btn_Proveedores.IconColor = System.Drawing.Color.White;
            this.btn_Proveedores.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_Proveedores.IconSize = 32;
            this.btn_Proveedores.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Proveedores.Location = new System.Drawing.Point(752, 3);
            this.btn_Proveedores.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Proveedores.Name = "btn_Proveedores";
            this.btn_Proveedores.Size = new System.Drawing.Size(165, 41);
            this.btn_Proveedores.TabIndex = 20;
            this.btn_Proveedores.Text = "Proveedores";
            this.btn_Proveedores.UseVisualStyleBackColor = true;
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
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(344, 13);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(234, 29);
            this.label6.TabIndex = 15;
            this.label6.Text = "Gestión de Compras";
            // 
            // TXT_ID_Remito
            // 
            this.TXT_ID_Remito.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TXT_ID_Remito.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXT_ID_Remito.Location = new System.Drawing.Point(221, 195);
            this.TXT_ID_Remito.Name = "TXT_ID_Remito";
            this.TXT_ID_Remito.ReadOnly = true;
            this.TXT_ID_Remito.Size = new System.Drawing.Size(213, 31);
            this.TXT_ID_Remito.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(3, 192);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(212, 37);
            this.label8.TabIndex = 17;
            this.label8.Text = "ID_Remito";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.TXT_ID_Remito, 1, 6);
            this.tableLayoutPanel2.Controls.Add(this.label8, 0, 6);
            this.tableLayoutPanel2.Controls.Add(this.TXT_total, 1, 5);
            this.tableLayoutPanel2.Controls.Add(this.cmb_Usuarios, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.label7, 0, 5);
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.TXT_descuento, 1, 4);
            this.tableLayoutPanel2.Controls.Add(this.label5, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.TXT_subtotal, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.cmb_Proveedores, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.dtm_Fechayhora, 1, 2);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(6, 26);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 7;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(437, 229);
            this.tableLayoutPanel2.TabIndex = 13;
            // 
            // TXT_total
            // 
            this.TXT_total.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TXT_total.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXT_total.Location = new System.Drawing.Point(221, 163);
            this.TXT_total.Name = "TXT_total";
            this.TXT_total.ReadOnly = true;
            this.TXT_total.Size = new System.Drawing.Size(213, 31);
            this.TXT_total.TabIndex = 16;
            // 
            // cmb_Usuarios
            // 
            this.cmb_Usuarios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmb_Usuarios.FormattingEnabled = true;
            this.cmb_Usuarios.Location = new System.Drawing.Point(221, 35);
            this.cmb_Usuarios.Name = "cmb_Usuarios";
            this.cmb_Usuarios.Size = new System.Drawing.Size(213, 27);
            this.cmb_Usuarios.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(3, 160);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(212, 32);
            this.label7.TabIndex = 11;
            this.label7.Text = "Total:";
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Proveedor:";
            // 
            // TXT_descuento
            // 
            this.TXT_descuento.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TXT_descuento.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXT_descuento.Location = new System.Drawing.Point(221, 131);
            this.TXT_descuento.Name = "TXT_descuento";
            this.TXT_descuento.Size = new System.Drawing.Size(213, 31);
            this.TXT_descuento.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(212, 32);
            this.label5.TabIndex = 8;
            this.label5.Text = "Descuento:";
            // 
            // TXT_subtotal
            // 
            this.TXT_subtotal.Dock = System.Windows.Forms.DockStyle.Top;
            this.TXT_subtotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXT_subtotal.Location = new System.Drawing.Point(221, 99);
            this.TXT_subtotal.Name = "TXT_subtotal";
            this.TXT_subtotal.Size = new System.Drawing.Size(213, 31);
            this.TXT_subtotal.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(212, 32);
            this.label4.TabIndex = 6;
            this.label4.Text = "Subtotal:";
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(212, 31);
            this.label2.TabIndex = 2;
            this.label2.Text = "Usuario:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(212, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "Fecha y hora:";
            // 
            // cmb_Proveedores
            // 
            this.cmb_Proveedores.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmb_Proveedores.FormattingEnabled = true;
            this.cmb_Proveedores.Location = new System.Drawing.Point(221, 3);
            this.cmb_Proveedores.Name = "cmb_Proveedores";
            this.cmb_Proveedores.Size = new System.Drawing.Size(213, 27);
            this.cmb_Proveedores.TabIndex = 13;
            // 
            // dtm_Fechayhora
            // 
            this.dtm_Fechayhora.Location = new System.Drawing.Point(221, 67);
            this.dtm_Fechayhora.Name = "dtm_Fechayhora";
            this.dtm_Fechayhora.Size = new System.Drawing.Size(213, 27);
            this.dtm_Fechayhora.TabIndex = 15;
            // 
            // BTN_Modificar
            // 
            this.BTN_Modificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.BTN_Modificar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BTN_Modificar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Modificar.Location = new System.Drawing.Point(113, 3);
            this.BTN_Modificar.Name = "BTN_Modificar";
            this.BTN_Modificar.Size = new System.Drawing.Size(104, 45);
            this.BTN_Modificar.TabIndex = 2;
            this.BTN_Modificar.Text = "Modificar";
            this.BTN_Modificar.UseVisualStyleBackColor = false;
            // 
            // BTN_Agregar
            // 
            this.BTN_Agregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.BTN_Agregar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BTN_Agregar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Agregar.Location = new System.Drawing.Point(3, 3);
            this.BTN_Agregar.Name = "BTN_Agregar";
            this.BTN_Agregar.Size = new System.Drawing.Size(104, 45);
            this.BTN_Agregar.TabIndex = 1;
            this.BTN_Agregar.Text = "Agregar";
            this.BTN_Agregar.UseVisualStyleBackColor = false;
            // 
            // dgv_compras
            // 
            this.dgv_compras.BackgroundColor = System.Drawing.Color.White;
            this.dgv_compras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_compras.Location = new System.Drawing.Point(7, 6);
            this.dgv_compras.Name = "dgv_compras";
            this.dgv_compras.ReadOnly = true;
            this.dgv_compras.RowHeadersWidth = 51;
            this.dgv_compras.Size = new System.Drawing.Size(906, 282);
            this.dgv_compras.TabIndex = 19;
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
            this.PanelPrincipal.Size = new System.Drawing.Size(920, 610);
            this.PanelPrincipal.TabIndex = 7;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.topbar);
            this.panel1.Controls.Add(this.panel_vista_compra);
            this.panel1.Location = new System.Drawing.Point(-1, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(919, 610);
            this.panel1.TabIndex = 0;
            // 
            // topbar
            // 
            this.topbar.BackColor = System.Drawing.Color.DodgerBlue;
            this.topbar.Controls.Add(this.btn_Proveedores);
            this.topbar.Controls.Add(this.Btn_volver);
            this.topbar.Controls.Add(this.label6);
            this.topbar.Dock = System.Windows.Forms.DockStyle.Top;
            this.topbar.Location = new System.Drawing.Point(0, 0);
            this.topbar.Name = "topbar";
            this.topbar.Size = new System.Drawing.Size(919, 47);
            this.topbar.TabIndex = 20;
            // 
            // panel_vista_compra
            // 
            this.panel_vista_compra.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel_vista_compra.Controls.Add(this.dgv_compras);
            this.panel_vista_compra.Controls.Add(this.groupBox2);
            this.panel_vista_compra.Location = new System.Drawing.Point(0, 47);
            this.panel_vista_compra.Margin = new System.Windows.Forms.Padding(2);
            this.panel_vista_compra.Name = "panel_vista_compra";
            this.panel_vista_compra.Size = new System.Drawing.Size(919, 561);
            this.panel_vista_compra.TabIndex = 3;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tableLayoutPanel1);
            this.groupBox2.Controls.Add(this.tableLayoutPanel2);
            this.groupBox2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(7, 294);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(909, 259);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos de la Compra:";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.BTN_Calcular_Total, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.BTN_BajaLogica, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.BTN_Modificar, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.BTN_Agregar, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(460, 202);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(440, 51);
            this.tableLayoutPanel1.TabIndex = 16;
            // 
            // BTN_Calcular_Total
            // 
            this.BTN_Calcular_Total.BackColor = System.Drawing.Color.White;
            this.BTN_Calcular_Total.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BTN_Calcular_Total.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Calcular_Total.Location = new System.Drawing.Point(333, 3);
            this.BTN_Calcular_Total.Name = "BTN_Calcular_Total";
            this.BTN_Calcular_Total.Size = new System.Drawing.Size(104, 45);
            this.BTN_Calcular_Total.TabIndex = 4;
            this.BTN_Calcular_Total.Text = "Calcular\r\n";
            this.BTN_Calcular_Total.UseVisualStyleBackColor = false;
            // 
            // BTN_BajaLogica
            // 
            this.BTN_BajaLogica.BackColor = System.Drawing.Color.Red;
            this.BTN_BajaLogica.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BTN_BajaLogica.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_BajaLogica.Location = new System.Drawing.Point(223, 3);
            this.BTN_BajaLogica.Name = "BTN_BajaLogica";
            this.BTN_BajaLogica.Size = new System.Drawing.Size(104, 45);
            this.BTN_BajaLogica.TabIndex = 3;
            this.BTN_BajaLogica.Text = "Baja ";
            this.BTN_BajaLogica.UseVisualStyleBackColor = false;
            // 
            // UcCompras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.PanelPrincipal);
            this.Name = "UcCompras";
            this.Size = new System.Drawing.Size(920, 610);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_compras)).EndInit();
            this.PanelPrincipal.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.topbar.ResumeLayout(false);
            this.topbar.PerformLayout();
            this.panel_vista_compra.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private FontAwesome.Sharp.IconButton btn_Proveedores;
        private FontAwesome.Sharp.IconButton Btn_volver;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TXT_ID_Remito;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TextBox TXT_total;
        private System.Windows.Forms.ComboBox cmb_Usuarios;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TXT_descuento;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TXT_subtotal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmb_Proveedores;
        private System.Windows.Forms.DateTimePicker dtm_Fechayhora;
        private System.Windows.Forms.Button BTN_Modificar;
        private System.Windows.Forms.Button BTN_Agregar;
        private System.Windows.Forms.DataGridView dgv_compras;
        private System.Windows.Forms.Panel PanelPrincipal;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel topbar;
        private System.Windows.Forms.Panel panel_vista_compra;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button BTN_Calcular_Total;
        private System.Windows.Forms.Button BTN_BajaLogica;
    }
}
