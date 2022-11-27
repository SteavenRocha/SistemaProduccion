using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class logNombreOrdenPlano
    {
        #region sigleton
        private static readonly logNombreOrdenPlano _instancia = new logNombreOrdenPlano();
        public static logNombreOrdenPlano Instancia
        {
            get
            {
                return logNombreOrdenPlano._instancia;
            }
        }
        #endregion singleton

        #region metodos

        ///listado
        public List<entNombreOrdenPlano> ListarNombreOrdenPlano()
        {
            return datNombreOrdenPlano.Instancia.ListarNombreOrdenPlano();
        }
        #endregion metodos
    }
}
