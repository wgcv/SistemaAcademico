<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="forodetalle.aspx.cs" Inherits="Sistema_Academico.forodetalle" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="FeaturedContent" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">
    <center>
    <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        <br />
        <asp:Panel ID="pnlResponder" runat="server" Visible="False">
            <br />
            Responder:<br />
            <br />
&nbsp;<asp:TextBox ID="TextBox1" runat="server" Height="121px" TextMode="MultiLine" Width="358px"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Enviar" />
        </asp:Panel>
        </center>
</asp:Content>
