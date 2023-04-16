using MySql.Data.MySqlClient;
using Mysqlx;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Ingeneria_Software_II
{
    public partial class frmCrearDepartamentos : Form
    {
        Departamento dep = new Departamento();
        public frmCrearDepartamentos()
        {
            InitializeComponent();
        }

        private void btnCrearDepartamentos_Click(object sender, EventArgs e)
        {
            frmCrearDepartamentos frmPantalla = new frmCrearDepartamentos();
            frmPantalla.Show();
            this.Hide();
        }

        private void btnRegistrarUsuarios_Click(object sender, EventArgs e)
        {
            frmRegistrarUsuarios frmPantalla = new frmRegistrarUsuarios();
            frmPantalla.Show();
            this.Hide();
        }

        private void btnCrearAsigarTareas_Click(object sender, EventArgs e)
        {
            frmCrearAsignarTareas frmPantalla = new frmCrearAsignarTareas();
            frmPantalla.Show();
            this.Hide();
        }

        private void pnlNavegacion_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pbAtras_Click(object sender, EventArgs e)
        {
            frmMenuPrincipal frmPantalla = new frmMenuPrincipal();
            this.Hide();
            frmPantalla.Show();            
        }

        private void btnCrearDepartamento_Click(object sender, EventArgs e)
        {            
            MySqlConnection conexionBD = Conexion.conexion();                       
            
            try
            {
                conexionBD.Open();
                // Obtenemos la cedula.
                string sql = $"SELECT cedula FROM usuario WHERE CONCAT(nombre, ' ', apellidos) = '{cbEncargado.Text.ToString()}'";
                MySqlCommand comando = new MySqlCommand(sql, conexionBD);


                MySqlDataReader reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    // Agregar el valor de la columna correspondiente al ComboBox.
                    dep.ID_encargado = int.Parse(reader.GetString(0));
                }

                dep.Nombre = txtNombreDepartamento.Text;                
            }
            catch (MySqlException ex)
            {
                MessageBox.Show($"Se ha producido un error.");
            }
            finally
            {
                conexionBD.Close();
                limpiar();
            }

            string sql2 = $"INSERT INTO departamento(nombre, id_encargado) VALUES('{dep.Nombre}', '{dep.ID_encargado}')";

            MySqlConnection conexionBD2 = Conexion.conexion();

            conexionBD2.Open();
            try
            {

                MySqlCommand consulta = new MySqlCommand(sql2, conexionBD2);

                consulta.ExecuteNonQuery();

                MessageBox.Show($"Departamento creado con exito.");
            }
            catch (MySqlException ex)
            {
                MessageBox.Show($"Error al crear departamento: {ex.Message}");
            }
            finally
            {
                conexionBD2.Close();
                limpiar();
            }
        }

        public void limpiar()
        {
            txtNombreDepartamento.Text = "";
        }

        private void cargarEncargados()
        {
            MySqlConnection conexionBD = Conexion.conexion();

            try
            {
                conexionBD.Open();
                string sql = ("SELECT CONCAT(nombre, ' ', apellidos) AS nombre_completo FROM usuario");
                MySqlCommand comando = new MySqlCommand(sql, conexionBD);

                //MySqlDataAdapter adapter = new MySqlDataAdapter();
                //adapter.SelectCommand = comando;

                MySqlDataReader reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    // Agregar el valor de la columna correspondiente al ComboBox
                    cbEncargado.Items.Add(reader.GetString(0));
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

        private void frmCrearDepartamentos_Load(object sender, EventArgs e)
        {
            cargarEncargados();
        }

        private void btnVerTareas_Click(object sender, EventArgs e)
        {
            frmVerTareas frmPantalla = new frmVerTareas();
            frmPantalla.Show();
            this.Hide();
        }
    }
}