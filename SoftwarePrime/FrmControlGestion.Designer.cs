namespace SoftwarePrime
{
    partial class FrmControlGestion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmControlGestion));
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.panelSlideBar = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.Btn_Desconectar = new FontAwesome.Sharp.IconButton();
            this.Btn_Proveedores = new FontAwesome.Sharp.IconButton();
            this.Btn_EstadoContable = new FontAwesome.Sharp.IconButton();
            this.Btn_RRHH = new FontAwesome.Sharp.IconButton();
            this.Btn_Usuarios = new FontAwesome.Sharp.IconButton();
            this.Btn_Ventas = new FontAwesome.Sharp.IconButton();
            this.Btn_Compras = new FontAwesome.Sharp.IconButton();
            this.BTN_Clientes = new FontAwesome.Sharp.IconButton();
            this.panelTopBar = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.Btn_Minimizar = new FontAwesome.Sharp.IconButton();
            this.Btn_Cerrar = new FontAwesome.Sharp.IconButton();
            this.label1 = new System.Windows.Forms.Label();
            this.PanelVista = new System.Windows.Forms.Panel();
            this.panelContenedor.SuspendLayout();
            this.panelSlideBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.panelTopBar.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelContenedor
            // 
            this.panelContenedor.BackColor = System.Drawing.Color.White;
            this.panelContenedor.Controls.Add(this.panelSlideBar);
            this.panelContenedor.Controls.Add(this.panelTopBar);
            this.panelContenedor.Controls.Add(this.PanelVista);
            this.panelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenedor.Location = new System.Drawing.Point(0, 0);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(1172, 661);
            this.panelContenedor.TabIndex = 3;
            // 
            // panelSlideBar
            // 
            this.panelSlideBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(18)))), ((int)(((byte)(120)))));
            this.panelSlideBar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelSlideBar.Controls.Add(this.pictureBox1);
            this.panelSlideBar.Controls.Add(this.tableLayoutPanel1);
            this.panelSlideBar.Location = new System.Drawing.Point(0, 0);
            this.panelSlideBar.Name = "panelSlideBar";
            this.panelSlideBar.Size = new System.Drawing.Size(254, 661);
            this.panelSlideBar.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::SoftwarePrime.Properties.Resources.Logo_Prime;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(28, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(194, 124);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.Btn_Desconectar, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.Btn_Proveedores, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.Btn_EstadoContable, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.Btn_RRHH, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.Btn_Usuarios, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.Btn_Ventas, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.Btn_Compras, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.BTN_Clientes, 0, 0);
            this.tableLayoutPanel1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 201);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 8;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(235, 387);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // Btn_Desconectar
            // 
            this.Btn_Desconectar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Btn_Desconectar.FlatAppearance.BorderSize = 0;
            this.Btn_Desconectar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.Btn_Desconectar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Desconectar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Desconectar.ForeColor = System.Drawing.Color.White;
            this.Btn_Desconectar.IconChar = FontAwesome.Sharp.IconChar.SignOut;
            this.Btn_Desconectar.IconColor = System.Drawing.Color.White;
            this.Btn_Desconectar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Btn_Desconectar.IconSize = 32;
            this.Btn_Desconectar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Desconectar.Location = new System.Drawing.Point(2, 338);
            this.Btn_Desconectar.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_Desconectar.Name = "Btn_Desconectar";
            this.Btn_Desconectar.Size = new System.Drawing.Size(231, 47);
            this.Btn_Desconectar.TabIndex = 15;
            this.Btn_Desconectar.Text = "Desconectar";
            this.Btn_Desconectar.UseVisualStyleBackColor = true;
            this.Btn_Desconectar.Click += new System.EventHandler(this.Btn_Desconectar_Click);
            // 
            // Btn_Proveedores
            // 
            this.Btn_Proveedores.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Btn_Proveedores.FlatAppearance.BorderSize = 0;
            this.Btn_Proveedores.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.Btn_Proveedores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Proveedores.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Proveedores.ForeColor = System.Drawing.Color.White;
            this.Btn_Proveedores.IconChar = FontAwesome.Sharp.IconChar.TruckFront;
            this.Btn_Proveedores.IconColor = System.Drawing.Color.White;
            this.Btn_Proveedores.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Btn_Proveedores.IconSize = 32;
            this.Btn_Proveedores.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Proveedores.Location = new System.Drawing.Point(2, 290);
            this.Btn_Proveedores.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_Proveedores.Name = "Btn_Proveedores";
            this.Btn_Proveedores.Size = new System.Drawing.Size(231, 44);
            this.Btn_Proveedores.TabIndex = 14;
            this.Btn_Proveedores.Text = "Proveedores";
            this.Btn_Proveedores.UseVisualStyleBackColor = true;
            this.Btn_Proveedores.Click += new System.EventHandler(this.btn_Proveedores_Click);
            // 
            // Btn_EstadoContable
            // 
            this.Btn_EstadoContable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Btn_EstadoContable.FlatAppearance.BorderSize = 0;
            this.Btn_EstadoContable.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.Btn_EstadoContable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_EstadoContable.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_EstadoContable.ForeColor = System.Drawing.Color.White;
            this.Btn_EstadoContable.IconChar = FontAwesome.Sharp.IconChar.ScaleBalanced;
            this.Btn_EstadoContable.IconColor = System.Drawing.Color.White;
            this.Btn_EstadoContable.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Btn_EstadoContable.IconSize = 32;
            this.Btn_EstadoContable.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_EstadoContable.Location = new System.Drawing.Point(2, 242);
            this.Btn_EstadoContable.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_EstadoContable.Name = "Btn_EstadoContable";
            this.Btn_EstadoContable.Size = new System.Drawing.Size(231, 44);
            this.Btn_EstadoContable.TabIndex = 13;
            this.Btn_EstadoContable.Text = "   Estado Contable";
            this.Btn_EstadoContable.UseVisualStyleBackColor = true;
            this.Btn_EstadoContable.Click += new System.EventHandler(this.btn_Estado_Contable_Click);
            // 
            // Btn_RRHH
            // 
            this.Btn_RRHH.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Btn_RRHH.FlatAppearance.BorderSize = 0;
            this.Btn_RRHH.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.Btn_RRHH.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_RRHH.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_RRHH.ForeColor = System.Drawing.Color.White;
            this.Btn_RRHH.IconChar = FontAwesome.Sharp.IconChar.Users;
            this.Btn_RRHH.IconColor = System.Drawing.Color.White;
            this.Btn_RRHH.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Btn_RRHH.IconSize = 32;
            this.Btn_RRHH.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_RRHH.Location = new System.Drawing.Point(2, 194);
            this.Btn_RRHH.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_RRHH.Name = "Btn_RRHH";
            this.Btn_RRHH.Size = new System.Drawing.Size(231, 44);
            this.Btn_RRHH.TabIndex = 12;
            this.Btn_RRHH.Text = "RRHH";
            this.Btn_RRHH.UseVisualStyleBackColor = true;
            this.Btn_RRHH.Click += new System.EventHandler(this.btn_RRHH_Click);
            // 
            // Btn_Usuarios
            // 
            this.Btn_Usuarios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Btn_Usuarios.FlatAppearance.BorderSize = 0;
            this.Btn_Usuarios.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.Btn_Usuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Usuarios.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Usuarios.ForeColor = System.Drawing.Color.White;
            this.Btn_Usuarios.IconChar = FontAwesome.Sharp.IconChar.UserGear;
            this.Btn_Usuarios.IconColor = System.Drawing.Color.White;
            this.Btn_Usuarios.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Btn_Usuarios.IconSize = 32;
            this.Btn_Usuarios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Usuarios.Location = new System.Drawing.Point(2, 146);
            this.Btn_Usuarios.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_Usuarios.Name = "Btn_Usuarios";
            this.Btn_Usuarios.Size = new System.Drawing.Size(231, 44);
            this.Btn_Usuarios.TabIndex = 11;
            this.Btn_Usuarios.Text = "Usuarios";
            this.Btn_Usuarios.UseVisualStyleBackColor = true;
            this.Btn_Usuarios.Click += new System.EventHandler(this.btn_Usuario_Click);
            // 
            // Btn_Ventas
            // 
            this.Btn_Ventas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Btn_Ventas.FlatAppearance.BorderSize = 0;
            this.Btn_Ventas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.Btn_Ventas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Ventas.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Ventas.ForeColor = System.Drawing.Color.White;
            this.Btn_Ventas.IconChar = FontAwesome.Sharp.IconChar.Store;
            this.Btn_Ventas.IconColor = System.Drawing.Color.White;
            this.Btn_Ventas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Btn_Ventas.IconSize = 32;
            this.Btn_Ventas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Ventas.Location = new System.Drawing.Point(2, 98);
            this.Btn_Ventas.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_Ventas.Name = "Btn_Ventas";
            this.Btn_Ventas.Size = new System.Drawing.Size(231, 44);
            this.Btn_Ventas.TabIndex = 10;
            this.Btn_Ventas.Text = "Ventas";
            this.Btn_Ventas.UseVisualStyleBackColor = true;
            this.Btn_Ventas.Click += new System.EventHandler(this.btn_Ventas_Click);
            // 
            // Btn_Compras
            // 
            this.Btn_Compras.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Btn_Compras.FlatAppearance.BorderSize = 0;
            this.Btn_Compras.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.Btn_Compras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Compras.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Compras.ForeColor = System.Drawing.Color.White;
            this.Btn_Compras.IconChar = FontAwesome.Sharp.IconChar.StoreAlt;
            this.Btn_Compras.IconColor = System.Drawing.Color.White;
            this.Btn_Compras.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Btn_Compras.IconSize = 32;
            this.Btn_Compras.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Compras.Location = new System.Drawing.Point(2, 50);
            this.Btn_Compras.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_Compras.Name = "Btn_Compras";
            this.Btn_Compras.Size = new System.Drawing.Size(231, 44);
            this.Btn_Compras.TabIndex = 9;
            this.Btn_Compras.Text = "Compras";
            this.Btn_Compras.UseVisualStyleBackColor = true;
            this.Btn_Compras.Click += new System.EventHandler(this.btn_Compras_Click);
            // 
            // BTN_Clientes
            // 
            this.BTN_Clientes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BTN_Clientes.FlatAppearance.BorderSize = 0;
            this.BTN_Clientes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.BTN_Clientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_Clientes.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Clientes.ForeColor = System.Drawing.Color.White;
            this.BTN_Clientes.IconChar = FontAwesome.Sharp.IconChar.User;
            this.BTN_Clientes.IconColor = System.Drawing.Color.White;
            this.BTN_Clientes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BTN_Clientes.IconSize = 32;
            this.BTN_Clientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTN_Clientes.Location = new System.Drawing.Point(2, 2);
            this.BTN_Clientes.Margin = new System.Windows.Forms.Padding(2);
            this.BTN_Clientes.Name = "BTN_Clientes";
            this.BTN_Clientes.Size = new System.Drawing.Size(231, 44);
            this.BTN_Clientes.TabIndex = 0;
            this.BTN_Clientes.Text = "Clientes";
            this.BTN_Clientes.UseVisualStyleBackColor = true;
            this.BTN_Clientes.Click += new System.EventHandler(this.btn_Clientes_Click);
            // 
            // panelTopBar
            // 
            this.panelTopBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(18)))), ((int)(((byte)(80)))));
            this.panelTopBar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelTopBar.Controls.Add(this.tableLayoutPanel2);
            this.panelTopBar.Controls.Add(this.label1);
            this.panelTopBar.Location = new System.Drawing.Point(253, 0);
            this.panelTopBar.Name = "panelTopBar";
            this.panelTopBar.Size = new System.Drawing.Size(919, 50);
            this.panelTopBar.TabIndex = 4;
            this.panelTopBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTopBar_MouseDown);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.Btn_Minimizar, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.Btn_Cerrar, 1, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(752, 4);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(150, 29);
            this.tableLayoutPanel2.TabIndex = 4;
            // 
            // Btn_Minimizar
            // 
            this.Btn_Minimizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Btn_Minimizar.BackgroundImage = global::SoftwarePrime.Properties.Resources.window_minimize_icon_194428;
            this.Btn_Minimizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Btn_Minimizar.FlatAppearance.BorderSize = 0;
            this.Btn_Minimizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Cyan;
            this.Btn_Minimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Minimizar.IconChar = FontAwesome.Sharp.IconChar.None;
            this.Btn_Minimizar.IconColor = System.Drawing.Color.Black;
            this.Btn_Minimizar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Btn_Minimizar.Location = new System.Drawing.Point(3, 3);
            this.Btn_Minimizar.Name = "Btn_Minimizar";
            this.Btn_Minimizar.Size = new System.Drawing.Size(69, 23);
            this.Btn_Minimizar.TabIndex = 1;
            this.Btn_Minimizar.UseVisualStyleBackColor = false;
            this.Btn_Minimizar.Click += new System.EventHandler(this.BTN_Minimizar_Click);
            // 
            // Btn_Cerrar
            // 
            this.Btn_Cerrar.BackColor = System.Drawing.Color.Red;
            this.Btn_Cerrar.BackgroundImage = global::SoftwarePrime.Properties.Resources.Close;
            this.Btn_Cerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Btn_Cerrar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Btn_Cerrar.FlatAppearance.BorderSize = 0;
            this.Btn_Cerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Btn_Cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Cerrar.IconChar = FontAwesome.Sharp.IconChar.None;
            this.Btn_Cerrar.IconColor = System.Drawing.Color.Red;
            this.Btn_Cerrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Btn_Cerrar.IconSize = 32;
            this.Btn_Cerrar.Location = new System.Drawing.Point(78, 3);
            this.Btn_Cerrar.Name = "Btn_Cerrar";
            this.Btn_Cerrar.Size = new System.Drawing.Size(69, 23);
            this.Btn_Cerrar.TabIndex = 0;
            this.Btn_Cerrar.UseVisualStyleBackColor = false;
            this.Btn_Cerrar.Click += new System.EventHandler(this.BTN_Cerrar_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 22);
            this.label1.TabIndex = 3;
            this.label1.Text = "Control General";
            // 
            // PanelVista
            // 
            this.PanelVista.BackColor = System.Drawing.Color.Transparent;
            this.PanelVista.Location = new System.Drawing.Point(253, 39);
            this.PanelVista.Name = "PanelVista";
            this.PanelVista.Size = new System.Drawing.Size(919, 623);
            this.PanelVista.TabIndex = 2;
            // 
            // FrmControlGestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1172, 661);
            this.Controls.Add(this.panelContenedor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmControlGestion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmControlGestion";
            this.panelContenedor.ResumeLayout(false);
            this.panelSlideBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panelTopBar.ResumeLayout(false);
            this.panelTopBar.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelContenedor;
        private System.Windows.Forms.Panel PanelVista;
        private System.Windows.Forms.Panel panelSlideBar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panelTopBar;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton BTN_Clientes;
        private FontAwesome.Sharp.IconButton Btn_Proveedores;
        private FontAwesome.Sharp.IconButton Btn_EstadoContable;
        private FontAwesome.Sharp.IconButton Btn_RRHH;
        private FontAwesome.Sharp.IconButton Btn_Usuarios;
        private FontAwesome.Sharp.IconButton Btn_Ventas;
        private FontAwesome.Sharp.IconButton Btn_Compras;
        private FontAwesome.Sharp.IconButton Btn_Minimizar;
        private FontAwesome.Sharp.IconButton Btn_Cerrar;
        private FontAwesome.Sharp.IconButton Btn_Desconectar;
    }
}