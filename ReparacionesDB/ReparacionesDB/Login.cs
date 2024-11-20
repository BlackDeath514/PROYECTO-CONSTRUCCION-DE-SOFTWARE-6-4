using CapaNegocio;
using CapaPresentacion;

namespace ReparacionesDB
{
    public partial class Login : Form
    {
        //variable que llama los metodos de la capa de datos
        private autentificacionUsuario verif_usuario;
        public Login()
        {
            InitializeComponent();
            verif_usuario= new autentificacionUsuario();
        }


        public void SetearCampos()
        {
            txtUsuario.Text = string.Empty;
            txtContrasena.Text = string.Empty;
        }


        private void btnEntrar_Click(object sender, EventArgs e)
        {
   
            try
            {
                string username = txtUsuario.Text;
                string password = txtContrasena.Text;

                bool isAuthenticated = verif_usuario.AuntentificarUsuario(username, password);

                if (isAuthenticated)
                {
                    MessageBox.Show("BIENVENIDO!");
                    Form paginaPrincipal = new frmPrincipal();
                    paginaPrincipal.ShowDialog();

                }
                else
                {
                    MessageBox.Show("Usuario o contraseña invalidos");
                    SetearCampos();
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
    }
}
