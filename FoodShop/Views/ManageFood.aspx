<%@ Page Title="" Language="C#" MasterPageFile="~/Layouts/Navbar.Master" AutoEventWireup="true" CodeBehind="ManageFood.aspx.cs" Inherits="FoodShop.Views.ManageFood" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Manage Page</h1>
<hr />
<h1>Menu List</h1>
<div>
    <asp:GridView ID="ManageMenu" runat="server" AutoGenerateColumns="False" OnRowDeleting="ManageMenu_RowDeleting" OnRowEditing="ManageMenu_RowEditing">
        <Columns>
            <asp:BoundField DataField="MenuName" HeaderText="Name" SortExpression="MenuName" />
            <asp:BoundField DataField="MenuPrice" HeaderText="Price" SortExpression="MenuPrice" />
            <asp:BoundField DataField="MenuType.MenuTypeName" HeaderText="Type" SortExpression="MenuType.MenuTypeName" />
            <asp:BoundField DataField="Restaurant.RestaurantName" HeaderText="Restaurant" SortExpression="Restaurant.RestaurantName" />
            <asp:CommandField ShowCancelButton="False" ShowDeleteButton="True" ShowEditButton="True" ButtonType="Button" ShowHeader="True" HeaderText="Action"></asp:CommandField>
        </Columns>
    </asp:GridView>
    <br />
    <asp:Button ID="InsertMenuBtn" runat="server" Text="Insert Menu" OnClick="InsertMenuBtn_Click" />
</div>


<hr />
<h1>Menu Type</h1>
<div>
    <asp:GridView ID="MenuTypeGV" runat="server" AutoGenerateColumns="False" OnRowDeleting="MenuTypeGV_RowDeleting" OnRowEditing="MenuTypeGV_RowEditing">
        <Columns>
            <asp:BoundField DataField="MenuTypeName" HeaderText="MenuTypeName" SortExpression="MenuTypeName" />
            <asp:CommandField ShowCancelButton="False" ShowDeleteButton="True" ShowEditButton="True" ButtonType="Button" ShowHeader="True" HeaderText="Action"></asp:CommandField>
        </Columns>

    </asp:GridView>
    <br />
    <asp:Button ID="InsertTypeBtn" runat="server" Text="Insert Menu Type" OnClick="InsertTypeBtn_Click" />
</div>

<hr />
<h1>Restaurant</h1>
<div>
    <asp:GridView ID="RestaurantGV" runat="server" AutoGenerateColumns="False" OnRowDeleting="RestaurantGV_RowDeleting" OnRowEditing="RestaurantGV_RowEditing">
        <Columns>
            <asp:BoundField DataField="RestaurantName" HeaderText="RestaurantName" SortExpression="RestaurantName" />
            <asp:BoundField DataField="RestaurantRating" HeaderText="RestaurantRating" SortExpression="RestaurantRating" />
            <asp:CommandField ShowCancelButton="False" ShowDeleteButton="True" ShowEditButton="True" ButtonType="Button" ShowHeader="True" HeaderText="Action"></asp:CommandField>
        </Columns>
    </asp:GridView>
    <br />
    <asp:Button ID="InsertRestoBtn" runat="server" Text="Insert Restaurant" OnClick="InsertRestoBtn_Click" />
</div>
</asp:Content>
