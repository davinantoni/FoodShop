<%@ Page Title="" Language="C#" MasterPageFile="~/Layouts/Navbar.Master" AutoEventWireup="true" CodeBehind="UpdateMenu.aspx.cs" Inherits="FoodShop.Views.UpdateMenu" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Update Menu Page</h1>
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
        <asp:Button ID="UpdateBtn" runat="server" Text="Update" OnClick="UpdateBtn_Click" />
        <asp:Button ID="BackBtn" runat="server" Text="Back" OnClick="BackBtn_Click" />
    </div>
    <asp:Label ID="ErrorLbl" runat="server" Text=""></asp:Label>
</asp:Content>
