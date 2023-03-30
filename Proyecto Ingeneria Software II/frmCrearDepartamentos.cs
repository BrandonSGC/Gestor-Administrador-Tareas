using MySql.Data.MySqlClient;
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
            dep.Nombre = txtNombreDepartamento.Text;

            MySqlConnection conexionBD = Conexion.conexion();
            conexionBD.Open();
            string sql = $"INSERT INTO departamento(nombre) VALUES('{dep.Nombre}')";

            try
            {
                MySqlCommand consulta = new MySqlCommand(sql, conexionBD);
                consulta.ExecuteNonQuery();

                MessageBox.Show("Departamento creado con exito.");
            }
            catch (MySqlException ex)
            {
                MessageBox.Show($"Error al crear departamento: {ex.Message}");
            }
            finally
            {
                conexionBD.Close();
                limpiar();
            }            
        }

        public void limpiar()
        {

        }
    }
}