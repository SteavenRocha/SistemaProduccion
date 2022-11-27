using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class logPlano
    {
        #region sigleton
        private static readonly logPlano _instancia = new logPlano();
        public static logPlano Instancia
        {
            get
            {
                return logPlano._instancia;
            }
        }
        #endregion singleton

        #region metodos

        ///listado

        public List<entPlano> ListarTipoPlano()
        {
            return datPlano.Instancia.ListarPlano();
        }

        ///inserta
        public void InsertaPlano(entPlano Cli)
        {
            datPlano.Instancia.InsertarPlano(Cli);
        }

        //edita
        public void EditaPlano(entPlano Cli)
        {
            datPlano.Instancia.EditarPlano(Cli);
        }

        public void DeshabilitarPlano(entPlano Cli)
        {
            datPlano.Instancia.DeshabilitarPlano(Cli);
        }
        #endregion metodos
    }
}
