using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ejemplo1
{
    public partial class formulario1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btncalcular_Click(object sender, EventArgs e)
        {

            int num1, num2, resultado;

            // datos de entrada

            num1 = Convert.ToInt32(tbnumero1.Text);
            num2 = Convert.ToInt32(tbnumero2.Text);

            // proceso

            resultado = num1 + num2;

            //salida

            lbresultado.Text = System.Convert.ToString(resultado);



        }
    }
}