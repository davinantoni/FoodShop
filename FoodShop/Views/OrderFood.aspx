<%@ Page Title="" Language="C#" MasterPageFile="~/Layouts/Navbar.Master" AutoEventWireup="true" CodeBehind="OrderFood.aspx.cs" Inherits="FoodShop.Views.OrderFood" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Choose the Restaurant</h1>
    <asp:GridView ID="RestaurantGV" runat="server" AutoGenerateColumns="False">
        <Columns>
            <asp:BoundField DataField="RestaurantName" HeaderText="Name" SortExpression="RestaurantName" />
            <asp:BoundField DataField="RestaurantRating" HeaderText="Rating" SortExpression="RestaurantRating" />
            <asp:TemplateField HeaderText="Actions">
                <ItemTemplate>
                    <asp:Button ID="MenuButton" runat="server" Text="View Menu" CommandArgument='<%# Eval("RestaurantID") %>' OnClick="MenuButton_Click" />
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>

    </asp:GridView>
</asp:Content>
