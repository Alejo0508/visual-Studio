using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using capaentidad;
using System.Configuration;

using System.Data.SqlClient;
using System.Data;

namespace capadatos
{
   public class CDempleado
    {

        SqlConnection cn =  new SqlConnection(ConfigurationManager.ConnectionStrings["sqlconex"].ConnectionString);

        public DataTable D_listado()
        {

           // este metodo envia un listado de empleados pero en un datatable

            SqlCommand cmd = new SqlCommand("sp_listar", cn);

            cmd.CommandType = CommandType.StoredProcedure;

            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();

            da.Fill(dt);

            return dt;

        }



    }

}
