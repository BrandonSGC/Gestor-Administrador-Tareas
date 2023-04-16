using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Ingeneria_Software_II
{
    public partial class frmCrearAsignarTareas : Form
    {
        Tarea tarea = new Tarea();
        public frmCrearAsignarTareas()
        {
            InitializeComponent();
        }

        private void pbAtras_Click(object sender, EventArgs e)
        {
            frmMenuPrincipal frmPantalla = new frmMenuPrincipal();
            this.Hide();
            frmPantalla.Show();
        }


        private void btnRegistrarUsuarios_Click(object sender, EventArgs e)
        {
            frmRegistrarUsuarios frmPantalla = new frmRegistrarUsuarios();
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

        private void btnCrearTarea_Click(object sender, EventArgs e)
        {
            tarea.Nombre = txtNombre.Text;
            tarea.Descripcion = txtDescripcion.Text;
            DateTime fecha_inicio = dtpFechaInicio.Value;
            DateTime fecha_finalizacion = dtpFechaFinalizacion.Value;
            tarea.FechaInicio = fecha_inicio.ToString("yyyy-MM-dd");
            tarea.FechaFinalizacion = fecha_finalizacion.ToString("yyyy-MM-dd");


            MySqlConnection conexionBD = Conexion.conexion();
            conexionBD.Open();
            string sql = $"INSERT INTO tarea(nombre, descripcion, fecha_inicio, fecha_finalizacion) VALUES('{tarea.Nombre}', '{tarea.Descripcion}', '{tarea.FechaInicio}', '{tarea.FechaFinalizacion}')";

            try
            {
                MySqlCommand consulta = new MySqlCommand(sql, conexionBD);
                consulta.ExecuteNonQuery();

                MessageBox.Show("Tarea creada con exito.");
            }
            catch (MySqlException ex)
            {
                MessageBox.Show($"Error al crear la tarea: {ex.Message}");
            }
            finally
            {
                conexionBD.Close();
                limpiar();
            }
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
                    cbDepEncargado.Items.Add(reader.GetString(0));
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

        private void frmCrearAsignarTareas_Load(object sender, EventArgs e)
        {
            cargarDepartamentos();
        }

        public void limpiar()
        {

        }

        private void btnVerTareas_Click(object sender, EventArgs e)
        {
            frmVerTareas frmPantalla = new frmVerTareas();
            frmPantalla.Show();
            this.Hide();
        }
    }
}
