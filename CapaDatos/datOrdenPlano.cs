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
    public class datOrdenPlano
    {
        #region sigleton
        private static readonly datOrdenPlano _instancia = new datOrdenPlano();
        public static datOrdenPlano Instancia
        {
            get
            {
                return datOrdenPlano._instancia;
            }
        }
        #endregion singleton

        #region metodos
        //listado 
        public List<entOrdenPlano> ListarOrdenPlano()
        {
            SqlCommand cmd = null;
            List<entOrdenPlano> lista = new List<entOrdenPlano>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar(); //singleton
                cmd = new SqlCommand("spListaOrdenPlano", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entOrdenPlano Cli = new entOrdenPlano();
                    Cli.OrdenPlanoID = Convert.ToInt32(dr["OrdenPlanoID"]);
                    Cli.IDdiseñador = Convert.ToInt32(dr["IDdiseñador"]);
                    Cli.RequerimientosclienteID = Convert.ToInt32(dr["RequerimientosclienteID"]);
                    Cli.FechaRegistro = Convert.ToDateTime(dr["FechaRegistro"]);
                    Cli.FechaLimite = Convert.ToDateTime(dr["FechaLimite"]);
                    Cli.estadoOP = Convert.ToBoolean(dr["estadoOP"]);
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
        //Inserta
        public Boolean InsertarOrdenPlano(entOrdenPlano Cli)
        {
            SqlCommand cmd = null;
            Boolean inserta = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spInsertaOrdenPlano", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@IDdiseñador", Cli.IDdiseñador);
                cmd.Parameters.AddWithValue("@RequerimientosclienteID", Cli.RequerimientosclienteID);
                cmd.Parameters.AddWithValue("@FechaRegistro", Cli.FechaRegistro);
                cmd.Parameters.AddWithValue("@FechaLimite", Cli.FechaLimite);
                cmd.Parameters.AddWithValue("@estadoOP", Cli.estadoOP);
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
        //deshabilita
        public Boolean DeshabilitarOrdenPlano(entOrdenPlano Cli)
        {
            SqlCommand cmd = null;
            Boolean delete = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spDeshabilitaOrdenPlano", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@OrdenPlanoID", Cli.OrdenPlanoID);
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
