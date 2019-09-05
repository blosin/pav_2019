namespace TP_PAV_3k2
{
    partial class FormularioABMEmpleado
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
            this.label8 = new System.Windows.Forms.Label();
            this.dateFechaAlta = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dateFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbTipoDoc = new System.Windows.Forms.ComboBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtLegajo = new System.Windows.Forms.TextBox();
            this.bntAgregar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.grdEmpleados = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grdEmpleados)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 84);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(101, 13);
            this.label8.TabIndex = 35;
            this.label8.Text = "Tipo de Documento";
            // 
            // dateFechaAlta
            // 
            this.dateFechaAlta.Location = new System.Drawing.Point(109, 160);
            this.dateFechaAlta.Name = "dateFechaAlta";
            this.dateFechaAlta.Size = new System.Drawing.Size(200, 20);
            this.dateFechaAlta.TabIndex = 34;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 189);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 13);
            this.label7.TabIndex = 33;
            this.label7.Text = "Legajo Superior";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 166);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 32;
            this.label6.Text = "Fecha Alta";
            // 
            // dateFechaNacimiento
            // 
            this.dateFechaNacimiento.Location = new System.Drawing.Point(109, 134);
            this.dateFechaNacimiento.MaxDate = new System.DateTime(2019, 8, 21, 0, 0, 0, 0);
            this.dateFechaNacimiento.Name = "dateFechaNacimiento";
            this.dateFechaNacimiento.Size = new System.Drawing.Size(200, 20);
            this.dateFechaNacimiento.TabIndex = 31;
            this.dateFechaNacimiento.Value = new System.DateTime(2019, 8, 21, 0, 0, 0, 0);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 140);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 13);
            this.label5.TabIndex = 30;
            this.label5.Text = "Fecha Nacimiento";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 29;
            this.label4.Text = "Número";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 28;
            this.label3.Text = "Apellido";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 27;
            this.label2.Text = "Nombre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "Legajo";
            // 
            // cmbTipoDoc
            // 
            this.cmbTipoDoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoDoc.FormattingEnabled = true;
            this.cmbTipoDoc.Location = new System.Drawing.Point(156, 81);
            this.cmbTipoDoc.Name = "cmbTipoDoc";
            this.cmbTipoDoc.Size = new System.Drawing.Size(153, 21);
            this.cmbTipoDoc.TabIndex = 25;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(109, 55);
            this.txtApellido.MaxLength = 15;
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(200, 20);
            this.txtApellido.TabIndex = 24;
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(109, 108);
            this.txtNumero.MaxLength = 10;
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(200, 20);
            this.txtNumero.TabIndex = 23;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(109, 29);
            this.txtNombre.MaxLength = 15;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(200, 20);
            this.txtNombre.TabIndex = 22;
            // 
            // txtLegajo
            // 
            this.txtLegajo.Location = new System.Drawing.Point(109, 3);
            this.txtLegajo.MaxLength = 8;
            this.txtLegajo.Name = "txtLegajo";
            this.txtLegajo.Size = new System.Drawing.Size(200, 20);
            this.txtLegajo.TabIndex = 21;
            // 
            // bntAgregar
            // 
            this.bntAgregar.Location = new System.Drawing.Point(93, 322);
            this.bntAgregar.Name = "bntAgregar";
            this.bntAgregar.Size = new System.Drawing.Size(75, 27);
            this.bntAgregar.TabIndex = 20;
            this.bntAgregar.Text = "Agregar";
            this.bntAgregar.UseVisualStyleBackColor = true;
            this.bntAgregar.Click += new System.EventHandler(this.BntAgregar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(255, 322);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 27);
            this.btnSalir.TabIndex = 19;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // grdEmpleados
            // 
            this.grdEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdEmpleados.Location = new System.Drawing.Point(377, 12);
            this.grdEmpleados.Name = "grdEmpleados";
            this.grdEmpleados.ReadOnly = true;
            this.grdEmpleados.Size = new System.Drawing.Size(395, 337);
            this.grdEmpleados.TabIndex = 36;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtLegajo);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.txtNombre);
            this.panel1.Controls.Add(this.dateFechaAlta);
            this.panel1.Controls.Add(this.txtNumero);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.txtApellido);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.cmbTipoDoc);
            this.panel1.Controls.Add(this.dateFechaNacimiento);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(12, 53);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(322, 210);
            this.panel1.TabIndex = 37;
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(12, 322);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 27);
            this.btnModificar.TabIndex = 38;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.BtnModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(174, 322);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 27);
            this.btnEliminar.TabIndex = 39;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // FormularioABMEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 361);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.grdEmpleados);
            this.Controls.Add(this.bntAgregar);
            this.Controls.Add(this.btnSalir);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FormularioABMEmpleado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administrar Empleado";
            this.Load += new System.EventHandler(this.AbmEmpleado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdEmpleados)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dateFechaAlta;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dateFechaNacimiento;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbTipoDoc;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtLegajo;
        private System.Windows.Forms.Button bntAgregar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.DataGridView grdEmpleados;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
    }
}