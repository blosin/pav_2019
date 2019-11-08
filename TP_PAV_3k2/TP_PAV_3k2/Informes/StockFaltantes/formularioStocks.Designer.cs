namespace TP_PAV_3k2.Informes.StockFaltantes
{
    partial class formularioStocks
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
            this.rvStocks = new Microsoft.Reporting.WinForms.ReportViewer();
            this.DatosStockFaltantes = new TP_PAV_3k2.Informes.StockFaltantes.DatosStockFaltantes();
            this.ProductoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ProductoTableAdapter = new TP_PAV_3k2.Informes.StockFaltantes.DatosStockFaltantesTableAdapters.ProductoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DatosStockFaltantes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // rvStocks
            // 
            this.rvStocks.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "datosstock";
            reportDataSource1.Value = this.ProductoBindingSource;
            this.rvStocks.LocalReport.DataSources.Add(reportDataSource1);
            this.rvStocks.LocalReport.ReportEmbeddedResource = "TP_PAV_3k2.Informes.StockFaltantes.InformeStockFaltantes.rdlc";
            this.rvStocks.Location = new System.Drawing.Point(0, 0);
            this.rvStocks.Name = "rvStocks";
            this.rvStocks.ServerReport.BearerToken = null;
            this.rvStocks.Size = new System.Drawing.Size(800, 450);
            this.rvStocks.TabIndex = 0;
            // 
            // DatosStockFaltantes
            // 
            this.DatosStockFaltantes.DataSetName = "DatosStockFaltantes";
            this.DatosStockFaltantes.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ProductoBindingSource
            // 
            this.ProductoBindingSource.DataMember = "Producto";
            this.ProductoBindingSource.DataSource = this.DatosStockFaltantes;
            // 
            // ProductoTableAdapter
            // 
            this.ProductoTableAdapter.ClearBeforeFill = true;
            // 
            // formularioStocks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rvStocks);
            this.Name = "formularioStocks";
            this.Text = "Productos con stock faltante";
            this.Load += new System.EventHandler(this.formularioStocks_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DatosStockFaltantes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rvStocks;
        private System.Windows.Forms.BindingSource ProductoBindingSource;
        private DatosStockFaltantes DatosStockFaltantes;
        private DatosStockFaltantesTableAdapters.ProductoTableAdapter ProductoTableAdapter;
    }
}