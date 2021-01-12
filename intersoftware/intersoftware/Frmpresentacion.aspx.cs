using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using capaEntidad;
using capaNegocio;
using capaDatos;
using System.Data;

namespace intersoftware
{
    public partial class Frmpresentacion : System.Web.UI.Page
    {

        CNempleado onempleado = new CNempleado();
        CEempleado oeempleado = new CEempleado();


        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            oeempleado.Cod_empleado =  Convert.ToInt32(tbcodempleado.Text);
            oeempleado.Nom_empleado = tbnomempleado.Text;
            oeempleado.Edad_empleado = Convert.ToInt32(tbedad.Text);
            oeempleado.Sexo_empledo = tbsexo.Text;
            oeempleado.Sueldo_empl = Convert.ToDouble(tbsueldo.Text);

            if (onempleado.guardar_empleado(oeempleado))
            {

                lbresultado.Text = "Empelado Guardado";

            }
            else
            {

                lbresultado.Text = "Error al guardar";
            
            }



        }

        protected void btnconsultar_Click(object sender, EventArgs e)
        {

            DataSet ds = new DataSet();

            oeempleado.Cod_empleado = Convert.ToInt32(tbcodempleado.Text);

            ds = onempleado.consultar_empleado(oeempleado);

            if (ds.Tables[0].Rows.Count == 0)
            {

                lbresultado.Text = "Empleado no existe";

            }
            else
            {

                tbnomempleado.Text = ds.Tables[0].Rows[0]["nom_empleado"].ToString();
                tbedad.Text = ds.Tables[0].Rows[0]["edad_empleado"].ToString();
                tbsexo.Text = ds.Tables[0].Rows[0]["sexo_empledo"].ToString();
                tbsueldo.Text = ds.Tables[0].Rows[0]["sueldo_empl"].ToString();

            }


        }

    }
}