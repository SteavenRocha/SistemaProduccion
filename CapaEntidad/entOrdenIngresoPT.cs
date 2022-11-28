using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class entOrdenIngresoPT
    {
        public int OrdenIngresoptID { get; set; }
        public int IDsupervisor { get; set; }
        public int OrdenProduccionID { get; set; }
        public DateTime FechaRegistro { get; set; }
        public int IDmueble { get; set; }
        public Boolean estOPT { get; set; }
    }
}
