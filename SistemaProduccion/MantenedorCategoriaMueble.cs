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
    public partial class MantenedorCategoriaMueble : Form
    {
        public MantenedorCategoriaMueble()
        {
            InitializeComponent();
            listarCategoriaMueble();
            grupBoxDatos.Enabled = false;
            txtIDCategoriaMueble.Enabled = false;
        }

        public void listarCategoriaMueble()
        {
            dgvCategoriaMueble.DataSource = logCategoriaMueble.Instancia.ListarCategoriaMueble();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void LimpiarVariables()
        {
            txtIDCategoriaMueble.Text = "";
            txtNombreCategoria.Text = " ";
            cbxCategoriaMueble.Checked = false;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            grupBoxDatos.Enabled = true;
            btnAgregar.Visible = true;
            LimpiarVariables();
            btnModificar.Visible = false;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                entCategoriaMueble c = new entCategoriaMueble();
                c.nombreCategoria = txtNombreCategoria.Text.Trim();
                c.estaCategoria = cbxCategoriaMueble.Checked;
                logCategoriaMueble.Instancia.InsertarCategoriaMueble(c);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            LimpiarVariables();
            grupBoxDatos.Enabled = false;
            listarCategoriaMueble();

        }

        private void dgvCategoriaMueble_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow filaActual = dgvCategoriaMueble.Rows[e.RowIndex]; //
            txtIDCategoriaMueble.Text = filaActual.Cells[0].Value.ToString();
            txtNombreCategoria.Text = filaActual.Cells[1].Value.ToString();
            cbxCategoriaMueble.Checked = Convert.ToBoolean(filaActual.Cells[2].Value);

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
                entCategoriaMueble c = new entCategoriaMueble();
                c.CategoriaMuebleID = int.Parse(txtIDCategoriaMueble.Text.Trim());
                c.nombreCategoria = txtNombreCategoria.Text.Trim();
                c.estaCategoria = cbxCategoriaMueble.Checked;
                logCategoriaMueble.Instancia.EditaCategoriaMueble(c);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            LimpiarVariables();
            grupBoxDatos.Enabled = false;
            listarCategoriaMueble();

        }

        private void btnDeshabilitar_Click(object sender, EventArgs e)
        {
            try
            {
                entCategoriaMueble c = new entCategoriaMueble();

                c.CategoriaMuebleID = int.Parse(txtIDCategoriaMueble.Text.Trim());
                cbxCategoriaMueble.Checked = false;
                c.estaCategoria = cbxCategoriaMueble.Checked;
                logCategoriaMueble.Instancia.DeshabilitarCategoriaMueble(c);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            LimpiarVariables();
            grupBoxDatos.Enabled = false;
            listarCategoriaMueble();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            grupBoxDatos.Enabled = false;
        }
    }
}

