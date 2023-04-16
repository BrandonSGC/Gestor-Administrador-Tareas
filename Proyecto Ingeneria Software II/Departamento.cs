using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Ingeneria_Software_II
{
    internal class Departamento
    {
        private string nombre;
        private int id_encargado;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public int ID_encargado
        {
            get { return id_encargado; }
            set { id_encargado = value; }
        }

            
    }  
}