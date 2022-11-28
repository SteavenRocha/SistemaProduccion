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
    public partial class OrdenPlano : Form
    {
        public OrdenPlano()
        {
            InitializeComponent();
            listarOrdenPlano();
            grupBoxDatos.Enabled = false;
            txtOrdenPlano.Enabled = false;
            listarReqCliente();
        }
        public void listarOrdenPlano()
        {
            dgvOrdenPlano.DataSource = logOrdenPlano.Instancia.ListarOrdenPlano();
        }
        private void listarReqCliente()
        {
            cmbReqCliente.DataSource = logReqCliente.Instancia.ListarReqCliente().ToList();
            cmbReqCliente.DisplayMember = "Caracteristicas";
            cmbReqCliente.ValueMember = "RequerimientosclienteID";
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            grupBoxDatos.Enabled = false;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            grupBoxDatos.Enabled = true;
            btnAgregar.Visible = true;
            LimpiarVariables();
        }

        private void LimpiarVariables()
        {
            txtOrdenPlano.Text = "";
            txtIDdiseñador.Text = " ";
        }

        private void btnDeshabilitar_Click(object sender, EventArgs e)
        {
            try
            {
                entOrdenPlano c = new entOrdenPlano();

                c.OrdenPlanoID = int.Parse(txtOrdenPlano.Text.Trim());
                cbEstado.Checked = false;
                c.estadoOP = cbEstado.Checked;
                logOrdenPlano.Instancia.DeshabilitarOrdenPlano(c);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            LimpiarVariables();
            grupBoxDatos.Enabled = false;
            listarOrdenPlano();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                entOrdenPlano c = new entOrdenPlano();
                c.IDdiseñador = int.Parse(txtIDdiseñador.Text.Trim());
                c.RequerimientosclienteID = Convert.ToInt32(cmbReqCliente.SelectedValue);
                c.FechaRegistro = dtpFechaRegistro.Value;
                c.FechaLimite = dtpFechaLimite.Value;
                c.estadoOP = cbEstado.Checked;
                logOrdenPlano.Instancia.InsertaOrdenPlano(c);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            LimpiarVariables();
            grupBoxDatos.Enabled = false;
            listarOrdenPlano();
        }

        private void dgvOrdenPlano_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow filaActual = dgvOrdenPlano.Rows[e.RowIndex]; //
            txtOrdenPlano.Text = filaActual.Cells[0].Value.ToString();
            txtIDdiseñador.Text = filaActual.Cells[1].Value.ToString();
            cmbReqCliente.Text = filaActual.Cells[2].Value.ToString();
            dtpFechaRegistro.Text = filaActual.Cells[3].Value.ToString();
            dtpFechaLimite.Text = filaActual.Cells[4].Value.ToString();
            cbEstado.Checked = Convert.ToBoolean(filaActual.Cells[5].Value);
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dgvOrdenPlano_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void grupBoxDatos_Enter(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void dtpFechaLimite_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txtIDdiseñador_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbReqCliente_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtOrdenPlano_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void cbEstado_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
