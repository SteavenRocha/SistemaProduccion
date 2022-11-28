using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class logOrdenPlanificacion
    {
        #region sigleton
        private static readonly logOrdenPlanificacion _instancia = new logOrdenPlanificacion();

        public static logOrdenPlanificacion Instancia
        {
            get
            {
                return logOrdenPlanificacion._instancia;
            }
        }
        #endregion singleton

        #region metodos

        ///listado
        public List<entOrdenPlanificacion> ListarOrdenPlanificacion()
        {
            return datOrdenPlanificacion.Instancia.ListarOrdePlanificacion();
        }
        ///inserta
        public void InsertaOrdenPlanificacion(entOrdenPlanificacion Cli)
        {
            datOrdenPlanificacion.Instancia.InsertarOrdenPlanificacion(Cli);
        }

        public void DeshabilitarOrdenPlanificacion(entOrdenPlanificacion Cli)
        {
            datOrdenPlanificacion.Instancia.DeshabilitarOrdenPlanificacion(Cli);
        }
        #endregion metodos
    }
}
