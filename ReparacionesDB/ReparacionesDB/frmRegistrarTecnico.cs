﻿using CapaNegocio;
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
    public partial class frmRegistrarTecnico : Form
    {
        private Tecnico n_tec;
        private bool is_nuv;
        public frmRegistrarTecnico()
        {
            InitializeComponent();
            n_tec = new Tecnico();
            is_nuv = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmRegistrarTecnico_Load(object sender, EventArgs e)
        {
            btnEliminar.Enabled = false;
            btnGuardar.Enabled = false;
            LlenarGridTEC();
        }

        private void LlenarGridTEC()
        {
            try
            {
                DGVtec.DataSource = n_tec.ObtenerTecnicos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener los datos " + ex.Message);
            }
        }

        private void SetearCampos()
        {
            txtNombreTec.Text = string.Empty;
            txtApellTec.Text = string.Empty;
            txtCedulaT.Text = string.Empty;
            txtCelularT.Text = string.Empty;
            txtExpe.Text = string.Empty;

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            try
            {
                is_nuv = true;
                SetearCampos();
                btnGuardar.Enabled = true;
                btnNuevo.Enabled = false;
                txtNombreTec.Focus();
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

                if (string.IsNullOrWhiteSpace(txtNombreTec.Text) || string.IsNullOrWhiteSpace(txtApellTec.Text) || string.IsNullOrWhiteSpace(txtCedulaT.Text) || string.IsNullOrWhiteSpace(txtCelularT.Text) || string.IsNullOrWhiteSpace(txtExpe.Text))
                {
                    MessageBox.Show("Tiene que llenar todos los campos.");
                    //LimpiarCampos();
                    return;
                }

                if (is_nuv)
                {
                    Tecnico obj_cl = new Tecnico(0, txtNombreTec.Text, txtApellTec.Text
                        , txtCedulaT.Text, txtCelularT.Text, txtExpe.Text);
                    if (n_tec.InsertarTec(obj_cl))
                    {
                        MessageBox.Show("Registro Insertado con Exito");
                        LlenarGridTEC();
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

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                Tecnico obj_cl = new Tecnico(0, txtNombreTec.Text, txtApellTec.Text
                        , txtCedulaT.Text, txtCelularT.Text, txtExpe.Text);
                n_tec.EliminarTec(obj_cl);
                LlenarGridTEC();
                SetearCampos();
                txtNombreTec.Focus();
                MessageBox.Show("Eliminado Correctamente");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error " + ex.Message);

            }
        }

        private void btnRegreso_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DGVtec_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtNombreTec.Text = DGVtec.Rows[e.RowIndex].Cells["NOMBRE_TECNICO"].Value.ToString();
                txtApellTec.Text = DGVtec.Rows[e.RowIndex].Cells["APELLIDO_TECNICO"].Value.ToString();
                txtCedulaT.Text = DGVtec.Rows[e.RowIndex].Cells["CEDULA_TECNICO"].Value.ToString();
                txtCelularT.Text = DGVtec.Rows[e.RowIndex].Cells["NUMERO_TECNICO"].Value.ToString();
                txtExpe.Text = DGVtec.Rows[e.RowIndex].Cells["EXPERIENCIA_TECNICO"].Value.ToString();

                btnNuevo.Enabled = true;
                btnGuardar.Enabled = true;
                btnEliminar.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error " + ex.Message);
            }

        }
    }
}