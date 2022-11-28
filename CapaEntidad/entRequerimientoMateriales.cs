using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class entRequerimientoMateriales
    {
        public int RequerimientoMaterialesID { get; set; }
        public string HerramientasNecesarias { get; set; }
        public int OrdenPlanificacionID { get; set; }
        public string MaterialesNecesarios { get; set; }
        public DateTime FechaRegistro { get; set; }     
        public Boolean estRM { get; set; }
    }
}
