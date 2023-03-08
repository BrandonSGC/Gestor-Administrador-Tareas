using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Ingeneria_Software_II
{
    internal class Tarea
    {
        #region Atributos
        private string nombre;
        private string descripcion;
        private string depEncargado;
        private string fechaInicio;
        private string fechaFinalizacion;
        private string estado;
        #endregion


        #region Propiedades
        public string Nombre
        {
            set { nombre = value; }
            get { return nombre; }
        }
        public string Descripcion
        {
            set { descripcion = value; }
            get { return descripcion; }
        }
        public string DepEncargado
        {
            set { depEncargado = value; }
            get { return depEncargado; }
        }
        public string FechaInicio
        {
            set { fechaInicio = value; }
            get { return fechaInicio; }
        }
        public string FechaFinalizacion
        {
            set { fechaFinalizacion = value; }
            get { return fechaFinalizacion; }
        }
        public string Estado
        {
            set { estado = value; }
            get { return estado; }
        }
        #endregion


        #region Constuctor
        public Tarea() {
            nombre = "";
            descripcion = "";
            depEncargado = "";
            fechaInicio = "";
            fechaFinalizacion = "";
            estado = "";
        }

        #endregion

    }
}
