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

namespace CapaPresentacion
{
    public partial class frmPrincipal : Form
    {
        private frmRegistrarCliente reg_cliente;
        private frmRegistrarTecnico reg_tecnico;
        private frmRegistrarMantenimiento reg_mantenimiento;
        private frmRegistrarEquipo eq_registro;
        //private List<Cliente> lista_cl;
        private Cliente cliente_p2;
        public frmPrincipal()
        {
            InitializeComponent();
            //lista_cl = new List<Cliente>();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnRegistrarCliente_Click(object sender, EventArgs e)
        {
            reg_cliente = new frmRegistrarCliente();

            reg_cliente.ShowDialog();

        }

        private void btnRegistrarTecnico_Click(object sender, EventArgs e)
        {
            reg_tecnico = new frmRegistrarTecnico();
            reg_tecnico.ShowDialog();

        }

        private void btnMantenimiento_Click(object sender, EventArgs e)
        {
            reg_mantenimiento = new frmRegistrarMantenimiento();
            reg_mantenimiento.ShowDialog();

        }

        private void btnREquipo_Click(object sender, EventArgs e)
        {
            eq_registro = new frmRegistrarEquipo(/*lista_cl*/);
            eq_registro.ShowDialog();
        }

        
    }
}
