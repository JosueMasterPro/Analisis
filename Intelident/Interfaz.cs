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
    public partial class Interfaz : Form
    {
        public Interfaz()
        {
            InitializeComponent();
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        /*Funciones*/
        //Variables
        private Form FormActual;
        private void OpenForm(Form FormHijo)
        {
            if (FormActual != null)
            {
                //Mantener un solo form
                FormActual.Close();
            }
            FormActual = FormHijo;
            FormHijo.TopLevel = false;
            FormHijo.FormBorderStyle = FormBorderStyle.None;
            FormHijo.Dock = DockStyle.Fill;
            PanelVisual.Controls.Add(FormHijo);
            PanelVisual.Tag = FormHijo;
            FormHijo.BringToFront();
            FormHijo.Show();
           //Labelinicio.Text = FormHijo.Text;
        }


        public void EsconderTexto()
        {
            BtnReportes.Text = "";
        }
        public void MostrarTexto()
        {
            BtnReportes.Text = "Reportes";
        }


        /*Fin de Funciones*/

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
            Login main = new Login();
            main.Show();
        }

        private void BtnMenu_Click(object sender, EventArgs e)
        {
            if (PMenu.Width == 100)
            {
                MostrarTexto();
                pictureLogo.Visible = true;
                PMenu.Visible = false;
                PMenu.Width = 320;
                PanelA.ShowSync(PMenu);
                LogoA.ShowSync(pictureLogo);
            }
            else
            {

                LogoA.HideSync(pictureLogo);
                PMenu.Visible = false;
                PMenu.Width = 100;
                PanelA.ShowSync(PMenu);
                EsconderTexto();
            }
        }

        private void BtnReportes_Click(object sender, EventArgs e)
        {

        }

        private void BtnReportes_Click_1(object sender, EventArgs e)
        {
            OpenForm(new RpVentas());
        }
    }
}
