using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Ingeneria_Software_II
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {;

            string query = $"SELECT COUNT(*) FROM usuario WHERE cedula = {txtUsuario.Text} AND contrasena = '{txtContrasena.Text}'";
            MySqlConnection conexionBD = Conexion.conexion();
            conexionBD.Open();

            try
            {
                MySqlCommand consulta = new MySqlCommand(query, conexionBD);

                int result = Convert.ToInt32(consulta.ExecuteScalar());
                if (result > 0)
                {
                    MessageBox.Show($"Se ha iniciado sesion correctamente.");
                    frmMenuPrincipal frmPantalla = new frmMenuPrincipal();
                    frmPantalla.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show($"Datos invalidos, intentelo de nuevo.");
                    limpiar();
                }   
            }
            catch (MySqlException ex)
            {
                MessageBox.Show($"Ha ocurrido un error: {ex}");
            }
            finally
            {
                conexionBD.Close();
            }            
        }

        public void limpiar()
        {
            txtUsuario.Text = "";
            txtContrasena.Text = "";            
        }
    } 
}