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
    public partial class fMainHome : Form
    {


        //fields
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        private Form FormActual;
        public string Usuario;
        public string NombreUsuario;
        public string ApellidoUsuario;
        public string CelularUsuario;
        public string CorreoUsuario;


  

        //Constructor
        public fMainHome(string userName )
        {
            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 60);
            panelMenuMain.Controls.Add(leftBorderBtn);
            //form
            //this.BackColor = Color.Red;
            //panelFMainHome.Location = new Point(5, 5);
            //panelFMainHome.BackColor = Color.Green;
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.labelUser.Text = userName;



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
                iconCurrentForm.IconChar = currentBtn.IconChar;
                iconCurrentForm.IconColor = color;
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
            panelFMainHome.Controls.Add(FormHijo);
            panelFMainHome.Tag = FormHijo;
            FormHijo.BringToFront();
            FormHijo.Show();
            labelCurrentForm.Text = FormHijo.Text;

        }



        private void Reset()
        {
            DesactivarBoton();
            leftBorderBtn.Visible = false;
            iconCurrentForm.IconChar = IconChar.HouseUser;
            iconCurrentForm.IconColor = Color.MediumPurple;
            labelCurrentForm.Text = "Inicio";
        }

       //nota importante, al crear el form debemos darle la propiedad que siempre este centrado asi se movera con la app
 



        //Revisar draw form option

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void PanelBarra_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

   
        //Revisar metodo
        private void panelMenuMain_Paint(object sender, PaintEventArgs e)
        {

        }
// State Buttons
        private void iconPictureBoxCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
            fLogin main = new fLogin();
            main.Show();
        }
        private void iconPictureMinimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void iconPictureBoxMaximizar_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                WindowState = FormWindowState.Maximized;
            else
                WindowState = FormWindowState.Normal;
        }

        //Forms Child

        private void iconButtonHome_Click(object sender, EventArgs e)
        {
            ActivarBoton(sender, RGBColors.color1);
            if (FormActual != null) 
                 FormActual.Close();
            Reset();
        }

        private void iconButtonInventario_Click(object sender, EventArgs e)
        {
            ActivarBoton(sender, RGBColors.color2);
            OpenForm(new fInventario());
        }

        private void iconButtonRDiario_Click(object sender, EventArgs e)
        {
            ActivarBoton(sender, RGBColors.color3);
            OpenForm(new fRDiario());
        }

        private void iconButtonRAverias_Click(object sender, EventArgs e)
        {
            ActivarBoton(sender, RGBColors.color4);
            OpenForm(new fRAverias());
        }

        private void iconButtonReportes_Click(object sender, EventArgs e)
        {
            ActivarBoton(sender, RGBColors.color5);
            OpenForm(new fReportes());
        }

        private void iconButtonConfiguracion_Click(object sender, EventArgs e)
        {
            ActivarBoton(sender, RGBColors.color6);
        }
    }
}
