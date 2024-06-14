<%@ Page Title="" Language="C#" MasterPageFile="~/Layouts/Navbar.Master" AutoEventWireup="true" CodeBehind="TransactionHistory.aspx.cs" Inherits="FoodShop.Views.TransactionHistory" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Transaction History</h1>
    <asp:GridView ID="TransactionGV" runat="server" AutoGenerateColumns="false">
        <columns>
            <asp:BoundField DataField="TransactionID" HeaderText="TransactionID" SortExpression="TransactionID"></asp:BoundField>
            <asp:BoundField DataField="UserID" HeaderText="UserID" SortExpression="UserID"></asp:BoundField>
            <asp:BoundField DataField="TransactionDate" HeaderText="Date" SortExpression="TransactionDate"></asp:BoundField>
            <asp:BoundField DataField="Status" HeaderText="Status" SortExpression="TransactionStatus"></asp:BoundField>


            <asp:TemplateField HeaderText="Transaction Detail">
                <itemtemplate>
                    <asp:Button ID="DetailButton" runat="server" Text="View Details" CommandArgument='<%# Eval("TransactionID") %>' OnClick="DetailButton_Click" />
                </itemtemplate>
            </asp:TemplateField>

        </columns>
    </asp:GridView>
</asp:Content>
