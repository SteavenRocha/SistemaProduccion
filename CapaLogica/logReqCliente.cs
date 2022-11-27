using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class logReqCliente
    {
        #region sigleton
        private static readonly logReqCliente _instancia = new logReqCliente();
        public static logReqCliente Instancia
        {
            get
            {
                return logReqCliente._instancia;
            }
        }
        #endregion singleton

        #region metodos

        ///listado
        public List<entReqCliente> ListarReqCliente()
        {
            return datReqCliente.Instancia.ListarReCliente();
        }
        #endregion metodos
    }
}
