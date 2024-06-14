<%@ Page Title="" Language="C#" MasterPageFile="~/Layouts/Navbar.Master" AutoEventWireup="true" CodeBehind="ViewMenu.aspx.cs" Inherits="FoodShop.Views.ViewMenu" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Menu</h1>
    <asp:GridView ID="OrderGV" runat="server" AutoGenerateColumns="False">
        <Columns>
            <asp:BoundField DataField="MenuName" HeaderText="Name" SortExpression="MenuName" />
            <asp:BoundField DataField="MenuPrice" HeaderText="Price" SortExpression="MenuPrice" />
            <asp:BoundField DataField="MenuType.MenuTypeName" HeaderText="Type" SortExpression="MenuType.MenuTypeName" />
            <asp:BoundField DataField="Restaurant.RestaurantName" HeaderText="Restaurant" SortExpression="Restaurant.RestaurantName" />
            <asp:TemplateField HeaderText="Quantity">
                <ItemTemplate>
                    <asp:TextBox ID="quantityTB" TextMode="Number" runat="server" />
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Actions">
                <ItemTemplate>
                    <asp:Button ID="OrderButton" runat="server" Text="Order" CommandArgument='<%# Eval("MenuID") %>' OnClick="OrderButton_Click" />
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>
    </asp:GridView>
    <asp:Label ID="MessageLabel" runat="server" ForeColor="Red" />
    <br />


    <h1>Your Cart</h1>
    <asp:GridView ID="CartGV" runat="server" AutoGenerateColumns="False">
        <Columns>
            <asp:BoundField DataField="Menu.MenuName" HeaderText="Name" SortExpression="Menu.MenuName" />
            <asp:BoundField DataField="Menu.MenuPrice" HeaderText="Price" SortExpression="Menu.MenuPrice" />
            <asp:BoundField DataField="Quantity" HeaderText="Quantity" SortExpression="Quantity" />
        </Columns>
    </asp:GridView>
    <br />
    <asp:Button ID="ClearCartButton" runat="server" Text="Clear Cart" CommandArgument='<%# Eval("CartID") %>' OnClick="ClearCartButton_Click" />
    <asp:Button ID="CheckoutButton" runat="server" Text="Checkout" OnClick="CheckoutButton_Click" />
    <br />
    <asp:Label ID="MessageLabel2" runat="server" ForeColor="Red" />
</asp:Content>
