<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Frmpresentacion.aspx.cs" Inherits="intersoftware.Frmpresentacion" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 38%;
            height: 148px;
        }
        .auto-style2 {
            width: 211px;
        }
        .auto-style3 {
            width: 211px;
            height: 23px;
        }
        .auto-style4 {
            height: 23px;
            width: 1313px;
        }
        .auto-style5 {
            width: 1313px;
        }
        .auto-style6 {
            width: 211px;
            height: 26px;
        }
        .auto-style7 {
            width: 1313px;
            height: 26px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table class="auto-style1">
                <tr>
                    <td class="auto-style3">cod_empleado:</td>
                    <td class="auto-style4">
                        <asp:TextBox ID="tbcodempleado" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">nom_empleado</td>
                    <td class="auto-style5">
                        <asp:TextBox ID="tbnomempleado" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">edad_empleado</td>
                    <td class="auto-style5">
                        <asp:TextBox ID="tbedad" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style6">sexo_empledo</td>
                    <td class="auto-style7">
                        <asp:TextBox ID="tbsexo" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">sueldo_empl</td>
                    <td class="auto-style5">
                        <asp:TextBox ID="tbsueldo" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td class="auto-style5">
                        <asp:Label ID="lbresultado" runat="server"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td class="auto-style5">
                        <asp:Button ID="Button1" runat="server" Text="Consultar" OnClick="Button1_Click" />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3"></td>
                    <td class="auto-style4"></td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
