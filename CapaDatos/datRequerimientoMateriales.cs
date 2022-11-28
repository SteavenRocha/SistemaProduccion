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
    public class datRequerimientoMateriales
    {
        #region sigleton

        private static readonly datRequerimientoMateriales _instancia = new datRequerimientoMateriales();

        public static datRequerimientoMateriales Instancia
        {
            get
            {
                return datRequerimientoMateriales._instancia;
            }
        }
        #endregion singleton

        #region metodos
        //listado 
        public List<entRequerimientoMateriales> ListarRequerimientoMateriales()
        {
            SqlCommand cmd = null;
            List<entRequerimientoMateriales> lista = new List<entRequerimientoMateriales>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spListaRequerimientoMateriales", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entRequerimientoMateriales Cli = new entRequerimientoMateriales();
                    Cli.RequerimientoMaterialesID = Convert.ToInt32(dr["RequerimientoMaterialesID"]);
                    Cli.HerramientasNecesarias = dr["HerramientasNecesarias"].ToString();
                    Cli.OrdenPlanificacionID = Convert.ToInt32(dr["OrdenPlanificacionID"]);
                    Cli.MaterialesNecesarios = dr["MaterialesNecesarios"].ToString();
                    Cli.FechaRegistro = Convert.ToDateTime(dr["FechaRegistro"]);
                    Cli.estRM = Convert.ToBoolean(dr["estRM"]);
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
        public Boolean InsertarRequerimientoMateriales(entRequerimientoMateriales Cli)
        {
            SqlCommand cmd = null;
            Boolean inserta = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spInsertaRequerimientoMateriales", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@HerramientasNecesarias", Cli.HerramientasNecesarias);
                cmd.Parameters.AddWithValue("@OrdenPlanificacionID", Cli.OrdenPlanificacionID);
                cmd.Parameters.AddWithValue("@MaterialesNecesarios", Cli.MaterialesNecesarios);
                cmd.Parameters.AddWithValue("@FechaRegistro", Cli.FechaRegistro);
                cmd.Parameters.AddWithValue("@estRM", Cli.estRM);
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

        public Boolean DeshabilitarRequerimientoMateriales(entRequerimientoMateriales Cli)
        {
            SqlCommand cmd = null;
            Boolean delete = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spDeshabilitaRequerimientoMateriales", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@RequerimientoMaterialesID", Cli.RequerimientoMaterialesID);
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
