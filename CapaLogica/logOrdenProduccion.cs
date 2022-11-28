using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class logOrdenProduccion
    {
        #region sigleton
        private static readonly logOrdenProduccion _instancia = new logOrdenProduccion();

        public static logOrdenProduccion Instancia
        {
            get
            {
                return logOrdenProduccion._instancia;
            }
        }
        #endregion singleton

        #region metodos

        ///listado
        public List<entOrdenProduccion> ListarOrdenProduccion()
        {
            return datOrdenProduccion.Instancia.ListarOrdenProduccion();
        }
        ///inserta
        public void InsertaOrdenProduccion(entOrdenProduccion Cli)
        {
            datOrdenProduccion.Instancia.InsertarOrdenProduccion(Cli);
        }

        public void DeshabilitarOrdenProduccion(entOrdenProduccion Cli)
        {
            datOrdenProduccion.Instancia.DeshabilitarOrdenProduccion(Cli);
        }
        #endregion metodos
    }
}
