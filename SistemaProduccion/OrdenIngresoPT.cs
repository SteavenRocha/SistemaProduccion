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
    public partial class OrdenIngresoPT : Form
    {
        public OrdenIngresoPT()
        {
            InitializeComponent();
            listarOrdenIngreso();
            grupBoxDatos.Enabled = false;
            txtOrdenProduccion.Enabled = false;
        }

        private void listarOrdenIngreso()
        {
            dgvOatos.DataSource = logOrdenIngresoPT.Instancia.ListarOrdenIngreso();
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
            txtIDmueble.Text = "";
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            grupBoxDatos.Enabled = false;
        }

        private void btnDeshabilitar_Click(object sender, EventArgs e)
        {
            try
            {
                entOrdenIngresoPT c = new entOrdenIngresoPT();

                c.OrdenIngresoptID = int.Parse(txtOrdenProduccion.Text.Trim());
                cbEstado.Checked = false;
                c.estOPT = cbEstado.Checked;
                logOrdenIngresoPT.Instancia.DeshabilitarOrdenIngreso(c);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            LimpiarVariables();
            grupBoxDatos.Enabled = false;
            listarOrdenIngreso();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            //insertar
            try
            {
                entOrdenIngresoPT c = new entOrdenIngresoPT();
                c.IDsupervisor = int.Parse(textIDsupervisor.Text.Trim());
                c.OrdenProduccionID = int.Parse(txtIDplanificacion.Text.Trim());
                c.FechaRegistro = dateFecha.Value;
                c.IDmueble = int.Parse(txtIDmueble.Text.Trim());
                c.estOPT = cbEstado.Checked;
                logOrdenIngresoPT.Instancia.InsertaOrdenIngreso(c);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            LimpiarVariables();
            grupBoxDatos.Enabled = false;
            listarOrdenIngreso();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dgvOatos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow filaActual = dgvOatos.Rows[e.RowIndex]; //
            txtOrdenProduccion.Text = filaActual.Cells[0].Value.ToString();
            textIDsupervisor.Text = filaActual.Cells[1].Value.ToString();
            txtIDplanificacion.Text = filaActual.Cells[2].Value.ToString();
            dateFecha.Text = filaActual.Cells[3].Value.ToString();
            txtIDmueble.Text = filaActual.Cells[4].Value.ToString();
            cbEstado.Checked = Convert.ToBoolean(filaActual.Cells[5].Value);
           
        }
    }
}
