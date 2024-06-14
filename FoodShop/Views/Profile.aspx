<%@ Page Title="" Language="C#" MasterPageFile="~/Layouts/Navbar.Master" AutoEventWireup="true" CodeBehind="Profile.aspx.cs" Inherits="FoodShop.Views.Profile" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
        <h2>Update Profile</h2>
        <asp:Label ID="ErrorLbl" runat="server" Text=""></asp:Label>
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
            <asp:Label ID="DOBLbl" runat="server" Text="Date Of Birth : "></asp:Label>
            <asp:Calendar ID="dobCalendar" runat="server"></asp:Calendar>
        </div>
        <br />
        <asp:Button ID="UpdateProfileBtn" runat="server" Text="Update Profile" OnClick="UpdateProfileBtn_Click" />
    </div>

    <div>
        <h2>Change Password</h2>
        <asp:Label ID="PwdErrorMsg" runat="server" ForeColor="Red"></asp:Label>
        <asp:TextBox ID="OldPasswordTB" runat="server" TextMode="Password" Placeholder="Old Password"></asp:TextBox>
        <asp:TextBox ID="NewPasswordTB" runat="server" TextMode="Password" Placeholder="New Password"></asp:TextBox>
        <asp:Button ID="UpdatePasswordBtn" runat="server" Text="Update Password" OnClick="UpdatePasswordBtn_Click" />
    </div>
    <asp:Label ID="ErrorLbl2" runat="server" Text=""></asp:Label>
</asp:Content>
