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
    public partial class MantenedorPlano : Form
    {
        public MantenedorPlano()
        {
            InitializeComponent();
            listarMantenedorPlano();
            grupBoxDatos.Enabled = false;
            txtIDplano.Enabled = false;
            listarNombrePlano();
           // listarNombreOrdenPlano();
        }

        /*private void listarNombreOrdenPlano()
        {
            cbxIDordenPlano.DataSource = logNombreOrdenPlano.Instancia.ListarNombreOrdenPlano().ToList();
            cbxIDordenPlano.DisplayMember = "TipoPlanoID";
            //cbxIDordenPlano.ValueMember = "TipoPlanoID";
        }*/

        public void listarMantenedorPlano()
        {
            dgvDatos.DataSource = logPlano.Instancia.ListarTipoPlano();
        }

        private void listarNombrePlano()
        {
            cbxCatPlano.DataSource = logNombrePlano.Instancia.ListarNombrePlano().ToList();
            cbxCatPlano.DisplayMember = "DescripcionPlano";
            cbxCatPlano.ValueMember = "TipoPlanoID";
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
            txtIDplano.Text = "";
            txtIDdiseñador.Text = " ";
            txtOrdePlano.Text = " ";
            cbxCatPlano.Text = " ";
            //cbkEstadoCliente.Checked = false;

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            grupBoxDatos.Enabled = true;
            btnModificar.Visible = true;
            btnAgregar.Visible = false;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            grupBoxDatos.Enabled = false;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                entPlano c = new entPlano();
                c.PlanoID = int.Parse(txtIDplano.Text.Trim());
                c.IDdiseñador = int.Parse(txtIDdiseñador.Text.Trim());
                c.OrdenPlanoID = int.Parse(txtOrdePlano.Text.Trim());
                //c.TipoID = int.Parse(txtCategoriaPlano.Text.Trim());
                c.estaPlano = cbxEstado.Checked;
                logPlano.Instancia.EditaPlano(c);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            LimpiarVariables();
            grupBoxDatos.Enabled = false;
            listarMantenedorPlano();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            //insertar
            try
            {
                entPlano c = new entPlano();
                c.IDdiseñador = int.Parse(txtIDdiseñador.Text.Trim());
                c.OrdenPlanoID = int.Parse(txtOrdePlano.Text.Trim());
                //c.TipoID = int.Parse(txtCategoriaPlano.Text.Trim());
                //c.OrdenPlanoID = Convert.ToInt32(cbxIDordenPlano.SelectedValue);
                c.TipoID = Convert.ToInt32(cbxCatPlano.SelectedValue);
                c.estaPlano = cbxEstado.Checked;
                logPlano.Instancia.InsertaPlano(c);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            LimpiarVariables();
            grupBoxDatos.Enabled = false;
            listarMantenedorPlano();
        }

        private void dgvDatos_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow filaActual = dgvDatos.Rows[e.RowIndex]; //
            txtIDplano.Text = filaActual.Cells[0].Value.ToString();
            txtIDdiseñador.Text = filaActual.Cells[1].Value.ToString();
            txtOrdePlano.Text = filaActual.Cells[2].Value.ToString();
            //txtCategoriaPlano.Text = filaActual.Cells[3].Value.ToString();
            //cbxIDordenPlano.Text = filaActual.Cells[2].Value.ToString();
            cbxCatPlano.Text = filaActual.Cells[3].Value.ToString();
            cbxEstado.Checked = Convert.ToBoolean(filaActual.Cells[4].Value);
        }

        private void btnDeshabilitar_Click(object sender, EventArgs e)
        {
            try
            {
                entPlano c = new entPlano();

                c.PlanoID = int.Parse(txtIDplano.Text.Trim());
                cbxEstado.Checked = false;
                c.estaPlano = cbxEstado.Checked;
                logPlano.Instancia.DeshabilitarPlano(c);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            LimpiarVariables();
            grupBoxDatos.Enabled = false;
            listarMantenedorPlano();
        }
    }
}
