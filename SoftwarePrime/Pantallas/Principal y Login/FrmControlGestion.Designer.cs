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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmControlGestion));
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.panelSlideBar = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.BTN_Articulos = new FontAwesome.Sharp.IconButton();
            this.Btn_Desconectar = new FontAwesome.Sharp.IconButton();
            this.BTN_Inicio = new FontAwesome.Sharp.IconButton();
            this.btn_Proveedores = new FontAwesome.Sharp.IconButton();
            this.btn_RRHH = new FontAwesome.Sharp.IconButton();
            this.btn_Usuarios = new FontAwesome.Sharp.IconButton();
            this.btn_Ventas = new FontAwesome.Sharp.IconButton();
            this.btn_Compras = new FontAwesome.Sharp.IconButton();
            this.btn_Clientes = new FontAwesome.Sharp.IconButton();
            this.BTN_EstadoContable = new FontAwesome.Sharp.IconButton();
            this.panelTopBar = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.Btn_Minimizar = new FontAwesome.Sharp.IconButton();
            this.Btn_Cerrar = new FontAwesome.Sharp.IconButton();
            this.PanelVista = new System.Windows.Forms.Panel();
            this.LBL_Hora = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.User_Tipo = new System.Windows.Forms.Label();
            this.LBL_User_Tipo = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panelContenedor.SuspendLayout();
            this.panelSlideBar.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panelTopBar.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.PanelVista.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.panelContenedor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(1564, 814);
            this.panelContenedor.TabIndex = 3;
            // 
            // panelSlideBar
            // 
            this.panelSlideBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(31)))), ((int)(((byte)(60)))));
            this.panelSlideBar.BackgroundImage = global::SoftwarePrime.Properties.Resources.Captura_de_pantalla_2025_09_05_211147;
            this.panelSlideBar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelSlideBar.Controls.Add(this.tableLayoutPanel1);
            this.panelSlideBar.Location = new System.Drawing.Point(0, 0);
            this.panelSlideBar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelSlideBar.Name = "panelSlideBar";
            this.panelSlideBar.Size = new System.Drawing.Size(338, 813);
            this.panelSlideBar.TabIndex = 3;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.BTN_Articulos, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.BTN_Inicio, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btn_Proveedores, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.btn_RRHH, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.btn_Usuarios, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.btn_Ventas, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.btn_Compras, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.btn_Clientes, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.BTN_EstadoContable, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.Btn_Desconectar, 0, 9);
            this.tableLayoutPanel1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(-1, 60);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 10;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.0909F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.0909F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.0909F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.0909F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.0909F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.0909F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.0909F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.0909F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.0909F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.0909F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(339, 737);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // BTN_Articulos
            // 
            this.BTN_Articulos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BTN_Articulos.FlatAppearance.BorderSize = 0;
            this.BTN_Articulos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.BTN_Articulos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_Articulos.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Articulos.ForeColor = System.Drawing.Color.White;
            this.BTN_Articulos.IconChar = FontAwesome.Sharp.IconChar.TruckFront;
            this.BTN_Articulos.IconColor = System.Drawing.Color.White;
            this.BTN_Articulos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BTN_Articulos.IconSize = 32;
            this.BTN_Articulos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTN_Articulos.Location = new System.Drawing.Point(3, 326);
            this.BTN_Articulos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BTN_Articulos.Name = "BTN_Articulos";
            this.BTN_Articulos.Size = new System.Drawing.Size(333, 77);
            this.BTN_Articulos.TabIndex = 17;
            this.BTN_Articulos.Text = "Articulos";
            this.BTN_Articulos.UseVisualStyleBackColor = true;
            this.BTN_Articulos.Click += new System.EventHandler(this.BTN_Articulos_Click);
            // 
            // Btn_Desconectar
            // 
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
            this.Btn_Desconectar.Location = new System.Drawing.Point(3, 650);
            this.Btn_Desconectar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Btn_Desconectar.Name = "Btn_Desconectar";
            this.Btn_Desconectar.Size = new System.Drawing.Size(333, 79);
            this.Btn_Desconectar.TabIndex = 15;
            this.Btn_Desconectar.Text = "Desconectar";
            this.Btn_Desconectar.UseVisualStyleBackColor = true;
            this.Btn_Desconectar.Click += new System.EventHandler(this.Btn_Desconectar_Click);
            // 
            // BTN_Inicio
            // 
            this.BTN_Inicio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BTN_Inicio.FlatAppearance.BorderSize = 0;
            this.BTN_Inicio.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.BTN_Inicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_Inicio.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Inicio.ForeColor = System.Drawing.Color.White;
            this.BTN_Inicio.IconChar = FontAwesome.Sharp.IconChar.DesktopAlt;
            this.BTN_Inicio.IconColor = System.Drawing.Color.White;
            this.BTN_Inicio.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BTN_Inicio.IconSize = 32;
            this.BTN_Inicio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTN_Inicio.Location = new System.Drawing.Point(3, 2);
            this.BTN_Inicio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BTN_Inicio.Name = "BTN_Inicio";
            this.BTN_Inicio.Size = new System.Drawing.Size(333, 77);
            this.BTN_Inicio.TabIndex = 16;
            this.BTN_Inicio.Text = "Inicio";
            this.BTN_Inicio.UseVisualStyleBackColor = true;
            this.BTN_Inicio.Click += new System.EventHandler(this.BTN_Inicio_Click);
            // 
            // btn_Proveedores
            // 
            this.btn_Proveedores.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Proveedores.FlatAppearance.BorderSize = 0;
            this.btn_Proveedores.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btn_Proveedores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Proveedores.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Proveedores.ForeColor = System.Drawing.Color.White;
            this.btn_Proveedores.IconChar = FontAwesome.Sharp.IconChar.TruckFront;
            this.btn_Proveedores.IconColor = System.Drawing.Color.White;
            this.btn_Proveedores.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_Proveedores.IconSize = 32;
            this.btn_Proveedores.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Proveedores.Location = new System.Drawing.Point(3, 569);
            this.btn_Proveedores.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Proveedores.Name = "btn_Proveedores";
            this.btn_Proveedores.Size = new System.Drawing.Size(333, 77);
            this.btn_Proveedores.TabIndex = 14;
            this.btn_Proveedores.Text = "Proveedores";
            this.btn_Proveedores.UseVisualStyleBackColor = true;
            this.btn_Proveedores.Click += new System.EventHandler(this.btn_Proveedores_Click);
            // 
            // BTN_EstadoContable
            // 
            this.BTN_EstadoContable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BTN_EstadoContable.FlatAppearance.BorderSize = 0;
            this.BTN_EstadoContable.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.BTN_EstadoContable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_EstadoContable.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_EstadoContable.ForeColor = System.Drawing.Color.White;
            this.BTN_EstadoContable.IconChar = FontAwesome.Sharp.IconChar.ChartLine;
            this.BTN_EstadoContable.IconColor = System.Drawing.Color.White;
            this.BTN_EstadoContable.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BTN_EstadoContable.IconSize = 32;
            this.BTN_EstadoContable.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTN_EstadoContable.Location = new System.Drawing.Point(3, 488);
            this.BTN_EstadoContable.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BTN_EstadoContable.Name = "BTN_EstadoContable";
            this.BTN_EstadoContable.Size = new System.Drawing.Size(333, 77);
            this.BTN_EstadoContable.TabIndex = 18;
            this.BTN_EstadoContable.Text = "Estado Contable";
            this.BTN_EstadoContable.UseVisualStyleBackColor = true;
            this.BTN_EstadoContable.Click += new System.EventHandler(this.BTN_EstadoContable_Click);
            // 
            // btn_RRHH
            // 
            this.btn_RRHH.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_RRHH.FlatAppearance.BorderSize = 0;
            this.btn_RRHH.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btn_RRHH.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_RRHH.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_RRHH.ForeColor = System.Drawing.Color.White;
            this.btn_RRHH.IconChar = FontAwesome.Sharp.IconChar.Users;
            this.btn_RRHH.IconColor = System.Drawing.Color.White;
            this.btn_RRHH.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_RRHH.IconSize = 32;
            this.btn_RRHH.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_RRHH.Location = new System.Drawing.Point(3, 488);
            this.btn_RRHH.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_RRHH.Name = "btn_RRHH";
            this.btn_RRHH.Size = new System.Drawing.Size(333, 77);
            this.btn_RRHH.TabIndex = 12;
            this.btn_RRHH.Text = "RRHH";
            this.btn_RRHH.UseVisualStyleBackColor = true;
            this.btn_RRHH.Click += new System.EventHandler(this.btn_RRHH_Click);
            // 
            // btn_Usuarios
            // 
            this.btn_Usuarios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Usuarios.FlatAppearance.BorderSize = 0;
            this.btn_Usuarios.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btn_Usuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Usuarios.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Usuarios.ForeColor = System.Drawing.Color.White;
            this.btn_Usuarios.IconChar = FontAwesome.Sharp.IconChar.UserGear;
            this.btn_Usuarios.IconColor = System.Drawing.Color.White;
            this.btn_Usuarios.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_Usuarios.IconSize = 32;
            this.btn_Usuarios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Usuarios.Location = new System.Drawing.Point(3, 407);
            this.btn_Usuarios.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Usuarios.Name = "btn_Usuarios";
            this.btn_Usuarios.Size = new System.Drawing.Size(333, 77);
            this.btn_Usuarios.TabIndex = 11;
            this.btn_Usuarios.Text = "Usuarios";
            this.btn_Usuarios.UseVisualStyleBackColor = true;
            this.btn_Usuarios.Click += new System.EventHandler(this.btn_Usuario_Click);
            // 
            // btn_Ventas
            // 
            this.btn_Ventas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Ventas.FlatAppearance.BorderSize = 0;
            this.btn_Ventas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btn_Ventas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Ventas.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Ventas.ForeColor = System.Drawing.Color.White;
            this.btn_Ventas.IconChar = FontAwesome.Sharp.IconChar.Store;
            this.btn_Ventas.IconColor = System.Drawing.Color.White;
            this.btn_Ventas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_Ventas.IconSize = 32;
            this.btn_Ventas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Ventas.Location = new System.Drawing.Point(3, 245);
            this.btn_Ventas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Ventas.Name = "btn_Ventas";
            this.btn_Ventas.Size = new System.Drawing.Size(333, 77);
            this.btn_Ventas.TabIndex = 10;
            this.btn_Ventas.Text = "Ventas";
            this.btn_Ventas.UseVisualStyleBackColor = true;
            this.btn_Ventas.Click += new System.EventHandler(this.btn_Ventas_Click);
            // 
            // btn_Compras
            // 
            this.btn_Compras.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Compras.FlatAppearance.BorderSize = 0;
            this.btn_Compras.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btn_Compras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Compras.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Compras.ForeColor = System.Drawing.Color.White;
            this.btn_Compras.IconChar = FontAwesome.Sharp.IconChar.StoreAlt;
            this.btn_Compras.IconColor = System.Drawing.Color.White;
            this.btn_Compras.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_Compras.IconSize = 32;
            this.btn_Compras.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Compras.Location = new System.Drawing.Point(3, 164);
            this.btn_Compras.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Compras.Name = "btn_Compras";
            this.btn_Compras.Size = new System.Drawing.Size(333, 77);
            this.btn_Compras.TabIndex = 9;
            this.btn_Compras.Text = "Compras";
            this.btn_Compras.UseVisualStyleBackColor = true;
            this.btn_Compras.Click += new System.EventHandler(this.btn_Compras_Click);
            // 
            // btn_Clientes
            // 
            this.btn_Clientes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Clientes.FlatAppearance.BorderSize = 0;
            this.btn_Clientes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btn_Clientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Clientes.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Clientes.ForeColor = System.Drawing.Color.White;
            this.btn_Clientes.IconChar = FontAwesome.Sharp.IconChar.UserAlt;
            this.btn_Clientes.IconColor = System.Drawing.Color.White;
            this.btn_Clientes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_Clientes.IconSize = 32;
            this.btn_Clientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Clientes.Location = new System.Drawing.Point(3, 83);
            this.btn_Clientes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Clientes.Name = "btn_Clientes";
            this.btn_Clientes.Size = new System.Drawing.Size(333, 77);
            this.btn_Clientes.TabIndex = 0;
            this.btn_Clientes.Text = "Clientes";
            this.btn_Clientes.UseVisualStyleBackColor = true;
            this.btn_Clientes.Click += new System.EventHandler(this.btn_Clientes_Click);
            // 
            // panelTopBar
            // 
            this.panelTopBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(31)))), ((int)(((byte)(60)))));
            this.panelTopBar.BackgroundImage = global::SoftwarePrime.Properties.Resources.Captura_de_pantalla_2025_09_05_211147;
            this.panelTopBar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelTopBar.Controls.Add(this.tableLayoutPanel2);
            this.panelTopBar.Location = new System.Drawing.Point(337, 0);
            this.panelTopBar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelTopBar.Name = "panelTopBar";
            this.panelTopBar.Size = new System.Drawing.Size(1225, 61);
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
            this.tableLayoutPanel2.Location = new System.Drawing.Point(1003, 5);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(200, 36);
            this.tableLayoutPanel2.TabIndex = 4;
            // 
            // Btn_Minimizar
            // 
            this.Btn_Minimizar.BackColor = System.Drawing.Color.Silver;
            this.Btn_Minimizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Btn_Minimizar.FlatAppearance.BorderSize = 0;
            this.Btn_Minimizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Cyan;
            this.Btn_Minimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Minimizar.IconChar = FontAwesome.Sharp.IconChar.None;
            this.Btn_Minimizar.IconColor = System.Drawing.Color.Black;
            this.Btn_Minimizar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Btn_Minimizar.Location = new System.Drawing.Point(4, 4);
            this.Btn_Minimizar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Btn_Minimizar.Name = "Btn_Minimizar";
            this.Btn_Minimizar.Size = new System.Drawing.Size(92, 28);
            this.Btn_Minimizar.TabIndex = 1;
            this.Btn_Minimizar.UseVisualStyleBackColor = false;
            this.Btn_Minimizar.Click += new System.EventHandler(this.BTN_Minimizar_Click);
            // 
            // Btn_Cerrar
            // 
            this.Btn_Cerrar.BackColor = System.Drawing.Color.Silver;
            this.Btn_Cerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Btn_Cerrar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Btn_Cerrar.FlatAppearance.BorderSize = 0;
            this.Btn_Cerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Btn_Cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Cerrar.IconChar = FontAwesome.Sharp.IconChar.None;
            this.Btn_Cerrar.IconColor = System.Drawing.Color.Red;
            this.Btn_Cerrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Btn_Cerrar.IconSize = 32;
            this.Btn_Cerrar.Location = new System.Drawing.Point(104, 4);
            this.Btn_Cerrar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Btn_Cerrar.Name = "Btn_Cerrar";
            this.Btn_Cerrar.Size = new System.Drawing.Size(92, 28);
            this.Btn_Cerrar.TabIndex = 0;
            this.Btn_Cerrar.UseVisualStyleBackColor = false;
            this.Btn_Cerrar.Click += new System.EventHandler(this.BTN_Cerrar_Click);
            // 
            // PanelVista
            // 
            this.PanelVista.BackColor = System.Drawing.Color.LightGray;
            this.PanelVista.BackgroundImage = global::SoftwarePrime.Properties.Resources.fondo_oscuro;
            this.PanelVista.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PanelVista.Controls.Add(this.LBL_Hora);
            this.PanelVista.Controls.Add(this.panel1);
            this.PanelVista.Controls.Add(this.pictureBox1);
            this.PanelVista.Controls.Add(this.label2);
            this.PanelVista.Controls.Add(this.label1);
            this.PanelVista.Location = new System.Drawing.Point(337, 62);
            this.PanelVista.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PanelVista.Name = "PanelVista";
            this.PanelVista.Size = new System.Drawing.Size(1225, 752);
            this.PanelVista.TabIndex = 2;
            // 
            // LBL_Hora
            // 
            this.LBL_Hora.AutoSize = true;
            this.LBL_Hora.BackColor = System.Drawing.Color.Transparent;
            this.LBL_Hora.Font = new System.Drawing.Font("Segoe UI Semibold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_Hora.ForeColor = System.Drawing.Color.White;
            this.LBL_Hora.Location = new System.Drawing.Point(509, 62);
            this.LBL_Hora.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LBL_Hora.Name = "LBL_Hora";
            this.LBL_Hora.Size = new System.Drawing.Size(175, 54);
            this.LBL_Hora.TabIndex = 11;
            this.LBL_Hora.Text = "00:00:00";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.iconPictureBox1);
            this.panel1.Controls.Add(this.User_Tipo);
            this.panel1.Controls.Add(this.LBL_User_Tipo);
            this.panel1.Location = new System.Drawing.Point(955, 7);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(266, 123);
            this.panel1.TabIndex = 10;
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.UserAlt;
            this.iconPictureBox1.IconColor = System.Drawing.Color.White;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 59;
            this.iconPictureBox1.Location = new System.Drawing.Point(4, 20);
            this.iconPictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(59, 65);
            this.iconPictureBox1.TabIndex = 7;
            this.iconPictureBox1.TabStop = false;
            // 
            // User_Tipo
            // 
            this.User_Tipo.AutoSize = true;
            this.User_Tipo.BackColor = System.Drawing.Color.Transparent;
            this.User_Tipo.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.User_Tipo.ForeColor = System.Drawing.Color.White;
            this.User_Tipo.Location = new System.Drawing.Point(71, 57);
            this.User_Tipo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.User_Tipo.Name = "User_Tipo";
            this.User_Tipo.Size = new System.Drawing.Size(0, 28);
            this.User_Tipo.TabIndex = 6;
            // 
            // LBL_User_Tipo
            // 
            this.LBL_User_Tipo.AutoSize = true;
            this.LBL_User_Tipo.BackColor = System.Drawing.Color.Transparent;
            this.LBL_User_Tipo.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_User_Tipo.ForeColor = System.Drawing.Color.White;
            this.LBL_User_Tipo.Location = new System.Drawing.Point(71, 20);
            this.LBL_User_Tipo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LBL_User_Tipo.Name = "LBL_User_Tipo";
            this.LBL_User_Tipo.Size = new System.Drawing.Size(86, 28);
            this.LBL_User_Tipo.TabIndex = 5;
            this.LBL_User_Tipo.Text = "Usuario:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::SoftwarePrime.Properties.Resources.Logo_Prime;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(476, 167);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(255, 195);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(357, 545);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(484, 28);
            this.label2.TabIndex = 9;
            this.label2.Text = "Seleccione un módulo del menú lateral para comenzar";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(388, 411);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(410, 92);
            this.label1.TabIndex = 8;
            this.label1.Text = "Bienvenido al sistema de \r\ngestión de Prime System\r\n";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FrmControlGestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1564, 814);
            this.Controls.Add(this.panelContenedor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmControlGestion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmControlGestion";
            this.Load += new System.EventHandler(this.FrmControlGestion_Load);
            this.panelContenedor.ResumeLayout(false);
            this.panelSlideBar.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panelTopBar.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.PanelVista.ResumeLayout(false);
            this.PanelVista.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelContenedor;
        private System.Windows.Forms.Panel PanelVista;
        private System.Windows.Forms.Panel panelSlideBar;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panelTopBar;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private FontAwesome.Sharp.IconButton btn_Clientes;
        private FontAwesome.Sharp.IconButton btn_Proveedores;
        private FontAwesome.Sharp.IconButton btn_RRHH;
        private FontAwesome.Sharp.IconButton btn_Usuarios;
        private FontAwesome.Sharp.IconButton btn_Ventas;
        private FontAwesome.Sharp.IconButton btn_Compras;
        private FontAwesome.Sharp.IconButton Btn_Minimizar;
        private FontAwesome.Sharp.IconButton Btn_Cerrar;
        private FontAwesome.Sharp.IconButton Btn_Desconectar;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label LBL_Hora;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private System.Windows.Forms.Label User_Tipo;
        private System.Windows.Forms.Label LBL_User_Tipo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton BTN_Inicio;
        private FontAwesome.Sharp.IconButton BTN_Articulos;
        private FontAwesome.Sharp.IconButton BTN_EstadoContable;
    }
}