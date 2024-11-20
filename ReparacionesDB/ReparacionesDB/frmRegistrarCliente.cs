using CapaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CapaPresentacion
{
    public partial class frmRegistrarCliente : Form
    {
        private Cliente n_cliente;
        private bool is_nuevo;
        public frmRegistrarCliente()
        {
            InitializeComponent();
            n_cliente = new Cliente();
            is_nuevo = false;
        }
        private void frmRegistrarCliente_Load(object sender, EventArgs e)
        {
            btnEliminar.Enabled = false;
            btnGuardar.Enabled = false;
            LlenarGridCliente();
        }
        private void LlenarGridCliente()
        {
            try
            {
                dgvClientes.DataSource = n_cliente.ObtenerTodosClientes();
                dgvClientes.Columns["ID_CLIENTE"].Visible = false; // Puedes hacer que el ID no sea visible pero aún accesible
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener los datos " + ex.Message);
            }
            
        }
        private void SetearCampos()
        {
            txtNombre.Text = string.Empty;
            txtApellido.Text = string.Empty;
            txtCedula.Text = string.Empty;
            txtCelular.Text = string.Empty;
            rtxtDireccion.Text = string.Empty;

        }


        private void btnNuevo_Click(object sender, EventArgs e)
        {
            try
            {
                is_nuevo = true;
                SetearCampos();
                btnGuardar.Enabled = true;
                btnNuevo.Enabled = false;
                txtNombre.Focus();
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

                if (string.IsNullOrWhiteSpace(txtNombre.Text) || string.IsNullOrWhiteSpace(txtApellido.Text) || string.IsNullOrWhiteSpace(txtCedula.Text) || string.IsNullOrWhiteSpace(rtxtDireccion.Text) || string.IsNullOrWhiteSpace(txtCelular.Text))
                {
                    MessageBox.Show("Tiene que llenar todos los campos.");

                    //LimpiarCampos();
                    return;
                }

                if (is_nuevo)
                {
                    Cliente obj_cl = new Cliente(0, txtNombre.Text, txtApellido.Text
                        , txtCedula.Text, txtCelular.Text, rtxtDireccion.Text);

                    if (n_cliente.InsertarCliente(obj_cl))
                    {
                        MessageBox.Show("Registro Insertado con Exito");
                        LlenarGridCliente();
                    }
                    else
                        MessageBox.Show("No se pudo insertar el registro");
                    btnGuardar.Enabled = false;
                    btnNuevo.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error -> " + ex.Message);
            }


        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {


            try
            {
                if (e.RowIndex >= 0) // Asegurarse de que el índice de fila es válido
                {
                    txtNombre.Text = dgvClientes.Rows[e.RowIndex].Cells["NOMBRE_CLIENTE"].Value.ToString();
                    txtApellido.Text = dgvClientes.Rows[e.RowIndex].Cells["APELLIDO_CLIENTE"].Value.ToString();
                    txtCedula.Text = dgvClientes.Rows[e.RowIndex].Cells["CEDULA_CLIENTE"].Value.ToString();
                    txtCelular.Text = dgvClientes.Rows[e.RowIndex].Cells["NUMERO_CLIENTE"].Value.ToString();
                    rtxtDireccion.Text = dgvClientes.Rows[e.RowIndex].Cells["DIRECCION_CLIENTE"].Value.ToString();

                    btnNuevo.Enabled = true;
                    btnGuardar.Enabled = true;
                    btnEliminar.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error " + ex.Message);
            }
            

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            
            try
            {
                if (dgvClientes.SelectedRows.Count > 0) // Verifica si hay una fila seleccionada
                {
                    int clienteId = Convert.ToInt32(dgvClientes.SelectedRows[0].Cells["ID_CLIENTE"].Value); // Obtiene el ID del cliente
                    if (n_cliente.EliminarClientes(clienteId))
                    {
                        MessageBox.Show("Eliminado Correctamente");
                        LlenarGridCliente();
                        SetearCampos();
                    }
                    else
                    {
                        MessageBox.Show("No se pudo eliminar el registro");
                    }
                }
                else
                {
                    MessageBox.Show("Por favor, selecciona un cliente.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error " + ex.Message);
            }
        }

        private void rtxtDireccion_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
