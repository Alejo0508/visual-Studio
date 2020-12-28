using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using capaEntidad;
using capaNegocio;
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
    }
}