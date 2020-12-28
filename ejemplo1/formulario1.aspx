<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="formulario1.aspx.cs" Inherits="ejemplo1.formulario1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 44%;
            height: 281px;
        }
        .auto-style2 {
            width: 132px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table class="auto-style1">
                <tr>
                    <td class="auto-style2">
                        <asp:Label ID="numero1" runat="server" Text="Numero 1"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="tbnumero1" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2">
                        <asp:Label ID="numero2" runat="server" Text="Numero 2"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="tbnumero2" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2">
                        <asp:Label ID="resultado" runat="server" Text="Resultado"></asp:Label>
                    </td>
                    <td>
                        <asp:Label ID="lbresultado" runat="server"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td>
                        <asp:Button ID="btncalcular" runat="server" OnClick="btncalcular_Click" Text="Calcular" />
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
