<%@ Page Title="" Language="C#" MasterPageFile="~/Layouts/Navbar.Master" AutoEventWireup="true" CodeBehind="UpdateMenuType.aspx.cs" Inherits="FoodShop.Views.UpdateMenuType" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Update Menu Type</h1>
    <div>
        <asp:Label ID="LblName" runat="server" Text="Name : "></asp:Label>
        <asp:TextBox ID="nameTB" runat="server"></asp:TextBox>
    </div>
    <div>
        <asp:Button ID="BtnUpdate" runat="server" Text="Update" OnClick="BtnUpdate_Click" />
        <asp:Button ID="backBtn" runat="server" Text="Back" OnClick="backBtn_Click" />
    </div>
    <asp:Label ID="ErrorLbl" runat="server" Text=""></asp:Label>
</asp:Content>
