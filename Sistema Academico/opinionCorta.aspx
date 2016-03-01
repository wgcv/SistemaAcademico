<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="opinionCorta.aspx.cs" Inherits="Sistema_Academico.opinionCorta" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="FeaturedContent" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">
    <asp:Label ID="lblPregunta" runat="server" Text="Label"></asp:Label>
    <br />
    <br />
    <br />
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="4" ForeColor="Black" GridLines="Horizontal" ShowHeader="False">
        <Columns>
            <asp:BoundField DataField="usuario" ShowHeader="False" />
            <asp:BoundField DataField="respuesta" ShowHeader="False" />
        </Columns>
        <FooterStyle BackColor="#CCCC99" ForeColor="Black" />
        <HeaderStyle BackColor="#333333" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="White" ForeColor="Black" HorizontalAlign="Right" />
        <SelectedRowStyle BackColor="#CC3333" Font-Bold="True" ForeColor="White" />
        <SortedAscendingCellStyle BackColor="#F7F7F7" />
        <SortedAscendingHeaderStyle BackColor="#4B4B4B" />
        <SortedDescendingCellStyle BackColor="#E5E5E5" />
        <SortedDescendingHeaderStyle BackColor="#242121" />
    </asp:GridView>
    <br />
    <br />
    <asp:Label ID="lblMensaje" runat="server" Text="Debe ingresar para responder" Visible="False"></asp:Label>
    <asp:Panel ID="pnlResponder" runat="server" Visible="False">
        <asp:Label ID="Label2" runat="server" Text="Responder"></asp:Label>
        <br />
        <br />
        <asp:TextBox ID="TextBox1" runat="server" Height="146px" TextMode="MultiLine" Width="391px"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="btnEnviar" runat="server" OnClick="btnEnviar_Click" Text="Responder" />
    </asp:Panel>
</asp:Content>
