using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class logCategoriaMueble
    {
        #region sigleton
        private static readonly logCategoriaMueble _instancia = new logCategoriaMueble();
        public static logCategoriaMueble Instancia
        {
            get
            {
                return logCategoriaMueble._instancia;
            }
        }
        #endregion singleton

        #region metodos

        //listado

        public List<entCategoriaMueble> ListarCategoriaMueble()
        {
            return datCategoriaMueble.Instancia.ListarCategoriaMueble();
        }

        ///inserta
        public void InsertarCategoriaMueble(entCategoriaMueble Cli)
        {
            datCategoriaMueble.Instancia.InsertarCategoriaMueble(Cli);
        }

        //edita
        public void EditaCategoriaMueble(entCategoriaMueble Cli)
        {
            datCategoriaMueble.Instancia.EditarCategoriaMueble(Cli);
        }
        public void DeshabilitarCategoriaMueble(entCategoriaMueble Cli)
        {
            datCategoriaMueble.Instancia.DeshabilitarCategoriaMueble(Cli);
        }

        #endregion metodos
    }
}
