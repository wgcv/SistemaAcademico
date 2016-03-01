<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="documentos.aspx.cs" Inherits="Sistema_Academico.documentos" %>
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
        <br />
        <asp:Panel ID="pnlSubir" runat="server" Visible="False">
           <h1 style="color:#808080"> Sube tu archivo</h1>Categoria:
            <asp:DropDownList ID="DropDownList1" runat="server">
                <asp:ListItem>Artículo</asp:ListItem>
                <asp:ListItem>Comunicación</asp:ListItem>
                <asp:ListItem>Noticia</asp:ListItem>
                <asp:ListItem>Paper Cientifico</asp:ListItem>
            </asp:DropDownList>
            &nbsp;&nbsp; Titulo:
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            &nbsp;&nbsp;&nbsp; Archivo:
            <asp:FileUpload ID="FileUpload1" runat="server" />
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Subir" />
            <br />
        </asp:Panel>
        <asp:Label ID="lblMensaje" runat="server"></asp:Label>
        <br />
        <br />
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
