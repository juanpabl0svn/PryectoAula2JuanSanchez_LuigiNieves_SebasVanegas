<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Ver_proyectos.aspx.cs" Inherits="FormularioWeb_EPS.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 132px;
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
                        <asp:Label ID="Label1" runat="server" Text="Proyectos registrados " style=" font-weight: bold;"></asp:Label>
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
                <td class="auto-style1" align ="left">
            <asp:Button ID="btnMostrar" runat="server" OnClick="btnMostrar_Click" Text="Mostrar" />
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
