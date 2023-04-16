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

        private void frmRegistrarUsuarios_Load(object sender, EventArgs e)
        {
            cargarDepartamentos();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            user.Cedula = int.Parse(txtCedula.Text);
            user.Nombre = txtNombre.Text;
            user.Apellidos = txtApellidos.Text;
            user.Contrasena = txtContrasena.Text;
            user.Email = txtEmail.Text;
            user.Telefono = int.Parse(txtTelefono.Text);
            user.Puesto = txtPuesto.Text;


            // Creamos la transaccion en SQL que vamos a hacer.
            string sql = $"INSERT INTO usuario VALUES({user.Cedula}, '{user.Nombre}', '{user.Apellidos}', '{user.Contrasena}', '{user.Email}', {user.Telefono}, '{user.Puesto}')";
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

        private void cargarDepartamentos()
        {
            MySqlConnection conexionBD = Conexion.conexion();

            try
            {
                conexionBD.Open();
                string sql = ("SELECT nombre FROM departamento");
                MySqlCommand comando = new MySqlCommand(sql, conexionBD);

                //MySqlDataAdapter adapter = new MySqlDataAdapter();
                //adapter.SelectCommand = comando;

                MySqlDataReader reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    // Agregar el valor de la columna correspondiente al ComboBox
                    cbDepartamento.Items.Add(reader.GetString(0));
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show($"Error al Mostrar los Datos: {ex}");
            }
            finally
            {
                conexionBD.Close();
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
            txtPuesto.Text = "";
        }

        private void btnVerTareas_Click(object sender, EventArgs e)
        {
            frmVerTareas frmPantalla = new frmVerTareas();
            frmPantalla.Show();
            this.Hide();
        }
    }
}