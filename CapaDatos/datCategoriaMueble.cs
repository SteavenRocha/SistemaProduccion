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
    public class datCategoriaMueble
    {
        #region sigleton
        private static readonly datCategoriaMueble _instancia = new datCategoriaMueble();
        public static datCategoriaMueble Instancia
        {
            get
            {
                return datCategoriaMueble._instancia;
            }
        }
        #endregion singleton

        #region metodos
        //listado
        public List<entCategoriaMueble> ListarCategoriaMueble()
        {
            SqlCommand cmd = null;
            List<entCategoriaMueble> lista = new List<entCategoriaMueble>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar(); //singleton
                cmd = new SqlCommand("spListasCategoriaMuebles", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entCategoriaMueble Cli = new entCategoriaMueble();
                    Cli.CategoriaMuebleID = Convert.ToInt32(dr["CategoriaMuebleID"]);
                    Cli.nombreCategoria = dr["nombreCategoria"].ToString();
                    Cli.estaCategoria = Convert.ToBoolean(dr["estaCategoria"]);
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
        public Boolean InsertarCategoriaMueble(entCategoriaMueble Cli)
        {
            SqlCommand cmd = null;
            Boolean inserta = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spInsertaCategoriaMuebles", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@nombreCategoria", Cli.nombreCategoria);
                cmd.Parameters.AddWithValue("@estaCategoria", Cli.estaCategoria);
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
        public Boolean EditarCategoriaMueble(entCategoriaMueble Cli)
        {
            SqlCommand cmd = null;
            Boolean edita = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spEditaCategoriaMuebles", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@CategoriaMuebleID", Cli.CategoriaMuebleID);
                cmd.Parameters.AddWithValue("@nombreCategoria", Cli.nombreCategoria);
                cmd.Parameters.AddWithValue("@estaCategoria", Cli.estaCategoria);
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
        public Boolean DeshabilitarCategoriaMueble(entCategoriaMueble Cli)
        {
            SqlCommand cmd = null;
            Boolean delete = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spDeshabilitaCategoriaMuebles", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@CategoriaMuebleID", Cli.CategoriaMuebleID);
               // cmd.Parameters.AddWithValue("@estaCategoria", Cli.estaCategoria);
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
