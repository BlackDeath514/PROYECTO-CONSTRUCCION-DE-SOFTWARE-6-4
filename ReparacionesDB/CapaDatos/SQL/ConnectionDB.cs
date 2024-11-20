using System.Data.SqlClient;
namespace CapaDatos
{
    // Clase que maneja la conexión a la base de datos
    internal class ConnectionDB
    {
        // Instancia de la conexión a la base de datos, configurada para SQL Server
        // La cadena de conexión incluye:
        // - Nombre del servidor: DormitorioPC\SQLEXPRESS
        // - Nombre de la base de datos: DB_POE_FINAL
        // - Seguridad integrada habilitada (autenticación de Windows)
        private SqlConnection conexion_db = new SqlConnection("server=DormitorioPC\\SQLEXPRESS; database=DB_POE_FINAL; Integrated Security=true");

        // Método para abrir la conexión a la base de datos
        public SqlConnection AbrirConexion()
        {
            if (conexion_db.State == System.Data.ConnectionState.Closed)
                conexion_db.Open();
            return conexion_db;
        }

        // Método para cerrar la conexión a la base de datos
        public SqlConnection CerrarConexion()
        {
            if (conexion_db.State == System.Data.ConnectionState.Open)
                conexion_db.Close();
            return conexion_db;
        }

    }
}
