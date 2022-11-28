using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaProduccion
{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new MantenedorTipoPlano());
            //Application.Run(new MantenedorClientes());
            //Application.Run(new MantenedorCategoriaMueble());
            //Application.Run(new RequerimientosCliente());
            //Application.Run(new OrdenPlano());
            //Application.Run(new MantenedorPlano());
            Application.Run(new OrdenPlanificacion());
        }
    }
}
