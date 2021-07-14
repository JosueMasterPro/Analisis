using Intelident.Reportes.BDReportesTableAdapters;
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
using System.Data.SqlClient;
using System.Data.Odbc;
using System.IO;

namespace Intelident
{
    public partial class RpVentas : Form
    {
        public RpVentas()
        {
            InitializeComponent();
            this.pBotones.Visible = false;
            EsconderPanel();
        }


        //Funciones
        public void EsconderMenu()
        {
            this.pOpciones.Visible = false;
            this.pBotones.Visible = true;
        }
        public void EsconderPanel()
        {
            pRpInv.Visible = false;
            pRpVentas.Visible = false;
            pRPaverias.Visible= false;
            pRpPxM.Visible = false;
            pMantenimiento.Visible = false;
        }
        private string retorno()
        {
            string C;
            if (textBox1.Text == "")
            {
               C = " ";
            }
            else
            {
                C = textBox1.Text;
            }
            return C;
        }
        //Fin de Funciones

        private void RpVentas_Load(object sender, EventArgs e)
        {
        }
        private void BtnBasedeDatos_Click(object sender, EventArgs e)
        {
            EsconderMenu();
            pRpVentas.Visible = true;
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            EsconderMenu();
            pRpInv.Visible = true;
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            EsconderMenu();
            pRPaverias.Visible = true;
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            EsconderMenu();
            pRpPxM.Visible = true;
        }

        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {
            EsconderMenu();
            pMantenimiento.Visible = true;
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuFlatButton6_Click(object sender, EventArgs e)
        {
            this.pBotones.Visible = false;
            this.pOpciones.Visible = true;
            EsconderPanel();
        }

        private void bunifuFlatButton7_Click(object sender, EventArgs e)
        {
            //Reprote de ventas
            string relativpath = "../../Reportes/RpVentas.rdlc";
            this.reportViewer1.LocalReport.DataSources.Clear();
            ReportDataSource rds = new ReportDataSource("DataSetVentas", bindingSourceVentas);
            this.spVentasTableAdapter.Fill(this.bdReportes.spVentas);
            this.reportViewer1.LocalReport.DataSources.Add(rds);
            this.reportViewer1.LocalReport.ReportPath = Path.GetFullPath(relativpath);
            this.reportViewer1.LocalReport.Refresh();
            this.reportViewer1.RefreshReport();
        }

        private void bunifuFlatButton8_Click(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'bdReportes1.Averia' Puede moverla o quitarla según sea necesario.
            this.spRpInventarioTableAdapter.Fill(this.bdReportes.spRpInventario);
            string relativpath = "../../Reportes/RpInventario.rdlc";
            reportViewer1.LocalReport.DataSources.Clear();
            ReportDataSource rds = new ReportDataSource("DataSetInventario", bindingSourceinv);
            reportViewer1.LocalReport.DataSources.Add(rds);
            this.reportViewer1.LocalReport.ReportPath = this.reportViewer1.LocalReport.ReportPath = Path.GetFullPath(relativpath);
            reportViewer1.LocalReport.Refresh();
            this.reportViewer1.RefreshReport();
        }

        private void bunifuFlatButton9_Click(object sender, EventArgs e)
        {
            this.reportViewer1.LocalReport.DataSources.Clear();
            string relativpath = "../../Reportes/averias.rdlc";
            this.spMaquinaAveriaTableAdapter.Fill(this.bdReportes.spMaquinaAveria);
            ReportDataSource rds = new ReportDataSource("DataSetAverias", bindingSourceAverias);
            this.reportViewer1.LocalReport.DataSources.Add(rds);
            this.reportViewer1.LocalReport.ReportPath = this.reportViewer1.LocalReport.ReportPath = Path.GetFullPath(relativpath);
            this.reportViewer1.LocalReport.Refresh();
            this.reportViewer1.RefreshReport();
        }

        private void bunifuFlatButton12_Click(object sender, EventArgs e)
        {
            this.reportViewer1.LocalReport.DataSources.Clear();
            string relativpath = "../../Reportes/RpDetalleAveria.rdlc";
            this.spAveriaDetalladaTableAdapter.Fill(this.bdReportes.spAveriaDetallada);
            ReportDataSource rds = new ReportDataSource("DataSetADetallado", bindingSourceRDetallado);
            this.reportViewer1.LocalReport.DataSources.Add(rds);
            this.reportViewer1.LocalReport.ReportPath = this.reportViewer1.LocalReport.ReportPath = Path.GetFullPath(relativpath);
            this.reportViewer1.LocalReport.Refresh();
            this.reportViewer1.RefreshReport();
        }

        private void bunifuFlatButton13_Click(object sender, EventArgs e)
        {
            this.reportViewer1.LocalReport.DataSources.Clear();
            string relativpath = "../../Reportes/RpAComunes.rdlc";
            ReportDataSource rds = new ReportDataSource("DataSetAComunes", bindingSourceAComunes);
            this.spAveriaMaquinaTableAdapter.Fill(this.bdReportes.spAveriaMaquina);
            this.reportViewer1.LocalReport.DataSources.Add(rds);
            this.reportViewer1.LocalReport.ReportPath = this.reportViewer1.LocalReport.ReportPath = Path.GetFullPath(relativpath);
            this.reportViewer1.LocalReport.Refresh();
            this.reportViewer1.RefreshReport();
        }

        private void bunifuFlatButton10_Click(object sender, EventArgs e)
        {
            this.reportViewer1.LocalReport.DataSources.Clear();
            string relativpath = "../../Reportes/PxM.rdlc";
            ReportDataSource rds = new ReportDataSource("DataSetPxM", bindingSourcePxM);
            this.spInventarioPiezaMaquinaTableAdapter.Fill(this.bdReportes.spInventarioPiezaMaquina);
            this.reportViewer1.LocalReport.DataSources.Add(rds);
            this.reportViewer1.LocalReport.ReportPath = this.reportViewer1.LocalReport.ReportPath = Path.GetFullPath(relativpath);
            this.reportViewer1.LocalReport.Refresh();
            this.reportViewer1.RefreshReport();
        }

        private void bunifuFlatButton14_Click(object sender, EventArgs e)
        {
            this.reportViewer1.LocalReport.DataSources.Clear();
            string relativpath = "../../Reportes/RpEGMaquinas.rdlc";
            ReportDataSource rds = new ReportDataSource("DataSetMaqLugar", bindingSourceGMaquina);
            this.spAveriaMaquinaLugarTableAdapter.Fill(this.bdReportes.spAveriaMaquinaLugar);
            this.reportViewer1.LocalReport.DataSources.Add(rds);
            this.reportViewer1.LocalReport.ReportPath = this.reportViewer1.LocalReport.ReportPath = Path.GetFullPath(relativpath);
            this.reportViewer1.LocalReport.Refresh();
            this.reportViewer1.RefreshReport();
        }

        private void bunifuFlatButton11_Click(object sender, EventArgs e)
        {
            this.reportViewer1.LocalReport.DataSources.Clear();
            string relativpath = "../../Reportes/RpMDetallado.rdlc";
            ReportDataSource rds = new ReportDataSource("DataSetMDetallado", bindingSourceMantenimiento);
            this.spMantenimientoSemanalDetalladoTableAdapter.Fill(this.bdReportes.spMantenimientoSemanalDetallado);
            this.reportViewer1.LocalReport.DataSources.Add(rds);
            this.reportViewer1.LocalReport.ReportPath = this.reportViewer1.LocalReport.ReportPath = Path.GetFullPath(relativpath);
            this.reportViewer1.LocalReport.Refresh();
            this.reportViewer1.RefreshReport();
        }

        private void bunifuFlatButton15_Click(object sender, EventArgs e)
        {
            this.reportViewer1.LocalReport.DataSources.Clear();
            string relativpath = "../../Reportes/RpEstadodetMaquina.rdlc";
            ReportDataSource rds = new ReportDataSource("DataSetDetalladoM", bindingSourceDMantenimiento);
            this.spDetalladoTableAdapter.Fill(this.bdReportes.spDetallado);
            this.reportViewer1.LocalReport.DataSources.Add(rds);
            this.reportViewer1.LocalReport.ReportPath = this.reportViewer1.LocalReport.ReportPath = Path.GetFullPath(relativpath);
            this.reportViewer1.LocalReport.Refresh();
            this.reportViewer1.RefreshReport();
        }

        private void bunifuFlatButton16_Click(object sender, EventArgs e)
        {
            this.reportViewer1.LocalReport.DataSources.Clear();
            string relativpath = "../../Reportes/RpMporTecnico.rdlc";
            ReportDataSource rds = new ReportDataSource("DataSetMporTec", bindingSourceTecnico);
            this.spMantenimientoTableAdapter.Fill(this.bdReportes.spMantenimiento);
            this.reportViewer1.LocalReport.DataSources.Add(rds);
            this.reportViewer1.LocalReport.ReportPath = this.reportViewer1.LocalReport.ReportPath = Path.GetFullPath(relativpath);
            this.reportViewer1.LocalReport.Refresh();
            this.reportViewer1.RefreshReport();
        }

        
    }
}
