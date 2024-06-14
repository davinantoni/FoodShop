<%@ Page Title="" Language="C#" MasterPageFile="~/Layouts/Navbar.Master" AutoEventWireup="true" CodeBehind="TransactionDetails.aspx.cs" Inherits="FoodShop.Views.TransactionDetails" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Transaction Detail</h1>
    <asp:GridView ID="TransactionDetailGV" runat="server" AutoGenerateColumns="False">
        <Columns>
            <asp:BoundField DataField="TransactionID" HeaderText="TransactionID" SortExpression="TransactionID"></asp:BoundField>
            <asp:BoundField DataField="MenuID" HeaderText="MenuID" SortExpression="MenuID"></asp:BoundField>
            <asp:BoundField DataField="Menu.MenuName" HeaderText="MenuName" SortExpression="Menu.MenuName" />
            <asp:BoundField DataField="Quantity" HeaderText="Quantity" SortExpression="Quantity"></asp:BoundField>
        </Columns>
    </asp:GridView>
</asp:Content>
