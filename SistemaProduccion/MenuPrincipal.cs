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
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RequerimientosCliente frm = new RequerimientosCliente();
            frm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MantenedorClientes frm = new MantenedorClientes();
            frm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MantenedorMuebles frm = new MantenedorMuebles();
            frm.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MantenedorCategoriaMueble frm = new MantenedorCategoriaMueble();
            frm.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            OrdenPlano frm = new OrdenPlano();
            frm.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MantenedorPlano frm = new MantenedorPlano();
            frm.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            MantenedorTipoPlano frm = new MantenedorTipoPlano();
            frm.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            OrdenPlanificacion frm = new OrdenPlanificacion();
            frm.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            RequerimientoMateriales frm = new RequerimientoMateriales();
            frm.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            OrdenProduccion frm = new OrdenProduccion();
            frm.Show();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            OrdenIngresoPT frm = new OrdenIngresoPT();
            frm.Show();
        }
    }
}
