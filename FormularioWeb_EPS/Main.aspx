<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Main.aspx.cs" Inherits="FormularioWeb_EPS.Main" Trace="false" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 773px;
        }
        .auto-style2 {
            width: 269px;
        }
        .auto-style3 {
            height: 23px;
        }
        .auto-style4 {
            height: 23px;
            width: 31px;
        }
        .auto-style5 {
            width: 31px;
        }
        .auto-style6 {
            width: 773px;
            height: 30px;
        }
        .auto-style7 {
            width: 269px;
            height: 30px;
        }
        .auto-style8 {
            height: 30px;
        }
    </style>
</head>
<body style="height: 208px">
    <form id="form1" runat="server">
        <br />
        <br />
        <br />
        <br />
        <br />
        <table style="width:100%;">
            <tr>
                <td class="auto-style4"></td>
                <td class="auto-style3" align="left">
                    <asp:Label ID="Label1" runat="server" Text="Aplicacion del gobierno" style=" font-weight: bold;"></asp:Label>
                </td>
                <td class="auto-style3"></td>
            </tr>
            <tr>
                <td class="auto-style5">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style4"></td>
                <td class="auto-style3"></td>
                <td class="auto-style3"></td>
            </tr>
        </table>
        <br />
        <br />
        <br />
        <br />
        <br />
        <table style="width:100%;" >
            <tr>
                <td class="auto-style1">&nbsp;</td>
                <td class="auto-style2" style="background-color: #FFFFFF" aria-sort="none">
                    &nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style6"></td>

                <td class="auto-style7"  aria-sort="none" align="center">
                    <asp:Button ID="btnVerProy" runat="server" Text="Ver proyectos" OnClick="btnVerProy_Click"  Width="150px" />
                </td>
                <td class="auto-style8"></td>
            </tr>
            <tr>
                <td class="auto-style1">&nbsp;</td>
                <td class="auto-style2"  aria-sort="none" align="center">
                    <asp:Button ID="btnRegistrarProy" runat="server" Text="Registrar proyecto" OnClick="btnRegistrarProy_Click" Width="150px" />
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1">&nbsp;</td>
                <td class="auto-style2"  aria-sort="none" align="center">
                    <asp:Button ID="btnModificar_proyecto" runat="server" Text="Modificar proyecto" OnClick="btnModificar_proyecto_Click" Width="150px" />
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1">&nbsp;</td>
                <td class="auto-style2"  aria-sort="none" align="center">
                    <asp:Button ID="btnEstadisticaProy" runat="server" Text="Estadisticas proyectos" Width="150px" OnClick="btnEstadisticaProy_Click" />
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1">&nbsp;</td>
                <td class="auto-style2"  aria-sort="none" align="center">
                    <asp:Button ID="btnAgregar_eliminar_miembro" runat="server" Text="Agregar/Eliminar miembro" Width="150px" OnClick="btnAgregar_eliminar_miembro_Click" />
                </td>
                <td>&nbsp;</td>
            </tr>
        </table>
        <div>
            <asp:Button ID="btnEjemplos" runat="server" OnClick="btnEjemplos_Click" Text="Crear ejemplos" Width="100px" />
        </div>
    </form>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
</body>
</html>
