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
using System.IO;

namespace Intelident
{
    public partial class Ingreso : Form
    {

        public Ingreso()
        {
            Font = SystemFonts.MessageBoxFont;
            InitializeComponent();
            this.TxtContraseña.UseSystemPasswordChar = true;
            this.TxtConfirmarContra.UseSystemPasswordChar = true;
        }
        private void Limpiar()
        {
            TxtUsuario.Text = "";
            TxtContraseña.Text = "";
            TxtConfirmarContra.Text = "";
            TxtCorreo.Text = "";
            TxtNombre.Text = "";
            TxtApellido.Text = "";
            TxtCelular.Text = "";
            TxtCorreo.Text = "";
            TxtImagen.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (TxtContraseña.Text == TxtConfirmarContra.Text & TxtUsuario.Text!="" & TxtContraseña.Text != "" & TxtNombre.Text != "" & TxtApellido.Text != "" & TxtCelular.Text != "" & TxtCorreo.Text != "" & TxtImagen.Text != "")
            {
                byte[] data = System.IO.File.ReadAllBytes(TxtImagen.Text);
                string qry = "insert into Alogin (Usuario,contrasena,nombre,apellido,celular,correo, imagen ) values (@Usuario, PWDENCRYPT(@Contrasena),@Nombre,@Apellido,@Celular,@correo,@Imagen)";

                try
                {
                    // Inicializa el objeto SqlCommand
                    SqlCommand SqlCom = new SqlCommand(qry, Conectar());

                    // Se agrega la información como parámetros
                    SqlCom.Parameters.Add(new SqlParameter("@Usuario", TxtUsuario.Text));
                    SqlCom.Parameters.Add(new SqlParameter("@Contrasena", TxtContraseña.Text));
                    SqlCom.Parameters.Add(new SqlParameter("@Nombre", TxtNombre.Text));
                    SqlCom.Parameters.Add(new SqlParameter("@Apellido", TxtApellido.Text));
                    SqlCom.Parameters.Add(new SqlParameter("@Celular", TxtCelular.Text));
                    SqlCom.Parameters.Add(new SqlParameter("@Correo", TxtCorreo.Text));
                    SqlCom.Parameters.Add(new SqlParameter("@Imagen", data));


                    // Abrir la conexión y ejecutar el query
                    Conectar();
                    SqlCom.ExecuteNonQuery();

                    // Mostrar un mensaje de confirmación
                    MessageBox.Show("Usuario Guardado correctamente", "Guardar Nota", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                Limpiar();
            }
            else
            {
                if(TxtUsuario.Text == "" || TxtContraseña.Text == "" || TxtNombre.Text == "" || TxtApellido.Text == "" || TxtCelular.Text == "" || TxtCorreo.Text == "" || TxtImagen.Text == "")
                {
                    label1.Text = "Debe Llenar Todos los campos";
                }
                else
                {
                    label1.Text = "la contraseña no coincide";
                }
                
            }
            
        }
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

        private void btnBuscarArchivo_Click(object sender, EventArgs e)
        {
            DialogResult r = dlgImagen.ShowDialog();
            if (r == DialogResult.OK)
            {
                TxtImagen.Text = dlgImagen.FileName;
                pictureBox1.Load(TxtImagen.Text);
            }
        }

        private void LbConfirmarContra_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TxtUsuario_TextChanged(object sender, EventArgs e)
        {
            label1.Text = "";
        }
    }
}
