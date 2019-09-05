namespace TP_PAV_3k2
{
    partial class FormularioABMSucursal
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
            this.fechaHabilitación = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCUIT = new System.Windows.Forms.TextBox();
            this.txtCalle = new System.Windows.Forms.TextBox();
            this.txtNumeroCalle = new System.Windows.Forms.TextBox();
            this.txtRazonSocial = new System.Windows.Forms.TextBox();
            this.bntAgregar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.grdEstaciones = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grdEstaciones)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // fechaHabilitación
            // 
            this.fechaHabilitación.Location = new System.Drawing.Point(115, 131);
            this.fechaHabilitación.MaxDate = new System.DateTime(2019, 8, 22, 0, 0, 0, 0);
            this.fechaHabilitación.Name = "fechaHabilitación";
            this.fechaHabilitación.Size = new System.Drawing.Size(200, 20);
            this.fechaHabilitación.TabIndex = 25;
            this.fechaHabilitación.Value = new System.DateTime(2019, 8, 22, 0, 0, 0, 0);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 137);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "Fecha Habilitacion";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "Número";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "Calle";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Razon Social";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "CUIT";
            // 
            // txtCUIT
            // 
            this.txtCUIT.Location = new System.Drawing.Point(115, 22);
            this.txtCUIT.MaxLength = 12;
            this.txtCUIT.Name = "txtCUIT";
            this.txtCUIT.Size = new System.Drawing.Size(200, 20);
            this.txtCUIT.TabIndex = 19;
            // 
            // txtCalle
            // 
            this.txtCalle.Location = new System.Drawing.Point(115, 74);
            this.txtCalle.MaxLength = 20;
            this.txtCalle.Name = "txtCalle";
            this.txtCalle.Size = new System.Drawing.Size(200, 20);
            this.txtCalle.TabIndex = 18;
            // 
            // txtNumeroCalle
            // 
            this.txtNumeroCalle.Location = new System.Drawing.Point(115, 100);
            this.txtNumeroCalle.MaxLength = 5;
            this.txtNumeroCalle.Name = "txtNumeroCalle";
            this.txtNumeroCalle.Size = new System.Drawing.Size(200, 20);
            this.txtNumeroCalle.TabIndex = 17;
            // 
            // txtRazonSocial
            // 
            this.txtRazonSocial.Location = new System.Drawing.Point(115, 48);
            this.txtRazonSocial.MaxLength = 20;
            this.txtRazonSocial.Name = "txtRazonSocial";
            this.txtRazonSocial.Size = new System.Drawing.Size(200, 20);
            this.txtRazonSocial.TabIndex = 16;
            // 
            // bntAgregar
            // 
            this.bntAgregar.Location = new System.Drawing.Point(93, 322);
            this.bntAgregar.Name = "bntAgregar";
            this.bntAgregar.Size = new System.Drawing.Size(75, 27);
            this.bntAgregar.TabIndex = 27;
            this.bntAgregar.Text = "Agregar";
            this.bntAgregar.UseVisualStyleBackColor = true;
            this.bntAgregar.Click += new System.EventHandler(this.BntAgregar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(259, 322);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 27);
            this.btnSalir.TabIndex = 26;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.Button1_Click);
            // 
            // grdEstaciones
            // 
            this.grdEstaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdEstaciones.Location = new System.Drawing.Point(377, 12);
            this.grdEstaciones.Name = "grdEstaciones";
            this.grdEstaciones.ReadOnly = true;
            this.grdEstaciones.Size = new System.Drawing.Size(395, 337);
            this.grdEstaciones.TabIndex = 28;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtRazonSocial);
            this.panel1.Controls.Add(this.txtNumeroCalle);
            this.panel1.Controls.Add(this.txtCalle);
            this.panel1.Controls.Add(this.fechaHabilitación);
            this.panel1.Controls.Add(this.txtCUIT);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(12, 53);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(322, 210);
            this.panel1.TabIndex = 29;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(178, 322);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 27);
            this.btnEliminar.TabIndex = 43;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(12, 322);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 27);
            this.btnModificar.TabIndex = 42;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.BtnModificar_Click);
            // 
            // FormularioABMSucursal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 361);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.grdEstaciones);
            this.Controls.Add(this.bntAgregar);
            this.Controls.Add(this.btnSalir);
            this.Name = "FormularioABMSucursal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administrar Estaciones de Servicio";
            this.Load += new System.EventHandler(this.AbmSucursales_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdEstaciones)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker fechaHabilitación;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCUIT;
        private System.Windows.Forms.TextBox txtCalle;
        private System.Windows.Forms.TextBox txtNumeroCalle;
        private System.Windows.Forms.TextBox txtRazonSocial;
        private System.Windows.Forms.Button bntAgregar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.DataGridView grdEstaciones;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnModificar;
    }
}