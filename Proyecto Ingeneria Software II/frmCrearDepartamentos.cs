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
    public partial class frmCrearDepartamentos : Form
    {
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

        }
    }
}