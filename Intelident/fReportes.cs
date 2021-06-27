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
    public partial class fReportes : Form
    {
        public fReportes()
        {
            InitializeComponent();
        }

        private void BtnReporte_Click(object sender, EventArgs e)
        {
            RpVentas Reporte = new RpVentas();
            Reporte.Show();
           
        }
    }
}
