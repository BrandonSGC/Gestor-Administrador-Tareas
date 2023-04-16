using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Ingeneria_Software_II
{
    public partial class frmVerTareas : Form
    {
        public frmVerTareas()
        {
            InitializeComponent();
        }

        private void frmVerTareas_Load(object sender, EventArgs e)
        {
            cargarEstados();
        }

        private void lblTitulo_Click(object sender, EventArgs e)
        {

        }

        public void cargarEstados()
        {
            MySqlConnection conexionBD = Conexion.conexion();

            try
            {
                conexionBD.Open();
                string sql = ("SELECT nombre FROM estado_tarea");
                MySqlCommand comando = new MySqlCommand(sql, conexionBD);

                //MySqlDataAdapter adapter = new MySqlDataAdapter();
                //adapter.SelectCommand = comando;

                MySqlDataReader reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    // Agregar el valor de la columna correspondiente al ComboBox
                    cbEstadoTarea.Items.Add(reader.GetString(0));
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

        private void pbAtras_Click(object sender, EventArgs e)
        {
            frmMenuPrincipal frmPantalla = new frmMenuPrincipal();            
            frmPantalla.Show();
            Close();
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

        private void btnVerTareas_Click(object sender, EventArgs e)
        {
            frmVerTareas frmPantalla = new frmVerTareas();
            frmPantalla.Show();
            this.Hide();
        }

        private void btnBucar_Click(object sender, EventArgs e)
        {
            // Obtenemos el codigo a buscar
            String nombre = txtBuscarNombreTarea.Text;

            // Creamos un reader
            MySqlDataReader reader = null;

            // Creamos la consulta.
            string sql = $"SELECT nombre, descripcion, dep_encargado, fecha_inicio, fecha_finalizacion FROM tarea WHERE nombre = '{nombre}' LIMIT 1";
            MySqlConnection conexionBD = Conexion.conexion();
            conexionBD.Open();
            try
            {
                MySqlCommand comando = new MySqlCommand(sql, conexionBD);
                reader = comando.ExecuteReader(); // Aqui tenemos ya el resultado de la consulta
                // Validamos
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        txtNombre.Text = reader.GetString(0);
                        txtDescripcion.Text = reader.GetString(1);
                        cbDepEncargado.Text = reader.GetString(2);
                        string fehcaInicio = reader.GetString(3);
                        DateTime fecha = DateTime.ParseExact(fehcaInicio, "M/d/yyyy h:mm:ss tt", CultureInfo.InvariantCulture);
                        dtpFechaInicio.Value = fecha.Date;

                        string fechaFinalizacion = reader.GetString(4);
                        DateTime fecha2 = DateTime.ParseExact(fechaFinalizacion, "M/d/yyyy h:mm:ss tt", CultureInfo.InvariantCulture);
                        dtpFechaFinalizacion.Value = fecha2.Date;
                    }
                }
                else
                {
                    MessageBox.Show("No se encontraron tareas..");
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show($"Error al buscar la tarea: {ex}");
            }
            finally
            {
                conexionBD.Close();
            }
        }
    }
}
