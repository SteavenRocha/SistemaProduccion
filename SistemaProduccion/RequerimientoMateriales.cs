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
    public partial class RequerimientoMateriales : Form
    {
        public RequerimientoMateriales()
        {
            InitializeComponent();
            listarRequerimientoClientes();
            grupBoxDatos.Enabled = false;
            txtIDReqMateriales.Enabled = false;
        }

        private void listarRequerimientoClientes()
        {
            dgvReqMateriales.DataSource = logRequerimientoMateriales.Instancia.ListarRequerimientoMateriales();
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
           // btnModificar.Visible = false;
        }

        private void LimpiarVariables()
        {
            txtIDReqMateriales.Text = "";
            textHnecesarias.Text = " ";
            textIDordenP.Text = "";
            textMaterialesN.Text = " ";
        }

        private void btnDeshabilitar_Click(object sender, EventArgs e)
        {
            try
            {
                entRequerimientoMateriales c = new entRequerimientoMateriales();

                c.RequerimientoMaterialesID = int.Parse(txtIDReqMateriales.Text.Trim());
                cbEstado.Checked = false;
                c.estRM = cbEstado.Checked;
                logRequerimientoMateriales.Instancia.DeshabilitarRequerimientoMateriales(c);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            LimpiarVariables();
            grupBoxDatos.Enabled = false;
            listarRequerimientoClientes();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            //insertar
            try
            {
                entRequerimientoMateriales c = new entRequerimientoMateriales();
                c.HerramientasNecesarias = textHnecesarias.Text.Trim();
                c.OrdenPlanificacionID = int.Parse(textIDordenP.Text.Trim());
                c.MaterialesNecesarios = textMaterialesN.Text.Trim();
                c.FechaRegistro = dtpFecha.Value;
                c.estRM = cbEstado.Checked;
                logRequerimientoMateriales.Instancia.InsertaRequerimientoMateriales(c);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            LimpiarVariables();
            grupBoxDatos.Enabled = false;
            listarRequerimientoClientes();

        }

        private void dgvReqMateriales_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow filaActual = dgvReqMateriales.Rows[e.RowIndex]; //
            txtIDReqMateriales.Text = filaActual.Cells[0].Value.ToString();
            textHnecesarias.Text = filaActual.Cells[1].Value.ToString();
            textIDordenP.Text = filaActual.Cells[2].Value.ToString();
            textMaterialesN.Text = filaActual.Cells[3].Value.ToString();
            dtpFecha.Text = filaActual.Cells[4].Value.ToString();
            cbEstado.Checked = Convert.ToBoolean(filaActual.Cells[5].Value);
        }
    }
}
