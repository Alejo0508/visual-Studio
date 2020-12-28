using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CapaEntidad;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace CapaDatos
{
    public class CDpiloto
    {

        SqlConnection conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["sqlconexion"].ConnectionString);

        public DataTable D_listado()
        {

            SqlCommand comando = new SqlCommand("sp_listarpiloto", conexion);

            comando.CommandType = CommandType.StoredProcedure;

            SqlDataAdapter adaptador = new SqlDataAdapter(comando);

            DataTable tablaDatos = new DataTable();

            adaptador.Fill(tablaDatos);

            return tablaDatos;
        
        
        
        }
       


    }
}
