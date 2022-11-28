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
    public partial class OrdenPlanificacion : Form
    {
        public OrdenPlanificacion()
        {
            InitializeComponent();
            listarOrdenPlanificacion();
            grupBoxDatos.Enabled = false;
            txtOrdenPlanificacion.Enabled = false;
        }

        private void listarOrdenPlanificacion()
        {
            dgvOatos.DataSource = logOrdenPlanificacion.Instancia.ListarOrdenPlanificacion();
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
            txtOrdenPlanificacion.Text = "";
            textIDsupervisor.Text = " ";
            txtIDplano.Text = " ";
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            grupBoxDatos.Enabled = false;
        }

        private void btnDeshabilitar_Click(object sender, EventArgs e)
        {
            try
            {
                entOrdenPlanificacion c = new entOrdenPlanificacion();

                c.OrdenPlanificacionID = int.Parse(txtOrdenPlanificacion.Text.Trim());
                cbEstado.Checked = false;
                c.estOP = cbEstado.Checked;
                logOrdenPlanificacion.Instancia.DeshabilitarOrdenPlanificacion(c);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            LimpiarVariables();
            grupBoxDatos.Enabled = false;
            listarOrdenPlanificacion();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                entOrdenPlanificacion c = new entOrdenPlanificacion(); 
                c.IDsupervisor = int.Parse(textIDsupervisor.Text.Trim());
                c.PlanoID = int.Parse(txtIDplano.Text.Trim());
                c.FechaLimite = dtpFechaLimite.Value;
                c.estOP = cbEstado.Checked;
                logOrdenPlanificacion.Instancia.InsertaOrdenPlanificacion(c);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            LimpiarVariables();
            grupBoxDatos.Enabled = false;
            listarOrdenPlanificacion();
        }

        private void dgvOatos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow filaActual = dgvOatos.Rows[e.RowIndex]; //
            txtOrdenPlanificacion.Text = filaActual.Cells[0].Value.ToString();
            textIDsupervisor.Text = filaActual.Cells[1].Value.ToString();
            txtIDplano.Text = filaActual.Cells[2].Value.ToString();
            dtpFechaLimite.Text = filaActual.Cells[3].Value.ToString();
            cbEstado.Checked = Convert.ToBoolean(filaActual.Cells[4].Value);
        }
    }
}
