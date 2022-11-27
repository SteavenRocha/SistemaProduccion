using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class logNombrePlano
    {
        #region sigleton
        private static readonly logNombrePlano _instancia = new logNombrePlano();
        public static logNombrePlano Instancia
        {
            get
            {
                return logNombrePlano._instancia;
            }
        }
        #endregion singleton

        #region metodos

        ///listado
        public List<entNombrePlano> ListarNombrePlano()
        {
            return datNombrePlano.Instancia.ListarNombrePlano();
        }
        #endregion metodos
    }
}
