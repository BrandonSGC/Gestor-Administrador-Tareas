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
            string[] estadoTarea = new string[4];
            estadoTarea[0] = "Asignado";
            estadoTarea[1] = "En Proceso";
            estadoTarea[2] = "En espera de";
            estadoTarea[3] = "Realizado";

            for (int i = 0; i < estadoTarea.Length; i++)
            {
                cbEstadoTarea.Items.Add(estadoTarea[i]);
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
    }
}
