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
            this.aBMSurtidorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSalir = new System.Windows.Forms.Button();
            this.grdEmpleados = new System.Windows.Forms.DataGridView();
            this.grdEstaciones = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ordenDeCompraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ticketToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdEmpleados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdEstaciones)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem,
            this.ordenDeCompraToolStripMenuItem,
            this.ticketToolStripMenuItem});
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
            this.agregarSucursalToolStripMenuItem,
            this.agregarTipoCombustibleToolStripMenuItem,
            this.agregarUnidadDeMedidaToolStripMenuItem,
            this.agregarUrgenciaToolStripMenuItem,
            this.aBMSurtidorToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // agregarEmpleadoToolStripMenuItem
            // 
            this.agregarEmpleadoToolStripMenuItem.Name = "agregarEmpleadoToolStripMenuItem";
            this.agregarEmpleadoToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.agregarEmpleadoToolStripMenuItem.Text = "Agregar Empleado";
            this.agregarEmpleadoToolStripMenuItem.Click += new System.EventHandler(this.agregarEmpleadoToolStripMenuItem_Click);
            // 
            // agregarSucursalToolStripMenuItem
            // 
            this.agregarSucursalToolStripMenuItem.Name = "agregarSucursalToolStripMenuItem";
            this.agregarSucursalToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.agregarSucursalToolStripMenuItem.Text = "Agregar Sucursal";
            this.agregarSucursalToolStripMenuItem.Click += new System.EventHandler(this.agregarSucursalToolStripMenuItem_Click);
            // 
            // agregarTipoCombustibleToolStripMenuItem
            // 
            this.agregarTipoCombustibleToolStripMenuItem.Name = "agregarTipoCombustibleToolStripMenuItem";
            this.agregarTipoCombustibleToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.agregarTipoCombustibleToolStripMenuItem.Text = "ABMTipoCombustible";
            this.agregarTipoCombustibleToolStripMenuItem.Click += new System.EventHandler(this.agregarTipoCombustibleToolStripMenuItem_Click);
            // 
            // agregarUnidadDeMedidaToolStripMenuItem
            // 
            this.agregarUnidadDeMedidaToolStripMenuItem.Name = "agregarUnidadDeMedidaToolStripMenuItem";
            this.agregarUnidadDeMedidaToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.agregarUnidadDeMedidaToolStripMenuItem.Text = "ABMUnidadMedida";
            this.agregarUnidadDeMedidaToolStripMenuItem.Click += new System.EventHandler(this.agregarUnidadDeMedidaToolStripMenuItem_Click);
            // 
            // agregarUrgenciaToolStripMenuItem
            // 
            this.agregarUrgenciaToolStripMenuItem.Name = "agregarUrgenciaToolStripMenuItem";
            this.agregarUrgenciaToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.agregarUrgenciaToolStripMenuItem.Text = "ABMUrgencia";
            this.agregarUrgenciaToolStripMenuItem.Click += new System.EventHandler(this.agregarUrgenciaToolStripMenuItem_Click);
            // 
            // aBMSurtidorToolStripMenuItem
            // 
            this.aBMSurtidorToolStripMenuItem.Name = "aBMSurtidorToolStripMenuItem";
            this.aBMSurtidorToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.aBMSurtidorToolStripMenuItem.Text = "ABMSurtidor";
            this.aBMSurtidorToolStripMenuItem.Click += new System.EventHandler(this.aBMSurtidorToolStripMenuItem_Click);
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
            // grdEmpleados
            // 
            this.grdEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdEmpleados.Location = new System.Drawing.Point(40, 80);
            this.grdEmpleados.Name = "grdEmpleados";
            this.grdEmpleados.ReadOnly = true;
            this.grdEmpleados.Size = new System.Drawing.Size(717, 142);
            this.grdEmpleados.TabIndex = 4;
            this.grdEmpleados.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GrdEmpleados_CellContentClick);
            // 
            // grdEstaciones
            // 
            this.grdEstaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdEstaciones.Location = new System.Drawing.Point(40, 241);
            this.grdEstaciones.Name = "grdEstaciones";
            this.grdEstaciones.ReadOnly = true;
            this.grdEstaciones.Size = new System.Drawing.Size(717, 141);
            this.grdEstaciones.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 225);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Estaciones Registradas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Empleados Registrados";
            // 
            // ordenDeCompraToolStripMenuItem
            // 
            this.ordenDeCompraToolStripMenuItem.Name = "ordenDeCompraToolStripMenuItem";
            this.ordenDeCompraToolStripMenuItem.Size = new System.Drawing.Size(114, 20);
            this.ordenDeCompraToolStripMenuItem.Text = "Orden de Compra";
            // 
            // ticketToolStripMenuItem
            // 
            this.ticketToolStripMenuItem.Name = "ticketToolStripMenuItem";
            this.ticketToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.ticketToolStripMenuItem.Text = "Ticket";
            // 
            // FormularioPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grdEstaciones);
            this.Controls.Add(this.grdEmpleados);
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
            ((System.ComponentModel.ISupportInitialize)(this.grdEmpleados)).EndInit();
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
        private System.Windows.Forms.DataGridView grdEmpleados;
        private System.Windows.Forms.DataGridView grdEstaciones;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripMenuItem agregarTipoCombustibleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarUnidadDeMedidaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarUrgenciaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aBMSurtidorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ordenDeCompraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ticketToolStripMenuItem;
    }
}