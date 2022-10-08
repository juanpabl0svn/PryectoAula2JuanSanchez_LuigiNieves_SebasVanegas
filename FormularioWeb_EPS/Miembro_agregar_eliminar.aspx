<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Miembro_agregar_eliminar.aspx.cs" Inherits="FormularioWeb_EPS.Estadisticas_proyecto" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 111px;
        }
        .auto-style2 {
            width: 185px;
        }
        .auto-style5 {
            width: 482px;
        }
        .auto-style6 {
            width: 100%;
        }
        .auto-style9 {
            width: 161px;
        }
        .auto-style10 {
            width: 184px;
        }
        .auto-style11 {
            width: 340px;
        }
        .auto-style12 {
            width: 111px;
            height: 30px;
        }
        .auto-style13 {
            width: 185px;
            height: 30px;
        }
        .auto-style14 {
            width: 482px;
            height: 30px;
        }
        .auto-style15 {
            height: 30px;
        }
    </style>
</head>
<body>
    
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label2" runat="server" Text="Modificar miembro" style=" font-weight: bold;"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<br />
            <br />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <table style="width:100%;">
                <tr>
                    <td class="auto-style12">
                        <asp:Label ID="Label1" runat="server" Text="Id del proyecto"></asp:Label>
                    </td>
                    <td class="auto-style13">
                        <asp:TextBox ID="txtProyectoAEncontrar" runat="server"></asp:TextBox>
                    </td>
                    <td class="auto-style14">
                        <asp:Button ID="btnBuscarProy" runat="server" Text="Buscar" OnClick="btnBuscarProy_Click" />
                    </td>
                    <td class="auto-style15">

                        <asp:Button ID="btnSalir" runat="server" Text="Salir" OnClick="btnSalir_Click" />

                        </td>
                    <td class="auto-style15">

                        &nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style1">&nbsp;</td>
                    <td class="auto-style2">&nbsp;</td>
                    <td class="auto-style5">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style1">

                        <asp:Label ID="lbError_EncontrarProyecto" runat="server" Font-Bold="True" ForeColor="#FF3300"></asp:Label>

                        </td>
                    <td class="auto-style2">&nbsp;</td>
                    <td class="auto-style5">&nbsp;</td>
                </tr>
            </table>
        </div>
        <table id="tblModificaciones" class="auto-style6">
            <tr>
                <td class="auto-style10">
                    <asp:Label ID="lblModificar" runat="server" Text="¿Que desea realizar?" Visible="False"></asp:Label>
                </td>
                <td class="auto-style9">
                    <asp:RadioButtonList ID="rbOpciones" runat="server" Visible="False">
                        <asp:ListItem>Agregar</asp:ListItem>
                        <asp:ListItem>Eliminar</asp:ListItem>
                    </asp:RadioButtonList>
                </td>
                <td class="auto-style11">

                        <asp:Button ID="btnIr" runat="server" Text="Ir" OnClick="btnIr_Click" Visible="False" Width="47px" />

                    </td>
                <td>

                        <asp:Label ID="lblFuncioa" runat="server" Font-Bold="True" ForeColor="Lime"></asp:Label>

                    </td>
            </tr>
            <tr>
                <td class="auto-style10">&nbsp;</td>
                <td class="auto-style9">&nbsp;</td>
                <td class="auto-style11">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style10">
                    <asp:Label ID="lblAccion" runat="server" Text="Id del miembro a eliminar" Visible="False"></asp:Label>
                </td>
                <td class="auto-style9">
                    <asp:TextBox ID="txtNuevo" runat="server" Visible="False"></asp:TextBox>
                </td>
                <td class="auto-style11" colspan="1">
                        <asp:Button ID="btnEliminar" runat="server" Text="Eliminar" Visible="False" OnClick="btnEliminar_Click" />
                    </td>
            </tr>
            <tr>
                <td>

                </td>
                <td>

                </td>
                <td>

                        <asp:Button ID="btnCancelar" runat="server" Text="Cancelar" Visible="False" OnClick="btnCancelar_Click" />

                </td>
                
            </tr>
            
        </table>
    <table style="width:100%;">
        <tr>
                    <td class="auto-style9">

                        <asp:Label ID="lblregistrarUser" runat="server" Text="Registrar usuarios" Visible="False"></asp:Label>

                    </td>
                    <td class="auto-style5">

                        <asp:Label ID="lbError_user" runat="server" Font-Bold="True" ForeColor="#FF3300"></asp:Label>

                        <asp:Label ID="lblGuardado" runat="server" Font-Bold="True" ForeColor="Lime"></asp:Label>

                    </td>

                </tr>
                
                <tr>
                    <td class="auto-style9">

                    </td>
                    <td class="auto-style5">

                    </td>

                </tr>
                
                <tr>
                    <td class="auto-style9">

                        <asp:Label ID="lblId" runat="server" Text="ID" Visible="False"></asp:Label>

                    </td>
                    <td class="auto-style5">

                        <asp:TextBox ID="txtId" runat="server" Visible="False"></asp:TextBox>
                        
                    </td>


                </tr>
                <tr>
                    <td class="auto-style9">

                        <asp:Label ID="lblNombre_user" runat="server" Text="Nombre" Visible="False"></asp:Label>

                    </td>
                    <td class="auto-style5">

                        <asp:TextBox ID="txtNombre_user" runat="server" Visible="False"></asp:TextBox>
                        
                    </td>


                </tr>
                <tr>
                    <td class="auto-style9">

                        <asp:Label ID="lblApellido_user" runat="server" Text="Apellido" Visible="False"></asp:Label>

                    </td>
                    <td class="auto-style5">

                        <asp:TextBox ID="txtApellido_user" runat="server" Visible="False"></asp:TextBox>
                        
                    </td>


                </tr>







                <tr>
                    <td class="auto-style11">
                        
                        <asp:Label ID="lblCorreoUser" runat="server" Text="Correo" Visible="False"></asp:Label>

                    </td>
                    <td>

                        <asp:TextBox ID="txtCorreo_user" runat="server" Visible="False"></asp:TextBox>
                        
                    </td>

                </tr>
                <tr>
                    <td class="auto-style8">

                        <asp:Label ID="lbllRol" runat="server" Text="Rol" Visible="False"></asp:Label>

                    </td>
                    <td class="auto-style6">

                        <asp:DropDownList ID="Rol_user" runat="server" Visible="False">
                            <asp:ListItem>Seleccionar</asp:ListItem>
                            <asp:ListItem>Director</asp:ListItem>
                            <asp:ListItem>Gerente</asp:ListItem>
                            <asp:ListItem>Ingeniero</asp:ListItem>
                            <asp:ListItem>Financiero</asp:ListItem>
                        </asp:DropDownList>
                        
                    </td>
                </tr>
                <tr>
                    <td class="auto-style11">

                    </td>
                    <td>

                    </td>
                </tr>
                <tr>
                    <td class="auto-style11">

                        <asp:Button ID="btnGuardar_miembro" runat="server" OnClick="btnGuardar_miembro_Click" Text="Registrar miembro" Visible="False" />
                    </td>
                    <td>

                        &nbsp;</td>
                </tr>
        <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
    </table>
    </form>
    </body>
</html>
