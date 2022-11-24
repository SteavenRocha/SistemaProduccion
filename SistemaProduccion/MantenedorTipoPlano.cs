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
    public partial class MantenedorTipoPlano : Form
    {
        public MantenedorTipoPlano()
        {
            InitializeComponent();
            listarTipoPlano();
            grupBoxTipoPlanos.Enabled = false;
            txtIDtipoPlano.Enabled = false;
        }

        public void listarTipoPlano()
        {
            dgvTipoPlano.DataSource = LogTipoPlano.Instancia.ListarTipoPlano(); 
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            grupBoxTipoPlanos.Enabled = true;

            btnAgregar.Visible = true;
            LimpiarVariables();
            btnModificar.Visible = false;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            grupBoxTipoPlanos.Enabled = true;
            btnModificar.Visible = true;
            btnAgregar.Visible = false;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            //insertar
            try
            {
                entTipoPlano c = new entTipoPlano();
                c.descripcionTipoPlano = txtDescripcion.Text.Trim();

                LogTipoPlano.Instancia.InsertaTipoPlano(c);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            LimpiarVariables();
            grupBoxTipoPlanos.Enabled = false;
            listarTipoPlano();
        }

        private void LimpiarVariables()
        {
            txtDescripcion.Text = " ";
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                entTipoPlano c = new entTipoPlano();
                c.IDtipoPlano = int.Parse(txtIDtipoPlano.Text.Trim());
                c.descripcionTipoPlano = txtDescripcion.Text.Trim();
                LogTipoPlano.Instancia.EditaTipoPlano(c);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            LimpiarVariables();
            grupBoxTipoPlanos.Enabled = false;
            listarTipoPlano();
        }

        private void dgvTipoPlano_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow filaActual = dgvTipoPlano.Rows[e.RowIndex]; //
            txtIDtipoPlano.Text = filaActual.Cells[0].Value.ToString();
            txtDescripcion.Text = filaActual.Cells[1].Value.ToString();
        }
    }
}
