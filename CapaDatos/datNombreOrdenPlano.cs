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
    public class datNombreOrdenPlano
    {
        #region sigleton
        private static readonly datNombreOrdenPlano _instancia = new datNombreOrdenPlano();
        public static datNombreOrdenPlano Instancia
        {
            get
            {
                return datNombreOrdenPlano._instancia;
            }
        }
        #endregion singleton

        #region metodos
        //listado 
        public List<entNombreOrdenPlano> ListarNombreOrdenPlano()
        {
            SqlCommand cmd = null;
            List<entNombreOrdenPlano> lista = new List<entNombreOrdenPlano>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar(); //singleton
                cmd = new SqlCommand("spListarNombreOrdenPlano", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entNombreOrdenPlano Cli = new entNombreOrdenPlano();
                    Cli.OrdenPlanoID = Convert.ToInt32(dr["OrdenPlanoID"]);
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
