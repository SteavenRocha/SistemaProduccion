using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class logOrdenIngresoPT
    {
        #region sigleton
        private static readonly logOrdenIngresoPT _instancia = new logOrdenIngresoPT();

        public static logOrdenIngresoPT Instancia
        {
            get
            {
                return logOrdenIngresoPT._instancia;
            }
        }
        #endregion singleton

        #region metodos

        ///listado
        public List<entOrdenIngresoPT> ListarOrdenIngreso()
        {
            return datOrdenIngresoPT.Instancia.ListarOrdenIngreso();
        }
        ///inserta
        public void InsertaOrdenIngreso(entOrdenIngresoPT Cli)
        {
            datOrdenIngresoPT.Instancia.InsertarOrdenIngreso(Cli);
        }

        public void DeshabilitarOrdenIngreso(entOrdenIngresoPT Cli)
        {
            datOrdenIngresoPT.Instancia.DeshabilitarOrdenIngreso(Cli);
        }
        #endregion metodos
    }
}
