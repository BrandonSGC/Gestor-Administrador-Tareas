using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Ingeneria_Software_II
{
    internal class Usuario 
    {
        #region Atributos
        private int cedula;
        private string nombre;
        private string apellidos;
        private string contrasena;
        private string email;
        private int telefono;
        private string puesto;
        #endregion


        #region Propiedades
        public int Cedula
        {
            get { return cedula; }
            set { cedula = value; }
        }

        public string Nombre
        {
            set { nombre = value; }
            get { return nombre; }
        }

        public string Apellidos
        {
            set { apellidos = value; }
            get { return apellidos; }
        }
        public string Contrasena
        {
            set { contrasena = value; }
            get { return contrasena; }
        }
        public string Email
        {
            set { email = value; }
            get { return email; }
        }
        public int Telefono
        {
            set { telefono = value; }
            get { return telefono; }
        }
        public string Puesto
        {
            set { puesto = value; }
            get { return puesto; }
        }
        #endregion


        #region Constructores
        public Usuario(string nombre, string apellidos, string contrasena,
        string email, int telefono, string puesto)
        {
            this.nombre = nombre;
            this.apellidos = apellidos;
            this.contrasena = contrasena;
            this.email = email;
            this.telefono = telefono;
            this.puesto = puesto;
        }

        public Usuario()
        {
            nombre = "";
            apellidos = "";
            contrasena = "";
            email = "";
            telefono = 0;
            puesto = "";
        }
        #endregion

        

        // Methods

    }
}
