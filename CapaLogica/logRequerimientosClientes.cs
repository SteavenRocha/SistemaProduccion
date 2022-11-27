using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class logRequerimientosClientes
    {
        #region sigleton
        private static readonly logRequerimientosClientes _instancia = new logRequerimientosClientes();
        public static logRequerimientosClientes Instancia
        {
            get
            {
                return logRequerimientosClientes._instancia;
            }
        }
        #endregion singleton

        #region metodos

        ///listado
        public List<entRequerimientosClientes> ListarRequerimientoCliente()
        {
            return datRequerimientosCliente.Instancia.ListarRequerimientoCliente();
        }

        ///inserta
        public void InsertaRequerimientosCliente(entRequerimientosClientes Cli)
        {
            datRequerimientosCliente.Instancia.InsertarRequerimientoCliente(Cli);
        }

        public void DeshabilitarRequerimientosCliente(entRequerimientosClientes Cli)
        {
            datRequerimientosCliente.Instancia.DeshabilitarRequerimientoCliente(Cli);
        }
        #endregion metodos
    }
}
