using CapaDatos;
using CapaEntidad;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class LogTipoPlano
    {
        #region sigleton
        private static readonly LogTipoPlano _instancia = new LogTipoPlano();
        public static LogTipoPlano Instancia
        {
            get
            {
                return LogTipoPlano._instancia;
            }
        }
        #endregion singleton

        #region metodos

        ///listado

        public List<entTipoPlano> ListarTipoPlano()
        {
            return datTipoPlano.Instancia.ListarTipoPlano();
        }
        ///inserta
        public void InsertaTipoPlano(entTipoPlano LisTP)
        {
            datTipoPlano.Instancia.InsertarTipoPlano(LisTP);
        }

        //edita
        public void EditaTipoPlano(entTipoPlano LisTP)
        {
            datTipoPlano.Instancia.EditarTipoPlano(LisTP);
        }
        /*public void DeshabilitarTipoPlano(entTipoPlano LisTP)
        {
            datTipoPlano.Instancia.DeshabilitarTipoPlano(LisTP);
        }*/
        #endregion metodos


    }
}
