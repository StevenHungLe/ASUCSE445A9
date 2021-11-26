<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MemberRegister.aspx.cs" Inherits="Restaurant.Account.MemberRegister" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>
            Register a new member
     </h2>
    <p>
        
        <asp:Label ID="UsernameLabel" runat="server" Text="Username :"></asp:Label> &nbsp;&nbsp;
            <asp:TextBox ID="UsernameTextBox" runat="server"></asp:TextBox>
        <asp:Label ID="UserErrorLabel" runat="server" Font-Italic="True" ForeColor="#3366CC"></asp:Label>
        <br />
        <br />
        <asp:Label ID="PasswordLabel" runat="server" Text="Password :&nbsp; "></asp:Label> &nbsp;&nbsp;
            <asp:TextBox ID="PasswordTextBox" runat="server" TextMode="Password"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="ConfirmLabel" runat="server" Text="Confirm    : &nbsp;&nbsp;"></asp:Label> &nbsp;&nbsp;
            <asp:TextBox ID="ConfirmTextBox" runat="server" TextMode="Password"></asp:TextBox>
            <asp:Label ID="PwdErrorLabel" runat="server" Font-Italic="True" ForeColor="#3366CC"></asp:Label>
        <br />
        <br />
        <asp:Image ID="Image" runat="server" />
        <asp:Button ID="GetNewImageBtn" runat="server" Text="Get New Image" OnClick="GetNewImageBtn_Click"  />
        <br />
        <br />
    Please enter the text above into the following textbox
        <br />
        <asp:TextBox ID="StringTextBox" runat="server"></asp:TextBox>
        <asp:Label ID="StrErrLabel" runat="server" Text="" Font-Italic="True" ForeColor="#3366CC"></asp:Label>
    </p>
    
        
        <asp:Button ID="RegisterButton" runat="server" Text="Register an Account" OnClick="RegisterButton_Click" />
            <asp:Button ID="LoginButton" runat="server" Text="Login" />
            <asp:Button ID="HomeButton" runat="server" Text="Back Home" />
    
    <p>
        
        &nbsp;</p>
        </div>
    </form>
</body>
</html>
