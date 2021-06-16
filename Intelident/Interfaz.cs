using FontAwesome.Sharp;
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


        //fields
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        private Form FormActual;
        public string NombreUsuario;
        public string ApellidoUsuario;
        public string CelularUsuario;
        public string CorreoUsuario;

        public static SqlConnection Conectar()
        {
            SqlConnection cn = new SqlConnection("data source = LAPTOP-MTHU4RQT; initial catalog = ClasePruebaBD2; user id = JosueReyes; password = Caracoles1412");

            cn.Open();
            return cn;

        }
        public static SqlConnection Cerrrar()
        {
            SqlConnection cn = new SqlConnection("data source = LAPTOP-MTHU4RQT; initial catalog = ClasePruebaBD2; user id = JosueReyes; password = Caracoles1412");
            cn.Close();
            return cn;
        }

        //Constructor
        public Interfaz(string userName, string Nombre, string Apellido,string Celular, string correo )
        {
            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 60);
            PanelMenu.Controls.Add(leftBorderBtn);
            //form
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.label1.Text = userName;
            NombreUsuario = Nombre;
            ApellidoUsuario = Apellido;
            CelularUsuario = Celular;
            CorreoUsuario = correo;
            this.label2.Text = NombreUsuario  + " " + ApellidoUsuario ;
            this.label3.Text = CorreoUsuario;
            buscar(userName);


        }
        private struct RGBColors
        {
            public static Color color1 = Color.FromArgb(172, 126, 241);
            public static Color color2 = Color.FromArgb(249, 118, 176);
            public static Color color3 = Color.FromArgb(253, 138, 114);
            public static Color color4 = Color.FromArgb(95, 77, 221);
            public static Color color5 = Color.FromArgb(249, 88, 155);
            public static Color color6 = Color.FromArgb(24, 161, 251);
        }
        private void ActivarBoton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DesactivarBoton();
                //Personalizacion del Boton
                //Boton
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(37, 36, 81);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;
                //Borde Izquierdo del boton
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();
                leftBorderBtn.BringToFront();
                //Editar el menu de barra
                iconCurrent.IconChar = currentBtn.IconChar;
                iconCurrent.IconColor = color;
            }
        }

        private void DesactivarBoton()
        {
            if (currentBtn != null)
            {
                //Boton
                currentBtn.BackColor = Color.FromArgb(31, 30, 68);
                currentBtn.ForeColor = Color.White;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.White;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;

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

        private void BtnInicio_Click(object sender, EventArgs e)
        {
           FormActual.Close();
            Reset();
        }

        private void Reset()
        {
            DesactivarBoton();
            leftBorderBtn.Visible = false;
            iconCurrent.IconChar = IconChar.HouseUser;
            iconCurrent.IconColor = Color.MediumPurple;
            Labelinicio.Text = "Inicio";
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            ActivarBoton(sender, RGBColors.color1);
            //Agregar formulario y enviarloselo al openForm
            //OpenForm(new BasedeDatos());
            //nota importante, al crear el form debemos darle la propiedad que siempre este centrado asi se movera con la app
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            ActivarBoton(sender, RGBColors.color2);
            OpenForm(new Inventario());
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            ActivarBoton(sender, RGBColors.color3);
        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
            ActivarBoton(sender, RGBColors.color4);
        }

        private void iconButton5_Click(object sender, EventArgs e)
        {
            ActivarBoton(sender, RGBColors.color5);
        }

        private void iconButton6_Click(object sender, EventArgs e)
        {
            ActivarBoton(sender, RGBColors.color6);
        }

        private void iconPictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 main = new Form1();
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

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void PanelBarra_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
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
                    byte[]imgData  = (byte[])rdr.GetValue(0);

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

        private void iconPictureBox4_Click(object sender, EventArgs e)
        {
            FormActual.Close();
            Reset();
        }
    }
}
