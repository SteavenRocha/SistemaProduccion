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
    public class datMueble
    {
        #region sigleton
        private static readonly datMueble _instancia = new datMueble();
        public static datMueble Instancia
        {
            get
            {
                return datMueble._instancia;
            }
        }
        #endregion singleton

        #region metodos
        //listado 
        public List<entMueble> ListarMueble()
        {
            SqlCommand cmd = null;
            List<entMueble> lista = new List<entMueble>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar(); //singleton
                cmd = new SqlCommand("spListaMueble", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entMueble Cli = new entMueble();
                    Cli.MuebleID = Convert.ToInt32(dr["MuebleID"]);
                    Cli.IDsupervisor = Convert.ToInt32(dr["IDsupervisor"]);
                    Cli.CategoriaID = Convert.ToInt32(dr["CategoriaID"]);
                    Cli.estMueble = Convert.ToBoolean(dr["estMueble"]);
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
        public Boolean InsertarMueble(entMueble Cli)
        {
            SqlCommand cmd = null;
            Boolean inserta = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spInsertaMueble", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@IDsupervisor", Cli.IDsupervisor);
                cmd.Parameters.AddWithValue("@CategoriaID", Cli.CategoriaID);
                cmd.Parameters.AddWithValue("@estMueble", Cli.estMueble);
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
        public Boolean EditarMueble(entMueble Cli)
        {
            SqlCommand cmd = null;
            Boolean edita = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spEditaMueble", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@MuebleID", Cli.MuebleID);
                cmd.Parameters.AddWithValue("@IDsupervisor", Cli.IDsupervisor);
                cmd.Parameters.AddWithValue("@CategoriaID", Cli.CategoriaID);
                cmd.Parameters.AddWithValue("@estMueble", Cli.estMueble);
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

        public Boolean DeshabilitarMueble(entMueble Cli)
        {
            SqlCommand cmd = null;
            Boolean delete = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spDeshabilitaMueble", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@MuebleID", Cli.MuebleID);
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
