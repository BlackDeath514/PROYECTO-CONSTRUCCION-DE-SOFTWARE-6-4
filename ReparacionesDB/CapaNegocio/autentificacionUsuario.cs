using CapaDatos.Interface;
using System.Data;
using System.Data.SqlClient;

namespace CapaNegocio
{
    public class autentificacionUsuario
    {
        // Atributos privados de la clase
        private int id_user ;
        private string usuario;
        private string contrasena;
        private interfaceReparacion conexion_db;

        // Constructor por defecto
        public autentificacionUsuario()
        {
            id_user = 0;
            usuario= string.Empty;
            contrasena= string.Empty;
            conexion_db = new interfaceReparacion();
        }

        // Constructor con parámetros
        public autentificacionUsuario(int id_user, string usuario, string contrasena)
        {
            this.id_user = id_user;
            this.usuario = usuario;
            this.contrasena = contrasena;
            conexion_db = new interfaceReparacion();
        }

        // Propiedades públicas para acceder y modificar los campos
        public int Id_user
        {
            get { return id_user; } set { id_user = value; }
        }
        public string Usuario
        {
            get { return usuario; }
            set { usuario = value; }
        }
        public string Contrasena
        {
            get { return contrasena; } set { contrasena = value; }
        }

        // Método para autenticar al usuario llamando al método de la capa de datos
        public bool AuntentificarUsuario(string username, string password)
        {
            return conexion_db.RevisarUsuario(username, password);
        }

    }
}
