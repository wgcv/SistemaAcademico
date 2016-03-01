<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="noticiasdetalle.aspx.cs" Inherits="Sistema_Academico.noticiasdetalle" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="FeaturedContent" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">
   
    <center>
     <asp:Label ID="lblTitulo" runat="server" style="font-weight: 700;font-size: 2em;color: #696969;"></asp:Label>
        <br />
        <br />
    <asp:Image ID="imgNoticia" runat="server" />
        <br />
    <br />
        </center>

    <br />
    <asp:Label ID="lblDescripcion" runat="server"></asp:Label>
    <br />
    <br />
    <asp:Panel ID="Panel2" runat="server">
        <asp:Label ID="Label4" runat="server" Text="Califiación"></asp:Label>
        <br />
        <asp:Image ID="estrellas" runat="server" style="width: 15%;" ImageUrl="~/calificacion/c1.png" />
    </asp:Panel>
    <br />
    <asp:Panel ID="pnlCalificacion" runat="server" Visible="False">
        <asp:Label ID="Label3" runat="server" Text="Califique la noticia"></asp:Label>
        <br />
        <asp:DropDownList ID="DropDownList1" runat="server">
            <asp:ListItem Value="5">Excelente</asp:ListItem>
            <asp:ListItem Value="4">Muy Buena</asp:ListItem>
            <asp:ListItem Value="3">Buena</asp:ListItem>
            <asp:ListItem Value="2">Regular</asp:ListItem>
            <asp:ListItem Value="1">Mala</asp:ListItem>
        </asp:DropDownList>
        &nbsp;<asp:Button ID="btnCalificar" runat="server" Text="Calificar" OnClick="btnCalificar_Click" />
    </asp:Panel>

</asp:Content>
