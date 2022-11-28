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
    public class datOrdenPlanificacion
    {
        #region sigleton
        private static readonly datOrdenPlanificacion _instancia = new datOrdenPlanificacion();
        public static datOrdenPlanificacion Instancia
        {
            get
            {
                return datOrdenPlanificacion._instancia;
            }
        }
        #endregion singleton

        #region metodos
        //listado 
        public List<entOrdenPlanificacion> ListarOrdePlanificacion()
        {
            SqlCommand cmd = null;
            List<entOrdenPlanificacion> lista = new List<entOrdenPlanificacion>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar(); //singleton
                cmd = new SqlCommand("spListaOrdenPlanificacion", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entOrdenPlanificacion Cli = new entOrdenPlanificacion();
                    Cli.OrdenPlanificacionID = Convert.ToInt32(dr["OrdenPlanificacionID"]);
                    Cli.IDsupervisor = Convert.ToInt32(dr["IDsupervisor"]);
                    Cli.PlanoID = Convert.ToInt32(dr["PlanoID"]);
                    Cli.FechaLimite = Convert.ToDateTime(dr["FechaLimite"]);
                    Cli.estOP = Convert.ToBoolean(dr["estOP"]);
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
        public Boolean InsertarOrdenPlanificacion(entOrdenPlanificacion Cli)
        {
            SqlCommand cmd = null;
            Boolean inserta = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spInsertaOrdenPlanificacion", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@IDsupervisor", Cli.IDsupervisor);
                cmd.Parameters.AddWithValue("@PlanoID", Cli.PlanoID);
                cmd.Parameters.AddWithValue("@FechaLimite", Cli.FechaLimite);
                cmd.Parameters.AddWithValue("@estOP", Cli.estOP);
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

        public Boolean DeshabilitarOrdenPlanificacion(entOrdenPlanificacion Cli)
        {
            SqlCommand cmd = null;
            Boolean delete = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spDeshabilitaOrdenPlanificacion", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@OrdenPlanificacionID", Cli.OrdenPlanificacionID);
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
