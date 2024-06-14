<%@ Page Title="" Language="C#" MasterPageFile="~/Layouts/Navbar.Master" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="FoodShop.Views.Home" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Home Page</h1>
    <asp:Label ID="UserRoleLabel" runat="server"></asp:Label><br />
    <asp:Label ID="UserNameLabel" runat="server"></asp:Label>
    <asp:GridView ID="CustomerGV" runat="server" AutoGenerateColumns="False">
        <Columns>
            <asp:BoundField DataField="UserID" HeaderText="ID" SortExpression="UserID" />
            <asp:BoundField DataField="Username" HeaderText="Username" SortExpression="Username" />
            <asp:BoundField DataField="UserEmail" HeaderText="User Email" SortExpression="UserEmail" />
            <asp:BoundField DataField="UserDOB" HeaderText="User DOB" SortExpression="UserDOB" />
            <asp:BoundField DataField="UserGender" HeaderText="User Gender" SortExpression="UserGender" />
            <asp:BoundField DataField="UserRole" HeaderText="User Role" SortExpression="UserRole" />
            <asp:BoundField DataField="UserPassword" HeaderText="User Password" SortExpression="UserPassword" />
        </Columns>
    </asp:GridView>
</asp:Content>
