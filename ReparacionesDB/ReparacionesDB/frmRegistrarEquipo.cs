using CapaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CapaPresentacion
{
    public partial class frmRegistrarEquipo : Form
    {
        //private List<Cliente> lista_cl;
        private bool nuevo;
        private EquipoCelular e_celular;

        public frmRegistrarEquipo(/*List<Cliente> cliente*/)
        {
            InitializeComponent();
            e_celular = new EquipoCelular();
            //lista_cl = cliente ?? new List<Cliente>();
            nuevo = false;
            cbliente.SelectedIndexChanged += new EventHandler(cbliente_SelectedIndexChanged);
        }

        private void frmRegistrarEquipo_Load(object sender, EventArgs e)
        {
            CargarClientes();
            btnGuardar.Enabled = false;
            btNuevo.Enabled = true;
            regreso.Enabled = true;

            if (cbliente.SelectedValue != null)
            {
                int clienteId = (int)cbliente.SelectedValue;
                ActualizarEquipos(clienteId);
            }
            else
            {
                // Manejar el caso donde no hay ningún cliente seleccionado.
                MessageBox.Show("Por favor, seleccione un cliente.");
            }
        }

        private void CargarClientes()
        {
            DataTable dt = e_celular.ObtenerCliente();
            cbliente.DisplayMember = "NOMBRE_CLIENTE";
            cbliente.ValueMember = "ID_CLIENTE";
            cbliente.DataSource = dt;
        }

        private void btNuevo_Click(object sender, EventArgs e)
        {
            try
            {
                nuevo = true;
                LimpiarCampos();
                btnGuardar.Enabled = true;
                regreso.Enabled = true;
                btNuevo.Enabled = false;
                txtModelo.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro -> " + ex.Message);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {

                if (string.IsNullOrWhiteSpace(txtModelo.Text) || string.IsNullOrWhiteSpace(txtMarca.Text) || string.IsNullOrWhiteSpace(txtDetalles.Text))
                {
                    MessageBox.Show("Tiene que llenar todos los campos.");
                    //LimpiarCampos();
                    return;
                }

                DataRowView clienteselecc = (DataRowView)cbliente.SelectedItem;

                if (clienteselecc != null)
                {
                    int clienteID = Convert.ToInt32(clienteselecc["ID_CLIENTE"]);

                    // Crear un nuevo objeto EquipoCelular
                    EquipoCelular nuevocelu = new EquipoCelular(0, txtModelo.Text, txtMarca.Text, txtDetalles.Text, clienteID);

                    if (e_celular.AgregarCelular(nuevocelu))
                    {
                        MessageBox.Show("Registro Insertado con Exito");
                        ActualizarEquipos(clienteID);
                    }
                    else
                    {
                        MessageBox.Show("No se pudo insertar el registro");
                    }

                    btnGuardar.Enabled = false;
                    btNuevo.Enabled = true;
                    regreso.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Por favor, selecciona un cliente.", "Error");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error: " + ex.Message);
                LimpiarCampos();
            }
            

        }

        private void ActualizarEquipos(int clienteId)
        {
            try
            {
                DGVequipos.DataSource = e_celular.ObtenerTodosCelular(clienteId);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener los datos " + ex.Message);
            }
        }

        private void LimpiarCampos()
        {
            txtDetalles.Text = string.Empty;
            txtMarca.Text = string.Empty;
            txtDetalles.Text = string.Empty;
            //cbliente.Items.Clear();
            cbliente.SelectedIndex = -1;
        }

        private void regreso_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataRowView clienteselecc = (DataRowView)cbliente.SelectedItem;
            if (clienteselecc != null)
            {
                int clienteID = Convert.ToInt32(clienteselecc["ID_CLIENTE"]);
                ActualizarEquipos(clienteID);
            }
            
        }

        /*private void btn_Click(object sender, EventArgs e)
        {

        }*/









    }
}
