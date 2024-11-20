using CapaDatos.Interface;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class Mantenimiento
    {
        // Atributos privados de la clase
        private interfaceReparacion conexion_db;
        private DateTime fecha_hoy;
        private string man_descrip;
        private int id_mantenimiento;
        private float precio_mant;
        private float precio_rep;
        private float mant_costo = 30.0f;
        private float iva = 0.12f;
        private List<Repuesto> re_mante;

        // Constructor por defecto
        public Mantenimiento()
        {
            conexion_db = new interfaceReparacion();
            id_mantenimiento = 0;
            man_descrip = string.Empty;
            precio_mant = 0;
            precio_rep = 0;
            fecha_hoy = DateTime.Now;
            re_mante = new List<Repuesto>();
        }

        // Constructor con parámetros
        public Mantenimiento(DateTime fecha_hoy, string man_descrip, int id_mantenimiento, float precio_mant, float precio_rep)
        {
            this.fecha_hoy = fecha_hoy;
            this.man_descrip = man_descrip;
            this.id_mantenimiento= id_mantenimiento;
            this.precio_mant = precio_mant;
            this.precio_rep = precio_rep;
            conexion_db = new interfaceReparacion();
            re_mante = new List<Repuesto>();
        }

        // Propiedades públicas para acceder y modificar los campos
        public int IdMante
        {
            get { return id_mantenimiento; }
            set { id_mantenimiento = value; }
        }

        public DateTime FechaHoy
        {
            get { return fecha_hoy;}
            set { fecha_hoy = value;}
        }

        public string ManDescrip
        {
            get { return man_descrip; }
            set { man_descrip = value; }
        }

        public float PrecioMante
        {
            get { return precio_mant; }
            set { precio_mant = value; }
        }

        public float PrecioRep
        {
            get { return precio_rep; }
            set { precio_rep = value; }
        }

        public List<Repuesto> ReMante
        {
            get { return re_mante; }
            set { re_mante = value; }
        }

        // Método para calcular el costo total del mantenimiento
        public float CostoTotal()
        {
            float precio_rep = re_mante.Sum(r => (float)r);
            float sub = precio_rep + mant_costo;
            float ivaa = sub * iva;
            return sub + ivaa;
        }

        // Método para guardar los datos del mantenimiento en la base de datos
        public bool GuardarMante(Mantenimiento mante)
        {
            precio_mant = CostoTotal();
            List<string> repuestosS = re_mante.Select(r => r.ToString()).ToList();
            return conexion_db.MantenimientoCreado(/*mante.IdMante, */mante.FechaHoy, mante.ManDescrip, mante.precio_mant, repuestosS);
        }

        // Métodos para obtener datos relacionados con los clientes y técnicos
        public DataTable ObtenerClientes()
        {
            return conexion_db.GetClientNames();
        }
        public DataTable ObtenerTecnico()
        {
            return conexion_db.GetTecnicosNames();
        }

        // Método para obtener detalles de los celulares asociados a un cliente específico
        public DataTable GetCellphoneDetailsByClientId(int clientId)
        {
            return conexion_db.ObtieneCelularesClientes(clientId);
        }
    }
}
