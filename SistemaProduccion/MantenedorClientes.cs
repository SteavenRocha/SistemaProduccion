using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaEntidad;
using CapaLogica;

namespace SistemaProduccion
{
    public partial class MantenedorClientes : Form
    {
        public MantenedorClientes()
        {
            InitializeComponent();
            listarCliente();
            grupBoxDatos.Enabled = false;
            txtidCliente.Enabled = false;
        }

        public void listarCliente()
        {
            dgvCliente.DataSource = logCliente.Instancia.ListarCliente();
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
            //insertar
            try
            {
                entCliente c = new entCliente();
                c.DNICliente = txtDNICliente.Text.Trim();
                c.Ntelefono = txtNTelefono.Text.Trim();
                c.fecRegCliente = dtpFecha.Value;
                c.nombresCompletos = txtNombres.Text.Trim();
                c.estadoCliente = cbEstadoCliente.Checked;
                logCliente.Instancia.InsertaCliente(c);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            LimpiarVariables();
            grupBoxDatos.Enabled = false;
            listarCliente();

        }
        private void LimpiarVariables()
        {
            txtDNICliente.Text = "";
            txtNTelefono.Text = " ";
            txtNombres.Text = " ";
            txtidCliente.Text = " ";
            //cbkEstadoCliente.Checked = false;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dgvCliente_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow filaActual = dgvCliente.Rows[e.RowIndex]; //
            txtidCliente.Text = filaActual.Cells[0].Value.ToString();
            txtDNICliente.Text = filaActual.Cells[1].Value.ToString();
            txtNTelefono.Text = filaActual.Cells[2].Value.ToString();
            dtpFecha.Text = filaActual.Cells[3].Value.ToString();
            txtNombres.Text = filaActual.Cells[4].Value.ToString();
            cbEstadoCliente.Checked = Convert.ToBoolean(filaActual.Cells[5].Value);

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
                entCliente c = new entCliente();
                c.idCliente = int.Parse(txtidCliente.Text.Trim());
                c.DNICliente = txtDNICliente.Text.Trim();
                c.Ntelefono = txtNTelefono.Text.Trim();
                c.fecRegCliente = dtpFecha.Value;
                c.nombresCompletos = txtNombres.Text.Trim();
                c.estadoCliente = cbEstadoCliente.Checked;
                logCliente.Instancia.EditaCliente(c);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            LimpiarVariables();
            grupBoxDatos.Enabled = false;
            listarCliente();

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            grupBoxDatos.Enabled = false;
        }

        private void btnDeshabilitar_Click(object sender, EventArgs e)
        {
            try
            {
                entCliente c = new entCliente();

                c.idCliente = int.Parse(txtidCliente.Text.Trim());
                cbEstadoCliente.Checked = false;
                c.estadoCliente = cbEstadoCliente.Checked;
                logCliente.Instancia.DeshabilitarCliente(c);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            LimpiarVariables();
            grupBoxDatos.Enabled = false;
            listarCliente();
        }

        private void grupBoxDatos_Enter(object sender, EventArgs e)
        {

        }
    }
}

