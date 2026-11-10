namespace SoftwarePrime.Pantallas.EstadoContable
{
    partial class FrmEstadoContable
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
            this.label6 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.Grilla_Bitacora = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label13 = new System.Windows.Forms.Label();
            this.LBL_Saldo = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.LBL_CantComprasVarias = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.LBL_CantVentas = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.LBL_CantCompras = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.LBL_ValorStock = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.LBL_EgresosVarios = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.LBL_Egresos = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.LBL_Ingresos = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.DT_FechaHasta = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.DT_FechaDesde = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.CMB_Usuario = new System.Windows.Forms.ComboBox();
            this.CHK_TodosUsuarios = new System.Windows.Forms.CheckBox();
            this.BTN_Consultar = new FontAwesome.Sharp.IconButton();
            this.BTN_ExportarPDF = new FontAwesome.Sharp.IconButton();
            this.PanelPrincipal.SuspendLayout();
            this.panel1.SuspendLayout();
            this.topbar.SuspendLayout();
            this.panel3.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grilla_Bitacora)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
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
            this.PanelPrincipal.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.topbar);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Location = new System.Drawing.Point(-1, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(919, 610);
            this.panel1.TabIndex = 1;
            // 
            // topbar
            // 
            this.topbar.BackColor = System.Drawing.Color.DodgerBlue;
            this.topbar.Controls.Add(this.label6);
            this.topbar.Dock = System.Windows.Forms.DockStyle.Top;
            this.topbar.Location = new System.Drawing.Point(0, 0);
            this.topbar.Name = "topbar";
            this.topbar.Size = new System.Drawing.Size(919, 47);
            this.topbar.TabIndex = 21;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(322, 9);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(286, 29);
            this.label6.TabIndex = 15;
            this.label6.Text = "Módulo Estado Contable";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.groupBox3);
            this.panel3.Controls.Add(this.groupBox2);
            this.panel3.Controls.Add(this.groupBox1);
            this.panel3.Location = new System.Drawing.Point(0, 47);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(919, 561);
            this.panel3.TabIndex = 4;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.Grilla_Bitacora);
            this.groupBox3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(9, 310);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(906, 245);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Bitácora de Movimientos:";
            // 
            // Grilla_Bitacora
            // 
            this.Grilla_Bitacora.AllowUserToAddRows = false;
            this.Grilla_Bitacora.AllowUserToDeleteRows = false;
            this.Grilla_Bitacora.BackgroundColor = System.Drawing.Color.White;
            this.Grilla_Bitacora.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grilla_Bitacora.Location = new System.Drawing.Point(12, 26);
            this.Grilla_Bitacora.Name = "Grilla_Bitacora";
            this.Grilla_Bitacora.ReadOnly = true;
            this.Grilla_Bitacora.Size = new System.Drawing.Size(882, 207);
            this.Grilla_Bitacora.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tableLayoutPanel2);
            this.groupBox2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(9, 119);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(906, 185);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Resumen Contable:";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.Controls.Add(this.label13, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.LBL_Saldo, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.label11, 2, 2);
            this.tableLayoutPanel2.Controls.Add(this.LBL_CantComprasVarias, 3, 2);
            this.tableLayoutPanel2.Controls.Add(this.label9, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.LBL_CantVentas, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.label7, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.LBL_CantCompras, 3, 1);
            this.tableLayoutPanel2.Controls.Add(this.label5, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.LBL_ValorStock, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.label3, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.LBL_EgresosVarios, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.LBL_Egresos, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.label14, 2, 3);
            this.tableLayoutPanel2.Controls.Add(this.LBL_Ingresos, 3, 3);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(12, 29);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(882, 144);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label13.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.label13.Location = new System.Drawing.Point(3, 108);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(214, 36);
            this.label13.TabIndex = 14;
            this.label13.Text = "Saldo Total:";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LBL_Saldo
            // 
            this.LBL_Saldo.AutoSize = true;
            this.LBL_Saldo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LBL_Saldo.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.LBL_Saldo.ForeColor = System.Drawing.Color.Green;
            this.LBL_Saldo.Location = new System.Drawing.Point(223, 108);
            this.LBL_Saldo.Name = "LBL_Saldo";
            this.LBL_Saldo.Size = new System.Drawing.Size(214, 36);
            this.LBL_Saldo.TabIndex = 15;
            this.LBL_Saldo.Text = "$0.00";
            this.LBL_Saldo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label11.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.label11.Location = new System.Drawing.Point(443, 72);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(214, 36);
            this.label11.TabIndex = 12;
            this.label11.Text = "Cant. Compras Varias:";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LBL_CantComprasVarias
            // 
            this.LBL_CantComprasVarias.AutoSize = true;
            this.LBL_CantComprasVarias.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LBL_CantComprasVarias.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.LBL_CantComprasVarias.Location = new System.Drawing.Point(663, 72);
            this.LBL_CantComprasVarias.Name = "LBL_CantComprasVarias";
            this.LBL_CantComprasVarias.Size = new System.Drawing.Size(216, 36);
            this.LBL_CantComprasVarias.TabIndex = 13;
            this.LBL_CantComprasVarias.Text = "0";
            this.LBL_CantComprasVarias.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(3, 72);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(214, 36);
            this.label9.TabIndex = 10;
            this.label9.Text = "Cant. Ventas:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LBL_CantVentas
            // 
            this.LBL_CantVentas.AutoSize = true;
            this.LBL_CantVentas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LBL_CantVentas.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.LBL_CantVentas.Location = new System.Drawing.Point(223, 72);
            this.LBL_CantVentas.Name = "LBL_CantVentas";
            this.LBL_CantVentas.Size = new System.Drawing.Size(214, 36);
            this.LBL_CantVentas.TabIndex = 11;
            this.LBL_CantVentas.Text = "0";
            this.LBL_CantVentas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(443, 36);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(214, 36);
            this.label7.TabIndex = 8;
            this.label7.Text = "Cant. Compras Insumos:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LBL_CantCompras
            // 
            this.LBL_CantCompras.AutoSize = true;
            this.LBL_CantCompras.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LBL_CantCompras.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.LBL_CantCompras.Location = new System.Drawing.Point(663, 36);
            this.LBL_CantCompras.Name = "LBL_CantCompras";
            this.LBL_CantCompras.Size = new System.Drawing.Size(216, 36);
            this.LBL_CantCompras.TabIndex = 9;
            this.LBL_CantCompras.Text = "0";
            this.LBL_CantCompras.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(3, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(214, 36);
            this.label5.TabIndex = 6;
            this.label5.Text = "Valor Stock Actual:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LBL_ValorStock
            // 
            this.LBL_ValorStock.AutoSize = true;
            this.LBL_ValorStock.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LBL_ValorStock.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.LBL_ValorStock.Location = new System.Drawing.Point(223, 36);
            this.LBL_ValorStock.Name = "LBL_ValorStock";
            this.LBL_ValorStock.Size = new System.Drawing.Size(214, 36);
            this.LBL_ValorStock.TabIndex = 7;
            this.LBL_ValorStock.Text = "$0.00";
            this.LBL_ValorStock.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(443, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(214, 36);
            this.label3.TabIndex = 4;
            this.label3.Text = "Egresos Compras Varias:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LBL_EgresosVarios
            // 
            this.LBL_EgresosVarios.AutoSize = true;
            this.LBL_EgresosVarios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LBL_EgresosVarios.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.LBL_EgresosVarios.ForeColor = System.Drawing.Color.Red;
            this.LBL_EgresosVarios.Location = new System.Drawing.Point(663, 0);
            this.LBL_EgresosVarios.Name = "LBL_EgresosVarios";
            this.LBL_EgresosVarios.Size = new System.Drawing.Size(216, 36);
            this.LBL_EgresosVarios.TabIndex = 5;
            this.LBL_EgresosVarios.Text = "$0.00";
            this.LBL_EgresosVarios.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 36);
            this.label1.TabIndex = 2;
            this.label1.Text = "Egresos por Compras:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LBL_Egresos
            // 
            this.LBL_Egresos.AutoSize = true;
            this.LBL_Egresos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LBL_Egresos.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.LBL_Egresos.ForeColor = System.Drawing.Color.Red;
            this.LBL_Egresos.Location = new System.Drawing.Point(223, 0);
            this.LBL_Egresos.Name = "LBL_Egresos";
            this.LBL_Egresos.Size = new System.Drawing.Size(214, 36);
            this.LBL_Egresos.TabIndex = 3;
            this.LBL_Egresos.Text = "$0.00";
            this.LBL_Egresos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label14.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.label14.Location = new System.Drawing.Point(443, 108);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(214, 36);
            this.label14.TabIndex = 16;
            this.label14.Text = "Ingresos por Ventas:";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LBL_Ingresos
            // 
            this.LBL_Ingresos.AutoSize = true;
            this.LBL_Ingresos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LBL_Ingresos.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.LBL_Ingresos.ForeColor = System.Drawing.Color.Green;
            this.LBL_Ingresos.Location = new System.Drawing.Point(663, 108);
            this.LBL_Ingresos.Name = "LBL_Ingresos";
            this.LBL_Ingresos.Size = new System.Drawing.Size(216, 36);
            this.LBL_Ingresos.TabIndex = 17;
            this.LBL_Ingresos.Text = "$0.00";
            this.LBL_Ingresos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tableLayoutPanel1);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(9, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(906, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtros:";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 6;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.label4, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.DT_FechaHasta, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.DT_FechaDesde, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label10, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.CMB_Usuario, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.CHK_TodosUsuarios, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.BTN_Consultar, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.BTN_ExportarPDF, 5, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 26);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(882, 62);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(288, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 31);
            this.label4.TabIndex = 3;
            this.label4.Text = "Hasta:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // DT_FechaHasta
            // 
            this.DT_FechaHasta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DT_FechaHasta.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.DT_FechaHasta.Location = new System.Drawing.Point(388, 3);
            this.DT_FechaHasta.Name = "DT_FechaHasta";
            this.DT_FechaHasta.Size = new System.Drawing.Size(159, 25);
            this.DT_FechaHasta.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 31);
            this.label2.TabIndex = 0;
            this.label2.Text = "Desde:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // DT_FechaDesde
            // 
            this.DT_FechaDesde.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DT_FechaDesde.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.DT_FechaDesde.Location = new System.Drawing.Point(123, 3);
            this.DT_FechaDesde.Name = "DT_FechaDesde";
            this.DT_FechaDesde.Size = new System.Drawing.Size(159, 25);
            this.DT_FechaDesde.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label10.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.label10.Location = new System.Drawing.Point(3, 31);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(114, 31);
            this.label10.TabIndex = 4;
            this.label10.Text = "Usuario:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // CMB_Usuario
            // 
            this.CMB_Usuario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CMB_Usuario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CMB_Usuario.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.CMB_Usuario.FormattingEnabled = true;
            this.CMB_Usuario.Location = new System.Drawing.Point(123, 34);
            this.CMB_Usuario.Name = "CMB_Usuario";
            this.CMB_Usuario.Size = new System.Drawing.Size(159, 25);
            this.CMB_Usuario.TabIndex = 5;
            // 
            // CHK_TodosUsuarios
            // 
            this.CHK_TodosUsuarios.AutoSize = true;
            this.CHK_TodosUsuarios.Checked = true;
            this.CHK_TodosUsuarios.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CHK_TodosUsuarios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CHK_TodosUsuarios.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.CHK_TodosUsuarios.Location = new System.Drawing.Point(288, 34);
            this.CHK_TodosUsuarios.Name = "CHK_TodosUsuarios";
            this.CHK_TodosUsuarios.Size = new System.Drawing.Size(94, 25);
            this.CHK_TodosUsuarios.TabIndex = 6;
            this.CHK_TodosUsuarios.Text = "Todos";
            this.CHK_TodosUsuarios.UseVisualStyleBackColor = true;
            this.CHK_TodosUsuarios.CheckedChanged += new System.EventHandler(this.CHK_TodosUsuarios_CheckedChanged);
            // 
            // BTN_Consultar
            // 
            this.BTN_Consultar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(139)))), ((int)(((byte)(245)))));
            this.BTN_Consultar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BTN_Consultar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BTN_Consultar.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.BTN_Consultar.ForeColor = System.Drawing.Color.White;
            this.BTN_Consultar.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.BTN_Consultar.IconColor = System.Drawing.Color.White;
            this.BTN_Consultar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BTN_Consultar.IconSize = 28;
            this.BTN_Consultar.Location = new System.Drawing.Point(553, 3);
            this.BTN_Consultar.Name = "BTN_Consultar";
            this.tableLayoutPanel1.SetRowSpan(this.BTN_Consultar, 2);
            this.BTN_Consultar.Size = new System.Drawing.Size(159, 56);
            this.BTN_Consultar.TabIndex = 7;
            this.BTN_Consultar.Text = "Consultar";
            this.BTN_Consultar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BTN_Consultar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BTN_Consultar.UseVisualStyleBackColor = false;
            this.BTN_Consultar.Click += new System.EventHandler(this.BTN_Consultar_Click);
            // 
            // BTN_ExportarPDF
            // 
            this.BTN_ExportarPDF.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.BTN_ExportarPDF.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BTN_ExportarPDF.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BTN_ExportarPDF.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.BTN_ExportarPDF.ForeColor = System.Drawing.Color.White;
            this.BTN_ExportarPDF.IconChar = FontAwesome.Sharp.IconChar.FilePdf;
            this.BTN_ExportarPDF.IconColor = System.Drawing.Color.White;
            this.BTN_ExportarPDF.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BTN_ExportarPDF.IconSize = 28;
            this.BTN_ExportarPDF.Location = new System.Drawing.Point(718, 3);
            this.BTN_ExportarPDF.Name = "BTN_ExportarPDF";
            this.tableLayoutPanel1.SetRowSpan(this.BTN_ExportarPDF, 2);
            this.BTN_ExportarPDF.Size = new System.Drawing.Size(161, 56);
            this.BTN_ExportarPDF.TabIndex = 8;
            this.BTN_ExportarPDF.Text = "Exportar PDF";
            this.BTN_ExportarPDF.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BTN_ExportarPDF.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BTN_ExportarPDF.UseVisualStyleBackColor = false;
            this.BTN_ExportarPDF.Click += new System.EventHandler(this.BTN_ExportarPDF_Click);
            // 
            // FrmEstadoContable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(919, 610);
            this.Controls.Add(this.PanelPrincipal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmEstadoContable";
            this.Text = "Estado Contable";
            this.PanelPrincipal.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.topbar.ResumeLayout(false);
            this.topbar.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Grilla_Bitacora)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelPrincipal;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel topbar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker DT_FechaDesde;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker DT_FechaHasta;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox CMB_Usuario;
        private System.Windows.Forms.CheckBox CHK_TodosUsuarios;
        private FontAwesome.Sharp.IconButton BTN_Consultar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LBL_Egresos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label LBL_EgresosVarios;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label LBL_ValorStock;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label LBL_CantCompras;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label LBL_CantVentas;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label LBL_CantComprasVarias;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label LBL_Saldo;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView Grilla_Bitacora;
        private FontAwesome.Sharp.IconButton BTN_ExportarPDF;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label LBL_Ingresos;
    }
}
