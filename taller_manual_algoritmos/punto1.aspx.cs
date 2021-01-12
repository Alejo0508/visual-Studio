using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace taller_manual_algoritmos
{
    public partial class punto1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btcalculaganancia_Click(object sender, EventArgs e)
        {
            
            double CapInvertido, ganancia;

            CapInvertido = Convert.ToDouble(tbcapitalinvertido.Text);

            ganancia = CapInvertido * 0.02;

            lbresultadoganancia.Text = System.Convert.ToString(ganancia);

        }

        protected void punto2_Click(object sender, EventArgs e)
        {

            double sueldoBase, venta1, venta2, venta3, comision, totpag, totVenta;

            sueldoBase = Convert.ToDouble(tbsaldobase.Text);
            venta1 = Convert.ToDouble(tbventa1.Text);
            venta2 = Convert.ToDouble(tbventa2.Text);
            venta3 = Convert.ToDouble(tbventa3.Text);

            totVenta = venta1 + venta2 + venta3;

            comision = totVenta * 0.10;

            totpag = sueldoBase + comision;

            lbtotalapagar.Text = System.Convert.ToString(totpag);
            lbcomision.Text = System.Convert.ToString(comision);


        }

        protected void btcalcularpunto3_Click(object sender, EventArgs e)
        {

            double totalcompra, descuento, totalpagar;

            totalcompra = Convert.ToDouble(tbtotaldelacompra.Text);

            descuento = totalcompra * 0.15;
            totalpagar = totalcompra - descuento;

            lbtotalapagarpunto2.Text = System.Convert.ToString(totalpagar);


        }

        protected void btpunto4_Click(object sender, EventArgs e)
        {

            double cal1, cal2, cal3, exafinal, trabafinal, prom, ppar, pef, ptf, calificacionfinal;

            cal1 = Convert.ToDouble(tbcal1punto4.Text);
            cal2 = Convert.ToDouble(tbcal2punto4.Text);
            cal3 = Convert.ToDouble(tbcal3punto4.Text);

            exafinal = Convert.ToDouble(tbexamenfinalpunto4.Text);
            trabafinal = Convert.ToDouble(tbtrabajofinalpunto4.Text);

            prom = (cal1 + cal2 + cal3) / 3;

            ppar = prom * 0.55;

            pef = exafinal * 0.30;
            ptf = trabafinal * 0.15;

            calificacionfinal = ppar + pef + ptf;

            lbcalfinalpunto4.Text = System.Convert.ToString(calificacionfinal);


        }

        protected void btpunto5_Click(object sender, EventArgs e)
        {

            int canhombres, canmujeres, totalumnos;
            double promhombres, prommujeres;

            canhombres = Convert.ToInt32(tbcanhompunto5.Text);
            canmujeres = Convert.ToInt32(tbcanmujerespunto5.Text);

            totalumnos = canhombres + canmujeres;

            promhombres = canhombres * 100 / totalumnos;
            prommujeres = canmujeres * 100 / totalumnos;

            promhombrespunto5.Text = System.Convert.ToString(promhombres);
            prommujerespunto5.Text = System.Convert.ToString(prommujeres);


        }

        protected void btpunto6_Click(object sender, EventArgs e)
        {

            int fechanacimiento, fechaactual, edad;

            fechanacimiento = Convert.ToInt32(tbfechanacimientopunto6.Text);
            fechaactual = Convert.ToInt32(tbfechaactualpunto6.Text);

            edad = fechaactual - fechanacimiento;

            lbedadpunto6.Text = System.Convert.ToString(edad);

        }
    }
}