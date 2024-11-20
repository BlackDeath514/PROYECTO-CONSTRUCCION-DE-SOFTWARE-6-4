using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class Persona
    {
        // Campos privados de la clase
        private string nombres; 
        private string apellidos;
        private string cedula;
        private string numero;

        // Constructor sin parámetros: inicializa los campos con valores predeterminados
        public Persona()
        {   
            nombres = string.Empty;
            apellidos = string.Empty;
            cedula = string.Empty;
            numero = string.Empty;

        }

        // Constructor con parámetros: permite establecer valores al crear el objeto
        public Persona(string nombre, string apellido, string cedula, string numero)
        {
            this.nombres = nombre;
            this.apellidos = apellido;
            this.cedula = cedula;
            this.numero = numero;
        }

        // Propiedades públicas para acceder y modificar los campos
        public string Nombres
        {
            get { return nombres; }
            set
            {
                nombres = value;
            }
        }
        public string Apellidos
        {
            get { return apellidos; }
            set
            {
                apellidos = value;
            }
        }

        public string Cedula
        {
            get { return cedula; }
            set
            {
                cedula = value;
            }
        }

        public string Numero
        {
            get { return numero; }
            set
            {
                numero = value;
            }
        }
    }
}
