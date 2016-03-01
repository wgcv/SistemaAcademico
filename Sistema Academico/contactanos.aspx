<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="contactanos.aspx.cs" Inherits="Sistema_Academico.contactanos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="FeaturedContent" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">
      <h1>
        Contactanos</h1>
    <p>
        Telefono: 593-43954312<br />
        Celular: 593-997845144<br />
        Mail: <a href="mailto:ingeneria@cu.ucsg.edu.ec">ingeneria@cu.ucsg.edu.ec</a></p>
    <p>
        O puede enviarnos un mensaje</p>
    
        <center>
        <table style="width:50%;">
            <tr>
                <td class="auto-style1">&nbsp;</td>
                <td><h1>Formulario de contacto</h1></td>
            </tr>
            <tr>
                <td class="auto-style2">Nombre</td>
                <td class="auto-style3">
                    <asp:TextBox ID="lblNombre" runat="server" Width="269px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style1">E-Mail</td>
                <td>
                    <asp:TextBox ID="lblEmail" runat="server" Width="267px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style1">Mensaje</td>
                <td>
                    <asp:TextBox ID="lblMensaje" runat="server" Height="189px" Width="269px" TextMode="MultiLine"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style1">&nbsp;</td>
                <td>
                    <asp:Label ID="Label1" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style1">&nbsp;</td>
                <td>&nbsp;&nbsp;
                    <asp:Button ID="btnEnviar" runat="server" Text="Enviar" Width="86px" OnClick="btnEnviar_Click" />
&nbsp;&nbsp;
                    <asp:Button ID="btnCancelar" runat="server" Text="Cancelar" OnClick="btnCancelar_Click" />
                </td>
            </tr>
        </table>
            </center>

</asp:Content>
