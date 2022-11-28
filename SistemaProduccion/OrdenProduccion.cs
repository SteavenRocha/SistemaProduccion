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
    public partial class OrdenProduccion : Form
    {
        public OrdenProduccion()
        {
            InitializeComponent();
            listarOrdenProduccion();
            grupBoxDatos.Enabled = false;
            txtOrdenProduccion.Enabled = false;
        }

        private void listarOrdenProduccion()
        {
            dgvOatos.DataSource = logOrdenProduccion.Instancia.ListarOrdenProduccion();
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
            txtOrdenProduccion.Text = "";
            textIDsupervisor.Text = " ";
            txtIDplanificacion.Text = "";
            textIDoperarios.Text = " ";
            textHorarios.Text = " ";
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            grupBoxDatos.Enabled = false;
        }

        private void btnDeshabilitar_Click(object sender, EventArgs e)
        {
            try
            {
                entOrdenProduccion c = new entOrdenProduccion();

                c.OrdenProduccionID = int.Parse(txtOrdenProduccion.Text.Trim());
                cbEstado.Checked = false;
                c.estOProdcuccion = cbEstado.Checked;
                logOrdenProduccion.Instancia.DeshabilitarOrdenProduccion(c);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            LimpiarVariables();
            grupBoxDatos.Enabled = false;
            listarOrdenProduccion();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            //insertar
            try
            {
                entOrdenProduccion c = new entOrdenProduccion();
                c.IDsupervisor = int.Parse(textIDsupervisor.Text.Trim());
                c.OrdenPlanificacionID = int.Parse(txtIDplanificacion.Text.Trim());
                c.IDoperarios = int.Parse(textIDoperarios.Text.Trim());
                c.Horarios = textHorarios.Text.Trim();
                c.estOProdcuccion = cbEstado.Checked;
                logOrdenProduccion.Instancia.InsertaOrdenProduccion(c);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            LimpiarVariables();
            grupBoxDatos.Enabled = false;
            listarOrdenProduccion();
        }

        private void dgvOatos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow filaActual = dgvOatos.Rows[e.RowIndex]; //
            txtOrdenProduccion.Text = filaActual.Cells[0].Value.ToString();
            textIDsupervisor.Text = filaActual.Cells[1].Value.ToString();
            txtIDplanificacion.Text = filaActual.Cells[2].Value.ToString();
            textIDoperarios.Text = filaActual.Cells[3].Value.ToString();
            textHorarios.Text = filaActual.Cells[4].Value.ToString();
            cbEstado.Checked = Convert.ToBoolean(filaActual.Cells[5].Value);
        }
    }
}
