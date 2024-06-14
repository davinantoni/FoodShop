<%@ Page Title="" Language="C#" MasterPageFile="~/Layouts/Navbar.Master" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="FoodShop.Views.Register" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Register Page</h1>
    <div>
        <asp:Label ID="nameLbl" runat="server" Text="Name : "></asp:Label>
        <asp:TextBox ID="nameTB" runat="server"></asp:TextBox>
    </div>
    <div>
        <asp:Label ID="emailLbl" runat="server" Text="Email : "></asp:Label>
        <asp:TextBox ID="emailTB" runat="server"></asp:TextBox>
    </div>
    <div>
        <asp:Label ID="genderLbl" runat="server" Text="Gender : "></asp:Label>
        <asp:RadioButtonList ID="genderList" runat="server">
            <asp:ListItem>Male</asp:ListItem>
            <asp:ListItem>Female</asp:ListItem>
        </asp:RadioButtonList>
    </div>
    <div>
        <asp:Label ID="passwordLbl" runat="server" Text="Password : "></asp:Label>
        <asp:TextBox ID="passwordTB" runat="server" TextMode="Password"></asp:TextBox>
    </div>
    <div>
        <asp:Label ID="confirmLbl" runat="server" Text="Confirm Password : "></asp:Label>
        <asp:TextBox ID="confirmTB" runat="server" TextMode="Password"></asp:TextBox>
    </div>
    <div>
        <asp:Label ID="DOBLbl" runat="server" Text="Date Of Birth : "></asp:Label>
        <asp:Calendar ID="dobCalendar" runat="server"></asp:Calendar>
    </div>

    <asp:Button ID="RegisterButton" runat="server" Text="Register" OnClick="RegisterButton_Click" />
    <asp:HyperLink ID="LoginLink" runat="server" NavigateUrl="~/Views/Login.aspx" Text="Already have an account? Login Here!" />
    <div>
        <asp:Label ID="ErrorLbl" runat="server" Text="" ForeColor="Red"></asp:Label>
    </div>
</asp:Content>
