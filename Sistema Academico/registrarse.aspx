<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="registrarse.aspx.cs" Inherits="Sistema_Academico.registrarse" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
    <style type="text/css">
        .auto-style1 {
            height: 26px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="FeaturedContent" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">
    <center>
    <table style="width:auto;">
        <tr>
            <td>&nbsp;</td>
            <td><b>Crear una nueva cuenta</b></td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>Nombre</td>
            <td>
                <asp:TextBox ID="txtNombre" runat="server" MaxLength="50" Width="222px"></asp:TextBox>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>Apellido</td>
            <td>
                <asp:TextBox ID="txtApellido" runat="server" MaxLength="50" Width="222px"></asp:TextBox>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>Carrera</td>
            <td>
                <asp:DropDownList ID="ddlcarrera" runat="server" Width="222px">
                    <asp:ListItem>Ingeniería de Sistemas</asp:ListItem>
                    <asp:ListItem>Ingeniería Civil</asp:ListItem>
                </asp:DropDownList>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style1">Correo</td>
            <td class="auto-style1">
                <asp:TextBox ID="txtCorreo" runat="server" MaxLength="50" TextMode="Email" Width="222px"></asp:TextBox>
            </td>
            <td class="auto-style1"></td>
        </tr>
        <tr>
            <td class="auto-style1">Usuario</td>
            <td class="auto-style1">
                <asp:TextBox ID="txtUsuario" runat="server" MaxLength="50" Width="222px"></asp:TextBox>
            </td>
            <td class="auto-style1"></td>
        </tr>
        <tr>
            <td>Password</td>
            <td>
                <asp:TextBox ID="txtPassword1" runat="server" MaxLength="50" TextMode="Password" Width="222px"></asp:TextBox>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>Confirmar Password</td>
            <td>
                <asp:TextBox ID="txtPassword2" runat="server" MaxLength="50" TextMode="Password" Width="222px"></asp:TextBox>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>Pregunta de recuperación</td>
            <td>
                <asp:DropDownList ID="ddlpregunta" runat="server" AutoPostBack="True" Width="222px">
                    <asp:ListItem Value="1">¿Cual es el nombre de tu colegio?</asp:ListItem>
<asp:ListItem>¿Cual es el nombre de tu mama?</asp:ListItem>
<asp:ListItem>¿Que marca es tu carro?</asp:ListItem>
<asp:ListItem>¿Cual fue tu primer ceular?</asp:ListItem>
                </asp:DropDownList>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>Respuesta</td>
            <td>
                <asp:TextBox ID="txtRespuesta" runat="server" Height="16px" MaxLength="50" Width="222px"></asp:TextBox>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>&nbsp;
                <asp:Label ID="lblError" runat="server"></asp:Label>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>
                <asp:Button ID="btnRegistrar" runat="server" Height="26px" OnClick="btnRegistrar_Click" Text="Registrarme" />
&nbsp;&nbsp;
                <asp:Button ID="btnCancelar" runat="server" OnClick="btnCancelar_Click" Text="Cancelar" />
            </td>
            <td>&nbsp;</td>
        </tr>
    </table>
        </center>
</asp:Content>
