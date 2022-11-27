using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class entRequerimientosClientes
    {
        public int RequerimientosclienteID { get; set; }
        public string Caracteristicas { get; set; }
        public int idCliente { get; set; }
        public DateTime fechaRegistro { get; set; }
        public string Observaciones { get; set; }      /// public entCiudad Ciudad{ get; set; }
        public string Medidas { get; set; }
        public Boolean estReqCli { get; set; }
    }
}
