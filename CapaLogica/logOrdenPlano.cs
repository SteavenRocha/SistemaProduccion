using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class logOrdenPlano
    {
        #region sigleton
        private static readonly logOrdenPlano _instancia = new logOrdenPlano();
        public static logOrdenPlano Instancia
        {
            get
            {
                return logOrdenPlano._instancia;
            }
        }
        #endregion singleton

        #region metodos

        ///listado
        public List<entOrdenPlano> ListarOrdenPlano()
        {
            return datOrdenPlano.Instancia.ListarOrdenPlano();
        }

        ///inserta
        public void InsertaOrdenPlano(entOrdenPlano Cli)
        {
            datOrdenPlano.Instancia.InsertarOrdenPlano(Cli);
        }

        public void DeshabilitarOrdenPlano(entOrdenPlano Cli)
        {
            datOrdenPlano.Instancia.DeshabilitarOrdenPlano(Cli);
        }
        #endregion metodos
    }
}
