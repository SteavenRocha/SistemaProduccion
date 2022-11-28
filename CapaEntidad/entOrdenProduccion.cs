using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class entOrdenProduccion
    {
        public int OrdenProduccionID { get; set; }
        public int IDsupervisor { get; set; }
        public int OrdenPlanificacionID { get; set; }
        public int IDoperarios { get; set; }
        public string Horarios { get; set; }
        public Boolean estOProdcuccion { get; set; }
    }
}
