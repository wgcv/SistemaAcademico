<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Sistema_Academico._Default" %>

<asp:Content runat="server" ID="FeaturedContent" ContentPlaceHolderID="FeaturedContent">
    <section class="featured">
        <div class="content-wrapper">
        </div>
    </section>
</asp:Content>
<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">
    <table style="width:100%;">
        <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td colspan="3" style="
    background: #555175;
    color: #fff;
    font-size: 2em;
">Noticias</td>
        </tr>
        <tr>
            <td class="auto-style2">
                <asp:LinkButton ID="noticiasl1" runat="server" OnClick="noticiasl1_Click">
                <asp:Image ID="noticiasimg1" runat="server" Width="250px" />
                <br />
                <asp:Label ID="noticiaslabel1" runat="server" Text="Label"></asp:Label>
                <br />
                    </asp:LinkButton>
            </td>
            <td class="auto-style2">
               <asp:LinkButton ID="noticiasl2" runat="server" OnClick="noticiasl2_Click">
                <asp:Image ID="noticiasimg2" runat="server" Width="250px" />
                <br />
                <asp:Label ID="noticiaslabel2" runat="server" Text="Label"></asp:Label>
                <br />
                    </asp:LinkButton>
            </td>
            <td class="auto-style2">
               <asp:LinkButton ID="noticiasl3" runat="server" OnClick="noticiasl3_Click">
                <asp:Image ID="noticiasimg3" runat="server" Width="250px" />
                <br />
                <asp:Label ID="noticiaslabel3" runat="server" Text="Label"></asp:Label>
                <br />
                    </asp:LinkButton>
            </td>
        </tr>
        <tr>
                      <td colspan="3" style="
    background: #555175;
    color: #fff;
    font-size: 2em;
">Eventos</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td><a href="/eventos.aspx">

                <asp:Image ID="eventosimg1" runat="server" Width="250px" />
                <br />
                <asp:Label ID="eventoslabel1" runat="server" Text="Label"></asp:Label>
                <br />
                </a>
            </td>
            <td>
                <a href="/eventos.aspx">
                <asp:Image ID="eventosimg2" runat="server"  Width="250px"/>
                <br />
                <asp:Label ID="eventoslabel2" runat="server" Text="Label"></asp:Label>
                <br />
                </a>
            </td>
            <td>
                <a href="/eventos.aspx">
                <asp:Image ID="eventosimg3" runat="server" Width="250px" />
                <br />
                <asp:Label ID="eventoslabel3" runat="server" Text="Label"></asp:Label>
                <br />
                    </a>
            </td>
        </tr>
        <tr>
                      <td colspan="3" style="
    background: #555175;
    color: #fff;
    font-size: 2em;
">Concursos</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>
                <a href="/concursos.aspx">
                 
                <asp:Image ID="concursosimg1" runat="server"  Width="250px"/>
                <br />
                <asp:Label ID="concursoslabel1" runat="server" Text="Label"></asp:Label>
                <br />
                    </a>
            </td>
            <td>
                <a href="/concursos.aspx">
                <asp:Image ID="concursosimg2" runat="server" Width="250px" />
                <br />
                <asp:Label ID="concursoslabel2" runat="server" Text="Label"></asp:Label>
                <br />
                    </a>
            </td>
            <td>
                  <a href="/concursos.aspx">
                <asp:Image ID="concursosimg3" runat="server" Width="250px" />
                <br />
                <asp:Label ID="concursoslabel3" runat="server" Text="Label"></asp:Label>
                <br />
                      </a>
            </td>
        </tr>
        <tr>
                      <td colspan="3" style="
    background: #555175;
    color: #fff;
    font-size: 2em;
">Opinion</td>
            <td class="auto-style1"></td>
            <td class="auto-style1"></td>
        </tr>
        <tr>
            <td colspan="3">
                <center>
                <asp:Label ID="lblopinion" runat="server" Text="Label" style="font-size: 1.5em;font-weight: 600;"></asp:Label>
            </center>
                    </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Opinion1" runat="server" Text="Label"></asp:Label>
            </td>
            <td>
                <asp:Label ID="Opinion2" runat="server" Text="Label"></asp:Label>
            </td>
            <td>
                <asp:Label ID="Opinion3" runat="server" Text="Label"></asp:Label>
            </td>
        </tr>
        <tr>
                      <td colspan="3" style="
    background: #555175;
    color: #fff;
    font-size: 2em;
">Foros</td>
            <td ></td>
            <td></td>
        </tr>
        <tr>
            <td>
                 <asp:LinkButton ID="forol1" runat="server" OnClick="forol1_Click">
                                <asp:Label ID="forolabel1" runat="server" Text="Label"></asp:Label>

                    </asp:LinkButton>
            </td>
            <td>
 <asp:LinkButton ID="forol2" runat="server" OnClick="forol2_Click">
                                <asp:Label ID="forolabel2" runat="server" Text="Label"></asp:Label>

                    </asp:LinkButton>            </td>
            <td >
               <asp:LinkButton ID="forol3" runat="server" OnClick="forol3_Click">
                                <asp:Label ID="forolabel3" runat="server" Text="Label"></asp:Label>

                    </asp:LinkButton>
            </td>
        </tr>
        <tr>
                      <td colspan="3" style="
    background: #555175;
    color: #fff;
    font-size: 2em;
">Encuesta</td>
            <td>&nbsp;</td>
            <td >&nbsp;</td>
        </tr>
        <tr>
            <td><a href="/encuesta.aspx">Resuelve la encuesta</a></td>
            <td >&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
    </table>
</asp:Content>
<asp:Content ID="Content1" runat="server" contentplaceholderid="HeadContent">
    
    <style type="text/css">
        .auto-style1 {
            height: 22px;
        }
        .auto-style2 {
            height: 13px;
        }
    </style>
    
</asp:Content>

