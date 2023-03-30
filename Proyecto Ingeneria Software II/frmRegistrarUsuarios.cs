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

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            user.Nombre = txtNombre.Text;
            user.Apellidos = txtApellidos.Text;
            user.Contrasena = txtContrasena.Text;
            user.Email = txtEmail.Text;
            user.Telefono = int.Parse(txtTelefono.Text);
            user.Puesto = cbPuesto.SelectedItem.ToString();
            Conectar();
            limpiar();
        }

        private void limpiar()
        {
            txtNombre.Text = "";
            txtApellidos.Text = "";
            txtContrasena.Text = "";
            txtEmail.Text = "";
            txtTelefono.Text = "";
            cbPuesto.Text = "";
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


        // Metodos
        public void Conectar() //Conectamos a la base de datos
        {
            /* Creamos un objeto en el cual le vamos a pasar el string de 
             * conexion de la base de datos. */
            SqlConnection conexion = new SqlConnection("Data Source=BRANDONPC;Initial Catalog=Prueba;User ID=sa;Password=root!");
            
            // Abrimos la conexion.
            conexion.Open();
            
            /* Creamos un objeto de tipo SqlCommand, que nos va a permitir 
             * realizar los comandos que queramos a la base de datos. 
             * Como parametro vamos a pasarle en los VALUES un @ + nombre de 
             * columna, para luego con la propiedad Parameters y el metodo
             * AddWithValue le pasemos por primer parametro la columna y como
             * segundo parametro el dato en si. */
            SqlCommand cmd = new SqlCommand("INSERT INTO usuario VALUES(@nombre, @apellidos, @contrasena, @email, @telefono, @puesto);", conexion);            
            cmd.Parameters.AddWithValue("@nombre", user.Nombre);
            cmd.Parameters.AddWithValue("@apellidos", user.Apellidos);
            cmd.Parameters.AddWithValue("@contrasena", user.Contrasena);
            cmd.Parameters.AddWithValue("@email", user.Email);
            cmd.Parameters.AddWithValue("@telefono", user.Telefono);
            cmd.Parameters.AddWithValue("@puesto", user.Puesto);
            
            cmd.ExecuteNonQuery(); //Aun no se que hace esto exactamente.
            // Cerramos la conexion
            conexion.Close();
            MessageBox.Show($"El usuario {user.Nombre} ha sido agregado con exito.");
        }

        private void btnRegistrar_Click_1(object sender, EventArgs e)
        {

        }
    }
}
