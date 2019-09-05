namespace TP_PAV_3k2
{
    partial class FormularioPrincipal
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarEmpleadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarSucursalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarTipoCombustibleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarUnidadDeMedidaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarUrgenciaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSalir = new System.Windows.Forms.Button();
            this.grdEstaciones = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.btnPedido = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdEstaciones)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarEmpleadoToolStripMenuItem,
            this.toolStripMenuItem1,
            this.agregarSucursalToolStripMenuItem,
            this.toolStripSeparator1,
            this.agregarTipoCombustibleToolStripMenuItem,
            this.agregarUnidadDeMedidaToolStripMenuItem,
            this.agregarUrgenciaToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(81, 20);
            this.menuToolStripMenuItem.Text = "Administrar";
            // 
            // agregarEmpleadoToolStripMenuItem
            // 
            this.agregarEmpleadoToolStripMenuItem.Name = "agregarEmpleadoToolStripMenuItem";
            this.agregarEmpleadoToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.agregarEmpleadoToolStripMenuItem.Text = "Empleado";
            this.agregarEmpleadoToolStripMenuItem.Click += new System.EventHandler(this.agregarEmpleadoToolStripMenuItem_Click);
            // 
            // agregarSucursalToolStripMenuItem
            // 
            this.agregarSucursalToolStripMenuItem.Name = "agregarSucursalToolStripMenuItem";
            this.agregarSucursalToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.agregarSucursalToolStripMenuItem.Text = "Sucursal";
            this.agregarSucursalToolStripMenuItem.Click += new System.EventHandler(this.agregarSucursalToolStripMenuItem_Click);
            // 
            // agregarTipoCombustibleToolStripMenuItem
            // 
            this.agregarTipoCombustibleToolStripMenuItem.Name = "agregarTipoCombustibleToolStripMenuItem";
            this.agregarTipoCombustibleToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.agregarTipoCombustibleToolStripMenuItem.Text = "Tipos de Combustible";
            this.agregarTipoCombustibleToolStripMenuItem.Click += new System.EventHandler(this.agregarTipoCombustibleToolStripMenuItem_Click);
            // 
            // agregarUnidadDeMedidaToolStripMenuItem
            // 
            this.agregarUnidadDeMedidaToolStripMenuItem.Name = "agregarUnidadDeMedidaToolStripMenuItem";
            this.agregarUnidadDeMedidaToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.agregarUnidadDeMedidaToolStripMenuItem.Text = "Unidades de Medida";
            this.agregarUnidadDeMedidaToolStripMenuItem.Click += new System.EventHandler(this.agregarUnidadDeMedidaToolStripMenuItem_Click);
            // 
            // agregarUrgenciaToolStripMenuItem
            // 
            this.agregarUrgenciaToolStripMenuItem.Name = "agregarUrgenciaToolStripMenuItem";
            this.agregarUrgenciaToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.agregarUrgenciaToolStripMenuItem.Text = "Niveles de Urgencia";
            this.agregarUrgenciaToolStripMenuItem.Click += new System.EventHandler(this.agregarUrgenciaToolStripMenuItem_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(656, 390);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(101, 31);
            this.btnSalir.TabIndex = 3;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // grdEstaciones
            // 
            this.grdEstaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdEstaciones.Location = new System.Drawing.Point(40, 86);
            this.grdEstaciones.Name = "grdEstaciones";
            this.grdEstaciones.ReadOnly = true;
            this.grdEstaciones.Size = new System.Drawing.Size(717, 296);
            this.grdEstaciones.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Estaciones Registradas";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(186, 6);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(189, 22);
            this.toolStripMenuItem1.Text = "Producto";
            // 
            // btnPedido
            // 
            this.btnPedido.Location = new System.Drawing.Point(549, 390);
            this.btnPedido.Name = "btnPedido";
            this.btnPedido.Size = new System.Drawing.Size(101, 31);
            this.btnPedido.TabIndex = 7;
            this.btnPedido.Text = "Nuevo Pedido";
            this.btnPedido.UseVisualStyleBackColor = true;
            // 
            // FormularioPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnPedido);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grdEstaciones);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormularioPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Principal";
            this.Load += new System.EventHandler(this.FormularioPrincipal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdEstaciones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarEmpleadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarSucursalToolStripMenuItem;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.DataGridView grdEstaciones;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem agregarTipoCombustibleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarUnidadDeMedidaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarUrgenciaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.Button btnPedido;
    }
}