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
    public partial class RequerimientosCliente : Form
    {
        public RequerimientosCliente()
        {
            InitializeComponent();
            listarRequerimientoCliente();
            grupBoxDatos.Enabled = false;
            txtIDReqClientes.Enabled = false;
            listarNombreCliente();
        }

        private void listarNombreCliente()
        {
            cmbCliente.DataSource=logNombreCliente.Instancia.ListarNombreCliente().ToList();
            cmbCliente.DisplayMember = "nombresCompletos";
            cmbCliente.ValueMember = "idCliente";
        }

        public void listarRequerimientoCliente()
        {
            dgvReqCliente.DataSource = logRequerimientosClientes.Instancia.ListarRequerimientoCliente();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            grupBoxDatos.Enabled = true;
            btnAgregar.Visible = true;
            LimpiarVariables();
        }
        private void LimpiarVariables()
        {
            txtIDReqClientes.Text = "";
            textCaracteristicas.Text = " ";
            textObservaciones.Text = " ";
            textMedidas.Text = " ";
        }

        private void dgvReqCliente_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow filaActual = dgvReqCliente.Rows[e.RowIndex]; //
            txtIDReqClientes.Text = filaActual.Cells[0].Value.ToString();
            textCaracteristicas.Text = filaActual.Cells[1].Value.ToString();
            cmbCliente.Text = filaActual.Cells[2].Value.ToString();
            dtpFecha.Text = filaActual.Cells[3].Value.ToString();
            textObservaciones.Text = filaActual.Cells[4].Value.ToString();
            textMedidas.Text = filaActual.Cells[5].Value.ToString();
            cbEstado.Checked = Convert.ToBoolean(filaActual.Cells[6].Value);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            grupBoxDatos.Enabled = false;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            //insertar
            try
            {
                entRequerimientosClientes c = new entRequerimientosClientes();
                c.Caracteristicas = textCaracteristicas.Text.Trim();
                c.idCliente = Convert.ToInt32(cmbCliente.SelectedValue);
                c.Observaciones = textObservaciones.Text.Trim();
                c.Medidas = textMedidas.Text.Trim();
                c.fechaRegistro = dtpFecha.Value;
                c.estReqCli = cbEstado.Checked;
                logRequerimientosClientes.Instancia.InsertaRequerimientosCliente(c);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            LimpiarVariables();
            grupBoxDatos.Enabled = false;
            listarRequerimientoCliente();
        }

        private void btnDeshabilitar_Click(object sender, EventArgs e)
        {
            try
            {
                entRequerimientosClientes c = new entRequerimientosClientes();

                c.RequerimientosclienteID = int.Parse(txtIDReqClientes.Text.Trim());
                cbEstado.Checked = false;
                c.estReqCli = cbEstado.Checked;
                logRequerimientosClientes.Instancia.DeshabilitarRequerimientosCliente(c);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            LimpiarVariables();
            grupBoxDatos.Enabled = false;
            listarRequerimientoCliente();
    }
}
}
