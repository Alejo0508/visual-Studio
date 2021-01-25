using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using CapaEntidad;
using CapaNegocio;
using System.Data;

namespace endulsar
{
    public partial class formulario1 : System.Web.UI.Page
    {

        CNpedido onpedido = new CNpedido();
        CEpedido oepedido = new CEpedido();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {

            double totalFinal;
            double total = Convert.ToDouble(tbTotal.Text);
            int cantidadProducto = Convert.ToInt32(tbcantidad.Text);

            oepedido.Id_producto1 = Convert.ToInt32(tbproducto.Text);
            oepedido.Id_cliente1 = Convert.ToInt32(tbcliente.Text);
            oepedido.Cantidad_producto = cantidadProducto;
            oepedido.Fecha_creacion = tbFechaPedido.Text;
            oepedido.Fecha_entrega = tbFechaEntrega.Text;

            totalFinal = cantidadProducto * total;

            oepedido.Total = totalFinal;


            if (onpedido.crear_pedido(oepedido))
            {
                tbrespuesta.Text = "Pedido Guardado";
            }
            else
            {
                tbrespuesta.Text = "No se pudo guardar pedido";
            }


        }

        protected void btnConsultar_Click(object sender, EventArgs e)
        {

            DataSet ds = new DataSet();

            oepedido.Id_pedido = Convert.ToInt32(tbpedido.Text);

            ds = onpedido.consultar_pedido(oepedido);

            if (ds.Tables[0].Rows.Count == 0)
            {
                tbrespuesta.Text = "No hay pedido";
            }
            else
            {

                    tbrespuesta.Text = ds.Tables[0].Rows[0]["id_cliente1"].ToString();

                    tbpedido.Text = ds.Tables[0].Rows[0]["id_pedido"].ToString();
                    tbproducto.Text = ds.Tables[0].Rows[0]["id_producto1"].ToString();
                    tbcantidad.Text = ds.Tables[0].Rows[0]["cantidad_producto"].ToString();
                    tbcliente.Text = ds.Tables[0].Rows[0]["id_cliente1"].ToString();
                    tbFechaPedido.Text = ds.Tables[0].Rows[0]["fecha_creacion"].ToString();
                    tbFechaEntrega.Text = ds.Tables[0].Rows[0]["fecha_entrega"].ToString();
                    tbTotal.Text = ds.Tables[0].Rows[0]["total"].ToString();


            }


        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {

            oepedido.Id_pedido = Convert.ToInt32(tbpedido.Text);

            if (onpedido.eliminar_pedido(oepedido))
            {
                tbrespuesta.Text = " pedido eliminado correctamente";
            }
            else
            {
                tbrespuesta.Text = "No se pudo eliminado pedido";
            }

        }

        protected void btnlimpiar_Click(object sender, EventArgs e)
        {


            tbpedido.Text = "";
            tbcantidad.Text = "";
            tbcliente.Text = "";
            tbFechaEntrega.Text = "";
            tbFechaPedido.Text = "";
            tbproducto.Text = "";
            tbTotal.Text = "";
            tbrespuesta.Text = "";

        }
    }
}