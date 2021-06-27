
namespace Intelident
{
    partial class RpVentas
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer2 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.reportes1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportes1 = new Intelident.Reportes.Reportes();
            this.rpVentaTableAdapter1 = new Intelident.Reportes.ReportesTableAdapters.RpVentaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportes1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportes1)).BeginInit();
            this.SuspendLayout();
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataMember = "RPVenta";
            this.bindingSource1.DataSource = this.reportes1BindingSource;
            // 
            // reportViewer2
            // 
            this.reportViewer2.Dock = System.Windows.Forms.DockStyle.Right;
            reportDataSource2.Name = "RpPrueba";
            reportDataSource2.Value = this.bindingSource1;
            this.reportViewer2.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer2.LocalReport.ReportEmbeddedResource = "Intelident.Reportes.RpVentasMensual.rdlc";
            this.reportViewer2.Location = new System.Drawing.Point(231, 0);
            this.reportViewer2.Name = "reportViewer2";
            this.reportViewer2.ServerReport.BearerToken = null;
            this.reportViewer2.Size = new System.Drawing.Size(1030, 807);
            this.reportViewer2.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(225, 807);
            this.panel1.TabIndex = 1;
            // 
            // reportes1BindingSource
            // 
            this.reportes1BindingSource.DataSource = this.reportes1;
            this.reportes1BindingSource.Position = 0;
            // 
            // reportes1
            // 
            this.reportes1.DataSetName = "Reportes";
            this.reportes1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rpVentaTableAdapter1
            // 
            this.rpVentaTableAdapter1.ClearBeforeFill = true;
            // 
            // RpVentas
            // 
            this.ClientSize = new System.Drawing.Size(1261, 807);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.reportViewer2);
            this.Name = "RpVentas";
            this.Load += new System.EventHandler(this.RpVentas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportes1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportes1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private Reportes.Reportes reportes;
        private System.Windows.Forms.BindingSource rPVentaBindingSource;
        private Reportes.ReportesTableAdapters.RpVentaTableAdapter rpVentaTableAdapter;
        private System.Windows.Forms.BindingSource rPVentaBindingSource1;
        private System.Windows.Forms.BindingSource vTotalCompraVentasBindingSource;
        private System.Windows.Forms.BindingSource vTotalCompraVentasBindingSource1;
        private System.Windows.Forms.BindingSource reportes1BindingSource;
        private Reportes.Reportes reportes1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer2;
        private System.Windows.Forms.BindingSource bindingSource1;
        private Reportes.ReportesTableAdapters.RpVentaTableAdapter rpVentaTableAdapter1;
        private System.Windows.Forms.Panel panel1;
    }
}