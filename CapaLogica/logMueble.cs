using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class logMueble
    {
        #region sigleton
        private static readonly logMueble _instancia = new logMueble();
        public static logMueble Instancia
        {
            get
            {
                return logMueble._instancia;
            }
        }
        #endregion singleton

        #region metodos

        ///listado

        public List<entMueble> ListarMueble()
        {
            return datMueble.Instancia.ListarMueble();
        }

        ///inserta
        public void InsertaMueble(entMueble Cli)
        {
            datMueble.Instancia.InsertarMueble(Cli);
        }

        //edita
        public void EditaMueble(entMueble Cli)
        {
            datMueble.Instancia.EditarMueble(Cli);
        }

        public void DeshabilitarMueble(entMueble Cli)
        {
            datMueble.Instancia.DeshabilitarMueble(Cli);
        }
        #endregion metodos
    }
}
