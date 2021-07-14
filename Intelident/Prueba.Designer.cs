
namespace Intelident
{
    partial class Prueba
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.bdReportes = new Intelident.Reportes.BDReportes();
            this.bindingSourceinv = new System.Windows.Forms.BindingSource(this.components);
            this.spRpInventarioTableAdapter = new Intelident.Reportes.BDReportesTableAdapters.spRpInventarioTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.bdReportes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceinv)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Intelident.Reportes.RpInventario.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1227, 710);
            this.reportViewer1.TabIndex = 0;
            // 
            // bdReportes
            // 
            this.bdReportes.DataSetName = "BDReportes";
            this.bdReportes.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bindingSourceinv
            // 
            this.bindingSourceinv.DataMember = "spRpInventario";
            this.bindingSourceinv.DataSource = this.bdReportes;
            // 
            // spRpInventarioTableAdapter
            // 
            this.spRpInventarioTableAdapter.ClearBeforeFill = true;
            // 
            // Prueba
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1227, 710);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Prueba";
            this.Text = "Prueba";
            this.Load += new System.EventHandler(this.Prueba_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bdReportes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceinv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private Reportes.BDReportes bdReportes;
        private System.Windows.Forms.BindingSource bindingSourceinv;
        private Reportes.BDReportesTableAdapters.spRpInventarioTableAdapter spRpInventarioTableAdapter;
    }
}