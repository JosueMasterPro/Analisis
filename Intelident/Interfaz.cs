using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Data.SqlClient;
using System.IO;

namespace Intelident
{
    public partial class Interfaz : Form
    {
        //Constructor
        public Interfaz(/*string userName, string Nombre, string Apellido,string Celular, string correo */)
        {
            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 60);
            PanelMenu.Controls.Add(leftBorderBtn);

            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            //this.label1.Text = userName;
            //this.label1.Text = userName;
            //NombreUsuario = Nombre;
            //ApellidoUsuario = Apellido;
            //CelularUsuario = Celular;
            //CorreoUsuario = correo;
            //this.label2.Text = NombreUsuario;
            //this.label3.Text = ApellidoUsuario;
            //buscar(userName);

        }
        /*Funciones*/
        //fields
        private Panel leftBorderBtn;
        private Form FormActual;
        public string NombreUsuario;
        public string ApellidoUsuario;
        public string CelularUsuario;
        public string CorreoUsuario;
        public static SqlConnection Conectar()
        {
            SqlConnection cn = new SqlConnection("data source = LAPTOP-MTHU4RQT; initial catalog = Proyecto; user id = JosueReyes; password = Caracoles1412");
            cn.Open();
            return cn;
        }
        public static SqlConnection Cerrrar()
        {
            SqlConnection cn = new SqlConnection("data source = LAPTOP-MTHU4RQT; initial catalog = Proyecto; user id = JosueReyes; password = Caracoles1412");
            cn.Close();
            return cn;
        }
        public void buscar(string Username)
        {
            string qry = "select Imagen from Alogin where Usuario = @Usuario";
            try
            {
                // Inicializa el objeto SqlCommand
                SqlCommand SqlCom = new SqlCommand(qry, Conectar());

                // Se agrega la información de búsqueda con parámetros
                SqlCom.Parameters.Add(new SqlParameter("@Usuario", Username));

                // Abre la conexión y ejecutar el query
                Conectar();
                SqlDataReader rdr = SqlCom.ExecuteReader();

                Image newImage = null;

                if (rdr.Read())
                {
                    // Obtiene los resultados de la búsqueda
                    byte[] imgData = (byte[])rdr.GetValue(0);

                    // Trata la información de la imagen para poder trasladarla al picturebox
                    using (MemoryStream ms = new MemoryStream(imgData, 0, imgData.Length))
                    {
                        ms.Write(imgData, 0, imgData.Length);
                        newImage = Image.FromStream(ms, true);
                    }

                    pictureBox1.Image = newImage;
                    newImage = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                // Cerrar la conexión si esta se encuentra abierta
                if (Conectar().State == ConnectionState.Open)
                    Cerrrar();
            }
        }

        //Abrir Forms
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
            Labelinicio.Text = FormHijo.Text;
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        /*Fin de Funciones*/



        private void BtnInicio_Click(object sender, EventArgs e)
        {
            if (FormActual != null)
            {
                FormActual.Close();
            }

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            //Agregar formulario y enviarloselo al openForm
            OpenForm(new RpVentas());
            //nota importante, al crear el form debemos darle la propiedad que siempre este centrado asi se movera con la app
        }

        private void iconPictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
            Login main = new Login();
            main.Show();
        }

        private void iconPictureBox2_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                WindowState = FormWindowState.Maximized;
            else
                WindowState = FormWindowState.Normal;
        }

        private void iconPictureBox3_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void BtnReportes_Click(object sender, EventArgs e)
        {
            OpenForm(new RpVentas());
            this.PanelMenu.Visible = false;
        }

        private void Logo_Click(object sender, EventArgs e)
        {
            this.PanelMenu.Visible = true;
        }
    }
}
