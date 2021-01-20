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

        public bool Guardar_empleado(CEempleado oempleado)
        {

            try
            {

                ocmd.CommandType = CommandType.StoredProcedure;
                ocmd.Connection = oconexion.conectar("BDEjemplo");

                ocmd.CommandText = "Actualizar_empleado";

                ocmd.Parameters.Add("@cod_empleado", oempleado.Cod_empleado);
                ocmd.Parameters.Add("@nom_empleado", oempleado.Nom_empleado);
                ocmd.Parameters.Add("@edad_empleado", oempleado.Edad_empleado);
                ocmd.Parameters.Add("@sexo_empledo", oempleado.Sexo_empledo);
                ocmd.Parameters.Add("@sueldo_empl", oempleado.Sueldo_empl);

                ocmd.ExecuteNonQuery();
                return true;


            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            
            }
        
        }

        public DataSet Consultar_empleado(CEempleado oempleado)
        {

            try
            {

                ocmd.CommandType = CommandType.StoredProcedure;
                ocmd.Connection = oconexion.conectar("BDEjemplo");

                ocmd.CommandText = "consultar_empleado";
                ocmd.Parameters.Add("@cod_empleado", oempleado.Cod_empleado);

                SqlDataAdapter da = new SqlDataAdapter(ocmd);
                DataSet ds = new DataSet();
                da.Fill(ds);

                return ds;
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);

            }


        }


    }
}
