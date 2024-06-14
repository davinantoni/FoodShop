<%@ Page Title="" Language="C#" MasterPageFile="~/Layouts/Navbar.Master" AutoEventWireup="true" CodeBehind="InsertMenu.aspx.cs" Inherits="FoodShop.Views.InsertMenu" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Insert Page</h1>
    <hr />
    <div>
        <asp:Label ID="NameLbl" runat="server" Text="Name : "></asp:Label>
        <asp:TextBox ID="NameTB" runat="server"></asp:TextBox>
    </div>
    <div>
        <asp:Label ID="PriceLbl" runat="server" Text="Price : "></asp:Label>
        <asp:TextBox ID="PriceTB" runat="server"></asp:TextBox>
    </div>
    <div>
        <asp:Label ID="MenuTypeIdLbl" runat="server" Text="Menu Type Name : "></asp:Label>
        <asp:DropDownList ID="MenuTypeDD" runat="server"></asp:DropDownList>
    </div>
    <div>
        <asp:Label ID="RestaurantIdLbl" runat="server" Text="Restaurant Name : "></asp:Label>
        <asp:DropDownList ID="RestaurantDD" runat="server"></asp:DropDownList>
    </div>
    <br />
    <div>
        <asp:Button ID="insertBtn" runat="server" Text="Insert" OnClick="insertBtn_Click" />
        <asp:Button ID="backBtn" runat="server" Text="Back" OnClick="backBtn_Click" />
    </div>
    <asp:Label ID="ErrorLbl" runat="server" Text=""></asp:Label>
</asp:Content>
