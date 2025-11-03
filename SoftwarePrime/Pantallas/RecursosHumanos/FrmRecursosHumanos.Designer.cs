namespace SoftwarePrime.Pantallas
{
    partial class FrmRecursosHumanos
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.topbar = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.Btn_volver = new FontAwesome.Sharp.IconButton();
            this.PanelPrincipal = new System.Windows.Forms.Panel();
            this.Panel_View = new System.Windows.Forms.Panel();
            this.Panel_Centro = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.BTN_Form_Users = new FontAwesome.Sharp.IconButton();
            this.BTN_Form_Cliente = new FontAwesome.Sharp.IconButton();
            this.BTN_Form_Prov = new FontAwesome.Sharp.IconButton();
            this.panel1.SuspendLayout();
            this.topbar.SuspendLayout();
            this.PanelPrincipal.SuspendLayout();
            this.Panel_View.SuspendLayout();
            this.Panel_Centro.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(36)))), ((int)(((byte)(71)))));
            this.panel1.Controls.Add(this.Panel_View);
            this.panel1.Controls.Add(this.topbar);
            this.panel1.Location = new System.Drawing.Point(-1, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(924, 610);
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
            this.topbar.Size = new System.Drawing.Size(924, 47);
            this.topbar.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(311, 9);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(325, 29);
            this.label6.TabIndex = 15;
            this.label6.Text = "Panel de Recursos Humanos";
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
            this.Btn_volver.Click += new System.EventHandler(this.Btn_volver_Click);
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
            this.PanelPrincipal.Size = new System.Drawing.Size(924, 611);
            this.PanelPrincipal.TabIndex = 7;
            // 
            // Panel_View
            // 
            this.Panel_View.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(36)))), ((int)(((byte)(71)))));
            this.Panel_View.Controls.Add(this.Panel_Centro);
            this.Panel_View.Location = new System.Drawing.Point(3, 48);
            this.Panel_View.Name = "Panel_View";
            this.Panel_View.Size = new System.Drawing.Size(917, 559);
            this.Panel_View.TabIndex = 21;
            // 
            // Panel_Centro
            // 
            this.Panel_Centro.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Panel_Centro.BackColor = System.Drawing.Color.Transparent;
            this.Panel_Centro.Controls.Add(this.tableLayoutPanel1);
            this.Panel_Centro.Location = new System.Drawing.Point(160, 74);
            this.Panel_Centro.Name = "Panel_Centro";
            this.Panel_Centro.Size = new System.Drawing.Size(600, 400);
            this.Panel_Centro.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.BTN_Form_Prov, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.BTN_Form_Cliente, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.BTN_Form_Users, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(152, 71);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(320, 260);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // BTN_Form_Users
            // 
            this.BTN_Form_Users.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BTN_Form_Users.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BTN_Form_Users.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Form_Users.ForeColor = System.Drawing.Color.White;
            this.BTN_Form_Users.IconChar = FontAwesome.Sharp.IconChar.UserAlt;
            this.BTN_Form_Users.IconColor = System.Drawing.Color.White;
            this.BTN_Form_Users.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BTN_Form_Users.IconSize = 34;
            this.BTN_Form_Users.Location = new System.Drawing.Point(3, 3);
            this.BTN_Form_Users.Name = "BTN_Form_Users";
            this.BTN_Form_Users.Size = new System.Drawing.Size(314, 80);
            this.BTN_Form_Users.TabIndex = 0;
            this.BTN_Form_Users.Text = "Administrar Usuarios";
            this.BTN_Form_Users.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BTN_Form_Users.UseVisualStyleBackColor = true;
            this.BTN_Form_Users.Click += new System.EventHandler(this.BTN_Form_Users_Click);
            // 
            // BTN_Form_Cliente
            // 
            this.BTN_Form_Cliente.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BTN_Form_Cliente.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BTN_Form_Cliente.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Form_Cliente.ForeColor = System.Drawing.Color.White;
            this.BTN_Form_Cliente.IconChar = FontAwesome.Sharp.IconChar.UserGroup;
            this.BTN_Form_Cliente.IconColor = System.Drawing.Color.White;
            this.BTN_Form_Cliente.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BTN_Form_Cliente.IconSize = 34;
            this.BTN_Form_Cliente.Location = new System.Drawing.Point(3, 89);
            this.BTN_Form_Cliente.Name = "BTN_Form_Cliente";
            this.BTN_Form_Cliente.Size = new System.Drawing.Size(314, 80);
            this.BTN_Form_Cliente.TabIndex = 1;
            this.BTN_Form_Cliente.Text = "Administrar Clientes";
            this.BTN_Form_Cliente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BTN_Form_Cliente.UseVisualStyleBackColor = true;
            this.BTN_Form_Cliente.Click += new System.EventHandler(this.BTN_Form_Cliente_Click);
            // 
            // BTN_Form_Prov
            // 
            this.BTN_Form_Prov.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BTN_Form_Prov.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BTN_Form_Prov.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Form_Prov.ForeColor = System.Drawing.Color.White;
            this.BTN_Form_Prov.IconChar = FontAwesome.Sharp.IconChar.TruckMoving;
            this.BTN_Form_Prov.IconColor = System.Drawing.Color.White;
            this.BTN_Form_Prov.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BTN_Form_Prov.IconSize = 34;
            this.BTN_Form_Prov.Location = new System.Drawing.Point(3, 175);
            this.BTN_Form_Prov.Name = "BTN_Form_Prov";
            this.BTN_Form_Prov.Size = new System.Drawing.Size(314, 82);
            this.BTN_Form_Prov.TabIndex = 2;
            this.BTN_Form_Prov.Text = "Administrar Proveedores";
            this.BTN_Form_Prov.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BTN_Form_Prov.UseVisualStyleBackColor = true;
            this.BTN_Form_Prov.Click += new System.EventHandler(this.BTN_Form_Prov_Click);
            // 
            // FrmRecursosHumanos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 611);
            this.Controls.Add(this.PanelPrincipal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmRecursosHumanos";
            this.Text = "FrmRecursosHumanos";
            this.Load += new System.EventHandler(this.FrmRecursosHumanos_Load);
            this.panel1.ResumeLayout(false);
            this.topbar.ResumeLayout(false);
            this.topbar.PerformLayout();
            this.PanelPrincipal.ResumeLayout(false);
            this.Panel_View.ResumeLayout(false);
            this.Panel_Centro.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel Panel_View;
        private System.Windows.Forms.Panel topbar;
        private FontAwesome.Sharp.IconButton Btn_volver;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel PanelPrincipal;
        private System.Windows.Forms.Panel Panel_Centro;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private FontAwesome.Sharp.IconButton BTN_Form_Prov;
        private FontAwesome.Sharp.IconButton BTN_Form_Cliente;
        private FontAwesome.Sharp.IconButton BTN_Form_Users;
    }
}