<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="recuperar.aspx.cs" Inherits="Sistema_Academico.recupear" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="FeaturedContent" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">
    <center>
<asp:Label ID="lblInformacion" runat="server" Text="Label"></asp:Label> 
        <br />
        <br />

        <asp:TextBox ID="txtRespuesta" runat="server" OnTextChanged="txtRespuesta_TextChanged"></asp:TextBox>
        &nbsp;&nbsp;
        <br />
        <br />
        <asp:Label ID="lblpassword" runat="server" Text="Password" Visible="False"></asp:Label>
&nbsp;
        <asp:TextBox ID="txtClave" runat="server" OnTextChanged="txtClave_TextChanged" Visible="False"></asp:TextBox>
        <br />
        <br />

<asp:Button ID="btnRegresar" runat="server" Text="Regresar"></asp:Button>
    &nbsp;&nbsp;
        <asp:Button ID="btnResponder" runat="server" OnClick="btnResponder_Click" Text="Responder" />
&nbsp;&nbsp;
        <asp:Button ID="btnPassword" runat="server" OnClick="btnPassword_Click" Text="Cambiar" Visible="False" />
    </center>
</asp:Content>
