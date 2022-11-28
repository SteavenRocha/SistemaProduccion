using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class logNombreMueble
    {
        #region sigleton
        private static readonly logNombreMueble _instancia = new logNombreMueble();
        public static logNombreMueble Instancia
        {
            get
            {
                return logNombreMueble._instancia;
            }
        }
        #endregion singleton

        #region metodos

        ///listado
        public List<entNombreMueble> ListarNombreMueble()
        {
            return datNombreMueble.Instancia.ListarNombreMueble();
        }
        #endregion metodos
    }
}
