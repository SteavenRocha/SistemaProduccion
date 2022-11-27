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
    public class datNombrePlano
    {
        #region sigleton
        private static readonly datNombrePlano _instancia = new datNombrePlano();
        public static datNombrePlano Instancia
        {
            get
            {
                return datNombrePlano._instancia;
            }
        }
        #endregion singleton

        #region metodos
        //listado 
        public List<entNombrePlano> ListarNombrePlano()
        {
            SqlCommand cmd = null;
            List<entNombrePlano> lista = new List<entNombrePlano>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar(); //singleton
                cmd = new SqlCommand("spListarNombreTipoPlano", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entNombrePlano Cli = new entNombrePlano();
                    Cli.TipoPlanoID = Convert.ToInt32(dr["TipoPlanoID"]);
                    Cli.DescripcionPlano = dr["DescripcionPlano"].ToString();
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
