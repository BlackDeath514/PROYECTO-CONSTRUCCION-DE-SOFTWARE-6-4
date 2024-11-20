using CapaDatos.Interface;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class Cliente : Persona
    {
        // Atributos privados de la clase
        private int id_cliente;
        private string direccion;
        private List<EquipoCelular> celular; //relacion con celulares
        private interfaceReparacion conexion_db;

        // Constructor por defecto
        public Cliente()
        {
            id_cliente = 0;
            celular = new List<EquipoCelular>();
            direccion = string.Empty;
            
            conexion_db= new interfaceReparacion();
        }

        // Constructor con parámetros
        public Cliente(int id_cliente, string nombres, string apellidos, string cedula, string numero ,string direccion) : base(nombres, apellidos, cedula, numero)
        {
            this.id_cliente = id_cliente;
            celular = new List<EquipoCelular>();
            this.direccion = direccion;
            
            conexion_db = new interfaceReparacion();
        }

        // Propiedades públicas para acceder y modificar los campos
        public int IdCliente
        {
            get { return id_cliente; }
            set { id_cliente= value; }
        }
        public string Direccion
        {
            get { return direccion; }
            set
            {
                direccion = value;
            }
        }
        
        public List<EquipoCelular> Celular
        {
            get { return celular; }
            set { celular = value; }
        }

        // Métodos para manejar información de los clientes

        // Inserta un nuevo cliente en la base de datos
        public bool InsertarCliente(Cliente mi_cliente)
        {
            return conexion_db.crearCliente(mi_cliente.Nombres, mi_cliente.Apellidos, mi_cliente.Cedula, mi_cliente.Numero, mi_cliente.Direccion);

        }
        // Obtiene todos los clientes desde la base de datos
        public DataTable ObtenerTodosClientes()
        {
            return conexion_db.getAllClientes();
        }

        // Elimina un cliente de la base de datos
        public bool EliminarClientes(int clienteId)
        {
            return conexion_db.eliminarCliente(clienteId);
        }
        

    }
}
