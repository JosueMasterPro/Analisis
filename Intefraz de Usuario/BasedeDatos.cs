using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;
using System.Data.Sql;
using System.Data.SqlClient;

namespace Intefraz_de_Usuario
{
    public partial class BasedeDatos : Form
    {
        //Cadena de Conexion
        string cadena = "data source = LAPTOP-MTHU4RQT; initial catalog = ClasePruebaBD2; user id = JosueReyes; password = Caracoles1412";
        public SqlConnection Conexion = new SqlConnection();
        SqlCommand Comando;
        public BasedeDatos()
        {
            InitializeComponent();
            Conexion.ConnectionString = cadena;
        }

        private void BasedeDatos_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "Boton Funciona";
            try
            {
                Conexion.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se Abrio La Base" + ex);
            }
            try 
            {
                
                Comando = new SqlCommand("use ClasePruebaBD2; Insert Into tipo values('5','Lujos',4)");
                Comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se Ejecuto El Querry" + ex);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = "Base Desconectada";
            cerrar();
        }
        public void abrir()
        {
            try
            {
                Conexion.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se se abrio la base de datos");
            }
        }

        //Metodo para cerrar la conexion
        public void cerrar()
        {
            Conexion.Close();
        }
    }
}
