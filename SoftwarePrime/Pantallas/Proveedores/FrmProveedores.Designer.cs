namespace SoftwarePrime.Pantallas
{
    partial class FrmProveedores
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
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.topbar = new System.Windows.Forms.Panel();
            this.Btn_volver = new FontAwesome.Sharp.IconButton();
            this.label6 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.BTN_BajaLogica = new System.Windows.Forms.Button();
            this.BTN_Modificar = new System.Windows.Forms.Button();
            this.BTN_Agregar = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.TXT_Prov = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TXT_Cuit = new System.Windows.Forms.TextBox();
            this.TEXT_Nom = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TXT_TEL = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TXT_Email = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.GrillaProv = new System.Windows.Forms.DataGridView();
            this.PanelPrincipal.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.topbar.SuspendLayout();
            this.panel3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GrillaProv)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelPrincipal
            // 
            this.PanelPrincipal.BackColor = System.Drawing.Color.White;
            this.PanelPrincipal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanelPrincipal.Controls.Add(this.panel1);
            this.PanelPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelPrincipal.Location = new System.Drawing.Point(0, 0);
            this.PanelPrincipal.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.PanelPrincipal.Name = "PanelPrincipal";
            this.PanelPrincipal.Size = new System.Drawing.Size(919, 608);
            this.PanelPrincipal.TabIndex = 7;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Location = new System.Drawing.Point(-1, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(919, 610);
            this.panel1.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.panel2);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(919, 610);
            this.panel4.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.topbar);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.GrillaProv);
            this.panel2.Location = new System.Drawing.Point(-1, -1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(919, 610);
            this.panel2.TabIndex = 0;
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
            this.Btn_volver.Click += new System.EventHandler(this.Btn_volver_Click);
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(306, 9);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(396, 29);
            this.label6.TabIndex = 15;
            this.label6.Text = "Módulo de Gestion de Proveedores";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Controls.Add(this.groupBox2);
            this.panel3.Location = new System.Drawing.Point(3, 52);
            this.panel3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(438, 547);
            this.panel3.TabIndex = 3;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.tableLayoutPanel1);
            this.groupBox2.Controls.Add(this.tableLayoutPanel2);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(3, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(432, 541);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos del Proveedor:";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.BTN_BajaLogica, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.BTN_Modificar, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.BTN_Agregar, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 487);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(426, 51);
            this.tableLayoutPanel1.TabIndex = 16;
            // 
            // BTN_BajaLogica
            // 
            this.BTN_BajaLogica.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BTN_BajaLogica.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(139)))), ((int)(((byte)(245)))));
            this.BTN_BajaLogica.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_BajaLogica.ForeColor = System.Drawing.Color.White;
            this.BTN_BajaLogica.Location = new System.Drawing.Point(302, 8);
            this.BTN_BajaLogica.Name = "BTN_BajaLogica";
            this.BTN_BajaLogica.Size = new System.Drawing.Size(106, 34);
            this.BTN_BajaLogica.TabIndex = 3;
            this.BTN_BajaLogica.Text = "Baja Lógica";
            this.BTN_BajaLogica.UseVisualStyleBackColor = false;
            this.BTN_BajaLogica.Click += new System.EventHandler(this.BTN_BajaLogica_Click);
            // 
            // BTN_Modificar
            // 
            this.BTN_Modificar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BTN_Modificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(139)))), ((int)(((byte)(245)))));
            this.BTN_Modificar.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Modificar.ForeColor = System.Drawing.Color.White;
            this.BTN_Modificar.Location = new System.Drawing.Point(160, 8);
            this.BTN_Modificar.Name = "BTN_Modificar";
            this.BTN_Modificar.Size = new System.Drawing.Size(105, 34);
            this.BTN_Modificar.TabIndex = 2;
            this.BTN_Modificar.Text = "Modificar";
            this.BTN_Modificar.UseVisualStyleBackColor = false;
            this.BTN_Modificar.Click += new System.EventHandler(this.BTN_Modificar_Click);
            // 
            // BTN_Agregar
            // 
            this.BTN_Agregar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BTN_Agregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(139)))), ((int)(((byte)(245)))));
            this.BTN_Agregar.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Agregar.ForeColor = System.Drawing.Color.White;
            this.BTN_Agregar.Location = new System.Drawing.Point(18, 8);
            this.BTN_Agregar.Name = "BTN_Agregar";
            this.BTN_Agregar.Size = new System.Drawing.Size(105, 34);
            this.BTN_Agregar.TabIndex = 1;
            this.BTN_Agregar.Text = "Agregar";
            this.BTN_Agregar.UseVisualStyleBackColor = false;
            this.BTN_Agregar.Click += new System.EventHandler(this.BTN_Agregar_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.TXT_Prov, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.TXT_Cuit, 1, 4);
            this.tableLayoutPanel2.Controls.Add(this.TEXT_Nom, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.label5, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.TXT_TEL, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.TXT_Email, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 135);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 5;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66611F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66611F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66611F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66611F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66611F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(426, 206);
            this.tableLayoutPanel2.TabIndex = 13;
            // 
            // TXT_Prov
            // 
            this.TXT_Prov.Dock = System.Windows.Forms.DockStyle.Top;
            this.TXT_Prov.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXT_Prov.Location = new System.Drawing.Point(216, 126);
            this.TXT_Prov.Name = "TXT_Prov";
            this.TXT_Prov.Size = new System.Drawing.Size(207, 31);
            this.TXT_Prov.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TXT_Cuit
            // 
            this.TXT_Cuit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TXT_Cuit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXT_Cuit.Location = new System.Drawing.Point(216, 167);
            this.TXT_Cuit.Name = "TXT_Cuit";
            this.TXT_Cuit.Size = new System.Drawing.Size(207, 31);
            this.TXT_Cuit.TabIndex = 9;
            // 
            // TEXT_Nom
            // 
            this.TEXT_Nom.Dock = System.Windows.Forms.DockStyle.Top;
            this.TEXT_Nom.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TEXT_Nom.Location = new System.Drawing.Point(216, 3);
            this.TEXT_Nom.Name = "TEXT_Nom";
            this.TEXT_Nom.Size = new System.Drawing.Size(207, 31);
            this.TEXT_Nom.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 164);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(207, 42);
            this.label5.TabIndex = 8;
            this.label5.Text = "CUIT:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TXT_TEL
            // 
            this.TXT_TEL.Dock = System.Windows.Forms.DockStyle.Top;
            this.TXT_TEL.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXT_TEL.Location = new System.Drawing.Point(216, 44);
            this.TXT_TEL.Name = "TXT_TEL";
            this.TXT_TEL.Size = new System.Drawing.Size(207, 31);
            this.TXT_TEL.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(207, 41);
            this.label4.TabIndex = 6;
            this.label4.Text = "Proveedor:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TXT_Email
            // 
            this.TXT_Email.Dock = System.Windows.Forms.DockStyle.Top;
            this.TXT_Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXT_Email.Location = new System.Drawing.Point(216, 85);
            this.TXT_Email.Name = "TXT_Email";
            this.TXT_Email.Size = new System.Drawing.Size(207, 31);
            this.TXT_Email.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(207, 41);
            this.label2.TabIndex = 2;
            this.label2.Text = "Telefono:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(207, 41);
            this.label3.TabIndex = 4;
            this.label3.Text = "Email:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GrillaProv
            // 
            this.GrillaProv.BackgroundColor = System.Drawing.Color.White;
            this.GrillaProv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GrillaProv.Location = new System.Drawing.Point(446, 53);
            this.GrillaProv.Name = "GrillaProv";
            this.GrillaProv.ReadOnly = true;
            this.GrillaProv.RowHeadersWidth = 51;
            this.GrillaProv.Size = new System.Drawing.Size(469, 545);
            this.GrillaProv.TabIndex = 2;
            this.GrillaProv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GrillaProv_CellClick);
            // 
            // FrmProveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(919, 608);
            this.Controls.Add(this.PanelPrincipal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmProveedores";
            this.Text = "FrmProveedores";
            this.PanelPrincipal.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.topbar.ResumeLayout(false);
            this.topbar.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GrillaProv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelPrincipal;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel topbar;
        private FontAwesome.Sharp.IconButton Btn_volver;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button BTN_BajaLogica;
        private System.Windows.Forms.Button BTN_Modificar;
        private System.Windows.Forms.Button BTN_Agregar;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TXT_Cuit;
        private System.Windows.Forms.TextBox TEXT_Nom;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TXT_TEL;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TXT_Email;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView GrillaProv;
        private System.Windows.Forms.TextBox TXT_Prov;
    }
}