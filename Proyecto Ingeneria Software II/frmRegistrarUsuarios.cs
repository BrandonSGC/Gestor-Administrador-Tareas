using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Ingeneria_Software_II
{
    public partial class frmRegistrarUsuarios : Form
    {
        Usuario user = new Usuario();
        public frmRegistrarUsuarios()
        {
            InitializeComponent();
        }
        
        public void cargarPuestos()
        {
            string[] puestos = new string[5];
            puestos[0] = "Ingeniero Softwre";
            puestos[1] = "Ingeniero Redes";
            puestos[2] = "Contador";
            puestos[3] = "Abogado";
            puestos[4] = "Chef";
            
            for (int i=0; i < puestos.Length; i++)
            {
                cbPuesto.Items.Add(puestos[i]);
            }
        }

        private void frmRegistrarUsuarios_Load(object sender, EventArgs e)
        {
            cargarPuestos();
        }


        private void btnRegistrar_Click_1(object sender, EventArgs e)
        {
            user.Cedula = int.Parse(txtCedula.Text);
            user.Nombre = txtNombre.Text;
            user.Apellidos = txtApellidos.Text;
            user.Contrasena = txtContrasena.Text;
            user.Email = txtEmail.Text;
            user.Telefono = int.Parse(txtTelefono.Text);
            user.Puesto = cbPuesto.SelectedItem.ToString();

            
            // Creamos la transaccion en SQL que vamos a hacer.
            string sql = $"INSERT INTO usuario VALUES('{user.Cedula}', '{user.Nombre}', '{user.Apellidos}', '{user.Contrasena}', '{user.Email}', '{user.Telefono}', '{user.Puesto}')";
            // Instanciamos la conexion.
            MySqlConnection conexionBD = Conexion.conexion();
            // Luego abrimos la conexion.
            conexionBD.Open();
            try
            {                
                // Instanciamos la consulta con el parametro de la transaccion y la conexion.
                MySqlCommand consulta = new MySqlCommand(sql, conexionBD);
                // Ejecutamos la consulta
                consulta.ExecuteNonQuery();

                MessageBox.Show($"Usuario registrado correctamente.");
            }
            catch (MySqlException ex)
            {
                MessageBox.Show($"Error a guardar el usuario: {ex}");
            }
            finally
            {
                conexionBD.Close();
                limpiar();
            }


        }

        private void limpiar()
        {
            txtCedula.Text = "";
            txtNombre.Text = "";
            txtApellidos.Text = "";
            txtContrasena.Text = "";
            txtEmail.Text = "";
            txtTelefono.Text = "";
            cbPuesto.SelectedItem = null;
        }

        private void pbAtras_Click(object sender, EventArgs e)
        {
            frmMenuPrincipal frmPantalla = new frmMenuPrincipal();
            this.Hide();
            frmPantalla.Show();
        }

        private void btnRegistrarUsuarios_Click(object sender, EventArgs e)
        {
            frmCrearAsignarTareas frmPantalla = new frmCrearAsignarTareas();
            frmPantalla.Show();
            this.Hide();
        }

        private void btnCrearDepartamentos_Click(object sender, EventArgs e)
        {
            frmCrearDepartamentos frmPantalla = new frmCrearDepartamentos();
            frmPantalla.Show();
            this.Hide();
        }
        private void btnCrearAsigarTareas_Click(object sender, EventArgs e)
        {
            frmCrearAsignarTareas frmPantalla = new frmCrearAsignarTareas();
            frmPantalla.Show();
            this.Hide();
        }
    }
}
