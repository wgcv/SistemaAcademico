<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="encuesta.aspx.cs" Inherits="Sistema_Academico.encuesta" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="FeaturedContent" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">
<center><h1>Encuesta</h1>
    <p>
        <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
    </p>
        </center>  
    <p>
    </p>
    <asp:Panel ID="Panel1" runat="server">
    </asp:Panel>
    <br />
    &nbsp;&nbsp;&nbsp;
    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Contestar" />
  
</asp:Content>
