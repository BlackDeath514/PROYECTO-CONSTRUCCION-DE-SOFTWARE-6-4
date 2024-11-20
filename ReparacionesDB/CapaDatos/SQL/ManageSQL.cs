using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos.SQL;

namespace CapaDatos
{
    internal class ManageSQL
    {
        // Instancia de conexión a la base de datos
        private ConnectionDB conn = new ConnectionDB();

        // Método para ejecutar sentencias SQL de tipo INSERT, UPDATE y DELETE
        public bool EjecutarNoQuery(string sql)
        {
            var command = new SqlCommand(); //objeto tipo Sqlcommand
            command.CommandType = CommandType.Text; // el tipo de ejecucion va a ser Text
            command.CommandText = sql; // asigno la sentencia sql
            command.Connection = conn.AbrirConexion(); // abro la conexion
            var resultado = command.ExecuteNonQuery();
            if (resultado > 0)
                return true;
            else return false;
        }

        // Método para ejecutar una consulta SELECT y devolver los resultados en un DataTable
        public DataTable EjecutarSelect(string sql)
        {
            var command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = sql;
            command.Connection = conn.AbrirConexion();
            SqlDataReader reader = command.ExecuteReader();
            using (var tabla = new DataTable())
            {
                tabla.Load(reader);
                reader.DisposeAsync();
                conn.CerrarConexion();
                return tabla;
            }

        }

        // Método para ejecutar un procedimiento almacenado que devuelve resultados (SELECT)
        public DataTable EjecutarSPSelect(string sp_name)
        {
            var command = new SqlCommand();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = sp_name;
            command.Connection = conn.AbrirConexion();
            SqlDataReader reader = command.ExecuteReader();
            using (var tabla = new DataTable())
            {
                tabla.Load(reader);
                reader.DisposeAsync();
                conn.CerrarConexion();
                return tabla;
            }
        }


        // Sobrecarga para ejecutar un procedimiento almacenado con parámetros y devolver resultados
        public DataTable EjecutarSPSelect(string sp_name, List<Parametros> lista_parametros)
        {
            var command = new SqlCommand();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = sp_name;
            // asignar los parametros
            foreach (var parametro in lista_parametros)
                command.Parameters.Add(parametro.NameParameter, parametro.TypeParameter).Value = parametro.ValueParameter;
            command.Connection = conn.AbrirConexion();
            SqlDataReader reader = command.ExecuteReader();
            using (var tabla = new DataTable())
            {
                tabla.Load(reader);
                reader.DisposeAsync();
                conn.CerrarConexion();
                return tabla;
            }
        }

        // Método para ejecutar un procedimiento almacenado que no devuelve resultados (INSERT, UPDATE, DELETE)
        public bool EjecutarSPNoQuery(string name_sp)
        {
            var command = new SqlCommand(); //objeto tipo Sqlcommand
            command.CommandType = CommandType.StoredProcedure; // el tipo de ejecucion va a ser Text
            command.CommandText = name_sp; // asigno la sentencia sql
            command.Connection = conn.AbrirConexion(); // abro la conexion
            var resultado = command.ExecuteNonQuery();
            if (resultado > 0)
                return true;
            else return false;
        }


        // Sobrecarga para ejecutar un procedimiento almacenado con parámetros que no devuelve resultados
        public bool EjecutarSPNoQuery(string name_sp, List<Parametros> lista_parametros)
        {
            var command = new SqlCommand(); //objeto tipo Sqlcommand
            command.CommandType = CommandType.StoredProcedure; // el tipo de ejecucion va a ser Text
            command.CommandText = name_sp; // asigno la sentencia sql
            //asignamos los parametros
            foreach (var parametro in lista_parametros)
                command.Parameters.Add(parametro.NameParameter, parametro.TypeParameter).Value = parametro.ValueParameter;

            command.Connection = conn.AbrirConexion(); // abro la conexion
            var resultado = command.ExecuteNonQuery();
            if (resultado > 0)
                return true;
            else return false;
        }

        // Método para autenticar a un usuario mediante un procedimiento almacenado

        public bool EjecutarAutentificarUsuario(string sp_name, List<Parametros> lista_parametros)
        {
            var command = new SqlCommand();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = sp_name;
            foreach (var parametro in lista_parametros)
                command.Parameters.Add(parametro.NameParameter, parametro.TypeParameter).Value = parametro.ValueParameter;

            command.Connection = conn.AbrirConexion();
            int result = Convert.ToInt32(command.ExecuteScalar());
            conn.CerrarConexion();
            return result == 1;
        }

        // Método para obtener los nombres de los clientes
        public DataTable GetClienteNombres()
        {
            var command = new SqlCommand();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "SP_GET_NOMBRE_CLIENTE";
            command.Connection = conn.AbrirConexion();
            SqlDataReader reader = command.ExecuteReader(); 
            using (var tabla = new DataTable())
            {
                tabla.Load(reader);
                reader.DisposeAsync();
                conn.CerrarConexion();
                return tabla;
            }
        }

        // Método para obtener los nombres de los técnicos
        public DataTable GetTecnicosNombres()
        {
            var command = new SqlCommand();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "SP_GET_NOMBRE_TECNICO";
            command.Connection = conn.AbrirConexion();
            SqlDataReader reader = command.ExecuteReader();
            using (var tabla = new DataTable())
            {
                tabla.Load(reader);
                reader.DisposeAsync();
                conn.CerrarConexion();
                return tabla;
            }
        }

        // Método para obtener los celulares de un cliente específico
        public DataTable GetCelularClientes(int clientId)
        {
            var command = new SqlCommand();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "SP_CELULAR_CLIENTE"; // Procedimiento almacenado para obtener marca y modelo
            command.Parameters.Add(new SqlParameter("@CLIENTE_ID", SqlDbType.Int)).Value = clientId;
            command.Connection = conn.AbrirConexion();
            SqlDataReader reader = command.ExecuteReader();
            using (var tabla = new DataTable())
            {
                tabla.Load(reader);
                reader.DisposeAsync();
                conn.CerrarConexion();
                return tabla;
            }
        }

        

    }
}
