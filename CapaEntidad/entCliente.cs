using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class entCliente
    {
        public int idCliente { get; set; }
        public string DNICliente { get; set; }
        public string Ntelefono { get; set; }
        public DateTime fecRegCliente { get; set; }
        public string nombresCompletos { get; set; }     
        public Boolean estadoCliente { get; set; }

    }
}
