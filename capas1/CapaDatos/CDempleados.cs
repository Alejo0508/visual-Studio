using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// se agregan librerias para poder establecer la conexion

using CapaEntidad; // siempre se que se refencie la libreria que hace la conexion a la bd se debe usar 
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace CapaDatos
{
    public class CDempleados
    {

        // se instancia una libreria sqlconection para poder establecer conexion

        SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["sqlconex"].ConnectionString); // en ConnectionStrings["sqlconex"] se pone la variable que se nombro en app.config

        // se crea procedimiento publico para establecer toda la conexion

        public DataTable D_listado()
        {

            SqlCommand cmd = new SqlCommand("sp_listar", cn); // se crea comando para usar la conexion

            cmd.CommandType = CommandType.StoredProcedure; // esto inicia el comando de la conexion anterior

            SqlDataAdapter da = new SqlDataAdapter(cmd); // se crea el adaptador de la conexion

            DataTable dt = new DataTable(); // se crea variable para almacenar una nueba tabla de datos

            da.Fill(dt); // se le pasa a la variable da toda la informacion que tiene dt

            return dt; // se retornan los datos

        
        }

    }
}
