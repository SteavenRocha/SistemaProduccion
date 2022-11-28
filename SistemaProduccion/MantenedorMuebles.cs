using CapaEntidad;
using CapaLogica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaProduccion
{
    public partial class MantenedorMuebles : Form
    {
        public MantenedorMuebles()
        {
            InitializeComponent();
            listarMantenedorMueble();
            grupBoxDatos.Enabled = false;
            txtIDmueble.Enabled = false;
            listarNombreMueble();
        }

        private void listarNombreMueble()
        {
            cbxCatMueble.DataSource = logNombreMueble.Instancia.ListarNombreMueble().ToList();
            cbxCatMueble.DisplayMember = "nombreCategoria";
            cbxCatMueble.ValueMember = "CategoriaMuebleID";
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            //insertar
            try
            {
                entMueble c = new entMueble();
                c.IDsupervisor = int.Parse(txtIDsupervisor.Text.Trim());
               //c.CategoriaID = int.Parse(txtCategoriaMueble.Text.Trim());
                c.CategoriaID = Convert.ToInt32(cbxCatMueble.SelectedValue);
                c.estMueble = cbxEstado.Checked;
                logMueble.Instancia.InsertaMueble(c);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            LimpiarVariables();
            grupBoxDatos.Enabled = false;
            listarMantenedorMueble();
        }
        public void listarMantenedorMueble()
        {
            dgvDatos.DataSource = logMueble.Instancia.ListarMueble();
        }
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            grupBoxDatos.Enabled = true;
            btnAgregar.Visible = true;
            LimpiarVariables();
            btnModificar.Visible = false;
        }

        private void LimpiarVariables()
        {
            txtIDmueble.Text = "";
            txtIDsupervisor.Text = " ";
            //txtCategoriaMueble.Text = " ";
            //cbkEstadoCliente.Checked = false;
            cbxCatMueble.Text = " ";
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            grupBoxDatos.Enabled = false;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            grupBoxDatos.Enabled = true;
            btnModificar.Visible = true;
            btnAgregar.Visible = false;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                entMueble c = new entMueble();
                c.MuebleID = int.Parse(txtIDmueble.Text.Trim());
                c.IDsupervisor = int.Parse(txtIDsupervisor.Text.Trim());
                //c.CategoriaID = int.Parse(txtCategoriaMueble.Text.Trim());
                c.estMueble = cbxEstado.Checked;
                logMueble.Instancia.EditaMueble(c);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            LimpiarVariables();
            grupBoxDatos.Enabled = false;
            listarMantenedorMueble();
        }

        private void btnDeshabilitar_Click(object sender, EventArgs e)
        {
            try
            {
                entMueble c = new entMueble();

                c.MuebleID = int.Parse(txtIDmueble.Text.Trim());
                cbxEstado.Checked = false;
                c.estMueble = cbxEstado.Checked;
                logMueble.Instancia.DeshabilitarMueble(c);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            LimpiarVariables();
            grupBoxDatos.Enabled = false;
            listarMantenedorMueble();
        }

        private void dgvDatos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow filaActual = dgvDatos.Rows[e.RowIndex]; //
            txtIDmueble.Text = filaActual.Cells[0].Value.ToString();
            txtIDsupervisor.Text = filaActual.Cells[1].Value.ToString();
            //txtCategoriaMueble.Text = filaActual.Cells[2].Value.ToString();
            //txtCategoriaPlano.Text = filaActual.Cells[3].Value.ToString();
            //cbxIDordenPlano.Text = filaActual.Cells[2].Value.ToString();
            cbxEstado.Checked = Convert.ToBoolean(filaActual.Cells[3].Value);
        }
    }
}
