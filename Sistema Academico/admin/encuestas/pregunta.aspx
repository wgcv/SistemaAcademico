<%@ Page Title="" Language="C#" MasterPageFile="~/admin/admin.Master" AutoEventWireup="true" CodeBehind="pregunta.aspx.cs" Inherits="Sistema_Academico.admin.encuestas.pregunta" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
    <style type="text/css">
    .auto-style1 {
        height: 22px;
    }
    .auto-style2 {
        height: 26px;
    }
</style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="FeaturedContent" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">
    <table style="width:100%;">
        <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>Pregunta</td>
            <td>
                <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
                    <asp:ListItem Value="abierta">Abierta</asp:ListItem>
                    <asp:ListItem Value="cerrada">Cerrada</asp:ListItem>
                </asp:DropDownList>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style2"></td>
            <td class="auto-style2">
                <asp:TextBox ID="txtPregunta" runat="server"></asp:TextBox>
            </td>
            <td class="auto-style2"></td>
        </tr>
        <tr>
            <td class="auto-style1"></td>
            <td class="auto-style1">
                <asp:Panel ID="Panel1" runat="server" Visible="False">
                    Respuestas:<br />
                    <br />
                    <asp:TextBox ID="txtR1" runat="server"></asp:TextBox>
                    <br />
                    <br />
                    <asp:TextBox ID="txtR2" runat="server"></asp:TextBox>
                    <br />
                    <br />
                    <asp:TextBox ID="txtR3" runat="server"></asp:TextBox>
                    <br />
                    <br />
                    <asp:TextBox ID="txtR4" runat="server"></asp:TextBox>
                    <br />
                    <br />
                    <asp:TextBox ID="txtR5" runat="server"></asp:TextBox>
                </asp:Panel>
            </td>
            <td class="auto-style1"></td>
        </tr>
        <tr>
            <td class="auto-style1">&nbsp;</td>
            <td class="auto-style1">
                <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Siguiente" />
            </td>
            <td class="auto-style1">&nbsp;</td>
        </tr>
    </table>
</asp:Content>
