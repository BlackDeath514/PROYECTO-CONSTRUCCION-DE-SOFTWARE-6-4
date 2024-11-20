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
    public class EquipoCelular
    {
        // Atributos privados de la clase
        private int id_celular;
        private string modelo;
        private string marca;
        private string detalle;
        private int cliente_id; //relacion con cliente
        private interfaceReparacion conexion_db;

        // Constructor por defecto
        public EquipoCelular()
        {
            id_celular = 0;
            modelo = string.Empty;
            marca = string.Empty;
            detalle = string.Empty;
            cliente_id = 0;
            conexion_db = new interfaceReparacion();
        }

        // Constructor con parámetros
        public EquipoCelular(int id_celular, string modelo, string marca, string detalle, int cliente_id)
        {
            this.id_celular = id_celular;
            this.modelo = modelo;
            this.marca = marca;
            this.detalle = detalle;
            this.cliente_id = cliente_id;
            conexion_db = new interfaceReparacion();
        }

        // Propiedades públicas para acceder y modificar los campos
        public int IdEquipo
        {
            get { return id_celular; }
            set { id_celular = value; }
        }

        public string Modelo
        { 
            get { return modelo; } 
            set {  modelo = value; } 
        }

        public string Marca
        { 
            get { return marca; } 
            set {  marca = value; } 
        }

        public string Detalle
        { 
            get { return detalle; } 
            set { detalle = value; } 
        }

        public int ClienteID
        { 
            get { return cliente_id; }
            set { cliente_id = value; } 
        }


        // Métodos para manejar la información del celular

        // Obtiene los nombres de los clientes

        public DataTable ObtenerCliente()
        {
            return conexion_db.GetClientNames();
        }


        // Agrega un nuevo celular a la base de datos
        public bool AgregarCelular(EquipoCelular celu)
        {
            try
            {
                return conexion_db.crearEquipo(celu.Modelo, celu.Marca, celu.Detalle, celu.ClienteID);
            }
            catch (Exception ex)
            {
                // Manejar el error aquí, si es necesario
                Console.WriteLine("Error: " + ex.Message);
                return false;
            }
        }

        // Obtiene todos los celulares asociados a un cliente específico
        public DataTable ObtenerTodosCelular(int clienteId)
        {
            return conexion_db.getAllCelular(clienteId);
        }
    }
}
