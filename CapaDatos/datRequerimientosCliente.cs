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
    public class datRequerimientosCliente
    {
        #region sigleton
        private static readonly datRequerimientosCliente _instancia = new datRequerimientosCliente();
        public static datRequerimientosCliente Instancia
        {
            get
            {
                return datRequerimientosCliente._instancia;
            }
        }
        #endregion singleton

        #region metodos
        //listado 
        public List<entRequerimientosClientes> ListarRequerimientoCliente()
        {
            SqlCommand cmd = null;
            List<entRequerimientosClientes> lista = new List<entRequerimientosClientes>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar(); //singleton
                cmd = new SqlCommand("spListasReqCliente", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entRequerimientosClientes Cli = new entRequerimientosClientes();
                    Cli.RequerimientosclienteID = Convert.ToInt32(dr["RequerimientosclienteID"]);
                    Cli.Caracteristicas = dr["Caracteristicas"].ToString();
                    Cli.idCliente = Convert.ToInt32(dr["idCliente"]);
                    Cli.Observaciones = dr["Observaciones"].ToString();
                    Cli.Medidas = dr["Medidas"].ToString();
                    Cli.fechaRegistro = Convert.ToDateTime(dr["fechaRegistro"]);
                    Cli.estReqCli = Convert.ToBoolean(dr["estReqCli"]);
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
        public Boolean InsertarRequerimientoCliente(entRequerimientosClientes Cli)
        {
            SqlCommand cmd = null;
            Boolean inserta = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spInsertaReqCliente", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Caracteristicas", Cli.Caracteristicas);
                cmd.Parameters.AddWithValue("@idCliente", Cli.idCliente);
                cmd.Parameters.AddWithValue("@Observaciones", Cli.Observaciones);
                cmd.Parameters.AddWithValue("@Medidas", Cli.Medidas);
                cmd.Parameters.AddWithValue("@fechaRegistro", Cli.fechaRegistro);
                cmd.Parameters.AddWithValue("@estReqCli", Cli.estReqCli);
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
        public Boolean DeshabilitarRequerimientoCliente(entRequerimientosClientes Cli)
        {
            SqlCommand cmd = null;
            Boolean delete = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spDeshabilitaReqCliente", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@RequerimientosclienteID", Cli.RequerimientosclienteID);
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
