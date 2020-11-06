<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Get.aspx.cs" Inherits="RESTfulAPI.View.Get" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1>Get</h1>
    <asp:Label ID="lblServer" runat="server" Text="Server:"></asp:Label>
    <br />
    <asp:TextBox ID="txtServer" runat="server"></asp:TextBox>
    <br />
    <asp:Label ID="lblParameter" runat="server" Text="Parameter:"></asp:Label>
    <br />
    <asp:TextBox ID="txtParameter" runat="server"></asp:TextBox>
    <br />
    <asp:Button ID="btnRun" runat="server" Text="Ausführen" OnClick="btnRun_Click" />
    <br />
    <asp:TextBox ID="txtResponse" runat="server" Rows="10" TextMode="MultiLine"></asp:TextBox>
</asp:Content>
