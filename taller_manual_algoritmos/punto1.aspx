<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="punto1.aspx.cs" Inherits="taller_manual_algoritmos.punto1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 46%;
            height: 136px;
        }
        .auto-style2 {
            width: 343px;
        }
        .auto-style3 {
            width: 55%;
            height: 92px;
        }
        .auto-style4 {
            width: 227px;
        }
        .auto-style7 {
            width: 246px;
        }
        .auto-style9 {
            width: 190px;
        }
        .auto-style10 {
            width: 202px;
        }
        .auto-style11 {
            width: 43%;
        }
        .auto-style12 {
            width: 313px;
        }
        .auto-style13 {
            width: 56%;
            height: 47px;
        }
        .auto-style14 {
            width: 188px;
        }
        .auto-style15 {
            width: 183px;
        }
        .auto-style16 {
            width: 181px;
        }
        .auto-style17 {
            width: 44%;
            height: 130px;
        }
        .auto-style20 {
            width: 338px;
        }
        .auto-style21 {
            width: 347px;
        }
        .auto-style22 {
            width: 39%;
            height: 93px;
        }
        .auto-style24 {
            width: 250px;
        }
        .auto-style25 {
            width: 218px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Punto 1</div>
        <table id="punto1" border="1" class="auto-style1">
            <tr>
                <td class="auto-style2">
                    <asp:Label ID="lbcapitalinvertido" runat="server" Text="Capital Invertido"></asp:Label>
                </td>
                <td>
                    <asp:Label ID="lbganancia" runat="server" Text="Ganancia"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:TextBox ID="tbcapitalinvertido" runat="server"></asp:TextBox>
                </td>
                <td>
                    <asp:Label ID="lbresultadoganancia" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td>
                    <asp:Button ID="btcalculaganancia" runat="server" OnClick="btcalculaganancia_Click" Text="Calcular" />
                </td>
            </tr>
        </table>
        <br />
        <br />
        Punto 2<br />
        <table border="1" class="auto-style3">
            <tr>
                <td class="auto-style4">
                    <asp:Label ID="sueldobase" runat="server" Text="Sueldo base"></asp:Label>
                </td>
                <td class="auto-style9">
                    <asp:Label ID="lbventa1" runat="server" Text="Venta 1"></asp:Label>
                </td>
                <td class="auto-style10">
                    <asp:Label ID="lbventa2" runat="server" Text="Venta 2"></asp:Label>
                </td>
                <td class="auto-style7">
                    <asp:Label ID="lbventa3" runat="server" Text="Venta 3"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style4">
                    <asp:TextBox ID="tbsaldobase" runat="server" Width="217px"></asp:TextBox>
                </td>
                <td class="auto-style9">
                    <asp:TextBox ID="tbventa1" runat="server" Width="181px"></asp:TextBox>
                </td>
                <td class="auto-style10">
                    <asp:TextBox ID="tbventa2" runat="server" Width="194px"></asp:TextBox>
                </td>
                <td class="auto-style7">
                    <asp:TextBox ID="tbventa3" runat="server" Width="176px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style4">
                    <asp:Label ID="lbtotpag" runat="server" Text="Total a pagar"></asp:Label>
                </td>
                <td class="auto-style9">
                    <asp:Label ID="lbtotalapagar" runat="server"></asp:Label>
                </td>
                <td class="auto-style10">
                    <asp:Label ID="lbcomi" runat="server" Text="Comision"></asp:Label>
                </td>
                <td class="auto-style7">
                    <asp:Label ID="lbcomision" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style4">&nbsp;</td>
                <td class="auto-style9">&nbsp;</td>
                <td class="auto-style10">
                    <asp:Button ID="punto2" runat="server" OnClick="punto2_Click" Text="Calcular" />
                </td>
                <td class="auto-style7">&nbsp;</td>
            </tr>
        </table>
        <br />
        <br />
        Punto3<br />
        <table border="1" class="auto-style11">
            <tr>
                <td class="auto-style12">
                    <asp:Label ID="lbtotcomp" runat="server" Text="Total de la Compra"></asp:Label>
                </td>
                <td>
                    <asp:Label ID="lbtotpag2" runat="server" Text="Total a pagar"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style12">
                    <asp:TextBox ID="tbtotaldelacompra" runat="server" Width="301px"></asp:TextBox>
                </td>
                <td>
                    <asp:Label ID="lbtotalapagarpunto2" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style12">&nbsp;</td>
                <td>
                    <asp:Button ID="btcalcularpunto3" runat="server" OnClick="btcalcularpunto3_Click" Text="Calcular" />
                </td>
            </tr>
        </table>
        <br />
        <br />
        Punto 4<br />
        <table border="1" class="auto-style13">
            <tr>
                <td class="auto-style14">
                    <asp:Label ID="Label1" runat="server" Text="Calificacion 1"></asp:Label>
                </td>
                <td class="auto-style15">
                    <asp:Label ID="Label2" runat="server" Text="Calificacion 2"></asp:Label>
                </td>
                <td class="auto-style16">
                    <asp:Label ID="Label3" runat="server" Text="Calificacion 3"></asp:Label>
                </td>
                <td>
                    <asp:Label ID="Label4" runat="server" Text="Examen final"></asp:Label>
                </td>
                <td>
                    <asp:Label ID="Label5" runat="server" Text="Trabajo final"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style14">
                    <asp:TextBox ID="tbcal1punto4" runat="server" Width="173px"></asp:TextBox>
                </td>
                <td class="auto-style15">
                    <asp:TextBox ID="tbcal2punto4" runat="server" Width="199px"></asp:TextBox>
                </td>
                <td class="auto-style16">
                    <asp:TextBox ID="tbcal3punto4" runat="server" Width="178px"></asp:TextBox>
                </td>
                <td>
                    <asp:TextBox ID="tbexamenfinalpunto4" runat="server" Width="142px"></asp:TextBox>
                </td>
                <td>
                    <asp:TextBox ID="tbtrabajofinalpunto4" runat="server" Width="143px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style14">&nbsp;</td>
                <td class="auto-style15">&nbsp;</td>
                <td class="auto-style16">&nbsp;</td>
                <td>
                    <asp:Label ID="Label6" runat="server" Text="Calificacion final"></asp:Label>
                </td>
                <td>
                    <asp:Label ID="lbcalfinalpunto4" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style14">&nbsp;</td>
                <td class="auto-style15">&nbsp;</td>
                <td class="auto-style16">
                    <asp:Button ID="btpunto4" runat="server" OnClick="btpunto4_Click" Text="Calcular" Width="107px" />
                </td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
        </table>
        <br />
        <br />
        Punto 5<br />
        <table border="1" class="auto-style17">
            <tr>
                <td class="auto-style20">
                    <asp:Label ID="Label7" runat="server" Text="Cantidad de hombres"></asp:Label>
                </td>
                <td class="auto-style21">
                    <asp:Label ID="Label8" runat="server" Text="Cantidad de mujeres"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style20">
                    <asp:TextBox ID="tbcanhompunto5" runat="server" Width="316px"></asp:TextBox>
                </td>
                <td class="auto-style21">
                    <asp:TextBox ID="tbcanmujerespunto5" runat="server" Width="306px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style20">Porcentaje hombres</td>
                <td class="auto-style21">Procentaje mujeres</td>
            </tr>
            <tr>
                <td class="auto-style20">
                    <asp:Label ID="promhombrespunto5" runat="server"></asp:Label>
                </td>
                <td class="auto-style21">
                    <asp:Label ID="prommujerespunto5" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style20">&nbsp;</td>
                <td class="auto-style21">
                    <asp:Button ID="btpunto5" runat="server" OnClick="btpunto5_Click" Text="Calcular" Width="110px" />
                </td>
            </tr>
        </table>
        <br />
        <br />
        punto 6<br />
        <table border="1" class="auto-style22">
            <tr>
                <td class="auto-style25">Año de nacimiento</td>
                <td class="auto-style24">Año Actual</td>
            </tr>
            <tr>
                <td class="auto-style25">
                    <asp:TextBox ID="tbfechanacimientopunto6" runat="server" Width="266px"></asp:TextBox>
                </td>
                <td class="auto-style24">
                    <asp:TextBox ID="tbfechaactualpunto6" runat="server" Width="262px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style25">Edad</td>
                <td class="auto-style24">
                    <asp:Label ID="lbedadpunto6" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style25">
                    <asp:Button ID="btpunto6" runat="server" OnClick="btpunto6_Click" Text="Calcular" Width="114px" />
                </td>
                <td class="auto-style24">&nbsp;</td>
            </tr>
        </table>
        <br />
    </form>
</body>
</html>
