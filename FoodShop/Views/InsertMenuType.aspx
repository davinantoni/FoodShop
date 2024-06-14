<%@ Page Title="" Language="C#" MasterPageFile="~/Layouts/Navbar.Master" AutoEventWireup="true" CodeBehind="InsertMenuType.aspx.cs" Inherits="FoodShop.Views.InsertMenuType" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Insert Menu Type</h1>
<div>
    <asp:Label ID="nameLbl" runat="server" Text="Name : "></asp:Label>
    <asp:TextBox ID="nameTB" runat="server"></asp:TextBox>
</div>
<div>
    <asp:Button ID="insertBtn" runat="server" Text="Insert" OnClick="insertBtn_Click" />
    <asp:Button ID="backBtn" runat="server" Text="Back" OnClick="backBtn_Click" />
</div>
<asp:Label ID="ErrorLbl" runat="server" Text=""></asp:Label>
</asp:Content>
