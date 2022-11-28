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
    public class datNombreMueble
    {
        #region sigleton
        private static readonly datNombreMueble _instancia = new datNombreMueble();
        public static datNombreMueble Instancia
        {
            get
            {
                return datNombreMueble._instancia;
            }
        }
        #endregion singleton

        #region metodos
        //listado 
        public List<entNombreMueble> ListarNombreMueble()
        {
            SqlCommand cmd = null;
            List<entNombreMueble> lista = new List<entNombreMueble>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar(); //singleton
                cmd = new SqlCommand("spListaNombreMueble", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entNombreMueble Cli = new entNombreMueble();
                    Cli.CategoriaMuebleID = Convert.ToInt32(dr["CategoriaMuebleID"]);
                    Cli.nombreCategoria = dr["nombreCategoria"].ToString();
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
