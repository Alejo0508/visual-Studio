using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using capaEntidad;

namespace capaDatos
{
    public class CDempleado
    {

        CDconexion oconexion = new CDconexion();
        SqlCommand ocmd = new SqlCommand();

        public bool guardar_empleado(CEempleado oempleado)
        {

            try
            {

                ocmd.CommandType = CommandType.StoredProcedure;
                ocmd.Connection = oconexion.conectar("BDEjemplo");
                ocmd.Parameters.Add("@cod_empleado", oempleado.Cod_empleado);

            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            
            }
        
        }


    }
}
