using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class entOrdenPlano
    {
        public int OrdenPlanoID { get; set; }
        public int IDdiseñador { get; set; }
        public int RequerimientosclienteID { get; set; }
        public DateTime FechaRegistro { get; set; }
        public DateTime FechaLimite { get; set; }      /// public entCiudad Ciudad{ get; set; }
        public Boolean estadoOP { get; set; }
    }
}
