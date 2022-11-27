using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class datReqCliente
    {
        #region sigleton
        private static readonly datReqCliente _instancia = new datReqCliente();
        public static datReqCliente Instancia
        {
            get
            {
                return datReqCliente._instancia;
            }
        }
        #endregion singleton

        #region metodos
        //listado 
        public List<entReqCliente> ListarReCliente()
        {
            SqlCommand cmd = null;
            List<entReqCliente> lista = new List<entReqCliente>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar(); //singleton
                cmd = new SqlCommand("spListarRequerimientosClientes", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entReqCliente Cli = new entReqCliente();
                    Cli.RequerimientosclienteID = Convert.ToInt32(dr["RequerimientosclienteID"]);
                    Cli.Caracteristicas = dr["Caracteristicas"].ToString();
                    lista.Add(Cli);
                }

            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                cmd.Connection.Close();
            }
            return lista;
        }
        #endregion metodos
    }
}
