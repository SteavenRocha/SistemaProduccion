using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class entMueble
    {
        public int MuebleID { get; set; }
        public int IDsupervisor { get; set; }
        public int CategoriaID { get; set; }
        public Boolean estMueble { get; set; }
    }
}
