using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class entOrdenPlanificacion
    {
        public int OrdenPlanificacionID { get; set; }
        public int IDsupervisor { get; set; }
        public int PlanoID { get; set; }
        public DateTime FechaLimite { get; set; }
        public Boolean estOP { get; set; }
    }
}
