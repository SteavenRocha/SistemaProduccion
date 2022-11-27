using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class entPlano
    {
        public int PlanoID { get; set; }
        public int IDdiseñador { get; set; }
        public int OrdenPlanoID { get; set; }
        public int TipoID { get; set; }
        public Boolean estaPlano { get; set; }
    }
}
