using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class logRequerimientoMateriales
    {
        #region sigleton
        private static readonly logRequerimientoMateriales _instancia = new logRequerimientoMateriales();

        public static logRequerimientoMateriales Instancia
        {
            get
            {
                return logRequerimientoMateriales._instancia;
            }
        }
        #endregion singleton

        #region metodos

        ///listado
        public List<entRequerimientoMateriales> ListarRequerimientoMateriales()
        {
            return datRequerimientoMateriales.Instancia.ListarRequerimientoMateriales();
        }
        ///inserta
        public void InsertaRequerimientoMateriales(entRequerimientoMateriales Cli)
        {
            datRequerimientoMateriales.Instancia.InsertarRequerimientoMateriales(Cli);
        }

        public void DeshabilitarRequerimientoMateriales(entRequerimientoMateriales Cli)
        {
            datRequerimientoMateriales.Instancia.DeshabilitarRequerimientoMateriales(Cli);
        }
        #endregion metodos
    }
}
