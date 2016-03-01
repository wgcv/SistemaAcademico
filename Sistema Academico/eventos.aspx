<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="eventos.aspx.cs" Inherits="Sistema_Academico.eventos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="FeaturedContent" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">
    <center>   <asp:Label ID="lblTabla" runat="server"></asp:Label>
        <br />
        <br />
          </center>
    <center>
        <asp:Panel ID="Panel1" runat="server" style="background: #555175;padding: 1em;color: #fff;width: 60%;text-align: center;">
            Suscríbete<br />
            <br />
            Nombre
            <asp:TextBox ID="txtNombre" runat="server"></asp:TextBox>
            &nbsp;&nbsp; Correo&nbsp;
            <asp:TextBox ID="txtCorreo" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="btnSuscribirce" runat="server" OnClick="btnSuscribirce_Click" Text="Suscribirse" />
    </asp:Panel>
  </center>
</asp:Content>
