using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.SQL
{
    internal class Parametros
    {
        private string name_parameter;
        private SqlDbType type_parameter;
        private object value_parameter;

        // Constructor predeterminado que inicializa los campos con valores predeterminados
        public Parametros()
        {
            name_parameter = string.Empty;
            type_parameter = SqlDbType.Int;
            value_parameter = string.Empty;
        }

        // Constructor sobrecargado para inicializar los campos con valores específicos
        public Parametros(string name_parameter, SqlDbType type_parameter, object value_parameter)
        {
            this.name_parameter = name_parameter;
            this.type_parameter = type_parameter;
            this.value_parameter = value_parameter;
        }

        // Propiedad para acceder y modificar
        public string NameParameter
        {
            get { return name_parameter; }
            set { name_parameter = value; }
        }

        public SqlDbType TypeParameter
        {
            get { return type_parameter; }
            set { type_parameter = value; }
        }

        public object ValueParameter
        {
            get { return value_parameter; }
            set { value_parameter = value; }
        }
    }
}
