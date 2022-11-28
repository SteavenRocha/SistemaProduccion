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
    public class datOrdenProduccion
    {
        #region sigleton

        private static readonly datOrdenProduccion _instancia = new datOrdenProduccion();

        public static datOrdenProduccion Instancia
        {
            get
            {
                return datOrdenProduccion._instancia;
            }
        }
        #endregion singleton

        #region metodos
        //listado 
        public List<entOrdenProduccion> ListarOrdenProduccion()
        {
            SqlCommand cmd = null;
            List<entOrdenProduccion> lista = new List<entOrdenProduccion>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spListaOrdenProduccion", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entOrdenProduccion Cli = new entOrdenProduccion();
                    Cli.OrdenProduccionID = Convert.ToInt32(dr["OrdenProduccionID"]);
                    Cli.IDsupervisor = Convert.ToInt32(dr["IDsupervisor"]);
                    Cli.OrdenPlanificacionID = Convert.ToInt32(dr["OrdenPlanificacionID"]);
                    Cli.IDoperarios = Convert.ToInt32(dr["IDoperarios"]);
                    Cli.Horarios = dr["Horarios"].ToString();
                    Cli.estOProdcuccion = Convert.ToBoolean(dr["estOProdcuccion"]);
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
        public Boolean InsertarOrdenProduccion(entOrdenProduccion Cli)
        {
            SqlCommand cmd = null;
            Boolean inserta = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spInsertaOrdenProduccion", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@IDsupervisor", Cli.IDsupervisor);
                cmd.Parameters.AddWithValue("@OrdenPlanificacionID", Cli.OrdenPlanificacionID);
                cmd.Parameters.AddWithValue("@IDoperarios", Cli.IDoperarios);
                cmd.Parameters.AddWithValue("@Horarios", Cli.Horarios);
                cmd.Parameters.AddWithValue("@estOProdcuccion", Cli.estOProdcuccion);
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

        public Boolean DeshabilitarOrdenProduccion(entOrdenProduccion Cli)
        {
            SqlCommand cmd = null;
            Boolean delete = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spDeshabilitaOrdenProduccion", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@OrdenProduccionID", Cli.OrdenProduccionID);
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
