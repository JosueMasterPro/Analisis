using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Intelident
{
    public partial class Prueba : Form
    {
        public Prueba()
        {
            InitializeComponent();
        }

        private void Prueba_Load(object sender, EventArgs e)
        {
            this.spRpInventarioTableAdapter.Fill(this.bdReportes.spRpInventario);
            reportViewer1.LocalReport.DataSources.Clear();
            ReportDataSource rds = new ReportDataSource("DataSetInventario", bindingSourceinv);
            reportViewer1.LocalReport.DataSources.Add(rds);
            reportViewer1.LocalReport.ReportPath = "C:\\Users\\Josue Reyes\\source\\repos\\JosueMasterPro\\Analisis\\Intelident\\Reportes\\RpInventario.rdlc";
            this.reportViewer1.RefreshReport();  
        }
    }
}
