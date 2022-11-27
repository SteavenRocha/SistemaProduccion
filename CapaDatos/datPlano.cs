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
    public class datPlano
    {
        #region sigleton
        private static readonly datPlano _instancia = new datPlano();
        public static datPlano Instancia
        {
            get
            {
                return datPlano._instancia;
            }
        }
        #endregion singleton

        #region metodos
        //listado 
        public List<entPlano> ListarPlano()
        {
            SqlCommand cmd = null;
            List<entPlano> lista = new List<entPlano>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar(); //singleton
                cmd = new SqlCommand("spListaPlano", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entPlano Cli = new entPlano();
                    Cli.PlanoID = Convert.ToInt32(dr["PlanoID"]);
                    Cli.IDdiseñador = Convert.ToInt32(dr["IDdiseñador"]);
                    Cli.OrdenPlanoID = Convert.ToInt32(dr["OrdenPlanoID"]);
                    Cli.TipoID = Convert.ToInt32(dr["TipoID"]);
                    Cli.estaPlano = Convert.ToBoolean(dr["estaPlano"]);
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
        public Boolean InsertarPlano(entPlano Cli)
        {
            SqlCommand cmd = null;
            Boolean inserta = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spInsertaPlano", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@IDdiseñador", Cli.IDdiseñador);
                cmd.Parameters.AddWithValue("@OrdenPlanoID", Cli.OrdenPlanoID);
                cmd.Parameters.AddWithValue("@TipoID", Cli.TipoID);
                cmd.Parameters.AddWithValue("@estaPlano", Cli.estaPlano);
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
        //Edita
        public Boolean EditarPlano(entPlano Cli)
        {
            SqlCommand cmd = null;
            Boolean edita = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spEditaPlano", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@PlanoID", Cli.PlanoID);
                cmd.Parameters.AddWithValue("@IDdiseñador", Cli.IDdiseñador);
                cmd.Parameters.AddWithValue("@OrdenPlanoID", Cli.OrdenPlanoID);
                cmd.Parameters.AddWithValue("@TipoID", Cli.TipoID);
                cmd.Parameters.AddWithValue("@estaPlano", Cli.estaPlano);
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

        public Boolean DeshabilitarPlano(entPlano Cli)
        {
            SqlCommand cmd = null;
            Boolean delete = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spDeshabilitaPlano", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@PlanoID", Cli.PlanoID);
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
