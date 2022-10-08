<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Estadisticas_proyecto.aspx.cs" Inherits="FormularioWeb_EPS.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 132px;
        }
        .auto-style2 {
            width: 132px;
            height: 23px;
        }
        .auto-style3 {
            height: 23px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server" align ="center">
        <div>
            <table style="width:100%;">
                <tr>
                    <td>&nbsp;</td>
                    <td align ="center">
                        <asp:Label ID="Label1" runat="server" Text="Estadisticas de los proyectos" style=" font-weight: bold;"></asp:Label>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td align ="center">
            <asp:TextBox ID="txtProyectos" runat="server" Height="484px" TextMode="MultiLine" Width="728px" MaxLength="300" ReadOnly="True" Wrap="False"></asp:TextBox>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td>

                        <asp:Label ID="lbError" runat="server" Font-Bold="True" ForeColor="#FF3300"></asp:Label>

                    </td>
                    <td>&nbsp;</td>
                </tr>
            </table>
        </div>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <table style="width:100%;">
            <tr>
                <td class="auto-style1" align ="left" align ="center">
            <asp:Button ID="btnMasDepartamentos" runat="server" OnClick="btnMasDepartamentos_Click" Text="Proyecto con mas departamentos y mas ingresos" />
                </td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1" align ="center">
                    <asp:Button ID="btnRentabilidad" runat="server" OnClick="btnRentabilidad_Click" Text="3 ideas de negocio con mas rentabilidad" />
                </td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1" align ="center">
                    <asp:Button ID="btnMas3Departamentos" runat="server" OnClick="btnMas3Departamentos_Click" Text="Ideas que impactan ams de 3 departamentos" />
                </td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1">
                    <asp:Button ID="btnsumaIngresos" runat="server" OnClick="btnsumaIngresos_Click" Text="Suma total de ingresos de los proyectos" />
                </td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:Button ID="btnSumaInversion" runat="server" OnClick="btnSumaInversion_Click" Text="Suma total de inversiones de los proyectos" />
                </td>
                <td class="auto-style3"></td>
                <td class="auto-style3"></td>
            </tr>
            <tr>
                <td class="auto-style1">
                    <asp:Button ID="btnmasHerramientas" runat="server" OnClick="btnmasHerramientas_Click" Text="Proyecto con mas herraminetas de la 4ta revolucion" />
                </td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1" align ="center">
                    <asp:Button ID="btnproyectosIA" runat="server" OnClick="btnproyectosIA_Click" Text="Cantidad de proyectos con inteligencia artificial" />
                </td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1" align="left"> 
                    <asp:Button ID="btnExit" runat="server" OnClick="btnExit_Click" Text="Salir" />
                </td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
        </table>
    </form>
</body>
</html>
