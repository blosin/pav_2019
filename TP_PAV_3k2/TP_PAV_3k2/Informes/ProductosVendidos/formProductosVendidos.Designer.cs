namespace TP_PAV_3k2.Informes.ProductosVendidos
{
    partial class formProductosVendidos
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.rvProductosVendidos = new Microsoft.Reporting.WinForms.ReportViewer();
            this.DatosProductosVendidos = new TP_PAV_3k2.Informes.ProductosVendidos.DatosProductosVendidos();
            this.ProductoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ProductoTableAdapter = new TP_PAV_3k2.Informes.ProductosVendidos.DatosProductosVendidosTableAdapters.ProductoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DatosProductosVendidos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // rvProductosVendidos
            // 
            this.rvProductosVendidos.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DatosProductosVendidos";
            reportDataSource1.Value = this.ProductoBindingSource;
            this.rvProductosVendidos.LocalReport.DataSources.Add(reportDataSource1);
            this.rvProductosVendidos.LocalReport.ReportEmbeddedResource = "TP_PAV_3k2.Informes.ProductosVendidos.InformeProductosvendidos.rdlc";
            this.rvProductosVendidos.Location = new System.Drawing.Point(0, 0);
            this.rvProductosVendidos.Name = "rvProductosVendidos";
            this.rvProductosVendidos.ServerReport.BearerToken = null;
            this.rvProductosVendidos.Size = new System.Drawing.Size(800, 450);
            this.rvProductosVendidos.TabIndex = 0;
            // 
            // DatosProductosVendidos
            // 
            this.DatosProductosVendidos.DataSetName = "DatosProductosVendidos";
            this.DatosProductosVendidos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ProductoBindingSource
            // 
            this.ProductoBindingSource.DataMember = "Producto";
            this.ProductoBindingSource.DataSource = this.DatosProductosVendidos;
            // 
            // ProductoTableAdapter
            // 
            this.ProductoTableAdapter.ClearBeforeFill = true;
            // 
            // formProductosVendidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rvProductosVendidos);
            this.Name = "formProductosVendidos";
            this.Text = "Productos vendidos";
            this.Load += new System.EventHandler(this.formProductosVendidos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DatosProductosVendidos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rvProductosVendidos;
        private System.Windows.Forms.BindingSource ProductoBindingSource;
        private DatosProductosVendidos DatosProductosVendidos;
        private DatosProductosVendidosTableAdapters.ProductoTableAdapter ProductoTableAdapter;
    }
}