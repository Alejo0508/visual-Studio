<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Frmpresentacion.aspx.cs" Inherits="intersoftware.Frmpresentacion" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 46%;
            height: 234px;
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
            width: 1538px;
        }
        .auto-style5 {
            width: 1538px;
        }
        .auto-style6 {
            width: 211px;
            height: 26px;
        }
        .auto-style7 {
            width: 1538px;
            height: 26px;
        }
    </style>
</head>
<body style="width: 1260px">
    <form id="form1" runat="server">
        <div>
            <table class="auto-style1">
                <tr>
                    <td class="auto-style3">cod_empleado:</td>
                    <td class="auto-style4">
                        <asp:TextBox ID="tbcodempleado" runat="server" Width="243px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">nom_empleado</td>
                    <td class="auto-style5">
                        <asp:TextBox ID="tbnomempleado" runat="server" Width="243px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">edad_empleado</td>
                    <td class="auto-style5">
                        <asp:TextBox ID="tbedad" runat="server" Width="244px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style6">sexo_empledo</td>
                    <td class="auto-style7">
                        <asp:TextBox ID="tbsexo" runat="server" Width="243px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">sueldo_empl</td>
                    <td class="auto-style5">
                        <asp:TextBox ID="tbsueldo" runat="server" Width="244px"></asp:TextBox>
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
                        <asp:Button ID="btnguardar" runat="server" Text="Guardar" OnClick="Button1_Click" />
                        <asp:Button ID="btnconsultar" runat="server" OnClick="btnconsultar_Click" Text="Consultar" />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3"></td>
                    <td class="auto-style4">
                        &nbsp;</td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
