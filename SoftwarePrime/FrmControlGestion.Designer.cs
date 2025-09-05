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
            this.BTN_Clientes = new FontAwesome.Sharp.IconButton();
            this.btn_RRHH = new System.Windows.Forms.Button();
            this.btn_Estado_Contable = new System.Windows.Forms.Button();
            this.btn_Proveedores = new System.Windows.Forms.Button();
            this.btn_Ventas = new System.Windows.Forms.Button();
            this.btn_Compras = new System.Windows.Forms.Button();
            this.btn_Usuario = new System.Windows.Forms.Button();
            this.panelTopBar = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.BTN_Cerrar = new System.Windows.Forms.Button();
            this.BTN_Minimizar = new System.Windows.Forms.Button();
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
            this.panelContenedor.Size = new System.Drawing.Size(1095, 661);
            this.panelContenedor.TabIndex = 3;
            // 
            // panelSlideBar
            // 
            this.panelSlideBar.BackColor = System.Drawing.Color.Black;
            this.panelSlideBar.Controls.Add(this.pictureBox1);
            this.panelSlideBar.Controls.Add(this.tableLayoutPanel1);
            this.panelSlideBar.Location = new System.Drawing.Point(0, 0);
            this.panelSlideBar.Name = "panelSlideBar";
            this.panelSlideBar.Size = new System.Drawing.Size(254, 661);
            this.panelSlideBar.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
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
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Black;
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.BTN_Clientes, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btn_RRHH, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.btn_Estado_Contable, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.btn_Proveedores, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.btn_Ventas, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.btn_Compras, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btn_Usuario, 0, 6);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(28, 201);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(194, 387);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // BTN_Clientes
            // 
            this.BTN_Clientes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BTN_Clientes.FlatAppearance.BorderSize = 0;
            this.BTN_Clientes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BTN_Clientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_Clientes.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Clientes.ForeColor = System.Drawing.Color.White;
            this.BTN_Clientes.IconChar = FontAwesome.Sharp.IconChar.User;
            this.BTN_Clientes.IconColor = System.Drawing.Color.White;
            this.BTN_Clientes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BTN_Clientes.IconSize = 32;
            this.BTN_Clientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTN_Clientes.Location = new System.Drawing.Point(4, 4);
            this.BTN_Clientes.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BTN_Clientes.Name = "BTN_Clientes";
            this.BTN_Clientes.Size = new System.Drawing.Size(186, 49);
            this.BTN_Clientes.TabIndex = 0;
            this.BTN_Clientes.Text = "Clientes";
            this.BTN_Clientes.UseVisualStyleBackColor = true;
            this.BTN_Clientes.Click += new System.EventHandler(this.btn_Clientes_Click);
            // 
            // btn_RRHH
            // 
            this.btn_RRHH.BackColor = System.Drawing.Color.Black;
            this.btn_RRHH.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_RRHH.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_RRHH.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_RRHH.FlatAppearance.BorderSize = 5;
            this.btn_RRHH.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_RRHH.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btn_RRHH.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_RRHH.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_RRHH.ForeColor = System.Drawing.Color.White;
            this.btn_RRHH.Location = new System.Drawing.Point(5, 170);
            this.btn_RRHH.Name = "btn_RRHH";
            this.btn_RRHH.Size = new System.Drawing.Size(184, 47);
            this.btn_RRHH.TabIndex = 8;
            this.btn_RRHH.Text = "Recursos Humanos";
            this.btn_RRHH.UseVisualStyleBackColor = false;
            this.btn_RRHH.Click += new System.EventHandler(this.btn_RRHH_Click);
            // 
            // btn_Estado_Contable
            // 
            this.btn_Estado_Contable.BackColor = System.Drawing.Color.Black;
            this.btn_Estado_Contable.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Estado_Contable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Estado_Contable.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_Estado_Contable.FlatAppearance.BorderSize = 5;
            this.btn_Estado_Contable.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_Estado_Contable.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btn_Estado_Contable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Estado_Contable.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Estado_Contable.ForeColor = System.Drawing.Color.White;
            this.btn_Estado_Contable.Location = new System.Drawing.Point(5, 280);
            this.btn_Estado_Contable.Name = "btn_Estado_Contable";
            this.btn_Estado_Contable.Size = new System.Drawing.Size(184, 47);
            this.btn_Estado_Contable.TabIndex = 5;
            this.btn_Estado_Contable.Text = "Estado Contable";
            this.btn_Estado_Contable.UseVisualStyleBackColor = false;
            this.btn_Estado_Contable.Click += new System.EventHandler(this.btn_Estado_Contable_Click);
            // 
            // btn_Proveedores
            // 
            this.btn_Proveedores.BackColor = System.Drawing.Color.Black;
            this.btn_Proveedores.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Proveedores.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Proveedores.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_Proveedores.FlatAppearance.BorderSize = 5;
            this.btn_Proveedores.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_Proveedores.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btn_Proveedores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Proveedores.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Proveedores.ForeColor = System.Drawing.Color.White;
            this.btn_Proveedores.Location = new System.Drawing.Point(5, 225);
            this.btn_Proveedores.Name = "btn_Proveedores";
            this.btn_Proveedores.Size = new System.Drawing.Size(184, 47);
            this.btn_Proveedores.TabIndex = 4;
            this.btn_Proveedores.Text = "Proveedores";
            this.btn_Proveedores.UseVisualStyleBackColor = false;
            this.btn_Proveedores.Click += new System.EventHandler(this.btn_Proveedores_Click);
            // 
            // btn_Ventas
            // 
            this.btn_Ventas.BackColor = System.Drawing.Color.Black;
            this.btn_Ventas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Ventas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Ventas.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_Ventas.FlatAppearance.BorderSize = 5;
            this.btn_Ventas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_Ventas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btn_Ventas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Ventas.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Ventas.ForeColor = System.Drawing.Color.White;
            this.btn_Ventas.Location = new System.Drawing.Point(5, 115);
            this.btn_Ventas.Name = "btn_Ventas";
            this.btn_Ventas.Size = new System.Drawing.Size(184, 47);
            this.btn_Ventas.TabIndex = 2;
            this.btn_Ventas.Text = "Ventas";
            this.btn_Ventas.UseVisualStyleBackColor = false;
            this.btn_Ventas.Click += new System.EventHandler(this.btn_Ventas_Click);
            // 
            // btn_Compras
            // 
            this.btn_Compras.BackColor = System.Drawing.Color.Black;
            this.btn_Compras.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Compras.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Compras.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_Compras.FlatAppearance.BorderSize = 5;
            this.btn_Compras.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_Compras.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btn_Compras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Compras.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Compras.ForeColor = System.Drawing.Color.White;
            this.btn_Compras.Location = new System.Drawing.Point(5, 60);
            this.btn_Compras.Name = "btn_Compras";
            this.btn_Compras.Size = new System.Drawing.Size(184, 47);
            this.btn_Compras.TabIndex = 1;
            this.btn_Compras.Text = "Compras";
            this.btn_Compras.UseVisualStyleBackColor = false;
            this.btn_Compras.Click += new System.EventHandler(this.btn_Compras_Click);
            // 
            // btn_Usuario
            // 
            this.btn_Usuario.BackColor = System.Drawing.Color.Black;
            this.btn_Usuario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Usuario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Usuario.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_Usuario.FlatAppearance.BorderSize = 5;
            this.btn_Usuario.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_Usuario.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btn_Usuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Usuario.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Usuario.ForeColor = System.Drawing.Color.White;
            this.btn_Usuario.Location = new System.Drawing.Point(5, 335);
            this.btn_Usuario.Name = "btn_Usuario";
            this.btn_Usuario.Size = new System.Drawing.Size(184, 47);
            this.btn_Usuario.TabIndex = 3;
            this.btn_Usuario.Text = "Usuario";
            this.btn_Usuario.UseVisualStyleBackColor = false;
            this.btn_Usuario.Click += new System.EventHandler(this.btn_Usuario_Click);
            // 
            // panelTopBar
            // 
            this.panelTopBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panelTopBar.Controls.Add(this.tableLayoutPanel2);
            this.panelTopBar.Controls.Add(this.label1);
            this.panelTopBar.Location = new System.Drawing.Point(253, 0);
            this.panelTopBar.Name = "panelTopBar";
            this.panelTopBar.Size = new System.Drawing.Size(936, 50);
            this.panelTopBar.TabIndex = 4;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.BTN_Cerrar, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.BTN_Minimizar, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(752, 4);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(150, 29);
            this.tableLayoutPanel2.TabIndex = 4;
            // 
            // BTN_Cerrar
            // 
            this.BTN_Cerrar.BackColor = System.Drawing.Color.Transparent;
            this.BTN_Cerrar.BackgroundImage = global::SoftwarePrime.Properties.Resources._1486564399_close_81512;
            this.BTN_Cerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BTN_Cerrar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BTN_Cerrar.FlatAppearance.BorderSize = 0;
            this.BTN_Cerrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BTN_Cerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BTN_Cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_Cerrar.ForeColor = System.Drawing.Color.Transparent;
            this.BTN_Cerrar.Location = new System.Drawing.Point(77, 2);
            this.BTN_Cerrar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BTN_Cerrar.Name = "BTN_Cerrar";
            this.BTN_Cerrar.Size = new System.Drawing.Size(71, 25);
            this.BTN_Cerrar.TabIndex = 1;
            this.BTN_Cerrar.UseVisualStyleBackColor = false;
            this.BTN_Cerrar.Click += new System.EventHandler(this.BTN_Cerrar_Click);
            // 
            // BTN_Minimizar
            // 
            this.BTN_Minimizar.BackColor = System.Drawing.Color.Transparent;
            this.BTN_Minimizar.BackgroundImage = global::SoftwarePrime.Properties.Resources.window_minimize_icon_198591;
            this.BTN_Minimizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BTN_Minimizar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BTN_Minimizar.FlatAppearance.BorderSize = 0;
            this.BTN_Minimizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Cyan;
            this.BTN_Minimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_Minimizar.ForeColor = System.Drawing.Color.White;
            this.BTN_Minimizar.Location = new System.Drawing.Point(2, 2);
            this.BTN_Minimizar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BTN_Minimizar.Name = "BTN_Minimizar";
            this.BTN_Minimizar.Size = new System.Drawing.Size(71, 25);
            this.BTN_Minimizar.TabIndex = 0;
            this.BTN_Minimizar.UseVisualStyleBackColor = false;
            this.BTN_Minimizar.Click += new System.EventHandler(this.BTN_Minimizar_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 22);
            this.label1.TabIndex = 3;
            this.label1.Text = "Control General";
            // 
            // PanelVista
            // 
            this.PanelVista.BackColor = System.Drawing.Color.Transparent;
            this.PanelVista.Location = new System.Drawing.Point(253, 47);
            this.PanelVista.Name = "PanelVista";
            this.PanelVista.Size = new System.Drawing.Size(937, 615);
            this.PanelVista.TabIndex = 2;
            // 
            // FrmControlGestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1095, 661);
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
        private System.Windows.Forms.Button btn_RRHH;
        private System.Windows.Forms.Button btn_Estado_Contable;
        private System.Windows.Forms.Button btn_Proveedores;
        private System.Windows.Forms.Button btn_Ventas;
        private System.Windows.Forms.Button btn_Compras;
        private System.Windows.Forms.Button btn_Usuario;
        private System.Windows.Forms.Panel panelTopBar;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button BTN_Cerrar;
        private System.Windows.Forms.Button BTN_Minimizar;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton BTN_Clientes;
    }
}