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
    public class datOrdenIngresoPT
    {
        #region sigleton

        private static readonly datOrdenIngresoPT _instancia = new datOrdenIngresoPT();

        public static datOrdenIngresoPT Instancia
        {
            get
            {
                return datOrdenIngresoPT._instancia;
            }
        }
        #endregion singleton

        #region metodos
        //listado 
        public List<entOrdenIngresoPT> ListarOrdenIngreso()
        {
            SqlCommand cmd = null;
            List<entOrdenIngresoPT> lista = new List<entOrdenIngresoPT>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spListaOrdenIngreso", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entOrdenIngresoPT Cli = new entOrdenIngresoPT();
                    Cli.OrdenIngresoptID = Convert.ToInt32(dr["OrdenIngresoptID"]);
                    Cli.IDsupervisor = Convert.ToInt32(dr["IDsupervisor"]);
                    Cli.OrdenProduccionID = Convert.ToInt32(dr["OrdenProduccionID"]);
                    Cli.FechaRegistro = Convert.ToDateTime(dr["FechaRegistro"]);
                    Cli.IDmueble = Convert.ToInt32(dr["IDmueble"]);
                    Cli.estOPT = Convert.ToBoolean(dr["estOPT"]);
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
        public Boolean InsertarOrdenIngreso(entOrdenIngresoPT Cli)
        {
            SqlCommand cmd = null;
            Boolean inserta = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spInsertaOrdenIngreso", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@IDsupervisor", Cli.IDsupervisor);
                cmd.Parameters.AddWithValue("@OrdenProduccionID", Cli.OrdenProduccionID);
                cmd.Parameters.AddWithValue("@FechaRegistro", Cli.FechaRegistro);
                cmd.Parameters.AddWithValue("@IDmueble", Cli.IDmueble);
                cmd.Parameters.AddWithValue("@estOPT", Cli.estOPT);
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

        public Boolean DeshabilitarOrdenIngreso(entOrdenIngresoPT Cli)
        {
            SqlCommand cmd = null;
            Boolean delete = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spDeshabilitaOrdenIngreso", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@OrdenIngresoptID", Cli.OrdenIngresoptID);
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
