<%@ Page Title="" Language="C#" MasterPageFile="~/Layouts/Navbar.Master" AutoEventWireup="true" CodeBehind="UpdateRestaurant.aspx.cs" Inherits="FoodShop.Views.UpdateRestaurant" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Update Restaurant</h1>
    <div>
        <asp:Label ID="LblName" runat="server" Text="Name : "></asp:Label>
        <asp:TextBox ID="nameTB" runat="server"></asp:TextBox>
    </div>
    <div>
        <asp:Label ID="LblRating" runat="server" Text="Rating : "></asp:Label>
        <asp:TextBox ID="ratingTB" runat="server"></asp:TextBox>
    </div>

    <div>
        <asp:Button ID="BtnUpdate" runat="server" Text="Update" OnClick="BtnUpdate_Click" />
        <asp:Button ID="backBtn" runat="server" Text="Back" OnClick="backBtn_Click" />
    </div>
    <asp:Label ID="ErrorLbl" runat="server" Text=""></asp:Label>
</asp:Content>
