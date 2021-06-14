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


namespace Intelident
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        public static SqlConnection Conectar()
        {
            SqlConnection cn = new SqlConnection("data source = LAPTOP-MTHU4RQT; initial catalog = ClasePruebaBD2; user id = JosueReyes; password = Caracoles1412");

            cn.Open();
            return cn;

        }


        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            Conectar();

            SqlDataAdapter da = new SqlDataAdapter("SELECT COUNT(*) FROM ALogin WHERE Usuario='" + textBox1.Text + "'AND PWDCOMPARE('"+ textBox2.Text+"',contrasena)=1", Conectar());
            DataTable dt = new DataTable();
            da.Fill(dt);

            if (dt.Rows[0][0].ToString() == "1")
            {
                MessageBox.Show("Acceso Concedido");
                this.Hide();
                new Interfaz().Show();
                

            }
            else
            {
                MessageBox.Show("Acceso Denegado");
            }
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
    
}
