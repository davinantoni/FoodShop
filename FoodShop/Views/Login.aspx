<%@ Page Title="" Language="C#" MasterPageFile="~/Layouts/Navbar.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="FoodShop.Views.Login" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Login Page</h1>
    <div>
        <asp:Label runat="server" Text="Username : "></asp:Label>
        <asp:TextBox ID="nameTB" runat="server"></asp:TextBox>
    </div>
    <div>
        <asp:Label ID="passwordLbl" runat="server" Text="Password : "></asp:Label>
        <asp:TextBox ID="passwordTB" runat="server" TextMode="Password"></asp:TextBox>
    </div>
    <div>
        <asp:CheckBox ID="termsCB" runat="server"></asp:CheckBox>
        <asp:Label runat="server" Text="Remember Me"></asp:Label>
    </div>
    <div>
        <asp:Button ID="loginBtn" runat="server" Text="Login" OnClick="loginBtn_Click" />
        <asp:HyperLink ID="RegisterLink" runat="server" NavigateUrl="~/Views/Register.aspx" Text="Don't have an account? Register Here!" />
    </div>
    <asp:Label ID="ErrorLbl" runat="server" Text=""></asp:Label>
</asp:Content>
