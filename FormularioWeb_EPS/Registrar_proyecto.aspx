<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Registrar_proyecto.aspx.cs" Inherits="FormularioWeb_EPS.WebForm_IMC" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style3 {
            height: 26px;
        }
        .auto-style5 {
            height: 23px;
        }
        .auto-style6 {
            height: 16px;
        }
        .auto-style8 {
            width: 153px;
            height: 16px;
        }
        .auto-style9 {
            height: 23px;
            width: 153px;
        }
        .auto-style10 {
            height: 26px;
            width: 153px;
        }
        .auto-style11 {
            width: 153px;
        }
        .auto-style12 {
            height: 24px;
            width: 153px;
        }
        .auto-style13 {
            height: 24px;
        }
    </style>
</head>
<body>
   
    <form id="form1" runat="server">
        <div>

                        <asp:Label ID="Label3" runat="server" Text="Registrar proyecto" style=" font-weight: bold;"></asp:Label>

                    <br />
            <br />
            <br />
            <table style="border-style: double; width:100%;">
                <tr>
                    <td class="auto-style9">

                        <asp:Label ID="lblregistrarUser0" runat="server" Text="Registrar proyecto"></asp:Label>

                    </td>
                    <td class="auto-style5">

                        <asp:Label ID="lbError" runat="server" Font-Bold="True" ForeColor="#FF3300"></asp:Label>

                    </td>


                </tr>
                <tr>
                    <td class="auto-style9">

                    </td>
                    <td class="auto-style5">

                    </td>


                </tr>

                <tr>
                    <td class="auto-style10">
                        <asp:Label ID="nombre_proy" runat="server" Text="Nombre del proyecto"></asp:Label>
                    </td>
                    <td class="auto-style3">
                        <asp:TextBox ID="txtNombre" runat="server"></asp:TextBox>
                    </td>                    
                </tr>
                <tr>
                    <td class="auto-style11">
                        <asp:Label ID="lbInversion" runat="server" Text="Inversion"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtInversion" runat="server"></asp:TextBox>
                    </td>
                    
                </tr>
                <tr>
                    <td class="auto-style10">
                        <asp:Label ID="lbPeso" runat="server" Text="Ingresos a 3 años"></asp:Label>
                    </td>
                    <td class="auto-style3">
                        <asp:TextBox ID="txtIngresos" runat="server"></asp:TextBox>
                    </td>
                    
                </tr>
                <tr>
                    <td class="auto-style11">
                        <asp:Label ID="lbEstatura" runat="server" Text="Departamentos"></asp:Label>
                    </td>
                    <td>
                        <asp:CheckBoxList ID="CheckBoxDepartamentos" runat="server">
                            <asp:ListItem>Huila</asp:ListItem>
                            <asp:ListItem>Caquetá</asp:ListItem>
                            <asp:ListItem>Caldas</asp:ListItem>
                            <asp:ListItem>Boyacá</asp:ListItem>
                            <asp:ListItem>Bolívar</asp:ListItem>
                        </asp:CheckBoxList>
                    </td>
                    
                    
                </tr><tr>
                    <td class="auto-style9">
                        
                        <asp:Label ID="Label1" runat="server" Text="Impacto social"></asp:Label>
                    </td>
                    <td class="auto-style5">
                        
                        <asp:TextBox ID="txtImpacto_social" runat="server"></asp:TextBox>
                        
                        </td>
                    
                </tr>
                <tr>
                    <td class="auto-style11">
                        
                        <asp:Label ID="Label2" runat="server" Text="Herramientas 4ta revolucion industrial"></asp:Label>
                    </td>
                    <td>

                        <asp:CheckBoxList ID="CheckBoxHerramientas" runat="server">
                            <asp:ListItem>IA</asp:ListItem>
                            <asp:ListItem>Cloud Compúting</asp:ListItem>
                            <asp:ListItem>Firma Dígital</asp:ListItem>
                            <asp:ListItem>Biometría</asp:ListItem>
                        </asp:CheckBoxList>

                    </td>
                    
                  
                </tr>
                <tr>
                    <td class="auto-style12">

                    </td>
                    <td class="auto-style13">

                        </td>

                </tr>
                
                <tr>
                    <td class="auto-style9">

                        <asp:Label ID="lblregistrarUser" runat="server" Text="Registrar usuarios"></asp:Label>

                    </td>
                    <td class="auto-style5">

                        <asp:Label ID="lbError_user" runat="server" Font-Bold="True" ForeColor="#FF3300"></asp:Label>

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

                        <asp:Label ID="lblId" runat="server" Text="ID"></asp:Label>

                    </td>
                    <td class="auto-style5">

                        <asp:TextBox ID="txtId" runat="server"></asp:TextBox>
                        
                    </td>


                </tr>
                <tr>
                    <td class="auto-style9">

                        <asp:Label ID="lblNombre_user" runat="server" Text="Nombre"></asp:Label>

                    </td>
                    <td class="auto-style5">

                        <asp:TextBox ID="txtNombre_user" runat="server"></asp:TextBox>
                        
                    </td>


                </tr>
                <tr>
                    <td class="auto-style9">

                        <asp:Label ID="lblNombre_user0" runat="server" Text="Apellido"></asp:Label>

                    </td>
                    <td class="auto-style5">

                        <asp:TextBox ID="txtApellido_user" runat="server"></asp:TextBox>
                        
                    </td>


                </tr>







                <tr>
                    <td class="auto-style11">
                        
                        <asp:Label ID="lblNombre_user1" runat="server" Text="Correo"></asp:Label>

                    </td>
                    <td>

                        <asp:TextBox ID="txtCorreo_user" runat="server"></asp:TextBox>
                        
                    </td>

                </tr>
                <tr>
                    <td class="auto-style8">

                        <asp:Label ID="lblNombre_user2" runat="server" Text="Rol"></asp:Label>

                    </td>
                    <td class="auto-style6">

                        <asp:DropDownList ID="Rol_user" runat="server">
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

                        <asp:Button ID="btnGuardar_miembro" runat="server" OnClick="btnGuardar_miembro_Click" Text="Registrar miembro" />
                    </td>
                    <td>

                        &nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style11">

                        &nbsp;</td>
                    <td>

                        &nbsp;</td>
                </tr>
            </table>
        </div>
        <p>

                        <table style="width:100%;">
                            <tr>
                                <td>

                        <asp:Button ID="Button1" runat="server" Text="Guardar proyecto" OnClick="btnGuardar_Click" />
                        
                                </td>
                                <td>&nbsp;</td>
                                <td>&nbsp;</td>
                            </tr>
                            <tr>
                                <td>&nbsp;</td>
                                <td>&nbsp;</td>
                                <td>&nbsp;</td>
                            </tr>
                            <tr>
                                <td>

                        <asp:Button ID="btnExit" runat="server" OnClick="btnExit_Click" Text="Salir" />

                                </td>
                                <td>&nbsp;</td>
                                <td>&nbsp;</td>
                            </tr>
                        </table>
                        
                    </p>
    </form>
</body>
</html>
