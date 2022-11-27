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
    public class datNombreCliente
    {
        #region sigleton
        private static readonly datNombreCliente _instancia = new datNombreCliente();
        public static datNombreCliente Instancia
        {
            get
            {
                return datNombreCliente._instancia;
            }
        }
        #endregion singleton

        #region metodos
        //listado 
        public List<entNombreCliente> ListarNombreCliente()
        {
            SqlCommand cmd = null;
            List<entNombreCliente> lista = new List<entNombreCliente>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar(); //singleton
                cmd = new SqlCommand("spListarReqClientes", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entNombreCliente Cli = new entNombreCliente();
                    Cli.idCliente = Convert.ToInt32(dr["idCliente"]);
                    Cli.nombresCompletos = dr["nombresCompletos"].ToString();
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
        #endregion metodos
    }
}
