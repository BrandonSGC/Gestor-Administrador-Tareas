using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Ingeneria_Software_II
{
    internal class Departamento
    {
        #region propiedades
        private string nombre;
        private Usuario usuario;
        #endregion


        #region Propiedades
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public Usuario Usuario
        {
            get { return usuario; }
            set { usuario = value; }
        }
        #endregion

        #region metodos
        
        #endregion
    }  
}
