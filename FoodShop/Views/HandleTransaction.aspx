<%@ Page Title="" Language="C#" MasterPageFile="~/Layouts/Navbar.Master" AutoEventWireup="true" CodeBehind="HandleTransaction.aspx.cs" Inherits="FoodShop.Views.HandleTransaction" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Handle Transaction</h1>
    <asp:GridView ID="TransactionGV" runat="server" AutoGenerateColumns="false">
        <columns>
            <asp:BoundField DataField="TransactionID" HeaderText="TransactionID" SortExpression="TransactionID"></asp:BoundField>
            <asp:BoundField DataField="UserID" HeaderText="UserID" SortExpression="UserID"></asp:BoundField>
            <asp:BoundField DataField="TransactionDate" HeaderText="Date" SortExpression="TransactionDate"></asp:BoundField>
            <asp:BoundField DataField="Status" HeaderText="Status" SortExpression="TransactionStatus"></asp:BoundField>


            <asp:TemplateField HeaderText="Action">
                <itemtemplate>
                    <asp:Button ID="HandleButton" runat="server" Text="Handle Transaction" CommandArgument='<%# Eval("TransactionID") %>' OnClick="HandleButton_Click" Visible='<%# Eval("Status").ToString() == "Unhandled" %>' />
                </itemtemplate>
            </asp:TemplateField>

        </columns>
    </asp:GridView>
</asp:Content>
