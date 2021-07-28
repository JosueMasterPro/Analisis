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
using FontAwesome.Sharp;

namespace Intelident
{
    public partial class Login : Form
    {

        private Form FormActual;
        public Login()
        {
            InitializeComponent();
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.textBox2.UseSystemPasswordChar = true;
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);


        public string userName { get ; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Celular { get; set; }
        public string Correo { get; set; }
      



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

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

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
            PanelMain.Controls.Add(FormHijo);
            PanelMain.Tag = FormHijo;
            FormHijo.BringToFront();
            FormHijo.Show();
        }


            private void iconButton1_Click(object sender, EventArgs e)
            {
            /*Conectar();

            SqlDataAdapter da = new SqlDataAdapter("SELECT COUNT(*) FROM ALogin WHERE Usuario='" + textBox1.Text + "'AND PWDCOMPARE('"+ textBox2.Text+"',contrasena)=1", Conectar());
            DataTable dt = new DataTable();
            da.Fill(dt);

            if (dt.Rows[0][0].ToString() == "1")
            {
                SqlCommand Comando = new SqlCommand("Select * from Alogin where Usuario=@Usuario",Conectar());
                Comando.Parameters.AddWithValue("@Usuario", textBox1.Text);
                SqlDataReader registro = Comando.ExecuteReader();

                if (registro.Read())
                {
                    Nombre = registro["Nombre"].ToString();
                    Apellido = registro["Apellido"].ToString();
                    Celular = registro["Celular"].ToString();
                    Correo = registro["Correo"].ToString();
                }
                userName = textBox1.Text;
                this.Hide();
                new Interfaz(userName,Nombre,Apellido,Celular,Correo).Show();
            }
            else
            {
                textBox1.Text = "";
                textBox2.Text = "";
                label3.Text = "Usuario o Contraseña Incorrecto";
            }*/
            this.Hide();
            new Interfaz().Show();
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            label3.Text = "";
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Ingreso().Show();
        }
    }
    
}
