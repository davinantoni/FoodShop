<%@ Page Title="" Language="C#" MasterPageFile="~/Layouts/Navbar.Master" AutoEventWireup="true" CodeBehind="InsertRestaurant.aspx.cs" Inherits="FoodShop.Views.InsertRestaurant" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Insert Restaurant</h1>
    <div>
        <asp:Label ID="nameLbl" runat="server" Text="Name : "></asp:Label>
        <asp:TextBox ID="nameTB" runat="server"></asp:TextBox>
    </div>
    <div>
        <asp:Label ID="ratingLbl" runat="server" Text="Rating : "></asp:Label>
        <asp:TextBox ID="ratingTB" runat="server"></asp:TextBox>
    </div>
    <div>
        <asp:Button ID="insertBtn" runat="server" Text="Insert" OnClick="insertBtn_Click" />
        <asp:Button ID="backBtn" runat="server" Text="Back" OnClick="backBtn_Click" />
    </div>
    <asp:Label ID="ErrorLbl" runat="server" Text=""></asp:Label>
</asp:Content>
