<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MemberLogin.aspx.cs" Inherits="Restaurant.Account.MemberLogin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        <h2>Member Login</h2>
        <p>
            <asp:Label ID="UsernameLabel" runat="server" Text="Username:"></asp:Label>
            <asp:TextBox ID="UsernameTextBox" runat="server"></asp:TextBox>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="errorLogin" runat="server"></asp:Label>
            <br />
            <br />
            <asp:Label ID="PasswordLabel" runat="server" Text="password:"></asp:Label>&nbsp
            <asp:TextBox ID="PasswordTextBox" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:CheckBox ID="CheckBox1" runat="server" Text="Save Username and Password" />
            <br /><br />
            <asp:Button ID="LoginBtn" runat="server" Text="Login" OnClick="LoginBtn_Click" />
        </p>
            <p>
                New user? Please <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Account/MemberRegister.aspx">Register</asp:HyperLink></p>
            <p>
                <asp:Button ID="BackHomeBtn" runat="server" Text="Back Home" />
            </p>
        </div>
    </form>
</body>
</html>
