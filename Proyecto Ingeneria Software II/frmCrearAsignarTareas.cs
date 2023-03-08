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
            tarea.Descripcion= txtDescripcion.Text;
            if (tarea.DepEncargado.Length > 0 & tarea.Descripcion.Length > 0  )
            {
                tarea.DepEncargado = cbDepEncargado.SelectedItem.ToString();
            } else
            {
                MessageBox.Show("Debe completar los campos.");
            }
            
            tarea.FechaInicio = dtpFechaInicio.Text;
            tarea.FechaFinalizacion = dtpFechaFinalizacion.Text;

        }

        public void cargarDepartamentos()
        {
            string[] departamentos = new string[3];
            departamentos[0] = "Recursos Humanos";
            departamentos[1] = "Contabilidad";
            departamentos[2] = "Departamento de TI";


            for (int i = 0; i < departamentos.Length; i++)
            {
                cbDepEncargado.Items.Add(departamentos[i]);
            }
        }

        private void frmCrearAsignarTareas_Load(object sender, EventArgs e)
        {
            cargarDepartamentos();
        }
    }
}
