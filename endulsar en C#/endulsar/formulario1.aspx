<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="formulario1.aspx.cs" Inherits="endulsar.formulario1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 336px;
        }
        .auto-style3 {
            width: 336px;
            height: 23px;
        }
        .auto-style4 {
            height: 23px;
            width: 537px;
        }
        .auto-style5 {
            width: 537px;
        }
        .auto-style6 {
            width: 336px;
            height: 26px;
        }
        .auto-style7 {
            width: 537px;
            height: 26px;
        }
    </style>
</head>
<body style="width: 786px; height: 255px; margin-left: 300px; margin-top: 100px; text-align:center">
    <form id="form1" runat="server">
        <div style="text-align:center">
            Pedidos Endulsar</div>
        <table class="auto-style1">
            <tr>
                <td class="auto-style6">Pedido</td>
                <td class="auto-style7">
                    <asp:TextBox ID="tbpedido" runat="server" Width="256px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">Producto</td>
                <td class="auto-style4">
                    <asp:TextBox ID="tbproducto" runat="server" Width="256px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">Cantidad</td>
                <td class="auto-style5">
                    <asp:TextBox ID="tbcantidad" runat="server" Width="255px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">Datos del Cliente</td>
                <td class="auto-style5">
                    <asp:TextBox ID="tbcliente" runat="server" Width="256px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">Fecha del pedido</td>
                <td class="auto-style5">
                    <asp:TextBox ID="tbFechaPedido" runat="server" Width="256px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">Fecha de entrega</td>
                <td class="auto-style5">
                    <asp:TextBox ID="tbFechaEntrega" runat="server" Width="256px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">Total</td>
                <td class="auto-style5">
                    <asp:TextBox ID="tbTotal" runat="server" Width="255px" ReadOnly="True"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style5">
                    <asp:Label ID="tbrespuesta" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style5">
                    <asp:Button ID="btnGuardar" runat="server" Text="Guardar" BackColor="#99CCFF" OnClick="btnGuardar_Click" />
                    <asp:Button ID="btnConsultar" runat="server" Text="Consultar" style="margin-left: 50px; margin-right: 50px" BackColor="#99CCFF" Font-Bold="False" OnClick="btnConsultar_Click" />
                    <asp:Button ID="btnEliminar" runat="server" Text="Eliminar" BackColor="#99CCFF" />
                </td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style5">&nbsp;</td>
            </tr>
        </table>
    </form>
</body>
</html>
