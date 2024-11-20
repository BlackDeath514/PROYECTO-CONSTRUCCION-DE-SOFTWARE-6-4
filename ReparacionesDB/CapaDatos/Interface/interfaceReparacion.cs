using CapaDatos.SQL;
//using capaNegocio
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.Interface
{
    // Clase que sirve como interfaz para la capa de datos y permite realizar operaciones relacionadas con la reparación
    public class interfaceReparacion
    {
        // Objeto de la clase ManageSQL para interactuar con la base de datos
        private ManageSQL obj_bd = new ManageSQL();

        //--------------------CLIENTE

        // Método para obtener todos los clientes desde la base de datos
        public DataTable getAllClientes()
        {
            return obj_bd.EjecutarSPSelect("SP_GET_ALL_CLIENTE");
        }

        // Método para registrar un nuevo cliente en la base de datos
        public bool crearCliente(string nombre_cliente, string apellido_cliente, string cedula_cliente,string numero_cliente,string direccion_cliente)
        {
            List<Parametros> lista_parametros = new List<Parametros>();
            lista_parametros.Add(new Parametros("n_cliente",SqlDbType.VarChar,nombre_cliente));
            lista_parametros.Add(new Parametros("a_cliente", SqlDbType.VarChar, apellido_cliente));
            lista_parametros.Add(new Parametros("c_cliente", SqlDbType.VarChar, cedula_cliente));
            lista_parametros.Add(new Parametros("num_cliente", SqlDbType.VarChar, numero_cliente));
            lista_parametros.Add(new Parametros("d_cliente", SqlDbType.VarChar, direccion_cliente));

            return obj_bd.EjecutarSPNoQuery("SP_CREAR_CLIENTE", lista_parametros);

        }

        // Método para eliminar un cliente según su ID
        public bool eliminarCliente(int clienteId)
        {
            List<Parametros> lista_parametros = new List<Parametros>
            {
                new Parametros("ID_CLIENTE", SqlDbType.Int, clienteId)
            };

            return obj_bd.EjecutarSPNoQuery("SP_ELIMINAR_CLIENTE", lista_parametros);
        }
        /*
        //eliminar clientes
        public bool eliminarCliente(string nombre_cliente, string apellido_cliente, string cedula_cliente, string numero_cliente, string direccion_cliente)
        {
            List<Parametros> lista_parametros = new List<Parametros>();
            lista_parametros.Add(new Parametros("n_cliente", SqlDbType.VarChar, nombre_cliente));
            lista_parametros.Add(new Parametros("a_cliente", SqlDbType.VarChar, apellido_cliente));
            lista_parametros.Add(new Parametros("c_cliente", SqlDbType.VarChar, cedula_cliente));
            lista_parametros.Add(new Parametros("num_cliente", SqlDbType.VarChar, numero_cliente));
            lista_parametros.Add(new Parametros("d_cliente", SqlDbType.VarChar, direccion_cliente));

            return obj_bd.EjecutarSPNoQuery("SP_ELIMINAR_CLIENTE",lista_parametros);
        }*/

        //-------------------CELULAR

        // Método para registrar un nuevo equipo celular asociado a un cliente

        public bool crearEquipo(string modelo_c, string marca_c, string detalle_c, int clienteId)
        {
            List<Parametros> lista_parametros = new List<Parametros>();
            lista_parametros.Add(new Parametros("modelo", SqlDbType.VarChar, modelo_c));
            lista_parametros.Add(new Parametros("marca", SqlDbType.VarChar, marca_c));
            lista_parametros.Add(new Parametros("detalle", SqlDbType.VarChar, detalle_c));
            lista_parametros.Add(new Parametros("cliente_id", SqlDbType.Int, clienteId.ToString()));

            return obj_bd.EjecutarSPNoQuery("SP_CREAR_CELULARR", lista_parametros);
        }

        // Método para obtener todos los celulares asociados a un cliente por su ID
        public DataTable getAllCelular(int clienteId)
        {
            List<Parametros> lista_parametros = new List<Parametros>();
            lista_parametros.Add(new Parametros("ID_CLIENTE", SqlDbType.Int, clienteId.ToString()));

            return obj_bd.EjecutarSPSelect("SP_GET_ALL_CELULAR", lista_parametros);
        }

        // Métodos para obtener nombres de clientes y técnicos
        public DataTable GetClientNames()
        {
            return obj_bd.GetClienteNombres();
        }
        public DataTable GetTecnicosNames()
        {
            return obj_bd.GetTecnicosNombres();
        }


        //LLAMA AL METODO QUE TRAE LOS CELULARES
        public DataTable ObtieneCelularesClientes(int clientId)
        {
            return obj_bd.GetCelularClientes(clientId);
        }
        /*public DataTable GetCellphoneDetailsByClientId(int clientId)
        {
            return obj_bd.GetCellphoneDetailsByClientId(clientId);
        }*/

        //---------------------TECNICOS
        // metodos tecnico

        // Método para obtener todos los técnicos registrados
        public DataTable getAllTecnicos()
        {
            return obj_bd.EjecutarSPSelect("SP_GET_ALL_TECNICO");
        }

        // Método para registrar un nuevo técnico
        public bool crearTecnico(string nombre_tecnico, string apellido_tecnico, string cedula_tecnico, string numero_tecnico, string experiencia_tecnico)
        {
            List<Parametros> lista_parametros = new List<Parametros>();
            lista_parametros.Add(new Parametros("n_tecnico", SqlDbType.VarChar, nombre_tecnico));
            lista_parametros.Add(new Parametros("a_tecnico", SqlDbType.VarChar, apellido_tecnico));
            lista_parametros.Add(new Parametros("c_tecnico", SqlDbType.VarChar, cedula_tecnico));
            lista_parametros.Add(new Parametros("num_tecnico", SqlDbType.VarChar, numero_tecnico));
            lista_parametros.Add(new Parametros("ex_tecnico", SqlDbType.VarChar, experiencia_tecnico));
            return obj_bd.EjecutarSPNoQuery("SP_CREAR_TECNICO", lista_parametros);
        }

        // Método para eliminar un técnico por sus datos
        public bool EliminarTecnico(string nombre_tecnico, string apellido_tecnico, string cedula_tecnico, string numero_tecnico, string experiencia_tecnico)
        {
            List<Parametros> lista_parametros = new List<Parametros>();
            lista_parametros.Add(new Parametros("n_tecnico", SqlDbType.VarChar, nombre_tecnico));
            lista_parametros.Add(new Parametros("a_tecnico", SqlDbType.VarChar, apellido_tecnico));
            lista_parametros.Add(new Parametros("c_tecnico", SqlDbType.VarChar, cedula_tecnico));
            lista_parametros.Add(new Parametros("num_tecnico", SqlDbType.VarChar, numero_tecnico));
            lista_parametros.Add(new Parametros("ex_tecnico", SqlDbType.VarChar, experiencia_tecnico));
            return obj_bd.EjecutarSPNoQuery("SP_ELIMINAR_TECNICO", lista_parametros);
        }


        //----------------------USUARIO
        //metodo de user que llama al de managesql
        public bool RevisarUsuario(string username, string password)
        {
            List<Parametros> lista_parametros = new List<Parametros>();
            lista_parametros.Add(new Parametros("Usuario_u", SqlDbType.VarChar, username));
            lista_parametros.Add(new Parametros("Contrasena_u", SqlDbType.VarChar, password));

            return obj_bd.EjecutarAutentificarUsuario("SP_VALIDAR_USER", lista_parametros);
        }


        //-----------------------MANTENIMIENTO
        // Método para crear un mantenimiento
        public bool MantenimientoCreado(/*int idMantenimiento, */DateTime fechaMantenimiento, string descripcion, float precioMan, List<string> re_mante)
        {
            List<Parametros> lista_parametros = new List<Parametros>
            {
                //new Parametros("ID_MANTENIMIENTO", SqlDbType.Int, idMantenimiento),
                new Parametros("FECHA_MANTENIMIENTO", SqlDbType.DateTime, fechaMantenimiento),
                new Parametros("DESCRIPCION", SqlDbType.VarChar, descripcion),
                new Parametros("PRECIO", SqlDbType.Float, precioMan),
                new Parametros("REPUESTOS", SqlDbType.VarChar, string.Join(",", re_mante))
            };
            return obj_bd.EjecutarSPNoQuery("SP_CREAR_MANTENIMIENTO", lista_parametros);
        }


    }
}
