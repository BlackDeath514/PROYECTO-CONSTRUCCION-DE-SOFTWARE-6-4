using CapaDatos.Interface;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    // Clase Tecnico, que hereda de la clase Persona
    public class Tecnico : Persona
    {
        // Atributos específicos de un técnico
        private int id_tec;
        private string anios_ex;
        private interfaceReparacion conexion_db;

        // Constructor por defecto
        public Tecnico()
        {
            id_tec = 0;
            anios_ex = string.Empty;
            conexion_db = new interfaceReparacion();
        }

        // Constructor con parámetros
        public Tecnico(int id_tec, string nombres, string apellidos, string cedula, string numero, string anios_ex) : base(nombres, apellidos, cedula, numero)
        {
            this.id_tec = id_tec;
            this.anios_ex = anios_ex;
            conexion_db = new interfaceReparacion();
        }

        // Propiedad para obtener y establecer el ID del técnico
        public int IdTec
        {
            get { return id_tec; }
            set { id_tec = value; }
        }
        // Propiedad para obtener y establecer los años de experiencia
        public string Experiencia
        {
            get { return anios_ex; }
            set
            {
                anios_ex = value;
            }
        }

        // Método para insertar un técnico en la base de datos
        public bool InsertarTec(Tecnico mi_tecn)
        {
            return conexion_db.crearTecnico(mi_tecn.Nombres, mi_tecn.Apellidos, mi_tecn.Cedula, mi_tecn.Numero, mi_tecn.Experiencia);

        }
        // Método para obtener todos los técnicos registrados en la base de datos
        public DataTable ObtenerTecnicos()
        {
            return conexion_db.getAllTecnicos();
        }

        // Método para eliminar un técnico de la base de datos
        public bool EliminarTec(Tecnico mi_tecn)
        {
            return conexion_db.EliminarTecnico(mi_tecn.Nombres, mi_tecn.Apellidos, mi_tecn.Cedula, mi_tecn.Numero, mi_tecn.Experiencia);
        }
    }
}
