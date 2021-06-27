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
    public partial class RpVentas : Form
    {
        public RpVentas()
        {
            InitializeComponent();
        }

        private void RpVentas_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'reportes1.RPVenta' Puede moverla o quitarla según sea necesario.
            this.rpVentaTableAdapter1.Fill(this.reportes1.RPVenta);

            this.reportViewer2.RefreshReport();
        }
    }
}
