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
                    LisTP.TipoPlanoID = Convert.ToInt32(dr["TipoPlanoID"]);
                    LisTP.DescripcionPlano = dr["DescripcionPlano"].ToString();
                    LisTP.estaTipoPlano = Convert.ToBoolean(dr["estaTipoPlano"]);
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
                cmd.Parameters.AddWithValue("@DescripcionPlano", LisTP.DescripcionPlano);
                cmd.Parameters.AddWithValue("@estaTipoPlano", LisTP.estaTipoPlano);
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
                cmd = new SqlCommand("spEditaTipoPlano", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@TipoPlanoID", LisTP.TipoPlanoID);
                cmd.Parameters.AddWithValue("@DescripcionPlano", LisTP.DescripcionPlano);
                cmd.Parameters.AddWithValue("@estaTipoPlano", LisTP.estaTipoPlano);
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
        //deshabilita

        public Boolean DeshabilitarTipoPlano(entTipoPlano Cli)
        {
            SqlCommand cmd = null;
            Boolean delete = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spDeshabilitaTipoPlano", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@TipoPlanoID", Cli.TipoPlanoID);
                //  cmd.Parameters.AddWithValue("@estadoCliente", Cli.estadoCliente);
                cn.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    delete = true;
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally { cmd.Connection.Close(); }
            return delete;
        }

        #endregion metodos

    }
}
