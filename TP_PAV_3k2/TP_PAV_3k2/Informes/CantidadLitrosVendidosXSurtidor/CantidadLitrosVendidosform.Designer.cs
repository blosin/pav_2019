namespace TP_PAV_3k2.Informes.CantidadLitrosVendidosXSurtidor
{
    partial class CantidadLitrosVendidosform
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
            this.rvVentasXSurtidor = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // rvVentasXSurtidor
            // 
            this.rvVentasXSurtidor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rvVentasXSurtidor.Location = new System.Drawing.Point(0, 0);
            this.rvVentasXSurtidor.Name = "rvVentasXSurtidor";
            this.rvVentasXSurtidor.ServerReport.BearerToken = null;
            this.rvVentasXSurtidor.Size = new System.Drawing.Size(800, 450);
            this.rvVentasXSurtidor.TabIndex = 0;
            // 
            // CantidadLitrosVendidosform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rvVentasXSurtidor);
            this.Name = "CantidadLitrosVendidosform";
            this.Text = "Ventas por surtidor";
            this.Load += new System.EventHandler(this.CantidadLitrosVendidosform_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rvVentasXSurtidor;
    }
}