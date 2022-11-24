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
    public class datTipoPlano
    {
        #region sigleton

        private static readonly datTipoPlano _instancia = new datTipoPlano();
 
        public static datTipoPlano Instancia
        {
            get
            {
                return datTipoPlano._instancia;
            }
        }
        #endregion singleton

        #region metodos
        ////////////////////listado
        public List<entTipoPlano> ListarTipoPlano()
        {
            SqlCommand cmd = null;
            List<entTipoPlano> lista = new List<entTipoPlano>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar(); //singleton
                cmd = new SqlCommand("spListaTipoPlano", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entTipoPlano LisTP = new entTipoPlano();
                    LisTP.IDtipoPlano = Convert.ToInt32(dr["IDtipoPlano"]);
                    LisTP.descripcionTipoPlano = dr["descripcionTipoPlano"].ToString();
                    lista.Add(LisTP);
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
        /////////////////////////Inserta
        public Boolean InsertarTipoPlano(entTipoPlano LisTP)
        {
            SqlCommand cmd = null;
            Boolean inserta = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spInsertaTipoPlano", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@descripcionTipoPlano", LisTP.descripcionTipoPlano);
                cn.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    inserta = true;
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally { cmd.Connection.Close(); }
            return inserta;
        }


        //////////////////////////////////Edita
        public Boolean EditarTipoPlano(entTipoPlano LisTP)
        {
            SqlCommand cmd = null;
            Boolean edita = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spEditaListaPlano", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@IDtipoPlano", LisTP.IDtipoPlano);
                cmd.Parameters.AddWithValue("@descripcionTipoPlano", LisTP.descripcionTipoPlano);
                cn.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    edita = true;
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally { cmd.Connection.Close(); }
            return edita;
        }

        #endregion metodos

    }
}
