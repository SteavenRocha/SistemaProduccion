using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class logNombreCliente
    {
        #region sigleton
        private static readonly logNombreCliente _instancia = new logNombreCliente();
        public static logNombreCliente Instancia
        {
            get
            {
                return logNombreCliente._instancia;
            }
        }
        #endregion singleton

        #region metodos

        ///listado
        public List<entNombreCliente> ListarNombreCliente()
        {
            return datNombreCliente.Instancia.ListarNombreCliente();
        }
        #endregion metodos
    }
}
